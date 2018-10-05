using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class AutoDeportivo : Automovil
    {
        private int _puertas;
        private int _velocidades;
        private String _transmision;
        private string _encendido;

        public AutoDeportivo()
        {
            this._puertas = 2;
            this._velocidades = 6;
            this._transmision = "manual";
            this._encendido = "";
        }

        public new string getEstadoMotor()
        {
            return _encendido;
        }

        public new void encenderVehiculo()
        {
            _encendido = "Boton Encendido";
        }

        public new void apagarVehiculo()
        {
            _encendido = "Boton Apagado";
        }

    }
}
