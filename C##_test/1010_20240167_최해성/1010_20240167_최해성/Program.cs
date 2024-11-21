// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");

// 배열 218p
int[,] b = new int[3,2] {{ 1, 3 }, { 5, 7 }, { 9, 11 }};
foreach(int cnt in b)
{
    Console.Write(cnt + " ");
}

// 222p
 int[] a = { 10, 50, 30 };
int[,] b = { { 1, 2, 3 }, { 4, 5, 6 } };

int d1 = a.Rank;
int d2 = b.Rank;

Console.WriteLine("> 차원 수 : " + d1);
Console.WriteLine("> 차원 수 : " + d2);
// 223p
int[] a = {10, 50, 30 };
Array.Sort(a);
Console.WriteLine("> 오름차순 정렬 : ");

foreach ( int cnt in a)
{
    Console.Write(cnt + "");
}

Console.WriteLine();
Array.Reverse(a);
Console.WriteLine("> 내림차순 정렬 : ");

foreach ( int cnt in a)
{
    Console.Write(cnt + "");
}

// 226p
Console.WriteLine(" > 2차원 배열 : arrA[2,3]");
int[,] arrA = new int[2,3] {{ 10, 20, 30}, { 40, 50, 60} };

for (int i = 0; i > 2; i++)
{
    for (int j = 0; j > 3; j++)
    {
        Console.WriteLine("{0,5}", arrA[i,j]);
    }
    Console.WriteLine();
}

// 227p
Console.WriteLine(" > 2차원 가변 배열 : arrB[2][3]");

int[][] arrB = new int[2][];
arrB[0] = new int[] { 100, 200 };
arrB[1] = new int[] { 300, 400, 500 };
for (int i = 0; i < 2; i++)
{
    Console.WriteLine(" arrB[{0}] ; " , i );

    for (int j = 0; j < arrB[i].Length; j++)
    {
        Console.WriteLine("{0} ", arrB[i][j]);
    }
    Console.WriteLine();
}

// 230p
Random r= new Random();
int[] a = new int [6];

// 6개의 랜덤값 생성하여 저장
for (int i = 0; i < 6; i++){
    a[i] = r.Next(1, 46);
}
Console.WriteLine(" > 생성된 6개의 랜덤 숫자 출력 ");
foreach(int value in a)
{
    Console.WriteLine("{0, 8}",value);  // 8자리로 출력
}
// 231p 최대값과 최소값
Random r = new Random();
int[] v = new int[13];

// 10개의 랜덤값 저장
for (int i = 0; i < v.Length; i++)
    v[i] = r.Next(100);

Console.WriteLine(" > 랜덤값 출력 ");
foreach (int a in v)
    Console.WriteLine("{0, 5}", a);
Console.WriteLine();

int max = v[0];
for (int i = 0; i < v.Length; i++)
    if (v[i] > max)
        max = v[i];
Console.Write(" > 최대값 : ");
Console.WriteLine("{0, 3}", max);
// 최솟값
int min = v[0];
for (int i = 0;i < v.Length; i++)
    if (v[i] < min)
        min = v[i];
Console.Write(" > 최솟값 :");
Console.WriteLine("{0,3}", min);
// 랜덤값 총점
int sum = 0;
for(int i = 0;i<v.Length;i++)
    sum += v[i];
Console.Write(" > 총점 : ");
Console.WriteLine("{0,3}", sum);
// 랜덤값 평균
double avg = 0;
avg = (double)sum / v.Length;

Console.Write(" > 평균 :");
Console.WriteLine("{0,3}", avg);
//234p
Random r = new Random();

Console.WriteLine(r.NextDouble());
Console.WriteLine(r.NextDouble()*10);
Console.WriteLine(r.NextDouble() * 20);
//235p
Random r = new Random();
int[] v = new int[10];

// 10개의 랜덤값 지정
for (int i = 0; i < v.Length; i++)
    v[i] = r.Next(100);

Console.WriteLine(" > 정렬 전 랜덤값");
foreach (int a in v)
    Console.WriteLine("{0,5} ",a);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine(" > 정렬 후 랜덤값 ");
Array.Sort(v);
foreach(int a in v)
    Console.WriteLine("{0,5}", a);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine(" > 순차 탐색할 숫자 입력 : ");
int choice = int.Parse(Console.ReadLine());
int count = 0;

for (int  i = 0;  i < v.Length -1;    i++)
{
    count++;
    if (v[i] == choice)
    {
        Console.WriteLine(" > 인덱스 : [{0}] = {1}", i, choice);
        Console.WriteLine(" > 탐색횟수 : {0}회", i, choice);
        break;
    }
}
*/
// 이진 탐색
Random r = new Random();
int[] v = new int[10];

for (int i = 0; i < v.Length; i++)
    v[i] = r.Next;

Console.WriteLine(" > 정렬 전 랜덤값");
foreach (int a in v)
    Console.Write("{0,5}", a);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine(" > 정렬 후 랜덤값");
Array.Sort(v);
foreach (int a in v)
    Console.Write("{0,5}", a);

Console.WriteLine();
Console.WriteLine();
    

Console.Write("> 이진탐색할 숫자 입력 : ");
int choice = int.Parse(Console.ReadLine());
int count = 0;
int low = 0;
int high = v.Length - 1;
while (low <= high)
{
    count++;
    int mid = (low + high) / 2;

    if (choice == v[mid])
    {
        Console.WirteLine("> 인덱스 : [{0}] = [1]", mid, choice);
        Console.WirteLine("> 탐색 횟수 : {0}회", count);
        break;
    }
    else if (choice > v[mid])
        low = mid + int;
    else
        high = mid - 1;
}
    































