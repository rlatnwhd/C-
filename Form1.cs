using System;
using System.Windows.Forms;
namespace C__Project
{
    public partial class Form1 : Form
    {
        string[] items = { "�ñ�", "�ϱ�", "�ֱ�", "����" };

        public Form1()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ������ ����Ʈ
            

            // ù ��° �޺��ڽ� ����
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(items);

            // �� ��° �޺��ڽ� ����
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.AddRange(items);

            // ù ��° �޺��ڽ� �⺻�� ����
            comboBox1.SelectedIndex = 0;


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ù ��° �޺��ڽ����� ���õ� �׸� ��������
            string selectedItem = comboBox1.SelectedItem.ToString();

            // �� ��° �޺��ڽ� ������Ʈ
            UpdateComboBox2Items(selectedItem);
        }

        private void UpdateComboBox2Items(string excludeItem)
        {
            // �� ��° �޺��ڽ� �ʱ�ȭ
            comboBox2.Items.Clear();

            // ���ܵ� �׸��� �����ϰ� ������ �߰�
            foreach (string item in items)
            {
                if (item != excludeItem)
                {
                    comboBox2.Items.Add(item);
                }
            }

            // �� ��° �޺��ڽ� �⺻�� ����
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();
            Form4 form4 = new Form4();
            Form5 form5 = new Form5();
            Form6 form6 = new Form6();
            Form7 form7 = new Form7();
            Form8 form8 = new Form8();
            Form9 form9 = new Form9();
            Form10 form10 = new Form10();
            Form11 form11 = new Form11();
            Form12 form12 = new Form12();
            Form13 form13 = new Form13();
            Form14 form14 = new Form14();
            Form15 form15 = new Form15();
            Form16 form16 = new Form16();
            Form17 form17 = new Form17();
            Form18 form18 = new Form18();
            Form19 form19 = new Form19();
            D_W dw = new D_W();

            // �� �޺��ڽ����� ���õ� �� ��������
            string selectedValue1 = comboBox1.SelectedItem.ToString();
            string selectedValue2 = comboBox2.SelectedItem.ToString();

            if (selectedValue1 == "�ñ�")
            {
                if (selectedValue2 == "�ϱ�") { form11.ShowDialog(); }
                else if (selectedValue2 == "�ֱ�") { form12.ShowDialog(); }
                else if (selectedValue2 == "����")
                {
                    form19.ShowDialog();
                    if (WeekCalculation.Weeks == 4) { form4.ShowDialog(); }
                    else if (WeekCalculation.Weeks == 5) { form3.ShowDialog(); }
                    else if (WeekCalculation.Weeks == 6) { form2.ShowDialog(); }
                    else { MessageBox.Show("�Է��� ��ҵǾ����ϴ�.", "�Է� ���", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else if (selectedValue1 == "�ϱ�")
            {
                if (selectedValue2 == "�ñ�") { form18.ShowDialog(); }
                else if (selectedValue2 == "�ֱ�") { dw.ShowDialog(); }
                else if (selectedValue2 == "����")
                {
                    form19.ShowDialog();
                    if (WeekCalculation.Weeks == 4) { form7.ShowDialog(); }
                    else if (WeekCalculation.Weeks == 5) { form6.ShowDialog(); }
                    else if (WeekCalculation.Weeks == 6) { form5.ShowDialog(); }
                    else { MessageBox.Show("�Է��� ��ҵǾ����ϴ�.", "�Է� ���", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else if (selectedValue1 == "�ֱ�")
            {
                if (selectedValue2 == "�ñ�") { form17.ShowDialog(); }
                else if (selectedValue2 == "�ϱ�") { form15.ShowDialog(); }
                else if (selectedValue2 == "����")
                {
                    form19.ShowDialog();
                    if (WeekCalculation.Weeks == 4) { form10.ShowDialog(); }
                    else if (WeekCalculation.Weeks == 5) { form9.ShowDialog(); }
                    else if (WeekCalculation.Weeks == 6) { form8.ShowDialog(); }
                    else { MessageBox.Show("�Է��� ��ҵǾ����ϴ�.", "�Է� ���", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else if (selectedValue1 == "����")
            {
                if (selectedValue2 == "�ñ�") { form16.ShowDialog(); }
                else if (selectedValue2 == "�ϱ�") { form14.ShowDialog(); }
                else if (selectedValue2 == "�ֱ�")
                {
                    form19.ShowDialog();
                    if (WeekCalculation.Weeks > 0) { form13.ShowDialog(); }
                    else { MessageBox.Show("�Է��� ��ҵǾ����ϴ�.", "�Է� ���", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }

        }
    }
}
