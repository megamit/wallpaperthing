using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuiWaller.Source
{
    static class SourceHelper
    {
        public static Source getSourceFromString(string pattern, string[] settings)
        {
            Type t = Type.GetType(pattern);
            if (t == null)
            {
                throw new Exception("Type " + pattern + " not found.");
            }
            Source s = (Source)Activator.CreateInstance(t);
            s.LoadFromString(settings);
            return s;
        }
        public static Source getSourceFromString(string pattern)
        {
            Type t = Type.GetType(pattern);
            if (t == null)
            {
                throw new Exception("Type " + pattern + " not found.");
            }
            return (Source)Activator.CreateInstance(t);
        }

        public static Dictionary<string, string> getSourceTypes()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("Folder", typeof(DirectorySource).ToString());
            return dict;
        }
        
    }
}
