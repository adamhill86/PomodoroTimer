namespace PomodoroTimer
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
            this.components = new System.ComponentModel.Container();
            this.startBtn = new System.Windows.Forms.Button();
            this.pomodoro = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.startBtn.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(220, 310);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(200, 100);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.Button_Click);
            // 
            // pomodoro
            // 
            this.pomodoro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pomodoro.Font = new System.Drawing.Font("Roboto", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomodoro.Location = new System.Drawing.Point(0, 0);
            this.pomodoro.Name = "pomodoro";
            this.pomodoro.Size = new System.Drawing.Size(622, 143);
            this.pomodoro.TabIndex = 1;
            this.pomodoro.Text = "Pomodoro";
            this.pomodoro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Roboto", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(120, 143);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(400, 140);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "25";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.pomodoro);
            this.Controls.Add(this.startBtn);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "Pomodoro Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label pomodoro;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

