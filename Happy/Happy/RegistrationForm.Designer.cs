using System.Windows.Forms;

namespace Happy
{
    partial class RegistrationForm
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
            this.LoginTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.Password2Textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.Location = new System.Drawing.Point(12, 12);
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(269, 20);
            this.LoginTextbox.TabIndex = 0;
            this.LoginTextbox.MouseClick+=new MouseEventHandler(this.LoginTextbox_Click_1);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(12, 38);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(269, 20);
            this.PasswordTextbox.TabIndex = 1;
            this.PasswordTextbox.MouseClick+=new MouseEventHandler(this.PasswordTextbox_Click_1);
            // 
            // Password2Textbox
            // 
            this.Password2Textbox.Location = new System.Drawing.Point(12, 64);
            this.Password2Textbox.Name = "Password2Textbox";
            this.Password2Textbox.Size = new System.Drawing.Size(269, 20);
            this.Password2Textbox.TabIndex = 2;
            this.Password2Textbox.MouseClick+=new MouseEventHandler(this.Password2Textbox_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 117);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password2Textbox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.LoginTextbox);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox Password2Textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}