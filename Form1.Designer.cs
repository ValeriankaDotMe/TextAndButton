namespace TextAndButton
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
            showText = new Button();
            SuspendLayout();
            // 
            // showText
            // 
            showText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            showText.Location = new Point(283, 180);
            showText.Name = "showText";
            showText.Size = new Size(203, 60);
            showText.TabIndex = 0;
            showText.Text = "Показать текст";
            showText.UseVisualStyleBackColor = true;
            showText.Click += showText_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button showText;
    }
}