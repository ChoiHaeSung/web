namespace _1107_20240167_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "C# 프로그래밍의 첫 걸음";

            string comlist = "컴퓨터의 종류를 살펴보면" +
          "크게 2가지로 구분할 수 있습니다. \n" +
          "데스크탑 PC와 노트북 PC로 " +
          "선호도는 달라집니다.";

            label2.Text = comlist;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
