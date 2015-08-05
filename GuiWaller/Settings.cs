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
        public string themepath { get; set; }
        private List<Source.Source> sources;
        public Settings()
        {
            apppath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"Waller");
            themepath = Path.Combine(apppath, "theme.ini");
            settingsPath = Path.Combine(apppath,"settings.ini");
            if (!Directory.Exists(apppath)){
                Directory.CreateDirectory(apppath);
                File.CreateText(themepath).Close();
                File.CreateText(settingsPath).Close();
            }

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
            theme.sourceList = this.LoadSources();


            //switch ((Settings.Mode)Properties.Settings.Default.Mode)
            //{
            //    case(Settings.Mode.Directory):
            //        if (Directory.Exists(Properties.Settings.Default.ModeDirectoryPath))
            //        {
            //            if ((Settings.CycleMode)Properties.Settings.Default.CycleMode == Settings.CycleMode.Random)
            //            {
            //                theme.source = FileHelper.RandomImageInDirectoryGenerator(
            //                    Properties.Settings.Default.ModeDirectoryPath,
            //                    Properties.Settings.Default.SubdirectorySearch
            //                );
            //            }
            //            else if ((Settings.CycleMode)Properties.Settings.Default.CycleMode == Settings.CycleMode.Consecutive)
            //            {
            //                theme.source = FileHelper.ImageInDirectoryGenerator(
            //                    Properties.Settings.Default.ModeDirectoryPath,
            //                    Properties.Settings.Default.SubdirectorySearch
            //                );
            //            }
                        
            //        }
            //        break;
            //    case Settings.Mode.Chan:
            //        theme.source = FileHelper.GetImageFrom4chan(false, 20, 5);

            //        break;
            //}
            //Console.WriteLine("new theme set");
            return theme;
        }



        internal List<Source.Source> LoadSources()
        {
            List<Source.Source> sauceList = new List<Source.Source>();
            string[] sourceFileLines;
            if (!File.Exists(themepath)){
                File.CreateText(themepath).Close();
                sourceFileLines = new string[0];
            }else{
                sourceFileLines = File.ReadAllLines(themepath);
            }
            foreach ( string newSource in sourceFileLines){
                string[] sourceDetails = newSource.Split(",".ToCharArray());
                string sourceType = sourceDetails[0];
                sauceList.Add(Source.SourceHelper.getSourceFromString(sourceType,sourceDetails));
            }
            sources = sauceList;
            return sauceList;
        }
        public void SaveSources()
        {
            string text = "";
            foreach (Source.Source source in sources)
            {
                text = source.ToSaveString() + "\n";
            }
            File.WriteAllText(themepath, text);
        }
    }

}
