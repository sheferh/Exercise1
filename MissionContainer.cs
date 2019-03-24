using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double func(double val);
    public class FunctionsContainer
    {

        private Dictionary<string, func> funcDict;
        public FunctionsContainer()
        {
            funcDict = new Dictionary<string, func>();
        }

        public func this[string nameOfFunc]
        {
            get
            {
                if (!funcDict.ContainsKey(nameOfFunc))
                {
                    funcDict.Add(nameOfFunc, value => value);
                }
                return funcDict[nameOfFunc];
            }

            set
            {
                funcDict[nameOfFunc] = value;
            }
        }
        public List<string> getAllMissions()
        {
            return funcDict.Keys.ToList();
        }
    }
}
