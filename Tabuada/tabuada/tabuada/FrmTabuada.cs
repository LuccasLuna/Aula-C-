using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada
{
    public partial class FrmTabuada : Form
    {
        public FrmTabuada()
        {
            InitializeComponent();
        }

 
        private void FrmTabuada_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click_1(object sender, EventArgs e)
        {
            int calcNumber = Int16.Parse(textNum.Text);
            listResultados.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                int mult = i * calcNumber;
                String result = $" {i} x {calcNumber} = {mult}";
                listResultados.Items.Add(result);
            }
        }

        private void textNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
