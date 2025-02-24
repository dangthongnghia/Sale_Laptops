using System.ComponentModel.DataAnnotations;


namespace Sale_laptop_online.Models
{
    public class Laptop
    {
        public int Id { get; set; }

        public string ? Title { get; set; }
        public string ?Model { get; set; }
        public string ?Name { get; set; }
        public string ?CPU { get; set; }
        public string ?OS { get; set; }
        public string ?RAM { get; set; }
        public string ?Storage { get; set; }
        public string ?Battery { get; set; }
        public string ?Display { get; set; }
        public string ?Card { get; set; }
        public decimal ?Price { get; set; }


        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public string ?Image { get; set; }
        public string ?Description { get; set; }

    }
}
