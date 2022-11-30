using L05_Tasks_MSSQL.Models.Enums;

namespace L05_Tasks_MSSQL.Models.DTO
{
    public class CreateBookDto
    {
        public string Pavadinimas { get; set; }

        public string Autorius { get; set; }

        /// <summary>
        /// Isleidimo metais paduodami DateTime formatu
        /// </summary>
        public DateTime Isleista { get; set; }

        /// <summary>
        /// Knygos tipas papuodamas string formatu
        /// </summary>
        public string KnygosTipas { get; set; }
    }
}
