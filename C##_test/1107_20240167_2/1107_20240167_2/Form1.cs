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
            label1.Text = "C# ���α׷����� ù ����";

            string comlist = "��ǻ���� ������ ���캸��" +
          "ũ�� 2������ ������ �� �ֽ��ϴ�. \n" +
          "����ũž PC�� ��Ʈ�� PC�� " +
          "��ȣ���� �޶����ϴ�.";

            label2.Text = comlist;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
