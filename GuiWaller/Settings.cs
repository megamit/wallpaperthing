using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace GuiWaller
{
    class Settings
    {
        private string settingsPath;
        private GuiWaller.EnumDisplayMonitorsWrapper.DisplayInfoCollection displayList;
        private Theme theme;
        public string apppath { get; private set; }
        public Settings()
        {
            apppath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"Waller");

            settingsPath = Path.Combine(apppath,"settings.ini");

        }
        public void Save()
        {

        }


        public void FirstLoad()
        {


        }

        public static int getMillisecondDelay()
        {
            return (int)(Properties.Settings.Default.CycleDelay * 1000);
        }
        public void updateDesktopList()
        {
            displayList = new EnumDisplayMonitorsWrapper().GetDisplays();
        }
        public enum Mode
        {
            Disabled,
            Directory,
            Chan,
        }
        public enum CycleMode
        {
            None,
            Consecutive,
            Random
        }
        public enum DisplayCycleMode
        {
            Consecutive,
            Random
        }


        internal Theme BuildTheme()
        {
            
            Theme theme = new Theme();
            switch ((Settings.Mode)Properties.Settings.Default.Mode)
            {
                case(Settings.Mode.Directory):
                    if (Directory.Exists(Properties.Settings.Default.ModeDirectoryPath))
                    {
                        if ((Settings.CycleMode)Properties.Settings.Default.CycleMode == Settings.CycleMode.Random)
                        {
                            theme.source = FileHelper.RandomImageInDirectoryGenerator(
                                Properties.Settings.Default.ModeDirectoryPath,
                                Properties.Settings.Default.SubdirectorySearch
                            );
                        }
                        else if ((Settings.CycleMode)Properties.Settings.Default.CycleMode == Settings.CycleMode.Consecutive)
                        {
                            theme.source = FileHelper.ImageInDirectoryGenerator(
                                Properties.Settings.Default.ModeDirectoryPath,
                                Properties.Settings.Default.SubdirectorySearch
                            );
                        }
                        
                    }
                    break;
                case Settings.Mode.Chan:
                    theme.source = FileHelper.GetImageFrom4chan(false, 20, 5);

                    break;
            }
            Console.WriteLine("new theme set");
            return theme;
        }


    }

}
