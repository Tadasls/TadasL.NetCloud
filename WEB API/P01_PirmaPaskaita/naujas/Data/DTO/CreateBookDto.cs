using ApiMokymai.Books;

namespace ApiMokymai.Data.DTO
{
    public class CreateBookDto
    {
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }
        public DateTime Isleista { get; set; }
        public string KnygosTipas { get; set; }


    }
}
