using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.AboutDto
{
    public class UpdateAboutDto
    {
        public int AboutId { get; set; }
        public string AboutImageUrl { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDescription { get; set; }
    }
}
