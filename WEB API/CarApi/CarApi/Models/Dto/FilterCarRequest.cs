namespace CarApi.Models.Dto
{
    public class FilterCarRequest
    {
                 
            /// <summary>
            /// Automobilio gamintojo pavadinimas 
            /// </summary>
            public string? Mark { get; set; }
            public string? Model { get; set; }
                       /// <summary>
            /// Automobilio pavaru dezes tipas Galimo sreiksmes Manual ir Automatic 
            /// </summary>
            public string? GearBox { get; set; }
            /// <summary>
            /// Automobilio kuro tipas Galima Dyzelis, Benzinas, Elektrinis 
            /// </summary>
            public string? Fuel { get; set; }
                

    }



}


