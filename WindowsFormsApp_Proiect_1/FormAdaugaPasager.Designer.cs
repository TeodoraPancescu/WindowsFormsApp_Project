namespace WindowsFormsApp_Proiect_1
{
    partial class FormAdaugaPasager
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrenumeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume";
            // 
            // NumeTextBox
            // 
            this.NumeTextBox.BackColor = System.Drawing.Color.Moccasin;
            this.NumeTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeTextBox.Location = new System.Drawing.Point(157, 26);
            this.NumeTextBox.Name = "NumeTextBox";
            this.NumeTextBox.Size = new System.Drawing.Size(141, 29);
            this.NumeTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Moccasin;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prenume";
            // 
            // PrenumeTextBox
            // 
            this.PrenumeTextBox.BackColor = System.Drawing.Color.Moccasin;
            this.PrenumeTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenumeTextBox.Location = new System.Drawing.Point(157, 78);
            this.PrenumeTextBox.Name = "PrenumeTextBox";
            this.PrenumeTextBox.Size = new System.Drawing.Size(141, 29);
            this.PrenumeTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Moccasin;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mail";
            // 
            // MailTextBox
            // 
            this.MailTextBox.BackColor = System.Drawing.Color.Moccasin;
            this.MailTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailTextBox.Location = new System.Drawing.Point(157, 130);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(141, 29);
            this.MailTextBox.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.PowderBlue;
            this.SaveButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SaveButton.Location = new System.Drawing.Point(259, 190);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 43);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FormAdaugaPasager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(357, 257);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrenumeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormAdaugaPasager";
            this.Text = "AdaugaPasager";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.Mail_validating);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrenumeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}