namespace Laba5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.inputFileButton = new System.Windows.Forms.Button();
            this.outputFileButton = new System.Windows.Forms.Button();
            this.packButton = new System.Windows.Forms.Button();
            this.unpackButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // inputFileTextBox
            // 
            this.inputFileTextBox.Location = new System.Drawing.Point(12, 48);
            this.inputFileTextBox.Name = "inputFileTextBox";
            this.inputFileTextBox.Size = new System.Drawing.Size(293, 27);
            this.inputFileTextBox.TabIndex = 0;
            this.inputFileTextBox.Text = "InputFile";
            this.inputFileTextBox.TextChanged += new System.EventHandler(this.inputFileTextBox_TextChanged);
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Location = new System.Drawing.Point(12, 103);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(293, 27);
            this.outputFileTextBox.TabIndex = 1;
            this.outputFileTextBox.Text = "OutputFile";
            this.outputFileTextBox.TextChanged += new System.EventHandler(this.outputFileTextBox_TextChanged);
            // 
            // inputFileButton
            // 
            this.inputFileButton.Location = new System.Drawing.Point(311, 46);
            this.inputFileButton.Name = "inputFileButton";
            this.inputFileButton.Size = new System.Drawing.Size(128, 29);
            this.inputFileButton.TabIndex = 2;
            this.inputFileButton.Text = "Выбрать файл";
            this.inputFileButton.UseVisualStyleBackColor = true;
            this.inputFileButton.Click += new System.EventHandler(this.inputFileButton_Click);
            // 
            // outputFileButton
            // 
            this.outputFileButton.Location = new System.Drawing.Point(311, 103);
            this.outputFileButton.Name = "outputFileButton";
            this.outputFileButton.Size = new System.Drawing.Size(128, 29);
            this.outputFileButton.TabIndex = 3;
            this.outputFileButton.Text = "Выбрать файл";
            this.outputFileButton.UseVisualStyleBackColor = true;
            this.outputFileButton.Click += new System.EventHandler(this.outputFileButton_Click);
            // 
            // packButton
            // 
            this.packButton.Location = new System.Drawing.Point(12, 155);
            this.packButton.Name = "packButton";
            this.packButton.Size = new System.Drawing.Size(427, 46);
            this.packButton.TabIndex = 4;
            this.packButton.Text = "Pack";
            this.packButton.UseVisualStyleBackColor = true;
            this.packButton.Click += new System.EventHandler(this.packButton_Click);
            // 
            // unpackButton
            // 
            this.unpackButton.Location = new System.Drawing.Point(12, 220);
            this.unpackButton.Name = "unpackButton";
            this.unpackButton.Size = new System.Drawing.Size(427, 41);
            this.unpackButton.TabIndex = 5;
            this.unpackButton.Text = "UnPack";
            this.unpackButton.UseVisualStyleBackColor = true;
            this.unpackButton.Click += new System.EventHandler(this.unpackButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(12, 281);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(427, 44);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 342);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(427, 39);
            this.progressBar.TabIndex = 7;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 393);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.unpackButton);
            this.Controls.Add(this.packButton);
            this.Controls.Add(this.outputFileButton);
            this.Controls.Add(this.inputFileButton);
            this.Controls.Add(this.outputFileTextBox);
            this.Controls.Add(this.inputFileTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputFileTextBox;
        private TextBox outputFileTextBox;
        private Button inputFileButton;
        private Button outputFileButton;
        private Button packButton;
        private Button unpackButton;
        private Button stopButton;
        private ProgressBar progressBar;
    }
}