using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;
using WorkerApp.Model;

namespace WorkerApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private AppDBContext _context;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private System.Windows.Forms.Form activeForm;
        public Form(AppDBContext context)
        {
            _context = context;
            InitializeComponent();
            random = new Random();
            panelWorker.Visible = false;
            panel_Project.Visible = false;
            panel_Tasks.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var calisanlar = _context.Calisanlar.ToList();
            //dataGridView1.DataSource = calisanlar;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelLogo.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(System.Windows.Forms.Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void btnWorker_Click(object sender, EventArgs e)
        {
            panelWorker.Visible = true;
            panelDesktopPane.Visible = false;
            panel_Project.Visible = false;
            panel_Tasks.Visible = false;
            lblTitle.Text = "Çalýþanlar";
            var calisanlar = _context.Calisanlar.Select(g => new { g.CalisanNo,g.CalisanAdi,g.CalisanSoyadi,g.TamamlananGorevSayisi,g.GecikenGorevSayisi }).ToList();
            dataGridView1.DataSource = calisanlar;
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            panelDesktopPane.Visible = false;
            panelWorker.Visible = false;
            panel_Project.Visible = true;
            panel_Tasks.Visible = false;
            lblTitle.Text = "Projeler";
            var projeler = _context.Projeler.Select(g => new { g.ProjeNo, g.ProjeAdi, g.BaslangicTarihi, g.BitisTarihi, g.GecikmeMiktari }).ToList();
            dataGridView2.DataSource = projeler;
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            panel_Tasks.Visible = true;
            panelDesktopPane.Visible = false;
            panelWorker.Visible = false;
            panel_Project.Visible = false;
            lblTitle.Text = "Görevler";
            var gorevler = _context.Gorevler.Select(g => new { g.GorevNo, g.GorevAdi, g.BaslangicTarihi, g.BitisTarihi, g.AdamGunDegeri, g.Durum }).ToList();
            dataGridView4.DataSource = gorevler;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var gecikenGorevler = _context.Projeler.Where(p => p.GecikmeMiktari > 0).ToList().Count;
            var tamamlananGorevler = _context.Projeler.Where(p => p.GecikmeMiktari < 0).ToList().Count;
            _context.Calisanlar.Add(new Calisan { CalisanAdi = txtWorkerName.Text, CalisanSoyadi = txtWorkerSurname.Text, GecikenGorevSayisi = gecikenGorevler, TamamlananGorevSayisi = tamamlananGorevler });
            _context.SaveChanges();

            var calisanlar = _context.Calisanlar.Select(g => new { g.CalisanNo, g.CalisanAdi, g.CalisanSoyadi, g.TamamlananGorevSayisi, g.GecikenGorevSayisi }).ToList();
            dataGridView1.DataSource = calisanlar.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var calisanlar = _context.Calisanlar.Find(id);
            _context.Calisanlar.Remove(calisanlar);
            _context.SaveChanges();
            var calisanlar1 = _context.Calisanlar.Select(g => new { g.CalisanNo, g.CalisanAdi, g.CalisanSoyadi, g.TamamlananGorevSayisi, g.GecikenGorevSayisi }).ToList();
            dataGridView1.DataSource = calisanlar1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dateTimePicker1.Value;
            DateTime bitis = dateTimePicker2.Value;

            int gecikmeMik = (DateTime.Now - bitis).Days;
            if (gecikmeMik < 0)
            {
                gecikmeMik = 0;
            }

            _context.Projeler.Add(new Proje { ProjeAdi = text2_Box1.Text, BaslangicTarihi = baslangic, BitisTarihi = bitis, GecikmeMiktari = gecikmeMik });
            _context.SaveChanges();
            var projeler = _context.Projeler.Select(g => new { g.ProjeNo, g.ProjeAdi, g.BaslangicTarihi, g.BitisTarihi, g.GecikmeMiktari }).ToList();
            dataGridView2.DataSource = projeler;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView2.CurrentRow.Cells[0].Value;
            var projeler = _context.Projeler.Find(id);
            _context.Projeler.Remove(projeler);
            var projeCalýsan = _context.ProjeCalisanlar.Find(projeler.ProjeNo);
            _context.ProjeCalisanlar.Remove(projeCalýsan);
            _context.SaveChanges();
            var projeler1 = _context.Projeler.Select(g => new { g.ProjeNo, g.ProjeAdi, g.BaslangicTarihi, g.BitisTarihi, g.GecikmeMiktari}).ToList();
            dataGridView2.DataSource = projeler1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var proje_ismi = textBox1.Text;
            DateTime baslangic = dateTimePicker3.Value;
            DateTime bitis = dateTimePicker4.Value;
            String gorevAdi = txt_gorev_adi.Text;
            var calisan = int.Parse(txtcalianId.Text);
            int adamgun = 0;
            String durum = null;
            if (checkBox1.Checked == true)
            {
                if (checkBox4.Checked == true)
                {
                    adamgun = 703;
                }
                else if (checkBox3.Checked == true)
                {
                    adamgun = 730;
                }
            }
            if (checkBox2.Checked == true)
            {
                if (checkBox4.Checked == true)
                {
                    adamgun = 153;
                }
                else if (checkBox3.Checked == true)
                {
                    adamgun = 1530;
                }
            }

            if (radioButton1.Checked == true)
            {
                durum = "TAMAMLANACAK";
            }
            if (radioButton2.Checked == true)
            {
                durum = "DEVAM EDÝYOR";
            }
            if (radioButton3.Checked == true)
            {
                durum = "TAMAMLANDI";
            }
            var proje = _context.Projeler.FirstOrDefault(p => p.ProjeAdi == proje_ismi);
            var calisan1 = _context.Calisanlar.FirstOrDefault(p => p.CalisanNo == calisan);
            _context.Gorevler.Add(new Gorev { GorevAdi = gorevAdi, BaslangicTarihi = baslangic, BitisTarihi = bitis, AdamGunDegeri = adamgun, Durum = durum, ProjeNo = proje.ProjeNo,CalisanNo=calisan1.CalisanNo });
            _context.SaveChanges();
            _context.ProjeCalisanlar.Add(new ProjeCalisan { ProjeNo = proje.ProjeNo, CalisanNo = calisan1.CalisanNo });
            _context.SaveChanges();
            var gorevler = _context.Gorevler.Select(g => new { g.GorevNo, g.GorevAdi, g.BaslangicTarihi, g.BitisTarihi, g.AdamGunDegeri, g.Durum }).ToList();
            dataGridView4.DataSource = gorevler;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView4.CurrentRow.Cells[0].Value;

            var gorevler = _context.Gorevler.Find(id);

            if (radioButton1.Checked == true)
            {
                gorevler.Durum = "TAMAMLANACAK";
            }
            if (radioButton2.Checked == true)
            {
                gorevler.Durum = "DEVAM EDÝYOR";
            }
            if (radioButton3.Checked == true)
            {
                gorevler.Durum = "TAMAMLANDI";
            }

            _context.SaveChanges();

            var gorevler1 = _context.Gorevler.Select(g => new { g.GorevNo, g.GorevAdi, g.BaslangicTarihi, g.BitisTarihi, g.AdamGunDegeri, g.Durum }).ToList();
            dataGridView4.DataSource = gorevler1;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView4.CurrentRow.Cells[0].Value;
            Console.WriteLine(id);
            var gorevler = _context.Gorevler.Find(id);
            _context.Gorevler.Remove(gorevler);
            _context.SaveChanges();
            var gorevler1 = _context.Gorevler.Select(g => new { g.GorevNo, g.GorevAdi, g.BaslangicTarihi, g.BitisTarihi, g.AdamGunDegeri, g.Durum }).ToList();
            dataGridView2.DataSource = gorevler1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var calisanlar = _context.Calisanlar.Find(id);
            var proje = _context.Projeler.FirstOrDefault(p => p.ProjeAdi == textBox2.Text);
            var projeCalisan = _context.ProjeCalisanlar.Add(new ProjeCalisan { ProjeNo=proje.ProjeNo,CalisanNo=calisanlar.CalisanNo});
            _context.SaveChanges();
            var result = from p in _context.ProjeCalisanlar
                         join c in _context.Calisanlar
                         on p.CalisanNo equals c.CalisanNo
                         select new { c.CalisanNo, c.CalisanAdi, c.CalisanSoyadi, c.TamamlananGorevSayisi, c.GecikenGorevSayisi };

            dataGridView1.DataSource = result.ToList();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var calisanlar = _context.Calisanlar.Find(id);
            var result = from p in _context.ProjeCalisanlar
                         join c in _context.Gorevler
                         on p.CalisanNo equals c.CalisanNo where c.CalisanNo == calisanlar.CalisanNo
                         select new { p.ProjeNo,c.GorevNo };
            dataGridView1.DataSource = result.ToList();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
