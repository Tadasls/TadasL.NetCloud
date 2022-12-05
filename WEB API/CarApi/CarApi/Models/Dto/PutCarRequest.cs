namespace CarApi.Models.Dto
{
    public class PutCarRequest
    {

        /// <summary>
        /// Automobilio gamintojo pavadinimas 
        /// </summary>
        public string Mark { get; set; }
        public string Model { get; set; }
        /// <summary>
        /// Automobilio pagaminimo metai formatu yyyy-MM-dd
        /// </summary>
        public string Year { get; set; }
        public string PlateNumber { get; set; }
        /// <summary>
        /// Automobilio pavaru dezes tipas Galimo sreiksmes Manual ir Automatic 
        /// </summary>
        public string GearBox { get; set; }
        /// <summary>
        /// Automobilio kuro tipas Galima Dyzelis, Benzinas, Elektrinis 
        /// </summary>
        public string Fuel { get; set; }

    }





}


