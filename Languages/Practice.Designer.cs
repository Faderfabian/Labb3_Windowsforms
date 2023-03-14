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
			this.buttonCheck = new System.Windows.Forms.Button();
			this.buttonFinish = new System.Windows.Forms.Button();
			this.labelFromLanguage = new System.Windows.Forms.Label();
			this.labelToLanguage = new System.Windows.Forms.Label();
			this.labelWord = new System.Windows.Forms.Label();
			this.labelResult = new System.Windows.Forms.Label();
			this.textBoxTranslation = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonCheck
			// 
			this.buttonCheck.Location = new System.Drawing.Point(133, 374);
			this.buttonCheck.Name = "buttonCheck";
			this.buttonCheck.Size = new System.Drawing.Size(75, 23);
			this.buttonCheck.TabIndex = 0;
			this.buttonCheck.Text = "Check";
			this.buttonCheck.UseVisualStyleBackColor = true;
			this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
			// 
			// buttonFinish
			// 
			this.buttonFinish.Location = new System.Drawing.Point(500, 375);
			this.buttonFinish.Name = "buttonFinish";
			this.buttonFinish.Size = new System.Drawing.Size(75, 23);
			this.buttonFinish.TabIndex = 1;
			this.buttonFinish.Text = "Finish";
			this.buttonFinish.UseVisualStyleBackColor = true;
			this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
			// 
			// labelFromLanguage
			// 
			this.labelFromLanguage.AutoSize = true;
			this.labelFromLanguage.Location = new System.Drawing.Point(214, 109);
			this.labelFromLanguage.Name = "labelFromLanguage";
			this.labelFromLanguage.Size = new System.Drawing.Size(35, 15);
			this.labelFromLanguage.TabIndex = 2;
			this.labelFromLanguage.Text = "From";
			this.labelFromLanguage.Click += new System.EventHandler(this.labelFromLanguage_Click);
			// 
			// labelToLanguage
			// 
			this.labelToLanguage.AutoSize = true;
			this.labelToLanguage.Location = new System.Drawing.Point(213, 153);
			this.labelToLanguage.Name = "labelToLanguage";
			this.labelToLanguage.Size = new System.Drawing.Size(19, 15);
			this.labelToLanguage.TabIndex = 3;
			this.labelToLanguage.Text = "To";
			// 
			// labelWord
			// 
			this.labelWord.AutoSize = true;
			this.labelWord.Location = new System.Drawing.Point(213, 66);
			this.labelWord.Name = "labelWord";
			this.labelWord.Size = new System.Drawing.Size(36, 15);
			this.labelWord.TabIndex = 4;
			this.labelWord.Text = "Word";
			this.labelWord.Click += new System.EventHandler(this.labelWord_Click);
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Location = new System.Drawing.Point(364, 109);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(39, 15);
			this.labelResult.TabIndex = 5;
			this.labelResult.Text = "Result";
			// 
			// textBoxTranslation
			// 
			this.textBoxTranslation.Location = new System.Drawing.Point(133, 328);
			this.textBoxTranslation.Name = "textBoxTranslation";
			this.textBoxTranslation.Size = new System.Drawing.Size(442, 23);
			this.textBoxTranslation.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(158, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "Word:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(158, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "From";
			this.label2.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(158, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "To";
			this.label3.Click += new System.EventHandler(this.label1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(364, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Result";
			this.label4.Click += new System.EventHandler(this.label1_Click);
			// 
			// Practice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxTranslation);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.labelWord);
			this.Controls.Add(this.labelToLanguage);
			this.Controls.Add(this.labelFromLanguage);
			this.Controls.Add(this.buttonFinish);
			this.Controls.Add(this.buttonCheck);
			this.Name = "Practice";
			this.Text = "Practice";
			this.Load += new System.EventHandler(this.Practice_Load_1);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button buttonCheck;
		private Button buttonFinish;
		private Label labelFromLanguage;
		private Label labelToLanguage;
		private Label labelWord;
		private Label labelResult;
		private TextBox textBoxTranslation;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
	}
}