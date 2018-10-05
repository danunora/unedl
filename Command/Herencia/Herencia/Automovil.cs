using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Automovil : Vehiculo
    {
        private int _llantas;
        private int _puertas;
        private int _velocidades;
        private String _transmision;
        private int _cambioActual;   // gear

        public Automovil()
        {
            this._llantas = 4;
            this._puertas = 4;
            this._velocidades = 5;
            this._transmision = "automatica";
            this._cambioActual = 1;
        }

        public int getPuertas()
        {
            return _puertas;
        }

        public void setPuertas(int m)
        {
            _puertas = m;
        }

        public int getVelocidades()
        {
            return _velocidades;
        }

        public void setTransmision(String m)
        {
            _transmision = m;
        }

        public String getTransmision()
        {
            return _transmision;
        }

    }
}
