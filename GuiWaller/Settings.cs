using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GuiWaller
{
    class Settings
    {
        private string settingsPath;
        private GuiWaller.EnumDisplayMonitorsWrapper.DisplayInfoCollection displayList;
        private Theme[] themeList;
        private Source[] sourceList;
        private Desktop[] desktopList;
        public Settings()
        {
            settingsPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Waller\\settings.ini"
            );

        }
        public void Save()
        {

        }

        public void Load()
        {

        }

        public void updateDesktopList()
        {
            displayList = new EnumDisplayMonitorsWrapper().GetDisplays();
        }
    }

}
