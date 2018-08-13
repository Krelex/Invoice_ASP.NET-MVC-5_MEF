using Enterwell_Fakture.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionPoint
{

    [Export(typeof(IPluginOperation))]
    [ExportMetadata("Symbol", "Germany")]
    class ger : IPluginOperation
    {
        public double Calculation(double UklupnaCijna)
        {
            return ((UklupnaCijna) * 0.19) + (UklupnaCijna);
        }
    }

    [Export(typeof(IPluginOperation))]
    [ExportMetadata("Symbol", "France")]
    class fra : IPluginOperation
    {
        public double Calculation(double UklupnaCijna)
        {
            return ((UklupnaCijna) * 0.20) + (UklupnaCijna);
        }
    }

    [Export(typeof(IPluginOperation))]
    [ExportMetadata("Symbol", "Finland")]
    class fin : IPluginOperation
    {
        public double Calculation(double UklupnaCijna)
        {
            return ((UklupnaCijna) * 0.20) + (UklupnaCijna);
        }
    }
}
