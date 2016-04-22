namespace NavBarDemo
{
    partial class Form1
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
            this.navBarContainer1 = new NavBarDemo.NavBarContainer();
            this.SuspendLayout();
            // 
            // navBarContainer1
            // 
            this.navBarContainer1.AutoScroll = true;
            this.navBarContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(140)))), ((int)(((byte)(225)))));
            this.navBarContainer1.BarMargin = 0;
            this.navBarContainer1.BarSpace = 0;
            this.navBarContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.navBarContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarContainer1.Location = new System.Drawing.Point(0, 0);
            this.navBarContainer1.Name = "navBarContainer1";
            this.navBarContainer1.SelectedIndex = -1;
            this.navBarContainer1.Size = new System.Drawing.Size(191, 308);
            this.navBarContainer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 308);
            this.Controls.Add(this.navBarContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private NavBarContainer navBarContainer1;

    }
}

