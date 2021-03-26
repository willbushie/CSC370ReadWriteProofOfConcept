
namespace CSC370ReadWriteProofOfConcept
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
            this.textFileLabel = new System.Windows.Forms.Label();
            this.textFileTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.contentsLabel = new System.Windows.Forms.Label();
            this.contentsTextBox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.contentsTextBox2 = new System.Windows.Forms.TextBox();
            this.contentsLabel2 = new System.Windows.Forms.Label();
            this.writeSaveAsTextBox = new System.Windows.Forms.TextBox();
            this.writeTextBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textFileLabel
            // 
            this.textFileLabel.AutoSize = true;
            this.textFileLabel.Location = new System.Drawing.Point(12, 16);
            this.textFileLabel.Name = "textFileLabel";
            this.textFileLabel.Size = new System.Drawing.Size(47, 13);
            this.textFileLabel.TabIndex = 0;
            this.textFileLabel.Text = "Text File";
            // 
            // textFileTextBox
            // 
            this.textFileTextBox.Location = new System.Drawing.Point(75, 12);
            this.textFileTextBox.Name = "textFileTextBox";
            this.textFileTextBox.Size = new System.Drawing.Size(217, 20);
            this.textFileTextBox.TabIndex = 1;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(75, 63);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(81, 60);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // contentsLabel
            // 
            this.contentsLabel.AutoSize = true;
            this.contentsLabel.Location = new System.Drawing.Point(7, 157);
            this.contentsLabel.Name = "contentsLabel";
            this.contentsLabel.Size = new System.Drawing.Size(52, 13);
            this.contentsLabel.TabIndex = 3;
            this.contentsLabel.Text = "Contents:";
            // 
            // contentsTextBox
            // 
            this.contentsTextBox.Location = new System.Drawing.Point(75, 157);
            this.contentsTextBox.Multiline = true;
            this.contentsTextBox.Name = "contentsTextBox";
            this.contentsTextBox.Size = new System.Drawing.Size(217, 204);
            this.contentsTextBox.TabIndex = 4;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(211, 63);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(81, 60);
            this.openFileButton.TabIndex = 5;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(320, 386);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(410, 63);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(81, 60);
            this.writeButton.TabIndex = 7;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(538, 63);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(81, 60);
            this.saveAsButton.TabIndex = 8;
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // contentsTextBox2
            // 
            this.contentsTextBox2.Location = new System.Drawing.Point(410, 157);
            this.contentsTextBox2.Multiline = true;
            this.contentsTextBox2.Name = "contentsTextBox2";
            this.contentsTextBox2.Size = new System.Drawing.Size(209, 204);
            this.contentsTextBox2.TabIndex = 9;
            // 
            // contentsLabel2
            // 
            this.contentsLabel2.AutoSize = true;
            this.contentsLabel2.Location = new System.Drawing.Point(343, 160);
            this.contentsLabel2.Name = "contentsLabel2";
            this.contentsLabel2.Size = new System.Drawing.Size(52, 13);
            this.contentsLabel2.TabIndex = 10;
            this.contentsLabel2.Text = "Contents:";
            // 
            // writeSaveAsTextBox
            // 
            this.writeSaveAsTextBox.Location = new System.Drawing.Point(410, 8);
            this.writeSaveAsTextBox.Name = "writeSaveAsTextBox";
            this.writeSaveAsTextBox.Size = new System.Drawing.Size(209, 20);
            this.writeSaveAsTextBox.TabIndex = 11;
            // 
            // writeTextBoxLabel
            // 
            this.writeTextBoxLabel.AutoSize = true;
            this.writeTextBoxLabel.Location = new System.Drawing.Point(348, 8);
            this.writeTextBoxLabel.Name = "writeTextBoxLabel";
            this.writeTextBoxLabel.Size = new System.Drawing.Size(47, 13);
            this.writeTextBoxLabel.TabIndex = 12;
            this.writeTextBoxLabel.Text = "Text File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.writeTextBoxLabel);
            this.Controls.Add(this.writeSaveAsTextBox);
            this.Controls.Add(this.contentsLabel2);
            this.Controls.Add(this.contentsTextBox2);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.contentsTextBox);
            this.Controls.Add(this.contentsLabel);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.textFileTextBox);
            this.Controls.Add(this.textFileLabel);
            this.Name = "Form1";
            this.Text = "Read and Write to Text File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textFileLabel;
        private System.Windows.Forms.TextBox textFileTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label contentsLabel;
        private System.Windows.Forms.TextBox contentsTextBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.TextBox contentsTextBox2;
        private System.Windows.Forms.Label contentsLabel2;
        private System.Windows.Forms.TextBox writeSaveAsTextBox;
        private System.Windows.Forms.Label writeTextBoxLabel;
    }
}

