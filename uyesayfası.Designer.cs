namespace kütüphane_otomasyonu
{
    partial class uyesayfası
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.dataGridView_uye = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_çıkış = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_uye)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(12, 26);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(79, 31);
            this.btn_ara.TabIndex = 0;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(231, 26);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(79, 31);
            this.btn_yenile.TabIndex = 0;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(110, 28);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(100, 26);
            this.txt_ara.TabIndex = 1;
            // 
            // dataGridView_uye
            // 
            this.dataGridView_uye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_uye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.isim,
            this.yazar,
            this.sayfa,
            this.tur});
            this.dataGridView_uye.Location = new System.Drawing.Point(12, 100);
            this.dataGridView_uye.Name = "dataGridView_uye";
            this.dataGridView_uye.RowHeadersWidth = 62;
            this.dataGridView_uye.RowTemplate.Height = 28;
            this.dataGridView_uye.Size = new System.Drawing.Size(746, 214);
            this.dataGridView_uye.TabIndex = 2;
            this.dataGridView_uye.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_uye_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "İD";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 80;
            // 
            // isim
            // 
            this.isim.HeaderText = "İSİM";
            this.isim.MinimumWidth = 8;
            this.isim.Name = "isim";
            this.isim.Width = 150;
            // 
            // yazar
            // 
            this.yazar.HeaderText = "YAZAR";
            this.yazar.MinimumWidth = 8;
            this.yazar.Name = "yazar";
            this.yazar.Width = 150;
            // 
            // sayfa
            // 
            this.sayfa.HeaderText = "SAYFA";
            this.sayfa.MinimumWidth = 8;
            this.sayfa.Name = "sayfa";
            this.sayfa.Width = 150;
            // 
            // tur
            // 
            this.tur.HeaderText = "TÜR";
            this.tur.MinimumWidth = 8;
            this.tur.Name = "tur";
            this.tur.Width = 150;
            // 
            // btn_çıkış
            // 
            this.btn_çıkış.Location = new System.Drawing.Point(12, 406);
            this.btn_çıkış.Name = "btn_çıkış";
            this.btn_çıkış.Size = new System.Drawing.Size(146, 47);
            this.btn_çıkış.TabIndex = 3;
            this.btn_çıkış.Text = "ÇIKIŞ";
            this.btn_çıkış.UseVisualStyleBackColor = true;
            this.btn_çıkış.Click += new System.EventHandler(this.btn_çıkış_Click);
            // 
            // uyesayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 684);
            this.Controls.Add(this.btn_çıkış);
            this.Controls.Add(this.dataGridView_uye);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_ara);
            this.Name = "uyesayfası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uyesayfası";
            this.Load += new System.EventHandler(this.uyesayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_uye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.DataGridView dataGridView_uye;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.Button btn_çıkış;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
    }
}