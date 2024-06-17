namespace C__Project
{
    partial class Form12
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
            AH = new TextBox();
            Day = new TextBox();
            DH = new TextBox();
            MHW = new Button();
            HW = new TextBox();
            Include14 = new Button();
            UnInclude14 = new Button();
            Include7 = new Button();
            UnInclude7 = new Button();
            Include8 = new Button();
            UnInclude8 = new Button();
            Include1 = new Button();
            UnInclude1 = new Button();
            Tax9_8 = new Button();
            Tax3_3 = new Button();
            NoTax = new Button();
            AH1 = new TextBox();
            Day1 = new TextBox();
            DH1 = new TextBox();
            HW1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // AH
            // 
            AH.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            AH.Location = new Point(366, 104);
            AH.Margin = new Padding(2, 1, 2, 1);
            AH.Name = "AH";
            AH.Size = new Size(44, 25);
            AH.TabIndex = 152;
            AH.Text = "0";
            AH.TextAlign = HorizontalAlignment.Right;
            AH.TextChanged += AH_TextChanged;
            // 
            // Day
            // 
            Day.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            Day.Location = new Point(256, 104);
            Day.Margin = new Padding(2, 1, 2, 1);
            Day.Name = "Day";
            Day.Size = new Size(44, 25);
            Day.TabIndex = 151;
            Day.TextAlign = HorizontalAlignment.Right;
            Day.TextChanged += Day_TextChanged;
            // 
            // DH
            // 
            DH.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            DH.Location = new Point(134, 104);
            DH.Margin = new Padding(2, 1, 2, 1);
            DH.MaxLength = 24;
            DH.Name = "DH";
            DH.Size = new Size(44, 25);
            DH.TabIndex = 150;
            DH.TextAlign = HorizontalAlignment.Right;
            DH.TextChanged += DH_TextChanged;
            // 
            // MHW
            // 
            MHW.BackColor = SystemColors.ButtonHighlight;
            MHW.Font = new Font("맑은 고딕", 10F, FontStyle.Bold);
            MHW.Location = new Point(476, 43);
            MHW.Margin = new Padding(2, 1, 2, 1);
            MHW.Name = "MHW";
            MHW.Size = new Size(75, 22);
            MHW.TabIndex = 149;
            MHW.Text = "9,860";
            MHW.UseVisualStyleBackColor = false;
            MHW.Click += MHW_Click;
            // 
            // HW
            // 
            HW.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW.Location = new Point(354, 45);
            HW.Margin = new Padding(2, 1, 2, 1);
            HW.Name = "HW";
            HW.Size = new Size(75, 25);
            HW.TabIndex = 148;
            HW.TextAlign = HorizontalAlignment.Right;
            HW.TextChanged += HW_TextChanged;
            // 
            // Include14
            // 
            Include14.BackColor = SystemColors.ButtonHighlight;
            Include14.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include14.Location = new Point(230, 40);
            Include14.Margin = new Padding(2, 1, 2, 1);
            Include14.Name = "Include14";
            Include14.Size = new Size(51, 30);
            Include14.TabIndex = 147;
            Include14.Text = "포함";
            Include14.UseVisualStyleBackColor = false;
            Include14.Click += Include14_Click;
            // 
            // UnInclude14
            // 
            UnInclude14.BackColor = SystemColors.ButtonHighlight;
            UnInclude14.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude14.Location = new Point(284, 40);
            UnInclude14.Margin = new Padding(2, 1, 2, 1);
            UnInclude14.Name = "UnInclude14";
            UnInclude14.Size = new Size(51, 30);
            UnInclude14.TabIndex = 146;
            UnInclude14.Text = "미포함";
            UnInclude14.UseVisualStyleBackColor = false;
            UnInclude14.Click += UnInclude14_Click;
            // 
            // Include7
            // 
            Include7.BackColor = SystemColors.ButtonHighlight;
            Include7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include7.Location = new Point(118, 40);
            Include7.Margin = new Padding(2, 1, 2, 1);
            Include7.Name = "Include7";
            Include7.Size = new Size(51, 30);
            Include7.TabIndex = 145;
            Include7.Text = "포함";
            Include7.UseVisualStyleBackColor = false;
            Include7.Click += Include7_Click;
            // 
            // UnInclude7
            // 
            UnInclude7.BackColor = SystemColors.ButtonHighlight;
            UnInclude7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude7.Location = new Point(172, 40);
            UnInclude7.Margin = new Padding(2, 1, 2, 1);
            UnInclude7.Name = "UnInclude7";
            UnInclude7.Size = new Size(51, 30);
            UnInclude7.TabIndex = 144;
            UnInclude7.Text = "미포함";
            UnInclude7.UseVisualStyleBackColor = false;
            UnInclude7.Click += UnInclude7_Click;
            // 
            // Include8
            // 
            Include8.BackColor = SystemColors.ButtonHighlight;
            Include8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include8.Location = new Point(606, 225);
            Include8.Margin = new Padding(2, 1, 2, 1);
            Include8.Name = "Include8";
            Include8.Size = new Size(75, 22);
            Include8.TabIndex = 143;
            Include8.Text = "포함";
            Include8.UseVisualStyleBackColor = false;
            // 
            // UnInclude8
            // 
            UnInclude8.BackColor = SystemColors.ButtonHighlight;
            UnInclude8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude8.Location = new Point(606, 201);
            UnInclude8.Margin = new Padding(2, 1, 2, 1);
            UnInclude8.Name = "UnInclude8";
            UnInclude8.Size = new Size(75, 22);
            UnInclude8.TabIndex = 142;
            UnInclude8.Text = "미포함";
            UnInclude8.UseVisualStyleBackColor = false;
            // 
            // Include1
            // 
            Include1.BackColor = SystemColors.ButtonHighlight;
            Include1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include1.Location = new Point(492, 225);
            Include1.Margin = new Padding(2, 1, 2, 1);
            Include1.Name = "Include1";
            Include1.Size = new Size(75, 22);
            Include1.TabIndex = 141;
            Include1.Text = "포함";
            Include1.UseVisualStyleBackColor = false;
            // 
            // UnInclude1
            // 
            UnInclude1.BackColor = SystemColors.ButtonHighlight;
            UnInclude1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude1.Location = new Point(492, 201);
            UnInclude1.Margin = new Padding(2, 1, 2, 1);
            UnInclude1.Name = "UnInclude1";
            UnInclude1.Size = new Size(75, 22);
            UnInclude1.TabIndex = 140;
            UnInclude1.Text = "미포함";
            UnInclude1.UseVisualStyleBackColor = false;
            // 
            // Tax9_8
            // 
            Tax9_8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Tax9_8.Location = new Point(680, 52);
            Tax9_8.Margin = new Padding(2, 1, 2, 1);
            Tax9_8.Name = "Tax9_8";
            Tax9_8.Size = new Size(42, 19);
            Tax9_8.TabIndex = 139;
            Tax9_8.UseVisualStyleBackColor = true;
            Tax9_8.Click += Tax9_8_Click;
            // 
            // Tax3_3
            // 
            Tax3_3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Tax3_3.Location = new Point(634, 52);
            Tax3_3.Margin = new Padding(2, 1, 2, 1);
            Tax3_3.Name = "Tax3_3";
            Tax3_3.Size = new Size(42, 19);
            Tax3_3.TabIndex = 138;
            Tax3_3.UseVisualStyleBackColor = true;
            Tax3_3.Click += Txt3_3_Click;
            // 
            // NoTax
            // 
            NoTax.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            NoTax.Location = new Point(588, 52);
            NoTax.Margin = new Padding(2, 1, 2, 1);
            NoTax.Name = "NoTax";
            NoTax.Size = new Size(42, 19);
            NoTax.TabIndex = 137;
            NoTax.UseVisualStyleBackColor = true;
            NoTax.Click += NoTax_Click;
            // 
            // AH1
            // 
            AH1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            AH1.Location = new Point(383, 210);
            AH1.Margin = new Padding(2, 1, 2, 1);
            AH1.Name = "AH1";
            AH1.Size = new Size(44, 25);
            AH1.TabIndex = 136;
            AH1.Text = "0";
            AH1.TextAlign = HorizontalAlignment.Right;
            // 
            // Day1
            // 
            Day1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            Day1.Location = new Point(289, 211);
            Day1.Margin = new Padding(2, 1, 2, 1);
            Day1.Name = "Day1";
            Day1.Size = new Size(44, 25);
            Day1.TabIndex = 135;
            Day1.TextAlign = HorizontalAlignment.Right;
            Day1.TextChanged += Day1_TextChanged;
            // 
            // DH1
            // 
            DH1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            DH1.Location = new Point(173, 211);
            DH1.Margin = new Padding(2, 1, 2, 1);
            DH1.MaxLength = 24;
            DH1.Name = "DH1";
            DH1.Size = new Size(44, 25);
            DH1.TabIndex = 134;
            DH1.TextAlign = HorizontalAlignment.Right;
            DH1.TextChanged += DH2_TextChanged;
            // 
            // HW1
            // 
            HW1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW1.Location = new Point(69, 210);
            HW1.Margin = new Padding(2, 1, 2, 1);
            HW1.Name = "HW1";
            HW1.Size = new Size(60, 25);
            HW1.TabIndex = 133;
            HW1.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(606, 280);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(122, 44);
            button1.TabIndex = 154;
            button1.Text = "급여 계산";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CalculateButton_Click;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.시_주;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(743, 334);
            Controls.Add(button1);
            Controls.Add(AH);
            Controls.Add(Day);
            Controls.Add(DH);
            Controls.Add(MHW);
            Controls.Add(HW);
            Controls.Add(Include14);
            Controls.Add(UnInclude14);
            Controls.Add(Include7);
            Controls.Add(UnInclude7);
            Controls.Add(Include8);
            Controls.Add(UnInclude8);
            Controls.Add(Include1);
            Controls.Add(UnInclude1);
            Controls.Add(Tax9_8);
            Controls.Add(Tax3_3);
            Controls.Add(NoTax);
            Controls.Add(AH1);
            Controls.Add(Day1);
            Controls.Add(DH1);
            Controls.Add(HW1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form12";
            Text = "Form12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AH;
        private TextBox Day;
        private TextBox DH;
        private Button MHW;
        private TextBox HW;
        private Button Include14;
        private Button UnInclude14;
        private Button Include7;
        private Button UnInclude7;
        private Button Include8;
        private Button UnInclude8;
        private Button Include1;
        private Button UnInclude1;
        private Button Tax9_8;
        private Button Tax3_3;
        private Button NoTax;
        private TextBox AH1;
        private TextBox Day1;
        private TextBox DH1;
        private TextBox HW1;
        private Button button1;
    }
}