namespace WindowsFormsApp_Proiect_1
{
    partial class FormAdaugaRezervare
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
            this.LocNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdaugareButton3 = new System.Windows.Forms.Button();
            this.TipComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PretTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LocNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // LocNumericUpDown1
            // 
            this.LocNumericUpDown1.BackColor = System.Drawing.Color.Moccasin;
            this.LocNumericUpDown1.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocNumericUpDown1.Location = new System.Drawing.Point(438, 9);
            this.LocNumericUpDown1.Name = "LocNumericUpDown1";
            this.LocNumericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.LocNumericUpDown1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Moccasin;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tip";
            // 
            // AdaugareButton3
            // 
            this.AdaugareButton3.BackColor = System.Drawing.Color.PowderBlue;
            this.AdaugareButton3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaugareButton3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AdaugareButton3.Location = new System.Drawing.Point(375, 116);
            this.AdaugareButton3.Name = "AdaugareButton3";
            this.AdaugareButton3.Size = new System.Drawing.Size(118, 35);
            this.AdaugareButton3.TabIndex = 11;
            this.AdaugareButton3.Text = "Salvare";
            this.AdaugareButton3.UseVisualStyleBackColor = false;
            this.AdaugareButton3.Click += new System.EventHandler(this.AdaugareButton3_Click);
            // 
            // TipComboBox
            // 
            this.TipComboBox.BackColor = System.Drawing.Color.Moccasin;
            this.TipComboBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipComboBox.FormattingEnabled = true;
            this.TipComboBox.Location = new System.Drawing.Point(81, 49);
            this.TipComboBox.Name = "TipComboBox";
            this.TipComboBox.Size = new System.Drawing.Size(121, 30);
            this.TipComboBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Moccasin;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Alegeti locul pe care doriti sa il rezervati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Moccasin;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pret";
            // 
            // PretTextBox
            // 
            this.PretTextBox.BackColor = System.Drawing.Color.Moccasin;
            this.PretTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretTextBox.Location = new System.Drawing.Point(81, 96);
            this.PretTextBox.Name = "PretTextBox";
            this.PretTextBox.Size = new System.Drawing.Size(121, 29);
            this.PretTextBox.TabIndex = 16;
            // 
            // FormAdaugaRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(557, 176);
            this.Controls.Add(this.PretTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipComboBox);
            this.Controls.Add(this.AdaugareButton3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocNumericUpDown1);
            this.Name = "FormAdaugaRezervare";
            this.Text = "RezervareForm";
            ((System.ComponentModel.ISupportInitialize)(this.LocNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown LocNumericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AdaugareButton3;
        private System.Windows.Forms.ComboBox TipComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PretTextBox;
    }
}