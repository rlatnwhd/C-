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
    public partial class D_W: Form
    {
        // 일 -> 주
        private List<Button> unIncludeButtons;
        private List<Button> includeButtons;

        IButtonSystem bs;
        IHW chw;
        IHour hour;

        public D_W()
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
                 new List<Button> {  },
                 new List<Button> {  },
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
        // 급여 계산 버튼 클릭 시 호출되는 함수
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double totalSalary = 0;

            double[] hourlyWages = new double[6];
            double[] dailyHours = new double[6];
            int[] workingDays = new int[6];
            double[] overtimeHours = new double[6];

            for (int i = 0; i < 6; i++)
            {
                if (!double.TryParse(this.Controls["HW" + (i + 1)].Text, out hourlyWages[i]) ||
                    !double.TryParse(this.Controls["DH" + (i + 1)].Text, out dailyHours[i]) ||
                    !int.TryParse(this.Controls["Day" + (i + 1)].Text, out workingDays[i]) ||
                    !double.TryParse(this.Controls["AH" + (i + 1)].Text, out overtimeHours[i]))
                {
                    MessageBox.Show("입력값을 확인해주세요.");
                    return;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                double weeklySalary = hourlyWages[i] * (dailyHours[i] * workingDays[i] + overtimeHours[i]);

                if (((Button)this.Controls["Include" + (i + 1)]).BackColor == SystemColors.GradientInactiveCaption)
                {
                    weeklySalary *= 0.9;
                }

                totalSalary += weeklySalary;
            }

            for (int i = 0; i < 6; i++)
            {
                if (((Button)this.Controls["Include" + (i + 8)]).BackColor == SystemColors.GradientInactiveCaption && dailyHours[i] * workingDays[i] >= 15)
                {
                    totalSalary += (dailyHours[i] / 40) * 8 * hourlyWages[i];
                }
            }

            if (Tax3_3.BackColor == SystemColors.GradientInactiveCaption)
            {
                totalSalary -= totalSalary * 0.033;
            }
            else if (Tax9_8.BackColor == SystemColors.GradientInactiveCaption)
            {
                totalSalary -= totalSalary * 0.094;
            }

            Form20 form20 = new Form20();
            new TotalSalary(totalSalary);
            form20.ShowDialog();
        }


        // 전체 설정 영역
        private void Include7_Click(object sender, EventArgs e) { bs.IncludePbButtons(); }
        private void UnInclude7_Click(object sender, EventArgs e) { bs.UnIncludePbButtons(); }
        private void MHW_Click(object sender, EventArgs e) { chw.SettingHWs(); }
        private void HW_TextChanged(object sender, EventArgs e) { chw.CustomHW(HW.Text); }
        private void AH_TextChanged(object sender, EventArgs e) { hour.CustomAH(AH.Text); }
        private void DH_TextChanged(object sender, EventArgs e) { hour.CustomDH(DH.Text); }
        private void Day_TextChanged(object sender, EventArgs e) { hour.CustomDay(Day.Text); }
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

        private void HW2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
