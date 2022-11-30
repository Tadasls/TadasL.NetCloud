using Castle.Components.DictionaryAdapter;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02_Rest_Endpoints.Models
{
    public class DBData
    {
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public string EndDate { get; set; }
        public int UserId { get; set; }

        public DBData()
        {

        }

        public DBData(int id, string type, string content, string endDate, int userId)
        {
            Id = id;
            Type = type;
            Content = content;
            EndDate = endDate;
            UserId = userId;
        }
    }
}
