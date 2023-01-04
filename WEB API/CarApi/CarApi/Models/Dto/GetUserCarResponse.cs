namespace CarApi.Models.Dto
{
    public class GetUserCarResponse
    {

        public GetUserCarResponse()
        {

        }
        public GetUserCarResponse(string vardas, string pavarde, string asmensKodas, IList<GetUserCarResponseCar> automobiliai)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            AsmensKodas = asmensKodas;
            Automobiliai = automobiliai;
        }

        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string AsmensKodas { get; set; }

        public IList<GetUserCarResponseCar> Automobiliai { get; set; }


    }
}