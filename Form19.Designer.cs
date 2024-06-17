namespace C__Project
{
    partial class Form19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox1.Location = new Point(433, 646);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 57);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox2.Location = new Point(433, 748);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 57);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.메인_버튼;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(298, 1058);
            button2.Name = "button2";
            button2.Size = new Size(447, 131);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("휴먼둥근헤드라인", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(341, 921);
            label2.Name = "label2";
            label2.Size = new Size(57, 50);
            label2.TabIndex = 5;
            label2.Text = "0";
            // 
            // Form19
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1058, 1223);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form19";
            Text = "Form19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label2;
    }
}