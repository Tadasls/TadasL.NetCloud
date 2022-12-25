namespace WebAppMSSQL.Models.DTO.NotificationDTO
{
    public class CreateNotificationDto
    {

        public int Id { get; set; }
        public string Topic { get; set; }
        public string Message { get; set; }
        public int LocalUserId { get; set; }


 
    }

}

