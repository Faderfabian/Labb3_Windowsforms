namespace Languages
{
    partial class Practice
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
			this.PracticeHeader = new System.Windows.Forms.Label();
			this.PracticeTextbox = new System.Windows.Forms.TextBox();
			this.PracticeStartbtn = new System.Windows.Forms.Button();
			this.PracticeStopbtn = new System.Windows.Forms.Button();
			this.PracticeExplanation = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// PracticeHeader
			// 
			this.PracticeHeader.AutoSize = true;
			this.PracticeHeader.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.PracticeHeader.Location = new System.Drawing.Point(275, 9);
			this.PracticeHeader.Name = "PracticeHeader";
			this.PracticeHeader.Size = new System.Drawing.Size(231, 22);
			this.PracticeHeader.TabIndex = 0;
			this.PracticeHeader.Text = "Practice your language skills!";
			// 
			// PracticeTextbox
			// 
			this.PracticeTextbox.Location = new System.Drawing.Point(209, 287);
			this.PracticeTextbox.Name = "PracticeTextbox";
			this.PracticeTextbox.Size = new System.Drawing.Size(389, 23);
			this.PracticeTextbox.TabIndex = 1;
			// 
			// PracticeStartbtn
			// 
			this.PracticeStartbtn.Location = new System.Drawing.Point(209, 350);
			this.PracticeStartbtn.Name = "PracticeStartbtn";
			this.PracticeStartbtn.Size = new System.Drawing.Size(75, 23);
			this.PracticeStartbtn.TabIndex = 2;
			this.PracticeStartbtn.Text = "Start";
			this.PracticeStartbtn.UseVisualStyleBackColor = true;
			// 
			// PracticeStopbtn
			// 
			this.PracticeStopbtn.Location = new System.Drawing.Point(523, 359);
			this.PracticeStopbtn.Name = "PracticeStopbtn";
			this.PracticeStopbtn.Size = new System.Drawing.Size(75, 23);
			this.PracticeStopbtn.TabIndex = 3;
			this.PracticeStopbtn.Text = "Stop";
			this.PracticeStopbtn.UseVisualStyleBackColor = true;
			this.PracticeStopbtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// PracticeExplanation
			// 
			this.PracticeExplanation.AutoSize = true;
			this.PracticeExplanation.Location = new System.Drawing.Point(343, 269);
			this.PracticeExplanation.Name = "PracticeExplanation";
			this.PracticeExplanation.Size = new System.Drawing.Size(137, 15);
			this.PracticeExplanation.TabIndex = 4;
			this.PracticeExplanation.Text = "Type in the correct word:";
			// 
			// Practice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.PracticeExplanation);
			this.Controls.Add(this.PracticeStopbtn);
			this.Controls.Add(this.PracticeStartbtn);
			this.Controls.Add(this.PracticeTextbox);
			this.Controls.Add(this.PracticeHeader);
			this.Name = "Practice";
			this.Text = "Practice";
			this.Load += new System.EventHandler(this.Practice_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label PracticeHeader;
        private TextBox PracticeTextbox;
        private Button PracticeStartbtn;
        private Button PracticeStopbtn;
        private Label PracticeExplanation;
    }
}