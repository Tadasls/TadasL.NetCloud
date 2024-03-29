﻿using P045_Generics.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generics.Domain.Models
{
    public class Fork : Tool, ITool
    {
        public Fork() { }

        public Fork(string name) { }

        public int Id { get; set; }
        public string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine("This is a fork which is used for eating hard food.");
        }

        public override string ToString()
        {
            return "I am a fork. Here is some text that I wanted to say.";
        }
    }
}