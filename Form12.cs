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
    public partial class Form12 : Form
    {
        // 시 -> 주
        private List<Button> unIncludeButtons;
        private List<Button> includeButtons;

        IButtonSystem bs;
        IHW chw;
        IHour hour;

        public Form12()
        {
            InitializeComponent();

            unIncludeButtons = new List<Button> { UnInclude1, UnInclude8 };
            includeButtons = new List<Button> { Include1, Include8, Include14 };

            // 각 버튼에 대한 Click 이벤트 핸들러를 할당합니다.
            foreach (var button in unIncludeButtons) { button.Click += UnIncludeButton_Click; }
            foreach (var button in includeButtons) { button.Click += IncludeButton_Click; }

            bs = new ChangeButtonSystem(
                 new List<Button> { UnInclude1, UnInclude7 },
                 new List<Button> { Include1, Include7 },
                 new List<Button> { UnInclude8, UnInclude14 },
                 new List<Button> { Include8, Include14 },
                 new List<Button> { NoTax, Tax3_3, Tax9_8 }
            );

            chw = new ChangeHW(new List<TextBox> { HW1 });
            hour = new ChangeHour(new List<TextBox> { AH1 },
                   new List<TextBox> { DH1 },
                   new List<TextBox> { Day1 }
            );

            NoTax.BackColor = SystemColors.GradientInactiveCaption;
            NoTax.Text = "선택";

            bs.UnIncludePbButtons();
            bs.UnIncludeHpButtons();
        }
        private void CheckIncludeButtons()
        {

            // Controls 컬렉션에서 컨트롤을 가져옵니다.
            Control dhControl = this.Controls["DH" + (1)];
            Control dayControl = this.Controls["Day" + (1)];


            // 조건을 만족하는지 확인합니다.
            double dailyHours;
            int workingDays;

            if (!double.TryParse(DH1.Text, out dailyHours) ||
                !int.TryParse(Day1.Text, out workingDays) ||
                dailyHours * workingDays < 15)
            {
                unIncludeButtons[1].BackColor = SystemColors.GradientInactiveCaption;
                includeButtons[1].BackColor = SystemColors.ButtonHighlight;
                Include14.BackColor = SystemColors.ButtonHighlight;
                UnInclude14.BackColor = SystemColors.GradientInactiveCaption;
            }


        }
        // 급여 계산 버튼 클릭 시 호출되는 함수
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double totalSalary = 0;

            double hourlyWage = 0;
            double dailyHours = 0;
            double workingDays = 0;
            double overtimeHours = 0;
            bool isProbationaryPeriod = false; // 수습 기간 여부를 나타내는 변수

            // DW1 텍스트 상자에서 시급을 입력받음
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

            // DAY1 텍스트 상자에서 근무일수를 입력받음
            if (!double.TryParse(Day1.Text, out workingDays))
            {
                MessageBox.Show("근무일수를 올바르게 입력하세요.");
                return;
            }

            // AH1 텍스트 상자에서 연장근무시간을 입력받음
            if (!double.TryParse(AH1.Text, out overtimeHours))
            {
                MessageBox.Show("연장근무시간을 올바르게 입력하세요.");
                return;
            }

            // 수습 기간인 경우 시급을 90%로 조정
            if (Include1.BackColor == SystemColors.GradientInactiveCaption)
            {
                hourlyWage *= 0.9;
            }

            // 주급 계산
            double weeklySalary = hourlyWage * dailyHours * workingDays;

            // 연장근무가 있을 경우 추가 계산
            if (overtimeHours > 0)
            {
                double overtimeRate = hourlyWage * 1.5; // 연장근무 시간에 대한 시급은 시급의 1.5배
                weeklySalary += overtimeHours * overtimeRate;
            }
            // Include8에 해당하는 직원에 대해서만 주휴 수당 계산
            if (Include8.BackColor == SystemColors.GradientInactiveCaption && dailyHours * workingDays >= 15)
            {
                // 주휴 수당 계산에 사용되는 시급을 hourlyWage로 변경
                double weeklyRestPay = (dailyHours / 40) * 8 * hourlyWage;
                totalSalary += weeklyRestPay;
            }

            

            // 총 급여에 주급 추가
            totalSalary += weeklySalary;

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
        private void Include14_Click(object sender, EventArgs e)
        {
            // 모든 버튼에 대한 조건을 충족하는지 확인하는 플래그
            bool allConditionsMet = true;

            double dailyHours;
            int workingDays;

            // Controls 컬렉션에서 컨트롤을 가져옵니다.
            Control dhControl = this.Controls["DH" + (1)];
            Control dayControl = this.Controls["Day" + (1)];

            // 컨트롤이 null인지 확인합니다.
            if (dhControl == null || dayControl == null)
            {
                MessageBox.Show($"DH{1} 또는 Day{1} 컨트롤이 존재하지 않습니다.");
                allConditionsMet = false;
            }

            // 텍스트 값을 double과 int로 변환할 수 있는지 확인합니다.
            if (!double.TryParse(dhControl.Text, out dailyHours) || !int.TryParse(dayControl.Text, out workingDays) || dailyHours * workingDays <= 15)
            {
                allConditionsMet = false;
                Include14.BackColor = SystemColors.ButtonHighlight;
            }
            

            // 모든 버튼에 대한 조건이 충족되었을 때만 IncludeHpButtons 호출
            if (allConditionsMet)
            {
                bs.IncludeHpButtons();
            }
            else
            {

                MessageBox.Show("조건을 충족하지 않습니다.");
            }
        }

        private void UnInclude14_Click(object sender, EventArgs e) { bs.UnIncludeHpButtons(); }
        private void MHW_Click(object sender, EventArgs e) { chw.SettingHWs(); }
        private void HW_TextChanged(object sender, EventArgs e) { chw.CustomHW(HW.Text); }
        private void AH_TextChanged(object sender, EventArgs e) { hour.CustomAH(AH.Text); }
        private void DH_TextChanged(object sender, EventArgs e) { hour.CustomDH(DH.Text); CheckIncludeButtons(); }
        private void Day_TextChanged(object sender, EventArgs e) { hour.CustomDay(Day.Text); CheckIncludeButtons(); }
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

            // dailyHours[i] * workingDays[i] >= 15 조건 확인
            int i = index - 6;
            double dailyHours;
            int workingDays;

            if (!double.TryParse(this.Controls["DH" + (1)].Text, out dailyHours) ||
                !int.TryParse(this.Controls["Day" + (1)].Text, out workingDays) ||
                dailyHours * workingDays < 15)
            {
                MessageBox.Show("조건을 충족하지 않습니다.");
                return;
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
            CheckIncludeButtons();
        }
        // Day1~Day6 텍스트 박스의 TextChanged 이벤트 핸들러
        private void Day1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int value;
                if (int.TryParse(textBox.Text, out value))
                {
                    if (value > 7)
                    {
                        MessageBox.Show("근무일수는 7일 이하로 입력해주세요.");
                        textBox.Text = "7";
                    }
                }
                else
                {
                    MessageBox.Show("유효한 숫자를 입력해주세요.");
                    textBox.Text = "";
                }
            }
            CheckIncludeButtons();
        }
    }
}
