using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Factura
    {
        private int _idFactura;
        private List<Item> _items = new List<Item>();
        private double _totalFactura;


        public Factura(int idFactura)
        {
            this._idFactura = idFactura;
            this._totalFactura = 0.0;
        }

        public void AddItem(Item unItem)
        {
            this._items.Add(unItem);  
        }

        public string FacturarItems()
        {
            try
            {
                string TextFactura = "FACTURA #" + this._idFactura.ToString() + "\r\n";

                foreach (Item item in this._items)
                {
                    TextFactura += "\r\n" + "Isbn: " + item.Libro.Isbn 
                        + " | Nombre: " + item.Libro.Name.ToString()
                        + " | Autor: " + item.Libro.Autor.ToString()
                        + " | Detalle: " + item.Libro.GetDetalle()
                        + " | Precio Unitario $" + item.Libro.GetPrecio()
                        + " | Cantidad: " + item.Cantidad
                        + " | SubTotal $" + item.PrecioTotal;

                    this._totalFactura += item.PrecioTotal;
                }

                TextFactura += "\r\n \r\n --------------------------- \r\n \r\n"
                        + "TOTAL $" + this._totalFactura.ToString();

                return TextFactura;

            }
            catch (Exception)
            {

                throw;
            }
            
        }

    }
}
