using System.ComponentModel.DataAnnotations;
using System.Net;

namespace WebAppMSSQL.Models.DTO.BookDTO
{
    public class GetBookDto
    {
        public GetBookDto()
        {

        }

        public GetBookDto(Book book)
        {
            Id = book.Id;
            PavadinimasIrAutorius = book.Title + " " + book.Author;
            LeidybosMetai = book.PublishYear;
            KnyguKiekis = book.Stock;

        }


        public int Id { get; set; }

        /// <summary>
        /// Pavadinimas ir Autoriaus vardas sujungtas i viena
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public string PavadinimasIrAutorius { get; set; }

        /// <summary>
        /// Isleidimo metais paduodami skaiciaus int formatu
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        [Range(typeof(DateTime), "0000-01-01", "2021-01-01", ErrorMessage = "Year must be between 1900-01-01 and 2021-01-01")]
        public int LeidybosMetai { get; set; }


        /// <summary>
        /// Knygos kiekis
        /// </summary>
        public int KnyguKiekis { get; set; }

    }
}


