using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlugins
{
    public class PluginHello : PluginInterface
    {
        public string Name
        {
            get
            {
                return "Hello";
            }
        }

        public void Do()
        {
            System.Console.WriteLine("Hello !");
        }
    }
}
