using P038_Integerence.InitialData;

namespace P038_Integerence.Models
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
