
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
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.Text = "Countup";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Window_Load);
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
    }
}

