namespace MoAdventOfCode3
{
    partial class MoAdventOfCode3
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
            this.cmdCalculateSquaresMultipleClaims = new System.Windows.Forms.Button();
            this.txtNumberSquaresMultipleClaims = new System.Windows.Forms.TextBox();
            this.txtNoOverlaps = new System.Windows.Forms.TextBox();
            this.lblNumberSquaresMultipleClaims = new System.Windows.Forms.Label();
            this.lblNoOverlaps = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(491, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Advent Of Code 2018 - Day 3 - No Matter How You Slice It";
            // 
            // cmdCalculateSquaresMultipleClaims
            // 
            this.cmdCalculateSquaresMultipleClaims.AutoSize = true;
            this.cmdCalculateSquaresMultipleClaims.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdCalculateSquaresMultipleClaims.Enabled = false;
            this.cmdCalculateSquaresMultipleClaims.Location = new System.Drawing.Point(27, 136);
            this.cmdCalculateSquaresMultipleClaims.Name = "cmdCalculateSquaresMultipleClaims";
            this.cmdCalculateSquaresMultipleClaims.Size = new System.Drawing.Size(245, 23);
            this.cmdCalculateSquaresMultipleClaims.TabIndex = 1;
            this.cmdCalculateSquaresMultipleClaims.Text = "Calculate number of Squares with multiple claims";
            this.cmdCalculateSquaresMultipleClaims.UseVisualStyleBackColor = true;
            this.cmdCalculateSquaresMultipleClaims.Click += new System.EventHandler(this.cmdCalculateSquaresMultipleClaims_Click);
            // 
            // txtNumberSquaresMultipleClaims
            // 
            this.txtNumberSquaresMultipleClaims.Location = new System.Drawing.Point(308, 138);
            this.txtNumberSquaresMultipleClaims.Name = "txtNumberSquaresMultipleClaims";
            this.txtNumberSquaresMultipleClaims.ReadOnly = true;
            this.txtNumberSquaresMultipleClaims.Size = new System.Drawing.Size(80, 20);
            this.txtNumberSquaresMultipleClaims.TabIndex = 3;
            this.txtNumberSquaresMultipleClaims.TabStop = false;
            // 
            // txtNoOverlaps
            // 
            this.txtNoOverlaps.Location = new System.Drawing.Point(308, 201);
            this.txtNoOverlaps.Name = "txtNoOverlaps";
            this.txtNoOverlaps.ReadOnly = true;
            this.txtNoOverlaps.Size = new System.Drawing.Size(80, 20);
            this.txtNoOverlaps.TabIndex = 4;
            this.txtNoOverlaps.TabStop = false;
            // 
            // lblNumberSquaresMultipleClaims
            // 
            this.lblNumberSquaresMultipleClaims.AutoSize = true;
            this.lblNumberSquaresMultipleClaims.Location = new System.Drawing.Point(305, 122);
            this.lblNumberSquaresMultipleClaims.Name = "lblNumberSquaresMultipleClaims";
            this.lblNumberSquaresMultipleClaims.Size = new System.Drawing.Size(192, 13);
            this.lblNumberSquaresMultipleClaims.TabIndex = 5;
            this.lblNumberSquaresMultipleClaims.Text = "Number of Squares with Multiple Claims";
            // 
            // lblNoOverlaps
            // 
            this.lblNoOverlaps.AutoSize = true;
            this.lblNoOverlaps.Location = new System.Drawing.Point(305, 185);
            this.lblNoOverlaps.Name = "lblNoOverlaps";
            this.lblNoOverlaps.Size = new System.Drawing.Size(138, 13);
            this.lblNoOverlaps.TabIndex = 6;
            this.lblNoOverlaps.Text = "Id of Claim with no Overlaps";
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
            this.label2.Text = "C:\\AdventOfCode\\AOC_2018_day3_input.txt";
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
            // MoAdventOfCode3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdLoadPuzzleInput);
            this.Controls.Add(this.lblNoOverlaps);
            this.Controls.Add(this.lblNumberSquaresMultipleClaims);
            this.Controls.Add(this.txtNoOverlaps);
            this.Controls.Add(this.txtNumberSquaresMultipleClaims);
            this.Controls.Add(this.cmdCalculateSquaresMultipleClaims);
            this.Controls.Add(this.label1);
            this.Name = "MoAdventOfCode3";
            this.Text = "Mo Advent Of Code 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCalculateSquaresMultipleClaims;
        private System.Windows.Forms.TextBox txtNumberSquaresMultipleClaims;
        private System.Windows.Forms.TextBox txtNoOverlaps;
        private System.Windows.Forms.Label lblNumberSquaresMultipleClaims;
        private System.Windows.Forms.Label lblNoOverlaps;
        private System.Windows.Forms.Button cmdLoadPuzzleInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInformation;
    }
}

