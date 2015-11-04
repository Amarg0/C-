namespace Happy
{
    partial class ProblemHistory
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
            this.MainProblem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CurrentProblem = new System.Windows.Forms.Label();
            this.CurrentStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainProblem
            // 
            this.MainProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainProblem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MainProblem.Location = new System.Drawing.Point(12, 9);
            this.MainProblem.Name = "MainProblem";
            this.MainProblem.Size = new System.Drawing.Size(543, 61);
            this.MainProblem.TabIndex = 0;
            this.MainProblem.Text = "Ваша главная проблема:";
            this.MainProblem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 10);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(12, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 61);
            this.label2.TabIndex = 2;
            this.label2.Text = "Чтобы её решить нужно:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 10);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = global::Happy.Properties.Resources.left;
            this.button1.Location = new System.Drawing.Point(12, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 69);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Happy.Properties.Resources.right;
            this.button2.Location = new System.Drawing.Point(505, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 69);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CurrentProblem
            // 
            this.CurrentProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentProblem.Location = new System.Drawing.Point(117, 94);
            this.CurrentProblem.Name = "CurrentProblem";
            this.CurrentProblem.Size = new System.Drawing.Size(319, 49);
            this.CurrentProblem.TabIndex = 5;
            this.CurrentProblem.Text = "Текущая проблема:";
            this.CurrentProblem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CurrentStatus
            // 
            this.CurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentStatus.Location = new System.Drawing.Point(117, 162);
            this.CurrentStatus.Name = "CurrentStatus";
            this.CurrentStatus.Size = new System.Drawing.Size(319, 49);
            this.CurrentStatus.TabIndex = 6;
            this.CurrentStatus.Text = "Состояние:";
            this.CurrentStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProblemHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 316);
            this.Controls.Add(this.CurrentStatus);
            this.Controls.Add(this.CurrentProblem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainProblem);
            this.Name = "ProblemHistory";
            this.Text = "ProblemHistory";
            this.Load += new System.EventHandler(this.ProblemHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainProblem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label CurrentProblem;
        private System.Windows.Forms.Label CurrentStatus;
    }
}