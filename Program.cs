using System.Configuration;
using System.Globalization;

namespace C__Project
{
    // 인터페이스 활용
    public interface IButtonSystem
    {
        void IncludePbButtons();
        void UnIncludePbButtons();
        void IncludeHpButtons();
        void UnIncludeHpButtons();
        void SetTaxButton(int taxNum);
    }
    public interface IHW
    {
        void CustomHW(string money);
        void SettingHWs();
    }

    public interface IHour
    {
        void CustomAH(string hour);
        void CustomDH(string hour);
        void CustomDay(string day);
    }

    abstract class WeekCalculation
    {
        public static int Weeks { get; set; }
        public WeekCalculation(int weeks) { Weeks = weeks; }
        public abstract int GetWeeksInMonth(int year, int month);
    }

    class TotalSalary
    {
        public static double Money { get; set; }
        public TotalSalary(double salary) { Money = salary; }
    }

    internal static class Program
    {

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }

    class ChangeButtonSystem : IButtonSystem
    {
        private List<Button> ProbationUninclude { get; set; }
        private List<Button> ProbationInclude { get; set; }
        private List<Button> NotHolidayPay { get; set; }
        private List<Button> HolidayPay { get; set; }
        private List<Button> TaxList { get; set; }

        public ChangeButtonSystem(List<Button> bt1, List<Button> bt2, List<Button> bt3, List<Button> bt4, List<Button> bt5)
        {
            ProbationUninclude = bt1.ToList();
            ProbationInclude = bt2.ToList();
            NotHolidayPay = bt3.ToList();
            HolidayPay = bt4.ToList();
            TaxList = bt5.ToList();
        }

        private void SetButtonColors(List<Button> buttons, Color color) { foreach (var button in buttons) { button.BackColor = color; } }

        public void IncludePbButtons()
        {
            SetButtonColors(ProbationInclude, SystemColors.GradientInactiveCaption);
            SetButtonColors(ProbationUninclude, SystemColors.ButtonHighlight);
        }

        public void UnIncludePbButtons()
        {
            SetButtonColors(ProbationUninclude, SystemColors.GradientInactiveCaption);
            SetButtonColors(ProbationInclude, SystemColors.ButtonHighlight);
        }

        public void IncludeHpButtons()
        {
            SetButtonColors(HolidayPay, SystemColors.GradientInactiveCaption);
            SetButtonColors(NotHolidayPay, SystemColors.ButtonHighlight);
        }

        public void UnIncludeHpButtons()
        {
            SetButtonColors(NotHolidayPay, SystemColors.GradientInactiveCaption);
            SetButtonColors(HolidayPay, SystemColors.ButtonHighlight);
        }

        public void SetTaxButton(int taxNum)
        {
            for (int i = 0; i < TaxList.Count; i++)
            {
                if (i == taxNum)
                {
                    TaxList[i].BackColor = SystemColors.GradientInactiveCaption;
                    TaxList[i].Text = "선택";
                }
                else
                {
                    TaxList[i].BackColor = SystemColors.ButtonHighlight;
                    TaxList[i].Text = "";
                }
            }
        }
    }

    class ChangeHW : IHW
    {
        private List<TextBox> SetHWs { get; set; }

        public ChangeHW(List<TextBox> hwBoxes) { SetHWs = hwBoxes; }

        private void SetTextForAll(List<TextBox> textBoxes, string text) { foreach (var textBox in textBoxes) { textBox.Text = text; } }

        public void SettingHWs() { SetTextForAll(SetHWs, "9860"); }

        public void CustomHW(string money) { SetTextForAll(SetHWs, money); }
    }
    class ChangeHour : IHour
    {
        private List<TextBox> SetAH { get; set; }
        private List<TextBox> SetDH { get; set; }
        private List<TextBox> SetDay { get; set; }

        public ChangeHour(List<TextBox> ahBoxes, List<TextBox> dhBoxes, List<TextBox> dayBoxes)
        {
            SetAH = ahBoxes;
            SetDH = dhBoxes;
            SetDay = dayBoxes;
        }

        public ChangeHour(List<TextBox> dhBoxes, List<TextBox> dayBoxes)
        {
            SetDH = dhBoxes;
            SetDay = dayBoxes;
        }

        private void SetTextForAll(List<TextBox> textBoxes, string text) { foreach (var textBox in textBoxes) { textBox.Text = text; } }

        public void CustomAH(string hour) { SetTextForAll(SetAH, hour); }
        public void CustomDH(string hour) { SetTextForAll(SetDH, hour); }
        public void CustomDay(string day) { SetTextForAll(SetDay, day); }
    }

    class MonthWeek : WeekCalculation
    {
        public MonthWeek(int weeks) : base(weeks) { }
        public override int GetWeeksInMonth(int year, int month)
        {
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            // 첫 번째 날과 마지막 날의 주차 계산
            Calendar calendar = CultureInfo.CurrentCulture.Calendar;
            CalendarWeekRule weekRule = CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule;
            DayOfWeek firstDayOfWeek = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;

            int firstWeek = calendar.GetWeekOfYear(firstDayOfMonth, weekRule, firstDayOfWeek);
            int lastWeek = calendar.GetWeekOfYear(lastDayOfMonth, weekRule, firstDayOfWeek);

            // 첫 번째 주와 마지막 주가 같을 경우 1주로 처리
            if (firstWeek == lastWeek)
            {
                return 1;
            }

            // 달이 1월이거나 12월일 경우 처리
            if (month == 1 && firstWeek > 1)
            {
                lastWeek += 1;
            }
            else if (month == 12 && lastWeek == 1)
            {
                lastWeek = calendar.GetWeekOfYear(new DateTime(year, 12, 31), weekRule, firstDayOfWeek);
            }

            return lastWeek - firstWeek + 1;
        }
    }
}