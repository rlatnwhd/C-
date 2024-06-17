namespace C__Project
{
    partial class Form4
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
            Include11 = new Button();
            UnInclude11 = new Button();
            Include10 = new Button();
            UnInclude10 = new Button();
            Include9 = new Button();
            UnInclude9 = new Button();
            Include8 = new Button();
            UnInclude8 = new Button();
            Include4 = new Button();
            UnInclude4 = new Button();
            Include3 = new Button();
            UnInclude3 = new Button();
            Include2 = new Button();
            UnInclude2 = new Button();
            Include1 = new Button();
            UnInclude1 = new Button();
            Tax9_8 = new Button();
            Tax3_3 = new Button();
            NoTax = new Button();
            AH4 = new TextBox();
            AH3 = new TextBox();
            AH2 = new TextBox();
            AH1 = new TextBox();
            Day4 = new TextBox();
            Day3 = new TextBox();
            DH4 = new TextBox();
            HW3 = new TextBox();
            DH3 = new TextBox();
            HW4 = new TextBox();
            DH2 = new TextBox();
            HW2 = new TextBox();
            Day2 = new TextBox();
            Day1 = new TextBox();
            DH1 = new TextBox();
            HW1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // AH
            // 
            AH.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            AH.Location = new Point(365, 103);
            AH.Margin = new Padding(2, 1, 2, 1);
            AH.Name = "AH";
            AH.Size = new Size(44, 25);
            AH.TabIndex = 236;
            AH.Text = "0";
            AH.TextAlign = HorizontalAlignment.Right;
            AH.TextChanged += AH_TextChanged;
            // 
            // Day
            // 
            Day.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            Day.Location = new Point(254, 103);
            Day.Margin = new Padding(2, 1, 2, 1);
            Day.Name = "Day";
            Day.Size = new Size(44, 25);
            Day.TabIndex = 235;
            Day.TextAlign = HorizontalAlignment.Right;
            Day.TextChanged += Day_TextChanged;
            // 
            // DH
            // 
            DH.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            DH.Location = new Point(133, 103);
            DH.Margin = new Padding(2, 1, 2, 1);
            DH.MaxLength = 24;
            DH.Name = "DH";
            DH.Size = new Size(44, 25);
            DH.TabIndex = 234;
            DH.TextAlign = HorizontalAlignment.Right;
            DH.TextChanged += DH_TextChanged;
            // 
            // MHW
            // 
            MHW.BackColor = SystemColors.ButtonHighlight;
            MHW.Font = new Font("맑은 고딕", 10F, FontStyle.Bold);
            MHW.Location = new Point(476, 42);
            MHW.Margin = new Padding(2, 1, 2, 1);
            MHW.Name = "MHW";
            MHW.Size = new Size(75, 22);
            MHW.TabIndex = 233;
            MHW.Text = "9,860";
            MHW.UseVisualStyleBackColor = false;
            MHW.Click += MHW_Click;
            // 
            // HW
            // 
            HW.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW.Location = new Point(352, 44);
            HW.Margin = new Padding(2, 1, 2, 1);
            HW.Name = "HW";
            HW.Size = new Size(75, 25);
            HW.TabIndex = 232;
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
            Include14.TabIndex = 231;
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
            UnInclude14.TabIndex = 230;
            UnInclude14.Text = "미포함";
            UnInclude14.UseVisualStyleBackColor = false;
            UnInclude14.Click += UnInclude14_Click;
            // 
            // Include7
            // 
            Include7.BackColor = SystemColors.ButtonHighlight;
            Include7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include7.Location = new Point(116, 40);
            Include7.Margin = new Padding(2, 1, 2, 1);
            Include7.Name = "Include7";
            Include7.Size = new Size(51, 30);
            Include7.TabIndex = 229;
            Include7.Text = "포함";
            Include7.UseVisualStyleBackColor = false;
            Include7.Click += Include7_Click;
            // 
            // UnInclude7
            // 
            UnInclude7.BackColor = SystemColors.ButtonHighlight;
            UnInclude7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude7.Location = new Point(170, 40);
            UnInclude7.Margin = new Padding(2, 1, 2, 1);
            UnInclude7.Name = "UnInclude7";
            UnInclude7.Size = new Size(51, 30);
            UnInclude7.TabIndex = 228;
            UnInclude7.Text = "미포함";
            UnInclude7.UseVisualStyleBackColor = false;
            UnInclude7.Click += UnInclude7_Click;
            // 
            // Include11
            // 
            Include11.BackColor = SystemColors.ButtonHighlight;
            Include11.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include11.Location = new Point(626, 429);
            Include11.Margin = new Padding(2, 1, 2, 1);
            Include11.Name = "Include11";
            Include11.Size = new Size(75, 22);
            Include11.TabIndex = 227;
            Include11.Text = "포함";
            Include11.UseVisualStyleBackColor = false;
            // 
            // UnInclude11
            // 
            UnInclude11.BackColor = SystemColors.ButtonHighlight;
            UnInclude11.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude11.Location = new Point(626, 405);
            UnInclude11.Margin = new Padding(2, 1, 2, 1);
            UnInclude11.Name = "UnInclude11";
            UnInclude11.Size = new Size(75, 22);
            UnInclude11.TabIndex = 226;
            UnInclude11.Text = "미포함";
            UnInclude11.UseVisualStyleBackColor = false;
            // 
            // Include10
            // 
            Include10.BackColor = SystemColors.ButtonHighlight;
            Include10.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include10.Location = new Point(626, 358);
            Include10.Margin = new Padding(2, 1, 2, 1);
            Include10.Name = "Include10";
            Include10.Size = new Size(75, 22);
            Include10.TabIndex = 225;
            Include10.Text = "포함";
            Include10.UseVisualStyleBackColor = false;
            // 
            // UnInclude10
            // 
            UnInclude10.BackColor = SystemColors.ButtonHighlight;
            UnInclude10.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude10.Location = new Point(626, 334);
            UnInclude10.Margin = new Padding(2, 1, 2, 1);
            UnInclude10.Name = "UnInclude10";
            UnInclude10.Size = new Size(75, 22);
            UnInclude10.TabIndex = 224;
            UnInclude10.Text = "미포함";
            UnInclude10.UseVisualStyleBackColor = false;
            // 
            // Include9
            // 
            Include9.BackColor = SystemColors.ButtonHighlight;
            Include9.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include9.Location = new Point(626, 290);
            Include9.Margin = new Padding(2, 1, 2, 1);
            Include9.Name = "Include9";
            Include9.Size = new Size(75, 22);
            Include9.TabIndex = 223;
            Include9.Text = "포함";
            Include9.UseVisualStyleBackColor = false;
            // 
            // UnInclude9
            // 
            UnInclude9.BackColor = SystemColors.ButtonHighlight;
            UnInclude9.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude9.Location = new Point(626, 265);
            UnInclude9.Margin = new Padding(2, 1, 2, 1);
            UnInclude9.Name = "UnInclude9";
            UnInclude9.Size = new Size(75, 22);
            UnInclude9.TabIndex = 222;
            UnInclude9.Text = "미포함";
            UnInclude9.UseVisualStyleBackColor = false;
            // 
            // Include8
            // 
            Include8.BackColor = SystemColors.ButtonHighlight;
            Include8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include8.Location = new Point(626, 224);
            Include8.Margin = new Padding(2, 1, 2, 1);
            Include8.Name = "Include8";
            Include8.Size = new Size(75, 22);
            Include8.TabIndex = 221;
            Include8.Text = "포함";
            Include8.UseVisualStyleBackColor = false;
            // 
            // UnInclude8
            // 
            UnInclude8.BackColor = SystemColors.ButtonHighlight;
            UnInclude8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude8.Location = new Point(626, 200);
            UnInclude8.Margin = new Padding(2, 1, 2, 1);
            UnInclude8.Name = "UnInclude8";
            UnInclude8.Size = new Size(75, 22);
            UnInclude8.TabIndex = 220;
            UnInclude8.Text = "미포함";
            UnInclude8.UseVisualStyleBackColor = false;
            // 
            // Include4
            // 
            Include4.BackColor = SystemColors.ButtonHighlight;
            Include4.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include4.Location = new Point(522, 429);
            Include4.Margin = new Padding(2, 1, 2, 1);
            Include4.Name = "Include4";
            Include4.Size = new Size(75, 22);
            Include4.TabIndex = 219;
            Include4.Text = "포함";
            Include4.UseVisualStyleBackColor = false;
            // 
            // UnInclude4
            // 
            UnInclude4.BackColor = SystemColors.ButtonHighlight;
            UnInclude4.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude4.Location = new Point(522, 405);
            UnInclude4.Margin = new Padding(2, 1, 2, 1);
            UnInclude4.Name = "UnInclude4";
            UnInclude4.Size = new Size(75, 22);
            UnInclude4.TabIndex = 218;
            UnInclude4.Text = "미포함";
            UnInclude4.UseVisualStyleBackColor = false;
            // 
            // Include3
            // 
            Include3.BackColor = SystemColors.ButtonHighlight;
            Include3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include3.Location = new Point(522, 358);
            Include3.Margin = new Padding(2, 1, 2, 1);
            Include3.Name = "Include3";
            Include3.Size = new Size(75, 22);
            Include3.TabIndex = 217;
            Include3.Text = "포함";
            Include3.UseVisualStyleBackColor = false;
            // 
            // UnInclude3
            // 
            UnInclude3.BackColor = SystemColors.ButtonHighlight;
            UnInclude3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude3.Location = new Point(522, 334);
            UnInclude3.Margin = new Padding(2, 1, 2, 1);
            UnInclude3.Name = "UnInclude3";
            UnInclude3.Size = new Size(75, 22);
            UnInclude3.TabIndex = 216;
            UnInclude3.Text = "미포함";
            UnInclude3.UseVisualStyleBackColor = false;
            // 
            // Include2
            // 
            Include2.BackColor = SystemColors.ButtonHighlight;
            Include2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include2.Location = new Point(522, 290);
            Include2.Margin = new Padding(2, 1, 2, 1);
            Include2.Name = "Include2";
            Include2.Size = new Size(75, 22);
            Include2.TabIndex = 215;
            Include2.Text = "포함";
            Include2.UseVisualStyleBackColor = false;
            // 
            // UnInclude2
            // 
            UnInclude2.BackColor = SystemColors.ButtonHighlight;
            UnInclude2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude2.Location = new Point(522, 265);
            UnInclude2.Margin = new Padding(2, 1, 2, 1);
            UnInclude2.Name = "UnInclude2";
            UnInclude2.Size = new Size(75, 22);
            UnInclude2.TabIndex = 214;
            UnInclude2.Text = "미포함";
            UnInclude2.UseVisualStyleBackColor = false;
            // 
            // Include1
            // 
            Include1.BackColor = SystemColors.ButtonHighlight;
            Include1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include1.Location = new Point(522, 224);
            Include1.Margin = new Padding(2, 1, 2, 1);
            Include1.Name = "Include1";
            Include1.Size = new Size(75, 22);
            Include1.TabIndex = 213;
            Include1.Text = "포함";
            Include1.UseVisualStyleBackColor = false;
            // 
            // UnInclude1
            // 
            UnInclude1.BackColor = SystemColors.ButtonHighlight;
            UnInclude1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude1.Location = new Point(522, 200);
            UnInclude1.Margin = new Padding(2, 1, 2, 1);
            UnInclude1.Name = "UnInclude1";
            UnInclude1.Size = new Size(75, 22);
            UnInclude1.TabIndex = 212;
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
            Tax9_8.TabIndex = 211;
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
            Tax3_3.TabIndex = 210;
            Tax3_3.UseVisualStyleBackColor = true;
            Tax3_3.Click += Txt3_3_Click;
            // 
            // NoTax
            // 
            NoTax.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            NoTax.Location = new Point(586, 52);
            NoTax.Margin = new Padding(2, 1, 2, 1);
            NoTax.Name = "NoTax";
            NoTax.Size = new Size(42, 19);
            NoTax.TabIndex = 209;
            NoTax.UseVisualStyleBackColor = true;
            NoTax.Click += NoTax_Click;
            // 
            // AH4
            // 
            AH4.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            AH4.Location = new Point(424, 414);
            AH4.Margin = new Padding(2, 1, 2, 1);
            AH4.Name = "AH4";
            AH4.Size = new Size(44, 25);
            AH4.TabIndex = 208;
            AH4.Text = "0";
            AH4.TextAlign = HorizontalAlignment.Right;
            // 
            // AH3
            // 
            AH3.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            AH3.Location = new Point(424, 347);
            AH3.Margin = new Padding(2, 1, 2, 1);
            AH3.Name = "AH3";
            AH3.Size = new Size(44, 25);
            AH3.TabIndex = 207;
            AH3.Text = "0";
            AH3.TextAlign = HorizontalAlignment.Right;
            // 
            // AH2
            // 
            AH2.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            AH2.Location = new Point(424, 278);
            AH2.Margin = new Padding(2, 1, 2, 1);
            AH2.Name = "AH2";
            AH2.Size = new Size(44, 25);
            AH2.TabIndex = 206;
            AH2.Text = "0";
            AH2.TextAlign = HorizontalAlignment.Right;
            // 
            // AH1
            // 
            AH1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            AH1.Location = new Point(424, 210);
            AH1.Margin = new Padding(2, 1, 2, 1);
            AH1.Name = "AH1";
            AH1.Size = new Size(44, 25);
            AH1.TabIndex = 205;
            AH1.Text = "0";
            AH1.TextAlign = HorizontalAlignment.Right;
            // 
            // Day4
            // 
            Day4.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            Day4.Location = new Point(329, 415);
            Day4.Margin = new Padding(2, 1, 2, 1);
            Day4.Name = "Day4";
            Day4.Size = new Size(44, 25);
            Day4.TabIndex = 204;
            Day4.TextAlign = HorizontalAlignment.Right;
            Day4.TextChanged += DH1_TextChanged;
            // 
            // Day3
            // 
            Day3.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            Day3.Location = new Point(329, 348);
            Day3.Margin = new Padding(2, 1, 2, 1);
            Day3.Name = "Day3";
            Day3.Size = new Size(44, 25);
            Day3.TabIndex = 203;
            Day3.TextAlign = HorizontalAlignment.Right;
            Day3.TextChanged += DH1_TextChanged;
            // 
            // DH4
            // 
            DH4.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            DH4.Location = new Point(214, 415);
            DH4.Margin = new Padding(2, 1, 2, 1);
            DH4.MaxLength = 24;
            DH4.Name = "DH4";
            DH4.Size = new Size(44, 25);
            DH4.TabIndex = 202;
            DH4.TextAlign = HorizontalAlignment.Right;
            DH4.TextChanged += DH2_TextChanged;
            // 
            // HW3
            // 
            HW3.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW3.Location = new Point(109, 347);
            HW3.Margin = new Padding(2, 1, 2, 1);
            HW3.Name = "HW3";
            HW3.Size = new Size(60, 25);
            HW3.TabIndex = 201;
            HW3.TextAlign = HorizontalAlignment.Right;
            // 
            // DH3
            // 
            DH3.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            DH3.Location = new Point(214, 348);
            DH3.Margin = new Padding(2, 1, 2, 1);
            DH3.MaxLength = 24;
            DH3.Name = "DH3";
            DH3.Size = new Size(44, 25);
            DH3.TabIndex = 200;
            DH3.TextAlign = HorizontalAlignment.Right;
            DH3.TextChanged += DH2_TextChanged;
            // 
            // HW4
            // 
            HW4.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW4.Location = new Point(109, 414);
            HW4.Margin = new Padding(2, 1, 2, 1);
            HW4.Name = "HW4";
            HW4.Size = new Size(60, 25);
            HW4.TabIndex = 199;
            HW4.TextAlign = HorizontalAlignment.Right;
            // 
            // DH2
            // 
            DH2.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            DH2.Location = new Point(214, 280);
            DH2.Margin = new Padding(2, 1, 2, 1);
            DH2.MaxLength = 24;
            DH2.Name = "DH2";
            DH2.Size = new Size(44, 25);
            DH2.TabIndex = 198;
            DH2.TextAlign = HorizontalAlignment.Right;
            DH2.TextChanged += DH2_TextChanged;
            // 
            // HW2
            // 
            HW2.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW2.Location = new Point(109, 278);
            HW2.Margin = new Padding(2, 1, 2, 1);
            HW2.Name = "HW2";
            HW2.Size = new Size(60, 25);
            HW2.TabIndex = 197;
            HW2.TextAlign = HorizontalAlignment.Right;
            // 
            // Day2
            // 
            Day2.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            Day2.Location = new Point(329, 278);
            Day2.Margin = new Padding(2, 1, 2, 1);
            Day2.Name = "Day2";
            Day2.Size = new Size(44, 25);
            Day2.TabIndex = 196;
            Day2.TextAlign = HorizontalAlignment.Right;
            Day2.TextChanged += DH1_TextChanged;
            // 
            // Day1
            // 
            Day1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            Day1.Location = new Point(329, 211);
            Day1.Margin = new Padding(2, 1, 2, 1);
            Day1.Name = "Day1";
            Day1.Size = new Size(44, 25);
            Day1.TabIndex = 195;
            Day1.TextAlign = HorizontalAlignment.Right;
            Day1.TextChanged += DH1_TextChanged;
            // 
            // DH1
            // 
            DH1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            DH1.Location = new Point(214, 211);
            DH1.Margin = new Padding(2, 1, 2, 1);
            DH1.MaxLength = 24;
            DH1.Name = "DH1";
            DH1.Size = new Size(44, 25);
            DH1.TabIndex = 194;
            DH1.TextAlign = HorizontalAlignment.Right;
            DH1.TextChanged += DH2_TextChanged;
            // 
            // HW1
            // 
            HW1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW1.Location = new Point(109, 210);
            HW1.Margin = new Padding(2, 1, 2, 1);
            HW1.Name = "HW1";
            HW1.Size = new Size(60, 25);
            HW1.TabIndex = 193;
            HW1.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(600, 488);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(122, 44);
            button1.TabIndex = 237;
            button1.Text = "급여 계산";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CalculateButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._4주_화면;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(748, 497);
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
            Controls.Add(Include11);
            Controls.Add(UnInclude11);
            Controls.Add(Include10);
            Controls.Add(UnInclude10);
            Controls.Add(Include9);
            Controls.Add(UnInclude9);
            Controls.Add(Include8);
            Controls.Add(UnInclude8);
            Controls.Add(Include4);
            Controls.Add(UnInclude4);
            Controls.Add(Include3);
            Controls.Add(UnInclude3);
            Controls.Add(Include2);
            Controls.Add(UnInclude2);
            Controls.Add(Include1);
            Controls.Add(UnInclude1);
            Controls.Add(Tax9_8);
            Controls.Add(Tax3_3);
            Controls.Add(NoTax);
            Controls.Add(AH4);
            Controls.Add(AH3);
            Controls.Add(AH2);
            Controls.Add(AH1);
            Controls.Add(Day4);
            Controls.Add(Day3);
            Controls.Add(DH4);
            Controls.Add(HW3);
            Controls.Add(DH3);
            Controls.Add(HW4);
            Controls.Add(DH2);
            Controls.Add(HW2);
            Controls.Add(Day2);
            Controls.Add(Day1);
            Controls.Add(DH1);
            Controls.Add(HW1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form4";
            Text = "Form4";
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
        private Button Include11;
        private Button UnInclude11;
        private Button Include10;
        private Button UnInclude10;
        private Button Include9;
        private Button UnInclude9;
        private Button Include8;
        private Button UnInclude8;
        private Button Include4;
        private Button UnInclude4;
        private Button Include3;
        private Button UnInclude3;
        private Button Include2;
        private Button UnInclude2;
        private Button Include1;
        private Button UnInclude1;
        private Button Tax9_8;
        private Button Tax3_3;
        private Button NoTax;
        private TextBox AH4;
        private TextBox AH3;
        private TextBox AH2;
        private TextBox AH1;
        private TextBox Day4;
        private TextBox Day3;
        private TextBox DH4;
        private TextBox HW3;
        private TextBox DH3;
        private TextBox HW4;
        private TextBox DH2;
        private TextBox HW2;
        private TextBox Day2;
        private TextBox Day1;
        private TextBox DH1;
        private TextBox HW1;
        private Button button1;
    }
}