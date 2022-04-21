using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevizeBiciclete.Domain;
using DevizeBiciclete.Repo;
using Deviz = DevizeBiciclete.Domain.DevizData;
using Piesa = DevizeBiciclete.Domain.DevizData.PiesaData;
using Manopera = DevizeBiciclete.Domain.DevizData.ManoperaData;
using Constatare = DevizeBiciclete.Domain.DevizData.ConstatareData;
using Bicicleta = DevizeBiciclete.Domain.DevizData.BicicletaData;
using Client = DevizeBiciclete.Domain.DevizData.ClientData;
using Piese = System.Collections.Generic.List<DevizeBiciclete.Domain.DevizData.PiesaData>;
using Manopere = System.Collections.Generic.List<DevizeBiciclete.Domain.DevizData.ManoperaData>;

namespace DevizeBiciclete.UI
{
    public partial class DevizForm : Form
    {
        Deviz deviz;
        public DevizForm()
        {
            InitializeComponent();
            numericUpDownTVA.Value = (decimal)DevizSetari.TVA * 100;
        }

        private void manoperaListControl_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender; if (control == null) return;
            TableLayoutPanel panel = control.Parent as TableLayoutPanel; if (panel == null) return;
            TableLayoutPanelCellPosition pos = panel.GetPositionFromControl(control);
            RowStyle row = panel.RowStyles[pos.Row];
            if (control.Height > row.Height)
            {
                var dif = control.Height - row.Height + control.Margin.Bottom + control.Margin.Top;
                row.Height += (int)dif;
                panel.Height += (int)dif;
            }
            else
            {
                var dif = -control.Height + row.Height;
                row.Height = control.Height + control.Margin.Bottom + control.Margin.Top;
                panel.Height -= (int)dif - (control.Margin.Bottom + control.Margin.Top);
            }
            this.Refresh();
        }
    }
}
