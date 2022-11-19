namespace P02_Rest_Endpoints.Models
{
    public class Sport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int PleoplePlaing { get; set; }

        public Sport(int id, string name, string country, int pleoplePlaing)
        {
            Id = id;
            Name = name;
            Country = country;
            PleoplePlaing = pleoplePlaing;
        }


    }

}
