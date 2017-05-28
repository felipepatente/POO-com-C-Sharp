using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    public class Fatorial
    {
        private double _num;


        public void SetNum(double _num)
        {
            if (_num >= 0)
            {
                this._num = _num;
            }
        }

        public double GetNum()
        {
            return this._num;
        }

        public double GetFatorial()
        {
            int fat = 1;

            for (int i = 1; i <= this._num; i++)
            {
                fat *= i;
            }

            return fat;
        }
    }
}
