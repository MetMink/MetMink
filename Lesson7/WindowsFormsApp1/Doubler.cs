using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    delegate void Updater();
    class Doubler
    {
        int finish;
        int count;
        int current;
        int minCount;
        Stack<int> history = new Stack<int>();

        public event Updater StartUpdater;

        public int Finish => finish;
        public int Count => count;
        public int MinCount => minCount;
        public int Current => current;
        public Doubler()
        {
            Random rnd = new Random();
            finish = rnd.Next(1,100);
            current = 1;
            count = 0;
            Min(finish);
            StartUpdater?.Invoke();
        }
        public void Plus()
        {
            history.Push(current);
            current++;
            count++;
            StartUpdater?.Invoke();
        }
        public void Multi()
        {
            history.Push(current);
            current *= 2;
            count++;
            StartUpdater?.Invoke();
        }
        public void Reset()
        {
            history.Clear();
            current = 1;
            count = 0;
            StartUpdater?.Invoke();

        }
        public void Back()
        {
           if(history.Count > 0) current = history.Pop();
            count--;
            if (count < 0)
            {
                MessageBox.Show("Откатывать дальше нельзя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count = 0;
            }
            StartUpdater?.Invoke();
        }
        public void Min(int finish)
        {
            int full = finish;
            for (; full > 1; )
            {
                if (full % 2 == 1)
                {
                    full -= 1;
                    minCount++;
                }
                else if (full % 2 == 0)
                {
                    full /= 2;
                    minCount++;
                }
            }
        }
    }
}
