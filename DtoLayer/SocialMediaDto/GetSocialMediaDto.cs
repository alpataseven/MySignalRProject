using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.SocialMediaDto
{
    public class GetSocialMediaDto
    {
        public int SocialMediaId { get; set; }
        public int SocialMediaTitle { get; set; }
        public int SocialMediaUrl { get; set; }
        public int SocialMediaIcon { get; set; }
    }
}
