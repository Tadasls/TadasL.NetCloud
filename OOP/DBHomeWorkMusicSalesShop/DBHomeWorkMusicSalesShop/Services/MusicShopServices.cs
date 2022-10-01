using DBHomeWorkMusicSalesShop.DataBase;
using DBHomeWorkMusicSalesShop.DTO;
using DBHomeWorkMusicSalesShop.Interfaces;
using DBHomeWorkMusicSalesShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBHomeWorkMusicSalesShop.Services
{

    public class MusicShopServices : IMusicShopServices
    {

        public static List<dynamic> perkamaDainos = new List<dynamic>();
        public static Customer PrisijungesUseris = new Customer();

        private readonly ChinookContext _dbKontekstas;
        private readonly ChinookRepository _manoDb;

        public MusicShopServices()
        {
            _dbKontekstas = new ChinookContext();
            _manoDb = new ChinookRepository(_dbKontekstas);
        }



        public void Run()
        {
            //Jei naudotojas yra jau prisijungęs jis neturėtų grįžti į šį langą nebent pats pasirenka atsijungti nuo tuometinės aktyvios paskyros.
            char meniu;
            while (true)
            {
                Console.Clear();
                Reset();

                Console.WriteLine("| #   FAKE MENIU press 1               | ");  //laikinas
                Console.WriteLine("| #   | Pasirinkimas :                | ");
                Console.WriteLine("| 1.  |   Prisijungti                 |  ");
                Console.WriteLine("| 2.  |   Registruotis                |  ");
                Console.WriteLine("| 3.  |   Darbuotojų Parinktys        |  ");
                Console.WriteLine("q. Quit");

                meniu = Console.ReadKey().KeyChar;

                switch (meniu)
                {
                    case '1':

                        StatistikosDarbuotojamsMeniu(); //testavimui
                       // PirmasKlientoPrisijungimoMetodas();
                        break;
                    case '2':
                        KlientoRegistracijosMetodas();
                        break;
                    case '3':
                        AdminAplinkosSecurityMetodas();
                        break;
                    case 'q':
                        Environment.Exit(0);
                        return;
                    case 'Q':
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("No such case");
                        break;
                }

                PauseScreen();

            }


        }



        //1
        public void PirmasKlientoPrisijungimoMetodas()
        {

            Console.Clear();
            Console.WriteLine("Show ID List");
            _manoDb.GetCustomers();

            List<long> idlist = new List<long>();
            foreach (var item in _dbKontekstas.Customers)
            {
                idlist.Add(item.CustomerId);
            }
            long idPasirinkimas;
            do
            {
                Console.WriteLine("Choose Your Id");
                idPasirinkimas = Convert.ToInt32(Console.ReadLine());

                if (idlist.Contains(idPasirinkimas)) 
                {
                    foreach (var item in _dbKontekstas.Customers)
                    {
                        if (item.CustomerId == idPasirinkimas) { PrisijungesUseris = item; }
                    }
                    PirkimoSistemosMetodas();
                } 
            } while (true);


        }
        public void PirkimoSistemosMetodas()
        {
            Console.Clear();
            Console.WriteLine("| #   | Pasirinkimas :                             | ");
            Console.WriteLine("| 1.  |   Peržiūrėti katalogą                      |  ");
            Console.WriteLine("| 2.  |   Įdėti į krepšelį                         |  ");
            Console.WriteLine("| 3.  |   Peržiūrėti krepšelį                      |  ");
            Console.WriteLine("| 4.  |   Peržiūrėti pirkimų istorija (Išrašai)    |  ");
            Console.WriteLine("q. Quit");

            char meniu;
            meniu = Console.ReadKey().KeyChar;

            switch (meniu)
            {
                case '1':
                    _manoDb.GetTracks();
                    RusiavimoPasirinkimoMetodas();
                    break;
                case '2':
                    KrepselioFormavimoMetodas();
                    break;
                case '3':
                    ViewBasket(); //todo
                    break;
                case '4':
                    SalesHistoryData(); //todo
                    break;
                case 'q':
                    Run();
                    return;
                case 'Q':
                    Run();
                    return;
                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }
        public void SalesHistoryData()
        {
            GautiKlientoAtaskaitasPagalKlientoID((int)PrisijungesUseris.CustomerId);
            Console.ReadKey();
            PirkimoSistemosMetodas();
        }
       


        public void RusiavimoPasirinkimoMetodas()
        {
            Console.WriteLine("| #   | Pasirinkimas :                   | ");
            Console.WriteLine("| Q.  |   Grįžti atgal                   |  ");
            Console.WriteLine("| O.  |   Rikiavimo langas               |  ");
            Console.WriteLine("| S.  |   Paieškos langas                |  ");

            char meniu;
            meniu = Console.ReadKey().KeyChar;

            switch (meniu)
            {
                case 'Q':
                    PirkimoSistemosMetodas();
                    break;
                case 'q':
                    PirkimoSistemosMetodas();
                    break;
                case 'O':
                    RikiavimoMetoduMeniu();
                    break;
                case 'o':
                    RikiavimoMetoduMeniu();
                    break;
                case 'S':
                    PaieskosMetoduMeniu();
                    break;
                case 's':
                    PaieskosMetoduMeniu();
                    break;

                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }
        public void PaieskosMetoduMeniu()
        {
            Console.WriteLine("| #   | Paieška :                                | ");
            Console.WriteLine("| 1.  |   Pagal Id                               |  ");
            Console.WriteLine("| 2.  |   Pagal Name                             |  ");
            Console.WriteLine("| 3.  |   Pagal Composer                         |  ");
            Console.WriteLine("| 4.  |   Pagal Genre                            |  ");
            Console.WriteLine("| 5.  |   Pagal Composer ir Album                |  ");
            Console.WriteLine("| 6.  |   Pagal Milliseconds (Mažiau nei X arba daugiau nei X)  |  ");

            char meniu;
            meniu = Console.ReadKey().KeyChar;
            switch (meniu)
            {
                case '1':
                    RastiDainaPagalIdMetodas();
                    break;
                case '2':
                    RastiDainaPagalName();
                    break;
                case '3':
                    RastiDainaPagalComposer();
                    break;
                case '4':
                    RastiDainaPagalGenre();
                    break;
                case '5':
                    Console.WriteLine("sarasas pagal Composer ir Album TODO  "); // to do
                    break;
                case '6':
                    Console.WriteLine(" Pagal Milliseconds (Mažiau nei X arba daugiau nei X TODO)   "); // to do
                    break;
                case 'q':
                    PirkimoSistemosMetodas();
                    break;
                case 'Q':
                    PirkimoSistemosMetodas();
                    break;
                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }
        public void RikiavimoMetoduMeniu()
        {
            Console.Clear();
            Console.WriteLine("| #   | Rikiavimas :                             | ");
            Console.WriteLine("| 1.  |   Pagal Name abecėlės tvarka             |  ");
            Console.WriteLine("| 2.  |   Pagal Name atvirkštine abecėlės tvarka |  ");
            Console.WriteLine("| 3.  |   Pagal Composer                         |  ");
            Console.WriteLine("| 4.  |   Pagal Genre                            |  ");
            Console.WriteLine("| 5.  |   Pagal Composer ir Album                |  ");

            char meniu;
            meniu = Console.ReadKey().KeyChar;

            switch (meniu)
            {
                case '1':
                    Console.WriteLine("sarasas pagal AZ "); 
                    RusiuotiDainaPagalMetoda(meniu);
                    RusiavimoPasirinkimoMetodas();
                    break;
                case '2':
                    Console.WriteLine("sarasas pagal ZA "); 
                    RusiuotiDainaPagalMetoda(meniu);
                    RusiavimoPasirinkimoMetodas();
                    break;
                case '3':
                    Console.WriteLine("sarasas pagal Composer  "); // to do
                    break;
                case '4':
                    Console.WriteLine("sarasas pagal Genre  "); // to do
                    break;
                case '5':
                    Console.WriteLine("sarasas pagal Composer ir Album   "); // to do
                    break;
                case 'q':
                    PirkimoSistemosMetodas();
                    break;
                case 'Q':
                    PirkimoSistemosMetodas();
                    break;

                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }

        //sales metodai
        public void KrepselioFormavimoMetodas()
        {
            Console.Clear();
            Console.WriteLine("| #   | Pasirinkimas :                             | ");
            Console.WriteLine("| 1.  | Rasti dainą pagal Id                       |  ");
            Console.WriteLine("| 2.  | Rasti dainą pagal pavadinimą               |  ");
            Console.WriteLine("| 3.  | Rasti dainas pagal albumo Id               |  ");
            Console.WriteLine("| 4.  | Rasti dainas pagal albumo pavadinimą       |  ");
            Console.WriteLine("q. Quit");
            
           
            char meniu;
            meniu = Console.ReadKey().KeyChar;
                Console.Clear();
            switch (meniu)
            {
                case '1':
                    RastiDainaPagalIdMetodas();
                    break;
                case '2':
                    RastiDainaPagalName();
                    break;
                case '3':
                    RastiDainaPagalAlbumID();
                    break;
                case '4':
                    RastiDainaPagalAlbumName();
                    break;
                case 'q':
                    Run();
                    return;
                case 'Q':
                    Run();
                    return;
                default:
                    Console.WriteLine("No such case");
                    break;
            }

        }
        public void PirkimoMetodoKomandos(List<dynamic> rastuDainuSaras)
        {
            Console.WriteLine("| #   | Pasirinkimas :                             | ");
            Console.WriteLine("| 1.  | 'q' - Grįžti atgal                      |  ");
            Console.WriteLine("| 2.  | 'y' - Įdeda į krepšelį visas rastas dainas            |  ");
            
            char meniu;
            meniu = Console.ReadKey().KeyChar;

            switch (meniu)
            {
                case 'q':
                    KrepselioFormavimoMetodas();
                    break;
                case 'Q':
                    KrepselioFormavimoMetodas();
                    break;
                case 'y':
                    IdetiPrekeIKrepselyMetodas(rastuDainuSaras); 
                    break;
                case 'Y':
                    IdetiPrekeIKrepselyMetodas(rastuDainuSaras);
                    break;
                default:
                    Console.WriteLine("No such case");
                    break;
            }

        } // pirmas
        public void IdetiPrekeIKrepselyMetodas(List<dynamic> rastuDainuSaras)
        {
            Console.WriteLine("Dainos X idedamos  i krepsely.... ");
            perkamaDainos.AddRange(rastuDainuSaras.ToArray());
            ViewBasket();
        }
        public void ViewBasket()
        {
            Console.Clear();
            Console.WriteLine("Krepselyje Yra sios Dainos:");
            if (perkamaDainos.Count() == 0)
            {
                Console.WriteLine("Krepselis tuscias");
                Console.ReadKey();
                PirkimoSistemosMetodas();

            }

            foreach (var track in perkamaDainos)
            {
                Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kaina}");
                //{track.Vardas},{track.Kompozitorius},{track.Zanras}, {track.Zanras.Name}, {track.Albumas}, {track.Albumas.Title}, {track.Trukme}, {track.Kaina}
            }
            PirkimoPatvirtinimoMetodoKomandos();
        }
        public void PirkimoPatvirtinimoMetodoKomandos()
        {
            Console.WriteLine("| #   | Pasirinkimas :                    | ");
            Console.WriteLine("| 1.  | 'q' - Grįžti atgal                |  ");
            Console.WriteLine("| 2.  | 'y' - Užbaigti pirkimą            |  ");

            char meniu;
            meniu = Console.ReadKey().KeyChar;

            switch (meniu)
            {
                case 'q':
                    KrepselioFormavimoMetodas();
                    break;
                case 'y':
                    SukurtiInvoiceMetodas();
                    break;

                default:
                    Console.WriteLine("No such case");
                    break;
            }

        }  //antras


        public void SukurtiInvoiceMetodas()
        {
            Console.Clear();

            Console.WriteLine("   Sugeneruotas INVOICE ");

            Console.WriteLine($"Name {PrisijungesUseris.FirstName}");
            Console.WriteLine($"LastName {PrisijungesUseris.LastName}");
            Console.WriteLine($"Adress {PrisijungesUseris.Address}");
            Console.WriteLine($"Phone {PrisijungesUseris.Phone}");
            Console.WriteLine($"Post Code {PrisijungesUseris.PostalCode}");

            Console.WriteLine();
            Console.WriteLine(" | #       | ID, Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | ");

            Console.WriteLine();
            double TotalBePVM = 0.0;
            foreach (var track in perkamaDainos)
            {
                Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras}, {track.Albumas}, {track.Trukme}, {track.Kaina}  ");
                TotalBePVM = TotalBePVM + track.Kaina;
            }

            Console.WriteLine();
            Console.WriteLine(TotalBePVM);
            Console.WriteLine(" Tax: 21%");
            double TotalSuPVM = TotalBePVM * 1.21;
            Console.WriteLine(TotalSuPVM);

            Console.WriteLine();
           
            GryzimoIMeniuMetodas();
        }
        public void GryzimoIMeniuMetodas()
        {
            Console.WriteLine(" 'q' - Grįžti atgal  ");
            char meniu = Console.ReadKey().KeyChar;
            switch (meniu)
            {
                case 'q':
                    KrepselioFormavimoMetodas();
                    break;
                case 'Q':
                    KrepselioFormavimoMetodas();
                    break;
                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }




        //dainu paieskos metodai
        public void RastiDainaPagalIdMetodas()
        {
            Console.WriteLine("Iveskite norimą Id   "); 
            int ieskomaPagal = Convert.ToInt32(Console.ReadLine());
            var rastuDainuSaras = _manoDb.GetTracksByID(ieskomaPagal);
            PirkimoMetodoKomandos(rastuDainuSaras.ToList());
        }
        public void RastiDainaPagalName()
        {
            Console.WriteLine("Iveskite norimą Name   ");
            string ieskomaPagal = Console.ReadLine();
            var rastuDainuSaras = _manoDb.GetTracksByName(ieskomaPagal);
            PirkimoMetodoKomandos(rastuDainuSaras.ToList());
        }
        public void RastiDainaPagalAlbumID()
        {
            Console.WriteLine("Iveskite norimą AlbumId  ");
            int ieskomaPagal = Convert.ToInt32(Console.ReadLine());
            var rastuDainuSaras = _manoDb.GetTracksByAlbumID(ieskomaPagal);
            PirkimoMetodoKomandos(rastuDainuSaras.ToList());
        }
        public void RastiDainaPagalAlbumName()
        {
            Console.WriteLine("Iveskite norimą Album Name   ");
            string ieskomaPagal = Console.ReadLine();
            var rastuDainuSaras = _manoDb.GetTracksByAlbumName(ieskomaPagal);
            PirkimoMetodoKomandos(rastuDainuSaras.ToList());
        }
        public void RastiDainaPagalComposer()
        {
            Console.WriteLine("Iveskite norimą Composer  ");
            string ieskomaPagal = Console.ReadLine();
            var rastuDainuSaras = _manoDb.GetTracksByAlbumName(ieskomaPagal);
            PirkimoMetodoKomandos(rastuDainuSaras.ToList());
        }
        public void RastiDainaPagalGenre()
        {
            Console.WriteLine("Iveskite norimą Genre Name   ");
            string ieskomaPagal = Console.ReadLine();
            var rastuDainuSaras = _manoDb.GetTracksByAlbumName(ieskomaPagal);
            PirkimoMetodoKomandos(rastuDainuSaras.ToList());
        }


        public void GautiKlientoAtaskaitasPagalKlientoID(int klientoId)
        {
             _manoDb.GetInvoices(klientoId);
        }
        //Rusiavimas
        public void RusiuotiDainaPagalMetoda(char meniu)
        {
            switch (meniu)
            {
                case '1':
                    var isrusiuotasDainuSarasasAZ = _manoDb.GetTracks();
                    Console.WriteLine(isrusiuotasDainuSarasasAZ);
                    break;
                case '2':
                    var isrusiuotasDainuSarasasZA = _manoDb.GetTracksSorted();
                    Console.WriteLine(isrusiuotasDainuSarasasZA);
                    break;

                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }


        //2
        public void KlientoRegistracijosMetodas()
        {

            //Pasirinkus "Registruotis" vartotojas turėtų įvesti visus privalomus ir pasirinktinai optional Customer laukus.
            //Jei registracija buvo sėkminga turėtų atsirasti naujas įrašas Customers lentelėje,
            //jei registracija nepavyko turėtų atsirasti pranešimas su žinute kodėl registracija nepavyko
            //ir būtų liepiama atnaujinti klaidą išmetusius laukus neišeinant iš registracijos lango.


            bool pirmasLaukasUzpildytas = false;
            bool antrasLaukasUzpildytas = false;

            // TO DO  

            Console.WriteLine("Iveskite kliento varda");
            string FirstName = Console.ReadLine();
            if (FirstName != null) { pirmasLaukasUzpildytas = true; }
            Console.WriteLine("Iveskite kliento Pavarde");
            string LastName = Console.ReadLine();
            if (FirstName != null) { antrasLaukasUzpildytas = true; }
            Console.WriteLine("Iveskite kliento Kompanija");
            string? Company = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Adresa");
            string? Address = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Miesta");
            string? City = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Valstija");
            string? State = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Saly");
            string? Country = Console.ReadLine();
            Console.WriteLine("Iveskite kliento PastoKoda");
            string? PostalCode = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Telefona");
            string? Phone = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Faxa");
            string? Fax = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Emaila");
            string Email = Console.ReadLine();


            do
            {
                if (!pirmasLaukasUzpildytas)
                {
                    Console.WriteLine("Iveskite kliento varda");
                    FirstName = Console.ReadLine();
                    if (FirstName != null) { pirmasLaukasUzpildytas = true; }
                }


            } while (!pirmasLaukasUzpildytas && !antrasLaukasUzpildytas);


            void AddCustomer()
            {
                using (var context = new ChinookContext())
                {
                    context.Customers.Add(new Customer
                    {
                        // CustomerId =  











                    });
                    context.SaveChanges();
                }
            }






            //to do suvedimas kaip naujo customerio i DB

            Run();


        }


        //3
        public void AdminAplinkosSecurityMetodas()
        {
            Console.Clear();

            Console.Clear();
            Console.WriteLine("| #   | Pasirinkimas                 |  ");
            Console.WriteLine("| 1.  |  Iveskite Pin   |  ");
            Console.WriteLine("| 2.  |  Prisijungti su savo ID    |  ");


            char meniu = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (meniu)
            {
                case '1':
                    Console.WriteLine("Please Enter PIN XXXX ");
                    var input = Console.ReadLine();
                    if (input == "1111") { AdminAplinkosMetodas(); }
                    break;
                case '2':
                    DarbuotojoAplinkosMetodas();
                    break;
                case 'q':
                    Run();
                    break;

                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }
        public void DarbuotojoAplinkosMetodas()
        {
            Console.WriteLine("Show Worker ID List");
            _manoDb.GetEmployees();

            int darbuotojuSkaicius = _dbKontekstas.Employees.ToList().Count();
            List<long> idlist = new List<long>();
            foreach (var item in _dbKontekstas.Employees)
            {

                idlist.Add(item.EmployeeId);

            }
            long idPasirinkimas;

            do
            {
                Console.WriteLine("Choose Your Id");
                idPasirinkimas = Convert.ToInt32(Console.ReadLine());

                if (idlist.Contains(idPasirinkimas))
                {
                    AdminAplinkosMetodas();
                }
            } while (true);
        }
        public void AdminAplinkosMetodas()
        {
            Console.Clear();
            Console.WriteLine("| #   | Pasirinkimas                 |  ");
            Console.WriteLine("| 1.  |  Keisti klientų duomenis    |  ");
            Console.WriteLine("| 2.  |  Pakeisti dainos statusą     |  ");
            Console.WriteLine("| 3.  |  Statistika (Darbuotojams)  |  "); //todo


            char meniu = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (meniu)
            {
                case '1':
                    KeistiKlientųDuomenisMetodoMeniu();
                    break;
                case '2':
                    PakeistiDainosStatusą();
                    break;
                case '3':
                    StatistikosDarbuotojamsMeniu();
                    break;

                case 'q':
                    Run();
                    break;

                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }
        public void StatistikosDarbuotojamsMeniu()
        {
            Console.Clear();
            Console.WriteLine("| #   | Pasirinkimas                 |  ");
            Console.WriteLine("| 1.  | Išgauti visas kliento atąskaitas pagal kliento ID   |  ");
            Console.WriteLine("| 2.  | Išgauti veiklos pelna (Neatskaičius mokesčių pilna suma)    |  ");
            Console.WriteLine("| 3.  | Išgauti veiklos pelną pagal paduotus metus  |  ");
            Console.WriteLine("| 4.  | Išgauti kiek kokio žanro kūrinių buvo nupirkta (Rikiuota pagal dydį) |  ");
            Console.WriteLine("| 5.  | Išgauti kiek kiekvienas klienas išleido pinigų  |  ");
            Console.WriteLine("| 6.  | (BONUS) Išgauti kiek pelno atnešė kiekvienas indivualus Artist  |  ");

            char meniu;
            meniu = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (meniu)
            {
                case '1':
                    Console.WriteLine("Iveskite Kliento Id");
                    int input = Convert.ToInt32(Console.ReadLine());
                    GautiKlientoAtaskaitasPagalKlientoID(input);
                    Console.ReadKey();
                    StatistikosDarbuotojamsMeniu();
                    break;
                case '2':
                    _manoDb.GetAllInvoices();
                    Console.ReadKey();
                    StatistikosDarbuotojamsMeniu();
                    break;
                case '3':
                    _manoDb.GetAllInvoicesByTime();
                    Console.ReadKey();
                    StatistikosDarbuotojamsMeniu();
                    break;
                case '4':
                    // StatistikosMetodas2();
                    break;
                case '5':
                    // StatistikosMetodas2();
                    break;
                case '6':
                    // StatistikosMetodas2();
                    break;

                case 'q':
                    Run();
                    break;
                case 'Q':
                    Run();
                    break;
                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }
        public void PakeistiDainosStatusą()
        {
            Console.Clear();
            Console.WriteLine("| #   | Pasirinkimas            |  ");
            Console.WriteLine("| 1.  | Gauti dainu sarasa      |  ");
            Console.WriteLine("| 2.  | Keisti dainos statusą   |  ");


            char meniu;
            meniu = Console.ReadKey().KeyChar;

            switch (meniu)
            {
                case '1':
                    _manoDb.GetTracks();
                    Console.ReadKey();
                    PakeistiDainosStatusą();
                    break;
                case '2':
                    RastiDainaPagalIdMetodas();

                    // Darbuotojai turės galimybę pakeisti Tracks status iš Active į Inactive ir atvirkščiai. 

                    // Įvedus dainos ID [2] užklausoje mums į ekraną turėtų išvesti koks yra esamas statusas
                    // ir lieptų pasirinkti ar norime keisti į [Active] arba [Inactive] statusus.
                    // Pasirinkus [Inactive] ši daina turėtų būti slepiama ir nebeišgaunama

                    break;


                case 'q':
                    AdminAplinkosMetodas();
                    break;

                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }
        public void KeistiKlientųDuomenisMetodoMeniu()
        {

            Console.Clear();
            Console.WriteLine("| #   | Pasirinkimas                   |  ");
            Console.WriteLine("| 1.  |  Gauti pirkėjų sąrašą          |  ");
            Console.WriteLine("| 2.  |  Pašalinti pirkėją pagal ID    |  ");
            Console.WriteLine("| 3.  |  Modifikuoti pirkėjo duomenis  |  ");

            char meniu = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (meniu)
            {
                case '1':
                    _manoDb.GetCustomers();
                    Console.ReadKey();
                    KeistiKlientųDuomenisMetodoMeniu();

                    break;
                case '2':
                    Console.WriteLine("Iveskite Pirkejo ID, kuri norite pasalinti");
                    int deleteCustomerID = Convert.ToInt32(Console.ReadLine());

                    // to do DELETE CUSTOMER
                    break;
                case '3':
                    // to do UPDATE CUSTOMER

                    break;

                case 'q':
                    AdminAplinkosMetodas();
                    break;

                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }


        //aditional methods
        public void PauseScreen()
        {
            Console.WriteLine("{0}{1}Press any key to continue..", Environment.NewLine, Environment.NewLine);
            Console.ReadKey();
        }
        public void Reset()
        {
            List<dynamic> perkamaDainos = new List<dynamic>();
            Customer PrisijungesUseris = new Customer();
        }


    }
}
