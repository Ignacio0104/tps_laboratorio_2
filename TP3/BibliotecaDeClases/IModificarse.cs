using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public interface IModificarse 
    {
        public void ActualizarInfo();
        public void EliminarObjeto();

        public void CargarDatosForm();
    }
}
