using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Docking;

namespace Q139656
{
    public static class DockPanelExtension
    {

        public static void MoveToScreen(this DockPanel dockPanel, Point point, int screenIndex)
        {
            dockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            if (screenIndex < Screen.AllScreens.Length)
            {
                Screen screen = Screen.AllScreens[screenIndex];
                point = new Point(screen.WorkingArea.X + point.X, screen.WorkingArea.Y + point.Y);
                dockPanel.MakeFloat(point);
            }
        }
    }
}
