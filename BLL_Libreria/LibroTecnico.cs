using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class LibroTecnico : Libro
    {
        private bool _cd;
        public LibroTecnico(string isbn, string name, string autor, double precio, bool cd)
            : base( isbn, name, autor, precio )
        {
            this._cd = cd;
            //Console.WriteLine("Libro Tecnico creado: "+ this._name);
        }

        public override string GetDetalle()
        {
            try
            {
                string detalle = "";

                if (this._cd)
                {
                    detalle += "Contiene un CD adicional";
                }

                return detalle;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public override double GetPrecio()
        {
            try
            {
                if (this._cd)
                {
                    return this._precio + (this._precio * 0.1);
                }
                return this._precio;

            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
