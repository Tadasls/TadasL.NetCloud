using P02_Rest_Endpoints.Models;
using P02_Rest_Endpoints.Models.Dto;

namespace P02_Rest_Endpoints.Data
{
    public static class DataDb
    {
        public static List<DataDTO> dataDuomenys = new List<DataDTO>()
            {
            new DataDTO(1, "tipas", "Turinys Zinutes", "05/29/2015", 55),
            new DataDTO(2, "tipas2", "Turinys Zinutes", "05/29/2018", 1),
            new DataDTO(3, "tipas3", "Turinys Zinutes", "05/29/2020", 1),
        
            };

     


    }
}
