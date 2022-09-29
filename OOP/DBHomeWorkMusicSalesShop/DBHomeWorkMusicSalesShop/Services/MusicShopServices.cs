using DBHomeWorkMusicSalesShop.DataBase;
using DBHomeWorkMusicSalesShop.DTO;
using DBHomeWorkMusicSalesShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHomeWorkMusicSalesShop.Services
{
    public class MusicShopServices : IMusicShopServices
    {

        public void Run()
        {

            //Jei naudotojas yra jau prisijungęs jis neturėtų grįžti į šį langą nebent pats pasirenka atsijungti nuo tuometinės aktyvios paskyros.
            char meniu;

            while (true)
            {
                Console.Clear();
               // Console.WriteLine("| #   FAKE press 1               | ");  //laikinas
                Console.WriteLine("| #   | Pasirinkimas :                | ");
                Console.WriteLine("| 1.  |   Prisijungti                 |  ");
                Console.WriteLine("| 2.  |   Registruotis                |  ");
                Console.WriteLine("| 3.  |   Darbuotojų Parinktys        |  ");
                Console.WriteLine("q. Quit");

                meniu = Console.ReadKey().KeyChar;

                switch (meniu)
                {
                    case '1':

                      //  KrepselioFormavimoMetodas(); //testavimui
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


        //3
        public void AdminAplinkosSecurityMetodas()
        {
            Console.Clear();


            Console.Clear();
            Console.WriteLine("| #   | Pasirinkimas                 |  ");
            Console.WriteLine("| 1.  |  Iveskite Pin   |  ");
            Console.WriteLine("| 2.  |  Prisijungti su savo ID    |  ");
 

            
            char meniu = Console.ReadKey().KeyChar;

            switch (meniu)
            {
                case '1':
                    Console.WriteLine("Please Enter PIN XXXX ");
                    var input = Console.ReadLine();
                    if (input == "1111"){ AdminAplinkosMetodas(); }
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

            ChinookContext dbKontekstas = new ChinookContext();
            ChinookRepository manoDb = new ChinookRepository(dbKontekstas);

            Console.WriteLine("Show Worker ID List");
            manoDb.GetEmployees(); 

            int idPasirinkimas;
            do
            {
                Console.WriteLine("Choose Your Id");

                idPasirinkimas = Convert.ToInt32(Console.ReadLine());
                if (idPasirinkimas >= 1 && idPasirinkimas <= 59) // to lenght of data base list
                {
                    AdminAplinkosMetodas();
                }
            } while (idPasirinkimas <= 1 && idPasirinkimas >= 59);
        }


        public void AdminAplinkosMetodas()
        {


              Console.Clear();
                Console.WriteLine("| #   | Pasirinkimas                 |  ");
                Console.WriteLine("| 1.  |  Keisti klientų duomenis    |  ");
                Console.WriteLine("| 2.  |  Pakeisti dainos statusą     |  ");
                Console.WriteLine("| 3.  |  Statistika (Darbuotojams)  |  "); //todo


                char meniu6;
                meniu6 = Console.ReadKey().KeyChar;

                switch (meniu6)
                {
                    case '1':
                    KeistiKlientųDuomenisMetodoMeniu();
                        break;
                    case '2':
                    PakeistiDainosStatusą();
                        break;
                    case '3':
                       // to do
                        break;
                    
                    case 'q':
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
                    ShowActiveTracsMetod();
                    Console.ReadKey();
                    PakeistiDainosStatusą();
                    break;
                case '2':
                   

                   
                    Console.WriteLine("Iveskite norimą Id   ");
                    int ieskomasTrackId = Convert.ToInt32(Console.ReadLine());
                    IEnumerable<dynamic> redaguojamasIrasas = RastiDainaPagalIdMetodas2(ieskomasTrackId);

                    //TrackDTO trackDTO = new TrackDTO(redaguojamasIrasas);
                    //Console.WriteLine(trackDTO.Active);
                    

                    // Įvedus dainos ID [2] užklausoje mums į ekraną turėtų išvesti koks yra esamas statusas
                    // ir lieptų pasirinkti ar norime keisti į [Active] arba [Inactive] statusus.
                    // Pasirinkus [Inactive] ši daina turėtų būti slepiama ir nebeišgaunama
                    // likusioje programoje išskyrus atąskaitas ir darbuotojams prieinamą informaciją. 

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
            Console.WriteLine("| #   | Pasirinkimas                 |  ");
            Console.WriteLine("| 1.  |  Gauti pirkėjų sąrašą     |  ");
            Console.WriteLine("| 2.  |  Pašalinti pirkėją pagal ID    |  ");
            Console.WriteLine("| 3.  |  Modifikuoti pirkėjo duomenis  |  ");


            char meniu6;
            meniu6 = Console.ReadKey().KeyChar;

            switch (meniu6)
            {
                case '1':
                    GautiPirkejuSarasaMetodas();
                    break;
                case '2':
                    // to do
                    break;
                case '3':
                    // to do
                    break;

                case 'q':
                    AdminAplinkosMetodas();
                    break;

                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }

        private void GautiPirkejuSarasaMetodas()
        {
            ChinookContext dbKontekstas = new ChinookContext();
            ChinookRepository manoDb = new ChinookRepository(dbKontekstas);
             manoDb.GetCustomers();
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
                if (FirstName != null) { pirmasLaukasUzpildytas = true;} 
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



            //to do suvedimas kaip naujo customerio i DB

            Run();

      



    }



        //1
        public void PirmasKlientoPrisijungimoMetodas()
        {
            ChinookContext dbKontekstas = new ChinookContext();
            ChinookRepository manoDb = new ChinookRepository(dbKontekstas);
            
            Console.Clear();

            Console.WriteLine("Show ID List");
            manoDb.GetCustomers();

            int idPasirinkimas;
            do
            {
                Console.WriteLine("Choose Your Id");
                
                idPasirinkimas = Convert.ToInt32(Console.ReadLine());
                if (idPasirinkimas >= 1 && idPasirinkimas <= 59) // to lenght of data base list
                {

                    PirkimoSistemosMetodas();
                } 
            } while (idPasirinkimas <= 1 && idPasirinkimas >= 59);




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

            char meniu2;
            meniu2 = Console.ReadKey().KeyChar;

            switch (meniu2)
            {
                case '1':
                    ShowActiveTracsMetod();
                    RusiavimoPasirinkimoMetodas();
                    break;
                case '2':
                    KrepselioFormavimoMetodas();
                    break;
                case '3':
                    ViewBasket(); //todo
                    UzbaigimoKomandos();
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
            //to do, show all customers Invoices filter by customer ID.. 
        }

        public void UzbaigimoKomandos()
        {
            Console.WriteLine("| #   | Pasirinkimas :                             | ");
            Console.WriteLine("| 1.  | 'q' - Grįžti atgal                      |  ");
            Console.WriteLine("| 2.  | 'y' - Įdeda į krepšelį visas rastas dainas            |  ");

            char meniu5;
            meniu5 = Console.ReadKey().KeyChar;

            switch (meniu5)
            {
                case 'q':
                    KrepselioFormavimoMetodas();
                    break;
                case 'y':
                    // to do print Invoice, customer,  items
                    break;

                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }

        public void ViewBasket()
        {
            //to do show Invoice ?? 
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
            Console.WriteLine("| #   | Paieška :                             | ");
            Console.WriteLine("| 1.  |   Pagal Id           |  ");
            Console.WriteLine("| 2.  |   Pagal Name |  ");
            Console.WriteLine("| 3.  |   Pagal Composer                         |  ");
            Console.WriteLine("| 4.  |   Pagal Genre                            |  ");
            Console.WriteLine("| 5.  |   Pagal Composer ir Album                |  ");
            Console.WriteLine("| 5.  |   Pagal Milliseconds (Mažiau nei X arba daugiau nei X)  |  ");


            char meniu;
            meniu = Console.ReadKey().KeyChar;

            switch (meniu)
            {
                case '1':
                    RastiDainaPagalIdMetodas();
                    PirkimoMetodoKomandos();
                    break;
                case '2':
                    RastiDainaPagalName();
                    PirkimoMetodoKomandos();
                    break;
                case '3':
                    Console.WriteLine("sarasas pagal Composer TODO "); // to do
                    break;
                case '4':
                    Console.WriteLine("sarasas pagal Genre TODO "); // to do
                    break;
                case '5':
                    Console.WriteLine("sarasas pagal Composer ir Album TODO  "); // to do
                    break;
                case 'q':
                    PirkimoSistemosMetodas(); //todo
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

                default:
                    Console.WriteLine("No such case");
                    break;
            }
        }

        public void KrepselioFormavimoMetodas()
        {
            Console.Clear();
            Console.WriteLine("| #   | Pasirinkimas :                             | ");
            Console.WriteLine("| 1.  | Rasti dainą pagal Id                       |  ");
            Console.WriteLine("| 2.  | Rasti dainą pagal pavadinimą               |  ");
            Console.WriteLine("| 3.  | Rasti dainas pagal albumo Id               |  ");
            Console.WriteLine("| 4.  | Rasti dainas pagal albumo pavadinimą       |  ");
            Console.WriteLine("q. Quit");

            char meniu3;
            meniu3 = Console.ReadKey().KeyChar;

            switch (meniu3)
            {
                case '1':
                    Console.Clear();
                    RastiDainaPagalIdMetodas();
                    PirkimoMetodoKomandos(); 
                    break;
                case '2':
                    Console.Clear();
                    RastiDainaPagalName();
                    PirkimoMetodoKomandos();
                    break;
                case '3':
                    //todo
                    PirkimoMetodoKomandos();
                    break;
                case '4':
                    //todo
                    PirkimoMetodoKomandos();
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

        public void PirkimoMetodoKomandos()
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
                case 'y':
                    IdetiPrekeIKrepselyMetodas(); //todo 
                    break;
              
                default:
                    Console.WriteLine("No such case");
                    break;
            }

        }

        public void PirkimoPatvirtinimoMetodoKomandos()
        {

            Console.WriteLine("| #   | Pasirinkimas :                             | ");
            Console.WriteLine("| 1.  | 'q' - Grįžti atgal                      |  ");
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

        }


        public void IdetiPrekeIKrepselyMetodas()
        {

            Console.WriteLine("Dainos X idedamos  i krepsely ");
            Console.WriteLine();
            //TODO
            // var pirkiniuKrepselis.Add(rastuDainuSaras); 



        }


        public void SukurtiInvoiceMetodas()
        {

            Console.WriteLine("Sugeneruotas Invoice");
            //TODO

            // Pasirinkus "Užbaigti pirkimą" programa turėtų atspausdinti visą informaciją apie Invoice,
            // kaip kliento vardas, pavardė, adresas, postalcode, telefono numeris ir visa kita informacija.
            // Po kliento duomenų turėtų būti surašyti visos nupirktos dainos su joms būtina priklausančia informacija.
            // Po nupirktų dainų sąrašu turėtų parašyti galutinę sumą be privalomo mokesčio(Tax), privalomo mokesčio suma
            // ir galutinė mokėtina suma.Šiam uždaviniui Tax bus fiksuoto dydžio 21 %, kurį galite laikyti kaip konstantą savo programoje.


            Console.WriteLine(@" 
                Name:{Customer.Name}
                Surname: Surname
                Address: Address
                Phone: Phone...
                PostalCode: PostalCode");
            Console.WriteLine(@" 
                | #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | 
                -------------------------------------------------------------- 
                | Id.  |    Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | ");

            Console.WriteLine(@" 
                Total without Tax: Total
                Tax: 21%
                Total: Total+21% ");


            Console.WriteLine(" 'q' - Grįžti atgal  ");
        

        }



        public IEnumerable<dynamic> RastiDainaPagalIdMetodas()
        {
            Console.WriteLine("Iveskite norimą Id   "); 
            int ieskomasTrackId = Convert.ToInt32(Console.ReadLine());

            ChinookContext dbKontekstas = new ChinookContext();
            ChinookRepository manoDb = new ChinookRepository(dbKontekstas);
           var rastuDainuSaras = manoDb.GetTracksByID(ieskomasTrackId);

            return rastuDainuSaras;

        }

        public IEnumerable<dynamic> RastiDainaPagalIdMetodas2(int ieskomasTrackId)
        {
           

            ChinookContext dbKontekstas = new ChinookContext();
            ChinookRepository manoDb = new ChinookRepository(dbKontekstas);
            var rastuDainuSaras = manoDb.GetTracksByID(ieskomasTrackId);

            return rastuDainuSaras;

        }




        public void RastiDainaPagalName()
        {
            Console.WriteLine("Iveskite norimą Name   "); 
            string ieskomasTrackName = Console.ReadLine();

            ChinookContext dbKontekstas = new ChinookContext();
            ChinookRepository manoDb = new ChinookRepository(dbKontekstas);
            var rastuDainuSaras = manoDb.GetTracksByName(ieskomasTrackName);

        }




        public void RusiuotiDainaPagalMetoda(char meniu)
        {

            ChinookContext dbKontekstas = new ChinookContext();
            ChinookRepository manoDb = new ChinookRepository(dbKontekstas);

            if (meniu == '1')
            {
                var isrusiuotasDainuSarasasAZ = manoDb.GetTracks();
                Console.WriteLine(isrusiuotasDainuSarasasAZ);
            }  else if (meniu == '2')
            {
                var isrusiuotasDainuSarasasZA = manoDb.GetTracksSorted();
                Console.WriteLine(isrusiuotasDainuSarasasZA);
            }
           

           
        }



        public void ShowActiveTracsMetod()
        {
            ChinookContext dbKontekstas = new ChinookContext();
            ChinookRepository manoDb = new ChinookRepository(dbKontekstas);
            manoDb.GetTracks();
        }

        //aditional methods

        public void PauseScreen()
        {
            Console.WriteLine("{0}{1}Press any key to continue..", Environment.NewLine, Environment.NewLine);
            Console.ReadKey();
        }
    }
}
