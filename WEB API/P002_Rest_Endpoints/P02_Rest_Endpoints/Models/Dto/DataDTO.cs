namespace P02_Rest_Endpoints.Models.Dto
{
    public class DataDTO

    {
        public DataDTO(DBData duomenys)
        {
            Id = duomenys.Id;
            Type = duomenys.Type;
            Content = duomenys.Content;
            EndDate = duomenys.EndDate;
            UserId = duomenys.UserId;
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public string EndDate { get; set; }
        public int UserId { get; set; }
    }
}
