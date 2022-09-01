using P045_Generics.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P045_Generics.Domain.Models
{
    public class Cordinate<T> : ICordinate
    {

        public Cordinate()
        {
            
        }

        public Cordinate(T x, T y)
        {
            X = x;
            Y = y;
        }

        public T X { get; set; }
        public T Y { get; set; }



        public string GetCordinate()
        {
            return $"{X};{Y}";
        }

        public void ResetCordinate()
        {
           
            X = default(T);
            Y = default(T);
        }

       
    }
}
