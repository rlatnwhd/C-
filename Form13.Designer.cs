namespace C__Project
{
    partial class Form13
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
            button1 = new Button();
            Include7 = new Button();
            UnInclude7 = new Button();
            Include1 = new Button();
            UnInclude1 = new Button();
            HW1 = new TextBox();
            Tax9_8 = new Button();
            Tax3_3 = new Button();
            NoTax = new Button();
            HW = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(792, 616);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(244, 94);
            button1.TabIndex = 157;
            button1.Text = "급여 계산";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CalculateButton_Click;
            // 
            // Include7
            // 
            Include7.BackColor = SystemColors.ButtonHighlight;
            Include7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include7.Location = new Point(294, 87);
            Include7.Margin = new Padding(4, 2, 4, 2);
            Include7.Name = "Include7";
            Include7.Size = new Size(102, 64);
            Include7.TabIndex = 160;
            Include7.Text = "포함";
            Include7.UseVisualStyleBackColor = false;
            Include7.Click += Include7_Click;
            // 
            // UnInclude7
            // 
            UnInclude7.BackColor = SystemColors.ButtonHighlight;
            UnInclude7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude7.Location = new Point(402, 87);
            UnInclude7.Margin = new Padding(4, 2, 4, 2);
            UnInclude7.Name = "UnInclude7";
            UnInclude7.Size = new Size(102, 64);
            UnInclude7.TabIndex = 159;
            UnInclude7.Text = "미포함";
            UnInclude7.UseVisualStyleBackColor = false;
            UnInclude7.Click += UnInclude7_Click;
            // 
            // Include1
            // 
            Include1.BackColor = SystemColors.ButtonHighlight;
            Include1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include1.Location = new Point(558, 484);
            Include1.Margin = new Padding(4, 2, 4, 2);
            Include1.Name = "Include1";
            Include1.Size = new Size(150, 47);
            Include1.TabIndex = 162;
            Include1.Text = "포함";
            Include1.UseVisualStyleBackColor = false;
            // 
            // UnInclude1
            // 
            UnInclude1.BackColor = SystemColors.ButtonHighlight;
            UnInclude1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude1.Location = new Point(558, 433);
            UnInclude1.Margin = new Padding(4, 2, 4, 2);
            UnInclude1.Name = "UnInclude1";
            UnInclude1.Size = new Size(150, 47);
            UnInclude1.TabIndex = 161;
            UnInclude1.Text = "미포함";
            UnInclude1.UseVisualStyleBackColor = false;
            // 
            // HW1
            // 
            HW1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW1.Location = new Point(328, 448);
            HW1.Margin = new Padding(4, 2, 4, 2);
            HW1.Name = "HW1";
            HW1.Size = new Size(116, 43);
            HW1.TabIndex = 163;
            HW1.TextAlign = HorizontalAlignment.Right;
            // 
            // Tax9_8
            // 
            Tax9_8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Tax9_8.Location = new Point(806, 109);
            Tax9_8.Margin = new Padding(4, 2, 4, 2);
            Tax9_8.Name = "Tax9_8";
            Tax9_8.Size = new Size(84, 41);
            Tax9_8.TabIndex = 166;
            Tax9_8.UseVisualStyleBackColor = true;
            Tax9_8.Click += Tax9_8_Click;
            // 
            // Tax3_3
            // 
            Tax3_3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Tax3_3.Location = new Point(714, 109);
            Tax3_3.Margin = new Padding(4, 2, 4, 2);
            Tax3_3.Name = "Tax3_3";
            Tax3_3.Size = new Size(84, 41);
            Tax3_3.TabIndex = 165;
            Tax3_3.UseVisualStyleBackColor = true;
            Tax3_3.Click += Txt3_3_Click;
            // 
            // NoTax
            // 
            NoTax.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            NoTax.Location = new Point(620, 109);
            NoTax.Margin = new Padding(4, 2, 4, 2);
            NoTax.Name = "NoTax";
            NoTax.Size = new Size(84, 41);
            NoTax.TabIndex = 164;
            NoTax.UseVisualStyleBackColor = true;
            NoTax.Click += NoTax_Click;
            // 
            // HW
            // 
            HW.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW.Location = new Point(244, 230);
            HW.Margin = new Padding(4, 2, 4, 2);
            HW.Name = "HW";
            HW.Size = new Size(146, 43);
            HW.TabIndex = 167;
            HW.TextAlign = HorizontalAlignment.Right;
            HW.TextChanged += HW_TextChanged;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.월_주;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1062, 733);
            Controls.Add(HW);
            Controls.Add(Tax9_8);
            Controls.Add(Tax3_3);
            Controls.Add(NoTax);
            Controls.Add(HW1);
            Controls.Add(Include1);
            Controls.Add(UnInclude1);
            Controls.Add(Include7);
            Controls.Add(UnInclude7);
            Controls.Add(button1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form13";
            Text = "Form13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button Include7;
        private Button UnInclude7;
        private Button Include1;
        private Button UnInclude1;
        private TextBox HW1;
        private Button Tax9_8;
        private Button Tax3_3;
        private Button NoTax;
        private TextBox HW;
    }
}