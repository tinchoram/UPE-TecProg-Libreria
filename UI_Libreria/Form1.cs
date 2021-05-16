using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI_Libreria
{
    public partial class FromLibreria : Form
    {
        
        public static List<Libro> ListaLibros = new List<Libro>();

        public FromLibreria()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Carga de datos al cargar el formulario
            dataGridViewLibreria.Columns.Add("isbn", "ISBN");
            dataGridViewLibreria.Columns.Add("name", "Nombre");
            dataGridViewLibreria.Columns.Add("autor", "Autor");
            dataGridViewLibreria.Columns.Add("precio_unit", "Precio Unidad");
            dataGridViewLibreria.Columns.Add("cantidad", "Cantidad");
            dataGridViewLibreria.Columns.Add("precio_total", "Precio Total");

            TextNumeroFactura.Text = "10001";

            //creo libros
            LibroTecnico unLibro1 = new LibroTecnico("0001", "Clean Code", "Robert C. Martin", 200.0, true);
            LibroTecnico unLibro2 = new LibroTecnico("0002", "The Pragmatic Programmer", "Andy Hunt", 300.0, true);
            LibroTecnico unLibro3 = new LibroTecnico("0003", "Python Cookbook", "David M. Beazley", 400.0, false);
            LibroNovela unLibro4 = new LibroNovela("0004", "Rayuela", "Cortazar", 500.0, "Drama");
            LibroNovela unLibro5 = new LibroNovela("0005", "La invención de Morel", "Bioy Casares", 600.0, "Romantica");
            LibroNovela unLibro6 = new LibroNovela("0006", "Papeles en el viento", "Sacheri", 700.0, "Drama");


            ListaLibros.Add(unLibro1);
            ListaLibros.Add(unLibro2);
            ListaLibros.Add(unLibro3);
            ListaLibros.Add(unLibro4);
            ListaLibros.Add(unLibro5);
            ListaLibros.Add(unLibro6);
            //lleno combobox
            foreach (Libro Unlibro in ListaLibros)
            {
                comboBoxLibros.Items.Add(Unlibro.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Me fijo si hay selecionado un libro y la cantidad es mayot a cero
                if ((comboBoxLibros.SelectedItem != null) && (numUpDownLibreria.Value > 0))
                {
                    //Busco en la lista de libros el seleccionado
                    Libro unlibro = ListaLibros.Find(x => x.Name == comboBoxLibros.SelectedItem.ToString());
                    //Leo la cantidad indicada
                    int cantidad = Convert.ToInt32(numUpDownLibreria.Value);

                    //Creo la Row en el dataGrid
                    //dataGridViewLibreria.Rows.Add("isbn", "name", "autor", "precio_unit", "cantidad", "precio_total");
                    dataGridViewLibreria.Rows.Add(  unlibro.Isbn, 
                                                    unlibro.Name, 
                                                    unlibro.Autor, 
                                                    unlibro.GetPrecio().ToString(), 
                                                    cantidad, unlibro.GetPrecio() * cantidad);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar libro y cantidad");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(dataGridViewLibreria.Rows.Count.ToString());
                //Me fijo si hay items cagados en el dataGrid
                if (dataGridViewLibreria.Rows.Count >= 2)
                {
                    //Creo la factura
                    int factura_id = Convert.ToInt32(TextNumeroFactura.Text);
                    Factura unaFactura = new Factura(factura_id);

                    //MessageBox.Show("Factura");
                    //Recorro el dataGrid y cargo los items a la factura
                    foreach (DataGridViewRow row in dataGridViewLibreria.Rows)
                    {
                        if (row.Cells["name"].Value != null)
                        {
                            Libro unlibro = ListaLibros.Find(x => x.Name == row.Cells["name"].Value.ToString());
                            int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                            Item unItem = new Item(unlibro, cantidad);
                            unaFactura.AddItem(unItem);
                        }

                    }
                    //ImprimoFactura
                    textBoxFactura.Text = unaFactura.FacturarItems();

                }
                else
                {
                    MessageBox.Show("No hay items para facturar");
                }



            }
            catch (FormatException ex)
            {
                MessageBox.Show("Numero de factura incorrecto: " + ex.Message.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
