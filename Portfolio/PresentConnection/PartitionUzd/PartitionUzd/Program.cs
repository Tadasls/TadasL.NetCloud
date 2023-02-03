using Microsoft.EntityFrameworkCore;
using PartitionUzd.Database;
using PartitionUzd.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;

namespace PartitionUzd
{
    public class Program
    {

        static void Main(string[] args)
        {

            //Choose your test Numbers
            int projectsAmount = 1000000, usersAmount = 200000;


            var stopwatch = Stopwatch.StartNew();
            var roots = FillDatabaseWithFakeDataWithUsers(usersAmount);
            Console.WriteLine($"DataBase with {usersAmount} new Fake Users data genereted in ms: [{stopwatch.Elapsed}] ");
           
            stopwatch = Stopwatch.StartNew();
            var projects = FillDatabaseWithFakeDataWithProjets(projectsAmount);
            Console.WriteLine($"DataBase with {projectsAmount} new Fake Projetcs data genereted in ms: [{stopwatch.Elapsed}] ");

            stopwatch = Stopwatch.StartNew();
             UpdateDataBaseWithSQL();
            //UpdateRootInObjects(projects, roots); in case of database fail
            Console.WriteLine($"DataBase Update Project.PartitionKey to Root.Id was made in ms: [{stopwatch.Elapsed}] ");
        }

        static public List<Project> FillDatabaseWithFakeDataWithProjets(int projektuSkaicius)
        {
            Console.WriteLine("Fake Projetcs data generation started ... !");
            var projects = new List<Project>();
            using (var context = new PCDBContext())
            {
                for (int i = 0; i < projektuSkaicius; i++)
                {
                    var project = new Project()
                    {
                        partitionKey = "partitionKey" + i.ToString()
                    };
                    context.Projects.Add(project);
                   // projects.Add(project); in case of database fail
                }         
                context.SaveChanges();
            }
            Console.WriteLine("Fake Projetcs Data generated!");

            return projects;

        }
        static public List<Root> FillDatabaseWithFakeDataWithUsers(int useriuSkaicius)
        {
            Console.WriteLine("Fake Users data generation started ... !");
            var roots = new List<Root>();
            var emails = new List<Email>();
            var tenants = new List<Tenant>();

            using (var context = new PCDBContext())
            {
                for (int i = 0; i < useriuSkaicius; i++)
                {
                    var mail = new Email()
                    {
                        email = i.ToString() + "@test.mail",
                        alternate = true
                    };
                    context.Emails.Add(mail);
                    //emails.Add(mail); in case of database fail

                    var tenant = new Tenant()
                    {
                        tenant = "tenant_" + i.ToString(),
                        userPrincipalName = "partitionKey" + i.ToString(),
                        objectId = i.ToString(),
                        emails = new List<Email>() { mail },
                        deleted = false
                    };
                    context.Tenants.Add(tenant);
                    // tenants.Add(tenant); in case of database fail

                    var root = new Root()
                    {
                        partitionKey = i.ToString(),
                        id = "Id-" + i.ToString(),
                        tenants = new List<Tenant>() { tenant }
                    };
                   context.Roots.Add(root);
                    // roots.Add(root); in case of database fail
                }
                context.SaveChanges();
            }
            Console.WriteLine("Fake Users Data generated!!");
            return roots;
        }

        static public void UpdateDataBaseWithSQL()
        {
            using (var context = new PCDBContext())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    context.Database.ExecuteSqlRaw(
                         @"UPDATE Projects SET Projects.partitionKey = Roots.id 
                            FROM Projects
			                JOIN Tenants ON Projects.partitionKey = Tenants.userPrincipalName 
                            JOIN Roots ON Roots.id  = Tenants.Rootid
                        "
                        );

                    context.SaveChanges();
                    dbContextTransaction.Commit();
                }
            }
        }
        public static void UpdateRootInObjects(List<Project> projects, List<Root> roots)
        {
            Dictionary<string, string> principalNameToIdMap = roots
                .SelectMany(r => r.tenants.Select(t => new { t.userPrincipalName, r.id }))
                .ToDictionary(x => x.userPrincipalName, x => x.id);

            foreach (var project in projects)
            {
                if (principalNameToIdMap.TryGetValue(project.partitionKey, out var id))
                {
                    project.partitionKey = id;
                }
            }
        }


        /*
Greta programavimo užduoties duodu ir optimizacijos užduotį. 
Nereikalingas programavimas bet reikalinga įdėja kaip išspręsti problema su geriausiu performance'u
Turime milijoną įrašų - objektas turi du properčius ID ir PartitionKey(pavadinikime tai Project)
Turime 200k įrasų kurio formatas prikabintas image. (pavadinkime tai User)
Užduotis - atnaujinti tą pirmą milijoną įrašų pakeičiant PartitionKey į Root.Id - Paieska,
kuri User naudoti turi būti daroma taip kad egzistuoja ryšys Project.PartitionKey == Tenant.UserPrincipalName.
Jei reikės patikslinimo sakykit.Bet čia užteks ir mažos kodo dalies arba bent jau loginės paieškos paaiskinimo
kuris duotų geriausia performance. 
       */
      
        // reikia pakeisti PartitionKey į Root.Id
        // yra rysis Project.PartitionKey == Tenant.UserPrincipalName


    }
}