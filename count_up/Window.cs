using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;

namespace count_up
{
    public partial class Window : Form
    {
        // Main timer
        readonly Stopwatch tick = new Stopwatch();

        // Snapping technology
        int keyPressed = 0;
        bool pressedW = false;
        bool pressedA = false;
        bool pressedS = false;
        bool pressedD = false;

        // State saving for detailed mode switch
        int hours = 0;
        int minutes = 0;
        int seconds = 0;
        int fractions = 0;

        bool nondetailedrequired = false;
        bool detailed = true;
        bool dragging = false;
        int overflows;
        readonly CultureInfo culture = CultureInfo.CurrentCulture;
        enum CultureWeirdnessEnum
        {
            NormalOrIrrelevant,
            Weird,
            VeryWeird
        }
        CultureWeirdnessEnum cultureWeirdness = CultureWeirdnessEnum.NormalOrIrrelevant;

        int timetimer = 0;

        // Dragging technology
        Point dragCursorPoint;
        Point dragFormPoint;

        public Window()
        {
            InitializeComponent();
        }

        private void drag_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void drag_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Window_Load(object sender, EventArgs e)
        {
            if (culture.NumberFormat.NumberDecimalSeparator == "," && culture.DateTimeFormat.TimeSeparator != ".")
            {
                cultureWeirdness = CultureWeirdnessEnum.Weird;
                time.Text = "00:00,00";
            }
            else if (culture.NumberFormat.NumberDecimalSeparator == "," && culture.DateTimeFormat.TimeSeparator == ".")
            {
                cultureWeirdness = CultureWeirdnessEnum.VeryWeird;
                time.Text = "00.00,00";
            }
            KeyUp += new KeyEventHandler(KeyPress);
            time.MouseDown += new MouseEventHandler(drag_MouseDown);
            time.MouseMove += new MouseEventHandler(drag_MouseMove);
            time.MouseUp += new MouseEventHandler(drag_MouseUp);
        }

        private new void KeyPress(object sender, KeyEventArgs e)
        {
            if (!controlcooldown.Enabled)
            {
                if (e.KeyCode == Keys.R)
                {
                    controlcooldown.Enabled = true;
                    reset_Click(null, null);
                    if (timer.Enabled)
                    {
                        timer.Enabled = false;
                        timetimer = 0;
                        overflow.Text = "Overflows: 00";
                        overflow.Visible = false;
                    }
                }
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.E)
                {
                    controlcooldown.Enabled = true;
                    startstop_Click(null, null);
                    if (timer.Enabled)
                    {
                        timer.Enabled = false;
                        timetimer = 0;
                        overflow.Text = "Overflows: 00";
                        overflow.Visible = false;
                    }
                }
                if (e.KeyCode == Keys.Q && !nondetailedrequired)
                {
                    controlcooldown.Enabled = true;
                    if (detailed)
                    {
                        detailed = false;
                        string elapsed = String.Empty;
                        if (cultureWeirdness == CultureWeirdnessEnum.NormalOrIrrelevant || cultureWeirdness == CultureWeirdnessEnum.Weird)
                        {
                            elapsed = String.Format("{0:00}:{1:00}:{2:00}",
                            hours, minutes, seconds);
                        }
                        else if (cultureWeirdness == CultureWeirdnessEnum.VeryWeird)
                        {
                            elapsed = String.Format("{0:00}.{1:00}.{2:00}",
                            hours, minutes, seconds);
                        }
                        time.Text = elapsed;
                    }
                    else if (!detailed)
                    {
                        detailed = true;
                        string elapsed = String.Empty;
                        if (cultureWeirdness == CultureWeirdnessEnum.NormalOrIrrelevant)
                        {
                            elapsed = String.Format("{0:00}:{1:00}.{2:00}",
                            minutes, seconds, fractions);
                        }
                        else if (cultureWeirdness == CultureWeirdnessEnum.Weird)
                        {
                            elapsed = String.Format("{0:00}:{1:00},{2:00}",
                            minutes, seconds, fractions);
                        }
                        else if (cultureWeirdness == CultureWeirdnessEnum.VeryWeird)
                        {
                            elapsed = String.Format("{0:00}.{1:00},{2:00}",
                            minutes, seconds, fractions);
                        }
                        time.Text = elapsed;
                    }
                }
                if (e.KeyCode == Keys.D0 && !timer.Enabled && !timeupdate.Enabled && overflows == 0)
                {
                    controlcooldown.Enabled = true;
                    startstop_Click(null, null);
                }
                if (e.KeyCode == Keys.D1 && !timer.Enabled && !timeupdate.Enabled && overflows == 0)
                {
                    controlcooldown.Enabled = true;
                    timer.Enabled = true;
                    timetimer = 1;
                    overflow.Visible = true;
                    overflow.Text = "Starting in 1";
                }
                if (e.KeyCode == Keys.D2 && !timer.Enabled && !timeupdate.Enabled && overflows == 0)
                {
                    controlcooldown.Enabled = true;
                    timer.Enabled = true;
                    timetimer = 2;
                    overflow.Visible = true;
                    overflow.Text = "Starting in 2";
                }
                if (e.KeyCode == Keys.D3 && !timer.Enabled && !timeupdate.Enabled && overflows == 0)
                {
                    controlcooldown.Enabled = true;
                    timer.Enabled = true;
                    timetimer = 3;
                    overflow.Visible = true;
                    overflow.Text = "Starting in 3";
                }
                if (e.KeyCode == Keys.D4 && !timer.Enabled && !timeupdate.Enabled && overflows == 0)
                {
                    controlcooldown.Enabled = true;
                    timer.Enabled = true;
                    timetimer = 4;
                    overflow.Visible = true;
                    overflow.Text = "Starting in 4";
                }
                if (e.KeyCode == Keys.D5 && !timer.Enabled && !timeupdate.Enabled && overflows == 0)
                {
                    controlcooldown.Enabled = true;
                    timer.Enabled = true;
                    timetimer = 5;
                    overflow.Visible = true;
                    overflow.Text = "Starting in 5";
                }
                if (e.KeyCode == Keys.D6 && !timer.Enabled && !timeupdate.Enabled && overflows == 0)
                {
                    controlcooldown.Enabled = true;
                    timer.Enabled = true;
                    timetimer = 6;
                    overflow.Visible = true;
                    overflow.Text = "Starting in 6";
                }
                if (e.KeyCode == Keys.D7 && !timer.Enabled && !timeupdate.Enabled && overflows == 0)
                {
                    controlcooldown.Enabled = true;
                    timer.Enabled = true;
                    timetimer = 7;
                    overflow.Visible = true;
                    overflow.Text = "Starting in 7";
                }
                if (e.KeyCode == Keys.D8 && !timer.Enabled && !timeupdate.Enabled && overflows == 0)
                {
                    controlcooldown.Enabled = true;
                    timer.Enabled = true;
                    timetimer = 8;
                    overflow.Visible = true;
                    overflow.Text = "Starting in 8";
                }
                if (e.KeyCode == Keys.D9 && !timer.Enabled && !timeupdate.Enabled && overflows == 0)
                {
                    controlcooldown.Enabled = true;
                    timer.Enabled = true;
                    timetimer = 9;
                    overflow.Visible = true;
                    overflow.Text = "Starting in 9";
                }
                if (e.KeyCode == Keys.W)
                {
                    if (keyPressed <= 1)
                    {
                        pressedW = true;
                        keyPressed += 1;
                        if (!snaptimer.Enabled)
                        {
                            snaptimer.Enabled = true;
                        }
                    }
                }
                if (e.KeyCode == Keys.A)
                {
                    if (keyPressed <= 1)
                    {
                        pressedA = true;
                        keyPressed += 1;
                        if (!snaptimer.Enabled)
                        {
                            snaptimer.Enabled = true;
                        }
                    }
                }
                if (e.KeyCode == Keys.S)
                {
                    if (keyPressed <= 1)
                    {
                        pressedS = true;
                        keyPressed += 1;
                        if (!snaptimer.Enabled)
                        {
                            snaptimer.Enabled = true;
                        }
                    }
                }
                if (e.KeyCode == Keys.D)
                {
                    if (keyPressed <= 1)
                    {
                        pressedD = true;
                        keyPressed += 1;
                        if (!snaptimer.Enabled)
                        {
                            snaptimer.Enabled = true;
                        }
                    }
                }
            }     
        }

        private void time_Click(object sender, EventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void timeupdate_Tick(object sender, EventArgs e)
        {
            if (tick.Elapsed.Hours == 100)
            {
                overflow.Visible = true;
                overflows += 1;
                if (overflows <= 9)
                {
                    overflow.Text = "Overflows: 0" + overflows;
                }
                else if (overflows <= 99)
                {
                    overflow.Text = "Overflows: " + overflows;
                }
                else if (overflows == 100)
                {
                    reset_Click(null, null);
                }
                if (detailed == false)
                {
                    detailed = true;
                }
                reset.Enabled = false;
                if (cultureWeirdness == CultureWeirdnessEnum.NormalOrIrrelevant)
                {
                    time.Text = "00:00.00";
                }
                else if (cultureWeirdness == CultureWeirdnessEnum.Weird)
                {
                    time.Text = "00:00,00";
                }
                else if (cultureWeirdness == CultureWeirdnessEnum.VeryWeird)
                {
                    time.Text = "00.00,00";
                }
                tick.Reset();
            }
            hours = tick.Elapsed.Hours;
            minutes = tick.Elapsed.Minutes;
            seconds = tick.Elapsed.Seconds;
            fractions = tick.Elapsed.Milliseconds / 10;
            if (String.Format("{0:00}:{1:00}:{2:00}",
            hours, minutes, seconds) == "01:00:00")
            {
                if (detailed)
                {
                    detailed = false;
                }
                nondetailedrequired = true;
            }
            if (detailed)
            {
                string elapsed = String.Empty;
                if (cultureWeirdness == CultureWeirdnessEnum.NormalOrIrrelevant)
                {
                    elapsed = String.Format("{0:00}:{1:00}.{2:00}",
                    minutes, seconds,
                    fractions);
                }               
                else if (cultureWeirdness == CultureWeirdnessEnum.Weird)
                {
                    elapsed = String.Format("{0:00}:{1:00},{2:00}",
                    minutes, seconds,
                    fractions);
                }
                else if (cultureWeirdness == CultureWeirdnessEnum.VeryWeird)
                {
                    elapsed = String.Format("{0:00}.{1:00},{2:00}",
                    minutes, seconds,
                    fractions);
                }
                time.Text = elapsed;
            }
            else
            {
                string elapsed = String.Empty;
                if (cultureWeirdness == CultureWeirdnessEnum.NormalOrIrrelevant || cultureWeirdness == CultureWeirdnessEnum.Weird)
                {
                    elapsed = String.Format("{0:00}:{1:00}:{2:00}",
                    hours, minutes, seconds);
                }
                else if (cultureWeirdness == CultureWeirdnessEnum.VeryWeird)
                {
                    elapsed = String.Format("{0:00}.{1:00}.{2:00}",
                    hours, minutes, seconds);
                }
                time.Text = elapsed;
            }
        }

        private void startstop_Click(object sender, EventArgs e)
        {
            if (startstop.Text == "START")
            {
                if (reset.Enabled)
                {
                    reset.Enabled = false;
                }
                timeupdate.Enabled = true;
                time.ForeColor = Color.DarkGreen;
                tick.Start();
                startstop.Text = "STOP";
            }
            else
            {
                reset.Enabled = true;
                timeupdate.Enabled = false;
                time.ForeColor = SystemColors.ControlText;
                tick.Stop();
                startstop.Text = "START";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            if (overflows >= 1)
            {
                overflows = 0;
                overflow.Text = "Overflows: 00";
                overflow.Visible = false;
            }
            if (detailed == false)
            {
                detailed = true;
            }
            reset.Enabled = false;
            if (cultureWeirdness == CultureWeirdnessEnum.NormalOrIrrelevant)
            {
                time.Text = "00:00.00";
            }
            else if (cultureWeirdness == CultureWeirdnessEnum.Weird)
            {
                time.Text = "00:00,00";
            }
            else if (cultureWeirdness == CultureWeirdnessEnum.VeryWeird)
            {
                time.Text = "00.00,00";
            }
            if (startstop.Text == "STOP")
            {
                timeupdate.Enabled = false;
                startstop.Text = "START";
            }
            hours = 0;
            minutes = 0;
            seconds = 0;
            fractions = 0;
            time.ForeColor = SystemColors.ControlText;
            tick.Reset();
        }

        private void snaptimer_Tick(object sender, EventArgs e)
        {
            snaptimer.Enabled = false;
            keyPressed = 0;
            if (pressedW && pressedA)
            {
                Opacity = 0;
                Left = 0;
                Top = 0;
                Opacity = 1;
            }
            if (pressedA && pressedS)
            {
                Opacity = 0;
                Left = 0;
                Top = Screen.PrimaryScreen.Bounds.Height - 85;
                Opacity = 1;
            }
            if (pressedS && pressedD)
            {
                Opacity = 0;
                Left = Screen.PrimaryScreen.Bounds.Width - 400;
                Top = Screen.PrimaryScreen.Bounds.Height - 85;
                Opacity = 1;
            }
            if (pressedD && pressedW)
            {
                Opacity = 0;
                Left = Screen.PrimaryScreen.Bounds.Width - 400;
                Top = 0;
                Opacity = 1;
            }
            if (pressedW && !pressedA && !pressedS && !pressedD)
            {
                Opacity = 0;
                Left = Screen.PrimaryScreen.Bounds.Width / 2 - 200;
                Top = 0;
                Opacity = 1;
            }
            if (!pressedW && !pressedA && pressedS && !pressedD)
            {
                Opacity = 0;
                Left = Screen.PrimaryScreen.Bounds.Width / 2 - 200;
                Top = Screen.PrimaryScreen.Bounds.Height - 85;
                Opacity = 1;
            }
            if (pressedW)
            {
                pressedW = false;
            }
            if (pressedA)
            {
                pressedA = false;
            }
            if (pressedS)
            {
                pressedS = false;
            }
            if (pressedD)
            {
                pressedD = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timetimer >= 2)
            {
                timetimer -= 1;
                overflow.Text = "Starting in " + Convert.ToString(timetimer);
            }
            else if (timetimer == 1)
            {
                controlcooldown.Enabled = true;
                timer.Enabled = false;
                overflow.Text = "Overflows: 00";
                overflow.Visible = false;
                startstop_Click(null, null);
            }
        }

        private void controlcooldown_Tick(object sender, EventArgs e)
        {
            controlcooldown.Enabled = false;
        }
    }
}
