
namespace Pracenje_trudnoce
{
    partial class Simptomi
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
            this.dgvSimptomi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumPocetkaSimptoma = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSimptomi = new System.Windows.Forms.ComboBox();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.buttonNatrag = new System.Windows.Forms.Button();
            this.dbTrudnoce = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimptomi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSimptomi
            // 
            this.dgvSimptomi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimptomi.Location = new System.Drawing.Point(124, 576);
            this.dgvSimptomi.Name = "dgvSimptomi";
            this.dgvSimptomi.RowHeadersWidth = 51;
            this.dgvSimptomi.RowTemplate.Height = 24;
            this.dgvSimptomi.Size = new System.Drawing.Size(669, 214);
            this.dgvSimptomi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(372, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simptomi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(197, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum početka simptoma:";
            // 
            // dtpDatumPocetkaSimptoma
            // 
            this.dtpDatumPocetkaSimptoma.Location = new System.Drawing.Point(457, 236);
            this.dtpDatumPocetkaSimptoma.Name = "dtpDatumPocetkaSimptoma";
            this.dtpDatumPocetkaSimptoma.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumPocetkaSimptoma.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(197, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opis simptoma:";
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(354, 311);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(303, 96);
            this.rtbOpis.TabIndex = 5;
            this.rtbOpis.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(197, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Naziv simptoma:";
            // 
            // cbSimptomi
            // 
            this.cbSimptomi.FormattingEnabled = true;
            this.cbSimptomi.Location = new System.Drawing.Point(457, 175);
            this.cbSimptomi.Name = "cbSimptomi";
            this.cbSimptomi.Size = new System.Drawing.Size(200, 24);
            this.cbSimptomi.TabIndex = 7;
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOdustani.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonOdustani.Location = new System.Drawing.Point(442, 459);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(156, 47);
            this.buttonOdustani.TabIndex = 20;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpremi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonSpremi.Location = new System.Drawing.Point(248, 459);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(156, 47);
            this.buttonSpremi.TabIndex = 19;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNatrag.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonNatrag.Location = new System.Drawing.Point(27, 28);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(94, 46);
            this.buttonNatrag.TabIndex = 21;
            this.buttonNatrag.Text = "Natrag";
            this.buttonNatrag.UseVisualStyleBackColor = true;
            this.buttonNatrag.Click += new System.EventHandler(this.buttonNatrag_Click);
            // 
            // dbTrudnoce
            // 
            this.dbTrudnoce.FormattingEnabled = true;
            this.dbTrudnoce.Location = new System.Drawing.Point(457, 119);
            this.dbTrudnoce.Name = "dbTrudnoce";
            this.dbTrudnoce.Size = new System.Drawing.Size(200, 24);
            this.dbTrudnoce.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(197, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Trudnoca";
            // 
            // Simptomi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(981, 917);
            this.Controls.Add(this.dbTrudnoce);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonNatrag);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.cbSimptomi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatumPocetkaSimptoma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSimptomi);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Simptomi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimptomiTrudnica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimptomi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSimptomi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetkaSimptoma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSimptomi;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.Button buttonNatrag;
        private System.Windows.Forms.ComboBox dbTrudnoce;
        private System.Windows.Forms.Label label5;
    }
}