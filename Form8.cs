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
    public partial class Form8 : Form
    {
        // 주 -> 월 6주
        private List<Button> unIncludeButtons;
        private List<Button> includeButtons;

        IButtonSystem bs;
        IHW chw;

        public Form8()
        {
            InitializeComponent();

            unIncludeButtons = new List<Button> { UnInclude8, UnInclude9, UnInclude10, UnInclude11, UnInclude12, UnInclude13 };
            includeButtons = new List<Button> { Include8, Include9, Include10, Include11, Include12, Include13 };

            // 각 버튼에 대한 Click 이벤트 핸들러를 할당합니다.
            foreach (var button in unIncludeButtons) { button.Click += UnIncludeButton_Click; }
            foreach (var button in includeButtons) { button.Click += IncludeButton_Click; }

            bs = new ChangeButtonSystem(
                 new List<Button> { UnInclude7, UnInclude8, UnInclude9, UnInclude10, UnInclude11, UnInclude12, UnInclude13 },
                 new List<Button> { Include7, Include8, Include9, Include10, Include11, Include12, Include13 },
                 new List<Button> { },
                 new List<Button> { },
                 new List<Button> { NoTax, Tax3_3, Tax9_8 }
            );

            chw = new ChangeHW(new List<TextBox> { HW1, HW2, HW3, HW4, HW5, HW6 });

            NoTax.BackColor = SystemColors.GradientInactiveCaption;
            NoTax.Text = "선택";

            bs.UnIncludePbButtons();
            bs.UnIncludeHpButtons();
        }



        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double totalSalary = 0;

            double weeklyWage = 0;
            double[] dailyWages = new double[4];

            // HW1 ~ HW4 텍스트 상자에서 주급을 입력받음
            if (!double.TryParse(HW.Text, out weeklyWage))
            {
                MessageBox.Show("주급을 올바르게 입력하세요.");
                return;
            }

            // 각 직원의 월급 계산
            for (int i = 0; i < 6; i++)
            {
                // 주급을 월급으로 변환
                double monthlySalary = weeklyWage * 4; // 주급 * 4주

                // 포함 여부에 따라 월급 조정
                if (((Button)this.Controls["Include" + (i + 8)]).BackColor == SystemColors.GradientInactiveCaption)
                {
                    monthlySalary *= 0.9; // 10% 감소
                }

                // 총 급여에 월급 추가
                totalSalary += monthlySalary;
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
        private void HW_TextChanged(object sender, EventArgs e) { chw.CustomHW(HW.Text); }
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
            if (index >= 6 && index <= 10)
            {
                // dailyHours[i] * workingDays[i] >= 15 조건 확인
                int i = index - 4;
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

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
