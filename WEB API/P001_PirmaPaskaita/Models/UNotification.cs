using System.ComponentModel.DataAnnotations;

namespace WebAppMSSQL.Models
{
    public class UNotification
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Message { get; set; }
        public int LocalUserId { get; set; }
        public bool IsSeen { get; set; }    
        virtual public LocalUser LocalUser { get; set; } // virtualus
    }
}