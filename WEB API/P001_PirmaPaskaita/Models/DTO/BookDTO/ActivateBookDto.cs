using System.ComponentModel.DataAnnotations;
using System.Data;

namespace WebAppMSSQL.Models.DTO.BookDTO
{
    public class ActivateBookDto
    {
        public int Id { get; set; }
        public string KnygosStatusas { get; set; }


    }
}