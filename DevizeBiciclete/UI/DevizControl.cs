using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Deviz = DevizeBiciclete.Domain.DevizData;

namespace DevizeBiciclete.UI
{
    public partial class DevizControl : UserControl
    {
        Deviz deviz;
        public DevizControl()
        {
            InitializeComponent();
        }
        
        public Deviz Deviz
        {
            get => deviz;
            set
            {
                deviz = value;
                textBoxNume.Text = value.Client.Nume;
                textBoxTelefon.Text = value.Client.Telefon;
                textBoxIn.Text = value.Constatare.DataInText;
                textBoxOut.Text = value.Constatare.DataOutText;
                numericUpDownPret.Value = (decimal)value.TotalCuTVA;
                textBoxModel.Text = value.Bicicleta.Model;
            }
        }
    }
}
