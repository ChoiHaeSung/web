using System.Windows;

namespace RestaurantReservationApp
{
    public partial class ChatBotWindow : Window
    {
        public ChatBotWindow()
        {
            InitializeComponent();
        }

        // 'Send' 버튼 클릭 시 처리
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string userMessage = ChatTextBox.Text;
            // 여기에 챗봇 로직을 넣을 수 있습니다.
            ChatTextBox.Clear(); // 메시지 전송 후 텍스트박스 초기화
        }
    }
}
