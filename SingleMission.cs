using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private func f;
        private string theName;
        public SingleMission(func theFunc, string funcName)
        {
            f = theFunc;
            theName = funcName;
        }
        string IMission.Name => theName;
        public event EventHandler<double> OnCalculate;
        string IMission.Type => "Single";

        public double Calculate(double v)
        {
            double theValue = f(v);
            if (OnCalculate != null)
            {
                OnCalculate.Invoke(this, theValue);
            }
            return theValue;
        }
    }
}
