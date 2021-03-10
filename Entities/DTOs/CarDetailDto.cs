using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    //DTO : Data Transformation Object
    public class CarDetailDto:IDto
    {
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
