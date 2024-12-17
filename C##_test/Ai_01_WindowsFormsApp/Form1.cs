using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ai_01_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> qaPairs;
        private List<Reservation> reservations; // 예약 목록


        public Form1()
        {
            InitializeComponent();
            InitializeQA();
            InitializeReservations(); // 예약 목록 초기화
            DisplayGreeting();
            txtInput.KeyDown += TxtInput_KeyDown; // KeyDown 이벤트 핸들러 추가
            TxtReservationDescription.KeyDown += txtReservationDescription_KeyDown; // KeyDown 이벤트 핸들러 추가
            
        }


        private void InitializeQA()
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
        private void InitializeReservations()
        {
            reservations = new List<Reservation>(); // 예약 목록 초기화
        }
        private void DisplayGreeting()
        {
            lblResponse.Text = "안녕하세요!! 어떤것을 도와드릴까요?('도움'을 쳐보세요!!)"; // 폼 로드 시 인사말 표시
            

        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userInput = txtInput.Text.Trim(); // 사용자 입력 가져오기
            string response;

            // 명령어 처리
            if (userInput.Equals("도움", StringComparison.OrdinalIgnoreCase))
            {
                response = "도움말: '운영 시간', '전화번호', '이용 방법', '예약' 등의 질문을 해주세요.";
            }
            else if (userInput.Equals("종료", StringComparison.OrdinalIgnoreCase))
            {
                response = "프로그램을 종료합니다.";
                Application.Exit(); // 프로그램 종료
            }
            // 인사말 처리
            else if (userInput.Contains("안녕하세요") || userInput.Contains("안녕") || userInput.Contains("안녕하십니까"))
            {
                response = "안녕하세요! 무엇을 도와드릴까요?";
            }
            // 키워드 인식 처리
            else if (userInput.Contains("운영 시간"))
            {
                response = "저희는 오전 9시부터 오후 6시까지 운영합니다.";
            }
            else if (userInput.Contains("전화번호"))
            {
                response = "고객센터 전화번호는 123-456-7890입니다.";
            }
            else if (userInput.Contains("이용 방법"))
            {
                response = "저희 웹사이트를 방문하시면 이용 방법을 확인하실 수 있습니다.";
            }
            else if (userInput.Contains("예약"))
            {
                response = "밑에 날짜와 시간을 정하시고, 성함을 치시면 예약이 됩니다";
            }
            // 정해진 질문에 대한 답변 제공
            else if (qaPairs.TryGetValue(userInput, out string answer))
            {
                response = answer;
            }
            else
            {
                response = "죄송합니다. 그에 대한 답변을 찾을 수 없습니다."; // 기본 응답
            }

            lblResponse.Text = response;
            txtInput.Clear(); // 입력창 초기화
        }
        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter 키가 눌렸는지 확인
            {
                btnSubmit.PerformClick(); // 버튼 클릭 이벤트 호출
                e.SuppressKeyPress = true; // Enter 키의 기본 동작(새 줄 추가 등)을 억제
            }
        }
        private void txtReservationDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter 키가 눌렸는지 확인
            {
                btnAddReservation.PerformClick(); // 버튼 클릭 이벤트 호출
                e.SuppressKeyPress = true; // Enter 키의 기본 동작(새 줄 추가 등)을 억제
            }
        }


        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dateTimePicker.Value; // 선택한 날짜와 시간
            string description = TxtReservationDescription.Text.Trim(); // 예약 설명

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("예약 설명을 입력해 주세요.");
                return;
            }

            // 예약 추가
            reservations.Add(new Reservation { DateTime = selectedDateTime, Description = description });
            UpdateReservationList(); // 예약 목록 업데이트
            TxtReservationDescription.Clear(); // 입력창 초기화
        }
        private void UpdateReservationList()
        {
            listBoxReservations.Items.Clear();  // 기존 항목 제거
            foreach (var res in reservations)   // reservation 대신 res 사용
            {
                listBoxReservations.Items.Add($"{res.DateTime}: {res.Description}");
            }
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            if (listBoxReservations.SelectedItem != null)
            {
                reservations.RemoveAt(listBoxReservations.SelectedIndex); // 선택한 예약 삭제
                UpdateReservationList();
            }
            else
            {
                MessageBox.Show("삭제할 예약을 선택해 주세요.");
            }
        }
        public class Reservation
        {
            public DateTime DateTime { get; set; }
            public string Description { get; set; }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblResponse_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // 초기 텍스트 설정
            TxtReservationDescription.Text = "이름을 입력하세요";
            TxtReservationDescription.ForeColor = Color.Gray;
        }
       
        private void TxtReservationDescription_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void TxtReservationDescription_Enter_1(object sender, EventArgs e)
        {
            if (TxtReservationDescription.Text == "이름을 입력하세요")
            {
                TxtReservationDescription.Text = ""; // 텍스트 지우기
                TxtReservationDescription.ForeColor = Color.Black; // 텍스트 색상 변경
            }
        }

        private void TxtReservationDescription_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtReservationDescription.Text))
            {
                TxtReservationDescription.Text = "이름을 입력하세요"; // 플레이스홀더 텍스트 설정
                TxtReservationDescription.ForeColor = Color.Gray; // 플레이스홀더 색상 설정
            }
        }

        // 타이머

        private List<string> btnReserve = new List<string>();

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "HH:mm"; // 24시간 형식으로 시간과 분만 표시

            if (dateTimePicker != null)
            {
                DateTime selectedDateTime = dateTimePicker.Value;

                // 30분 단위로 반올림
                int minutes = selectedDateTime.Minute;
                int roundedMinutes = (minutes / 30) * 30; // 30분 단위로 반올림
                DateTime roundedDateTime = new DateTime(selectedDateTime.Year, 
                    selectedDateTime.Month, selectedDateTime.Day, selectedDateTime.Hour, roundedMinutes, 0);

                dateTimePicker.Value = roundedDateTime;
            }
        }

        private void AddReservation(DateTime dateTime)
        {
            string reservation = dateTime.ToString("yyyy-MM-dd HH:mm");
            btnReserve.Add(reservation);
            MessageBox.Show($"예약이 추가되었습니다: {reservation}");
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dateTimePicker.Value;
            AddReservation(selectedDateTime);
        }



        private void listBoxReservations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

