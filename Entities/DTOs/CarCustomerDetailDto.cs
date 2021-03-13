using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarCustomerDetailDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public String UserLastName { get; set; }
        public string CompanyName { get; set; }
    }
}
