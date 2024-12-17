using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RestaurantReservationApp
{
    public partial class ReservationListWindow : Window
    {
        // 예약 데이터를 담을 리스트
        private List<Reservation> reservations = new List<Reservation>();

        public ReservationListWindow()
        {
            InitializeComponent();
        }

        // 메인 폼에서 예약 데이터를 추가할 메서드
        public void AddReservation(Reservation reservation)
        {
            // 예약을 리스트에 추가
            reservations.Add(reservation);

            // 리스트를 갱신하여 화면에 표시
            UpdateReservationList();
        }

        internal void AddReservation(MainWindow.Reservation newReservation)
        {
            throw new NotImplementedException();
        }

        // ListBox에 예약 리스트를 업데이트하는 메서드
        private void UpdateReservationList()
        {
            // 기존 리스트를 비우고, 예약 데이터를 새로 추가
            ReservationListBox.Items.Clear();

            foreach (var reservation in reservations)
            {
                // 예약 정보를 "날짜 시간 - 좌석" 형식으로 ListBox에 추가
                ReservationListBox.Items.Add($"{reservation.Date:yyyy-MM-dd} {reservation.Time} - {reservation.Seat}");
            }
        }
    }

    // 예약 정보 클래스
    public class Reservation
    {
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Seat { get; set; }
    }
}
