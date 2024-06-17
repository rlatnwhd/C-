namespace C__Project
{
    partial class Form20
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
            ResultBox = new Label();
            SuspendLayout();
            // 
            // ResultBox
            // 
            ResultBox.AutoSize = true;
            ResultBox.Font = new Font("휴먼둥근헤드라인", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ResultBox.Location = new Point(113, 552);
            ResultBox.Margin = new Padding(4, 0, 4, 0);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(80, 72);
            ResultBox.TabIndex = 134;
            ResultBox.Text = "0";
            // 
            // Form20
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.계산결과_003;
            ClientSize = new Size(1039, 788);
            Controls.Add(ResultBox);
            Name = "Form20";
            Text = "Form20";
            Load += Form20_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ResultBox;
    }
}