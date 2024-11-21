
/*// 2024 / 10 / 31 / 목요일 //////////////////////////////////////////////////
public class MathHelper
{
    //static 메서드 ★
    public static int Add(int a, int b)
    {
        return a + b;
    }

    //인스턴스 변수 (static이 아님) ★
    public int InstanceValue;

    //static 변수
    public static int StaticValue;
}

class Program
{
    static void Main()
    {
        //static멤버는 객체 생성 없이
        //클래스 이름으로 직접 접근
        int sum = MathHelper.Add(5, 3);
        MathHelper.StaticValue = 10;

        //인스턴스 멤버는 객체를 생성해야 접근 가능
        MathHelper helper = new MathHelper();
        helper.InstanceValue = 5;

        Console.WriteLine($"Sum:{sum}");
        Console.WriteLine($"Static Value:{MathHelper.StaticValue}");
        Console.WriteLine($"Instance Value:{helper.InstanceValue}");
    }
}


class Owner
{
    public string name;                    // 인스턴스 필드 선언
}

class Exchange
{
    public static double P = 0.3025;       // 클래스 정적 필드 선언
    public const int Q = 100;              // 상수 선언
    public static double result = P * Q;   // 클래스 정적 필드 / 평방미터를 평으로 환산
}
class Program
{
    static void Main(string[] args)
    {
        Owner s = new Owner();    // Owner 클래스의 속성을 가진 객체 s 생성
        s.name = "홍길동";

        Console.WriteLine(" > 성명 : " + s.name);
        Console.WriteLine(" > 기준 : 1 평방미터 -> " + Exchange.P + " 평");
        Console.WriteLine(" > 대상 : " + Exchange.Q + " 평방미터");
        Console.WriteLine(" > 결과 : " + Exchange.result + " 평 ");
    }
}

class Calculator
{
    // 인스턴스 변수
    private double result;

    // 인스턴스 메서드: 객체를 생성해야 사용 가능
    public void Add(double number)
    {
        result += number;
    }

    public double GetResult()
    {
        return result;
    }

    // 정적 메서드: 객체 생성 없이 바로 사용 가능
    public static double Add(double x, double y)
    {
        return x + y;
    }

    public static double Multiply(double x, double y)
    {
        return x * y;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 정적 메서드 사용 - 객체 생성 없이 바로 사용
        double staticResult1 = Calculator.Add(5, 3);      // 8
        double staticResult2 = Calculator.Multiply(4, 2); // 8
        Console.WriteLine($"정적 메서드 결과: {staticResult1}, {staticResult2}");

        // 인스턴스 메서드 사용 - 객체를 먼저 생성해야 함
        Calculator calc = new Calculator();
        calc.Add(5);
        calc.Add(3);
        double instanceResult = calc.GetResult(); // 8
        Console.WriteLine($"인스턴스 메서드 결과: {instanceResult}");
    }
}


class Solution
{
    static void Main(string[] args)
    {
        // 2~50까지 숫자 중 소수 판별 프로그램
        int count = 0;
        for (int i = 2; i <= 50; i++)
        {
            if (IsPrime(i))
            {
                Console.Write("{0, 3}", i);               // 3자리로 소수 출력
                count++;
            }
        }
        Console.WriteLine();
        Console.WriteLine(" > 소수 개수 : " + count);
    }
    private static bool IsPrime(int s)
    {
        int num = (int)Math.Sqrt(s);
        for (int i = 2; i <= num; i++)
        {
            if (s % i == 0)
                return false;
        }
        return true;
    }
} 

class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(" > 윤년 리스트 ");
        for (int year = 2020; year <= 2050; year++)
        {
            if (IsLeapYear(year))
            {
                Console.Write("{0, 7}", year);
            }
        }
        Console.WriteLine();
    }

    private static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}

class Solution
{
    static void Main(string[] args)
    {
        Console.Write(" >   1~10 까지 누적 합계 : ");
        Console.WriteLine("{0, 5}", AddMethod(1, 10));

        Console.Write(" > 51~100 까지 누적 합계 : ");
        Console.WriteLine("{0, 5}", AddMethod(51, 100));
    }

    private static int AddMethod(int n, int m)
    {
        int sum = 0;
        for(int count = n; count <= m; count++)
        {
            sum += count;      // sum = sum + count
        }
        return sum;
    }
}

class Solution
{
    static void Main(string[] args)
    {
        Output(15);
        Output(12.35);
        Output("파이값 = ", 3.141592);
    }

    private static void Output(double a)
    {
        Console.Write(" > 실수값 출력 : ");
        Console.WriteLine(a);
    }

    private static void Output(string s, double a)
    {
        Console.Write(" > 문자열 + 실수값 출력 : ");
        Console.WriteLine(s + a);
    }

    private static void Output(int a)
    {
        Console.Write(" > 정수값 출력 : ");
        Console.WriteLine(a);
    }
}

class Solution
{
    private int start;    // 멤버 변수 생성
    public int width      // 속성 생성
    {
        get { return start; }
        set 
        {
            if (value > 0) { start = value; }
            else 
            { 
                Console.WriteLine("시작 : 양의 정수만 입력 "); 
            }
        }
    }

    private int end;     // 멤버 변수 생성
    public int height    // 속성 생성
    {
        get { return end; }
        set
        {
            if (value > 0) { end = value; }
            else
            {
                Console.WriteLine("종료 : 양의 정수만 입력 ");
            }
        }
    }

    public Solution(int start, int end)  // 생성자 생성
    {
        width = start;
        height = end;
    }

    // 인스턴스 메서드
    public int Area()
    {
        return this.width * this.height;
    }

    static void Main(string[] args)
    {
        Solution box = new Solution(38, -23);
        Console.WriteLine($"면적: {box.Area()}");
        Console.WriteLine();

        box.width = 73;
        box.height = 88;
        Console.WriteLine($"면적: {box.Area()}");
    }
}


// 제네릭 클래스 정의
public class Box<T> {
    private T item;

    public void SetItem(T newItem)    {
        item = newItem;
    }

    public T GetItem()    {
        return item;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // int 타입으로 구체화
        Box<int> intBox = new Box<int>();
        intBox.SetItem(10);
        Console.WriteLine(intBox.GetItem());  // 출력: 10

        // string 타입으로 구체화
        Box<string> stringBox = new Box<string>();
        stringBox.SetItem("Hello");
        Console.WriteLine(stringBox.GetItem());  // 출력: Hello
    }
}

class Solution
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();

        // 리스트에 요소 추가
        list.Add(23);
        list.Add(85);
        list.Add(16);
        list.Add(95);

        Console.WriteLine(" > 반복문으로 요소 출력 ");
        foreach(var item in list)
        {
            Console.WriteLine(" 요소 : {0}", item);
        }
        Console.WriteLine(" > 리스트 요소 개수 : {0}", list.Count);
    }
}


class Solution
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() {123, 35, 78 };

        Console.WriteLine(" > 반복문으로 요소 출력 ");

        foreach (var item in list)
        {
            Console.WriteLine(" 요소 : {0, 3}", item);
        }
        Console.WriteLine(" > 리스트 요소 개수 : {0}", list.Count);
    }
}


using System;

class Solution
{
    class Car
    {
        private void PrivateM() { Console.WriteLine("Car의 Private 메서드"); }
        public void PublicM() { Console.WriteLine("Car의 Public 메서드"); }
        protected void ProtectedM() { Console.WriteLine("Car의 Protected 메서드"); }

        public void TestA()
        {
            Console.WriteLine("Car 클래스 내부 테스트:");
            PrivateM();
            PublicM();
            ProtectedM();
        }
    }

    class Sedan : Car
    {
        public void TestB()
        {
            Console.WriteLine("\nSedan 클래스 (상속받은 클래스) 테스트:");
            // PrivateM(); // 이 줄은 컴파일 에러가 발생하므로 주석 처리
            PublicM();
            ProtectedM();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("접근 제한자 테스트 시작\n");

        Car car = new Car();
        car.TestA();

        Sedan sedan = new Sedan();
        sedan.TestB();

        Console.WriteLine("\n외부에서의 접근 테스트:");
        // car.PrivateM(); // 이 줄은 컴파일 에러가 발생하므로 주석 처리
        // car.ProtectedM(); // 이 줄도 컴파일 에러가 발생하므로 주석 처리
        car.PublicM();

        Console.WriteLine("\n접근 제한자 테스트 종료");
    }
}

*/