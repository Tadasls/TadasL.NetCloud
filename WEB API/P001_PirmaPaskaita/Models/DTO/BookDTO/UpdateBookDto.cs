using System.ComponentModel.DataAnnotations;
using System.Data;
using WebAppMSSQL.Models.Enums;

namespace WebAppMSSQL.Models.DTO.BookDTO
{
    public class UpdateBookDto
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Knygos išleidimos metai
        /// </summary>
        [Range(typeof(DateTime), "1900-01-01", "2023-01-01", ErrorMessage = "Isleista must be between 1900-01-01 and 2023-01-01")]
        public DateTime Isleista { get; set; }

        /// <summary>
        /// Author of the book
        /// </summary>
        [MaxLength(255, ErrorMessage = "Autorius cannot be longer than 255 characters")]
        public string Autorius { get; set; }

        /// <summary>
        /// Book title
        /// </summary>
        [MaxLength(255, ErrorMessage = "Pavadinimas cannot be longer than 255 characters")]
        public string Pavadinimas { get; set; }

        /// <summary>
        /// Cover type of the book
        /// </summary>
        [MaxLength(15, ErrorMessage = "Knygos tipas cannot be longer than 15 characters")]
        public string KnygosTipas { get; set; }

        /// <summary>
        /// Knygos kiekis
        /// </summary>
        public int KnyguKiekis { get; set; }
        ///// <summary>
        ///// Knygos info atnaujinimo data
        ///// </summary>
        //public DateTime Updated { get; set; }

        public string KnygosStatusas { get; set; }


    }
}