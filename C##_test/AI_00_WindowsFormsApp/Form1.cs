using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_00_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeQA();
        }

        private void InitializeQA()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 질문과 답변을 매핑하는 Dictionary 초기화
            qaPairs = new Dictionary<string, string>
            {
                { "운영 시간은 언제인가요?", "저희는 오전 9시부터 오후 6시까지 운영합니다." },
                { "안녕하세요", "안녕하세요! 무엇을 도와드릴까요?" },
                { "고객센터 전화번호는?", "고객센터 전화번호는 123-456-7890입니다." },
                { "이용 방법은?", "저희 웹사이트를 방문하시면 이용 방법을 확인하실 수 있습니다." }
            };
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userInput = txtInput.Text.Trim(); // 사용자 입력 가져오기
            if (qaPairs.TryGetValue(userInput, out string answer))
            {
                lblResponse.Text = answer; // 정해진 답변 제공
            }
            else
            {
                lblResponse.Text = "죄송합니다. 그에 대한 답변을 찾을 수 없습니다."; // 기본 응답
            }
            txtInput.Clear(); // 입력창 초기화
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
