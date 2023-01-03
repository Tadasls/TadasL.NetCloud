using Microsoft.AspNetCore.Routing;
using PressentC.Service.IService;
using PressentConnection;
using PressentConnection.Data;
using System.Diagnostics;
using static PressentConnection.Program;

namespace PressentC.Service
{
    public class OptimizationService : IOptimizationService
    {
        public OptimizationService()
        {
        }

        private readonly DataBaseContext _db;
        public OptimizationService(DataBaseContext db)
        {
            _db = db;
           
        }

        public async Task PaleidimoMetodas()
        {
            var stopwatch = Stopwatch.StartNew();
            int projektuSkaicius = 10000, useriuSkaicius = 2000;
            var projects = await GenerateProjectsAsync(projektuSkaicius); // project
            var roots = await  GenerateRootsAsync(useriuSkaicius); // users/tenant
            Console.WriteLine($"Duomenu baze su {projektuSkaicius} įrašų su naujais {useriuSkaicius} irasais sukurta per ms: [{stopwatch.Elapsed}] ");
            
            stopwatch = Stopwatch.StartNew();
            UpdateRoot(projects, roots);
            Console.WriteLine($"Duomenu baze su {projektuSkaicius} įrašų atnaujinta su naujais {useriuSkaicius} irasais per ms: [{stopwatch.Elapsed}] ");
        }

        public void UpdateRoot(List<Project>projects, List<Root>roots)
        {
        
            Dictionary<string, string> principalNameToIdMap = roots
                .SelectMany(r => r.tenants.Select(t => new { t.userPrincipalName, r.id }))
                .ToDictionary(x => x.userPrincipalName, x => x.id);

            foreach (var project in projects)
            {
                if (principalNameToIdMap.TryGetValue(project.PartitionKey, out var id))
                {
                    project.PartitionKey = id;
                }
            }
        }


        public async Task<List<Project>> GenerateProjectsAsync(int count)
        {
            var projects = new List<Project>();

            for (int i = 0; i < count; i++)
            {
                var project = new Project
                {
                    ID = "ID" + i,
                    PartitionKey = "user" + i + "@example.com"
                };

                projects.Add(project);
            }

            await _db.Projects.AddRangeAsync(projects);
            await _db.SaveChangesAsync();
            return projects;
        }

        public async Task<List<Root>> GenerateRootsAsync(int count)
        {
            var roots = new List<Root>();

            for (int i = 0; i < count; i++)
            {
                var root = new Root
                {
                    id = "ID" + i,
                    partitionKey = "user" + i + "@example.com",
                    tenants = new List<Tenant>
            {
                new Tenant
                {
                    tenant = "Tenant" + i,
                    userPrincipalName = "user" + i + "@example.com",
                    objectId = "object" + i,
                    emails = new List<Email>
                    {
                        new Email
                        {
                            email = "user" + i + "@example.com",
                            alternative = false
                        },
                        new Email
                        {
                            email = "user" + i + "_alt@example.com",
                            alternative = true
                        }
                    },
                    deleted = false
                }
            }
                };

                roots.Add(root);
            }

            await _db.Roots.AddRangeAsync(roots);
            await _db.SaveChangesAsync();
            return roots;
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
        //yra rysys Project.PartitionKey == Tenant.UserPrincipalName.
        // reikia pakeisti PartitionKey į Root.Id
        // yra rysis Project.PartitionKey == Tenant.UserPrincipalName






        public static void SprendimassuSQL()
        {

            //UPDATE Root
            //SET id = Project.PartitionKey
            //FROM Root
            //INNER JOIN Tenant ON Root.Tenant.UserPrincipalName = Tenant.UserPrincipalName
            //INNER JOIN Project ON Project.PartitionKey = Tenant.UserPrincipalName
        }






    }
}
