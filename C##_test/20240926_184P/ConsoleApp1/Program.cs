// See https://aka.ms/new-console-template for more information

/* 184p
Console.WriteLine("Hello, World!");
int su, count, sum = 0;

count = 1;

Console.Write("누적합을 어디까지 구할까요 : ");
su = int.Parse(Console.ReadLine());

while (count <= su)      // 입력한 수까지 반복문 수행
{
    sum += count;
    count++;

}
Console.WriteLine(" > 1부터 " + su + "까지 누적 합계 : " + sum);
Console.WriteLine(" > 카운트 변수값 : " + count);


// 185p Project Name : WhileIFelseSum
// if...else 조건문으로 음의 정수는 배제하고 양의 정수만 허용하여 누적 합계를 산출 -> 출력하기 위해 다음과 같이 소스 코드를 입력
int su, count, sum = 0;

count = 1;

Console.Write("누적합을 어디까지 구할까요 : ");
su = int.Parse(Console.ReadLine());

if(su < 0)
{
    Console.WriteLine(" > 유효하지 않은 데이터값! ");
    Console.WriteLine(" > 프로그램 종료! ");
}
else
{
    while (count <= su)     // 입력한 수까지 반복문 수행, Repeat until the number entered.
    {
        sum += count;
        count++;
    }
    Console.WriteLine(" > 1부터 " + su + "까지 누적 합계 : " + sum);
    Console.WriteLine(" > 카운트 변수값 : " + count);
}


// 187p  Project Name : DoWhile
// do...while 반복문으로 exit 문자열이 입력될 때까지 문자열 입력 명령을 반복 수행
int count = 1;
string s;

Console.WriteLine("문자열 exit가 입력되면 종료");

do
{
    Console.Write(" > " + count + "회문자열 :");
    s = Console.ReadLine();
    count++;
} while (s != "exit");
Console.WriteLine(" > 반복 수행 횟수 : " + (count - 1) + "회");


// 190p Project Name : ForSum
// for 반복문으로 1부터 입력한 수까지 누적되는 합계를 산출
int count, su, sum = 0;

Console.Write("누적합을 어디까지 구할까요 : ");
su = int.Parse(Console.ReadLine());

for(count =1; count <= su; count++)
{
    sum += count; // sum = sum + count;
}    
Console.WriteLine(" > 1부터 " + su + "까지 누적 합계 : " + sum);
Console.WriteLine(" > 카운트 변수값 : " + count);


// 191p Project Name : ForIFesleSum
// if.else 조건문으로 음의 정수는 배제하고 양의 정수만 허용
int count, su, sum = 0;

Console.Write("누적합을 어디까지 구할까요 : ");
su = int.Parse(Console.ReadLine());

if (su < 0)
{
    Console.WriteLine(" > 유효하지 않은 데이터값!");
    Console.WriteLine(" > 프로그램 종료!");
}
else
{

    for (count = 1; count <= su; count++)
    {
        sum += count; // sum = sum + count;
    }
    Console.WriteLine(" > 1부터 " + su + "까지 누적 합계 : " + sum);
    Console.WriteLine(" > 카운트 변수값 : " + count);
}


// 192p Project Name ForGugudan
// for 반복문으로 입력한 숫자의 구구단을 출력
int dan, count, gob;

Console.Write("출력할 구구단:");
dan = int.Parse(Console.ReadLine());

if (dan < 2 || dan > 99)
{
    Console.WriteLine(" > 유효하지 않은 데이터값!");
    Console.WriteLine(" > 프로그램 종료! ");
}
else
{
    for (count = 1; count <= 9; count++)
    {
        gob = dan * count;
        Console.WriteLine(dan + " * " + count + " = " + gob);
    }
}


//194p Project Name ForNestingGugudan
// 중첩된 for 반복문으로 구구단을 출력
int dan, count, gob;

for (dan = 2; dan <= 9; dan++)
{
    for (count = 1; count <= 9; count++)
    {
        gob = dan * count;
        Console.WriteLine(dan + " * " + count + " = " + gob);
    }
    Console.WriteLine();
}


// 195p Project Name : ForNestingStar
// 중첩된 for 반복문으로 *을 5개부터 1개까지 개수가 1개씩 점차 줄어들게 수행
int star, count;

 for(count = 1; count <=1; count++)
{
    for (star = 5; star >= count; star--)
        {
        Console.Write("☆");
    }
    Console.WriteLine();
}

// 원하는 별의 갯수 선정
int count, star;

Console.Write("출력할 별의 갯수: ");
int inNum = int.Parse(Console.ReadLine());

for (count = 1; count <= inNum; count++)
{
    for (star = 1; star <= count; star++)
        {
        Console.Write("☆");
    }
    Console.WriteLine();
}


// 198p Project Name. DowhileBreak
// dp.while 반복문으로 1부터 100까지 누적 합계를 산출합니다
// 그리고 누적합이 500을 넘게 되면 반복문을 빠져나옵니다
int count = 1, sum = 0;

Console.WriteLine("누적합이 500을 넘으면 프로그램 종료");
do
{
    if (sum > 500)
    {
        Console.WriteLine(" > 누적합 500 초과! ");
        break;
    }
    else
    {
        sum += count; // sum = sum + count;
    }
    count++;
} while (count <= 1000); // 또는 WHile (true) -> 무한 반복문 구현 기능

Console.WriteLine(" > 누적 합계 : " + sum);


// 200p Project ForContinue
// for 반복문을 사용하여 1부터 10까지의 숫자 중 홀수만 출력
// 홀수는 나머지 연산자(%)와 continue 점프문을 사용하여 판별
int count;

Console.WriteLine("홀수만 출력하는 프로그램 ");
Console.Write(">");

for (count = 1; count <= 10; count++)
{
    if(count %2 == 0)
    {
        continue;
    }
    Console.Write(count + " ");
}


// 201p Project Name. WhileGoto
// 콘솔 창에서 입력한 수가 음의 정수 데이터값일 경우 goto 점프문을 선언
// 그리고 다시 입력하도록 수행
int su, count, sum = 0;

count = 1;

replay:
Console.Write("누적합을 어디까지 구할까요: ");
su = int.Parse(Console.ReadLine());

if ( su < 0)
{
    Console.WriteLine(" > 유효하지 않은 데이터값! ");
    Console.WriteLine();
    goto replay;
}
else
{
    while (count <= su)     // 입력한 수까지 반복문 수행
    {
        sum += count;
        count++;
    }
    Console.WriteLine(" > 1부터 "+ su + "까지 누적 합계 : " + sum);
    Console.WriteLine(" > 카운트 변수값 : " + count);

}
*/


/* 문제 1: While 루프 - 홀수 항목의 총 가격
 설명 : 당신은 슈퍼마켓에 가서 홀수 가격의 품목만 구입하기로 결정했습니다.
A와 B(A <= B)라는 두 가지 가격이 제공됩니다. 'A'와 'B' 사이의 모든 홀수 항목의 
총 가격을 계산하는 프로그램을 작성하세요
*/
int A, B, sum = 0;

Console.Write(" A의 값을 입력하세요 :");
A = int.Parse(Console.ReadLine());
Console.Write(" B의 값을 입력하세요 :");
B = int.Parse(Console.ReadLine());

if (A <0 || A < B)
{
    Console.WriteLine("다시 입력하세요");
}













































/* 문제 2: While 루프 – 자동차 연료 공급

**설명:**

당신은 자동차에 연료를 공급하고 있으며 총 연료량이 특정 목표에 도달하면 멈추기로 결정했습니다. 
연료를 공급할 때마다 다른 양의 연료를 무작위로 추가합니다. 연료량을 하나씩 입력받아 
총 연료량이 목표 연료량 'T'와 같거나 초과하면 멈추는 프로그램을 작성하세요.

**입력 예:**
T = 50
연료량: 15 10 20 10
* *출력 예: **
연료가 완성되었습니다.총 연료: 55
*/

/*
문제 3: While 루프 – 대출금 상환

**설명:**

당신은 대출을 받았고 그것을 할부로 갚아야 합니다. 매달 다른 금액을 지불하게 됩니다. 대출금 상환을 시뮬레이션하고 대출금이 완전히 상환될 때까지 각 지불 후 남은 대출금을 인쇄하는 프로그램을 작성하세요.

**입력 예:**
대출금액 : 1000 

상환 : 300 400 200 150
**출력 예:**
남은 대출 : 700

남은 대출 : 300

남은 대출 : 100

대출 상환 완료!
*/
/*
 문제 4: For 루프 – 주차장에 있는 자동차 수 세기

**설명:**

당신은 하루 종일 자동차가 들어오고 나가는 주차장을 모니터링하고 있습니다. 매 시간마다 얼마나 많은 차량이 진입했는지 확인합니다. 주어진 시간 동안 주차장에 진입하는 자동차 수를 추적하고 마지막에 총 자동차 수를 출력하는 프로그램을 작성하세요.

**입력 예:**
추적시간 : 4
시간별 차량 수 : 5 8 4 6
* *출력 예: **
총 차량 수 : 23
*/

/*
### **문제 5 : For문과 If문 – 유통기한이 지난 제품 확인하기**

* *설명:**

당신은 가게에서 제품들의 유통기한을 확인하고 있습니다. 각 제품은 유통기한까지 남은 일수가 있습니다. 프로그램은 제품의 개수와 각 제품의 유통기한을 입력받고, 유통기한이 지난 제품들(남은 일수가 0일 이하)을 출력하세요.

**입력 예시:**

제품의 개수: 5
각 제품의 유통기한(일): 10 - 1 3 0 - 5

* *출력 예시: **

2번째 제품은 유통기한이 지났습니다.
4번째 제품은 유통기한이 지났습니다.
5번째 제품은 유통기한이 지났습니다.

*/

/*
### **문제 6 : For문과 If문 – 비 오는 날 수 세기**

**설명:**

한 주 동안 날씨를 기록하고, 비가 온 날의 수를 계산하는 프로그램을 작성하세요. 사용자로부터 각 날의 날씨 정보를 입력받고, 비가 온 날을 출력하세요. 비가 온 날은 "비"라는 단어로 입력됩니다.

**입력 예시:**

코드 복사
한 주 동안의 날씨: 맑음 비 비 흐림 맑음 비 맑음

**출력 예시:**

비가 온 날은 총 3일입니다.
*/

/*
### 문제7: 주사위

3개의 주사위는 각각 1에서 6까지의 숫자를 가질 수 있습니다. 주어진 정수 `N`이 주어졌을 때, 세 주사위의 눈 합이 `N`이 되는 경우의 수와 그 경우의 수의 개수를 출력하는 프로그램을 작성하세요.

### 입력:

정수 `N` (3 ≤ N ≤ 18)

### 출력:

세 주사위의 눈 합이 `N`이 되는 경우와 그 경우의 수를 출력하세요.

입력 예시:

15

출력 예시:
(3, 6, 6)
(4, 5, 6)
(4, 6, 5)
(5, 4, 6)
(5, 5, 5)
(5, 6, 4)
(6, 3, 6)
(6, 4, 5)
(6, 5, 4)
(6, 6, 3)
경우의 수: 10

*/













