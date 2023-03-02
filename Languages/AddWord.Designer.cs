namespace Languages
{
    partial class AddWord
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
			this.EnglishAddWordsBTN = new System.Windows.Forms.Button();
			this.EnglishRemoveWords = new System.Windows.Forms.Button();
			this.AddWords = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// EnglishAddWordsBTN
			// 
			this.EnglishAddWordsBTN.Location = new System.Drawing.Point(12, 415);
			this.EnglishAddWordsBTN.Name = "EnglishAddWordsBTN";
			this.EnglishAddWordsBTN.Size = new System.Drawing.Size(75, 23);
			this.EnglishAddWordsBTN.TabIndex = 1;
			this.EnglishAddWordsBTN.Text = "Add words";
			this.EnglishAddWordsBTN.UseVisualStyleBackColor = true;
			this.EnglishAddWordsBTN.Click += new System.EventHandler(this.AddRows_Click);
			// 
			// EnglishRemoveWords
			// 
			this.EnglishRemoveWords.Location = new System.Drawing.Point(93, 415);
			this.EnglishRemoveWords.Name = "EnglishRemoveWords";
			this.EnglishRemoveWords.Size = new System.Drawing.Size(107, 23);
			this.EnglishRemoveWords.TabIndex = 1;
			this.EnglishRemoveWords.Text = "Remove words";
			this.EnglishRemoveWords.UseVisualStyleBackColor = true;
			this.EnglishRemoveWords.Click += new System.EventHandler(this.RemoveRows_Click);
			// 
			// AddWords
			// 
			this.AddWords.Location = new System.Drawing.Point(12, 12);
			this.AddWords.Name = "AddWords";
			this.AddWords.Size = new System.Drawing.Size(437, 275);
			this.AddWords.TabIndex = 2;
			this.AddWords.TabStop = false;
			this.AddWords.Text = "AddWords";
			this.AddWords.Enter += new System.EventHandler(this.AddWords_Enter);
			// 
			// AddWord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.AddWords);
			this.Controls.Add(this.EnglishRemoveWords);
			this.Controls.Add(this.EnglishAddWordsBTN);
			this.Name = "AddWord";
			this.Text = "AddWord";
			this.Load += new System.EventHandler(this.English_Load);
			this.ResumeLayout(false);

        }

        #endregion
        private Button EnglishAddWordsBTN;
        private Button EnglishRemoveWords;
		private GroupBox AddWords;
	}
}