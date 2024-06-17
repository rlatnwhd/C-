using System;
using System.Windows.Forms;
namespace C__Project
{
    public partial class Form1 : Form
    {
        string[] items = { "시급", "일급", "주급", "월급" };

        public Form1()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 아이템 리스트
            

            // 첫 번째 콤보박스 설정
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(items);

            // 두 번째 콤보박스 설정
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.AddRange(items);

            // 첫 번째 콤보박스 기본값 설정
            comboBox1.SelectedIndex = 0;


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 첫 번째 콤보박스에서 선택된 항목 가져오기
            string selectedItem = comboBox1.SelectedItem.ToString();

            // 두 번째 콤보박스 업데이트
            UpdateComboBox2Items(selectedItem);
        }

        private void UpdateComboBox2Items(string excludeItem)
        {
            // 두 번째 콤보박스 초기화
            comboBox2.Items.Clear();

            // 제외된 항목을 제외하고 아이템 추가
            foreach (string item in items)
            {
                if (item != excludeItem)
                {
                    comboBox2.Items.Add(item);
                }
            }

            // 두 번째 콤보박스 기본값 설정
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

            // 두 콤보박스에서 선택된 값 가져오기
            string selectedValue1 = comboBox1.SelectedItem.ToString();
            string selectedValue2 = comboBox2.SelectedItem.ToString();

            if (selectedValue1 == "시급")
            {
                if (selectedValue2 == "일급") { form11.ShowDialog(); }
                else if (selectedValue2 == "주급") { form12.ShowDialog(); }
                else if (selectedValue2 == "월급")
                {
                    form19.ShowDialog();
                    if (WeekCalculation.Weeks == 4) { form4.ShowDialog(); }
                    else if (WeekCalculation.Weeks == 5) { form3.ShowDialog(); }
                    else if (WeekCalculation.Weeks == 6) { form2.ShowDialog(); }
                    else { MessageBox.Show("입력이 취소되었습니다.", "입력 취소", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else if (selectedValue1 == "일급")
            {
                if (selectedValue2 == "시급") { form18.ShowDialog(); }
                else if (selectedValue2 == "주급") { dw.ShowDialog(); }
                else if (selectedValue2 == "월급")
                {
                    form19.ShowDialog();
                    if (WeekCalculation.Weeks == 4) { form7.ShowDialog(); }
                    else if (WeekCalculation.Weeks == 5) { form6.ShowDialog(); }
                    else if (WeekCalculation.Weeks == 6) { form5.ShowDialog(); }
                    else { MessageBox.Show("입력이 취소되었습니다.", "입력 취소", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else if (selectedValue1 == "주급")
            {
                if (selectedValue2 == "시급") { form17.ShowDialog(); }
                else if (selectedValue2 == "일급") { form15.ShowDialog(); }
                else if (selectedValue2 == "월급")
                {
                    form19.ShowDialog();
                    if (WeekCalculation.Weeks == 4) { form10.ShowDialog(); }
                    else if (WeekCalculation.Weeks == 5) { form9.ShowDialog(); }
                    else if (WeekCalculation.Weeks == 6) { form8.ShowDialog(); }
                    else { MessageBox.Show("입력이 취소되었습니다.", "입력 취소", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else if (selectedValue1 == "월급")
            {
                if (selectedValue2 == "시급") { form16.ShowDialog(); }
                else if (selectedValue2 == "일급") { form14.ShowDialog(); }
                else if (selectedValue2 == "주급")
                {
                    form19.ShowDialog();
                    if (WeekCalculation.Weeks > 0) { form13.ShowDialog(); }
                    else { MessageBox.Show("입력이 취소되었습니다.", "입력 취소", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }

        }
    }
}
