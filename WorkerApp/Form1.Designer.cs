
namespace WorkerApp
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            panelMenu = new Panel();
            btnTask = new Button();
            btnProject = new Button();
            btnWorker = new Button();
            panelLogo = new Panel();
            label2 = new Label();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            label1 = new Label();
            panelWorker = new Panel();
            button9 = new Button();
            button8 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            txtWorkerSurname = new TextBox();
            lblWorkerSurname = new Label();
            txtWorkerName = new TextBox();
            lblWorkerName = new Label();
            dataGridView1 = new DataGridView();
            panel_Tasks = new Panel();
            label14 = new Label();
            txtcalianId = new TextBox();
            dataGridView4 = new DataGridView();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            txt_gorev_adi = new TextBox();
            textBox1 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            calisanBindingSource = new BindingSource(components);
            panel_Project = new Panel();
            text2_Box1 = new TextBox();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_Tasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calisanBindingSource).BeginInit();
            panel_Project.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnTask);
            panelMenu.Controls.Add(btnProject);
            panelMenu.Controls.Add(btnWorker);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 646);
            panelMenu.TabIndex = 2;
            // 
            // btnTask
            // 
            btnTask.Dock = DockStyle.Top;
            btnTask.FlatAppearance.BorderSize = 0;
            btnTask.FlatStyle = FlatStyle.Flat;
            btnTask.ForeColor = SystemColors.ControlLightLight;
            btnTask.Image = (Image)resources.GetObject("btnTask.Image");
            btnTask.ImageAlign = ContentAlignment.MiddleLeft;
            btnTask.Location = new Point(0, 200);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(220, 60);
            btnTask.TabIndex = 2;
            btnTask.Text = "   Görev";
            btnTask.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += btnTask_Click;
            // 
            // btnProject
            // 
            btnProject.Dock = DockStyle.Top;
            btnProject.FlatAppearance.BorderSize = 0;
            btnProject.FlatStyle = FlatStyle.Flat;
            btnProject.ForeColor = SystemColors.ControlLightLight;
            btnProject.Image = (Image)resources.GetObject("btnProject.Image");
            btnProject.ImageAlign = ContentAlignment.MiddleLeft;
            btnProject.Location = new Point(0, 140);
            btnProject.Name = "btnProject";
            btnProject.Size = new Size(220, 60);
            btnProject.TabIndex = 1;
            btnProject.Text = "   Proje";
            btnProject.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProject.UseVisualStyleBackColor = true;
            btnProject.Click += btnProject_Click;
            // 
            // btnWorker
            // 
            btnWorker.Dock = DockStyle.Top;
            btnWorker.FlatAppearance.BorderSize = 0;
            btnWorker.FlatStyle = FlatStyle.Flat;
            btnWorker.ForeColor = SystemColors.ControlLightLight;
            btnWorker.Image = (Image)resources.GetObject("btnWorker.Image");
            btnWorker.ImageAlign = ContentAlignment.MiddleLeft;
            btnWorker.Location = new Point(0, 80);
            btnWorker.Name = "btnWorker";
            btnWorker.Size = new Size(220, 60);
            btnWorker.TabIndex = 0;
            btnWorker.Text = "   Çalışan";
            btnWorker.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWorker.UseVisualStyleBackColor = true;
            btnWorker.Click += btnWorker_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(57, 33);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 0;
            label2.Text = "Çalışan Bilgisi";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(panelDesktopPane);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.ForeColor = SystemColors.ControlText;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1064, 80);
            panelTitleBar.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(507, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(55, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Giriş";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label1_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Location = new Point(0, 80);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1064, 566);
            panelDesktopPane.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(696, 298);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 5;
            label1.Text = "Hoş Geldiniz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelWorker
            // 
            panelWorker.Controls.Add(button9);
            panelWorker.Controls.Add(button8);
            panelWorker.Controls.Add(textBox2);
            panelWorker.Controls.Add(label3);
            panelWorker.Controls.Add(button2);
            panelWorker.Controls.Add(button1);
            panelWorker.Controls.Add(txtWorkerSurname);
            panelWorker.Controls.Add(lblWorkerSurname);
            panelWorker.Controls.Add(txtWorkerName);
            panelWorker.Controls.Add(lblWorkerName);
            panelWorker.Controls.Add(dataGridView1);
            panelWorker.Location = new Point(220, 80);
            panelWorker.Name = "panelWorker";
            panelWorker.Size = new Size(1064, 566);
            panelWorker.TabIndex = 6;
            // 
            // button9
            // 
            button9.Location = new Point(98, 402);
            button9.Name = "button9";
            button9.Size = new Size(100, 23);
            button9.TabIndex = 12;
            button9.Text = "Detay";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(98, 373);
            button8.Name = "button8";
            button8.Size = new Size(100, 23);
            button8.TabIndex = 11;
            button8.Text = "Güncelle";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 334);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 337);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 9;
            label3.Text = "Proje Adı:";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(98, 269);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 8;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(98, 240);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 7;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtWorkerSurname
            // 
            txtWorkerSurname.Location = new Point(98, 202);
            txtWorkerSurname.Name = "txtWorkerSurname";
            txtWorkerSurname.Size = new Size(100, 23);
            txtWorkerSurname.TabIndex = 5;
            // 
            // lblWorkerSurname
            // 
            lblWorkerSurname.AutoSize = true;
            lblWorkerSurname.Location = new Point(6, 205);
            lblWorkerSurname.Name = "lblWorkerSurname";
            lblWorkerSurname.Size = new Size(86, 15);
            lblWorkerSurname.TabIndex = 4;
            lblWorkerSurname.Text = "Çalışan Soyadı:";
            // 
            // txtWorkerName
            // 
            txtWorkerName.Location = new Point(98, 161);
            txtWorkerName.Name = "txtWorkerName";
            txtWorkerName.Size = new Size(100, 23);
            txtWorkerName.TabIndex = 3;
            // 
            // lblWorkerName
            // 
            lblWorkerName.AutoSize = true;
            lblWorkerName.Location = new Point(6, 164);
            lblWorkerName.Name = "lblWorkerName";
            lblWorkerName.Size = new Size(69, 15);
            lblWorkerName.TabIndex = 2;
            lblWorkerName.Text = "Çalışan Adı:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(385, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(552, 206);
            dataGridView1.TabIndex = 0;
            // 
            // panel_Tasks
            // 
            panel_Tasks.Controls.Add(label14);
            panel_Tasks.Controls.Add(txtcalianId);
            panel_Tasks.Controls.Add(dataGridView4);
            panel_Tasks.Controls.Add(radioButton3);
            panel_Tasks.Controls.Add(radioButton2);
            panel_Tasks.Controls.Add(radioButton1);
            panel_Tasks.Controls.Add(button7);
            panel_Tasks.Controls.Add(button6);
            panel_Tasks.Controls.Add(button5);
            panel_Tasks.Controls.Add(checkBox4);
            panel_Tasks.Controls.Add(checkBox3);
            panel_Tasks.Controls.Add(checkBox2);
            panel_Tasks.Controls.Add(checkBox1);
            panel_Tasks.Controls.Add(dateTimePicker4);
            panel_Tasks.Controls.Add(dateTimePicker3);
            panel_Tasks.Controls.Add(txt_gorev_adi);
            panel_Tasks.Controls.Add(textBox1);
            panel_Tasks.Controls.Add(label13);
            panel_Tasks.Controls.Add(label12);
            panel_Tasks.Controls.Add(label11);
            panel_Tasks.Controls.Add(label10);
            panel_Tasks.Controls.Add(label9);
            panel_Tasks.Controls.Add(label8);
            panel_Tasks.Controls.Add(label7);
            panel_Tasks.Location = new Point(220, 80);
            panel_Tasks.Name = "panel_Tasks";
            panel_Tasks.Size = new Size(1064, 524);
            panel_Tasks.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 149);
            label14.Name = "label14";
            label14.Size = new Size(61, 15);
            label14.TabIndex = 9;
            label14.Text = "Çalışan id:";
            // 
            // txtcalianId
            // 
            txtcalianId.Location = new Point(103, 146);
            txtcalianId.Name = "txtcalianId";
            txtcalianId.Size = new Size(100, 23);
            txtcalianId.TabIndex = 10;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(309, 173);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(646, 161);
            dataGridView4.TabIndex = 21;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(544, 430);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(90, 19);
            radioButton3.TabIndex = 20;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tamamlandı";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(544, 398);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(98, 19);
            radioButton2.TabIndex = 19;
            radioButton2.TabStop = true;
            radioButton2.Text = "Devam Ediyor";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(544, 369);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 19);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tamamlanacak";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(544, 455);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 17;
            button7.Text = "Güncelle";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(103, 394);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 16;
            button6.Text = "Sil";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(103, 365);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 15;
            button5.Text = "Ekle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(103, 322);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(32, 19);
            checkBox4.TabIndex = 14;
            checkBox4.Text = "3";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(153, 321);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(38, 19);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "30";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(153, 296);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(38, 19);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "15";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(103, 295);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(32, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "7";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(103, 266);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(200, 23);
            dateTimePicker4.TabIndex = 10;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(103, 240);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 9;
            // 
            // txt_gorev_adi
            // 
            txt_gorev_adi.Location = new Point(103, 211);
            txt_gorev_adi.Name = "txt_gorev_adi";
            txt_gorev_adi.Size = new Size(100, 23);
            txt_gorev_adi.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(431, 373);
            label13.Name = "label13";
            label13.Size = new Size(47, 15);
            label13.TabIndex = 6;
            label13.Text = "Durum:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 322);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 5;
            label12.Text = "Gün Değeri:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 296);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 4;
            label11.Text = "Adam Değeri:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 271);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 3;
            label10.Text = "Bitiş Tarihi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 243);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 2;
            label9.Text = "Başlangıç Tarihi:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 210);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 1;
            label8.Text = "Görev Adı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 179);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 0;
            label7.Text = "Proje:";
            // 
            // calisanBindingSource
            // 
            calisanBindingSource.DataSource = typeof(Model.Calisan);
            // 
            // panel_Project
            // 
            panel_Project.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel_Project.Controls.Add(text2_Box1);
            panel_Project.Controls.Add(dataGridView2);
            panel_Project.Controls.Add(button4);
            panel_Project.Controls.Add(button3);
            panel_Project.Controls.Add(dateTimePicker2);
            panel_Project.Controls.Add(dateTimePicker1);
            panel_Project.Controls.Add(label6);
            panel_Project.Controls.Add(label5);
            panel_Project.Controls.Add(label4);
            panel_Project.Location = new Point(220, 80);
            panel_Project.Name = "panel_Project";
            panel_Project.Size = new Size(1064, 558);
            panel_Project.TabIndex = 9;
            // 
            // text2_Box1
            // 
            text2_Box1.Location = new Point(109, 160);
            text2_Box1.Name = "text2_Box1";
            text2_Box1.Size = new Size(100, 23);
            text2_Box1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(315, 157);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(551, 292);
            dataGridView2.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(109, 305);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Sil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(109, 266);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(109, 224);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(109, 195);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 230);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 2;
            label6.Text = "Bitiş Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 196);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 1;
            label5.Text = "Başlangıç Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 163);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 0;
            label4.Text = "Proje Adı:";
            label4.Click += label4_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 646);
            Controls.Add(panel_Tasks);
            Controls.Add(panelWorker);
            Controls.Add(panel_Project);
            Controls.Add(label1);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Form";
            Text = "Form1";
            Load += Form_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelWorker.ResumeLayout(false);
            panelWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_Tasks.ResumeLayout(false);
            panel_Tasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)calisanBindingSource).EndInit();
            panel_Project.ResumeLayout(false);
            panel_Project.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelMenu;
        private Button btnTask;
        private Button btnProject;
        private Button btnWorker;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label2;
        private Panel panelDesktopPane;
        private Label label1;
        private Panel panelWorker;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txtWorkerSurname;
        private Label lblWorkerSurname;
        private TextBox txtWorkerName;
        private Label lblWorkerName;
        private DataGridViewTextBoxColumn projelerDataGridViewTextBoxColumn;
        private BindingSource calisanBindingSource;
        private Button button2;
        private Panel panel_Project;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button4;
        private Button button3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox text2_Box1;
        private DataGridView dataGridView2;
        private Panel panel_Tasks;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private TextBox txt_gorev_adi;
        private TextBox textBox1;
        private DataGridView dataGridView4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button7;
        private Button button6;
        private Button button5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button8;
        private Button button9;
        private Label label14;
        private TextBox txtcalianId;
    }
}
