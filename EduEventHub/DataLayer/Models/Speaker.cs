using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Speaker : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public string? ImgPath { get; set; }
        public string Specialization { get; set; } = string.Empty;

        public ICollection<SpeakerSocialMedia> SocialMedias { get; set; } = new List<SpeakerSocialMedia>();
        public ICollection<EventContent> EventContents { get; set; } = new List<EventContent>();
    }
}
