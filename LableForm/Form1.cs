using System.Collections.Generic;

namespace LableForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Size = new Size(900, 800);
            Text = "이거보세요!!";

            int height = 50;
            int width = 300;
            int margin = 10;

            GroupBox groupBox1 = new GroupBox()
            {
                Text = "족발",
                Location = new Point(margin, margin * 33),
                Size = new Size(width + margin * 2, height * 3 + margin * 2)
            };

            GroupBox groupBox2 = new GroupBox()
            {
                Text = "사이드",
                Location = new Point(margin * 5 + width, margin * 33),
                Size = new Size(width + margin * 2, height * 3 + margin * 2)
            };

            CheckBox checkBox1 = new CheckBox()
            {
                Text = "혼자",
                Width = width,
                Height = height,
                Location = new Point(20, height * 0 + margin * 10)
            };

            CheckBox checkBox2 = new CheckBox()
            {
                Text = "다수",
                Width = width,
                Height = height,
                Location = new Point(20, height * 1 + margin * 10)
            };

            CheckBox checkBox3 = new CheckBox()
            {
                Text = "대기",
                Width = width,
                Height = height,
                Location = new Point(20, height * 2 + margin * 10)
            };

            Button button2 = new Button()
            {
                Text = "이렇게! 딸깍!",
                Width = width,
                Height = height,
                Location = new Point(20, height * 4 + margin * 10 - 50)
            };

            RadioButton radioButton1 = new RadioButton()
            {
                Text = "냉족발",
                Width = width,
                Height = height,
                Location = new Point(20, height * 1 + margin)
            };

            RadioButton radioButton2 = new RadioButton()
            {
                Text = "불족발",
                Width = width,
                Height = height,
                Location = new Point(20, height * 2 + margin)
            };

            RadioButton radioButton3 = new RadioButton()
            {
                Text = "막국수",
                Width = width,
                Height = height,
                Location = new Point(20, height * 1 + margin)
            };

            RadioButton radioButton4 = new RadioButton()
            {
                Text = "해파리",
                Width = width,
                Height = height,
                Location = new Point(20, height * 2 + margin)
            };

            Button button = new Button()
            {
                Text = "이렇게!!! 딸깍!!!",
                Width = width,
                Height = height,
                Location = new Point(20, height * 4 + margin * 33)
            };

            Label label = new Label()
            {
                Text = "족발",
                Location = new Point(20, 10),
                Height = height - 23
            };

            LinkLabel linkLabel = new LinkLabel()
            {
                Text = "장충동",
                Location = new Point(20, 50),
                Height = height
            };

            button.Click += ButtonClick;
            button2.Click += ButtonClick2;

            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);

            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);

            label.Click += LabelClick;
            linkLabel.Click += LabelClick2;

            Controls.Add(label);
            Controls.Add(linkLabel);

            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(button);
            Controls.Add(button2);
        }

        private void ButtonClick(object? sender, EventArgs e)
        {

            List<string> list = new List<string>();
            foreach (var outeritem in Controls)
            {
                if (outeritem is GroupBox)
                {
                    foreach (var inneritem in ((GroupBox)outeritem).Controls)
                    {
                        RadioButton radioButton = inneritem as RadioButton;
                        if(radioButton != null && radioButton.Checked)
                        {
                            list.Add(radioButton.Text);
                        }
                    }
                }
            }

            MessageBox.Show(string.Join(",", list) + " 주문이요~~");
        }

        private void ButtonClick2(object? sender, EventArgs e)
        {

            List<string> list = new List<string>();
            foreach (var item in Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    if (checkBox.Checked) { list.Add(checkBox.Text); }
                }
            }

            MessageBox.Show(string.Join(",", list) + " 주문이요~~");
        }



        private void LabelClick(object? sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"", "https://youtu.be/94SSOpQWgrY?feature=shared");
        }

        private void LabelClick2(object? sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
