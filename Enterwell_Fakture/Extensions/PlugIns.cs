using Enterwell_Fakture.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;

namespace Enterwell_Fakture.Models
{
    [Export(typeof(IPluginOperation))]
    [ExportMetadata("Symbol", "Croatia")]
    class hrv : IPluginOperation
    {
        public double Calculation(double UklupnaCijna)
        {
            return ((UklupnaCijna) * 0.25) + (UklupnaCijna);
        }
    }

    [Export(typeof(IPluginOperation))]
    [ExportMetadata("Symbol", "Bosnia and Herzegovina")]
    class bih : IPluginOperation
    {
        public double Calculation(double UklupnaCijna)
        {
            return ((UklupnaCijna) * 0.17) + (UklupnaCijna);
        }
    }
}