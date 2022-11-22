namespace P02_Rest_Endpoints.Models.Dto
{
    public class DataDTO

    {
        public DataDTO(int id, string type, string content, string endDate, int UserId)
        {
            this.id = id;
            this.type = type;
            this.content = content;
            this.endDate = endDate;
            this.UserId = UserId;
        }

        public int id { get; set; }
        public string type { get; set; }
        public string content { get; set; }
        public string endDate { get; set; }
        public int UserId { get; set; }
    }
}
