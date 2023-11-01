using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraIMC
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            float p = float.Parse(TxtPeso.Text);
            float a = float.Parse(TxtAltura.Text);
            float resultado = CalculaIMC(p, a);
            CalculaIMC.Text = CalculaIMC = $"IMC: {resultado}";
        }


        private float calculaIMC(float peso,float altura)
        {
            float imc = peso / (altura * altura);
            return imc;
        }

        private String button1_Click(float imc)
        {
            String classifc = "";
            return classifc;
        }

        private void CalculaIMC_Click(object sender, EventArgs e)
        {

        }
    }
}