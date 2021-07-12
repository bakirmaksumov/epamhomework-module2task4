using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class OutputInfo
    {
        public string inputInfo(string name)
        {
            string _name = name;
            string result = String.Empty;
            if (_name != String.Empty)
            {
                result = $"{DateTime.Now.ToString("h:mm:ss tt")}, Hello {_name}";
                return result;
            }
            else
            {
                result = "No name, please input the name";
                return result;
            }
        }
    }
}
