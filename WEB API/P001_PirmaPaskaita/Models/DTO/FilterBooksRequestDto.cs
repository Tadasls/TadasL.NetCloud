using L05_Tasks_MSSQL.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace L05_Tasks_MSSQL.Models.DTO
{
    public class FilterBooksRequestDto
    {
        public FilterBooksRequestDto()
        {

        }
      
        public FilterBooksRequestDto(string pavadinimas, string autorius, string knygosTipas)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            KnygosTipas = knygosTipas;
        }

        /// <summary>
        /// Knygos pavadinimas
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public string? Pavadinimas { get; set; }

        /// <summary>
        /// Knygos Autorius
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public string? Autorius { get; set; }

        /// <summary>
        /// KnygosTipas
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public string? KnygosTipas { get; set; }
    }
}
