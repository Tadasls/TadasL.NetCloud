using L05_Tasks_MSSQL.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace L05_Tasks_MSSQL.Models.DTO
{
    public class CreateBookDto
    {


        /// <summary>
        /// Knygos pavadinimas
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public string Pavadinimas { get; set; }


        /// <summary>
        /// Isleidimo metais paduodami skaiciaus int formatu
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public string Autorius { get; set; }


        /// <summary>
        /// Isleidimo metais paduodami DateTime formatu
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public DateTime Isleista { get; set; }


        /// <summary>
        /// Knygos tipas papuodamas string formatu
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public string KnygosTipas { get; set; }
    }
}
