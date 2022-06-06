namespace IntervalTimer
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
            this.countsBox = new System.Windows.Forms.ListBox();
            this.tempTime = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.resetAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.add10 = new System.Windows.Forms.Button();
            this.add30 = new System.Windows.Forms.Button();
            this.add60 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countsBox
            // 
            this.countsBox.BackColor = System.Drawing.SystemColors.Control;
            this.countsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countsBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.countsBox.FormattingEnabled = true;
            this.countsBox.Location = new System.Drawing.Point(374, 18);
            this.countsBox.Name = "countsBox";
            this.countsBox.Size = new System.Drawing.Size(123, 65);
            this.countsBox.TabIndex = 37;
            // 
            // tempTime
            // 
            this.tempTime.Location = new System.Drawing.Point(278, 99);
            this.tempTime.Name = "tempTime";
            this.tempTime.Size = new System.Drawing.Size(221, 17);
            this.tempTime.TabIndex = 36;
            this.tempTime.Text = "0:00";
            this.tempTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Location = new System.Drawing.Point(277, 251);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(220, 24);
            this.resetButton.TabIndex = 35;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Location = new System.Drawing.Point(277, 200);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(221, 45);
            this.addButton.TabIndex = 34;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // resetAllButton
            // 
            this.resetAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetAllButton.Location = new System.Drawing.Point(25, 251);
            this.resetAllButton.Name = "resetAllButton";
            this.resetAllButton.Size = new System.Drawing.Size(110, 24);
            this.resetAllButton.TabIndex = 33;
            this.resetAllButton.Text = "Reset All";
            this.resetAllButton.UseVisualStyleBackColor = true;
            this.resetAllButton.Click += new System.EventHandler(this.resetAllButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 73);
            this.label1.TabIndex = 32;
            this.label1.Text = "00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add10
            // 
            this.add10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add10.Location = new System.Drawing.Point(277, 122);
            this.add10.Name = "add10";
            this.add10.Size = new System.Drawing.Size(221, 20);
            this.add10.TabIndex = 31;
            this.add10.Text = "+ 30 Seconds";
            this.add10.UseVisualStyleBackColor = true;
            this.add10.Click += new System.EventHandler(this.add10_Click);
            // 
            // add30
            // 
            this.add30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add30.Location = new System.Drawing.Point(277, 148);
            this.add30.Name = "add30";
            this.add30.Size = new System.Drawing.Size(221, 20);
            this.add30.TabIndex = 30;
            this.add30.Text = "+ 2 Minutes";
            this.add30.UseVisualStyleBackColor = true;
            this.add30.Click += new System.EventHandler(this.add30_Click);
            // 
            // add60
            // 
            this.add60.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add60.Location = new System.Drawing.Point(277, 174);
            this.add60.Name = "add60";
            this.add60.Size = new System.Drawing.Size(221, 20);
            this.add60.TabIndex = 29;
            this.add60.Text = "+ 5 Minutes";
            this.add60.UseVisualStyleBackColor = true;
            this.add60.Click += new System.EventHandler(this.add60_Click);
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Location = new System.Drawing.Point(25, 200);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(221, 45);
            this.startButton.TabIndex = 28;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skipButton
            // 
            this.skipButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipButton.Location = new System.Drawing.Point(142, 251);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(110, 24);
            this.skipButton.TabIndex = 38;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 301);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.countsBox);
            this.Controls.Add(this.tempTime);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resetAllButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add10);
            this.Controls.Add(this.add30);
            this.Controls.Add(this.add60);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Interval Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox countsBox;
        private System.Windows.Forms.Label tempTime;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button resetAllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add10;
        private System.Windows.Forms.Button add30;
        private System.Windows.Forms.Button add60;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button skipButton;
    }
}

