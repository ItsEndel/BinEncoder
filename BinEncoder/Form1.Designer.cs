namespace BinEncoder
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(16, 16);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.PlaceholderText = "请在这里输入要加密/解密的文本";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(752, 366);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "这是一句话。";
            this.textBox.WordWrap = false;
            // 
            // seedTextBox
            // 
            this.seedTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seedTextBox.Location = new System.Drawing.Point(336, 398);
            this.seedTextBox.MaxLength = 5;
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.PlaceholderText = "请输入种子";
            this.seedTextBox.Size = new System.Drawing.Size(128, 35);
            this.seedTextBox.TabIndex = 3;
            this.seedTextBox.Text = "5";
            this.seedTextBox.TextChanged += new System.EventHandler(this.seedTextBox_TextChanged);
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(112, 398);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(128, 35);
            this.encodeButton.TabIndex = 1;
            this.encodeButton.Text = "加密";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(560, 398);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(128, 35);
            this.decodeButton.TabIndex = 2;
            this.decodeButton.Text = "解密";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.seedTextBox);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "BinEncoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox;
        private TextBox seedTextBox;
        private Button encodeButton;
        private Button decodeButton;
    }
}