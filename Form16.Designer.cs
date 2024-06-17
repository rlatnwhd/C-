namespace C__Project
{
    partial class Form16
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
            Day1 = new TextBox();
            DH1 = new TextBox();
            HW1 = new TextBox();
            Include1 = new Button();
            UnInclude1 = new Button();
            DH = new TextBox();
            Include7 = new Button();
            UnInclude7 = new Button();
            Day = new TextBox();
            Tax9_8 = new Button();
            Tax3_3 = new Button();
            NoTax = new Button();
            HW = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(487, 293);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(122, 44);
            button1.TabIndex = 157;
            button1.Text = "급여 계산";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CalculateButton_Click;
            // 
            // Day1
            // 
            Day1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            Day1.Location = new Point(342, 211);
            Day1.Margin = new Padding(2, 1, 2, 1);
            Day1.Name = "Day1";
            Day1.Size = new Size(44, 25);
            Day1.TabIndex = 161;
            Day1.TextAlign = HorizontalAlignment.Right;
            Day1.TextChanged += Day1_TextChanged;
            // 
            // DH1
            // 
            DH1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            DH1.Location = new Point(226, 211);
            DH1.Margin = new Padding(2, 1, 2, 1);
            DH1.MaxLength = 24;
            DH1.Name = "DH1";
            DH1.Size = new Size(44, 25);
            DH1.TabIndex = 160;
            DH1.TextAlign = HorizontalAlignment.Right;
            DH1.TextChanged += DH2_TextChanged;
            // 
            // HW1
            // 
            HW1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW1.Location = new Point(122, 210);
            HW1.Margin = new Padding(2, 1, 2, 1);
            HW1.Name = "HW1";
            HW1.Size = new Size(60, 25);
            HW1.TabIndex = 159;
            HW1.TextAlign = HorizontalAlignment.Right;
            // 
            // Include1
            // 
            Include1.BackColor = SystemColors.ButtonHighlight;
            Include1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include1.Location = new Point(436, 227);
            Include1.Margin = new Padding(2, 1, 2, 1);
            Include1.Name = "Include1";
            Include1.Size = new Size(75, 22);
            Include1.TabIndex = 163;
            Include1.Text = "포함";
            Include1.UseVisualStyleBackColor = false;
            // 
            // UnInclude1
            // 
            UnInclude1.BackColor = SystemColors.ButtonHighlight;
            UnInclude1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude1.Location = new Point(436, 203);
            UnInclude1.Margin = new Padding(2, 1, 2, 1);
            UnInclude1.Name = "UnInclude1";
            UnInclude1.Size = new Size(75, 22);
            UnInclude1.TabIndex = 162;
            UnInclude1.Text = "미포함";
            UnInclude1.UseVisualStyleBackColor = false;
            // 
            // DH
            // 
            DH.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            DH.Location = new Point(133, 103);
            DH.Margin = new Padding(2, 1, 2, 1);
            DH.MaxLength = 24;
            DH.Name = "DH";
            DH.Size = new Size(44, 25);
            DH.TabIndex = 166;
            DH.TextAlign = HorizontalAlignment.Right;
            DH.TextChanged += DH_TextChanged;
            // 
            // Include7
            // 
            Include7.BackColor = SystemColors.ButtonHighlight;
            Include7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include7.Location = new Point(132, 38);
            Include7.Margin = new Padding(2, 1, 2, 1);
            Include7.Name = "Include7";
            Include7.Size = new Size(51, 30);
            Include7.TabIndex = 165;
            Include7.Text = "포함";
            Include7.UseVisualStyleBackColor = false;
            Include7.Click += Include7_Click;
            // 
            // UnInclude7
            // 
            UnInclude7.BackColor = SystemColors.ButtonHighlight;
            UnInclude7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude7.Location = new Point(186, 38);
            UnInclude7.Margin = new Padding(2, 1, 2, 1);
            UnInclude7.Name = "UnInclude7";
            UnInclude7.Size = new Size(51, 30);
            UnInclude7.TabIndex = 164;
            UnInclude7.Text = "미포함";
            UnInclude7.UseVisualStyleBackColor = false;
            UnInclude7.Click += UnInclude7_Click;
            // 
            // Day
            // 
            Day.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            Day.Location = new Point(253, 103);
            Day.Margin = new Padding(2, 1, 2, 1);
            Day.Name = "Day";
            Day.Size = new Size(44, 25);
            Day.TabIndex = 167;
            Day.TextAlign = HorizontalAlignment.Right;
            Day.TextChanged += Day_TextChanged;
            // 
            // Tax9_8
            // 
            Tax9_8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Tax9_8.Location = new Point(520, 52);
            Tax9_8.Margin = new Padding(2, 1, 2, 1);
            Tax9_8.Name = "Tax9_8";
            Tax9_8.Size = new Size(42, 19);
            Tax9_8.TabIndex = 171;
            Tax9_8.UseVisualStyleBackColor = true;
            Tax9_8.Click += Tax9_8_Click;
            // 
            // Tax3_3
            // 
            Tax3_3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Tax3_3.Location = new Point(474, 52);
            Tax3_3.Margin = new Padding(2, 1, 2, 1);
            Tax3_3.Name = "Tax3_3";
            Tax3_3.Size = new Size(42, 19);
            Tax3_3.TabIndex = 170;
            Tax3_3.UseVisualStyleBackColor = true;
            Tax3_3.Click += Txt3_3_Click;
            // 
            // NoTax
            // 
            NoTax.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            NoTax.Location = new Point(426, 52);
            NoTax.Margin = new Padding(2, 1, 2, 1);
            NoTax.Name = "NoTax";
            NoTax.Size = new Size(42, 19);
            NoTax.TabIndex = 169;
            NoTax.UseVisualStyleBackColor = true;
            NoTax.Click += NoTax_Click;
            // 
            // HW
            // 
            HW.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW.Location = new Point(272, 43);
            HW.Margin = new Padding(2, 1, 2, 1);
            HW.Name = "HW";
            HW.Size = new Size(75, 25);
            HW.TabIndex = 172;
            HW.TextAlign = HorizontalAlignment.Right;
            HW.TextChanged += HW_TextChanged;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.월_시_002;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(624, 352);
            Controls.Add(HW);
            Controls.Add(Tax9_8);
            Controls.Add(Tax3_3);
            Controls.Add(NoTax);
            Controls.Add(Day);
            Controls.Add(DH);
            Controls.Add(Include7);
            Controls.Add(UnInclude7);
            Controls.Add(Include1);
            Controls.Add(UnInclude1);
            Controls.Add(Day1);
            Controls.Add(DH1);
            Controls.Add(HW1);
            Controls.Add(button1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form16";
            Text = "ㅍ";
            Load += Form16_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox Day1;
        private TextBox DH1;
        private TextBox HW1;
        private Button Include1;
        private Button UnInclude1;
        private TextBox DH;
        private Button Include7;
        private Button UnInclude7;
        private TextBox Day;
        private Button Tax9_8;
        private Button Tax3_3;
        private Button NoTax;
        private TextBox HW;
    }
}