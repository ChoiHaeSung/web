// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
// 프롬프트만으로 사용

class Program
{
    static void Main()
    {
        // 질문과 답변을 저장할 딕셔너리
        var qaPairs = new Dictionary<string, string>
        {
            { "운영 시간은 언제인가요?", "저희는 오전 9시부터 오후 6시까지 운영합니다." },
            { "위치는 어디인가요?", "저희는 서울 강남구에 위치하고 있습니다." },
            { "연락처는 무엇인가요?", "연락처는 123-456-7890입니다." }
        };

        Console.WriteLine("챗봇에 오신 것을 환영합니다! 질문을 입력하세요.");

        while (true)
        {
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "exit") break; // 'exit' 입력 시 종료

            // 질문에 대한 답변 찾기
            if (qaPairs.TryGetValue(userInput, out string answer))
            {
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("죄송합니다. 그에 대한 답변을 찾을 수 없습니다.");
            }
        }
    }
}
