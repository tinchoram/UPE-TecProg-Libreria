using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class LibroNovela: Libro
    {
        private string _genero;
        public LibroNovela(string isbn, string name, string autor, double precio, string genero)
            : base(isbn, name, autor, precio)
        {
            this._genero = genero;
            
        }

        public override string GetDetalle()
        {
            string detalle = "";

            detalle += "Novela Genero: " + this._genero;

            return detalle;
        }

    }
}
