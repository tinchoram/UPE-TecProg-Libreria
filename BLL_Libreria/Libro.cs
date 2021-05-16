using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public abstract class Libro
    {
        protected string _isbn;
        protected string _name;
        protected string _autor;
        protected double _precio;



        public Libro(string isbn, string name, string autor, double precio)
        {
            this._isbn = isbn;
            this._name = name;
            this._autor = autor;
            this._precio = precio;
            Console.WriteLine("Libro Creado");
        }

        public string Name
        {
            get { return this._name; }
        }
        public string Autor
        {
            get { return this._autor; }
        }
        public string Isbn
        {
            get { return this._isbn; }
        }

        public virtual double GetPrecio()
        {
            return this._precio;
        }

        public abstract string GetDetalle();
        

    }
}
