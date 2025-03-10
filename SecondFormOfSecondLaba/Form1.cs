namespace SecondFormOfSecondLaba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = Logic.Message(this.textBox1.Text);
            MessageBox.Show(message);
        }
    }

    public class Logic
    {
        public static string Message(string str)
        {
            char[] chars = { ' ', ',', '.', '!', '?', ';', ':' };
            string[] words = str.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            string needword = "";
            string message = "";


            foreach (string word in words)
            {
                if (word.Length % 2 == 1) //если нечетное число букв
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == 'd')
                        {
                            needword += "t";
                        }
                        else
                        {
                            needword += word[i];
                        }
                    }
                    message += needword + " " + needword + " ";
                    needword = "";
                }
            }
            return message;
        }
    }
}
