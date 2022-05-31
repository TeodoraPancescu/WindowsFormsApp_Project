namespace WindowsFormsApp_Proiect_1
{
    partial class FormRuta
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdaugaRutaButton1 = new System.Windows.Forms.Button();
            this.ContinuareButton2 = new System.Windows.Forms.Button();
            this.RutaDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RutaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 57);
            this.label2.TabIndex = 18;
            this.label2.Text = "Be Fast And Green";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::WindowsFormsApp_Proiect_1.Properties.Resources.ruta;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(752, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // AdaugaRutaButton1
            // 
            this.AdaugaRutaButton1.BackColor = System.Drawing.Color.PowderBlue;
            this.AdaugaRutaButton1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaugaRutaButton1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AdaugaRutaButton1.Location = new System.Drawing.Point(1049, 182);
            this.AdaugaRutaButton1.Name = "AdaugaRutaButton1";
            this.AdaugaRutaButton1.Size = new System.Drawing.Size(154, 34);
            this.AdaugaRutaButton1.TabIndex = 20;
            this.AdaugaRutaButton1.Text = "Adauga Ruta";
            this.AdaugaRutaButton1.UseVisualStyleBackColor = false;
            this.AdaugaRutaButton1.Click += new System.EventHandler(this.AdaugaRutaButton1_Click_1);
            // 
            // ContinuareButton2
            // 
            this.ContinuareButton2.BackColor = System.Drawing.Color.PowderBlue;
            this.ContinuareButton2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinuareButton2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ContinuareButton2.Location = new System.Drawing.Point(805, 427);
            this.ContinuareButton2.Name = "ContinuareButton2";
            this.ContinuareButton2.Size = new System.Drawing.Size(124, 30);
            this.ContinuareButton2.TabIndex = 21;
            this.ContinuareButton2.Text = "Continua";
            this.ContinuareButton2.UseVisualStyleBackColor = false;
            this.ContinuareButton2.Click += new System.EventHandler(this.ContinuareButton2_Click_1);
            // 
            // RutaDataGridView
            // 
            this.RutaDataGridView.AllowUserToAddRows = false;
            this.RutaDataGridView.AllowUserToDeleteRows = false;
            this.RutaDataGridView.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.RutaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RutaDataGridView.Location = new System.Drawing.Point(-3, 69);
            this.RutaDataGridView.Name = "RutaDataGridView";
            this.RutaDataGridView.ReadOnly = true;
            this.RutaDataGridView.RowHeadersWidth = 51;
            this.RutaDataGridView.RowTemplate.Height = 24;
            this.RutaDataGridView.Size = new System.Drawing.Size(749, 402);
            this.RutaDataGridView.TabIndex = 22;
            // 
            // BackButton1
            // 
            this.BackButton1.BackColor = System.Drawing.Color.PowderBlue;
            this.BackButton1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BackButton1.Location = new System.Drawing.Point(1177, 9);
            this.BackButton1.Name = "BackButton1";
            this.BackButton1.Size = new System.Drawing.Size(108, 29);
            this.BackButton1.TabIndex = 23;
            this.BackButton1.Text = "Back";
            this.BackButton1.UseVisualStyleBackColor = false;
            this.BackButton1.Click += new System.EventHandler(this.BackButton1_Click);
            // 
            // FormRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1286, 469);
            this.Controls.Add(this.BackButton1);
            this.Controls.Add(this.RutaDataGridView);
            this.Controls.Add(this.ContinuareButton2);
            this.Controls.Add(this.AdaugaRutaButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "FormRuta";
            this.Text = "FormRuta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RutaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AdaugaRutaButton1;
        private System.Windows.Forms.Button ContinuareButton2;
        private System.Windows.Forms.DataGridView RutaDataGridView;
        private System.Windows.Forms.Button BackButton1;
    }
}