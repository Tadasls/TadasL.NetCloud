namespace P02_Rest_Endpoints.Models.Dto
{
    public class UserDTO

    {
        public UserDTO(int id, string userName, string userLastname, string userEmail)
        {
            this.id = id;
            this.userName = userName;
            this.userLastname = userLastname;
            this.userEmail = userEmail;
        }

        public int id { get; set; }
        public string userName { get; set; }
        public string userLastname { get; set; }
        public string userEmail { get; set; }
    }
}
