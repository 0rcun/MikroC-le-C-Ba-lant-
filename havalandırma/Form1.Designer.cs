namespace havalandırma
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_hava = new System.Windows.Forms.TextBox();
            this.txt_nem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sıcaklık = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_h_kapat = new System.Windows.Forms.Button();
            this.btn_h_ac = new System.Windows.Forms.Button();
            this.btn_baglan = new System.Windows.Forms.Button();
            this.btn_baglan_kes = new System.Windows.Forms.Button();
            this.cbx_port = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERİPORT:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_hava);
            this.groupBox1.Controls.Add(this.txt_nem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_sıcaklık);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(276, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEĞERLER";
            // 
            // txt_hava
            // 
            this.txt_hava.Location = new System.Drawing.Point(87, 83);
            this.txt_hava.Name = "txt_hava";
            this.txt_hava.Size = new System.Drawing.Size(100, 22);
            this.txt_hava.TabIndex = 2;
            this.txt_hava.TextChanged += new System.EventHandler(this.txt_hava_TextChanged);
            // 
            // txt_nem
            // 
            this.txt_nem.Location = new System.Drawing.Point(87, 55);
            this.txt_nem.Name = "txt_nem";
            this.txt_nem.Size = new System.Drawing.Size(100, 22);
            this.txt_nem.TabIndex = 1;
            this.txt_nem.TextChanged += new System.EventHandler(this.txt_nem_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "HAVA:";
            // 
            // txt_sıcaklık
            // 
            this.txt_sıcaklık.Location = new System.Drawing.Point(87, 23);
            this.txt_sıcaklık.Name = "txt_sıcaklık";
            this.txt_sıcaklık.Size = new System.Drawing.Size(100, 22);
            this.txt_sıcaklık.TabIndex = 0;
            this.txt_sıcaklık.TextChanged += new System.EventHandler(this.txt_sıcaklık_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "NEM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "SICAKLIK:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_h_kapat);
            this.groupBox2.Controls.Add(this.btn_h_ac);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(276, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HAVALANDIRMA";
            // 
            // btn_h_kapat
            // 
            this.btn_h_kapat.Location = new System.Drawing.Point(125, 39);
            this.btn_h_kapat.Name = "btn_h_kapat";
            this.btn_h_kapat.Size = new System.Drawing.Size(80, 35);
            this.btn_h_kapat.TabIndex = 0;
            this.btn_h_kapat.Text = "KAPAT";
            this.btn_h_kapat.UseVisualStyleBackColor = true;
            this.btn_h_kapat.Click += new System.EventHandler(this.btn_h_kapat_Click);
            // 
            // btn_h_ac
            // 
            this.btn_h_ac.Location = new System.Drawing.Point(29, 39);
            this.btn_h_ac.Name = "btn_h_ac";
            this.btn_h_ac.Size = new System.Drawing.Size(80, 35);
            this.btn_h_ac.TabIndex = 0;
            this.btn_h_ac.Text = "AÇ";
            this.btn_h_ac.UseVisualStyleBackColor = true;
            this.btn_h_ac.Click += new System.EventHandler(this.btn_h_ac_Click);
            // 
            // btn_baglan
            // 
            this.btn_baglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_baglan.Location = new System.Drawing.Point(26, 171);
            this.btn_baglan.Name = "btn_baglan";
            this.btn_baglan.Size = new System.Drawing.Size(139, 35);
            this.btn_baglan.TabIndex = 0;
            this.btn_baglan.Text = "BAĞLAN";
            this.btn_baglan.UseVisualStyleBackColor = true;
            this.btn_baglan.Click += new System.EventHandler(this.btn_baglan_Click);
            // 
            // btn_baglan_kes
            // 
            this.btn_baglan_kes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_baglan_kes.Location = new System.Drawing.Point(26, 230);
            this.btn_baglan_kes.Name = "btn_baglan_kes";
            this.btn_baglan_kes.Size = new System.Drawing.Size(139, 35);
            this.btn_baglan_kes.TabIndex = 0;
            this.btn_baglan_kes.Text = "BAĞLANTI KES";
            this.btn_baglan_kes.UseVisualStyleBackColor = true;
            this.btn_baglan_kes.Click += new System.EventHandler(this.btn_baglan_kes_Click);
            // 
            // cbx_port
            // 
            this.cbx_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_port.FormattingEnabled = true;
            this.cbx_port.Location = new System.Drawing.Point(156, 106);
            this.cbx_port.Name = "cbx_port";
            this.cbx_port.Size = new System.Drawing.Size(101, 24);
            this.cbx_port.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(140, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(548, 332);
            this.Controls.Add(this.cbx_port);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_baglan_kes);
            this.Controls.Add(this.btn_baglan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HAVALANDIRMA SİSTEMİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_hava;
        private System.Windows.Forms.TextBox txt_nem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sıcaklık;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_h_kapat;
        private System.Windows.Forms.Button btn_h_ac;
        private System.Windows.Forms.Button btn_baglan;
        private System.Windows.Forms.Button btn_baglan_kes;
        private System.Windows.Forms.ComboBox cbx_port;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

