using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        private List<func> TheList;
        private string TheName;
        public ComposedMission(string compName)
        {
            TheName = compName;
            TheList = new List<func>();
        }
        string IMission.Type => "Composed";
        string IMission.Name => TheName;
        public double Calculate(double value)
        {
            double val = value;
            foreach (func f in TheList)
            {
                val = f(val);
            }
            if (OnCalculate != null)
            {
                OnCalculate.Invoke(this, val);
            }
            return val;
        }
        public ComposedMission Add(func func)
        {
            TheList.Add(func);
            return this;
        }
    }
}
