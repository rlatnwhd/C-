namespace C__Project
{
    partial class D_W
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
            AH = new TextBox();
            Day = new TextBox();
            DH = new TextBox();
            HW = new TextBox();
            Include7 = new Button();
            UnInclude7 = new Button();
            Include1 = new Button();
            UnInclude1 = new Button();
            Tax9_8 = new Button();
            Tax3_3 = new Button();
            NoTax = new Button();
            AH1 = new TextBox();
            Day1 = new TextBox();
            DH1 = new TextBox();
            HW1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(1009, 600);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(244, 93);
            button1.TabIndex = 177;
            button1.Text = "급여 계산";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CalculateButton_Click;
            // 
            // AH
            // 
            AH.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            AH.Location = new Point(496, 87);
            AH.Margin = new Padding(4, 2, 4, 2);
            AH.Name = "AH";
            AH.Size = new Size(84, 43);
            AH.TabIndex = 175;
            AH.Text = "0";
            AH.TextAlign = HorizontalAlignment.Right;
            AH.TextChanged += AH_TextChanged;
            // 
            // Day
            // 
            Day.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            Day.Location = new Point(506, 219);
            Day.Margin = new Padding(4, 2, 4, 2);
            Day.Name = "Day";
            Day.Size = new Size(84, 43);
            Day.TabIndex = 174;
            Day.TextAlign = HorizontalAlignment.Right;
            Day.TextChanged += Day_TextChanged;
            // 
            // DH
            // 
            DH.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            DH.Location = new Point(264, 219);
            DH.Margin = new Padding(4, 2, 4, 2);
            DH.MaxLength = 24;
            DH.Name = "DH";
            DH.Size = new Size(84, 43);
            DH.TabIndex = 173;
            DH.TextAlign = HorizontalAlignment.Right;
            DH.TextChanged += DH_TextChanged;
            // 
            // HW
            // 
            HW.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW.Location = new Point(708, 93);
            HW.Margin = new Padding(4, 2, 4, 2);
            HW.Name = "HW";
            HW.Size = new Size(146, 43);
            HW.TabIndex = 171;
            HW.TextAlign = HorizontalAlignment.Right;
            HW.TextChanged += HW_TextChanged;
            // 
            // Include7
            // 
            Include7.BackColor = SystemColors.ButtonHighlight;
            Include7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include7.Location = new Point(234, 84);
            Include7.Margin = new Padding(4, 2, 4, 2);
            Include7.Name = "Include7";
            Include7.Size = new Size(102, 64);
            Include7.TabIndex = 168;
            Include7.Text = "포함";
            Include7.UseVisualStyleBackColor = false;
            Include7.Click += Include7_Click;
            // 
            // UnInclude7
            // 
            UnInclude7.BackColor = SystemColors.ButtonHighlight;
            UnInclude7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude7.Location = new Point(342, 84);
            UnInclude7.Margin = new Padding(4, 2, 4, 2);
            UnInclude7.Name = "UnInclude7";
            UnInclude7.Size = new Size(102, 64);
            UnInclude7.TabIndex = 167;
            UnInclude7.Text = "미포함";
            UnInclude7.UseVisualStyleBackColor = false;
            UnInclude7.Click += UnInclude7_Click;
            // 
            // Include1
            // 
            Include1.BackColor = SystemColors.ButtonHighlight;
            Include1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include1.Location = new Point(996, 482);
            Include1.Margin = new Padding(4, 2, 4, 2);
            Include1.Name = "Include1";
            Include1.Size = new Size(150, 47);
            Include1.TabIndex = 164;
            Include1.Text = "포함";
            Include1.UseVisualStyleBackColor = false;
            // 
            // UnInclude1
            // 
            UnInclude1.BackColor = SystemColors.ButtonHighlight;
            UnInclude1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude1.Location = new Point(996, 431);
            UnInclude1.Margin = new Padding(4, 2, 4, 2);
            UnInclude1.Name = "UnInclude1";
            UnInclude1.Size = new Size(150, 47);
            UnInclude1.TabIndex = 163;
            UnInclude1.Text = "미포함";
            UnInclude1.UseVisualStyleBackColor = false;
            // 
            // Tax9_8
            // 
            Tax9_8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Tax9_8.Location = new Point(1132, 112);
            Tax9_8.Margin = new Padding(4, 2, 4, 2);
            Tax9_8.Name = "Tax9_8";
            Tax9_8.Size = new Size(84, 41);
            Tax9_8.TabIndex = 162;
            Tax9_8.UseVisualStyleBackColor = true;
            Tax9_8.Click += Tax9_8_Click;
            // 
            // Tax3_3
            // 
            Tax3_3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Tax3_3.Location = new Point(1040, 112);
            Tax3_3.Margin = new Padding(4, 2, 4, 2);
            Tax3_3.Name = "Tax3_3";
            Tax3_3.Size = new Size(84, 41);
            Tax3_3.TabIndex = 161;
            Tax3_3.UseVisualStyleBackColor = true;
            Tax3_3.Click += Txt3_3_Click;
            // 
            // NoTax
            // 
            NoTax.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            NoTax.Location = new Point(946, 112);
            NoTax.Margin = new Padding(4, 2, 4, 2);
            NoTax.Name = "NoTax";
            NoTax.Size = new Size(84, 41);
            NoTax.TabIndex = 160;
            NoTax.UseVisualStyleBackColor = true;
            NoTax.Click += NoTax_Click;
            // 
            // AH1
            // 
            AH1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            AH1.Location = new Point(777, 451);
            AH1.Margin = new Padding(4, 2, 4, 2);
            AH1.Name = "AH1";
            AH1.Size = new Size(84, 43);
            AH1.TabIndex = 159;
            AH1.Text = "0";
            AH1.TextAlign = HorizontalAlignment.Right;
            // 
            // Day1
            // 
            Day1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            Day1.Location = new Point(589, 453);
            Day1.Margin = new Padding(4, 2, 4, 2);
            Day1.Name = "Day1";
            Day1.Size = new Size(84, 43);
            Day1.TabIndex = 158;
            Day1.TextAlign = HorizontalAlignment.Right;
            // 
            // DH1
            // 
            DH1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            DH1.Location = new Point(357, 453);
            DH1.Margin = new Padding(4, 2, 4, 2);
            DH1.MaxLength = 24;
            DH1.Name = "DH1";
            DH1.Size = new Size(84, 43);
            DH1.TabIndex = 157;
            DH1.TextAlign = HorizontalAlignment.Right;
            // 
            // HW1
            // 
            HW1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW1.Location = new Point(149, 451);
            HW1.Margin = new Padding(4, 2, 4, 2);
            HW1.Name = "HW1";
            HW1.Size = new Size(116, 43);
            HW1.TabIndex = 156;
            HW1.TextAlign = HorizontalAlignment.Right;
            // 
            // D_W
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.일_주;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1292, 723);
            Controls.Add(button1);
            Controls.Add(AH);
            Controls.Add(Day);
            Controls.Add(DH);
            Controls.Add(HW);
            Controls.Add(Include7);
            Controls.Add(UnInclude7);
            Controls.Add(Include1);
            Controls.Add(UnInclude1);
            Controls.Add(Tax9_8);
            Controls.Add(Tax3_3);
            Controls.Add(NoTax);
            Controls.Add(AH1);
            Controls.Add(Day1);
            Controls.Add(DH1);
            Controls.Add(HW1);
            Name = "D_W";
            Text = "D_W";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox AH;
        private TextBox Day;
        private TextBox DH;
        private TextBox HW;
        private Button Include7;
        private Button UnInclude7;
        private Button Include1;
        private Button UnInclude1;
        private Button Tax9_8;
        private Button Tax3_3;
        private Button NoTax;
        private TextBox AH1;
        private TextBox Day1;
        private TextBox DH1;
        private TextBox HW1;
    }
}