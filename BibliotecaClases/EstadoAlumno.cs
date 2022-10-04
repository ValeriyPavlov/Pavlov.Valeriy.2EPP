using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public enum EstadoCursada
    { 
        Regular,
        Libre
    }

    public class EstadoAlumno
    {
        private EstadoCursada _estadoCursada;
        private int _notaExamen;
        private bool _presente;

        public EstadoAlumno()
        {
            _estadoCursada = EstadoCursada.Regular;
            _notaExamen = 0;
            _presente = false;
        }

        public EstadoCursada EstadoCursada { get => _estadoCursada; set => _estadoCursada = value; }
        public bool Presente { get => _presente; set => _presente = value; }
        public int NotaExamen { get => _notaExamen; set => _notaExamen = value; }
    }
}
