namespace WindowsFormsApp_Proiect_1
{
    partial class FormAutovehicule
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
            this.LabelDenumire = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTip = new System.Windows.Forms.Label();
            this.BackButton4 = new System.Windows.Forms.Button();
            this.PozeAutovehiculePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PozeAutovehiculePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDenumire
            // 
            this.LabelDenumire.AutoSize = true;
            this.LabelDenumire.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDenumire.Location = new System.Drawing.Point(323, 429);
            this.LabelDenumire.Name = "LabelDenumire";
            this.LabelDenumire.Size = new System.Drawing.Size(91, 21);
            this.LabelDenumire.TabIndex = 2;
            this.LabelDenumire.Text = "Denumire";
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.PowderBlue;
            this.NextButton.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.NextButton.Location = new System.Drawing.Point(677, 429);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 32);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.BackColor = System.Drawing.Color.PowderBlue;
            this.PrevButton.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PrevButton.Location = new System.Drawing.Point(-3, 429);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 32);
            this.PrevButton.TabIndex = 5;
            this.PrevButton.Text = "Prev";
            this.PrevButton.UseVisualStyleBackColor = false;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Acestea sunt autobuze electrice sau pe hidrogen, Impreuna protejam natura!";
            // 
            // LabelTip
            // 
            this.LabelTip.AutoSize = true;
            this.LabelTip.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTip.Location = new System.Drawing.Point(323, 464);
            this.LabelTip.Name = "LabelTip";
            this.LabelTip.Size = new System.Drawing.Size(39, 21);
            this.LabelTip.TabIndex = 7;
            this.LabelTip.Text = "Tip";
            // 
            // BackButton4
            // 
            this.BackButton4.BackColor = System.Drawing.Color.PowderBlue;
            this.BackButton4.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BackButton4.Location = new System.Drawing.Point(665, 2);
            this.BackButton4.Name = "BackButton4";
            this.BackButton4.Size = new System.Drawing.Size(74, 29);
            this.BackButton4.TabIndex = 9;
            this.BackButton4.Text = "Back";
            this.BackButton4.UseVisualStyleBackColor = false;
            this.BackButton4.Click += new System.EventHandler(this.BackButton4_Click);
            // 
            // PozeAutovehiculePictureBox
            // 
            this.PozeAutovehiculePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PozeAutovehiculePictureBox.Image = global::WindowsFormsApp_Proiect_1.Properties.Resources.electric21;
            this.PozeAutovehiculePictureBox.Location = new System.Drawing.Point(87, 74);
            this.PozeAutovehiculePictureBox.Name = "PozeAutovehiculePictureBox";
            this.PozeAutovehiculePictureBox.Size = new System.Drawing.Size(585, 352);
            this.PozeAutovehiculePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PozeAutovehiculePictureBox.TabIndex = 0;
            this.PozeAutovehiculePictureBox.TabStop = false;
            this.PozeAutovehiculePictureBox.Click += new System.EventHandler(this.PozeAutovehiculePictureBox_Click);
            // 
            // FormAutovehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(751, 494);
            this.Controls.Add(this.BackButton4);
            this.Controls.Add(this.LabelTip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.LabelDenumire);
            this.Controls.Add(this.PozeAutovehiculePictureBox);
            this.Name = "FormAutovehicule";
            this.Text = "FormAutovehicule";
            ((System.ComponentModel.ISupportInitialize)(this.PozeAutovehiculePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PozeAutovehiculePictureBox;
        private System.Windows.Forms.Label LabelDenumire;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelTip;
        private System.Windows.Forms.Button BackButton4;
    }
}