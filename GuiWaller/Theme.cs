using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GuiWaller
{
    class Theme
    {
        private Random rng = new Random();
        private IEnumerator<string> enumerator;
        private int lastUpdatedDisplay = 0;
        private int lastSource = 0;
        private Settings.CycleMode lastCycleMode = (Settings.CycleMode)Properties.Settings.Default.CycleMode;
        private bool sauce;
        public List<Source.Source> sourceList;
        public IEnumerable<string> source
        {
            set
            {
                if (enumerator != null)  enumerator.Dispose();
                enumerator = value.GetEnumerator();
                }
            }
        private string[] take(int count)
        {
            string[] imgs = new string[count];
            if (sourceList.Count > 0)
                switch((Settings.CycleMode)Properties.Settings.Default.CycleMode){
                    case(Settings.CycleMode.Consecutive):
                        for (int i = 0; i < count; i++)
                        {
                            lastSource = (lastSource + 1) % sourceList.Count;
                            imgs[i] = sourceList[lastSource].getNewWallpaper();
                        }
                        break;
                }
            return imgs;

        }
        private string[] oldtake(int count)
        {
            string[] imgs = new string[count];
            for (int i = 0; i < count; i++)
            {
                enumerator.MoveNext();
                imgs[i] = enumerator.Current;
            }
            return imgs;
        }
        public IEnumerable<string> nullSource()
        {
            yield return null;
        }
        public void setNewWallpaper()
        {
            int count = (new EnumDisplayMonitorsWrapper()).GetDisplays().Count;
            if(count==0) return;
            string[] imgs = take(Properties.Settings.Default.ImagesPerCycle);
            if (imgs.Length == 0) return;
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