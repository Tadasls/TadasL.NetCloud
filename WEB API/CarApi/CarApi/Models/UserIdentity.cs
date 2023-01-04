namespace CarApi.Models
{
    public class UserIdentity
    {

        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string AsmensKodas { get; set; }
        public int Id { get; set; }
        public virtual LocalUser LocalUser { get; set; }

    }
}
