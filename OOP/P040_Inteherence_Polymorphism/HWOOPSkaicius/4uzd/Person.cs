using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HWOOPSkaiciavimas._4uzd
{
    public class Person : IPerson
    {
        public Person()
	    {
            Name = "";
            LastName = "";
	    }
        public Person(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public List<IHobby> MegstamiDalykai { get; set; } = new List<IHobby>();
        public List<IHobby> CheckoutList = new List<IHobby>();

        public void Interact(IHobby hobis)
        {
            Console.WriteLine($" {Name} will now watch a {hobis.Name} which is a {hobis.Genre}.");
        }
        public string GetFavoriteHobbyType(IHobby hobis) 
        {
            Console.WriteLine(hobis.GetHobbyInformation());
            return hobis.Name;
        }
        public string GetFavoriteHobby(List<IHobby> MegstamiDalykai)
        {
            MegstamiDalykai.Sort((h1, h2) => h1.Rating.CompareTo(h2.Rating));
            return MegstamiDalykai[0].GetHobbyInformation(); 
        } 

        public List<IHobby> GetFavoriteFromEachHobby()
        {
            List<IHobby> megstamiausiHobiai = new List<IHobby>(3);
            foreach (IHobby hobis in megstamiausiHobiai)
            {
                if (hobis.GetHobbyName() == "Game")
                {
                    if (megstamiausiHobiai[0].Rating < hobis.Rating)
                    {
                        megstamiausiHobiai[0] = hobis;
                    }
                }
                else if (hobis.GetHobbyName() == "Movie")
                {
                    if (megstamiausiHobiai[1].Rating < hobis.Rating)
                    {
                        megstamiausiHobiai[1] = hobis;
                    }
                }
                else if (hobis.GetHobbyName() == "Music")
                {
                    if (megstamiausiHobiai[2].Rating < hobis.Rating)
                    {
                        megstamiausiHobiai[2] = hobis;
                    }
                }
            }

            return megstamiausiHobiai;
        }
        public string GetFavoriteMusicGenre()
        {
            Dictionary<string, int> pasikartojimuSkaicius = new Dictionary<string, int>() { };
            KeyValuePair<string, int> laikinaPora = new KeyValuePair<string, int>("", 0);
            string textas = "";
            foreach (IHobby hobis in MegstamiDalykai)
            {
                pasikartojimuSkaicius[hobis.Genre] = pasikartojimuSkaicius[hobis.Genre]++;
            }

            foreach (KeyValuePair<string, int> genre in pasikartojimuSkaicius)
            {
                if (laikinaPora.Value < genre.Value)
                {
                    textas = genre.Key;
                    laikinaPora = genre;
                }
            }

            return textas;
        } //-> Turetu grazinti megstamiausia dazniausiai pasikartojanti muzikos zanra zmogaus hobiuose
        public Dictionary<string, int> GetEachHobbyAvgRating()
        {
            Dictionary<string, int> vidIvertinimas = new Dictionary<string, int>()
            {
                { "Game", 0 },
                { "Movie", 0 },
                { "Music", 0 }
            };
            int[] skaiciuokle = new int[3];

            foreach (IHobby hobis in MegstamiDalykai)
            {
                if (hobis.GetHobbyName() == "Game")
                {
                    vidIvertinimas["Game"] += hobis.Rating;
                    skaiciuokle[0]++;
                }
                else if (hobis.GetHobbyName() == "Movie")
                {
                    vidIvertinimas["Movie"] += hobis.Rating;
                    skaiciuokle[1]++;
                }
                else if (hobis.GetHobbyName() == "Music")
                {
                    vidIvertinimas["Music"] += hobis.Rating;
                    skaiciuokle[2]++;
                }
            }

            vidIvertinimas["Game"] += vidIvertinimas["Game"] / skaiciuokle[0];
            vidIvertinimas["Movie"] += vidIvertinimas["Movie"] / skaiciuokle[1];
            vidIvertinimas["Music"] += vidIvertinimas["Music"] / skaiciuokle[2];

            return vidIvertinimas;
        } // -> Grazina dictionary su irasais kuriuose key yra hobio tipas pvz filmas, o value yra vidurkis

        public void ShareHobbies(Person person2)
        {
            person2.MegstamiDalykai.AddRange(MegstamiDalykai);
        }
        public void ShareOldMovies(Person person2)
        {
            List<IHobby> visiFilmai = new List<IHobby>();
            List<IHobby> naujiFilmai = new List<IHobby>();

            foreach (IHobby hobis in MegstamiDalykai)
            {

                if (hobis.GetHobbyName() == "Movie")
                {
                    visiFilmai.Add(hobis);
                }
            }
            foreach (Movie video in visiFilmai)
            {
                if (video.CreationDate > new DateTime(2010, 01, 01))
                {
                    naujiFilmai.Add(video);
                }
            }
            person2.MegstamiDalykai.AddRange(naujiFilmai);

        }

        public List<IHobby> FindSimilarHobbies(Person person2) 
        {
           List<IHobby> sutampantysHobiai = new List<IHobby>();

            foreach (IHobby hobis in this.MegstamiDalykai)
            {
                foreach (IHobby kitasHobis in person2.MegstamiDalykai)
                {
                    if (hobis.GetHobbyName() == kitasHobis.GetHobbyName())
                    {
                        sutampantysHobiai.Add(hobis);
                    }
                }
            }
            return sutampantysHobiai;
        }
        public List<IHobby> FindSimilarHobbies(Person person2, string hobbyType)
        {
            List<IHobby> sutampantysHobiai = new List<IHobby>();

            foreach (IHobby hobis in this.MegstamiDalykai)
            {
                foreach (IHobby kitasHobis in person2.MegstamiDalykai)
                {
                    if (hobis.GetHobbyName() == kitasHobis.GetHobbyName() && hobis.GetHobbyName() == hobbyType)
                    {
                        sutampantysHobiai.Add(hobis);
                    }
                }
            }
            return sutampantysHobiai;
        }
        public List<string> FindMatchingGenres(Person person2, string hobbyType)
        {
            List<string> sutampantysZanrai = new List<string>();

            foreach (IHobby hobis in MegstamiDalykai)
            {
                if (hobbyType == hobis.GetHobbyName())
                {
                    foreach (IHobby kitasHobis in person2.MegstamiDalykai)
                    {
                        if (hobis.Genre == kitasHobis.Genre && !sutampantysZanrai.Contains(hobis.Genre))
                        {
                            sutampantysZanrai.Add(hobis.Genre);
                        }
                    }
                }
            }

            return sutampantysZanrai;
        }
        void AddRandomToCheckList(Person person2) 
        {
            List<IHobby> skirtingiHobiai = new List<IHobby>();
            foreach (IHobby hobis in this.MegstamiDalykai)
            {
                foreach (IHobby kitasHobis in person2.MegstamiDalykai)
                {
                    if (hobis.GetHobbyName() != kitasHobis.GetHobbyName())
                    {
                        skirtingiHobiai.Add(hobis);
                    }
                }
            }
            Random rnd = new Random();
            MegstamiDalykai.Add(skirtingiHobiai[rnd.Next(0, skirtingiHobiai.Count)]);






        }

    }
}
