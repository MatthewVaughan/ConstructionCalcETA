namespace Project03
{
    partial class frmMain
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
            this.oldStart = new System.Windows.Forms.Label();
            this.oldEnd = new System.Windows.Forms.Label();
            this.newEnd = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtOldEnd = new System.Windows.Forms.TextBox();
            this.txtNewEnd = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oldStart
            // 
            this.oldStart.AutoSize = true;
            this.oldStart.Location = new System.Drawing.Point(66, 89);
            this.oldStart.Name = "oldStart";
            this.oldStart.Size = new System.Drawing.Size(208, 17);
            this.oldStart.TabIndex = 0;
            this.oldStart.Text = "Enter Start Time (Military Time):";
            // 
            // oldEnd
            // 
            this.oldEnd.AutoSize = true;
            this.oldEnd.Location = new System.Drawing.Point(66, 128);
            this.oldEnd.Name = "oldEnd";
            this.oldEnd.Size = new System.Drawing.Size(229, 17);
            this.oldEnd.TabIndex = 1;
            this.oldEnd.Text = "Enter Old End Time (Military Time):";
            // 
            // newEnd
            // 
            this.newEnd.AutoSize = true;
            this.newEnd.Location = new System.Drawing.Point(69, 220);
            this.newEnd.Name = "newEnd";
            this.newEnd.Size = new System.Drawing.Size(118, 17);
            this.newEnd.TabIndex = 2;
            this.newEnd.Text = "New Arrival Time:";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(69, 174);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(118, 25);
            this.btn.TabIndex = 3;
            this.btn.Text = "Calculate";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(305, 89);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 22);
            this.txtStart.TabIndex = 4;
            // 
            // txtOldEnd
            // 
            this.txtOldEnd.Location = new System.Drawing.Point(305, 128);
            this.txtOldEnd.Name = "txtOldEnd";
            this.txtOldEnd.Size = new System.Drawing.Size(100, 22);
            this.txtOldEnd.TabIndex = 5;
            // 
            // txtNewEnd
            // 
            this.txtNewEnd.Location = new System.Drawing.Point(305, 220);
            this.txtNewEnd.Name = "txtNewEnd";
            this.txtNewEnd.Size = new System.Drawing.Size(100, 22);
            this.txtNewEnd.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 413);
            this.Controls.Add(this.txtNewEnd);
            this.Controls.Add(this.txtOldEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.newEnd);
            this.Controls.Add(this.oldEnd);
            this.Controls.Add(this.oldStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Arrival Time Calc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldStart;
        private System.Windows.Forms.Label oldEnd;
        private System.Windows.Forms.Label newEnd;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtOldEnd;
        private System.Windows.Forms.TextBox txtNewEnd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

