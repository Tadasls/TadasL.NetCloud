using P02_Rest_Endpoints.Models;
using P02_Rest_Endpoints.Models.Dto;

namespace P02_Rest_Endpoints.Data
{
    public static class DataDb
    {
        public static List<DataDTO2> dataDuomenys = new List<DataDTO2>()
            {
            new DataDTO2(1, "tipas", "Turinys Zinutes", "05/29/2015", 55),
            new DataDTO2(2, "tipas2", "Turinys Zinutes", "05/29/2018", 1),
            new DataDTO2(3, "tipas3", "Turinys Zinutes", "05/29/2020", 1),
        
            };

     


    }
}
