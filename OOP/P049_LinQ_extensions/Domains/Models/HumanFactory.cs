using Domains.Models;
using P049_LINQ_Extension.Domain.InitialData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P049_LINQ_Extension.Domain.Models
{
    public class HumanFactory : IHumanFactory
    {
        public IEnumerable<Human> Bind()
        {
            foreach (var character in CharacterInitialData.DataSeedCSV.Where(c => c.Contains("Human")))
            {
                var characterArray = character.Split(",");
                yield return new Human(characterArray[0].Trim(), characterArray[1].Trim(), (EGender)int.Parse(characterArray[4].Trim()));
            }
        }

       
       
    }
}
