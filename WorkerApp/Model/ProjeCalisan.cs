using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerApp.Model
{
    [Table("ProjeCalisan")]
    public class ProjeCalisan
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Proje")]
        public int ProjeNo { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Calisan")]
        public int CalisanNo { get; set; }

        public virtual Proje Proje { get; set; }
        public virtual Calisan Calisan { get; set; }
    }
}
