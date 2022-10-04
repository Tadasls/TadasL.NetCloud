using Castle.Core.Resource;
using DBHomeWorkMusicSalesShop.DataBase;
using DBHomeWorkMusicSalesShop.Interfaces;
using DBHomeWorkMusicSalesShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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
        public List<dynamic> perkamaDainos = new List<dynamic>();
        public Customer prisijungesUseris = new Customer();
        private ChinookRepository @object;
        private readonly ChinookContext _dbKontekstas;
        private readonly ChinookRepository _manoDb;

        public MusicShopServices()
        {
            _dbKontekstas = new ChinookContext();
            _manoDb = new ChinookRepository(_dbKontekstas);
        }

        public MusicShopServices(ChinookRepository @object)
        {
            this.@object = @object;
        }

        public void Run()
        {
            char meniu;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("| #   | Pasirinkimas :                | ");
                Console.WriteLine("| 1.  |   Prisijungti                 |  ");
                Console.WriteLine("| 2.  |   Registruotis                |  ");
                Console.WriteLine("| 3.  |   Darbuotojų Parinktys        |  ");
                Console.WriteLine("q. Quit");

                meniu = Console.ReadKey().KeyChar;

                switch (meniu)
                {
                    case '1':
                        PirmasKlientoPrisijungimoMetodas();
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

        //1 Kliento Aplinka
        public void PirmasKlientoPrisijungimoMetodas()
        {

            Console.Clear();
            Console.WriteLine("Show ID List");
            GautiKlientus();

            List<long> idlist = new List<long>();
            foreach (var item in _dbKontekstas.Customers)
            {
                idlist.Add(item.CustomerId);
            }
            long idPasirinkimas;
            do
            {
                
                Console.WriteLine("Choose Your Id");
                Reset();
                idPasirinkimas = IvestiSkaiciu();

                if (idlist.Contains(idPasirinkimas)) 
                {
                    foreach (var item in _dbKontekstas.Customers)
                    {
                        if (item.CustomerId == idPasirinkimas) 
                        {
                            prisijungesUseris = item;
                        }

                    }
                    PirkimoSistemosMetodas();
                } 
            } while (true);


        }
        public virtual IEnumerable<dynamic> GautiKlientus()
        {
            IEnumerable<dynamic> klientai = _manoDb.GetCustomers();
            return klientai;

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
                    KrepselioFormavimoMeniu();
                    break;
                case '3':
                    KrepselioRodymoMetodas(); 
                    break;
                case '4':
                    SalesHistoryData(); 
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
            GautiKlientoAtaskaitasPagalKlientoID((int)prisijungesUseris.CustomerId);
            PauseScreen();
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
            Console.Clear();
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

            
            char meniu = Console.ReadKey().KeyChar;

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
                    RastiDainaPagalComposer();
                    break;
                case '4':
                    RastiDainaPagalGenre();
                    break;
                case '5':
                    RastiDainaPagalComposerIrAlbum();
                    break;
                case '6':
                    RastiDainaPagalTrukme();
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

            
           char meniu = Console.ReadKey().KeyChar;

            switch (meniu)
            {
                case '1':
                    IEnumerable<dynamic> isrusiuotasDainuSarasasAZ = _manoDb.GetTracks();
                    Console.WriteLine(isrusiuotasDainuSarasasAZ);
                    PauseScreen();
                    RusiavimoPasirinkimoMetodas();
                    break;
                case '2':
                    var isrusiuotasDainuSarasasZA = _manoDb.GetTracksSorted();
                    Console.WriteLine(isrusiuotasDainuSarasasZA);
                    PauseScreen();
                    RusiavimoPasirinkimoMetodas();
                    break;
                case '3':
                    isrusiuotasDainuSarasasZA = _manoDb.GetTracksByComposer();
                    Console.WriteLine(isrusiuotasDainuSarasasZA);
                    PauseScreen();
                    RusiavimoPasirinkimoMetodas();
                    break;
                case '4':
                    isrusiuotasDainuSarasasZA = _manoDb.GetTracksByGenre();
                    Console.WriteLine(isrusiuotasDainuSarasasZA);
                    PauseScreen();
                    RusiavimoPasirinkimoMetodas();
                    break;
                case '5':
                    isrusiuotasDainuSarasasZA = _manoDb.GetTracksByComposerAndAlbum();
                    Console.WriteLine(isrusiuotasDainuSarasasZA);
                    PauseScreen();
                    RusiavimoPasirinkimoMetodas();
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
        public void KrepselioFormavimoMeniu()
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
                    PirkimoSistemosMetodas();
                    return;
                case 'Q':
                    PirkimoSistemosMetodas();
                    return;
                default:
                    Console.WriteLine("No such case");
                    break;
            }

        }
        public void PirkimoPasirinkimoKomandos(List<dynamic> rastuDainuSaras)
        {
            Console.WriteLine("| #   | Pasirinkimas :                               | ");
            Console.WriteLine("| 1.  | 'q' - Grįžti atgal                           |  ");
            Console.WriteLine("| 2.  | 'y' - Įdeda į krepšelį visas rastas dainas   |  ");
            
            char meniu;
            meniu = Console.ReadKey().KeyChar;

            switch (meniu)
            {
                case 'q':
                    KrepselioFormavimoMeniu();
                    break;
                case 'Q':
                    KrepselioFormavimoMeniu();
                    break;
                case 'y':
                    perkamaDainos.AddRange(rastuDainuSaras.ToArray());
                    KrepselioRodymoMetodas();
                    break;
                case 'Y':
                    perkamaDainos.AddRange(rastuDainuSaras.ToArray());
                    KrepselioRodymoMetodas();
                    break;
                default:
                    Console.WriteLine("No such case");
                    break;
            }
        } 
        public void KrepselioRodymoMetodas()
        {
            Console.Clear();
            Console.WriteLine("Krepselyje Yra sios Dainos:");
            if (perkamaDainos.Count() == 0)  //    ==null )
            {
                Console.WriteLine("Krepselis tuscias");
                PauseScreen();
                PirkimoSistemosMetodas();
            }

            foreach (var track in perkamaDainos)
            {
                Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kaina}");
                //{track.Vardas},{track.Kompozitorius},{track.Zanras}, {track.Zanras.Name}, {track.Albumas}, {track.Albumas.Title}, {track.Trukme}, {track.Kaina}
            }
            PirkimoUzbaigimoKomandos();
        }
        public void PirkimoUzbaigimoKomandos()
        {
            Console.WriteLine("| #   | Pasirinkimas :                    | ");
            Console.WriteLine("| 1.  | 'q' - Grįžti atgal                |  ");
            Console.WriteLine("| 2.  | 'y' - Užbaigti pirkimą            |  ");

            char meniu = Console.ReadKey().KeyChar;
            switch (meniu)
            {
                case 'q':
                    KrepselioFormavimoMeniu();
                    break;
                case 'Q':
                    KrepselioFormavimoMeniu();
                    break;
                case 'y':
                    SukurtiInvoiceMetodas();
                    break;
                case 'Y':
                    SukurtiInvoiceMetodas();
                    break;
                default:
                    Console.WriteLine("No such case");
                    break;
            }

        }
        public void SukurtiInvoiceMetodas()
        {
            Console.Clear();

            Console.WriteLine("   Sugeneruotas INVOICE ");

            Console.WriteLine($"Name {prisijungesUseris.FirstName}");
            Console.WriteLine($"LastName {prisijungesUseris.LastName}");
            Console.WriteLine($"Adress {prisijungesUseris.Address}");
            Console.WriteLine($"Phone {prisijungesUseris.Phone}");
            Console.WriteLine($"Post Code {prisijungesUseris.PostalCode}");

            Console.WriteLine();
            Console.WriteLine(" | #       | ID, Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | ");

            Console.WriteLine();
            double TotalBePVM = 0.0;

            var invoiceitems = new HashSet<InvoiceItem>();
            foreach (var track in perkamaDainos)
            {
                var invItem = new InvoiceItem();
                invItem.TrackId = track.IrasoId;
                invItem.UnitPrice = track.Kaina;
                invItem.Quantity =1;
                invoiceitems.Add(invItem);
                Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras}, {track.Albumas}, {track.Trukme}, {track.Kaina}  ");
                TotalBePVM = TotalBePVM + track.Kaina;
            }

            Console.WriteLine();
            Console.WriteLine(TotalBePVM);
            Console.WriteLine(" Tax: 21%");
            double TotalSuPVM = TotalBePVM * 1.21;
            Console.WriteLine(TotalSuPVM);

            Console.WriteLine();




            Invoice invoice = new Invoice()
            {
                InvoiceItems = invoiceitems

            };

            invoice.CustomerId = prisijungesUseris.CustomerId;
            invoice.InvoiceDate = DateTime.Now;
            invoice.BillingAddress = prisijungesUseris.Address;
            invoice.BillingCity = prisijungesUseris.City;
            invoice.BillingState = prisijungesUseris.State;
            invoice.BillingCountry = prisijungesUseris.Country;
            invoice.BillingPostalCode = prisijungesUseris.PostalCode;
            invoice.Total = TotalSuPVM;



            _manoDb.CreateNewInvoice(invoice);





            GryzimoIMeniuMetodoKomanda();
        }
        public void GryzimoIMeniuMetodoKomanda()
        {
            Console.WriteLine(" 'q' - Grįžti atgal  ");
            char meniu = Console.ReadKey().KeyChar;
            switch (meniu)
            {
                case 'q':
                    KrepselioFormavimoMeniu();
                    break;
                case 'Q':
                    KrepselioFormavimoMeniu();
                    break;
                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }

        //dainu paieskos metodai
        public IEnumerable<dynamic> RastiDainaPagalIdMetodas()
        {
            Console.WriteLine("Iveskite norimą Id   "); 
            int ieskomaPagal = IvestiSkaiciu();
            var rastuDainuSaras = _manoDb.GetTracksByID(ieskomaPagal);
            PirkimoPasirinkimoKomandos(rastuDainuSaras.ToList());
            return rastuDainuSaras.ToList();
        }
        public void RastiDainaPagalName()
        {
            Console.WriteLine("Iveskite norimą Name   ");
            string ieskomaPagal = Console.ReadLine();
            var rastuDainuSaras = _manoDb.GetTracksByName(ieskomaPagal);
            PirkimoPasirinkimoKomandos(rastuDainuSaras.ToList());
        }
        public void RastiDainaPagalAlbumID()
        {
            Console.WriteLine("Iveskite norimą AlbumId  ");
            int ieskomaPagal = IvestiSkaiciu(); 
            var rastuDainuSaras = _manoDb.GetTracksByAlbumID(ieskomaPagal);
            PirkimoPasirinkimoKomandos(rastuDainuSaras.ToList());
        }
        public void RastiDainaPagalAlbumName()
        {
            Console.WriteLine("Iveskite norimą Album Name   ");
            string ieskomaPagal = Console.ReadLine();
            var rastuDainuSaras = _manoDb.GetTracksByAlbumName(ieskomaPagal);
            PirkimoPasirinkimoKomandos(rastuDainuSaras.ToList());
        }
        public void RastiDainaPagalComposer()
        {
            Console.WriteLine("Iveskite norimą Composer  ");
            string ieskomaPagal = Console.ReadLine();
            var rastuDainuSaras = _manoDb.GetTracksByAlbumName(ieskomaPagal);
            PirkimoPasirinkimoKomandos(rastuDainuSaras.ToList());
        }
        public void RastiDainaPagalGenre()
        {
            Console.WriteLine("Iveskite norimą Genre Name   ");
            string ieskomaPagal = Console.ReadLine();
            var rastuDainuSaras = _manoDb.GetTracksByAlbumName(ieskomaPagal);
            PirkimoPasirinkimoKomandos(rastuDainuSaras.ToList());
        }
        public void RastiDainaPagalComposerIrAlbum()
        {
            Console.WriteLine("Iveskite ieskoma kompozitoriu   ");
            string ieskomaskompozitorius = Console.ReadLine();
            Console.WriteLine("Iveskite ieskoma Albuma ");
            string ieskomasAlbumas = Console.ReadLine();
            var rastuDainuSaras = _manoDb.GetTracksByComposerAndAlbum(ieskomaskompozitorius, ieskomasAlbumas);
            PirkimoPasirinkimoKomandos(rastuDainuSaras.ToList());
        }
        public void RastiDainaPagalTrukme()
        {
            Console.WriteLine("Iveskite ieskoma trukme nuo MiliSekundziu   ");

            int ieskomaPagalNuoMili = IvestiSkaiciu();
            Console.WriteLine("Iveskite ieskoma trukme nuo MiliSekundziu   ");
            int ieskomaPagalIkiMili = IvestiSkaiciu();
            var rastuDainuSaras = _manoDb.GetTracksByLenght(ieskomaPagalNuoMili, ieskomaPagalIkiMili);
            PirkimoPasirinkimoKomandos(rastuDainuSaras.ToList());
        }
        public void GautiKlientoAtaskaitasPagalKlientoID(int klientoId)
        {
             _manoDb.GetInvoices(klientoId);
        }

        //2
        public void KlientoRegistracijosMetodas()
        {
            Console.Clear();
                  bool pirmasLaukasUzpildytas = false;
            bool antrasLaukasUzpildytas = false;


                Customer naujasKlientas = new Customer();

                Console.WriteLine("Iveskite kliento varda");
                naujasKlientas.FirstName = Console.ReadLine();
                if (naujasKlientas.FirstName != "") { pirmasLaukasUzpildytas = true; }
            while (!pirmasLaukasUzpildytas)
            {
                Console.WriteLine("Neivestas Vardas prasau pakartotinai");
                Console.WriteLine("Iveskite kliento varda");
                naujasKlientas.FirstName = Console.ReadLine();
                if (naujasKlientas.FirstName != "") { pirmasLaukasUzpildytas = true; }
            }

            Console.WriteLine("Iveskite kliento Pavarde");
            naujasKlientas.LastName = Console.ReadLine();
            if (naujasKlientas.LastName != "") { antrasLaukasUzpildytas = true; }
            while (!antrasLaukasUzpildytas)
            {
                Console.WriteLine("Neivesta Pavarde prasau pakartotinai");
                Console.WriteLine("Iveskite kliento Pavarde");
                naujasKlientas.LastName = Console.ReadLine();
                if (naujasKlientas.LastName != "") { antrasLaukasUzpildytas = true; }
            }

            Console.WriteLine("Iveskite kliento Kompanija");
            naujasKlientas.Company = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Adresa");
            naujasKlientas.Address = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Miesta");
            naujasKlientas.City = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Valstija");
            naujasKlientas.State = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Saly");
            naujasKlientas.Country = Console.ReadLine();
            Console.WriteLine("Iveskite kliento PastoKoda");
            naujasKlientas.PostalCode = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Telefona");
            naujasKlientas.Phone = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Faxa");
            naujasKlientas.Fax = Console.ReadLine();
            Console.WriteLine("Iveskite kliento Emaila");
            naujasKlientas.Email = Console.ReadLine();


            _manoDb.CreateNewCustomer(naujasKlientas);
                Console.Write($" new Customer with Name {naujasKlientas.FirstName}  and LastName {naujasKlientas.LastName}  added to the database\n");
          PauseScreen();

            


            Run();
        }

        //3
        public void AdminAplinkosSecurityMetodas()
        {
            Console.Clear();

            Console.Clear();
            Console.WriteLine("| #   | Pasirinkimas               |  ");
            Console.WriteLine("| 1.  |  Iveskite Pin              |  ");
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
                case 'Q':
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

            //int darbuotojuSkaicius = _dbKontekstas.Employees.ToList().Count();
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
            Console.WriteLine("| 3.  |  Statistika (Darbuotojams)  |  "); 

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
                case 'Q':
                    Run();
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
                    PauseScreen();
                    KeistiKlientųDuomenisMetodoMeniu();
                    break;
                case '2':
                    Console.WriteLine("Iveskite Pirkejo ID, kuri norite PASALINTI");
                    long deleteCustomerID = Convert.ToInt32(Console.ReadLine());
                    _manoDb.DeleteCustomer(deleteCustomerID);
                    PauseScreen();
                    KeistiKlientųDuomenisMetodoMeniu();
                    break;
                case '3':
                    RodytiPasirinktoKlientoDuomenisIrPrasytiSuvestiNaujus();
                    PauseScreen();
                    KeistiKlientųDuomenisMetodoMeniu();
                    break;
                case 'q':
                    AdminAplinkosMetodas();
                    break;
                case 'Q':
                    AdminAplinkosMetodas();
                    break;

                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }
        public void RodytiPasirinktoKlientoDuomenisIrPrasytiSuvestiNaujus()
        {
            Console.WriteLine("Iveskite Pirkejo ID, kuri norite REDAGUOTI");
            long pokyciuID = IvestiSkaiciu();
            _manoDb.UpdateCustomerData(pokyciuID);

        }
        public void PakeistiDainosStatusą()
        {
            Console.Clear();
            Console.WriteLine("| #   | Pasirinkimas            |  ");
            Console.WriteLine("| 1.  | Gauti dainu sarasa      |  ");
            Console.WriteLine("| 2.  | Keisti dainos statusą   |  ");


            
            char meniu = Console.ReadKey().KeyChar;
            Console.Clear();

            switch (meniu)
            {
                case '1':
                    _manoDb.GetTracksForAdmins();
                    PauseScreen();
                    PakeistiDainosStatusą();
                    break;
                case '2':
                    Console.WriteLine("Iveskite keiciamos DainosId ");
                    long input = Convert.ToInt32(Console.ReadLine());
                    _manoDb.UpdateTrackData(input);
                    PakeistiDainosStatusą();
                    break;

                case 'q':
                    AdminAplinkosMetodas();
                    break;
                case 'Q':
                    AdminAplinkosMetodas();
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

           
           char meniu = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (meniu)
            {
                case '1':
                    Console.WriteLine("Iveskite Kliento Id");
                    int input = Convert.ToInt32(Console.ReadLine());
                    GautiKlientoAtaskaitasPagalKlientoID(input);
                    PauseScreen();
                    StatistikosDarbuotojamsMeniu();
                    break;
                case '2':
                    _manoDb.GetAllInvoices();
                    PauseScreen();
                    StatistikosDarbuotojamsMeniu();
                    break;
                case '3':
                    _manoDb.GetAllInvoicesByTime();
                    PauseScreen();
                    StatistikosDarbuotojamsMeniu();
                    break;
                case '4':
                    _manoDb.GetAllInvoicesDataByZanras();
                    PauseScreen();
                    StatistikosDarbuotojamsMeniu();
                    break;
                case '5':
                    _manoDb.GetAllInvoicesByCustomers();
                    PauseScreen();
                    StatistikosDarbuotojamsMeniu();
                    break;
                case 'q':
                    KeistiKlientųDuomenisMetodoMeniu();
                    break;
                case 'Q':
                    KeistiKlientųDuomenisMetodoMeniu();
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
           perkamaDainos = new List<dynamic>();
         // Customer prisijungesUseris = new Customer();
    }
        public int IvestiSkaiciu()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
                Console.WriteLine("Neteisinga ivestis!");

            return input;
        }


    }
}
