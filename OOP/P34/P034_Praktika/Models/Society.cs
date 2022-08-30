using P034_Praktika.InitalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P034_Praktika.Models
{
    public class Society
    {
        public List<Person> People { get; set; }

        public void FillPeople()
        {
            People = PersonInitialData.DataSeed.ToList();
        }
        public List<Person> OldPeople
        {
            get
            {
                var lst = new List<Person>();
                foreach (var p in People)
                {
                    if (p.BirthDate < new DateTime(2001, 1, 1))
                        lst.Add(p);
                }

                return lst;
            }
        }

    }
}
