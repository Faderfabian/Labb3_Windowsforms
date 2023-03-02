namespace Languages
{
	partial class ShowList
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
			this.dgvWords = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvWords
			// 
			this.dgvWords.AllowUserToAddRows = false;
			this.dgvWords.AllowUserToDeleteRows = false;
			this.dgvWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvWords.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvWords.Location = new System.Drawing.Point(0, 0);
			this.dgvWords.Name = "dgvWords";
			this.dgvWords.ReadOnly = true;
			this.dgvWords.RowTemplate.Height = 25;
			this.dgvWords.Size = new System.Drawing.Size(800, 450);
			this.dgvWords.TabIndex = 0;
			this.dgvWords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWords_CellContentClick);
			// 
			// ShowList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvWords);
			this.Name = "ShowList";
			this.Text = "ShowList";
			this.Load += new System.EventHandler(this.ShowList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvWords)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dgvWords;
	}
}