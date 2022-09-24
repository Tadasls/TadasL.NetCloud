using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook_App.Models
{
    public class NoteBook
    {
        public NoteBook()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDatetime { get; set; }
        public string Priority { get; set; }


    }
}