using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace WindowsFormsApp30
{
    public partial class Form1 : Form
    {
        Score Score;
        public Form1()
        {
            Score = new Score();
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Schet.Text = Score.FirstlyScore.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                Thread[] threads = new Thread[20];
                Action<int> action = delegate (int iteration) { Score.UpdatePursh(iteration); };
                for (int i = 0; i < 20; i++)
                {
                    var operation = new ParameterizedThreadStart(obj => action((int)numericUpDown1.Value));
                    threads[i] = new Thread(operation);
                    threads[i].Start();
                }
                Snato.Text = Score.CountScore.ToString();
                Schet.Text = Score.FirstlyScore.ToString();

        }
    }
}
