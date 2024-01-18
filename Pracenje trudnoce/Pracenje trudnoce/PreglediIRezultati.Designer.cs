
namespace Pracenje_trudnoce
{
    partial class PreglediIRezultati
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
            this.dgvPregledi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRezultatiPregleda = new System.Windows.Forms.DataGridView();
            this.buttonDodajPregled = new System.Windows.Forms.Button();
            this.buttonAzuriraj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultatiPregleda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregledi
            // 
            this.dgvPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledi.Location = new System.Drawing.Point(170, 66);
            this.dgvPregledi.Name = "dgvPregledi";
            this.dgvPregledi.RowHeadersWidth = 51;
            this.dgvPregledi.RowTemplate.Height = 24;
            this.dgvPregledi.Size = new System.Drawing.Size(669, 174);
            this.dgvPregledi.TabIndex = 0;
            this.dgvPregledi.SelectionChanged += new System.EventHandler(this.dgvPregledi_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregledi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rezultati pregleda";
            // 
            // dgvRezultatiPregleda
            // 
            this.dgvRezultatiPregleda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezultatiPregleda.Location = new System.Drawing.Point(170, 384);
            this.dgvRezultatiPregleda.Name = "dgvRezultatiPregleda";
            this.dgvRezultatiPregleda.RowHeadersWidth = 51;
            this.dgvRezultatiPregleda.RowTemplate.Height = 24;
            this.dgvRezultatiPregleda.Size = new System.Drawing.Size(669, 174);
            this.dgvRezultatiPregleda.TabIndex = 3;
            // 
            // buttonDodajPregled
            // 
            this.buttonDodajPregled.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajPregled.Location = new System.Drawing.Point(398, 258);
            this.buttonDodajPregled.Name = "buttonDodajPregled";
            this.buttonDodajPregled.Size = new System.Drawing.Size(139, 48);
            this.buttonDodajPregled.TabIndex = 4;
            this.buttonDodajPregled.Text = "Dodaj pregled";
            this.buttonDodajPregled.UseVisualStyleBackColor = true;
            this.buttonDodajPregled.Click += new System.EventHandler(this.buttonDodajPregled_Click);
            // 
            // buttonAzuriraj
            // 
            this.buttonAzuriraj.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAzuriraj.Location = new System.Drawing.Point(543, 258);
            this.buttonAzuriraj.Name = "buttonAzuriraj";
            this.buttonAzuriraj.Size = new System.Drawing.Size(139, 48);
            this.buttonAzuriraj.TabIndex = 5;
            this.buttonAzuriraj.Text = "Ažuriraj";
            this.buttonAzuriraj.UseVisualStyleBackColor = true;
            this.buttonAzuriraj.Click += new System.EventHandler(this.buttonAzuriraj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.Location = new System.Drawing.Point(700, 258);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(139, 48);
            this.buttonObrisi.TabIndex = 6;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(700, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Obriši";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(543, 577);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ažuriraj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(388, 577);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 53);
            this.button3.TabIndex = 7;
            this.button3.Text = "Dodaj rezultate pregleda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNatrag.Location = new System.Drawing.Point(12, 26);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(94, 46);
            this.buttonNatrag.TabIndex = 11;
            this.buttonNatrag.Text = "Natrag";
            this.buttonNatrag.UseVisualStyleBackColor = true;
            this.buttonNatrag.Click += new System.EventHandler(this.buttonNatrag_Click);
            // 
            // PreglediIRezultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(937, 672);
            this.Controls.Add(this.buttonNatrag);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonAzuriraj);
            this.Controls.Add(this.buttonDodajPregled);
            this.Controls.Add(this.dgvRezultatiPregleda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPregledi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PreglediIRezultati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregledi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultatiPregleda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRezultatiPregleda;
        private System.Windows.Forms.Button buttonDodajPregled;
        private System.Windows.Forms.Button buttonAzuriraj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonNatrag;
    }
}