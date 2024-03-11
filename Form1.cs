namespace strTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Properties.Settings.Default.str = textBox1.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show(Logic.solver(textBox1.Text));
            }
        }
    }
    public class Logic
    {
        public static string solver(string str)
        {
            char[] word;
            if (str.Length % 2 == 0)
            {
                word = str.ToCharArray();
                for (int i = 0; i < str.Length - 1; i += 2)
                {
                    char temp = word[i];
                    word[i] = word[i + 1];
                    word[i + 1] = temp;
                }
                return (new string(word));
            }
            else
            {
                return "Слово с нечётным количеством символом";
            }
        }
    }
}
