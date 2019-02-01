using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinterVacation04
{
    public partial class Form1 : Form
    {
        DateTime enter = new DateTime ();
        public Form1()
        {
            InitializeComponent();
            enter = DateTime.Now;
            label1.Text = "進場時間: " + enter;
        }
    }
}
