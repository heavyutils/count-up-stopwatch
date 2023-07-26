
namespace count_up
{
    partial class Window
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
            this.time = new System.Windows.Forms.Label();
            this.startstop = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.timeupdate = new System.Windows.Forms.Timer(this.components);
            this.overflow = new System.Windows.Forms.Label();
            this.snaptimer = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.controlcooldown = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailedONQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.time.ContextMenuStrip = this.contextMenuStrip;
            this.time.Font = new System.Drawing.Font("Consolas", 46F);
            this.time.Location = new System.Drawing.Point(0, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(400, 85);
            this.time.TabIndex = 1;
            this.time.Text = "00:00.00";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time.UseMnemonic = false;
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // startstop
            // 
            this.startstop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startstop.Enabled = false;
            this.startstop.Location = new System.Drawing.Point(12, 88);
            this.startstop.Name = "startstop";
            this.startstop.Size = new System.Drawing.Size(180, 25);
            this.startstop.TabIndex = 0;
            this.startstop.Text = "START";
            this.startstop.UseVisualStyleBackColor = true;
            this.startstop.Visible = false;
            this.startstop.Click += new System.EventHandler(this.startstop_Click);
            // 
            // reset
            // 
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(208, 88);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(180, 25);
            this.reset.TabIndex = 2;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Visible = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // timeupdate
            // 
            this.timeupdate.Interval = 30;
            this.timeupdate.Tick += new System.EventHandler(this.timeupdate_Tick);
            // 
            // overflow
            // 
            this.overflow.BackColor = System.Drawing.Color.Maroon;
            this.overflow.Font = new System.Drawing.Font("Consolas", 7F);
            this.overflow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.overflow.Location = new System.Drawing.Point(0, 0);
            this.overflow.Name = "overflow";
            this.overflow.Size = new System.Drawing.Size(400, 15);
            this.overflow.TabIndex = 3;
            this.overflow.Text = "Overflows: 00";
            this.overflow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.overflow.Visible = false;
            // 
            // snaptimer
            // 
            this.snaptimer.Interval = 125;
            this.snaptimer.Tick += new System.EventHandler(this.snaptimer_Tick);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // controlcooldown
            // 
            this.controlcooldown.Interval = 300;
            this.controlcooldown.Tick += new System.EventHandler(this.controlcooldown_Tick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.detailedONQToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.startInToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(211, 156);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.startToolStripMenuItem.Text = "Start (Space, E)";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.resetToolStripMenuItem.Text = "Reset (R)";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // detailedONQToolStripMenuItem
            // 
            this.detailedONQToolStripMenuItem.Name = "detailedONQToolStripMenuItem";
            this.detailedONQToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.detailedONQToolStripMenuItem.Text = "Detailed ON (Q)";
            this.detailedONQToolStripMenuItem.Click += new System.EventHandler(this.detailedONQToolStripMenuItem_Click);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topLeftToolStripMenuItem,
            this.topToolStripMenuItem,
            this.topRightToolStripMenuItem,
            this.bottomLeftToolStripMenuItem,
            this.bottomToolStripMenuItem,
            this.bottomRightToolStripMenuItem});
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.positionToolStripMenuItem.Text = "Position";
            // 
            // topLeftToolStripMenuItem
            // 
            this.topLeftToolStripMenuItem.Name = "topLeftToolStripMenuItem";
            this.topLeftToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.topLeftToolStripMenuItem.Text = "Top-Left (W+A)";
            this.topLeftToolStripMenuItem.Click += new System.EventHandler(this.topLeftToolStripMenuItem_Click);
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.topToolStripMenuItem.Text = "Top (W)";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.topToolStripMenuItem_Click);
            // 
            // topRightToolStripMenuItem
            // 
            this.topRightToolStripMenuItem.Name = "topRightToolStripMenuItem";
            this.topRightToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.topRightToolStripMenuItem.Text = "Top-Right (W+D)";
            this.topRightToolStripMenuItem.Click += new System.EventHandler(this.topRightToolStripMenuItem_Click);
            // 
            // bottomLeftToolStripMenuItem
            // 
            this.bottomLeftToolStripMenuItem.Name = "bottomLeftToolStripMenuItem";
            this.bottomLeftToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.bottomLeftToolStripMenuItem.Text = "Bottom-Left (S+A)";
            this.bottomLeftToolStripMenuItem.Click += new System.EventHandler(this.bottomLeftToolStripMenuItem_Click);
            // 
            // bottomToolStripMenuItem
            // 
            this.bottomToolStripMenuItem.Name = "bottomToolStripMenuItem";
            this.bottomToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.bottomToolStripMenuItem.Text = "Bottom (S)";
            this.bottomToolStripMenuItem.Click += new System.EventHandler(this.bottomToolStripMenuItem_Click);
            // 
            // bottomRightToolStripMenuItem
            // 
            this.bottomRightToolStripMenuItem.Name = "bottomRightToolStripMenuItem";
            this.bottomRightToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.bottomRightToolStripMenuItem.Text = "Bottom-Right (S+D)";
            this.bottomRightToolStripMenuItem.Click += new System.EventHandler(this.bottomRightToolStripMenuItem_Click);
            // 
            // startInToolStripMenuItem
            // 
            this.startInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem1,
            this.sToolStripMenuItem2,
            this.sToolStripMenuItem3,
            this.sToolStripMenuItem4,
            this.sToolStripMenuItem5,
            this.sToolStripMenuItem6,
            this.sToolStripMenuItem7,
            this.sToolStripMenuItem8,
            this.sToolStripMenuItem9});
            this.startInToolStripMenuItem.Name = "startInToolStripMenuItem";
            this.startInToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.startInToolStripMenuItem.Text = "Start in...";
            // 
            // sToolStripMenuItem1
            // 
            this.sToolStripMenuItem1.Name = "sToolStripMenuItem1";
            this.sToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.sToolStripMenuItem1.Text = "1S";
            this.sToolStripMenuItem1.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem2
            // 
            this.sToolStripMenuItem2.Name = "sToolStripMenuItem2";
            this.sToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.sToolStripMenuItem2.Text = "2S";
            this.sToolStripMenuItem2.Click += new System.EventHandler(this.sToolStripMenuItem2_Click);
            // 
            // sToolStripMenuItem3
            // 
            this.sToolStripMenuItem3.Name = "sToolStripMenuItem3";
            this.sToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.sToolStripMenuItem3.Text = "3S";
            this.sToolStripMenuItem3.Click += new System.EventHandler(this.sToolStripMenuItem3_Click);
            // 
            // sToolStripMenuItem4
            // 
            this.sToolStripMenuItem4.Name = "sToolStripMenuItem4";
            this.sToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.sToolStripMenuItem4.Text = "4S";
            this.sToolStripMenuItem4.Click += new System.EventHandler(this.sToolStripMenuItem4_Click);
            // 
            // sToolStripMenuItem5
            // 
            this.sToolStripMenuItem5.Name = "sToolStripMenuItem5";
            this.sToolStripMenuItem5.Size = new System.Drawing.Size(224, 26);
            this.sToolStripMenuItem5.Text = "5S";
            this.sToolStripMenuItem5.Click += new System.EventHandler(this.sToolStripMenuItem5_Click);
            // 
            // sToolStripMenuItem6
            // 
            this.sToolStripMenuItem6.Name = "sToolStripMenuItem6";
            this.sToolStripMenuItem6.Size = new System.Drawing.Size(224, 26);
            this.sToolStripMenuItem6.Text = "6S";
            this.sToolStripMenuItem6.Click += new System.EventHandler(this.sToolStripMenuItem6_Click);
            // 
            // sToolStripMenuItem7
            // 
            this.sToolStripMenuItem7.Name = "sToolStripMenuItem7";
            this.sToolStripMenuItem7.Size = new System.Drawing.Size(224, 26);
            this.sToolStripMenuItem7.Text = "7S";
            this.sToolStripMenuItem7.Click += new System.EventHandler(this.sToolStripMenuItem7_Click);
            // 
            // sToolStripMenuItem8
            // 
            this.sToolStripMenuItem8.Name = "sToolStripMenuItem8";
            this.sToolStripMenuItem8.Size = new System.Drawing.Size(224, 26);
            this.sToolStripMenuItem8.Text = "8S";
            this.sToolStripMenuItem8.Click += new System.EventHandler(this.sToolStripMenuItem8_Click);
            // 
            // sToolStripMenuItem9
            // 
            this.sToolStripMenuItem9.Name = "sToolStripMenuItem9";
            this.sToolStripMenuItem9.Size = new System.Drawing.Size(224, 26);
            this.sToolStripMenuItem9.Text = "9S";
            this.sToolStripMenuItem9.Click += new System.EventHandler(this.sToolStripMenuItem9_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 85);
            this.Controls.Add(this.overflow);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.startstop);
            this.Controls.Add(this.time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Window";
            this.ShowIcon = false;
            this.Text = "Count-Up";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Window_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button startstop;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Timer timeupdate;
        private System.Windows.Forms.Label overflow;
        private System.Windows.Forms.Timer snaptimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer controlcooldown;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailedONQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem9;
    }
}

