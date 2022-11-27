namespace P02_Rest_Endpoints.Models.Dto
{
    public class DataDTO2

    {
        public DataDTO2(int id, string type, string content, string endDate, int UserId)
        {
            this.id = id;
            this.type = type;
            this.content = content;
            this.endDate = endDate;
            this.UserId2 = UserId;
        }

        public int id { get; set; }
        public string type { get; set; }
        public string content { get; set; }
        public string endDate { get; set; }
        public int UserId2 { get; set; }
    }
}
