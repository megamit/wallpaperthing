using GuiWaller.Gui.Source;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GuiWaller.Source
{
    class DirectorySource : Source
    {
        private string path = "";
        private bool useSubfolders = false;
        private int order = 0;
        private string name = "Unnamed";
        IEnumerator<string> filegen;
        public DirectorySource()
        {

        }
        public void LoadFromString(string[] loadString)
        {
            string[] settings = loadString;
            path = settings[1];
            useSubfolders = Convert.ToBoolean(settings[2]);
            order = Convert.ToInt32(settings[3]);
            name = settings[4];
            filegen = RandomImageInDirectoryGenerator(path, useSubfolders).GetEnumerator();
            Console.WriteLine("Source Loaded\n\t" + this.ToSaveString());
        }

        public string getNewWallpaper(){
            filegen.MoveNext();
            if (filegen.Current == null)
            {
                filegen = RandomImageInDirectoryGenerator(path, useSubfolders).GetEnumerator();
                filegen.MoveNext();
            }
            return filegen.Current;
        }

        public string ToSaveString()
        {
            string classname = base.ToString();
            string data = String.Join(",", new string[] { classname, path, useSubfolders.ToString(), order.ToString(), name });
            return data;
        }
        public int runSettingsApplet()
        {
            DirectorySettings settings = new DirectorySettings();
            settings.Path = path;
            settings.Order = (Settings.CycleMode)order;
            settings.UseSubfolders = useSubfolders;
            settings.FormClosing += onSettingsCloseHandler;
            settings.ShowDialog();
            return 0;
        }
        public string getName()
        {
            return name;
        }
        public string getDisplayName()
        {
            return "Folder";
        }
        public void onSettingsCloseHandler(object sender, EventArgs ev)
        {
            DirectorySettings ds = (DirectorySettings) sender;
            if (ds.ExitStatus != 0) return;
            path = ds.Path;
            useSubfolders = ds.UseSubfolders;
            order = (int)ds.Order;
        }
        public IEnumerable<string> ImageInDirectoryGenerator(String path, bool sub)
        {
            int index = 0;
            SearchOption so = sub ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            if (path == null || path == "") yield return null;
            List<string> files = new List<string>(Directory.GetFiles(path, "*", so));
            if (files.Count == 0) yield return null;
            else
            {

                while (true)
                {

                    String f = (String)files[index];
                    // this is an image file
                    if (f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                        || f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)
                        || f.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                        || f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase)
                        ) yield return f;
                    else files.RemoveAt(index);
                    // if the files list is now empty, end the loop
                    if (files.Count == 0) break;
                    index = (index + 1) % files.Count;

                }
            }

            yield return null;
        }
        public IEnumerable<string> RandomImageInDirectoryGenerator(String path, bool sub)
        {
            SearchOption so = sub ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            if (path == null || path == "") yield return null;
            List<string> files = new List<string>(Directory.GetFiles(path, "*", so));
            if (files.Count == 0) yield return null;
            else
            {
                Random rng = new Random(((int)DateTime.Now.Ticks));

                // select a random file and check it against the list of file types
                while (true)
                {
                    // pick a random index from the list
                    int index = rng.Next(files.Count);

                    String f = (String)files[index];
                    // this is an image file
                    if (f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                        || f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)
                        || f.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                        || f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase)
                        ) yield return f;
                    files.RemoveAt(index);

                    // if the files list is now empty, end the loop
                    if (files.Count == 0) break;

                }
            }

            yield return null;
        }
        public static string[] GetRandomImagesInDirectory(String path, int count, bool sub)
        {
            SearchOption so = sub ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            List<string> files = new List<string>(Directory.GetFiles(path, "*", so));
            List<string> images = new List<string>();

            if (files.Count == 0) return null;
            Random rng = new Random(((int)DateTime.Now.Ticks));

            // select a random file and check it against the list of file types
            while (true)
            {
                // pick a random index from the list
                int index = rng.Next(files.Count);

                String f = (String)files[index];
                // this is an image file
                if (f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                    || f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)
                    || f.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                    || f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase)
                    ) images.Add(f);
                files.RemoveAt(index);

                // if the files list is now empty, end the loop
                if (images.Count == count) break;
                if (files.Count == 0) break;

            }

            return images.ToArray();
        }
    }
}
