 using C__Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project
{
    public partial class Form11 : Form
    {
        // 시 -> 일
        private List<Button> unIncludeButtons;
        private List<Button> includeButtons;

        IButtonSystem bs;
        IHW chw;
        IHour hour;

        public Form11()
        {
            InitializeComponent();

            unIncludeButtons = new List<Button> { UnInclude1 };
            includeButtons = new List<Button> { Include1 };

            // 각 버튼에 대한 Click 이벤트 핸들러를 할당합니다.
            foreach (var button in unIncludeButtons) { button.Click += UnIncludeButton_Click; }
            foreach (var button in includeButtons) { button.Click += IncludeButton_Click; }

            bs = new ChangeButtonSystem(
                 new List<Button> { UnInclude1, UnInclude7 },
                 new List<Button> { Include1, Include7 },
                 new List<Button> { },
                 new List<Button> { },
                 new List<Button> { NoTax, Tax3_3, Tax9_8 }
            );

            chw = new ChangeHW(new List<TextBox> { HW1 });
            hour = new ChangeHour(new List<TextBox> { DH1 },
                   new List<TextBox> { }
            );

            NoTax.BackColor = SystemColors.GradientInactiveCaption;
            NoTax.Text = "선택";

            bs.UnIncludePbButtons();
            bs.UnIncludeHpButtons();
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double totalSalary = 0;

            double hourlyWage = 0;
            double dailyHours = 0;

            // HW1 텍스트 상자에서 시급을 입력받음
            if (!double.TryParse(HW1.Text, out hourlyWage))
            {
                MessageBox.Show("시급을 올바르게 입력하세요.");
                return;
            }

            // DH1 텍스트 상자에서 근무시간을 입력받음
            if (!double.TryParse(DH1.Text, out dailyHours))
            {
                MessageBox.Show("근무시간을 올바르게 입력하세요.");
                return;
            }

            // 시급을 일급으로 변환
            double dailyWage = hourlyWage * dailyHours;

            // 총 급여에 일급 추가
            totalSalary += dailyWage;

            if (((Button)this.Controls["Include" + 1]).BackColor == SystemColors.GradientInactiveCaption)
            {
                totalSalary *= 0.9; // 10% 감소
            }

            // 세금 적용
            if (Tax3_3.BackColor == SystemColors.GradientInactiveCaption)
            {
                totalSalary -= totalSalary * 0.033;
            }
            else if (Tax9_8.BackColor == SystemColors.GradientInactiveCaption)
            {
                totalSalary -= totalSalary * 0.094;
            }

            // 결과 출력
            Form20 form20 = new Form20();
            new TotalSalary(totalSalary);
            form20.ShowDialog();
        }



        // 전체 설정 영역
        private void Include7_Click(object sender, EventArgs e) { bs.IncludePbButtons(); }
        private void UnInclude7_Click(object sender, EventArgs e) { bs.UnIncludePbButtons(); }
        private void MHW_Click(object sender, EventArgs e) { chw.SettingHWs(); }
        private void HW_TextChanged(object sender, EventArgs e) { chw.CustomHW(HW.Text); }
        private void DH_TextChanged(object sender, EventArgs e) { hour.CustomDH(DH.Text); }
        private void NoTax_Click(object sender, EventArgs e) { bs.SetTaxButton(0); }
        private void Txt3_3_Click(object sender, EventArgs e) { bs.SetTaxButton(1); }
        private void Tax9_8_Click(object sender, EventArgs e) { bs.SetTaxButton(2); }


        // 개인 설정 영역


        private void UnIncludeButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (unIncludeButtons.Contains(clickedButton))
            {
                if (clickedButton.BackColor == SystemColors.ButtonHighlight)
                {
                    clickedButton.BackColor = SystemColors.GradientInactiveCaption;
                    int index = unIncludeButtons.IndexOf(clickedButton);
                    includeButtons[index].BackColor = SystemColors.ButtonHighlight;
                }
            }
        }

        private void IncludeButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null)
            {
                Console.WriteLine("Clicked button is null.");
                return;
            }
            Console.WriteLine($"Clicked Button: {clickedButton.Name}");

            if (includeButtons == null)
            {
                Console.WriteLine("Include buttons list is null.");
                return;
            }

            if (!includeButtons.Contains(clickedButton))
            {
                Console.WriteLine("Clicked button is not in include buttons list.");
                return;
            }

            int index = includeButtons.IndexOf(clickedButton);
            Console.WriteLine($"Index: {index}");

            // 인덱스가 유효한지 검사
            if (index < 0 || index >= unIncludeButtons.Count)
            {
                Console.WriteLine("Index is out of range.");
                return;
            }

            // Include8, Include9, Include10, Include11, Include12, Include13 버튼에 대해 조건 추가
            if (index >= 6 && index <= 11)
            {
                // dailyHours[i] * workingDays[i] >= 15 조건 확인
                int i = index - 6;
                double dailyHours;
                int workingDays;

                if (!double.TryParse(this.Controls["DH" + (i + 1)].Text, out dailyHours) ||
                    !int.TryParse(this.Controls["Day" + (i + 1)].Text, out workingDays) ||
                    dailyHours * workingDays < 15)
                {
                    MessageBox.Show("조건을 충족하지 않습니다.");
                    return;
                }
            }

            if (clickedButton.BackColor == SystemColors.ButtonHighlight)
            {
                clickedButton.BackColor = SystemColors.GradientInactiveCaption;
                if (index < unIncludeButtons.Count && unIncludeButtons[index] != null)
                {
                    unIncludeButtons[index].BackColor = SystemColors.ButtonHighlight;
                }
            }
        }
        // DH1~DH6 텍스트 박스의 TextChanged 이벤트 핸들러
        private void DH2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                double value;
                if (double.TryParse(textBox.Text, out value))
                {
                    if (value > 24)
                    {
                        MessageBox.Show("근무시간은 24시간 이하로 입력해주세요.");
                        textBox.Text = "24";
                    }
                }
                else
                {
                    MessageBox.Show("유효한 숫자를 입력해주세요.");
                    textBox.Text = "";
                }
            }
        }

    }
}
