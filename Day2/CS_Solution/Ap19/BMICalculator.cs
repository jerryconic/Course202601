using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap19
{
    internal class BMICalculator
    {
        private double _height, _weight;

        public string Status()
        {
            double bmi = _weight / _height / _height;
            if (bmi < 18.5)
                return string.Format($"BMI={bmi:0.00}, 體重過輕");
            else if (bmi < 24)
                return string.Format($"BMI={bmi:0.00}, 體重正常");
            else
                return string.Format($"BMI={bmi:0.00}, 體重過重");

        }
        /// <summary>
        /// BMI計算器
        /// </summary>
        /// <param name="height">身高(cm)</param>
        /// <param name="weight">體重(kg)</param>
        public BMICalculator(double height, double weight)
        {
            _height = height / 100;
            _weight = weight;
        }
    }
}
