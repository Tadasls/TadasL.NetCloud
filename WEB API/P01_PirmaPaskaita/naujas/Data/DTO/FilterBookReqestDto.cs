using ApiMokymai.Books;

namespace ApiMokymai.Data.DTO
{
    public class FilterBookReqestDto
    {
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }
        public ECoverType KnygosTipas { get; set; }


    }
}
