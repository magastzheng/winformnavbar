using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavBarDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, System.EventArgs e)
        {
            NavBarItem item;
            item = navBarContainer1.AddBar();
            item.Title = "测试1";
            item.AddTreeViewItem();

            item = navBarContainer1.AddBar();
            item.Title = "测试2";
            item.AddTreeViewItem();

            item = navBarContainer1.AddBar();
            item.Title = "测试3";
            item.AddTreeViewItem();
        }
    }
}
