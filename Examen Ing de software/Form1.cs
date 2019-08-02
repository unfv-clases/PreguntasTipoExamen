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
                this.pregunta.Text = "Es Una Técnica numérica para conducir experimentos en una computadora digital";
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
            this.pregunta.Text = "En el proceso de diseñar y desarrollar un modelo de un sistema o proceso real y conducir experimentos con el propósito de entender el compartamiento del sistema o evaluar varias estrategias para la operación del sitema";
            this.opcion1.Text = "Simulación de sistemas.";
            this.opcion2.Text = "Simulación de eventos discretos.";
            this.opcion3.Text = "Simulación de eventos actuales.";
            this.opcion4.Text = "Simulación.";
            seleccion++;
        }
        private void pregunta3()
        {
            this.pregunta.Text = "Se basa en el uso de ecuaciones matematicas y estadisticas.";
            this.opcion1.Text = "Simulación";
            this.opcion2.Text = "Simulación de eventos discretos.";
            this.opcion3.Text = "Simulación de eventos actuales.";
            this.opcion4.Text = "Simulación de eventos futuros.";
            seleccion++;
        }
        private void pregunta4()
        {
            this.pregunta.Text = "Este proceso consiste en relacionar los diferentes eventos que pueden cambiar el estado de un sistema bajo estudio por medio de distribuciones de probalidad y condiciones lógicas del problema que se estén analizando ";
            this.opcion1.Text = "Simulación de eventos discretos";
            this.opcion2.Text = "Simulación de eventos actuales";
            this.opcion3.Text = "Simulación de sistemas";
            this.opcion4.Text = "Simulación de eventos futuros";
            seleccion++;
        }
        //private void pregunta5()
        //{
        //    this.pregunta.Text = "Uno de los métodos definidos por TOGAF para el desarrollo de una arquitectura empresarial es: ";
        //    this.opcion1.Text = "ERP(Enterprise Resourse Planing)";
        //    this.opcion2.Text = "CMS(Content Managment System)";
        //    this.opcion3.Text = "ADD (Architecture Development Method)";
        //    this.opcion4.Text = "OLAP(Online Analitic Proccesing)";
        //    seleccion++;
        //}
        //private void pregunta6()
        //{
        //    this.pregunta.Text = "La arquitectura de datos describe:";
        //    this.opcion1.Text = "la estructura de los datos físicos y lógicos de la organización, y los recursos de gestión de estos datos.";
        //    this.opcion2.Text = "la estructura hardware, software y redes requeridas para dar soporte a la implantación de las aplicaciones principales, de misión crítica, de la organización.";
        //    this.opcion3.Text = "la estrategia de negocios, la gobernabilidad, la estructura y los procesos clave de la organización";
        //    this.opcion4.Text = "Ninguna de las anteriores";
        //    seleccion++;
        //}
        //private void pregunta7()
        //{
        //    this.pregunta.Text = "La siguinete definicion: Puede ser interpretado como un repositorio virtual de todos los artefactos arquitectónicos disponibles en una organización. Pertenece a:";
        //    this.opcion1.Text = "Arquitectura de negocios";
        //    this.opcion2.Text = "Modelo empresarial";
        //    this.opcion3.Text = "Metodo de desarrollo de la arquitectura";
        //    this.opcion4.Text = "Continuum Empresarial";
        //    seleccion++;
        //}
        //private void pregunta8()
        //{
        //    this.pregunta.Text = "Son los 3 conceptos básicos de TOGAF:";
        //    this.opcion1.Text = "Entregable, Artefacto, HelpDesk";
        //    this.opcion2.Text = "Entregable, Artefacto, Building block";
        //    this.opcion3.Text = "Servicial, Artefacto, Building block";
        //    this.opcion4.Text = "Ninguno de los anteriores";
        //    seleccion++;
        //}
        //private void pregunta9()
        //{
        //    this.pregunta.Text = "Conforman el contenido del repositorio  de la arquitectura.";
        //    this.opcion1.Text = "Sistema de información";
        //    this.opcion2.Text = "Building block";
        //    this.opcion3.Text = "Entregable";
        //    this.opcion4.Text = "Artefacto";
        //    seleccion++;
        //}
        //private void pregunta10()
        //{
        //    this.pregunta.Text = "Los entregables son:";
        //    this.opcion1.Text = "El resultado de un trabajo que se pide";
        //    this.opcion2.Text = "Es lo que representa la salida de los proyectos dentro de las organizaciones.";
        //    this.opcion3.Text = "Todas las anteriores";
        //    this.opcion4.Text = "Ninguna de las anteriores";
        //    seleccion++;
        //}
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
                    //pregunta10();
                    pregunta4();
                    Limpiar();
                    break;

                //case 4:
                //    if (this.opcion2.Checked == true)
                //    {
                //        resultado++;
                //    }
                //    pregunta5();
                //    Limpiar();
                //    break;

                //case 5:
                //    if (this.opcion3.Checked == true)
                //    {
                //        resultado++;
                //    }
                //    pregunta6();
                //    Limpiar();
                //    break;

                //case 6:
                //    if (this.opcion1.Checked == true)
                //    {
                //        resultado++;
                //    }
                //    pregunta7();
                //    Limpiar();
                //    break;

                //case 7:
                //    if (this.opcion4.Checked == true)
                //    {
                //        resultado++;
                //    }
                //    pregunta8();
                //    Limpiar();
                //    break;

                //case 8:
                //    if (this.opcion2.Checked == true)
                //    {
                //        resultado++;
                //    }
                //    pregunta9();
                //    Limpiar();
                //    break;



                case 4:
                    if (this.opcion1.Checked == true)
                    {
                        resultado++;
                    }
                    if (resultado >= 4)
                    {
                        MessageBox.Show(resultado.ToString(), "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show(resultado.ToString(), "DEBES ATENDER MAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
