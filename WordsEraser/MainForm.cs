using System;
using System.Windows.Forms;

namespace WordsEraser
{
    public partial class MainForm : Form
    {
        private static readonly Random Rand = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string text = tbSource.Text;
            string result = string.Empty;
            var words = text.Split(' ');
            foreach (var word in words)
            {
                int flag = Rand.Next(100);
                if (flag < double.Parse(tbFrequency.Text))
                {
                    foreach (var letter in word)
                    {
                        result += letter;
                    }
                }
                else
                {
                    foreach (var letter in word)
                    {
                        if (char.IsLetter(letter))
                        {
                            result += "*";
                        }
                        else
                        {
                            result += letter;
                        }
                    }
                }
                result += " ";
            }

            tbResult.Text = result;
        }
    }
}