using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    public class PluginManager 
    {
        private ArrayList plugins = new ArrayList();
        public void LoadPlugin(IPlug plugin)
        {
            plugins.Add(plugin);
        }
        public void ExecutePlugins()
        {
            foreach(IPlug plugin in plugins)
            {
                plugin.Execute();
            }
        }
    }
}
