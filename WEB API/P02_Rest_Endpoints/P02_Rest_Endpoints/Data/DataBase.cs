using P02_Rest_Endpoints.Models;
using P02_Rest_Endpoints.Models.Dto;

namespace P02_Rest_Endpoints.Data
{
    public static class DataBase
    {
        public static List<Fan> fanai = new List<Fan>()
            {
            new Fan(1, "Petras1", "Spain", 7),
            new Fan(2, "Petras2", "Spain", 23),
            new Fan(3, "Petras3", "Africa", 7),
            new Fan(4, "Petras4", "Italy", 7),
            new Fan(5, "Petras5", "Germany", 7),
            new Fan(6, "Petras6", "Lithuania", 7),
            };

        public static List<Athlete> atletai = new List<Athlete>()
            {
            new Athlete(1, "Orange", "Spain", 7),
            new Athlete(2, "Apple", "Spain", 23),
            new Athlete(3, "Banana", "Africa", 7),
            new Athlete(4, "Pizza", "Italy", 7),
            new Athlete(5, "Sausages", "Germany", 7),
            new Athlete(6, "Potatoes", "Lithuania", 7),
            };

        public static List<Sport> sportoSakos = new List<Sport>()
            {
            new Sport(1, "Orange", "Spain", 7),
            new Sport(2, "Apple", "Spain", 23),
            new Sport(3, "Banana", "Africa", 7),
            new Sport(4, "Pizza", "Italy", 7),
            new Sport(5, "Sausages", "Germany", 7),
            new Sport(6, "Potatoes", "Lithuania", 7),
            };











    }
}
