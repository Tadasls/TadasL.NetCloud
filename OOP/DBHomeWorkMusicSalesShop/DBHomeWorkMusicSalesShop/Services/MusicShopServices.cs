using DBHomeWorkMusicSalesShop.DataBase;
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
           
            //Pirmas langas turėtų būti skirtas registracijai, prisijungimui ir Employee skirtoms statistikoms. 
            char meniu1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("| #   | Pasirinkimas :                | ");
                Console.WriteLine("| 1.  |   Prisijungti                 |  ");
                Console.WriteLine("| 2.  |   Registruotis                |  ");
                Console.WriteLine("| 3.  |   Darbuotojų Parinktys        |  ");
                Console.WriteLine("q. Quit");

                meniu1 = Console.ReadKey().KeyChar;

                switch (meniu1)
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

        public void AdminAplinkosSecurityMetodas()
        {
            Console.Clear();
            Console.WriteLine("Please Enter PIN or Choose Employe ID"); // to DO 
            var input = Console.ReadLine();
            if (input == "123")
            {
                AdminAplinkosMetodas();
            }
        }

        public void AdminAplinkosMetodas()
        {
              Console.Clear();
                Console.WriteLine("| #   | Pasirinkimas                 |  ");
                Console.WriteLine("| 1.  |  Keisti klientų duomenis    |  ");
                Console.WriteLine("| 2.  |  Pakeisti dainos statusą     |  ");
                Console.WriteLine("| 3.  |  Statistika (Darbuotojams)  |  ");


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
            Console.WriteLine("| #   | Pasirinkimas                 |  ");
            Console.WriteLine("| 1.  | Gauti dainu sarasa   |  ");
            Console.WriteLine("| 2.  |  Keisti dainos statusą   |  ");
        


            char meniu7;
            meniu7 = Console.ReadKey().KeyChar;

            switch (meniu7)
            {
                case '1':
                    // to do [1] išveda į ekraną suformatuotas dainas
                    break;
                case '2':
                    // to do [2] Liepia įvesti dainos ID.
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
                    // to do
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

        public void KlientoRegistracijosMetodas()
        {

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

        public void PirmasKlientoPrisijungimoMetodas()
        {
            ChinookContext dbKontekstas = new ChinookContext();
            ChinookRepository manoDb = new ChinookRepository(dbKontekstas);


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
                    KrepselioMetodas();
                    break;
                case '3':
                    ViewBasket();
                    UzbaigimoKomandos();
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
                    KrepselioMetodas();
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
            Console.Clear();
            Console.WriteLine("| #   | Pasirinkimas :                   | ");
            Console.WriteLine("| Q.  |   Grįžti atgal                   |  ");
            Console.WriteLine("| O.  |   Rikiavimo langas               |  ");
            Console.WriteLine("| S.  |   Paieškos langas                |  ");



            char meniu3;
            meniu3 = Console.ReadKey().KeyChar;

            switch (meniu3)
            {
                case 'q':
                    PirkimoSistemosMetodas();
                    break;
                case 'O':
                    RikiavimoMetoduMeniu();
                    break;
                case 'S':
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


            char meniu4;
            meniu4 = Console.ReadKey().KeyChar;

            switch (meniu4)
            {
                case '1':
                    RastiDainaPagalIdMetodas();
                    break;
                case '2':
                    Console.WriteLine("sarasas pagal ZA "); // to do
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

        public void RikiavimoMetoduMeniu()
        {
            Console.WriteLine("| #   | Rikiavimas :                             | ");
            Console.WriteLine("| 1.  |   Pagal Name abecėlės tvarka             |  ");
            Console.WriteLine("| 2.  |   Pagal Name atvirkštine abecėlės tvarka |  ");
            Console.WriteLine("| 3.  |   Pagal Composer                         |  ");
            Console.WriteLine("| 4.  |   Pagal Genre                            |  ");
            Console.WriteLine("| 5.  |   Pagal Composer ir Album                |  ");



            char meniu4;
            meniu4 = Console.ReadKey().KeyChar;

            switch (meniu4)
            {
                case '1':
                    Console.WriteLine("sarasas pagal AZ "); // to do
                    break;
                case '2':
                    Console.WriteLine("sarasas pagal ZA "); // to do
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

        public void KrepselioMetodas()
        {
            Console.Clear();
            Console.WriteLine("| #   | Pasirinkimas :                             | ");
            Console.WriteLine("| 1.  | Rasti dainą pagal Id                       |  ");
            Console.WriteLine("| 2.  | Rasti dainą pagal pavadinimą               |  ");
            Console.WriteLine("| 3.  | Rasti dainas pagal albumo Id               |  ");
            Console.WriteLine("| 3.  | Rasti dainas pagal albumo pavadinimą       |  ");
            Console.WriteLine("q. Quit");

            char meniu3;
            meniu3 = Console.ReadKey().KeyChar;

            switch (meniu3)
            {
                case '1':
                    RastiDainaPagalIdMetodas();
                    PirkimoMetodoKomandos(); //need refactoring
                    break;
                case '2':
                  
                    break;
                case '3':

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
            
            char meniu5;
            meniu5 = Console.ReadKey().KeyChar;

            switch (meniu5)
            {
                case 'q':
                    KrepselioMetodas();
                    break;
                case 'y':
                  // var pirkiniuKrepselis.Add(rastuDainuSaras); // create fill invoice by client data, track ir t.t. 
                    break;
              
                default:
                    Console.WriteLine("No such case");
                    break;
            }

        }

        public IEnumerable<dynamic> RastiDainaPagalIdMetodas()
        {
            Console.WriteLine("Iveskite norimą Id   "); // to do
            int ieskomasTrackId = Convert.ToInt32(Console.ReadLine());

            ChinookContext dbKontekstas = new ChinookContext();
            ChinookRepository manoDb = new ChinookRepository(dbKontekstas);
           var rastuDainuSaras = manoDb.GetTracksByID(ieskomasTrackId);
            Console.WriteLine(rastuDainuSaras); 
            return rastuDainuSaras;
        }

        public void ShowActiveTracsMetod()
        {
            ChinookContext dbKontekstas = new ChinookContext();
            ChinookRepository manoDb = new ChinookRepository(dbKontekstas);
            manoDb.GetTracks();
        }

        public void PauseScreen()
        {
            Console.WriteLine("{0}{1}Press any key to continue..", Environment.NewLine, Environment.NewLine);
            Console.ReadKey();
        }
    }
}
