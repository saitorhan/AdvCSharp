using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginInterface
{
   public interface IPlugin
    {
        string Guid { get; }
        string Name { get; }
        Form Start();
    }
}
