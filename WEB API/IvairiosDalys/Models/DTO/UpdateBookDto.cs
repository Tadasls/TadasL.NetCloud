using L05_Tasks_MSSQL.Models.Enums;

namespace L05_Tasks_MSSQL.Models.DTO
{
    public class UpdateBookDto
    {
        public int Id { get; set; }
        /// <summary>
        /// Isleidimo metais DateTime formatas
        /// </summary>
        public DateTime Isleista { get; set; }

        public string Autorius { get; set; }

        public string Pavadinimas { get; set; }

        public string KnygosTipas { get; set; }
    }
}