﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
  public class MPRCL_Usuario
    {

        private int codigoempleado;
        private string nombreempleado;

        public int CodigoEmpleado
        {
            get
            {
                return codigoempleado;
            }

            set
            {
                codigoempleado = value;
            }
        }

        public string NombreEmpleado
        {
            get
            {
                return nombreempleado;
            }

            set
            {
                nombreempleado = value;
            }
        }
    }
}
