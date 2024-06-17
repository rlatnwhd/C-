namespace C__Project
{
    partial class Form18
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
            HW = new TextBox();
            Tax9_8 = new Button();
            Tax3_3 = new Button();
            NoTax = new Button();
            Day = new TextBox();
            DH = new TextBox();
            Include7 = new Button();
            UnInclude7 = new Button();
            Include1 = new Button();
            UnInclude1 = new Button();
            Day1 = new TextBox();
            DH1 = new TextBox();
            HW1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // HW
            // 
            HW.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW.Location = new Point(270, 43);
            HW.Margin = new Padding(2, 1, 2, 1);
            HW.Name = "HW";
            HW.Size = new Size(75, 25);
            HW.TabIndex = 188;
            HW.TextAlign = HorizontalAlignment.Right;
            HW.TextChanged += HW_TextChanged;
            // 
            // Tax9_8
            // 
            Tax9_8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Tax9_8.Location = new Point(518, 51);
            Tax9_8.Margin = new Padding(2, 1, 2, 1);
            Tax9_8.Name = "Tax9_8";
            Tax9_8.Size = new Size(42, 19);
            Tax9_8.TabIndex = 187;
            Tax9_8.UseVisualStyleBackColor = true;
            Tax9_8.Click += Tax9_8_Click;
            // 
            // Tax3_3
            // 
            Tax3_3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Tax3_3.Location = new Point(472, 51);
            Tax3_3.Margin = new Padding(2, 1, 2, 1);
            Tax3_3.Name = "Tax3_3";
            Tax3_3.Size = new Size(42, 19);
            Tax3_3.TabIndex = 186;
            Tax3_3.UseVisualStyleBackColor = true;
            Tax3_3.Click += Txt3_3_Click;
            // 
            // NoTax
            // 
            NoTax.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            NoTax.Location = new Point(424, 51);
            NoTax.Margin = new Padding(2, 1, 2, 1);
            NoTax.Name = "NoTax";
            NoTax.Size = new Size(42, 19);
            NoTax.TabIndex = 185;
            NoTax.UseVisualStyleBackColor = true;
            NoTax.Click += NoTax_Click;
            // 
            // Day
            // 
            Day.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            Day.Location = new Point(251, 102);
            Day.Margin = new Padding(2, 1, 2, 1);
            Day.Name = "Day";
            Day.Size = new Size(44, 25);
            Day.TabIndex = 184;
            Day.TextAlign = HorizontalAlignment.Right;
            Day.TextChanged += Day_TextChanged;
            // 
            // DH
            // 
            DH.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            DH.Location = new Point(131, 102);
            DH.Margin = new Padding(2, 1, 2, 1);
            DH.MaxLength = 24;
            DH.Name = "DH";
            DH.Size = new Size(44, 25);
            DH.TabIndex = 183;
            DH.TextAlign = HorizontalAlignment.Right;
            DH.TextChanged += DH_TextChanged;
            // 
            // Include7
            // 
            Include7.BackColor = SystemColors.ButtonHighlight;
            Include7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include7.Location = new Point(130, 38);
            Include7.Margin = new Padding(2, 1, 2, 1);
            Include7.Name = "Include7";
            Include7.Size = new Size(51, 30);
            Include7.TabIndex = 182;
            Include7.Text = "포함";
            Include7.UseVisualStyleBackColor = false;
            // 
            // UnInclude7
            // 
            UnInclude7.BackColor = SystemColors.ButtonHighlight;
            UnInclude7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude7.Location = new Point(184, 38);
            UnInclude7.Margin = new Padding(2, 1, 2, 1);
            UnInclude7.Name = "UnInclude7";
            UnInclude7.Size = new Size(51, 30);
            UnInclude7.TabIndex = 181;
            UnInclude7.Text = "미포함";
            UnInclude7.UseVisualStyleBackColor = false;
            // 
            // Include1
            // 
            Include1.BackColor = SystemColors.ButtonHighlight;
            Include1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Include1.Location = new Point(434, 226);
            Include1.Margin = new Padding(2, 1, 2, 1);
            Include1.Name = "Include1";
            Include1.Size = new Size(75, 22);
            Include1.TabIndex = 180;
            Include1.Text = "포함";
            Include1.UseVisualStyleBackColor = false;
            // 
            // UnInclude1
            // 
            UnInclude1.BackColor = SystemColors.ButtonHighlight;
            UnInclude1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            UnInclude1.Location = new Point(434, 202);
            UnInclude1.Margin = new Padding(2, 1, 2, 1);
            UnInclude1.Name = "UnInclude1";
            UnInclude1.Size = new Size(75, 22);
            UnInclude1.TabIndex = 179;
            UnInclude1.Text = "미포함";
            UnInclude1.UseVisualStyleBackColor = false;
            // 
            // Day1
            // 
            Day1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            Day1.Location = new Point(340, 211);
            Day1.Margin = new Padding(2, 1, 2, 1);
            Day1.Name = "Day1";
            Day1.Size = new Size(44, 25);
            Day1.TabIndex = 178;
            Day1.TextAlign = HorizontalAlignment.Right;
            Day1.TextChanged += Day1_TextChanged;
            // 
            // DH1
            // 
            DH1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            DH1.Location = new Point(224, 211);
            DH1.Margin = new Padding(2, 1, 2, 1);
            DH1.MaxLength = 24;
            DH1.Name = "DH1";
            DH1.Size = new Size(44, 25);
            DH1.TabIndex = 177;
            DH1.TextAlign = HorizontalAlignment.Right;
            DH1.TextChanged += DH2_TextChanged;
            // 
            // HW1
            // 
            HW1.Font = new Font("맑은 고딕", 10.125F, FontStyle.Bold);
            HW1.Location = new Point(120, 210);
            HW1.Margin = new Padding(2, 1, 2, 1);
            HW1.Name = "HW1";
            HW1.Size = new Size(60, 25);
            HW1.TabIndex = 176;
            HW1.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(486, 293);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(122, 44);
            button1.TabIndex = 174;
            button1.Text = "급여 계산";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.일_시_002;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(630, 353);
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
            Name = "Form18";
            Text = "Form18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox HW;
        private Button Tax9_8;
        private Button Tax3_3;
        private Button NoTax;
        private TextBox Day;
        private TextBox DH;
        private Button Include7;
        private Button UnInclude7;
        private Button Include1;
        private Button UnInclude1;
        private TextBox Day1;
        private TextBox DH1;
        private TextBox HW1;
        private Button button1;
    }
}