namespace MoAdventOfCode1
{
    partial class MoAdventOfCode1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdResultingFrequency = new System.Windows.Forms.Button();
            this.cmdFrequencyReachedTwice = new System.Windows.Forms.Button();
            this.txtResultingFrequency = new System.Windows.Forms.TextBox();
            this.txtFrequencyReachedTwice = new System.Windows.Forms.TextBox();
            this.lblResultingFrequency = new System.Windows.Forms.Label();
            this.lblFrequencyReachedTwice = new System.Windows.Forms.Label();
            this.cmdLoadPuzzleInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Advent Of Code 2018 - Day 1 - Chronal Calibration";
            // 
            // cmdResultingFrequency
            // 
            this.cmdResultingFrequency.AutoSize = true;
            this.cmdResultingFrequency.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdResultingFrequency.Enabled = false;
            this.cmdResultingFrequency.Location = new System.Drawing.Point(27, 136);
            this.cmdResultingFrequency.Name = "cmdResultingFrequency";
            this.cmdResultingFrequency.Size = new System.Drawing.Size(151, 23);
            this.cmdResultingFrequency.TabIndex = 1;
            this.cmdResultingFrequency.Text = "Display Resulting Frequency";
            this.cmdResultingFrequency.UseVisualStyleBackColor = true;
            this.cmdResultingFrequency.Click += new System.EventHandler(this.cmdResultingFrequency_Click);
            // 
            // cmdFrequencyReachedTwice
            // 
            this.cmdFrequencyReachedTwice.AutoSize = true;
            this.cmdFrequencyReachedTwice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdFrequencyReachedTwice.Enabled = false;
            this.cmdFrequencyReachedTwice.Location = new System.Drawing.Point(27, 198);
            this.cmdFrequencyReachedTwice.Name = "cmdFrequencyReachedTwice";
            this.cmdFrequencyReachedTwice.Size = new System.Drawing.Size(205, 23);
            this.cmdFrequencyReachedTwice.TabIndex = 2;
            this.cmdFrequencyReachedTwice.Text = "Display First Frequency Reached Twice";
            this.cmdFrequencyReachedTwice.UseVisualStyleBackColor = true;
            this.cmdFrequencyReachedTwice.Click += new System.EventHandler(this.cmdFrequencyReachedTwice_Click);
            // 
            // txtResultingFrequency
            // 
            this.txtResultingFrequency.Location = new System.Drawing.Point(308, 138);
            this.txtResultingFrequency.Name = "txtResultingFrequency";
            this.txtResultingFrequency.ReadOnly = true;
            this.txtResultingFrequency.Size = new System.Drawing.Size(80, 20);
            this.txtResultingFrequency.TabIndex = 3;
            this.txtResultingFrequency.TabStop = false;
            // 
            // txtFrequencyReachedTwice
            // 
            this.txtFrequencyReachedTwice.Location = new System.Drawing.Point(308, 201);
            this.txtFrequencyReachedTwice.Name = "txtFrequencyReachedTwice";
            this.txtFrequencyReachedTwice.ReadOnly = true;
            this.txtFrequencyReachedTwice.Size = new System.Drawing.Size(81, 20);
            this.txtFrequencyReachedTwice.TabIndex = 4;
            this.txtFrequencyReachedTwice.TabStop = false;
            // 
            // lblResultingFrequency
            // 
            this.lblResultingFrequency.AutoSize = true;
            this.lblResultingFrequency.Location = new System.Drawing.Point(305, 122);
            this.lblResultingFrequency.Name = "lblResultingFrequency";
            this.lblResultingFrequency.Size = new System.Drawing.Size(104, 13);
            this.lblResultingFrequency.TabIndex = 5;
            this.lblResultingFrequency.Text = "Resulting Frequency";
            // 
            // lblFrequencyReachedTwice
            // 
            this.lblFrequencyReachedTwice.AutoSize = true;
            this.lblFrequencyReachedTwice.Location = new System.Drawing.Point(305, 185);
            this.lblFrequencyReachedTwice.Name = "lblFrequencyReachedTwice";
            this.lblFrequencyReachedTwice.Size = new System.Drawing.Size(136, 13);
            this.lblFrequencyReachedTwice.TabIndex = 6;
            this.lblFrequencyReachedTwice.Text = "Frequency Reached Twice";
            // 
            // cmdLoadPuzzleInput
            // 
            this.cmdLoadPuzzleInput.AutoSize = true;
            this.cmdLoadPuzzleInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdLoadPuzzleInput.Location = new System.Drawing.Point(27, 81);
            this.cmdLoadPuzzleInput.Name = "cmdLoadPuzzleInput";
            this.cmdLoadPuzzleInput.Size = new System.Drawing.Size(102, 23);
            this.cmdLoadPuzzleInput.TabIndex = 7;
            this.cmdLoadPuzzleInput.Text = "Load Puzzle Input";
            this.cmdLoadPuzzleInput.UseVisualStyleBackColor = true;
            this.cmdLoadPuzzleInput.Click += new System.EventHandler(this.cmdLoadPuzzleInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "C:\\AdventOfCode\\AOC_2018_day1_input.txt";
            // 
            // txtInformation
            // 
            this.txtInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.Location = new System.Drawing.Point(27, 55);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.ReadOnly = true;
            this.txtInformation.Size = new System.Drawing.Size(410, 20);
            this.txtInformation.TabIndex = 9;
            this.txtInformation.TabStop = false;
            this.txtInformation.Text = " Click [Load Puzzle Input] ";
            // 
            // MoAdventOfCode1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdLoadPuzzleInput);
            this.Controls.Add(this.lblFrequencyReachedTwice);
            this.Controls.Add(this.lblResultingFrequency);
            this.Controls.Add(this.txtFrequencyReachedTwice);
            this.Controls.Add(this.txtResultingFrequency);
            this.Controls.Add(this.cmdFrequencyReachedTwice);
            this.Controls.Add(this.cmdResultingFrequency);
            this.Controls.Add(this.label1);
            this.Name = "MoAdventOfCode1";
            this.Text = "Mo Advent Of Code 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdResultingFrequency;
        private System.Windows.Forms.Button cmdFrequencyReachedTwice;
        private System.Windows.Forms.TextBox txtResultingFrequency;
        private System.Windows.Forms.TextBox txtFrequencyReachedTwice;
        private System.Windows.Forms.Label lblResultingFrequency;
        private System.Windows.Forms.Label lblFrequencyReachedTwice;
        private System.Windows.Forms.Button cmdLoadPuzzleInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInformation;
    }
}

