using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Docking;

namespace Q139656 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            for (int i = 0; i < Screen.AllScreens.Length; i++)
                radioGroup1.Properties.Items.Add(new RadioGroupItem(i, "Screen #" + i.ToString()));
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            dockPanel1.MoveToScreen(new Point(100, 100), radioGroup1.SelectedIndex);
        }
    }
}