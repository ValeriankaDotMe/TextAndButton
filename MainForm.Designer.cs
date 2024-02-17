namespace TextAndButton
{
    partial class MainForm
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
            showText = new Button();
            messageField = new TextBox();
            SuspendLayout();
            // 
            // showText
            // 
            showText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            showText.Location = new Point(299, 61);
            showText.Name = "showText";
            showText.Size = new Size(203, 60);
            showText.TabIndex = 0;
            showText.Text = "Показать текст";
            showText.UseVisualStyleBackColor = true;
            showText.Click += showText_Click;
            // 
            // messageField
            // 
            messageField.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            messageField.Location = new Point(12, 12);
            messageField.Name = "messageField";
            messageField.Size = new Size(776, 43);
            messageField.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 132);
            Controls.Add(messageField);
            Controls.Add(showText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TextAndButton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button showText;
        private TextBox messageField;
    }
}