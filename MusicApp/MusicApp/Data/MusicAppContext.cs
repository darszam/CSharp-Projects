using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MusicApp.Models
{
    public class MusicAppContext : DbContext
    {
        public MusicAppContext (DbContextOptions<MusicAppContext> options)
            : base(options)
        {
        }

        public DbSet<MusicApp.Models.MusicAsset> MusicAsset { get; set; }
    }
}
