namespace Pizza_Sipariş_Ekranı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnkapat = new System.Windows.Forms.Button();
            this.btnsiparişver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxpeynir = new System.Windows.Forms.CheckBox();
            this.checkBoxbalık = new System.Windows.Forms.CheckBox();
            this.checkBoxmantar = new System.Windows.Forms.CheckBox();
            this.checkBoxsucuk = new System.Windows.Forms.CheckBox();
            this.checkBoxsalam = new System.Windows.Forms.CheckBox();
            this.checkBoxzeytin = new System.Windows.Forms.CheckBox();
            this.checkBoxançuez = new System.Windows.Forms.CheckBox();
            this.checkBoxmısır = new System.Windows.Forms.CheckBox();
            this.checkBoxsosis = new System.Windows.Forms.CheckBox();
            this.checkBoxdana = new System.Windows.Forms.CheckBox();
            this.lblebat = new System.Windows.Forms.Label();
            this.lbladet = new System.Windows.Forms.Label();
            this.lblsiparişekranı = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbltoplam = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnkapat
            // 
            this.btnkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapat.Location = new System.Drawing.Point(225, 668);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(100, 34);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = true;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnsiparişver
            // 
            this.btnsiparişver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsiparişver.Location = new System.Drawing.Point(331, 668);
            this.btnsiparişver.Name = "btnsiparişver";
            this.btnsiparişver.Size = new System.Drawing.Size(109, 34);
            this.btnsiparişver.TabIndex = 1;
            this.btnsiparişver.Text = "Sipariş Ver";
            this.btnsiparişver.UseVisualStyleBackColor = true;
            this.btnsiparişver.Click += new System.EventHandler(this.btnsiparişver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxpeynir);
            this.groupBox1.Controls.Add(this.checkBoxbalık);
            this.groupBox1.Controls.Add(this.checkBoxmantar);
            this.groupBox1.Controls.Add(this.checkBoxsucuk);
            this.groupBox1.Controls.Add(this.checkBoxsalam);
            this.groupBox1.Controls.Add(this.checkBoxzeytin);
            this.groupBox1.Controls.Add(this.checkBoxançuez);
            this.groupBox1.Controls.Add(this.checkBoxmısır);
            this.groupBox1.Controls.Add(this.checkBoxsosis);
            this.groupBox1.Controls.Add(this.checkBoxdana);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(91, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 309);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzemeler";
            // 
            // checkBoxpeynir
            // 
            this.checkBoxpeynir.AutoSize = true;
            this.checkBoxpeynir.Location = new System.Drawing.Point(168, 251);
            this.checkBoxpeynir.Name = "checkBoxpeynir";
            this.checkBoxpeynir.Size = new System.Drawing.Size(64, 20);
            this.checkBoxpeynir.TabIndex = 9;
            this.checkBoxpeynir.Text = "Peynir";
            this.checkBoxpeynir.UseVisualStyleBackColor = true;
            // 
            // checkBoxbalık
            // 
            this.checkBoxbalık.AutoSize = true;
            this.checkBoxbalık.Location = new System.Drawing.Point(170, 191);
            this.checkBoxbalık.Name = "checkBoxbalık";
            this.checkBoxbalık.Size = new System.Drawing.Size(87, 20);
            this.checkBoxbalık.TabIndex = 8;
            this.checkBoxbalık.Text = "Ton Balığı";
            this.checkBoxbalık.UseVisualStyleBackColor = true;
            // 
            // checkBoxmantar
            // 
            this.checkBoxmantar.AutoSize = true;
            this.checkBoxmantar.Location = new System.Drawing.Point(170, 140);
            this.checkBoxmantar.Name = "checkBoxmantar";
            this.checkBoxmantar.Size = new System.Drawing.Size(67, 20);
            this.checkBoxmantar.TabIndex = 7;
            this.checkBoxmantar.Text = "Mantar";
            this.checkBoxmantar.UseVisualStyleBackColor = true;
            // 
            // checkBoxsucuk
            // 
            this.checkBoxsucuk.AutoSize = true;
            this.checkBoxsucuk.Location = new System.Drawing.Point(170, 94);
            this.checkBoxsucuk.Name = "checkBoxsucuk";
            this.checkBoxsucuk.Size = new System.Drawing.Size(63, 20);
            this.checkBoxsucuk.TabIndex = 6;
            this.checkBoxsucuk.Text = "Sucuk";
            this.checkBoxsucuk.UseVisualStyleBackColor = true;
            this.checkBoxsucuk.CheckedChanged += new System.EventHandler(this.checkBoxsucuk_CheckedChanged);
            // 
            // checkBoxsalam
            // 
            this.checkBoxsalam.AutoSize = true;
            this.checkBoxsalam.Location = new System.Drawing.Point(170, 45);
            this.checkBoxsalam.Name = "checkBoxsalam";
            this.checkBoxsalam.Size = new System.Drawing.Size(65, 20);
            this.checkBoxsalam.TabIndex = 5;
            this.checkBoxsalam.Text = "Salam";
            this.checkBoxsalam.UseVisualStyleBackColor = true;
            // 
            // checkBoxzeytin
            // 
            this.checkBoxzeytin.AutoSize = true;
            this.checkBoxzeytin.Location = new System.Drawing.Point(17, 251);
            this.checkBoxzeytin.Name = "checkBoxzeytin";
            this.checkBoxzeytin.Size = new System.Drawing.Size(62, 20);
            this.checkBoxzeytin.TabIndex = 4;
            this.checkBoxzeytin.Text = "Zeytin";
            this.checkBoxzeytin.UseVisualStyleBackColor = true;
            // 
            // checkBoxançuez
            // 
            this.checkBoxançuez.AutoSize = true;
            this.checkBoxançuez.Location = new System.Drawing.Point(17, 191);
            this.checkBoxançuez.Name = "checkBoxançuez";
            this.checkBoxançuez.Size = new System.Drawing.Size(70, 20);
            this.checkBoxançuez.TabIndex = 3;
            this.checkBoxançuez.Text = "Ançuez";
            this.checkBoxançuez.UseVisualStyleBackColor = true;
            // 
            // checkBoxmısır
            // 
            this.checkBoxmısır.AutoSize = true;
            this.checkBoxmısır.Location = new System.Drawing.Point(17, 140);
            this.checkBoxmısır.Name = "checkBoxmısır";
            this.checkBoxmısır.Size = new System.Drawing.Size(54, 20);
            this.checkBoxmısır.TabIndex = 2;
            this.checkBoxmısır.Text = "Mısır";
            this.checkBoxmısır.UseVisualStyleBackColor = true;
            // 
            // checkBoxsosis
            // 
            this.checkBoxsosis.AutoSize = true;
            this.checkBoxsosis.Location = new System.Drawing.Point(17, 94);
            this.checkBoxsosis.Name = "checkBoxsosis";
            this.checkBoxsosis.Size = new System.Drawing.Size(60, 20);
            this.checkBoxsosis.TabIndex = 1;
            this.checkBoxsosis.Text = "Sosis";
            this.checkBoxsosis.UseVisualStyleBackColor = true;
            // 
            // checkBoxdana
            // 
            this.checkBoxdana.AutoSize = true;
            this.checkBoxdana.Location = new System.Drawing.Point(17, 43);
            this.checkBoxdana.Name = "checkBoxdana";
            this.checkBoxdana.Size = new System.Drawing.Size(111, 20);
            this.checkBoxdana.TabIndex = 0;
            this.checkBoxdana.Text = "Dana Jambon";
            this.checkBoxdana.UseVisualStyleBackColor = true;
            // 
            // lblebat
            // 
            this.lblebat.AutoSize = true;
            this.lblebat.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblebat.Location = new System.Drawing.Point(40, 89);
            this.lblebat.Name = "lblebat";
            this.lblebat.Size = new System.Drawing.Size(56, 23);
            this.lblebat.TabIndex = 3;
            this.lblebat.Text = "Ebat :";
            // 
            // lbladet
            // 
            this.lbladet.AutoSize = true;
            this.lbladet.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladet.Location = new System.Drawing.Point(70, 616);
            this.lbladet.Name = "lbladet";
            this.lbladet.Size = new System.Drawing.Size(55, 21);
            this.lbladet.TabIndex = 4;
            this.lbladet.Text = "Adet :";
            this.lbladet.Click += new System.EventHandler(this.lbladet_Click);
            // 
            // lblsiparişekranı
            // 
            this.lblsiparişekranı.BackColor = System.Drawing.Color.Red;
            this.lblsiparişekranı.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsiparişekranı.Location = new System.Drawing.Point(-5, -2);
            this.lblsiparişekranı.Name = "lblsiparişekranı";
            this.lblsiparişekranı.Size = new System.Drawing.Size(661, 66);
            this.lblsiparişekranı.TabIndex = 5;
            this.lblsiparişekranı.Text = "PİZZA SİPARİŞ EKRANI";
            this.lblsiparişekranı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "American Hot",
            "Callypso",
            "Turkish",
            "Pizza Italiano",
            "Etravaganzza"});
            this.listBox1.Location = new System.Drawing.Point(91, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 82);
            this.listBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 619);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(320, 622);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 8;
            // 
            // lbltoplam
            // 
            this.lbltoplam.AutoSize = true;
            this.lbltoplam.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplam.Location = new System.Drawing.Point(238, 619);
            this.lbltoplam.Name = "lbltoplam";
            this.lbltoplam.Size = new System.Drawing.Size(76, 21);
            this.lbltoplam.TabIndex = 9;
            this.lbltoplam.Text = "Toplam :";
            this.lbltoplam.Click += new System.EventHandler(this.lbltoplam_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(91, 232);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 19);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İnce Kenar";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(320, 232);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 19);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kalın Kenar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Küçük Boy",
            "Orta Boy",
            "Büyük Boy"});
            this.comboBox1.Location = new System.Drawing.Point(91, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 736);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lbltoplam);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblsiparişekranı);
            this.Controls.Add(this.lbladet);
            this.Controls.Add(this.lblebat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsiparişver);
            this.Controls.Add(this.btnkapat);
            this.Name = "Form1";
            this.Text = "PİZZA SİPRAİŞ EKRANI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Button btnsiparişver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblebat;
        private System.Windows.Forms.Label lbladet;
        private System.Windows.Forms.Label lblsiparişekranı;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbltoplam;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBoxpeynir;
        private System.Windows.Forms.CheckBox checkBoxbalık;
        private System.Windows.Forms.CheckBox checkBoxmantar;
        private System.Windows.Forms.CheckBox checkBoxsucuk;
        private System.Windows.Forms.CheckBox checkBoxsalam;
        private System.Windows.Forms.CheckBox checkBoxzeytin;
        private System.Windows.Forms.CheckBox checkBoxançuez;
        private System.Windows.Forms.CheckBox checkBoxmısır;
        private System.Windows.Forms.CheckBox checkBoxsosis;
        private System.Windows.Forms.CheckBox checkBoxdana;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

