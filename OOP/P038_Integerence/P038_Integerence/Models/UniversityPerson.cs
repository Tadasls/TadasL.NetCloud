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
        public List<Hobby>Hobbies { get; set; } = new List<Hobby>();

        private Random _rnd;
        public UniversityPerson()
        {
            _rnd = new Random();
        }
        public UniversityPerson(Random rnd)
        {
            _rnd = rnd;
        }
        public int SetHobbies(string[] data)
        {
           Hobbies = new List<Hobby>();
            int hobbiesCount = _rnd.Next(0, 5);
            return hobbiesCount;
        }
        public void PaimaHobiuSarasaIrPriskiriaAtsitiktinius4HobiusIProperties(int hobbiesCount) 
        {
            List<string> hobbyDuomenuSarasas = HobbyInitialData.DataSeedCsv.ToList();

            Random rnd = new Random();
            int numberOfHobbies = hobbiesCount; //rnd.Next(0, 5);

            for (int i = 0; i <= numberOfHobbies; i++)
            {
                Hobby hobby = new Hobby();

                int rndIndx = rnd.Next(hobbyDuomenuSarasas.Count);
                hobby.UzpildytiHobioProperties(hobbyDuomenuSarasas[rndIndx]);
                hobbyDuomenuSarasas.RemoveAt(rndIndx);
                Hobbies.Add(hobby);
            }
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




