namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int width = 200;
            int height = 40;
            int margin = 22;
            myButton.Text = "�ڵ忡�� ����!";
            myButton.Width = 200;

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Location = new Point(margin, (height + margin) * (i + 1) + margin);
                button.Text = "���� ���� " + i + "��°";
                button.Width = width;
                button.Height = height;
            }
        }
    }
}
