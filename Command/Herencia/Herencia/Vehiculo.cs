using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Vehiculo
    {
        private String _marca;
        private String _modelo;
        private int _velocidadActual;
        private int _direccionActual;
        private string _encendido;

        public Vehiculo()
        {
            this._marca = "";
            this._modelo = "";
            this._velocidadActual = 0;
            this._direccionActual = 0;
            this._encendido = "";
        }

        public String getMarca()
        {
            return _marca;
        }

        public void setMarca(String marca)
        {
            _marca = marca;
        }

        public String getModelo()
        {
            return _modelo;
        }

        public void setModelo(String modelo)
        {
            _modelo = modelo;
        }

        public int getVelocidadActual()
        {
            return _velocidadActual;
        }

        public void setVelocidadActual(int velocidadActual)
        {
            _velocidadActual = velocidadActual;
        }

        public int getDireccionActual()
        {
            return _direccionActual;
        }

        public void setDireccionActual(int direccionActual)
        {
            _direccionActual = direccionActual;
        }

        public string getEstadoMotor()
        {
            return _encendido;
        }

        public void encenderVehiculo()
        {
            _encendido = "Llave Encendido";
        }

        public void apagarVehiculo()
        {
            _encendido = "Llave Apagado";
        }
    }
}