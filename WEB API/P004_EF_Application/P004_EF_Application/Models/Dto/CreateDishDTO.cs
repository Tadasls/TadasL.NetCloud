﻿namespace P004_EF_Application.Models.Dto
{
    public class CreateDishDTO
    {
              
        public string Name { get; set; }
        public string Type { get; set; }
        public string SpiceLevel { get; set; }
        public string Country { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedDateTime { get; set; }


    }
}
