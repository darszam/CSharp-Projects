using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DemoCoreWebAppMVC.Models
{
    public class Music
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode=true)]
        public DateTime ReleaseTime { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
