using P038_Praktika.InitalData;
using P038_Praktika.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038_Integerence.Models
{
    public class UniversityPerson : Person
    {     
        public Profession Profession { get; set; }
        public List<Hobby>Hobbies { get; set; } // = new List<Hobby>(); //inicilizuojame konstruktoriuje

        private Random _rnd; // neinicilizuojame kad nebutu klase ir galetume testoti
        public UniversityPerson()  //metode iniciliacuojame random kad nebutu klase
        {
            _rnd = new Random();
        }
        public UniversityPerson(Random rnd)  // random paduodame per parametra kad butu testuojamas
        {
            _rnd = rnd;
        }
        public void SetHobbies(string[] data)
        {

           // string[] data = HobbyInitialData.DataSeedCsv.ToList(); sutvarkyti pagal irasa

            Hobbies = new List<Hobby>();
            List<int> indexesTaken = new List<int>(); //masyvas loginantis kokie hobiu indeksai jau buvo paimti

            //sugeneruoti skaiciu nuo 0 iki 4 - hobiu kieki
            int hobbiesCount = _rnd.Next(0, 5);
            for (int i = 0; i < hobbiesCount; i++)
            {
                int hobbyIndex;
                do
                {
                    hobbyIndex = _rnd.Next(0, data.Length);
                }
                while (indexesTaken.Contains(hobbyIndex));
                indexesTaken.Add(hobbyIndex);
            }

            FillHobbies(data, indexesTaken);
        }

        private void FillHobbies(string[] data, List<int> indexesTaken)
        {
            foreach (var index in indexesTaken)
            {
                Hobby h = new Hobby();
                h.EncodeCsv(data[index]);
                Hobbies.Add(h);
            }
        }

        //public void PaimaHobiuSarasaIrPriskiriaAtsitiktinius4HobiusIProperties(int hobbiesCount) 
        //{
        //    List<string> hobbyDuomenuSarasas = HobbyInitialData.DataSeedCsv.ToList();

        //    Random rnd = new Random();
        //    int numberOfHobbies = hobbiesCount; //rnd.Next(0, 5);

        //    for (int i = 0; i <= numberOfHobbies; i++)
        //    {
        //        Hobby hobby = new Hobby();

        //        int rndIndx = rnd.Next(hobbyDuomenuSarasas.Count);
        //        hobby.EncodeCsv(hobbyDuomenuSarasas[rndIndx]);
        //        hobbyDuomenuSarasas.RemoveAt(rndIndx);
        //        Hobbies.Add(hobby);
        //    }
        //}

        public void SetProfession(Profession[] data)
        {
            int professionIndex = _rnd.Next(0, data.Length);
            Profession = data[professionIndex];
        }
        public void SetProfession(string[] data)
        {
            int professionIndex = _rnd.Next(0, data.Length);
            Profession profession = new();
            profession.EncodeCsv(data[professionIndex].Replace(";", ","));
            Profession = profession;
        }



        public string GetCsv()
        {


            return $"{Id},{FirstName},{LastName},{Gender},{BirthDate},{Weight},{Height},{Profession.Id}" +
                $",{(Hobbies.Count > 0 ? Hobbies[0].Id : "")}" +
                $",{(Hobbies.Count > 1 ? Hobbies[1].Id : "")}" +
                $",{(Hobbies.Count > 2 ? Hobbies[2].Id : "")}" +
                $",{(Hobbies.Count > 3 ? Hobbies[3].Id : "")}";
        }




        public void PickProfessionRandomly(Random rnd)
        {
            int pasirinkimas = rnd.Next(3);

            if (pasirinkimas == 1)
            {
                Profession randomProfession = ProfessionInitialData.DataSeed[rnd.Next(ProfessionInitialData.DataSeed.Length)];
                Profession = randomProfession;
            }
            else if (pasirinkimas == 2)
            {
                var randomProfession = ProfessionInitialData.DataSeedCsvComma[rnd.Next(ProfessionInitialData.DataSeedCsvSemicolon.Length)];
                Profession = new Profession(randomProfession.Split(";"));
            }
            else if (pasirinkimas == 3)
            {
                var randomProfession = ProfessionInitialData.DataSeedCsvComma[rnd.Next(ProfessionInitialData.DataSeedCsvComma.Length)];
                Profession = new Profession(randomProfession.Split(","));
            }
        }
        public string GetCSV()
        {
            var text = new StringBuilder(Profession.GetCsv());

            foreach (var hobby in Hobbies)
            {
                text.Append($",{hobby.GetCsv()}");
            }

            return text.ToString();
        }


    }     

}




