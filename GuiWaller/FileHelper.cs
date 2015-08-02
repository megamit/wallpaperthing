using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Linq;

namespace GuiWaller
{
    static class FileHelper
    {
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
        public static IEnumerable<string> RandomImageInDirectoryGenerator(String path,bool sub)
        {
            SearchOption so = sub ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            if (path == null || path == "") yield return null;
            List<string> files = new List<string>(Directory.GetFiles(path,"*",so));
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
        public static string[] GetRandomImagesInDirectory(String path, int count,bool sub)
        {
            SearchOption so = sub ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            List<string> files = new List<string>(Directory.GetFiles(path,"*",so));
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
        public static IEnumerable<string> GetImageFrom4chan(bool isRandom, int imagesPerThread, int minimumImages)
        {
            char[] invalidChars = Path.GetInvalidFileNameChars();
            string targetBoard = "w";
            string chanURL = "http://a.4cdn.org/";
            string imgURL = "http://i.4cdn.org/";
            JArray currentThread;
            Random rng = new Random();
            WebClient c = new WebClient();
            string data = c.DownloadString(chanURL + targetBoard + "/catalog.json");
            Console.WriteLine(chanURL + targetBoard + "/catalog.json");
            currentThread = JArray.Parse(data);
            //look through pages
            foreach (JObject pageToken in currentThread.Children())
            {
                //look through threads on page that are not sticky
                foreach (JObject threadToken in pageToken["threads"].Children())
                {
                    if ( (threadToken.Property("sticky") == null || threadToken.Property("sticky").Equals("0"))
                        && Convert.ToInt32( threadToken.Property("images").Value ) > minimumImages )
                    {
                        Console.WriteLine(threadToken["semantic_url"]);
                        string threadPageTokenString = c.DownloadString(chanURL + targetBoard + "/thread/" + threadToken["no"] + ".json");
                        JObject threadPageArray = JObject.Parse(threadPageTokenString);
                        foreach (JObject post in threadPageArray["posts"].Children())
                        {
                            string url = imgURL
                                + targetBoard
                                + "/" + post["tim"].ToString()
                                + post["ext"].ToString();
                            string filename = new string(
                                (
                                post["filename"].ToString()+ post["ext"].ToString()
                                ).Where(x => !invalidChars.Contains(x)).ToArray());
                            string filepath = Path.Combine(Path.GetTempPath(),  filename);
                            File.Create(filepath).Close();
                            Console.WriteLine(url + " => " + filepath);
                            c.DownloadFile(url ,filepath);

                            yield return filepath;
                        }
                        Console.WriteLine("thread done");
                    }
                }

            }
            Console.WriteLine("" + currentThread.Count + " pages cycled");

        }
        public static void GetImageFrom4chan()
        {
            string targetBoard = "w";
            string chanURL = "http://a.4cdn.org/";
            string imgURL = "http://i.4cdn.org/";
            JArray currentThread;
            Random rng = new Random();
            WebClient c = new WebClient();
            while (true)
            {
                var data = c.DownloadString(chanURL + targetBoard + "/catalog.json");
                Console.WriteLine(chanURL + targetBoard + "/catalog.json");
                currentThread = JArray.Parse(data);
                int count = 0;
                //look through pages
                foreach (JObject pageToken in currentThread.Children())
                {
                    //look through threads on page that are not sticky
                    foreach(JObject threadToken in pageToken["threads"].Children()){
                        if (threadToken.Property("sticky") == null || threadToken.Property("sticky").Equals("0"))
                        {
                            Console.WriteLine(threadToken["semantic_url"]);

                        }
                    }
                    
                }
                Console.WriteLine(""+currentThread.Count+" pages");
                break;
            }

        }

        public static string[] GetAllImagesInDirectory(String path, bool sub)
        {
            List<string> images = new List<string>();
            SearchOption so = sub ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            // select a random file and check it against the list of file types
            foreach (String f in Directory.GetFiles(path,"*",so))
            {

                // this is an image file
                if (f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                    || f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)
                    || f.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                    || f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase)
                    ) images.Add(f);

            }

            return images.ToArray();
        }

        public static string GetWorkingDirectory()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        }

        public static string getTempWallpaperPath()
        {
            return Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
        }
    }

}
