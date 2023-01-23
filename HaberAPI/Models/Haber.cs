using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberAPI.Models
{
    public class Haber
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Metin { get; set; }
        public string Kategori { get; set; }
        public string ResimYolu { get; set; }
    }
}
