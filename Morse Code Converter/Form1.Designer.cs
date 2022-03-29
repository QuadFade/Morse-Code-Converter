namespace Morse_Code_Converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.convertLabel = new System.Windows.Forms.Label();
            this.convertTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.staticOutputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.revertTextBox = new System.Windows.Forms.TextBox();
            this.revertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Morse Code Converter";
            // 
            // convertLabel
            // 
            this.convertLabel.AutoSize = true;
            this.convertLabel.Location = new System.Drawing.Point(3, 36);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(94, 13);
            this.convertLabel.TabIndex = 1;
            this.convertLabel.Text = "To Be Converted: ";
            // 
            // convertTextBox
            // 
            this.convertTextBox.Location = new System.Drawing.Point(93, 33);
            this.convertTextBox.Name = "convertTextBox";
            this.convertTextBox.Size = new System.Drawing.Size(201, 20);
            this.convertTextBox.TabIndex = 2;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(300, 25);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 34);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(219, 300);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // staticOutputLabel
            // 
            this.staticOutputLabel.AutoSize = true;
            this.staticOutputLabel.Location = new System.Drawing.Point(9, 93);
            this.staticOutputLabel.Name = "staticOutputLabel";
            this.staticOutputLabel.Size = new System.Drawing.Size(45, 13);
            this.staticOutputLabel.TabIndex = 6;
            this.staticOutputLabel.Text = "Output: ";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(68, 74);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 7;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(60, 82);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(315, 77);
            this.outputTextBox.TabIndex = 8;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(127, 300);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 34);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // revertTextBox
            // 
            this.revertTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revertTextBox.Location = new System.Drawing.Point(61, 203);
            this.revertTextBox.Multiline = true;
            this.revertTextBox.Name = "revertTextBox";
            this.revertTextBox.ReadOnly = true;
            this.revertTextBox.Size = new System.Drawing.Size(314, 77);
            this.revertTextBox.TabIndex = 10;
            // 
            // revertButton
            // 
            this.revertButton.Location = new System.Drawing.Point(162, 163);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(75, 34);
            this.revertButton.TabIndex = 11;
            this.revertButton.Text = "Revert Text";
            this.revertButton.UseVisualStyleBackColor = true;
            this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 358);
            this.Controls.Add(this.revertButton);
            this.Controls.Add(this.revertTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.staticOutputLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertTextBox);
            this.Controls.Add(this.convertLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morse Code Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label convertLabel;
        private System.Windows.Forms.TextBox convertTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label staticOutputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox revertTextBox;
        private System.Windows.Forms.Button revertButton;
    }
}

