using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8_C_12
{
    internal class DataAnnotation
    {
        [Length(2, 20)]
        public string Name { get; set; }

        [Range(1, 1000, MinimumIsExclusive = true, MaximumIsExclusive = false)]
        public double Price { get; set; }

        [AllowedValues("Computers", "Video Games")]
        public string Category { get; set; }

        [DeniedValues("Printers")]
        public string SubCategory { get; set; }

        [Base64String]
        public string Description { get; set; }
    }
}
