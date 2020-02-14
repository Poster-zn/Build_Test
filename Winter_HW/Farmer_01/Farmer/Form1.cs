using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer
{
    public partial class Form1 : Form
    {
        List<string> _list;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetListBoxes();
        }

        private void CreateList()
        {
            _list = new List<string>()
            {
                 "農夫", "羊", "菜","狼"
            };

        }

        private void SetListBoxes()
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;           

            listBox1.DataSource = _list.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _list.Remove("農夫");

        }
    }
}
