using P045_Generics.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generics.Domain.Models
{
    public class PrivateClient : IUser
    {
        public PrivateClient()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
