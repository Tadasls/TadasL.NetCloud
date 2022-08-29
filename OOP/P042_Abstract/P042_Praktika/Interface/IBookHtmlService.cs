using P042_Praktika.Enums;
using P042_Praktika.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Praktika.Models.Interface
{
    public interface IBookHtmlService
    {
        Dictionary<BookType, List<Book>>Decode(string dataSeed);
        string Encode(Dictionary<BookType, List<Book>> books);
    }
}
