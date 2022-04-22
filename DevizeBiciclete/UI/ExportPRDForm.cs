using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevizeBiciclete.UI
{
    public partial class ExportPDFForm : Form
    {
        public ExportPDFForm()
        {
            InitializeComponent();
        }

        private void textBox2_Resize(object sender, EventArgs e)
        {
            textBox2.Margin = new Padding(textBox2.Margin.Left, textBox2.Margin.Top, (int)tableLayoutPanel2.ColumnStyles[1].Width, textBox2.Margin.Bottom);
        }
    }
}
