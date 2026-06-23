using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap20
{
    internal class GuessGame
    {
        private int _guess, _ans;
        public void Start()
        {
            Random rnd = new Random();
            _ans = rnd.Next(1, 100);
            //Console.WriteLine(_ans);
        }
        public void Guess()
        {
            string s;
            Console.Write("猜數字(1-99):");
            s = Console.ReadLine();
            int.TryParse(s, out _guess);
        }

        public bool GotAns()
        {
            if (_guess < _ans)
                Console.WriteLine("高一點");
            else if (_guess > _ans)
                Console.WriteLine("低一點");
            else
                Console.WriteLine("猜對了");
            return _ans == _guess;
            /*
            if (_ans == _guess)
                return true;
            else
                return false;
            */
        }
    }
}
