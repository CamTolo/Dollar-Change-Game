
namespace Dollar_Change_Game
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
            this.numOfQuartersLabel = new System.Windows.Forms.Label();
            this.numOfPenniesLabel = new System.Windows.Forms.Label();
            this.numOfNickelsLabel = new System.Windows.Forms.Label();
            this.numOfDimesLabel = new System.Windows.Forms.Label();
            this.dollarChangeGameLabel = new System.Windows.Forms.Label();
            this.penniesTextBox = new System.Windows.Forms.TextBox();
            this.nickelsTextBox = new System.Windows.Forms.TextBox();
            this.dimesTextBox = new System.Windows.Forms.TextBox();
            this.quartersTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numOfQuartersLabel
            // 
            this.numOfQuartersLabel.AutoSize = true;
            this.numOfQuartersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfQuartersLabel.Location = new System.Drawing.Point(43, 205);
            this.numOfQuartersLabel.Name = "numOfQuartersLabel";
            this.numOfQuartersLabel.Size = new System.Drawing.Size(206, 24);
            this.numOfQuartersLabel.TabIndex = 0;
            this.numOfQuartersLabel.Text = "Number of Quarters: ";
            // 
            // numOfPenniesLabel
            // 
            this.numOfPenniesLabel.AutoSize = true;
            this.numOfPenniesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfPenniesLabel.Location = new System.Drawing.Point(43, 77);
            this.numOfPenniesLabel.Name = "numOfPenniesLabel";
            this.numOfPenniesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numOfPenniesLabel.Size = new System.Drawing.Size(208, 24);
            this.numOfPenniesLabel.TabIndex = 1;
            this.numOfPenniesLabel.Text = "Number of Pennies : ";
            // 
            // numOfNickelsLabel
            // 
            this.numOfNickelsLabel.AutoSize = true;
            this.numOfNickelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfNickelsLabel.Location = new System.Drawing.Point(43, 123);
            this.numOfNickelsLabel.Name = "numOfNickelsLabel";
            this.numOfNickelsLabel.Size = new System.Drawing.Size(200, 24);
            this.numOfNickelsLabel.TabIndex = 2;
            this.numOfNickelsLabel.Text = "Number of Nickels : ";
            this.numOfNickelsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // numOfDimesLabel
            // 
            this.numOfDimesLabel.AutoSize = true;
            this.numOfDimesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfDimesLabel.Location = new System.Drawing.Point(43, 165);
            this.numOfDimesLabel.Name = "numOfDimesLabel";
            this.numOfDimesLabel.Size = new System.Drawing.Size(190, 24);
            this.numOfDimesLabel.TabIndex = 3;
            this.numOfDimesLabel.Text = "Number of Dimes : ";
            // 
            // dollarChangeGameLabel
            // 
            this.dollarChangeGameLabel.AutoSize = true;
            this.dollarChangeGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarChangeGameLabel.Location = new System.Drawing.Point(191, 21);
            this.dollarChangeGameLabel.Name = "dollarChangeGameLabel";
            this.dollarChangeGameLabel.Size = new System.Drawing.Size(356, 24);
            this.dollarChangeGameLabel.TabIndex = 4;
            this.dollarChangeGameLabel.Text = "Welcome to the Dollar Change Game";
            // 
            // penniesTextBox
            // 
            this.penniesTextBox.Location = new System.Drawing.Point(313, 82);
            this.penniesTextBox.Name = "penniesTextBox";
            this.penniesTextBox.Size = new System.Drawing.Size(100, 20);
            this.penniesTextBox.TabIndex = 5;
            // 
            // nickelsTextBox
            // 
            this.nickelsTextBox.Location = new System.Drawing.Point(313, 128);
            this.nickelsTextBox.Name = "nickelsTextBox";
            this.nickelsTextBox.Size = new System.Drawing.Size(100, 20);
            this.nickelsTextBox.TabIndex = 6;
            // 
            // dimesTextBox
            // 
            this.dimesTextBox.Location = new System.Drawing.Point(313, 170);
            this.dimesTextBox.Name = "dimesTextBox";
            this.dimesTextBox.Size = new System.Drawing.Size(100, 20);
            this.dimesTextBox.TabIndex = 7;
            // 
            // quartersTextBox
            // 
            this.quartersTextBox.Location = new System.Drawing.Point(313, 210);
            this.quartersTextBox.Name = "quartersTextBox";
            this.quartersTextBox.Size = new System.Drawing.Size(100, 20);
            this.quartersTextBox.TabIndex = 8;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(520, 77);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(161, 81);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate Change";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.changeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.changeLabel.Location = new System.Drawing.Point(195, 297);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(394, 87);
            this.changeLabel.TabIndex = 10;
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(528, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Designed by: Cameron Tolodziecki";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(520, 182);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(161, 71);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.quartersTextBox);
            this.Controls.Add(this.dimesTextBox);
            this.Controls.Add(this.nickelsTextBox);
            this.Controls.Add(this.penniesTextBox);
            this.Controls.Add(this.dollarChangeGameLabel);
            this.Controls.Add(this.numOfDimesLabel);
            this.Controls.Add(this.numOfNickelsLabel);
            this.Controls.Add(this.numOfPenniesLabel);
            this.Controls.Add(this.numOfQuartersLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOfQuartersLabel;
        private System.Windows.Forms.Label numOfPenniesLabel;
        private System.Windows.Forms.Label numOfNickelsLabel;
        private System.Windows.Forms.Label numOfDimesLabel;
        private System.Windows.Forms.Label dollarChangeGameLabel;
        private System.Windows.Forms.TextBox penniesTextBox;
        private System.Windows.Forms.TextBox nickelsTextBox;
        private System.Windows.Forms.TextBox dimesTextBox;
        private System.Windows.Forms.TextBox quartersTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
    }
}

