using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc
{
    internal class Clspersona
    {
        //atributos
        private float peso, altura, pasos,kmCaminados, sancada;
        private float imc;
        private string tipoImc="";

        //constructor
        public Clspersona(float peso, float a, float pasos, float sancada)
        {

            this.peso = peso;
            this.altura = a;
            this.pasos = pasos;
            this.sancada = sancada;

            calImc();
        }

        //metodos
        public void calImc()
        {
            imc = peso/(altura * altura);

            if (imc < 18.5)
            {
                tipoImc = "Peso bajo";
            }
            else if (imc >=18.5 && imc<25)
            {
                tipoImc = "Normal";
            }
            else if (imc>=25 && imc<30)
            {
                tipoImc = "Sobre peso";
            }
            else
            {
                tipoImc = "Obesidad";
            }
        }

        public string Caminar()
        {
            kmCaminados = (sancada * pasos)/1000;
            float KmNecesarios=0;
            string Objetivo;

            if (tipoImc == "Obesidad")
            {
                KmNecesarios = 9;

            }
            else if (tipoImc == "Peso bajo")
            {
                KmNecesarios = 5;
            }
            else if (tipoImc == "Normal")
            {
                KmNecesarios = 6.5f;
            }
            else if (tipoImc == "Sobre peso")
            {
                KmNecesarios = 8;
            }

            if (kmCaminados >= KmNecesarios)
            {
                Objetivo = "Cumpliste tu objetuvo";
            }
            else
            {
                Objetivo = "Falta caminar " + (KmNecesarios - kmCaminados) + "Km";
            }

            return Objetivo;
        }

        public string TipoImc
        {
            get { return tipoImc; }
        }
        public float IMC
        {
            get { return imc; }
        }

    }
}
