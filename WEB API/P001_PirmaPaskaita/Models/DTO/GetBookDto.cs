﻿using L05_Tasks_MSSQL.Models;
using System.ComponentModel.DataAnnotations;
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
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public string PavadinimasIrAutorius { get; set; }

        /// <summary>
        /// Isleidimo metais paduodami skaiciaus int formatu
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        [Range(typeof(DateTime), "0000-01-01", "2021-01-01", ErrorMessage = "Year must be between 1900-01-01 and 2021-01-01")]
        public int LeidybosMetai { get; set; }
    }
}


