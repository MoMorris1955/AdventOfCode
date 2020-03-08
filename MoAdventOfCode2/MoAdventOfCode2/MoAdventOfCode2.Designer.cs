namespace MoAdventOfCode2
{
    partial class MoAdventOfCode2
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
            this.cmdCalculateCheckSum = new System.Windows.Forms.Button();
            this.cmdFindCommonChars = new System.Windows.Forms.Button();
            this.txtCalculatedCheckSum = new System.Windows.Forms.TextBox();
            this.txtCommonCharacters = new System.Windows.Forms.TextBox();
            this.lblCalculatedCheckSum = new System.Windows.Forms.Label();
            this.lblCommonCharacters = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(526, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Advent Of Code 2018 - Day 2 - Inventory Management System";
            // 
            // cmdCalculateCheckSum
            // 
            this.cmdCalculateCheckSum.AutoSize = true;
            this.cmdCalculateCheckSum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdCalculateCheckSum.Enabled = false;
            this.cmdCalculateCheckSum.Location = new System.Drawing.Point(27, 136);
            this.cmdCalculateCheckSum.Name = "cmdCalculateCheckSum";
            this.cmdCalculateCheckSum.Size = new System.Drawing.Size(192, 23);
            this.cmdCalculateCheckSum.TabIndex = 1;
            this.cmdCalculateCheckSum.Text = "Calculate CheckSum for Puzzle Input";
            this.cmdCalculateCheckSum.UseVisualStyleBackColor = true;
            this.cmdCalculateCheckSum.Click += new System.EventHandler(this.cmdcmdCalculateCheckSum_Click);
            // 
            // cmdFindCommonChars
            // 
            this.cmdFindCommonChars.AutoSize = true;
            this.cmdFindCommonChars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdFindCommonChars.Enabled = false;
            this.cmdFindCommonChars.Location = new System.Drawing.Point(27, 198);
            this.cmdFindCommonChars.Name = "cmdFindCommonChars";
            this.cmdFindCommonChars.Size = new System.Drawing.Size(214, 23);
            this.cmdFindCommonChars.TabIndex = 2;
            this.cmdFindCommonChars.Text = "Find common chars in two correct Box Ids";
            this.cmdFindCommonChars.UseVisualStyleBackColor = true;
            this.cmdFindCommonChars.Click += new System.EventHandler(this.cmdFindCommonChars_Click);
            // 
            // txtCalculatedCheckSum
            // 
            this.txtCalculatedCheckSum.Location = new System.Drawing.Point(308, 138);
            this.txtCalculatedCheckSum.Name = "txtCalculatedCheckSum";
            this.txtCalculatedCheckSum.ReadOnly = true;
            this.txtCalculatedCheckSum.Size = new System.Drawing.Size(80, 20);
            this.txtCalculatedCheckSum.TabIndex = 3;
            this.txtCalculatedCheckSum.TabStop = false;
            // 
            // txtCommonCharacters
            // 
            this.txtCommonCharacters.Location = new System.Drawing.Point(308, 201);
            this.txtCommonCharacters.Name = "txtCommonCharacters";
            this.txtCommonCharacters.ReadOnly = true;
            this.txtCommonCharacters.Size = new System.Drawing.Size(249, 20);
            this.txtCommonCharacters.TabIndex = 4;
            this.txtCommonCharacters.TabStop = false;
            // 
            // lblCalculatedCheckSum
            // 
            this.lblCalculatedCheckSum.AutoSize = true;
            this.lblCalculatedCheckSum.Location = new System.Drawing.Point(305, 122);
            this.lblCalculatedCheckSum.Name = "lblCalculatedCheckSum";
            this.lblCalculatedCheckSum.Size = new System.Drawing.Size(132, 13);
            this.lblCalculatedCheckSum.TabIndex = 5;
            this.lblCalculatedCheckSum.Text = "CheckSum of Puzzle Input";
            // 
            // lblCommonCharacters
            // 
            this.lblCommonCharacters.AutoSize = true;
            this.lblCommonCharacters.Location = new System.Drawing.Point(305, 185);
            this.lblCommonCharacters.Name = "lblCommonCharacters";
            this.lblCommonCharacters.Size = new System.Drawing.Size(101, 13);
            this.lblCommonCharacters.TabIndex = 6;
            this.lblCommonCharacters.Text = "Common characters";
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
            this.label2.Text = "C:\\AdventOfCode\\AOC_2018_day2_input.txt";
            // 
            // txtInformation
            // 
            this.txtInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.Location = new System.Drawing.Point(27, 55);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.ReadOnly = true;
            this.txtInformation.Size = new System.Drawing.Size(510, 20);
            this.txtInformation.TabIndex = 9;
            this.txtInformation.TabStop = false;
            this.txtInformation.Text = " Click [Load Puzzle Input] ";
            // 
            // MoAdventOfCode2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdLoadPuzzleInput);
            this.Controls.Add(this.lblCommonCharacters);
            this.Controls.Add(this.lblCalculatedCheckSum);
            this.Controls.Add(this.txtCommonCharacters);
            this.Controls.Add(this.txtCalculatedCheckSum);
            this.Controls.Add(this.cmdFindCommonChars);
            this.Controls.Add(this.cmdCalculateCheckSum);
            this.Controls.Add(this.label1);
            this.Name = "MoAdventOfCode2";
            this.Text = "Mo Advent Of Code 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCalculateCheckSum;
        private System.Windows.Forms.Button cmdFindCommonChars;
        private System.Windows.Forms.TextBox txtCalculatedCheckSum;
        private System.Windows.Forms.TextBox txtCommonCharacters;
        private System.Windows.Forms.Label lblCalculatedCheckSum;
        private System.Windows.Forms.Label lblCommonCharacters;
        private System.Windows.Forms.Button cmdLoadPuzzleInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInformation;
    }
}

