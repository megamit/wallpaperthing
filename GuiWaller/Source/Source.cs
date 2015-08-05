using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuiWaller.Source
{
    public interface Source 
    {
        string getName();
        string ToSaveString();
        string getDisplayName();
        string getNewWallpaper();
        int runSettingsApplet();
        void LoadFromString(string[] data);
    }
}
