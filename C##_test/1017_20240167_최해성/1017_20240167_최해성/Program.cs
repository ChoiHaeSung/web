// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
//  1번
/* 
char a = '안';
char b = '전';
char c = '운';
char d = '전';
Console.Write(a);
Console.WriteLine(b);
Console.Write(c);
Console.WriteLine(d);

// or 

Console.Write(a);
Console.Write(b);
Console.WriteLine();
Console.Write(c);
Console.Write(d);
*/

// 2번
/*
char e = 'Q';
int f = 'Q' + 5;


Console.WriteLine("알파벳 : "+e+ " ->아스키코드값 :" + ((int)e));
Console.Write(f + " ->아스키코드값 :"+ ((char)f));
*/

// 3번
/*
int a;
int b;

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
Console.WriteLine("덧셉 : " + (a + b));
Console.WriteLine("뺼셈 : " + (a - b));
Console.WriteLine("곱셉 : " + (a * b));
Console.WriteLine("나눗셉 : " + ((float)a / b));
*/

// 4번

//int c, d;
//char cn;
//c = Console.Read();
//Console.WriteLine(c);
//Console.WriteLine((char)c);
//d = c + 5;
//Console.WriteLine(d);
//cn = Convert.ToChar(d);
//Console.WriteLine(cn);

// 174 11
/*
int a;
a = int.Parse(Console.ReadLine());
if (a >= 90 && a<= 100)
{
    Console.WriteLine("등급 : A 학점");
}
}*/

// 175 12
/*
int choice = 3;
switch (choice)
{
    case 1:
    case 2:
        Console.WriteLine("교통수단 : 비행기");
        break;
    case 3:
    case 4:
        Console.WriteLine("자가용");
        break;
    default:
        Console.WriteLine("도보");
        break;
}
*/

// 176p
/*
float h, w, bmi;
Console.Write("신장(cm) : ");
h = float.Parse(Console.ReadLine());
h = h / 100;

Console.Write("체중(kg) : ");
w = float.Parse(Console.ReadLine());

bmi = (w / (h * h));
Console.Write(" > 본인 BMI : " + bmi);

if (bmi < 18.5)
{
    Console.WriteLine("체력 보강 필요");
}
    else if(bmi < 23)
    {
        Console.WriteLine("정상 유지 필요");
    }
        else if(bmi <= 40)
        {
            Console.WriteLine("다이어트 필요");
        }
            else
            {
            Console.WriteLine("프로그램 종료");
            }
*/
// 177p
/*
int y;
Console.Write("월 입력 : ");
y = int.Parse(Console.ReadLine());

if(y == 2)
{
    Console.WriteLine(" > " + y + "월은 평년 기준 28일까지 있습니다");
}
else if(y == 4 || y == 6 || y == 9 || y == 11)
{
    Console.WriteLine(" > " +y+ "월은 평년 기준 30일까지 있습니다");
}
else if (y == 1 || y == 3 || y == 5 || y == 7 || y == 8 || y == 10 || y == 12)
{
    Console.WriteLine(" > " + y + "월은 평년 기준 31일까지 있습니다");
}
else
{
    Console.WriteLine("프로그램 종료");
}
*/

// 213p

int star, count;

for (count = 1; count <= 5; count++)
{
    for (star = 1; star <= count; star++)
    {
        Console.Write("★");
    }
    Console.WriteLine();
}






















