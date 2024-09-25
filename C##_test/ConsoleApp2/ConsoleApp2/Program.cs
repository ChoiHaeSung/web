/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 117p
int count = 100;

Console.WriteLine("주어진 데이터값이 count = 100 일 때");
count += 5; // count = count + 5
Console.WriteLine("count += 5 " + count);

count -= 3; // count = count - 5
Console.WriteLine("count -= 3 " + count);

count *= 2; // count = count * 2
Console.WriteLine("count * =2 " + count);

count /= 10; // count = count / 10
Console.WriteLine("count /= 10 " + count);

// 118p
string fruti = "과일 -> ";

Console.WriteLine("주어진 문자열 : " +  fruti);

fruti += "사과";
Console.WriteLine("주어진 문자열 : " +  fruti);

fruti += "바나나";
Console.WriteLine("주어진 문자열 : " +  fruti);

//119
int b, c;

b = 10;
c = ++b;
Console.Write("b = 10, c = ++b 일 때 : ");
Console.WriteLine("b = " + b + ", c = " + c);

b = 10; //누적값을 배제하기 위한 변수의 값 초기화 선언
c = b++;
Console.Write("b = 10, c = b++ 일 때 : ");
Console.WriteLine("b = " + b + ", c = " + c);

b = 10; //누적값을 배제하기 위한 변수의 값 초기화 선언
c = --b;
Console.Write("b = 10, c = --b 일 때 : ");
Console.WriteLine("b = " + b + ", c = " + c);

b = 10; //누적값을 배제하기 위한 변수의 값 초기화 선언
c = b--;
Console.Write("b = 10, c = b-- 일 때 : ");
Console.WriteLine("b = " + b + ", c = " + c);


//122p
int d;

Console.Write("1. 정수 입력 :");
d = int.Parse(Console.ReadLine());

Console.WriteLine("2. 입력한 정수값 출력 : " + d);

// 123p
float e;

Console.Write("1. 실수 입력 : ");
e = float.Parse(Console.ReadLine());

Console.WriteLine("2. 입력한 실수값 출력 : " + e);




//125p
int h;
char cparse;

Console.Write("1. 문자입력 : ");
h = Console.Read();

Console.WriteLine("2. 문자의 아스키코드값이 출력 : " + h);
cparse = Convert.ToChar(h);

Console.WriteLine("3. 문자 변환 메서드를 적용하여 출력 : " + cparse);

//126p
Console.ReadLine();

string g;

Console.Write("1. 문자열 입력 : ");
g = Console.ReadLine();

Console.WriteLine("2. 입력한 문자열 출력 : " + g);


//146p
int a, choice;

Console.Write("정수 입력 : ");
a = int.Parse(Console.ReadLine());
choice = a % 2;

if (choice == 0)
{
    Console.WriteLine("짝수");
}
else
{
    Console.WriteLine("홀수");
}

//147p
int c;
char cparse;

Console.Write("문자 입력:");
c = Console.Read();
cparse = Convert.ToChar(c);

if (cparse >= 'A' && cparse <= 'Z')
{
    Console.WriteLine(" > 입력한 알파벳 : " + cparse);
    Console.WriteLine(" > 판별 결과 : 대문자 ");
}
else
{
    Console.WriteLine(" > 입력한 알파벳 : " + cparse);
    Console.WriteLine(" > 판별 결과 : 소문자 ");
}


//149p
int d;
char chocolet;

Console.WriteLine("법학과 : A 또는 a ");
Console.WriteLine("행정학과 : S 또는 s ");
Console.WriteLine("소비자학과 : D 또는 d ");
Console.WriteLine("데이터사이언스학과 : F 또는 f");
Console.WriteLine("그 이외의 알파벳 : 에러 메시지 출력 ");
Console.WriteLine();

Console.Write("알파벳 입력 : ");
d = Console.Read();
chocolet = Convert.ToChar(d);

Console.Write("선택학과 : ");

if (chocolet == 'A' || chocolet == 'a')
{
    Console.WriteLine("법학과 ");
}
else if (chocolet == 'S' || chocolet == 'S') 
{
    Console.WriteLine("행정학과 ");
}


//151
int score;

Console.Write("점수 입력: ");
score = int.Parse(Console.ReadLine());

if (score >= 90)
{
    Console.WriteLine(" > 입력한 점수 : " + score);
    Console.WriteLine(" > 등급 : A 학점 ");
}
if (score >= 80)
{
    Console.WriteLine(" > 입력한 점수 : " + score);
    Console.WriteLine(" > 등급 : B 학점 ");
}
if (score >= 70)
{
    Console.WriteLine(" > 입력한 점수 : " + score);
    Console.WriteLine(" > 등급 : C 학점 ");
}
if (score >= 60)
{
    Console.WriteLine(" > 입력한 점수 : " + score);
    Console.WriteLine(" > 등급 : D 학점 ");
}
else
{
    Console.WriteLine(" > 입력한 점수 : " + score);
    Console.WriteLine(" > 등급 : F 학점 ");
}


//159p
int score, mok;
char grade;

Console.Write("점수 입력 : ");
score = int.Parse(Console.ReadLine());
mok = score / 10;

if (score > 100 || score < 0)
{
    Console.WriteLine(" > 점수의 허용 공간이 아닙니다. ");
    Console.WriteLine(" > 프로그램 종료! ");
}
else
{
    switch (mok)
    {
        case 10:
        case 9:
            grade = 'A';
            break;
        case 8:
            grade = 'B';
            break;
        case 7:
            grade = 'C';
            break;
        case 6:
            grade = 'D';
            break;
        default:
            grade = 'F';
            break;
    }
    Console.WriteLine(" > 입력한 점수 : " + score );
    Console.WriteLine(" > 등급 : " + grade + " 학점 ");
}
*/
/*
//quit 1
int age;
char cparse;

Console.Write("나이 입력");
age = int.Parse(Console.ReadLine());

if (age >= 18 && age < 99)

    Console.WriteLine(" > 나이 : 청소년 관람 불가");
}
if (age >= 15 && age < 18)
{
    Console.WriteLine(" > 나이 : 15세 이상 관람가");
}
else 
{
    Console.WriteLine(" > 나이 : 전체 관람가");
}
*/
// quit 2






























