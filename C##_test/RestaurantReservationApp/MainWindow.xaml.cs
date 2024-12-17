using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RestaurantReservationApp
{
    public partial class MainWindow : Window
    {
        private List<DateTime> reservedDates;
        public MainWindow()
        {
            InitializeComponent();
            reservedDates = new List<DateTime>
            {
                new DateTime(2024, 12, 15),
                new DateTime(2024, 12, 16),
                new DateTime(2024, 12, 17),
                new DateTime(2024, 12, 18),
                new DateTime(2024, 12, 19),
                new DateTime(2024, 12, 20),
            };
        }
        private void ReservationDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = ReservationDatePicker.SelectedDate;

            if (selectedDate.HasValue)
            {
                // 선택된 날짜에 대한 예약 상태를 확인
                int reservationCount = 0;
                foreach (var reservedDate in reservedDates)
                {
                    if (reservedDate.Date == selectedDate.Value.Date)
                    {
                        reservationCount++;
                    }
                }

                // 예약 상태에 따라 색상 변경
                if (reservationCount >= 6)
                {
                    ReservationDatePicker.Background = System.Windows.Media.Brushes.Green; // 초록색
                }
                else if (reservationCount >= 4)
                {
                    ReservationDatePicker.Background = System.Windows.Media.Brushes.Yellow; // 노란색
                }
                else
                {
                    ReservationDatePicker.Background = System.Windows.Media.Brushes.Red; // 빨간색
                }
            }
        }

        // 예약 리스트 보기 버튼 클릭 시
        private void OnViewReservationListClick(object sender, RoutedEventArgs e)
        {
            // 입력된 데이터를 받아오기
            string seat = SeatSelectionComboBox.SelectedItem.ToString();
            string time = ReservationTimeComboBox.SelectedItem.ToString();
            DateTime date = ReservationDatePicker.SelectedDate.Value;

            // Reservation 객체 생성
            Reservation newReservation = new Reservation
            {
                Date = date,
                Time = time,
                Seat = seat
            };

            // ReservationListWindow 창을 열고 데이터를 전달
            ReservationListWindow reservationWindow = new ReservationListWindow();
            reservationWindow.AddReservation(newReservation);
            reservationWindow.Show();  // 예약 리스트 창 열기
        }
        public class Reservation
        {
            public DateTime Date { get; set; }
            public string Time { get; set; }
            public string Seat { get; set; }
        }

        private void SeatSelectionComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var selectedSeat = (System.Windows.Controls.ComboBoxItem)SeatSelectionComboBox.SelectedItem;
            MessageBox.Show($"선택된 좌석: {selectedSeat.Content}");
        }

        private void MenuSelectionComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var selectedMenu = (System.Windows.Controls.ComboBoxItem)MenuSelectionComboBox.SelectedItem;
            MessageBox.Show($"선택된 코스: {selectedMenu.Content}");
        }

        private void OnSaveRequestClick(object sender, RoutedEventArgs e)
        {
            string specialRequest = SpecialRequestTextBox.Text;
            MessageBox.Show($"특별 요청사항: {specialRequest}");

            // 날짜와 시간 가져오기
            DateTime selectedDate = ReservationDatePicker.SelectedDate ?? DateTime.Now; // 날짜 선택 안 한 경우 현재 날짜 사용
            string selectedTime = ReservationTimeComboBox.SelectedItem?.ToString();

            // 예약 정보 출력 (예시)
            MessageBox.Show($"예약 날짜: {selectedDate.ToShortDateString()}\n예약 시간: {selectedTime}");

        }

        private void OnParkingInfoClick(object sender, RoutedEventArgs e)
        {
            ParkingInfoTextBlock.Text = "레스토랑 앞에 무료 주차 공간이 있습니다.";
            ParkingInfoTextBlock.Visibility = Visibility.Visible;
        }

        private void OpenChatBotWindow(object sender, RoutedEventArgs e)
        {
            // ChatBotWindow 창 열기
            ChatBotWindow chatBotWindow = new ChatBotWindow();
            chatBotWindow.Show();  // 챗봇 창을 화면에 띄운다
        }
    }
}
