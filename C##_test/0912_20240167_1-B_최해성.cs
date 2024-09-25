// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 75P
Console.WriteLine("대한\t민국.");
Console.WriteLine("용기는 \" 진실\'에서 우러나온다.");
Console.WriteLine("오늘보다\n내일은 희망차다.");



// 77P
Console.WriteLine("대한민국."[0]);
Console.WriteLine("대한민국."[1]);
Console.WriteLine("대한민국."[2]);
Console.WriteLine("대한민국."[3]);

// 81P
Console.Write("!false의 논리 연산 결과 : ");
Console.WriteLine(!false);
Console.Write("true || false의 논리 연산 결과 : ");
Console.WriteLine(true || false);
Console.Write("true && false의 논리 연산 결과 : ");
Console.WriteLine(true && false);

// 92P
int a, b, hap, cha, gob, na, mo;
a = 10;
b = 3;

hap = a + b;
cha = a - b;
gob = a * b;
na = a / b;

Console.WriteLine("a=10, b= 3일 때, 사칙 연산결과");
Console.WriteLine("a + b = " + hap);
Console.WriteLine("a - b = " + cha);
Console.WriteLine("a * b = " + gob);
Console.WriteLine("a / b = " + na);

// 95p
float c, d, result1;
double result2;
c = 2;
d = 3;
result1 = c / d;
result2 = c / d;

Console.WriteLine("float = " + result1);
Console.WriteLine("double = " + result2);

// 96p
float e,f, result3;
e = 2;
f = 3;
result3 =  e / f;

double g, h, result4;
e = 2;
f = 3;
result4 = e / f;

Console.WriteLine("float = " + result3);
Console.WriteLine("double = " + result4);

// 98p
decimal j, k;
j = 0.12345678901234567890123m; // 숫자 뒤에 m을 반드시 첨부
k = 3.141592653589793238462643383279502884197m;

Console.WriteLine("decimal = " + j);
Console.WriteLine("decimal = " + k);

// 100p
char l, n;
l = 'A';
n = 'B';

Console.Write("알파벳 : " + l);
Console.WriteLine("-> 아스키코드값 : " + (int)n);

// 102p
string m = "집에 가고싶다";

Console.WriteLine(m);

// 103p
string o = "prongraming";

Console.WriteLine(o + "!");
Console.WriteLine(o[1]);
Console.WriteLine(o[4]);

// 104p
string sz = "Space Zone";
Console.WriteLine("대문자 변환 " + sz.ToUpper());
Console.WriteLine("소문자 변환 " + sz.ToLower());
// 105p
string tt = sz.Trim();
Console.WriteLine("모든 공백 제거 |" + sz.Trim() + "|");
Console.WriteLine("앞의 공백 제거 |" + sz.TrimStart() + "|");
Console.WriteLine("뒤의 공백 제거 |" + sz.TrimEnd() + "|");

// 107p
bool q = (37 == 99);
Console.WriteLine("!(37 == 99) : " + c);

// 109p
Console.WriteLine("int 형식 \t : " + sizeof(int) + " 바이트");

// 110p
int p = 123;
long r = 1234567890123456;

// 변수에 대한 자료형 검사
Console.WriteLine(p.GetType());     // int
Console.WriteLine(r.GetType());     // long

// 상수에 대한 자료형 검사
Console.WriteLine(38.277f.GetType());   // float
Console.WriteLine(38.277.GetType());    // Double
Console.WriteLine(38.277m.GetType());   // decimal
Console.WriteLine("스페이스".GetType());// string
Console.WriteLine("A".GetType());       // char

// 112p
var s = 88.99;
var t = 'A';
var u = "space";

Console.WriteLine(s.GetType());
Console.WriteLine(t.GetType());
Console.WriteLine(u.GetType());

// 113p
int v, w;
float result5;

v = 5;
w = 2;

result5 = v / w;
Console.WriteLine("강제 자료형 변환 전 :" + result5);

result5 = (float)v / w;
Console.WriteLine("강제 자료형 변환 전 : " + result5);