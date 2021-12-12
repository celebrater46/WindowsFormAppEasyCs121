using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs121
{
    public partial class Form1 : Form
    {
        private ListBox lbx;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Get All Data";
            this.Width = 300;
            this.Height = 200;

            lbx = new ListBox();
            lbx.Dock = DockStyle.Fill;

            var cars = new[]
            {
                new { num = 2, name = "Benz" },
                new { num = 3, name = "Ferrari" },
                new { num = 4, name = "Fuso" },
            };

            // IEnumerable qry = from K in cars select new { K.name, K.num }; // 2, 3, 4
            // IEnumerable qry = from K in cars where K.num <= 3 select new { K.name, K.num }; // 2, 3
            IEnumerable qry = from K in cars where K.num <= 3 orderby K.num descending select new { K.name, K.num }; // 3, 2

            foreach (var tmp in qry)
            {
                lbx.Items.Add(tmp);
            }

            lbx.Parent = this;
        }
    }
}