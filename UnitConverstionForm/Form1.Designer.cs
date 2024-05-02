namespace UnitConverstionForm
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Label label1;
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button2.Location = new Point(174, 65);
            button2.Name = "button2";
            button2.Size = new Size(478, 100);
            button2.TabIndex = 0;
            button2.Text = "단위 환산";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(174, 199);
            label2.Name = "label2";
            label2.Size = new Size(215, 54);
            label2.TabIndex = 1;
            label2.Text = "inch 입력 :";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("맑은 고딕", 15F);
            textBox2.Location = new Point(395, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 61);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(174, 284);
            label3.Name = "label3";
            label3.Size = new Size(349, 54);
            label3.TabIndex = 3;
            label3.Text = "inch to cm 결과 : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15F);
            label1.Location = new Point(511, 284);
            label1.Name = "label1";
            label1.Size = new Size(0, 54);
            label1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.Location = new Point(174, 369);
            label4.Name = "label4";
            label4.Size = new Size(179, 54);
            label4.TabIndex = 5;
            label4.Text = "0초 경과";
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 15F);
            label6.Location = new Point(511, 284);
            label6.Name = "label6";
            label6.Size = new Size(0, 54);
            label6.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 534);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button2);
            Name = "Form1";
            Text = "202395007 김수종";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
