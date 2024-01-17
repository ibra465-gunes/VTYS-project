using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerApp.Model
{
    public class Gorev
    {
        [Key]
        [Column("Görev No")]
        public int GorevNo { get; set; }

        [Required]
        [Column("Görev Adı")]
        [StringLength(100)]
        public string GorevAdi { get; set; }

        [Required]
        [Column("Başlangıç Tarihi")]
        public DateTime BaslangicTarihi { get; set; }

        [Required]
        [Column("Bitiş Tarihi")]
        public DateTime BitisTarihi { get; set; }

        [Required]
        [Column("Adam Gün Değeri")]
        public int AdamGunDegeri { get; set; }

        [Required]
        [Column("Durum")]
        [StringLength(20)]
        public string Durum { get; set; }
        [ForeignKey("Proje")]
        [Column("Proje No")]
        public int ProjeNo { get; set; }
        [Required]
        [ForeignKey("Calisan")]
        [Column("Çalışan No")]
        public int CalisanNo { get; set; }

        // Görev ve Proje arasında bir-birçok ilişki
        public virtual Proje Proje { get; set; }
    }
}
