using P058_Json;

namespace P058_Jason
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, JSON!");

            //SerializeDeserializeDemo.Show();
            SerializeDemoObject.Show();
            //DeserializeObjectsDemo.Show();
           // JsonDatesDemo.Show();
            
        }
    }

    /* ------------------------------------------------
### Turite sarasa. Serelizuokite json
List<string> games = new List<string> { "Starcraft", "Halo","Legend of Zelda"};
*/


    /* ------------------------------------------------
    ### Turite zodyna. Serelizuokite json
    Dictionary<string, int> points = new Dictionary<string, int>
    {
        { "James", 9001 },
        { "Jo", 3474 },
        { "Jess", 11926 }
    };
    */

    /* ------------------------------------------------
    ### Sukurkite objekta. skukurkite klase ir serelizuokite json
          Account account = new Account
          {
              Email = "james@example.com",
              Active = true,
              CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
              Roles = new List<string>
              {
                  "User",
                  "Admin"
              }
          };
          */



    /* ------------------------------------------------
     ### sukurkite klase, irasykite json i faila
      Movie movie = new Movie{Name = "Bad Boys",Year = 1995 };
     */



}