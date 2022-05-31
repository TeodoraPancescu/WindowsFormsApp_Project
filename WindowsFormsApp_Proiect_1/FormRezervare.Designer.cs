namespace WindowsFormsApp_Proiect_1
{
    partial class FormRezervare
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
            this.RezervareDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.AdaugareLocButton = new System.Windows.Forms.Button();
            this.RegularSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StandardSumLabel = new System.Windows.Forms.Label();
            this.VIPSumLabel = new System.Windows.Forms.Label();
            this.BackButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RezervareDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RezervareDataGridView
            // 
            this.RezervareDataGridView.AllowUserToAddRows = false;
            this.RezervareDataGridView.AllowUserToDeleteRows = false;
            this.RezervareDataGridView.BackgroundColor = System.Drawing.Color.Moccasin;
            this.RezervareDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezervareDataGridView.Location = new System.Drawing.Point(0, 286);
            this.RezervareDataGridView.Name = "RezervareDataGridView";
            this.RezervareDataGridView.ReadOnly = true;
            this.RezervareDataGridView.RowHeadersWidth = 51;
            this.RezervareDataGridView.RowTemplate.Height = 24;
            this.RezervareDataGridView.Size = new System.Drawing.Size(383, 217);
            this.RezervareDataGridView.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Moccasin;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 38);
            this.label2.TabIndex = 19;
            this.label2.Text = "Be Fast And Green";
            // 
            // AdaugareLocButton
            // 
            this.AdaugareLocButton.BackColor = System.Drawing.Color.Moccasin;
            this.AdaugareLocButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaugareLocButton.Location = new System.Drawing.Point(220, 198);
            this.AdaugareLocButton.Name = "AdaugareLocButton";
            this.AdaugareLocButton.Size = new System.Drawing.Size(108, 40);
            this.AdaugareLocButton.TabIndex = 20;
            this.AdaugareLocButton.Text = "Rezerva";
            this.AdaugareLocButton.UseVisualStyleBackColor = false;
            this.AdaugareLocButton.Click += new System.EventHandler(this.AdaugareLocButton_Click);
            // 
            // RegularSum
            // 
            this.RegularSum.AutoSize = true;
            this.RegularSum.BackColor = System.Drawing.Color.Moccasin;
            this.RegularSum.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegularSum.Location = new System.Drawing.Point(12, 47);
            this.RegularSum.Name = "RegularSum";
            this.RegularSum.Size = new System.Drawing.Size(190, 22);
            this.RegularSum.TabIndex = 21;
            this.RegularSum.Text = "Pret Total Standard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pret Total VIP";
            // 
            // StandardSumLabel
            // 
            this.StandardSumLabel.AutoSize = true;
            this.StandardSumLabel.BackColor = System.Drawing.Color.Moccasin;
            this.StandardSumLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardSumLabel.Location = new System.Drawing.Point(246, 47);
            this.StandardSumLabel.Name = "StandardSumLabel";
            this.StandardSumLabel.Size = new System.Drawing.Size(63, 22);
            this.StandardSumLabel.TabIndex = 23;
            this.StandardSumLabel.Text = "label3";
            // 
            // VIPSumLabel
            // 
            this.VIPSumLabel.AutoSize = true;
            this.VIPSumLabel.BackColor = System.Drawing.Color.Moccasin;
            this.VIPSumLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIPSumLabel.Location = new System.Drawing.Point(246, 84);
            this.VIPSumLabel.Name = "VIPSumLabel";
            this.VIPSumLabel.Size = new System.Drawing.Size(63, 22);
            this.VIPSumLabel.TabIndex = 24;
            this.VIPSumLabel.Text = "label4";
            // 
            // BackButton1
            // 
            this.BackButton1.BackColor = System.Drawing.Color.Moccasin;
            this.BackButton1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButton1.Location = new System.Drawing.Point(12, 251);
            this.BackButton1.Name = "BackButton1";
            this.BackButton1.Size = new System.Drawing.Size(108, 29);
            this.BackButton1.TabIndex = 25;
            this.BackButton1.Text = "Back";
            this.BackButton1.UseVisualStyleBackColor = false;
            this.BackButton1.Click += new System.EventHandler(this.BackButton1_Click);
            // 
            // FormRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp_Proiect_1.Properties.Resources.scaune;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(384, 500);
            this.Controls.Add(this.BackButton1);
            this.Controls.Add(this.VIPSumLabel);
            this.Controls.Add(this.StandardSumLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegularSum);
            this.Controls.Add(this.AdaugareLocButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RezervareDataGridView);
            this.Name = "FormRezervare";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.RezervareDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RezervareDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AdaugareLocButton;
        private System.Windows.Forms.Label RegularSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StandardSumLabel;
        private System.Windows.Forms.Label VIPSumLabel;
        private System.Windows.Forms.Button BackButton1;
    }
}