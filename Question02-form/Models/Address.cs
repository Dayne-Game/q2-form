using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question02_form.Interfaces;

namespace Question02_form.Models
{
    public class Address : IAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
    }
}
