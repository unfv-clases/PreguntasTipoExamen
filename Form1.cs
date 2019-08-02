using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen_Ing_de_software
{
    public partial class Prueba : Form
    {
        int resultado = 0;
        int seleccion = 1;
        public Prueba()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void Iniciar()
        {
            if (MessageBox.Show("Tarea Numero 5", "Evaluacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.pregunta.Text = "1. Es Una Técnica numérica para conducir experimentos en una computadora digital";
                this.opcion1.Text = "Simulación. ";
                this.opcion2.Text = "Simulación de sistemas";
                this.opcion3.Text = "Simulación de eventos discretos.";
                this.opcion4.Text = "Simulación de eventos actuales.";
            }
            else
            {
                Application.Exit();
            }

        }

        private void pregunta2()
        {
            this.pregunta.Text = "2. En el proceso de diseñar y desarrollar un modelo de un" +
                " sistema o proceso real y conducir experimentos con el propósito de" + "\r" +
                " entender el compartamiento del sistema o evaluar varias estrategias " +
                "para la operación del sitema";
            this.opcion1.Text = "Simulación de sistemas.";
            this.opcion2.Text = "Simulación de eventos discretos.";
            this.opcion3.Text = "Simulación de eventos actuales.";
            this.opcion4.Text = "Simulación.";
            seleccion++;
        }
        private void pregunta3()
        {
            this.pregunta.Text = "3. Se basa en el uso de ecuaciones matematicas y estadisticas.";
            this.opcion1.Text = "Simulación";
            this.opcion2.Text = "Simulación de eventos discretos.";
            this.opcion3.Text = "Simulación de eventos actuales.";
            this.opcion4.Text = "Simulación de eventos futuros.";
            seleccion++;
        }
        private void pregunta4()
        {
            this.pregunta.Text = "4. Este proceso consiste en relacionar los diferentes " +
                "eventos que pueden cambiar el estado de un sistema bajo estudio " + "\r"+
                "por medio de distribuciones de probalidad y condiciones lógicas" +
                " del problema que se estén analizando ";
            this.opcion1.Text = "Simulación de eventos discretos";
            this.opcion2.Text = "Simulación de eventos actuales";
            this.opcion3.Text = "Simulación de sistemas";
            this.opcion4.Text = "Simulación de eventos futuros";
            seleccion++;
        }
        private void pregunta5()
        {
            this.pregunta.Text = "5. Cual de las siguientes alternativas NO es parte de la Calidad : ";
            this.opcion1.Text = "Aptitud de uso";
            this.opcion2.Text = "Valor por el patrocinador";
            this.opcion3.Text = "Satisfacción del cliente";
            this.opcion4.Text = "Conformidad con los requisitos";
            seleccion++;
        }
        private void pregunta6()
        {
            this.pregunta.Text = "6. Un director de proyecto está utilizando un histograma para " +
                "analizar defectos"+"encontrados por un equipo durante las actividades"+
                "de inspección ¿Qué proceso está desempeñando?";
            this.opcion1.Text = "Realizar el aseguramiento de la calidad.";
            this.opcion2.Text = "Controlar la calidad.";
            this.opcion3.Text = "Planificar la Gestión de la Calidad";
            this.opcion4.Text = "Verificar el Alcance";
            seleccion++;
        }
        private void pregunta7()
        {
            this.pregunta.Text = "7. Cuál de los siguientes NO es un ejemplo de Costo" +
                "de la Calidad(COQ)";
            this.opcion1.Text = "Constractar inspectores adicionales para buscar defectos";
            this.opcion2.Text = "Hacer que los trabajadores utilicen tiempo extra "+
                "para revisar requisitos de los interesados" ;
            this.opcion3.Text = "Pagar programadores adicionales para ayudar a cumplir con la fecha"+
                "de entrega";
            this.opcion4.Text = "Enviar a un equipo a reparar un producto"+
                "defectuoso que fue entregado al cliente";
            seleccion++;
        }
        private void pregunta8()
        {
            this.pregunta.Text = "8. Usted está trabajando con un equipo de audtoría"+
                "para revisar que todos los proyectos de su compañía satisfagan"+
                "los mismos estándares de calidad.¿Qué proceso se está haciendo";
            this.opcion1.Text = "Realizar la Gestión de la Calidad";
            this.opcion2.Text = "Planificar la Gestión de la Calidad";
            this.opcion3.Text = "Controlar la Calidad";
            this.opcion4.Text = "Gestionar la Calidad";
            seleccion++;
        }
        private void pregunta9()
        {
            this.pregunta.Text = "9. ¿Cuál de los siguientes enunciados NO es parte"+
                "del Plan de Gestión de la Calidad?";
            this.opcion1.Text = "Métricas para medir la calidad de su proyecto";
            this.opcion2.Text = "Una descripción de qué entregables no tienen que ser inspeccionados";
            this.opcion3.Text = "Estrategias para encargarse de defectos y otros problemas de Calidad";
            this.opcion4.Text = "Guía de comó el Equipo de Proyecto implementará la política de calidad de la compañia";
            seleccion++;
        }
        private void pregunta10()
        {
            this.pregunta.Text = "10. Cuándo se realiza una inspección";
            this.opcion1.Text = "En cualquier momento que se produzca un entregable";
            this.opcion2.Text = "Al final del proyecto.";
            this.opcion3.Text = "Sólo antes de entregar el producto final ";
            this.opcion4.Text = "Al inicio del proyecto";
            seleccion++;
        }
        private void Limpiar()
        {
            this.opcion1.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (seleccion)
            {
                case 1:
                    if (this.opcion1.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta2();
                    Limpiar();
                    break;
                    
                case 2:
                     if (this.opcion1.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta6();
                    Limpiar();
                    break;

                case 6:
                    if (this.opcion3.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta7();
                    Limpiar();
                    break;

                case 7:
                    if (this.opcion4.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta8();
                    Limpiar();
                    break;

                case 8:
                    if (this.opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta9();
                    Limpiar();
                    break;
                case 9:
                    if (this.opcion1.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta10();
                    Limpiar();
                    break;

                case 10:
                    if (this.opcion1.Checked == true)
                    {
                        resultado++;
                    }
                    if (resultado == 10)
                    {
                        MessageBox.Show(resultado.ToString(), "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Logro:  "+resultado.ToString()+"  Puntos", "DEBES ATENDER MAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }

                    break;
                default:
                    break;
            }
        }

        private void opcion1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
