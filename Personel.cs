using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class Personel
    {
        [Key]
        public int perId { get; set; }
        public string perAd { get; set; }
        public string perSoyad{ get; set; }
    }
}
