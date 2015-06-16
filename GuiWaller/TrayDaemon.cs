using GuiWaller.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GuiWaller
{
    class TrayDaemon : ApplicationContext
    {
        private NotifyIcon trayIcon;
        private Settings settings;
        public TrayDaemon ()
        {
            // Initialize Tray Icon
            trayIcon = new NotifyIcon();
            trayIcon.Icon = Resources.TrayIcon;
            trayIcon.ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("Exit", Exit)
                });
            trayIcon.Visible = true;
            settings = new Settings();
            settings.updateDesktopList();
            settings.Load();
        }
        

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }
    }
}
