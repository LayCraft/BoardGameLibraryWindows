namespace BoardGameLibrary
{
    partial class GameManagerDialog
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
			System.Windows.Forms.MenuStrip menuStrip1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameManagerDialog));
			this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._gameListBox = new System.Windows.Forms.ListBox();
			this._noteTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
			this._lastPlayedDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this._purchasedDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this._playsTextBox = new System.Windows.Forms.TextBox();
			this._costTextBox = new System.Windows.Forms.TextBox();
			this._nameTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this._addPlayButton = new System.Windows.Forms.Button();
			this._newGameButton = new System.Windows.Forms.Button();
			this._deleteButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
			menuStrip1 = new System.Windows.Forms.MenuStrip();
			menuStrip1.SuspendLayout();
			this.toolStripContainer3.ContentPanel.SuspendLayout();
			this.toolStripContainer3.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer3.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			menuStrip1.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
			menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem});
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 4);
			menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			menuStrip1.Size = new System.Drawing.Size(544, 25);
			menuStrip1.TabIndex = 14;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem1
			// 
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.fileToolStripMenuItem1.Size = new System.Drawing.Size(33, 19);
			this.fileToolStripMenuItem1.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem1
			// 
			this.openToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem1.Image")));
			this.openToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
			this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
			this.openToolStripMenuItem1.Text = "&Open";
			this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Enabled = false;
			this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.saveAsToolStripMenuItem.Text = "Save &As";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// _gameListBox
			// 
			this._gameListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._gameListBox.FormattingEnabled = true;
			this._gameListBox.Location = new System.Drawing.Point(0, 16);
			this._gameListBox.Name = "_gameListBox";
			this._gameListBox.Size = new System.Drawing.Size(301, 264);
			this._gameListBox.TabIndex = 0;
			this._gameListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._gameListBox_MouseDoubleClick);
			// 
			// _noteTextBox
			// 
			this._noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._noteTextBox.Location = new System.Drawing.Point(310, 163);
			this._noteTextBox.Multiline = true;
			this._noteTextBox.Name = "_noteTextBox";
			this._noteTextBox.ReadOnly = true;
			this._noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._noteTextBox.Size = new System.Drawing.Size(231, 117);
			this._noteTextBox.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(307, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Note:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(307, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Purchased:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(307, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Cost:";
			// 
			// toolStripContainer3
			// 
			this.toolStripContainer3.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer3.ContentPanel
			// 
			this.toolStripContainer3.ContentPanel.Controls.Add(this._lastPlayedDateTimePicker);
			this.toolStripContainer3.ContentPanel.Controls.Add(this._purchasedDateTimePicker);
			this.toolStripContainer3.ContentPanel.Controls.Add(this._playsTextBox);
			this.toolStripContainer3.ContentPanel.Controls.Add(this._costTextBox);
			this.toolStripContainer3.ContentPanel.Controls.Add(this._nameTextBox);
			this.toolStripContainer3.ContentPanel.Controls.Add(this.label4);
			this.toolStripContainer3.ContentPanel.Controls.Add(this._addPlayButton);
			this.toolStripContainer3.ContentPanel.Controls.Add(this._newGameButton);
			this.toolStripContainer3.ContentPanel.Controls.Add(this._deleteButton);
			this.toolStripContainer3.ContentPanel.Controls.Add(this._noteTextBox);
			this.toolStripContainer3.ContentPanel.Controls.Add(this.label1);
			this.toolStripContainer3.ContentPanel.Controls.Add(this.label5);
			this.toolStripContainer3.ContentPanel.Controls.Add(this.label2);
			this.toolStripContainer3.ContentPanel.Controls.Add(this.label6);
			this.toolStripContainer3.ContentPanel.Controls.Add(this.label3);
			this.toolStripContainer3.ContentPanel.Controls.Add(this._gameListBox);
			this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(544, 320);
			this.toolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer3.LeftToolStripPanelVisible = false;
			this.toolStripContainer3.Location = new System.Drawing.Point(10, 10);
			this.toolStripContainer3.Name = "toolStripContainer3";
			this.toolStripContainer3.RightToolStripPanelVisible = false;
			this.toolStripContainer3.Size = new System.Drawing.Size(544, 345);
			this.toolStripContainer3.TabIndex = 15;
			this.toolStripContainer3.Text = "toolStripContainer3";
			// 
			// toolStripContainer3.TopToolStripPanel
			// 
			this.toolStripContainer3.TopToolStripPanel.Controls.Add(menuStrip1);
			// 
			// _lastPlayedDateTimePicker
			// 
			this._lastPlayedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._lastPlayedDateTimePicker.CausesValidation = false;
			this._lastPlayedDateTimePicker.Checked = false;
			this._lastPlayedDateTimePicker.Enabled = false;
			this._lastPlayedDateTimePicker.Location = new System.Drawing.Point(390, 110);
			this._lastPlayedDateTimePicker.Name = "_lastPlayedDateTimePicker";
			this._lastPlayedDateTimePicker.Size = new System.Drawing.Size(151, 20);
			this._lastPlayedDateTimePicker.TabIndex = 16;
			// 
			// _purchasedDateTimePicker
			// 
			this._purchasedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._purchasedDateTimePicker.CausesValidation = false;
			this._purchasedDateTimePicker.Enabled = false;
			this._purchasedDateTimePicker.Location = new System.Drawing.Point(390, 84);
			this._purchasedDateTimePicker.Name = "_purchasedDateTimePicker";
			this._purchasedDateTimePicker.Size = new System.Drawing.Size(151, 20);
			this._purchasedDateTimePicker.TabIndex = 16;
			// 
			// _playsTextBox
			// 
			this._playsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._playsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._playsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._playsTextBox.Location = new System.Drawing.Point(477, 57);
			this._playsTextBox.Name = "_playsTextBox";
			this._playsTextBox.ReadOnly = true;
			this._playsTextBox.Size = new System.Drawing.Size(64, 13);
			this._playsTextBox.TabIndex = 15;
			// 
			// _costTextBox
			// 
			this._costTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._costTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._costTextBox.Location = new System.Drawing.Point(349, 57);
			this._costTextBox.Name = "_costTextBox";
			this._costTextBox.ReadOnly = true;
			this._costTextBox.Size = new System.Drawing.Size(75, 13);
			this._costTextBox.TabIndex = 15;
			// 
			// _nameTextBox
			// 
			this._nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._nameTextBox.Location = new System.Drawing.Point(359, 21);
			this._nameTextBox.Name = "_nameTextBox";
			this._nameTextBox.ReadOnly = true;
			this._nameTextBox.Size = new System.Drawing.Size(185, 25);
			this._nameTextBox.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(307, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Name:";
			// 
			// _addPlayButton
			// 
			this._addPlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._addPlayButton.Location = new System.Drawing.Point(466, 286);
			this._addPlayButton.Name = "_addPlayButton";
			this._addPlayButton.Size = new System.Drawing.Size(75, 23);
			this._addPlayButton.TabIndex = 12;
			this._addPlayButton.Text = "Add Play";
			this._addPlayButton.UseVisualStyleBackColor = true;
			this._addPlayButton.Click += new System.EventHandler(this._addPlayButton_Click);
			// 
			// _newGameButton
			// 
			this._newGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._newGameButton.Location = new System.Drawing.Point(145, 286);
			this._newGameButton.Name = "_newGameButton";
			this._newGameButton.Size = new System.Drawing.Size(75, 23);
			this._newGameButton.TabIndex = 11;
			this._newGameButton.Text = "Add";
			this._newGameButton.UseVisualStyleBackColor = true;
			this._newGameButton.Click += new System.EventHandler(this._newGameButton_Click);
			// 
			// _deleteButton
			// 
			this._deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._deleteButton.Location = new System.Drawing.Point(226, 286);
			this._deleteButton.Name = "_deleteButton";
			this._deleteButton.Size = new System.Drawing.Size(75, 23);
			this._deleteButton.TabIndex = 10;
			this._deleteButton.Text = "Delete";
			this._deleteButton.UseVisualStyleBackColor = true;
			this._deleteButton.Click += new System.EventHandler(this._deleteGameButton_Click);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(307, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Last Played:";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(430, 57);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Plays:";
			// 
			// _saveFileDialog
			// 
			this._saveFileDialog.Filter = "Xml files (*.xml)|*.xml";
			// 
			// _openFileDialog
			// 
			this._openFileDialog.FileName = "openFileDialog1";
			// 
			// GameManagerDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 365);
			this.Controls.Add(this.toolStripContainer3);
			this.MainMenuStrip = menuStrip1;
			this.MinimumSize = new System.Drawing.Size(500, 276);
			this.Name = "GameManagerDialog";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage Your Collection";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameManagerDialog_FormClosing);
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			this.toolStripContainer3.ContentPanel.ResumeLayout(false);
			this.toolStripContainer3.ContentPanel.PerformLayout();
			this.toolStripContainer3.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer3.TopToolStripPanel.PerformLayout();
			this.toolStripContainer3.ResumeLayout(false);
			this.toolStripContainer3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox _gameListBox;
        private System.Windows.Forms.TextBox _noteTextBox;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.SaveFileDialog _saveFileDialog;
		private System.Windows.Forms.OpenFileDialog _openFileDialog;
		private System.Windows.Forms.Button _newGameButton;
		private System.Windows.Forms.Button _deleteButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button _addPlayButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox _nameTextBox;
		private System.Windows.Forms.TextBox _playsTextBox;
		private System.Windows.Forms.TextBox _costTextBox;
		private System.Windows.Forms.DateTimePicker _purchasedDateTimePicker;
		private System.Windows.Forms.DateTimePicker _lastPlayedDateTimePicker;
    }
}