using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameLibrary.BaseDialogs
{
    partial class OkApplyCancelDialog
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
            this._bottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _bottomPanel
            // 
            this._bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._bottomPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this._bottomPanel.Location = new System.Drawing.Point(0, 201);
            this._bottomPanel.Name = "_bottomPanel";
            this._bottomPanel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._bottomPanel.Size = new System.Drawing.Size(284, 32);
            this._bottomPanel.TabIndex = 0;
            this._bottomPanel.WrapContents = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(284, 201);
            this.MainPanel.TabIndex = 1;
            // 
            // OkApplyCancelDialog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this._bottomPanel);
            this.Name = "OkApplyCancelDialog2";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.FlowLayoutPanel _bottomPanel;



    }
}
