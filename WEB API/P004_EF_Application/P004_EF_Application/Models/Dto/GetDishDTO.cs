namespace P004_EF_Application.Models.Dto
{
    public class GetDishDTO
    {
        public GetDishDTO(Dish dish)
        {
            Name = dish.Name;
            Type = dish.Type;
            SpiceLevel = dish.SpiceLevel;
            Country = dish.Country;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string SpiceLevel { get; set; }
        public string Country { get; set; }
  



    }
}
