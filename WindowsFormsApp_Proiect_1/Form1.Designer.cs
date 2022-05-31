namespace WindowsFormsApp_Proiect_1
{
    partial class FormPrincipal
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
            this.InformatiiButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DateButton = new System.Windows.Forms.Button();
            this.AutentificareButton = new System.Windows.Forms.Button();
            this.VehiculeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InformatiiButton
            // 
            this.InformatiiButton.BackColor = System.Drawing.Color.PowderBlue;
            this.InformatiiButton.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformatiiButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.InformatiiButton.Location = new System.Drawing.Point(704, 495);
            this.InformatiiButton.Name = "InformatiiButton";
            this.InformatiiButton.Size = new System.Drawing.Size(212, 31);
            this.InformatiiButton.TabIndex = 2;
            this.InformatiiButton.Text = "Informatii Telefonice";
            this.InformatiiButton.UseVisualStyleBackColor = false;
            this.InformatiiButton.Click += new System.EventHandler(this.InformatiiButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 31.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = " ";
            // 
            // DateButton
            // 
            this.DateButton.BackColor = System.Drawing.Color.PowderBlue;
            this.DateButton.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DateButton.Location = new System.Drawing.Point(-2, 74);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(327, 31);
            this.DateButton.TabIndex = 5;
            this.DateButton.Text = "Introduceti datele pentru a rezerva";
            this.DateButton.UseVisualStyleBackColor = false;
            this.DateButton.Click += new System.EventHandler(this.DateButton_Click);
            // 
            // AutentificareButton
            // 
            this.AutentificareButton.BackColor = System.Drawing.Color.PowderBlue;
            this.AutentificareButton.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutentificareButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AutentificareButton.Location = new System.Drawing.Point(726, 74);
            this.AutentificareButton.Name = "AutentificareButton";
            this.AutentificareButton.Size = new System.Drawing.Size(175, 31);
            this.AutentificareButton.TabIndex = 6;
            this.AutentificareButton.Text = "Autentificare";
            this.AutentificareButton.UseVisualStyleBackColor = false;
            this.AutentificareButton.Click += new System.EventHandler(this.AutentificareButton_Click);
            // 
            // VehiculeButton
            // 
            this.VehiculeButton.BackColor = System.Drawing.Color.PowderBlue;
            this.VehiculeButton.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiculeButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.VehiculeButton.Location = new System.Drawing.Point(12, 495);
            this.VehiculeButton.Name = "VehiculeButton";
            this.VehiculeButton.Size = new System.Drawing.Size(216, 31);
            this.VehiculeButton.TabIndex = 8;
            this.VehiculeButton.Text = "Automobilele noastre";
            this.VehiculeButton.UseVisualStyleBackColor = false;
            this.VehiculeButton.Click += new System.EventHandler(this.VehiculeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp_Proiect_1.Properties.Resources.bus1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(936, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 57);
            this.label2.TabIndex = 9;
            this.label2.Text = "Be Fast And Green";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(928, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VehiculeButton);
            this.Controls.Add(this.AutentificareButton);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InformatiiButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button InformatiiButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Button AutentificareButton;
        private System.Windows.Forms.Button VehiculeButton;
        private System.Windows.Forms.Label label2;
    }
}

