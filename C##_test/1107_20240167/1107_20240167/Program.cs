// See https://aka.ms/new-console-template for more information
/*
class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(" > 오늘 : {0}", DateTime.Today);

        DateTime y = DateTime.Today.AddDays(-1);  // 어제
        Console.WriteLine(" > 어제 : {0}", y.ToShortDateString());

        DateTime t = DateTime.Today.AddDays(+1);  // 내일
        Console.WriteLine(" > 내일 : {0}", t.ToShortDateString());
    }
}

class Solution
{
    static void Main(string[] args)
    {
        DateTime d1 = new DateTime(2000, 3, 2, 9, 30, 0);
        DateTime d2 = new DateTime(2035, 12, 25, 23, 59, 38);

        Console.WriteLine(" > 입사일자 : {0}", d1);
        Console.WriteLine(" > 경력기준 : {0}", d2);

        Console.WriteLine(" > {0}과 {1}의 차이는 {2} 일입니다.",
            d1.ToString("2024년 11월 07일"),    // 월과 일은 2자리로 설정
            d2.ToString("2024년 11월 08일"),
            d2.Subtract(d1).Days);
    }
}

class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(" > 2024년은 {0} 입니다.",
            DateTime.IsLeapYear(2024) ? "[윤년]" : "[평년]");
        Console.WriteLine(" > 2024년 2월은 {0}일 입니다. \n",
            DateTime.DaysInMonth(2024, 2));

        Console.WriteLine(" > 2030년은 {0} 입니다.",
            DateTime.IsLeapYear(2030) ? "[윤년]" : "[평년]");
        Console.WriteLine(" > 2030년 2월은 {0}일 입니다. \n",
            DateTime.DaysInMonth(2030, 2));
    }
}

class Solution
{
    static void Main(string[] args)
    {
        DateTime sT = new DateTime(2023, 3, 15, 10, 33, 0);
        DateTime eT = new DateTime(2023, 3, 20, 7, 15, 0);
        TimeSpan tTime = eT - sT;

        Console.WriteLine(" > 2023. 3. 15 ~ 2023. 3. 20일의 시간 간격 ");
        Console.WriteLine(" > 여행기간 : {0, 10}", tTime);
        Console.WriteLine(" {0, 14} 일", tTime.Days);
        Console.WriteLine(" {0, 14} 시간", tTime.TotalHours);
        Console.WriteLine(" {0, 14} 분", tTime.TotalMinutes);
        Console.WriteLine(" {0, 14} 초", tTime.TotalSeconds);
    }
}

class Solution
{
    static void Main(string[] args)
    {
        Console.Write(" > 생일 입력(년-월-일 시:분) : ");
        DateTime d1 = DateTime.Parse(Console.ReadLine());
        DateTime d2 = DateTime.Now;

        TimeSpan interval = d2 - d1;
        Console.WriteLine(" > 출생 시각 : {0}", d1);
        Console.WriteLine(" > 현재 시각 : {0}", d2);
        Console.WriteLine(" > 생존 시간 : {0}", interval.ToString());
        Console.WriteLine(" > 지금까지 {0}일 {1}시간 {2}분 {3}초를 생활하였습니다.",
            interval.Days, interval.Hours, interval.Minutes, interval.Seconds);
    }
}
*/


























