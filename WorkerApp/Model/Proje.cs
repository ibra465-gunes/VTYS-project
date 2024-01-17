using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerApp.Model
{
    [Table("Proje")]
    public class Proje
    {
        [Key]
        [Column("Proje No")]
        public int ProjeNo { get; set; }

        [Required]
        [Column("Proje Adı")]
        [StringLength(100)]
        public string ProjeAdi { get; set; }

        [Required]
        [Column("Başlangıç Tarihi")]
        public DateTime BaslangicTarihi { get; set; }

        [Required]
        [Column("Bitiş Tarihi")]
        public DateTime BitisTarihi { get; set; }

        [Column("Gecikme Miktarı")]
        public int? GecikmeMiktari { get; set; }

        // Proje ve Görev arasında bir-birçok ilişki
        
        public virtual ICollection<Gorev> Gorevler { get; set; }

        // Proje ve Çalışan arasında birçok-birçok ilişki
        public virtual ICollection<ProjeCalisan> ProjeCalisanlar { get; set; }
    }
}
