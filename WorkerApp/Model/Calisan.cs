using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerApp.Model
{
    public class Calisan
    {
        [Key]
        [Column("Çalışan No")]
        public int CalisanNo { get; set; }

        [Required]
        [Column("Çalışan Adı")]
        [StringLength(100)]
        public string CalisanAdi { get; set; }

        [Required]
        [Column("Çalışan Soyadı")]
        [StringLength(100)]
        public string CalisanSoyadi { get; set; }

        [Column("Tamamlanan Görev Sayısı")]
        public int? TamamlananGorevSayisi { get; set; }

        [Column("Geciken Görev Sayısı")]
        public int? GecikenGorevSayisi { get; set; }

        // Çalışan ve Proje arasında birçok-birçok ilişki
        public virtual ICollection<ProjeCalisan> ProjeCalisanlar { get; set; }
    }
}
