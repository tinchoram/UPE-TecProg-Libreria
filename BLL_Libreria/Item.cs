using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Item
    {
        //private int item_id;
        private Libro _libro;
        private int _cantidad;
        private double _precioTotal;

        public Item(Libro unlibro, int cantidad)
        {
            this._libro = unlibro;
            this._cantidad = cantidad;
            this._precioTotal = unlibro.GetPrecio() * cantidad;
        }

        public Libro Libro
        {
            get { return this._libro; }
        }

        public int Cantidad
        {
            get { return this._cantidad; }
        }

        public double PrecioTotal
        {
            get { return this._precioTotal; }
        }
    }

}
