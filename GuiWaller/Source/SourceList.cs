using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuiWaller.Source
{
    static class SourceHelper
    {
        public static Source getSourceFromString(string pattern)
        {
            Type t = Type.GetType(pattern);
            if (t == null)
            {
                throw new Exception("Type " + pattern + " not found.");
            }
            return (Source)Activator.CreateInstance(t);
        }
    }
}
