namespace BoardGameLibrary
{
    partial class GameEditorDialog
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
			this._nameTextBox = new System.Windows.Forms.TextBox();
			this._noteTextBox = new System.Windows.Forms.TextBox();
			this._playsUpDown = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this._costTextBox = new System.Windows.Forms.TextBox();
			this._purchasedDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this._lastPlayedDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.MainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._playsUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add(this._lastPlayedDateTimePicker);
			this.MainPanel.Controls.Add(this._purchasedDateTimePicker);
			this.MainPanel.Controls.Add(this.label4);
			this.MainPanel.Controls.Add(this.label5);
			this.MainPanel.Controls.Add(this.label6);
			this.MainPanel.Controls.Add(this.label7);
			this.MainPanel.Controls.Add(this.label8);
			this.MainPanel.Controls.Add(this.label9);
			this.MainPanel.Controls.Add(this._playsUpDown);
			this.MainPanel.Controls.Add(this._noteTextBox);
			this.MainPanel.Controls.Add(this._costTextBox);
			this.MainPanel.Controls.Add(this._nameTextBox);
			this.MainPanel.Size = new System.Drawing.Size(306, 269);
			// 
			// _nameTextBox
			// 
			this._nameTextBox.Location = new System.Drawing.Point(94, 12);
			this._nameTextBox.Name = "_nameTextBox";
			this._nameTextBox.Size = new System.Drawing.Size(200, 20);
			this._nameTextBox.TabIndex = 0;
			// 
			// _noteTextBox
			// 
			this._noteTextBox.AcceptsReturn = true;
			this._noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._noteTextBox.Location = new System.Drawing.Point(94, 116);
			this._noteTextBox.Multiline = true;
			this._noteTextBox.Name = "_noteTextBox";
			this._noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._noteTextBox.Size = new System.Drawing.Size(200, 147);
			this._noteTextBox.TabIndex = 5;
			// 
			// _playsUpDown
			// 
			this._playsUpDown.Location = new System.Drawing.Point(240, 38);
			this._playsUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this._playsUpDown.Name = "_playsUpDown";
			this._playsUpDown.Size = new System.Drawing.Size(54, 20);
			this._playsUpDown.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(45, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 19;
			this.label4.Text = "Name:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(50, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Note:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(11, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Last Played:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(17, 67);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Purchased:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(193, 41);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 13);
			this.label8.TabIndex = 17;
			this.label8.Text = "Plays:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(52, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(36, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "Cost:";
			// 
			// _costTextBox
			// 
			this._costTextBox.Location = new System.Drawing.Point(94, 38);
			this._costTextBox.Name = "_costTextBox";
			this._costTextBox.Size = new System.Drawing.Size(80, 20);
			this._costTextBox.TabIndex = 1;
			// 
			// _purchasedDateTimePicker
			// 
			this._purchasedDateTimePicker.Location = new System.Drawing.Point(94, 64);
			this._purchasedDateTimePicker.Name = "_purchasedDateTimePicker";
			this._purchasedDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this._purchasedDateTimePicker.TabIndex = 3;
			// 
			// _lastPlayedDateTimePicker
			// 
			this._lastPlayedDateTimePicker.Location = new System.Drawing.Point(94, 90);
			this._lastPlayedDateTimePicker.Name = "_lastPlayedDateTimePicker";
			this._lastPlayedDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this._lastPlayedDateTimePicker.TabIndex = 4;
			// 
			// GameEditorDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BottomButtons = BoardGameLibrary.BaseDialogs.OkApplyCancelDialog.DialogButtons.OkCancel;
			this.ClientSize = new System.Drawing.Size(306, 301);
			this.Name = "GameEditorDialog";
			this.Text = "Game Editor";
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._playsUpDown)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.TextBox _noteTextBox;
        private System.Windows.Forms.NumericUpDown _playsUpDown;
		private System.Windows.Forms.DateTimePicker _lastPlayedDateTimePicker;
		private System.Windows.Forms.DateTimePicker _purchasedDateTimePicker;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox _costTextBox;

    }
}