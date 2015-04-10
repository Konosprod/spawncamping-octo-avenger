using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlugins
{
    public class PluginChoucroute : PluginInterface
    {
        public string Name
        {
            get
            {
                return "Choucroute";
            }
        }

        public void Do()
        {
            System.Console.WriteLine("Choucroute !");
        }
    }
}
