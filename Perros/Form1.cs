using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Perros
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();

        public static List<Perros> myList = new List<Perros>();
        public static List<Gato> migato = new List<Gato>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            myList.Add(new Perros
            {
                Nombre = txtNombrePerro.Text,
                Raza = txtRaza.Text,
                Edad = int.Parse(txtEdadPerro.Text),
                costo = int.Parse(txtCostoPerro.Text),
            });

            txtNombrePerro.Clear();
            txtRaza.Clear();
            txtEdadPerro.Clear();
            txtCostoPerro.Clear();

            Console.WriteLine("tengo  " + myList.Count);



        }

        private void btnGuardarGato_Click(object sender, EventArgs e)
        {
            migato.Add(new Gato
            {
                Nombre = txtNombreGato.Text,
                ColorPelo = txtColorGato.Text,
                Edad = int.Parse(txtEdadGato.Text),
                Costo = int.Parse(txtCostoGato.Text),
            });
            txtNombreGato.Clear();
            txtColorGato.Clear();
            txtCostoGato.Clear();
            txtEdadGato.Clear();

            Console.WriteLine("tengo " + migato.Count);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {


            dgV_01.DataSource = null;
            dgV_01.DataSource = myList;


        }

        private void btnMostrarGato_Click(object sender, EventArgs e)
        {
            dgV_02.DataSource = null;
            dgV_02.DataSource = migato;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMotrar2_Click(object sender, EventArgs e)
        {

            Raza rz = new Raza();
            // el maximo
            form2.txtMaximo.Text = rz.QueryMaxrazas(myList);

            // llenando el datagridview
            form2.dgvEst.DataSource = rz.QueryListRazas(myList);
            

            form2.ShowDialog();



        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
