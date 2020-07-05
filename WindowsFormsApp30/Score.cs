using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp30
{
    class Score
    {
        int score=10000;
        static object obj = new object();
        public int FirstlyScore { get { return score; } }
        public int CountScore { get { return 10000- score; } }

        public void UpdatePursh(int iteration)
        {
            for (int i = 0; i < iteration; i++)
            {
                if (score > 0)
                {
                    //score--;
                    Interlocked.Decrement(ref score);
                }
            }
        }
    }
}
