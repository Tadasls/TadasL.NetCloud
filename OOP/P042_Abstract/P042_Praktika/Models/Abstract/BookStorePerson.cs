namespace P043_Uzduotys.Models.Abstract
{
    public abstract class BookStorePerson
    {
        public string Code { get; set; }
        public virtual string PhoneNo { get; set; }
        public virtual string Address { get; set; }
    }
}