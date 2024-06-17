using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;

            textBox1.Text = now.Year.ToString();
            textBox2.Text = now.Month.ToString();
            UpdateWeeks();
        }

        private void UpdateWeeks()
        {
            try
            {
                int year = int.Parse(textBox1.Text);
                int month = int.Parse(textBox2.Text);

                MonthWeek MW = new MonthWeek(0);
                int weeks = MW.GetWeeksInMonth(year, month);
                label2.Text = weeks.ToString();
            }
            catch (FormatException)
            {
                label2.Text = "0";
            }
            catch (Exception)
            {
                label2.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateWeeks();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateWeeks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 텍스트 박스가 비어 있는지 확인
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("연도와 월을 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 주 수가 0인지 확인
            if (label2.Text == "0")
            {
                MessageBox.Show("유효한 연도와 월을 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // `MonthWeek` 클래스의 생성자 호출
            int weeks = int.Parse(label2.Text);
            new MonthWeek(weeks);
            Close();
        }
    }
}
