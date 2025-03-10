namespace SecondFormOfSecondLaba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = Properties.Settings.Default.StringTextBox;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StringTextBox = textBox1.Text;
            Properties.Settings.Default.Save();

            string message = Logic.Message(this.textBox1.Text);
            MessageBox.Show(message);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.StringTextBox = textBox1.Text;
            Properties.Settings.Default.Save();
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
