namespace Happy
{
    partial class EnterProblem
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
            this.ProblemTextBox = new System.Windows.Forms.TextBox();
            this.GetProblem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите Вашу проблему:";
            // 
            // ProblemTextBox
            // 
            this.ProblemTextBox.Location = new System.Drawing.Point(28, 68);
            this.ProblemTextBox.Name = "ProblemTextBox";
            this.ProblemTextBox.Size = new System.Drawing.Size(284, 20);
            this.ProblemTextBox.TabIndex = 1;
            // 
            // GetProblem
            // 
            this.GetProblem.Location = new System.Drawing.Point(90, 111);
            this.GetProblem.Name = "GetProblem";
            this.GetProblem.Size = new System.Drawing.Size(152, 28);
            this.GetProblem.TabIndex = 2;
            this.GetProblem.Text = "OK";
            this.GetProblem.UseVisualStyleBackColor = true;
            this.GetProblem.Click += new System.EventHandler(this.GetProblem_Click);
            // 
            // EnterProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 151);
            this.Controls.Add(this.GetProblem);
            this.Controls.Add(this.ProblemTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EnterProblem";
            this.Text = "EnterProblem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProblemTextBox;
        private System.Windows.Forms.Button GetProblem;
    }
}