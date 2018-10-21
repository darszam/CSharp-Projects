using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class MusicAsset
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Tuning { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DurationTime { get; set; }
        [Range(0,60)]
        public int Minutes { get; set; }
        [Range(0,60)]
        public int Seconds { get; set; }
    }
}
