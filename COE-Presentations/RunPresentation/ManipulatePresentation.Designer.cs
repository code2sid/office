﻿namespace ManipulatePresentation
{
    partial class ManipulatePresentation
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
            this.components = new System.ComponentModel.Container();
            this.presenationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // presenationTimer
            // 
            this.presenationTimer.Enabled = true;
            this.presenationTimer.Interval = 5000;
            this.presenationTimer.Tick += new System.EventHandler(this.presenationTimer_Tick);
            // 
            // ManipulatePresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "ManipulatePresentation";
            this.Text = "ManipulatePresentation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer presenationTimer;
    }
}
