using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbEstructura_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbEstructura.SelectedIndex)
            {
                case 1: ListaSimple lista = new ListaSimple();
                        lista.ShowDialog();
                        cmbEstructura.SelectedIndex = 0; break;
                case 2: ListaDoble doble = new ListaDoble();
                        doble.ShowDialog();
                        cmbEstructura.SelectedIndex = 0; break;
                case 3: ListaSimpleCircular lcs = new ListaSimpleCircular();
                        lcs.ShowDialog();
                        cmbEstructura.SelectedIndex = 0; break;
                case 4: ListaDobleCircular ldc = new ListaDobleCircular();
                        ldc.ShowDialog();
                        cmbEstructura.SelectedIndex = 0; break;
                case 5: Pila pi = new Pila();
                        pi.ShowDialog();
                        cmbEstructura.SelectedIndex = 0; break;
                case 6: ColaSimple colasimple = new ColaSimple();  
                        colasimple.ShowDialog(); 
                        cmbEstructura.SelectedIndex = 0; break;
                case 7: ColaCircular colacircular = new ColaCircular();
                        colacircular.ShowDialog();
                        cmbEstructura.SelectedIndex = 0; break;
                case 8: Bicola bicola = new Bicola(); 
                        bicola.ShowDialog(); 
                        cmbEstructura.SelectedIndex = 0; break;
                case 9: ColaPrioridad colaprioridad = new ColaPrioridad();
                        colaprioridad.ShowDialog();
                        cmbEstructura.SelectedIndex = 0; break;
                case 10: ArbolTDA arbol = new ArbolTDA();
                        arbol.ShowDialog();
                        cmbEstructura.SelectedIndex = 0; break;
                case 11: Grafos grf = new Grafos();
                        grf.ShowDialog();
                        cmbEstructura.SelectedIndex = 0; break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEstructura.SelectedIndex = 0;
            cmbAlgoritmo.SelectedIndex = 0;
        }

        private void cmbAlgoritmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbAlgoritmo.SelectedIndex)
            {
                case 1: Burbuja burbu = new Burbuja();
                        burbu.ShowDialog();
                        cmbAlgoritmo.SelectedIndex = 0; break;
                case 2: BurbujaBidireccional burbubi = new BurbujaBidireccional();
                        burbubi.ShowDialog();
                        cmbAlgoritmo.SelectedIndex = 0; break;
                case 3: Inserccion inser = new Inserccion();
                        inser.ShowDialog();
                        cmbAlgoritmo.SelectedIndex = 0; break;
                case 4: Countingsort cs = new Countingsort();
                        cs.ShowDialog();
                        cmbAlgoritmo.SelectedIndex = 0; break;
                case 5: OrdenamientoABcs arbol = new OrdenamientoABcs();
                        arbol.ShowDialog();
                        cmbAlgoritmo.SelectedIndex = 0; break;
                case 6: MezclaDirecta md = new MezclaDirecta();
                        md.ShowDialog();
                        cmbAlgoritmo.SelectedIndex = 0; break;
                case 7: RadixSort rs = new RadixSort();
                        rs.ShowDialog();
                        cmbAlgoritmo.SelectedIndex = 0; break;
                case 8: ShellSort shell = new ShellSort();
                        shell.ShowDialog();
                        cmbAlgoritmo.SelectedIndex = 0; break;
                case 9: Selectionsort ss = new Selectionsort();
                         ss.ShowDialog();
                         cmbAlgoritmo.SelectedIndex = 0; break;
                case 10: Quicksorting rapido = new Quicksorting();
                         rapido.ShowDialog();
                         cmbAlgoritmo.SelectedIndex = 0; break;
            }
        }
    }
}
