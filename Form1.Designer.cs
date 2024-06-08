namespace DPM_Calc
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.damageLabel = new System.Windows.Forms.Label();
            this.guardedDamageLabel = new System.Windows.Forms.Label();
            this.minutesTextBox = new System.Windows.Forms.TextBox();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.damageTextBox = new System.Windows.Forms.TextBox();
            this.guardedDamageTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.guardedPercentageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(13, 13);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(47, 13);
            this.minutesLabel.TabIndex = 0;
            this.minutesLabel.Text = "Minutes:";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(13, 39);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(52, 13);
            this.secondsLabel.TabIndex = 1;
            this.secondsLabel.Text = "Seconds:";
            // 
            // damageLabel
            // 
            this.damageLabel.AutoSize = true;
            this.damageLabel.Location = new System.Drawing.Point(13, 65);
            this.damageLabel.Name = "damageLabel";
            this.damageLabel.Size = new System.Drawing.Size(50, 13);
            this.damageLabel.TabIndex = 2;
            this.damageLabel.Text = "Damage:";
            // 
            // guardedDamageLabel
            // 
            this.guardedDamageLabel.AutoSize = true;
            this.guardedDamageLabel.Location = new System.Drawing.Point(13, 91);
            this.guardedDamageLabel.Name = "guardedDamageLabel";
            this.guardedDamageLabel.Size = new System.Drawing.Size(94, 13);
            this.guardedDamageLabel.TabIndex = 3;
            this.guardedDamageLabel.Text = "Guarded Damage:";
            // 
            // minutesTextBox
            // 
            this.minutesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.minutesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minutesTextBox.ForeColor = System.Drawing.Color.White;
            this.minutesTextBox.Location = new System.Drawing.Point(109, 10);
            this.minutesTextBox.Name = "minutesTextBox";
            this.minutesTextBox.Size = new System.Drawing.Size(100, 20);
            this.minutesTextBox.TabIndex = 4;
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.secondsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondsTextBox.ForeColor = System.Drawing.Color.White;
            this.secondsTextBox.Location = new System.Drawing.Point(109, 36);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondsTextBox.TabIndex = 5;
            // 
            // damageTextBox
            // 
            this.damageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.damageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.damageTextBox.ForeColor = System.Drawing.Color.White;
            this.damageTextBox.Location = new System.Drawing.Point(109, 62);
            this.damageTextBox.Name = "damageTextBox";
            this.damageTextBox.Size = new System.Drawing.Size(100, 20);
            this.damageTextBox.TabIndex = 6;
            // 
            // guardedDamageTextBox
            // 
            this.guardedDamageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guardedDamageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guardedDamageTextBox.ForeColor = System.Drawing.Color.White;
            this.guardedDamageTextBox.Location = new System.Drawing.Point(109, 88);
            this.guardedDamageTextBox.Name = "guardedDamageTextBox";
            this.guardedDamageTextBox.Size = new System.Drawing.Size(100, 20);
            this.guardedDamageTextBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(16, 114);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(193, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(16, 150);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "Result";
            // 
            // guardedPercentageLabel
            // 
            this.guardedPercentageLabel.AutoSize = true;
            this.guardedPercentageLabel.Location = new System.Drawing.Point(16, 173);
            this.guardedPercentageLabel.Name = "guardedPercentageLabel";
            this.guardedPercentageLabel.Size = new System.Drawing.Size(106, 13);
            this.guardedPercentageLabel.TabIndex = 10;
            this.guardedPercentageLabel.Text = "Guarded Percentage";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(252, 210);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.guardedPercentageLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.guardedDamageTextBox);
            this.Controls.Add(this.damageTextBox);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.minutesTextBox);
            this.Controls.Add(this.guardedDamageLabel);
            this.Controls.Add(this.damageLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.minutesLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Damage Per Minute Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label damageLabel;
        private System.Windows.Forms.Label guardedDamageLabel; // New label
        private System.Windows.Forms.TextBox minutesTextBox;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.TextBox damageTextBox;
        private System.Windows.Forms.TextBox guardedDamageTextBox; // New text box
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label guardedPercentageLabel; // New result label
    }
}
