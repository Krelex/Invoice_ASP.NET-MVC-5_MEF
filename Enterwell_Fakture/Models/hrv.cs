using Enterwell_Fakture.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;

namespace Enterwell_Fakture.Models
{
    [Export(typeof(IPluginOperation))]
    [ExportMetadata("Symbol", "HR")]
    class hrv : IPluginOperation
    {
        public double Calculation(double UklupnaCijna)
        {
            return ((UklupnaCijna) * 0.25) + (UklupnaCijna);
        }
    }

    [Export(typeof(IPluginOperation))]
    [ExportMetadata("Symbol", "BIH")]
    class bih : IPluginOperation
    {
        public double Calculation(double UklupnaCijna)
        {
            return ((UklupnaCijna) * 0.30) + (UklupnaCijna);
        }
    }
}