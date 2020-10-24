using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryClassesArrays
{
    public partial class formArrays : Form
    {
        public formArrays()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            int k = int.Parse(textBoxKElements.Text);
            dataGridViewArray.ColumnCount = k;
            for (int i = 0; i < k; i++)
            {
                dataGridViewArray.Columns[i].HeaderCell.Value = i.ToString();
            }

        }

    }
}
