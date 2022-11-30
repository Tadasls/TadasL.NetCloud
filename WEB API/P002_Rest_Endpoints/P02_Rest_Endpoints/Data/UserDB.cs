using P02_Rest_Endpoints.Models;
using P02_Rest_Endpoints.Models.Dto;

namespace P02_Rest_Endpoints.Data
{
    public static class UserDB
    {
        public static List<UserDTO> useriuSarasas = new List<UserDTO>()
            {
            new UserDTO(1, "Tonis", "Soprano", "mafija@kaunas.lt" ),
            new UserDTO(2, "Tacis", "Lauris", "tacis@lauris.lt" ),
            new UserDTO(3, "Petras3", "Petraitis3", "petras@petraitis.lt" ),
            new UserDTO(4, "Petras4", "Petraitis4", "petras@petraitis.lt" ),
            };

     


    }
}
