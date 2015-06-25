using GuiWaller.Gui;
using GuiWaller.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GuiWaller
{
    class TrayDaemon : ApplicationContext
    {
        private NotifyIcon trayIcon;
        private Settings settings;
        private Timer ticker;
        private Theme theme;
        public TrayDaemon ()
        {
            // Initialize Tray Icon
            trayIcon = new NotifyIcon();
            trayIcon.Icon = Resources.TrayIcon;
            trayIcon.ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("New Wallpaper",SetRandomWallpapers),
                    new MenuItem("Settings",OpenSettingForm),
                    new MenuItem("Exit", Exit)
                });
            trayIcon.Visible = true;
            ticker = new Timer();
            settings = new Settings();
            settings.updateDesktopList();
            theme = settings.BuildTheme();

            ticker.Interval = Settings.getMillisecondDelay();
            ticker.Tick += tick;
            ticker.Start();
            
        }
        void tick(object sender, EventArgs e)
        {
            if ((Settings.CycleMode)Properties.Settings.Default.CycleMode != Settings.CycleMode.None)
            {
                theme.setNewWallpaper();
            }
            
        }
        void OpenSettingForm(object sender, EventArgs e)
        {
            SettingsForm setForm = new SettingsForm();
            setForm.FormClosed += onSettingFormClose;
            setForm.Show();
        }

        void onSettingFormClose(object sender, EventArgs e)
        {
            ticker.Interval = Settings.getMillisecondDelay();
            theme = settings.BuildTheme();
        }
        
        void SetRandomWallpapers(object sender, EventArgs e)
        {
            tick(sender,e);
        }
        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }
    }
}
