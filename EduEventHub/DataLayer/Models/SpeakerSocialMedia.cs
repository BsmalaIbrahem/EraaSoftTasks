using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class SpeakerSocialMedia : BaseModel
    {
        public int Id { get; set; }
        public int SpeakerId { get; set; }
        [ForeignKey(nameof(SpeakerId))]
        [NotMapped]
        public Speaker Speaker { get; set; } = new Speaker();
        public PlatForm Platform { get; set; }
        public string Url { get; set; } = string.Empty;
    }

    public enum PlatForm
    {
        Facebook = 0,
        Twitter = 1,
        LinkedIn = 2,
        Instagram = 3,
        YouTube = 4,
        TikTok = 5,
        Other = 6
    }


    }
