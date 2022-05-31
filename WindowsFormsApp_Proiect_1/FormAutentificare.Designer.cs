namespace WindowsFormsApp_Proiect_1
{
    partial class FormAutentificare
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox1 = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.BackButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autetificare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // UserTextBox
            // 
            this.UserTextBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.UserTextBox.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTextBox.Location = new System.Drawing.Point(137, 96);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(245, 27);
            this.UserTextBox.TabIndex = 3;
            // 
            // PassTextBox1
            // 
            this.PassTextBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.PassTextBox1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTextBox1.Location = new System.Drawing.Point(137, 149);
            this.PassTextBox1.Name = "PassTextBox1";
            this.PassTextBox1.PasswordChar = '*';
            this.PassTextBox1.Size = new System.Drawing.Size(245, 27);
            this.PassTextBox1.TabIndex = 4;
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.PowderBlue;
            this.LogInButton.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LogInButton.Location = new System.Drawing.Point(146, 205);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(96, 29);
            this.LogInButton.TabIndex = 5;
            this.LogInButton.Text = "Log In!";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // BackButton4
            // 
            this.BackButton4.BackColor = System.Drawing.Color.PowderBlue;
            this.BackButton4.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BackButton4.Location = new System.Drawing.Point(1, 1);
            this.BackButton4.Name = "BackButton4";
            this.BackButton4.Size = new System.Drawing.Size(74, 29);
            this.BackButton4.TabIndex = 8;
            this.BackButton4.Text = "Back";
            this.BackButton4.UseVisualStyleBackColor = false;
            this.BackButton4.Click += new System.EventHandler(this.BackButton4_Click);
            // 
            // FormAutentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(388, 265);
            this.Controls.Add(this.BackButton4);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PassTextBox1);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAutentificare";
            this.Text = "AutentificareForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PassTextBox1;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button BackButton4;
    }
}