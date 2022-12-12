﻿using System.ComponentModel.DataAnnotations;

namespace WebAppMSSQL.Models.DTO.BookDTO
{
    public class UpdateBookDto
    {
        public UpdateBookDto()
        {

        }
        public UpdateBookDto(int id, DateTime isleista, string autorius, string pavadinimas, string knygosTipas, int knyguKiekis)
        {
            Id = id;
            Isleista = isleista;
            Autorius = autorius;
            Pavadinimas = pavadinimas;
            KnygosTipas = knygosTipas;
            KnyguKiekis = knyguKiekis;
        }


        public int Id { get; set; }


        /// <summary>
        /// pagaminimo metai formatu yyyy-MM-dd. Galima metai nuo 0000-01-01 iki 2023-01-01
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        [Range(typeof(DateTime), "0000-01-01", "2023-01-01", ErrorMessage = "Year must be between 1900-01-01 and 2021-01-01")]
        public DateTime Isleista { get; set; }

        /// <summary>
        /// Knygos Autorius
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public string Autorius { get; set; }


        /// <summary>
        /// Knygos pavadinimas
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public string Pavadinimas { get; set; }


        /// <summary>
        /// Knygos tipas
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public string KnygosTipas { get; set; }

        /// <summary>
        /// Knygos kiekis
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public int KnyguKiekis { get; set; }
    }
}