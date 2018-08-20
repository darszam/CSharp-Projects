using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreWebAppMVC.Models
{
    public class MusicGenreViewModel
    {
        public List<Music> musics;
        public SelectList genres;
        public string MusicGenre { get; set; }
    }
}
