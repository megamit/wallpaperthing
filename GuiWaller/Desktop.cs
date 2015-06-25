using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Native;

namespace GuiWaller
{
    public static class Desktop
    {
        public enum Style : int
        {
            Tiled,
            Centered,
            Stretched,
            Fit,
            Fill,
            Span,
            Multi
        }
        public enum ScaleMode : int
        {
            Centre = 0,
            Stretch = 2,
            Fill = 3,
            Fit = 4,
        }
        public static Image ScaleImage(Image img, int width, int height,ScaleMode style)
        {
            Image scaledImg = new Bitmap(width,height);
            Brush BlackBrush = new SolidBrush(Color.Black);
            switch (style)
            {
                case ScaleMode.Stretch:
                    using (Graphics g = Graphics.FromImage(scaledImg)){
                        g.DrawImage(img, 0, 0, width, height);
                    }
                    break;
                case ScaleMode.Fit:
                    
                    if ((float)width / height > (float)img.Width / img.Height)
                    {
                        //if true image will clip on height
                        int newWidth = (int)((float)img.Width * (float)height / img.Height);
                        int xOffset = Math.Abs(newWidth - width) / 2;
                        using (Graphics g = Graphics.FromImage(scaledImg))
                        {
                            g.FillRectangle(BlackBrush, 0, 0, width, height);
                            g.DrawImage(img, xOffset, 0, newWidth, height);
                        }
                        
                    }
                    else
                    {
                        
                        int newHeight = (int)(img.Height *(float)width/img.Width);
                        int yOffset = Math.Abs(newHeight - height) / 2;
                        using (Graphics g = Graphics.FromImage(scaledImg))
                        {
                            g.FillRectangle(BlackBrush,0,0,width,height);
                            g.DrawImage(img, 0, yOffset, width, newHeight);
                        }
                        Console.WriteLine("New Height: " + newHeight);
                        Console.WriteLine("Height: " + height);
                        Console.WriteLine("yOffset: " + yOffset);
                        Console.WriteLine("img Height: " + img.Height);
                        Console.WriteLine("img width: " + img.Width);
                    }
                    break;
                case ScaleMode.Fill:
                    if ((float)width / height < (float)img.Width / img.Height)
                    {
                        //if true image will clip on height
                        int newWidth = (int)((float)img.Width * (float)height / img.Height);
                        int xOffset = Math.Abs(newWidth - width) / -2;
                        using (Graphics g = Graphics.FromImage(scaledImg))
                        {
                            g.DrawImage(img, xOffset, 0, newWidth, height);
                        }
                        
                    }
                    else
                    {
                        
                        int newHeight = (int)(img.Height *(float)width/img.Width);
                        int yOffset = Math.Abs(newHeight - height) / -2;
                        using (Graphics g = Graphics.FromImage(scaledImg))
                        {
                            g.DrawImage(img, 0, yOffset, width, newHeight);
                        }
                    }
                    break;
                case ScaleMode.Centre:
                    int x = (width - img.Width) / 2;
                    int y = (height - img.Height) / 2;
                    using (Graphics g = Graphics.FromImage(scaledImg))
                    {
                        g.FillRectangle(BlackBrush, 0, 0, width, height);
                        g.DrawImage(img, x,y);
                    }
                    break;
                default:
                    goto case ScaleMode.Stretch;
            }
            return scaledImg;
        }
        public static Image getCurrentDesktopImage()
        {
            GuiWaller.EnumDisplayMonitorsWrapper.DisplayInfoCollection info = new EnumDisplayMonitorsWrapper().GetDisplays();
            WALLPAPEROPT wopt = new WALLPAPEROPT();
            wopt.dwSize = WALLPAPEROPT.SizeOf;
            IActiveDesktop iad = shlobj.GetActiveDesktop();
            StringBuilder wallpaperPath = new StringBuilder(128);
            iad.GetWallpaperOptions(ref wopt, 0);
            iad.GetWallpaper(wallpaperPath, 128, 0x00);
            Image wall = Image.FromFile(wallpaperPath.ToString());

            int left = info[0].MonitorArea.left;
            int right = info[0].MonitorArea.right;
            int top = info[0].MonitorArea.top;
            int bottom = info[0].MonitorArea.bottom;
            foreach (GuiWaller.EnumDisplayMonitorsWrapper.DisplayInfo display in info)
            {
                left = (display.MonitorArea.left < left ? display.MonitorArea.left : left);
                top = (display.MonitorArea.top < top ? display.MonitorArea.top : top);
                right = (display.MonitorArea.right > right ? display.MonitorArea.right : right);
                bottom = (display.MonitorArea.bottom > bottom ? display.MonitorArea.bottom : bottom);
            }
            Image img;
            if ((wopt.dwStyle == WallPaperStyle.WPSTYLE_TILE) &&
                wall.Height == bottom - top &&
                wall.Width == right - left)
            {
                img = new Bitmap(wall);
            }
            else
            {
                img = new Bitmap(right - left, bottom - top);
                using (Graphics g = Graphics.FromImage(img))
                {
                    for (int i = 0; i < info.Count; i++)
                    {
                        int x = info[i].MonitorArea.left - left;
                        int y = info[i].MonitorArea.top - top;
                        g.DrawImage(wall, x, y, Convert.ToInt32(info[i].ScreenWidth), Convert.ToInt32(info[i].ScreenHeight));
                    }
                }
            }
            wall.Dispose();
            return img;
        }

        public static Image CompositeMultiWallpaper(string[] storagePaths, int[] displayNumbers)
        {
            GuiWaller.EnumDisplayMonitorsWrapper.DisplayInfoCollection info = new EnumDisplayMonitorsWrapper().GetDisplays();
            //determin virtual desktop dimentions
            int left = info[0].MonitorArea.left;
            int right = info[0].MonitorArea.right;
            int top = info[0].MonitorArea.top;
            int bottom = info[0].MonitorArea.bottom;
            foreach(GuiWaller.EnumDisplayMonitorsWrapper.DisplayInfo display in info){
                left = (display.MonitorArea.left < left ? display.MonitorArea.left:left);
                top = (display.MonitorArea.top < top ? display.MonitorArea.top : top);
                right = (display.MonitorArea.right > right ? display.MonitorArea.right : right);
                bottom = (display.MonitorArea.bottom > bottom ? display.MonitorArea.bottom : bottom);
            }


           Image img = getCurrentDesktopImage();
            using (Graphics g = Graphics.FromImage(img))
            {
                for (int i = 0; i < displayNumbers.Length; i++)
                {
                    if (File.Exists(storagePaths[i]))
                    {
                        Console.WriteLine("Applying: "+storagePaths[i]+" to display " + displayNumbers[i]);
                        Image subImg = ScaleImage(Bitmap.FromFile(storagePaths[i]),
                            Convert.ToInt32(info[ displayNumbers[i] ].ScreenWidth),
                            Convert.ToInt32(info[  displayNumbers[i] ].ScreenHeight),
                            (ScaleMode)Properties.Settings.Default.ScaleMode
                            );
                        int x = info[ displayNumbers[i] ].MonitorArea.left - left;
                        int y = info[ displayNumbers[i] ].MonitorArea.top - top;
                        g.DrawImage(subImg, x, y);
                    }
                }
            }
           
            
            return img;
        }

        public static int Set(String file,Style style, String storagePath,int displayNumber){
            String[] files = {file};
            int[] displays = new int[] { displayNumber };
            return Set(files,style,storagePath,displays);
        }


        public static int Set(String[] file, Style style, String storagePath, int[] displayNumbers)
        {
            try
            {
                System.Drawing.Image img;
                IntPtr result = IntPtr.Zero;
                SendMessageTimeout(FindWindow("Progman", IntPtr.Zero), 0x52c, IntPtr.Zero, IntPtr.Zero, 0, 500, out result);

                IActiveDesktop iad = shlobj.GetActiveDesktop();

                WALLPAPEROPT wopt = new WALLPAPEROPT();
                wopt.dwSize = WALLPAPEROPT.SizeOf;
                iad.GetWallpaperOptions(ref wopt, 0);
                if (style == Style.Tiled) wopt.dwStyle = WallPaperStyle.WPSTYLE_TILE;
                else if (style == Style.Centered) wopt.dwStyle = WallPaperStyle.WPSTYLE_CENTER;
                else if (style == Style.Stretched) wopt.dwStyle = WallPaperStyle.WPSTYLE_STRETCH;
                else if (style == Style.Fit) wopt.dwStyle = WallPaperStyle.WPSTYLE_KEEPASPECT;
                else if (style == Style.Fill) wopt.dwStyle = WallPaperStyle.WPSTYLE_CROPTOFIT;
                else if (style == Style.Span) wopt.dwStyle = WallPaperStyle.WPSTYLE_SPAN;
                else if (style == Style.Multi)
                {
                    wopt.dwStyle = WallPaperStyle.WPSTYLE_TILE;
                }

                if (style == Style.Multi)
                {
                    img = CompositeMultiWallpaper(file,displayNumbers);
                }
                else img = System.Drawing.Image.FromFile(file[0]);

                img.Save(storagePath, System.Drawing.Imaging.ImageFormat.Bmp);

                iad.SetWallpaper(storagePath, 0);

                iad.SetWallpaperOptions(ref wopt, 0);
                iad.ApplyChanges(AD_Apply.ALL | AD_Apply.FORCE | AD_Apply.BUFFERED_REFRESH);

                //double check for debug (probably unneccessary)
                WALLPAPEROPT newWopt = new WALLPAPEROPT();
                iad.GetWallpaperOptions(ref newWopt, 0);
            }
            catch (OutOfMemoryException ex)
            {  // thrown when the file does not have a valid image format or the decoder does not support the pixel format of the file
                Console.WriteLine("\nInvalid file format or the file format is not supported");
                return 1;
            }
            catch (Exception ex)
            { // catch everything else just in case
                Console.WriteLine("<unexpected error>\n\n" + ex.ToString());
                return 1;
            }

            return 0;
        }


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessageTimeout(
                          IntPtr hWnd,      // handle to destination window
                          uint Msg,       // message
                          IntPtr wParam,  // first message parameter
                          IntPtr lParam,   // second message parameter
                            uint fuFlags,
                            uint uTimeout,
                            out IntPtr result

                          );
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, IntPtr ZeroOnly);

    }
}
