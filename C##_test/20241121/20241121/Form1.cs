namespace _20241121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            // 소스 코드 추가
            DateTime today = DateTime.Today;
            DateTime selectdDay = dateTimePicker1.Value;

            textBox1.Text = today.Subtract(selectdDay).
                TotalDays.ToString("0");    
        
        }
    }
}
