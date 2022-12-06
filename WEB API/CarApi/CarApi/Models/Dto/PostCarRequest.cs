using CarApi.Database.InitialData;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CarApi.Models.Dto
{
    public class PostCarRequest
    {
        /// <summary>
        /// Automobilio gamintojo pavadinimas
        /// </summary>
        [MaxLength(50, ErrorMessage = "Mark cannot be longer than 50 characters")]
        public string Mark { get; set; }

        [MaxLength(50, ErrorMessage = "Model cannot be longer than 50 characters")]
        public string Model { get; set; }
        /// <summary>
        /// Automobilio pagaminimo metai formatu yyyy-MM-dd
        /// </summary>
        [Range(typeof(DateTime), "1900-01-01", "2021-01-01", ErrorMessage = "Year must be between 1900-01-01 and 2021-01-01")]
        public string Year { get; set; }

        [MaxLength(20, ErrorMessage = "Model cannot be longer than 50 characters")]
        public string? PlateNumber { get; set; }

        /// <summary>
        /// Autotomobilio pavaru dezes tipas. Galimos reiksmes Manual ir Automatic
        /// </summary>
        [MaxLength(15, ErrorMessage = "Model cannot be longer than 50 characters")]
        public string GearBox { get; set; }
        /// <summary>
        /// Automobilio kuro tipas. Galimos reiksmes Petrol, Diesel ir Electric
        /// </summary>
        [MaxLength(15, ErrorMessage = "Model cannot be longer than 50 characters")]
        public string Fuel { get; set; }
    }
}

