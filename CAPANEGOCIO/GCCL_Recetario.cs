using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
    class Recetario
    {
        private int idrecetario;
        private DateTime fechacreacion;
        private string nombre;
        private string descripcion;
        private double totalcantidad;
        List<RecetarioDet> det;

        public int IdRecetario
        {
            get
            {
                return idrecetario;
            }

            set
            {
                idrecetario = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return fechacreacion;
            }

            set
            {
                fechacreacion = value;
            }
        }

        public string NombreRecetario
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string DescripcionRecetario
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public double TotalCantidadProducto
        {
            get
            {
                return totalcantidad;
            }

            set
            {
                totalcantidad = value;
            }
        }
    }

    class RecetarioDet
    {
        private int iddetrecetario;
        private double cantidadproducto;
        private int idrecetarioencabezado;
        public int IdDetRecetario
        {
            get
            {
                return iddetrecetario;
            }

            set
            {
                iddetrecetario = value;
            }
        }

        public double CantidadProducto
        {
            get
            {
                return cantidadproducto;
            }

            set
            {
                cantidadproducto = value;
            }
        }

        public int IdRecEncabezado
        {
            get
            {
                return idrecetarioencabezado;
            }

            set
            {
                idrecetarioencabezado = value;
            }
        }
    }
}
