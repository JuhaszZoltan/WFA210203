
namespace WFA210203
{
    partial class FrmMain
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
            this.dgvTanuloAdatok = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUjTanulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.cbEvismetlo = new System.Windows.Forms.ComboBox();
            this.rtbMunkak = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEvfolyam = new System.Windows.Forms.TextBox();
            this.tbOsztaly = new System.Windows.Forms.TextBox();
            this.tbOsszOra = new System.Windows.Forms.TextBox();
            this.tbMegvan50 = new System.Windows.Forms.TextBox();
            this.btnModosit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanuloAdatok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTanuloAdatok
            // 
            this.dgvTanuloAdatok.AllowUserToAddRows = false;
            this.dgvTanuloAdatok.AllowUserToDeleteRows = false;
            this.dgvTanuloAdatok.AllowUserToResizeColumns = false;
            this.dgvTanuloAdatok.AllowUserToResizeRows = false;
            this.dgvTanuloAdatok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTanuloAdatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTanuloAdatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTanuloAdatok.Location = new System.Drawing.Point(12, 109);
            this.dgvTanuloAdatok.Name = "dgvTanuloAdatok";
            this.dgvTanuloAdatok.RowHeadersVisible = false;
            this.dgvTanuloAdatok.RowHeadersWidth = 51;
            this.dgvTanuloAdatok.RowTemplate.Height = 29;
            this.dgvTanuloAdatok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTanuloAdatok.Size = new System.Drawing.Size(978, 240);
            this.dgvTanuloAdatok.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Név";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Évfolyam";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Osztály";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Évismtlő?";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // btnUjTanulo
            // 
            this.btnUjTanulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUjTanulo.Location = new System.Drawing.Point(496, 28);
            this.btnUjTanulo.Name = "btnUjTanulo";
            this.btnUjTanulo.Size = new System.Drawing.Size(494, 52);
            this.btnUjTanulo.TabIndex = 1;
            this.btnUjTanulo.Text = "Új tanuló adatainak felvitele";
            this.btnUjTanulo.UseVisualStyleBackColor = true;
            this.btnUjTanulo.Click += new System.EventHandler(this.btnUjTanulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Közösségi szolgálat";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(191, 434);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(239, 27);
            this.tbNev.TabIndex = 3;
            // 
            // cbEvismetlo
            // 
            this.cbEvismetlo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvismetlo.FormattingEnabled = true;
            this.cbEvismetlo.Items.AddRange(new object[] {
            "Nem",
            "Igen"});
            this.cbEvismetlo.Location = new System.Drawing.Point(234, 533);
            this.cbEvismetlo.Name = "cbEvismetlo";
            this.cbEvismetlo.Size = new System.Drawing.Size(124, 28);
            this.cbEvismetlo.TabIndex = 4;
            // 
            // rtbMunkak
            // 
            this.rtbMunkak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbMunkak.Location = new System.Drawing.Point(496, 416);
            this.rtbMunkak.Name = "rtbMunkak";
            this.rtbMunkak.Size = new System.Drawing.Size(464, 136);
            this.rtbMunkak.TabIndex = 5;
            this.rtbMunkak.Text = "Szervezetek, ahol teljesített (név, óra):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kiválasztott gyerek adatainak módosítaása:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(487, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(503, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kiválasztott tanuló közösségi szolgálati adatai:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(49, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Évfolyam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(49, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Osztály:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(49, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Évismétlő:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(487, 565);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Teljesített órák összesen:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(487, 609);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Megvan az 50?";
            // 
            // tbEvfolyam
            // 
            this.tbEvfolyam.Location = new System.Drawing.Point(191, 467);
            this.tbEvfolyam.Name = "tbEvfolyam";
            this.tbEvfolyam.Size = new System.Drawing.Size(239, 27);
            this.tbEvfolyam.TabIndex = 3;
            // 
            // tbOsztaly
            // 
            this.tbOsztaly.Location = new System.Drawing.Point(191, 500);
            this.tbOsztaly.Name = "tbOsztaly";
            this.tbOsztaly.Size = new System.Drawing.Size(239, 27);
            this.tbOsztaly.TabIndex = 3;
            // 
            // tbOsszOra
            // 
            this.tbOsszOra.Location = new System.Drawing.Point(785, 566);
            this.tbOsszOra.Name = "tbOsszOra";
            this.tbOsszOra.Size = new System.Drawing.Size(170, 27);
            this.tbOsszOra.TabIndex = 3;
            // 
            // tbMegvan50
            // 
            this.tbMegvan50.Location = new System.Drawing.Point(785, 605);
            this.tbMegvan50.Name = "tbMegvan50";
            this.tbMegvan50.Size = new System.Drawing.Size(170, 27);
            this.tbMegvan50.TabIndex = 3;
            // 
            // btnModosit
            // 
            this.btnModosit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModosit.Location = new System.Drawing.Point(34, 586);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(413, 46);
            this.btnModosit.TabIndex = 6;
            this.btnModosit.Text = "adatok módosítása";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.BtnModosit);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 655);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.rtbMunkak);
            this.Controls.Add(this.cbEvismetlo);
            this.Controls.Add(this.tbOsztaly);
            this.Controls.Add(this.tbEvfolyam);
            this.Controls.Add(this.tbMegvan50);
            this.Controls.Add(this.tbOsszOra);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUjTanulo);
            this.Controls.Add(this.dgvTanuloAdatok);
            this.Name = "FrmMain";
            this.Text = "Közösségi Szolgálat";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanuloAdatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTanuloAdatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnUjTanulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.ComboBox cbEvismetlo;
        private System.Windows.Forms.RichTextBox rtbMunkak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEvfolyam;
        private System.Windows.Forms.TextBox tbOsztaly;
        private System.Windows.Forms.TextBox tbOsszOra;
        private System.Windows.Forms.TextBox tbMegvan50;
        private System.Windows.Forms.Button btnModosit;
    }
}

