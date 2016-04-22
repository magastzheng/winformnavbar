namespace NavBarDemo
{
    partial class NavBarItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._button = new System.Windows.Forms.Button();
            this._treeView = new System.Windows.Forms.TreeView();
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _button
            // 
            this._button.Dock = System.Windows.Forms.DockStyle.Top;
            this._button.Location = new System.Drawing.Point(0, 0);
            this._button.Name = "_button";
            this._button.Size = new System.Drawing.Size(234, 29);
            this._button.TabIndex = 0;
            this._button.UseVisualStyleBackColor = true;
            // 
            // _treeView
            // 
            this._treeView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._treeView.Location = new System.Drawing.Point(0, 26);
            this._treeView.Name = "_treeView";
            this._treeView.Size = new System.Drawing.Size(234, 111);
            this._treeView.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this._button);
            this.panel.Controls.Add(this._treeView);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(234, 137);
            this.panel.TabIndex = 2;
            // 
            // NavBarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "NavBarItem";
            this.Size = new System.Drawing.Size(234, 137);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button button;
        //private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel panel;
    }
}
