using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.TestimonialDto
{
    public class UpdateTestimonialDto
    {
        public int TestimonialId { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialTitle { get; set; }
        public string TestimonialComment { get; set; }
        public string TestimonialImageUrl { get; set; }
        public bool TestimonialStatus { get; set; }
    }
}
