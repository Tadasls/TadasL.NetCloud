using System.ComponentModel.DataAnnotations;

namespace WebAppMSSQL.Models.DTO.BookDTO
{
    public class CreateBookDto
    {
        //public CreateBookDto(string pavadinimas, string autorius, DateTime isleista, string knygosTipas, int knyguKiekis)
        //{
        //    Pavadinimas = pavadinimas;
        //    Autorius = autorius;
        //    Isleista = isleista;
        //    KnygosTipas = knygosTipas;
        //    KnyguKiekis = knyguKiekis;
        //}




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
        /// Knygos išleidimos metai
        /// </summary>
        [Range(typeof(DateTime), "1900-01-01", "2025-01-01", ErrorMessage = "Isleista must be between 1900-01-01 and 2023-01-01")]
        public DateTime Isleista { get; set; }

        /// <summary>
        /// Knygos tipas papuodamas string formatu
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public string KnygosTipas { get; set; }

        /// <summary>
        /// Knygos kiekis
        /// </summary>
        public int KnyguKiekis { get; set; }
    }
}
