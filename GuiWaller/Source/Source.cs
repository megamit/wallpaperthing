using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuiWaller.Source
{
    interface Source 
    {
        string getNewWallpaper();
        int runSettingsApplet();
        static Source loadFromString();
    }
}
