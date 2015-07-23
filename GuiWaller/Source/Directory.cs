using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuiWaller.Source
{
    class Directory : Source
    {
        public string getNewWallpaper(){
            return "";
        }
        public static IEnumerable<string> ImageInDirectoryGenerator(String path, bool sub)
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
        public static IEnumerable<string> RandomImageInDirectoryGenerator(String path, bool sub)
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
