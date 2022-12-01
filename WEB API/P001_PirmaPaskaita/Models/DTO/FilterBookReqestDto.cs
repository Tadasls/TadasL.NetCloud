using L05_Tasks_MSSQL.Models.Enums;

namespace L05_Tasks_MSSQL.Models.DTO
{
    public class FilterBooksRequestDto
    {
        public FilterBooksRequestDto(string pavadinimas, string autorius, string knygosTipas)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            KnygosTipas = knygosTipas;
        }

        public string Pavadinimas { get; set; }

        public string Autorius { get; set; }

        public string KnygosTipas { get; set; }
    }
}
