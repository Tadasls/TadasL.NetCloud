using L05_Tasks_MSSQL.Models.Enums;

namespace L05_Tasks_MSSQL.Models.DTO
{
    public class FilterBooksRequestDto
    {
        public string Pavadinimas { get; set; }

        public string Autorius { get; set; }

        public string KnygosTipas { get; set; }
    }
}
