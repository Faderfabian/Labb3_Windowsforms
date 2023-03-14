namespace Languages
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.swedishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gettingStartedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.EnglishButton = new System.Windows.Forms.Button();
			this.SwedishButton = new System.Windows.Forms.Button();
			this.SpanishButton = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.languageList = new System.Windows.Forms.ListBox();
			this.languages = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(273, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome to Fabbes Language learning App!";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languagesToolStripMenuItem,
            this.loadListToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// languagesToolStripMenuItem
			// 
			this.languagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.swedishToolStripMenuItem,
            this.spanishToolStripMenuItem});
			this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
			this.languagesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.languagesToolStripMenuItem.Text = "Languages";
			// 
			// englishToolStripMenuItem
			// 
			this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			this.englishToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.englishToolStripMenuItem.Text = "AddWord";
			// 
			// swedishToolStripMenuItem
			// 
			this.swedishToolStripMenuItem.Name = "swedishToolStripMenuItem";
			this.swedishToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.swedishToolStripMenuItem.Text = "Swedish";
			// 
			// spanishToolStripMenuItem
			// 
			this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
			this.spanishToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.spanishToolStripMenuItem.Text = "Spanish";
			// 
			// loadListToolStripMenuItem
			// 
			this.loadListToolStripMenuItem.Name = "loadListToolStripMenuItem";
			this.loadListToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.loadListToolStripMenuItem.Text = "Load List";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.gettingStartedToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// gettingStartedToolStripMenuItem
			// 
			this.gettingStartedToolStripMenuItem.Name = "gettingStartedToolStripMenuItem";
			this.gettingStartedToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.gettingStartedToolStripMenuItem.Text = "Getting Started";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(377, 70);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(317, 45);
			this.label2.TabIndex = 2;
			this.label2.Text = "This App has been made to help you learn new languages. \r\nFor a quick start, sele" +
    "ct a language below. \r\nOr to get a more in-depth explanation of the features, cl" +
    "ick\r\n";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EnglishButton
			// 
			this.EnglishButton.Location = new System.Drawing.Point(508, 373);
			this.EnglishButton.Name = "EnglishButton";
			this.EnglishButton.Size = new System.Drawing.Size(75, 23);
			this.EnglishButton.TabIndex = 3;
			this.EnglishButton.Text = "Add word";
			this.EnglishButton.UseVisualStyleBackColor = true;
			this.EnglishButton.Click += new System.EventHandler(this.EnglishButton_Click);
			// 
			// SwedishButton
			// 
			this.SwedishButton.Location = new System.Drawing.Point(204, 373);
			this.SwedishButton.Name = "SwedishButton";
			this.SwedishButton.Size = new System.Drawing.Size(144, 23);
			this.SwedishButton.TabIndex = 3;
			this.SwedishButton.Text = "Show wordlist words";
			this.SwedishButton.UseVisualStyleBackColor = true;
			this.SwedishButton.Click += new System.EventHandler(this.SwedishButton_Click);
			// 
			// SpanishButton
			// 
			this.SpanishButton.Location = new System.Drawing.Point(725, 373);
			this.SpanishButton.Name = "SpanishButton";
			this.SpanishButton.Size = new System.Drawing.Size(75, 23);
			this.SpanishButton.TabIndex = 3;
			this.SpanishButton.Text = "Practice";
			this.SpanishButton.UseVisualStyleBackColor = true;
			this.SpanishButton.Click += new System.EventHandler(this.SpanishButton_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(489, 115);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(86, 15);
			this.linkLabel1.TabIndex = 4;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Getting Started";
			// 
			// languageList
			// 
			this.languageList.FormattingEnabled = true;
			this.languageList.ItemHeight = 15;
			this.languageList.Location = new System.Drawing.Point(48, 70);
			this.languageList.Name = "languageList";
			this.languageList.Size = new System.Drawing.Size(120, 259);
			this.languageList.TabIndex = 5;
			this.languageList.SelectedIndexChanged += new System.EventHandler(this.languageList_SelectedIndexChanged);
			// 
			// languages
			// 
			this.languages.FormattingEnabled = true;
			this.languages.ItemHeight = 15;
			this.languages.Location = new System.Drawing.Point(228, 70);
			this.languages.Name = "languages";
			this.languages.Size = new System.Drawing.Size(120, 259);
			this.languages.TabIndex = 6;
			this.languages.SelectedIndexChanged += new System.EventHandler(this.languages_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.languages);
			this.Controls.Add(this.languageList);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.SpanishButton);
			this.Controls.Add(this.SwedishButton);
			this.Controls.Add(this.EnglishButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Fabbes Language App";
			this.Load += new System.EventHandler(this.Form1_load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem languagesToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem swedishToolStripMenuItem;
        private ToolStripMenuItem spanishToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem gettingStartedToolStripMenuItem;
        private Label label2;
        private Button EnglishButton;
        private Button SwedishButton;
        private Button SpanishButton;
        private LinkLabel linkLabel1;
        private ListBox languageList;
        private ToolStripMenuItem loadListToolStripMenuItem;
        private ListBox languages;
    }
}