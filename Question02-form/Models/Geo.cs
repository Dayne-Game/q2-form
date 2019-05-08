using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question02_form.Interfaces;

namespace Question02_form.Models
{
    class Geo : IGeo
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }
}
