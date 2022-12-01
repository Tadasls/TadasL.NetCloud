using L05_Tasks_MSSQL.Models;
using System.Net;

namespace L05_Tasks_MSSQL.Models.DTO
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
        }

        public int Id { get; set; }

        /// <summary>
        /// Pavadinimas ir Autoriaus vardas sujungtas i viena
        /// </summary>
        public string PavadinimasIrAutorius { get; set; }

        /// <summary>
        /// Isleidimo metais paduodami skaiciaus int formatu
        /// </summary>
        public int LeidybosMetai { get; set; }
    }
}


