using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GuiWaller
{
    class Theme
    {
        private Random rng = new Random();
        private int lastUpdatedDisplay = 0;
        public Theme()
        {
            source = nullSource();
        }
        public IEnumerable<string> source { get; set; }

        public IEnumerable<string> nullSource()
        {
            yield return null;
        }
        public void setNewWallpaper()
        {
            int count = (new EnumDisplayMonitorsWrapper()).GetDisplays().Count;
            if(count==0) return;
            string[] imgs = source.Take(count).ToArray();
            int[] disps = new int[Properties.Settings.Default.ImagesPerCycle];
            if ((Settings.DisplayCycleMode)Properties.Settings.Default.DisplayOrder == Settings.DisplayCycleMode.Consecutive)
                for (int i = 0; i<disps.Length;i++){
                    lastUpdatedDisplay = (lastUpdatedDisplay +1)%count;
                    disps[i] = lastUpdatedDisplay;
                }
            else if((Settings.DisplayCycleMode)Properties.Settings.Default.DisplayOrder == Settings.DisplayCycleMode.Random){
                for (int i = 0; i<disps.Length;i++) disps[i] = rng.Next(count);
                lastUpdatedDisplay = disps[count-1];
                }
            Desktop.Set(imgs,Desktop.Style.Multi,FileHelper.getTempWallpaperPath(),disps);
        }
    }
}