namespace WindowsFormsApp_Proiect_1
{
    partial class FormPasager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPasager));
            this.AdaugareButton1 = new System.Windows.Forms.Button();
            this.PasagerDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContinuareButton = new System.Windows.Forms.Button();
            this.ErrorProviderNume = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PasagerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderNume)).BeginInit();
            this.SuspendLayout();
            // 
            // AdaugareButton1
            // 
            this.AdaugareButton1.BackColor = System.Drawing.Color.PowderBlue;
            this.AdaugareButton1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaugareButton1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AdaugareButton1.Location = new System.Drawing.Point(-1, 37);
            this.AdaugareButton1.Name = "AdaugareButton1";
            this.AdaugareButton1.Size = new System.Drawing.Size(161, 31);
            this.AdaugareButton1.TabIndex = 5;
            this.AdaugareButton1.Text = "Adauga Pasager";
            this.AdaugareButton1.UseVisualStyleBackColor = false;
            this.AdaugareButton1.Click += new System.EventHandler(this.AdaugareButton1_Click);
            // 
            // PasagerDataGridView
            // 
            this.PasagerDataGridView.AllowUserToAddRows = false;
            this.PasagerDataGridView.AllowUserToDeleteRows = false;
            this.PasagerDataGridView.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.PasagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PasagerDataGridView.Location = new System.Drawing.Point(564, 37);
            this.PasagerDataGridView.Name = "PasagerDataGridView";
            this.PasagerDataGridView.ReadOnly = true;
            this.PasagerDataGridView.RowHeadersWidth = 51;
            this.PasagerDataGridView.RowTemplate.Height = 24;
            this.PasagerDataGridView.Size = new System.Drawing.Size(608, 323);
            this.PasagerDataGridView.TabIndex = 6;
            this.PasagerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BackButton1
            // 
            this.BackButton1.BackColor = System.Drawing.Color.PowderBlue;
            this.BackButton1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BackButton1.Location = new System.Drawing.Point(455, 2);
            this.BackButton1.Name = "BackButton1";
            this.BackButton1.Size = new System.Drawing.Size(108, 29);
            this.BackButton1.TabIndex = 7;
            this.BackButton1.Text = "Back";
            this.BackButton1.UseVisualStyleBackColor = false;
            this.BackButton1.Click += new System.EventHandler(this.BackButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ContinuareButton
            // 
            this.ContinuareButton.BackColor = System.Drawing.Color.PowderBlue;
            this.ContinuareButton.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinuareButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ContinuareButton.Location = new System.Drawing.Point(397, 320);
            this.ContinuareButton.Name = "ContinuareButton";
            this.ContinuareButton.Size = new System.Drawing.Size(161, 31);
            this.ContinuareButton.TabIndex = 11;
            this.ContinuareButton.Text = "Continua";
            this.ContinuareButton.UseVisualStyleBackColor = false;
            this.ContinuareButton.Click += new System.EventHandler(this.ContinuareButton_Click);
            // 
            // ErrorProviderNume
            // 
            this.ErrorProviderNume.ContainerControl = this;
            // 
            // FormPasager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1171, 363);
            this.Controls.Add(this.ContinuareButton);
            this.Controls.Add(this.BackButton1);
            this.Controls.Add(this.PasagerDataGridView);
            this.Controls.Add(this.AdaugareButton1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPasager";
            this.Text = "FormPasager";
            ((System.ComponentModel.ISupportInitialize)(this.PasagerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderNume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AdaugareButton1;
        private System.Windows.Forms.DataGridView PasagerDataGridView;
        private System.Windows.Forms.Button BackButton1;
        private System.Windows.Forms.Button ContinuareButton;
        private System.Windows.Forms.ErrorProvider ErrorProviderNume;
    }
}