namespace UnitConverstionForm
{
    public partial class Form1 : Form
    {
        private int elapsedTime = 0;
        private double cm = 2.54;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "���� Ŭ���߽��ϴ�!";
            double num = double.Parse(textBox2.Text);
            num *= cm;
            label6.Text = num.ToString("0.00" + "cm");
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            label4.Text = elapsedTime + "�� ���";
        }

    }
}
