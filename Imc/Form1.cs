using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imc
{
    public partial class Form1 : Form
    {
        //validacion
        public void validar_keyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (char.IsDigit(e.KeyChar))
                return;
            

            if (char.IsControl(e.KeyChar))
                return;
            

            if (e.KeyChar == '.' && !textBox.Text.Contains("."))
                return;
                    

                e.Handled = true;
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try { 
                //crear variables
            float peso, altura, pasos, sancada;

                //asignar valores
            pasos = float.Parse(TxtPasosDiarios.Text);
            altura = float.Parse(TxtAltura.Text);
            peso = float.Parse(TxtPeso.Text);
            sancada = float.Parse(TxtSancada.Text);

                //crear objeto
            Clspersona pesona = new Clspersona(peso,altura,pasos,sancada);

                //mostrar datos
            TxtImc.Text =""+ pesona.IMC;
            TxtTipoImc.Text = pesona.TipoImc;
            TxtObjetuvo.Text = pesona.Caminar();
            }
            catch//prevencion de errores
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }
    }
}
