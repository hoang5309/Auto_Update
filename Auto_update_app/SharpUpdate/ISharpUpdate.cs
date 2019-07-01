using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;
using System.Windows;

namespace SharpUpdate
{
    public interface ISharpUpdate
    {
        string ApplicationName { get; }
        string ApplicationID { get; }
        Assembly ApplicationAssembly { get; }
        Icon Application { get; }
        Uri UpdateXmlLocation { get; }
        Object context { get; }
    }
}
