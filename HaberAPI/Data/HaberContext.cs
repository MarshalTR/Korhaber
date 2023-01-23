using HaberAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HaberAPI.Data
{
    public class HaberContext:DbContext
    {
        public HaberContext(DbContextOptions<HaberContext> options) : base(options)
        {

        }
        public DbSet<Haber> Haberler { get; set; }
    }
}
