using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPlugins
{
    public partial class Form1 : Form
    {
        private Dictionary<string, PluginInterface> plugins;
        public Form1()
        {

            InitializeComponent();

            plugins = new Dictionary<string, PluginInterface>();
            PluginLoader pl = new PluginLoader();
            ICollection<PluginInterface> items = pl.loadPlugins("Plugins");

            foreach(PluginInterface item in items)
            {
                plugins.Add(item.Name, item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plugins["Hello"].Do();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plugins["Choucroute"].Do();
        }
    }
}
