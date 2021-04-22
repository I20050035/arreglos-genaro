using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosRegistros
{
    class Producto
    {
        //declaracion de propiedades
        public int Id;
        public string NombreProducto;
        public double PrecioProducto;
        public int ExistenciaProducto;

        //declaracion de metodos get-set

        public int id
        {
            set { value = Id; }
            get { return (Id);}
        }

        public string nombreproducto
        {
            set { value = NombreProducto; }
            get { return (NombreProducto); }
        }

        public double precioproducto
        {
            set { value = PrecioProducto; }
            get { return (PrecioProducto); }
        }

        public int existenciaproducto
        {
            set { value = ExistenciaProducto; }
            get { return (ExistenciaProducto); }
        }

        //declaracion del constructor
        public Producto() 
        {
            Id = 0;
            NombreProducto = "";
            PrecioProducto = 0 ;
            ExistenciaProducto = 0;
        }


    }
}
