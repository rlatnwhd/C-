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
    public partial class Form6 : Form
    {
        // 일 -> 월 5주
        private List<Button> unIncludeButtons;
        private List<Button> includeButtons;

        IButtonSystem bs;
        IHW chw;
        IHour hour;

        public Form6()
        {
            InitializeComponent();

            unIncludeButtons = new List<Button> { UnInclude1, UnInclude2, UnInclude3, UnInclude4, UnInclude5, UnInclude8, UnInclude9, UnInclude10, UnInclude11, UnInclude12 };
            includeButtons = new List<Button> { Include1, Include2, Include3, Include4, Include5, Include8, Include9, Include10, Include11, Include12, Include14 };

            // 각 버튼에 대한 Click 이벤트 핸들러를 할당합니다.
            foreach (var button in unIncludeButtons) { button.Click += UnIncludeButton_Click; }
            foreach (var button in includeButtons) { button.Click += IncludeButton_Click; }

            bs = new ChangeButtonSystem(
                 new List<Button> { UnInclude1, UnInclude2, UnInclude3, UnInclude4, UnInclude5, UnInclude7 },
                 new List<Button> { Include1, Include2, Include3, Include4, Include5, Include7 },
                 new List<Button> { UnInclude8, UnInclude9, UnInclude10, UnInclude11, UnInclude12, UnInclude14 },
                 new List<Button> { Include8, Include9, Include10, Include11, Include12, Include14 },
                 new List<Button> { NoTax, Tax3_3, Tax9_8 }
            );

            chw = new ChangeHW(new List<TextBox> { HW1, HW2, HW3, HW4, HW5 });
            hour = new ChangeHour(new List<TextBox> { DH1, DH2, DH3, DH4, DH5 },
                   new List<TextBox> { Day1, Day2, Day3, Day4, Day5 }
            );

            NoTax.BackColor = SystemColors.GradientInactiveCaption;
            NoTax.Text = "선택";

            bs.UnIncludePbButtons();
            bs.UnIncludeHpButtons();
        }
        private void CheckIncludeButtons()
        {
            // UnInclude8부터 UnInclude11까지의 버튼에 대한 조건을 확인하고, 조건에 따라 색을 조정합니다.
            for (int index = 5; index <= 9; index++)
            {
                int i = index - 5;
                double dailyHours;
                int workingDays;

                // Controls 컬렉션에서 컨트롤을 가져옵니다.
                Control dhControl = this.Controls["DH" + (i + 1)];
                Control dayControl = this.Controls["Day" + (i + 1)];

                // 컨트롤이 null이거나 변환이 실패하면 처리를 중단합니다.
                if (dhControl == null || dayControl == null ||
                    !double.TryParse(dhControl.Text, out dailyHours) ||
                    !int.TryParse(dayControl.Text, out workingDays))
                {
                    continue;
                }

                // 조건을 만족하는지 확인합니다.
                if (dailyHours * workingDays < 15)
                {
                    unIncludeButtons[index].BackColor = SystemColors.GradientInactiveCaption;
                    includeButtons[index].BackColor = SystemColors.ButtonHighlight;
                    Include14.BackColor = SystemColors.ButtonHighlight;
                    UnInclude14.BackColor = SystemColors.GradientInactiveCaption;
                }

            }
        }

        // 급여 계산 버튼 클릭 시 호출되는 함수
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double totalSalary = 0;

            double[] dailyWages = new double[6];
            int[] workingDays = new int[6];
            double[] dailyHours = new double[6]; // dailyHours 배열 추가 및 초기화

            for (int i = 0; i < 5; i++)
            {
                if (!double.TryParse(this.Controls["HW" + (i + 1)].Text, out dailyWages[i]) ||
                    !int.TryParse(this.Controls["Day" + (i + 1)].Text, out workingDays[i]) ||
                    !double.TryParse(this.Controls["DH" + (i + 1)].Text, out dailyHours[i])) // dailyHours 입력 추가
                {
                    MessageBox.Show("입력값을 확인해주세요.");
                    return;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                // 월급 계산: 일급 * 근무일수
                double monthlySalary = dailyWages[i] * workingDays[i];

                // 포함 버튼의 상태에 따라 조정
                if (((Button)this.Controls["Include" + (i + 1)]).BackColor == SystemColors.GradientInactiveCaption)
                {
                    monthlySalary *= 0.9; // 10% 감소
                }

                totalSalary += monthlySalary;
            }

            // 주휴 수당 계산
            for (int i = 0; i < 5; i++)
            {
                if (((Button)this.Controls["Include" + (i + 8)]).BackColor == SystemColors.GradientInactiveCaption && dailyHours[i] * workingDays[i] >= 15)
                {
                    totalSalary += (dailyHours[i] / 40) * 8 * dailyWages[i]; // 수정된 주휴 수당 계산 로직
                }
            }

            // 세금 공제 계산
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

            // Include8부터 Include13까지의 버튼에 대한 조건을 확인하고, 하나라도 조건이 충족되지 않으면 플래그를 false로 설정
            for (int index = 5; index <= 9; index++)
            {
                int i = index - 5;
                double dailyHours;
                int workingDays;

                // Controls 컬렉션에서 컨트롤을 가져옵니다.
                Control dhControl = this.Controls["DH" + (i + 1)];
                Control dayControl = this.Controls["Day" + (i + 1)];

                // 컨트롤이 null인지 확인합니다.
                if (dhControl == null || dayControl == null)
                {
                    MessageBox.Show($"DH{i + 1} 또는 Day{i + 1} 컨트롤이 존재하지 않습니다.");
                    allConditionsMet = false;
                    break;
                }

                // 텍스트 값을 double과 int로 변환할 수 있는지 확인합니다.
                if (!double.TryParse(dhControl.Text, out dailyHours) || !int.TryParse(dayControl.Text, out workingDays) || dailyHours * workingDays <= 15)
                {
                    allConditionsMet = false;
                    Include14.BackColor = SystemColors.ButtonHighlight;
                    break;
                }
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
        private void DH_TextChanged(object sender, EventArgs e) { hour.CustomDH(DH.Text); }
        private void Day_TextChanged(object sender, EventArgs e) { hour.CustomDay(Day.Text); }
        private void NoTax_Click(object sender, EventArgs e) { bs.SetTaxButton(0); }
        private void Txt3_3_Click(object sender, EventArgs e) { bs.SetTaxButton(1); }
        private void Tax9_8_Click(object sender, EventArgs e) { bs.SetTaxButton(2); }


        // 개인 설정 영역
        private void UnIncludeButton_Click(object sender, EventArgs e)
        {
            // 클릭된 버튼을 가져옵니다.
            Button clickedButton = (Button)sender;

            // 클릭된 버튼이 비포함 버튼 배열에 있는지 확인합니다.
            if (unIncludeButtons.Contains(clickedButton))
            {
                // 비포함 버튼의 배경색이 SystemColors.ButtonHighlight이면 처리합니다.
                if (clickedButton.BackColor == SystemColors.ButtonHighlight)
                {
                    // 비포함 버튼의 배경색 변경
                    clickedButton.BackColor = SystemColors.GradientInactiveCaption;

                    // 포함 버튼의 배경색 변경
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
            if (index >= 5 && index <= 9)
            {
                // dailyHours[i] * workingDays[i] >= 15 조건 확인
                int i = index - 5;
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
