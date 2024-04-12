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
            myButton.Text = "코드에서 변경!";
            myButton.Width = 200;

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Location = new Point(margin, (height + margin) * (i + 1) + margin);
                button.Text = "동적 생성 " + i + "번째";
                button.Width = width;
                button.Height = height;
            }
        }
    }
}
