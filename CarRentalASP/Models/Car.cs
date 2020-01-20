using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalASP.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public String Color { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public double RentalAmount { get; set; }
    }
}