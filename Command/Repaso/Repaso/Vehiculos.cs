using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Vehiculos
    {
        // Access Modifier, sirven para encapsular
        // public, se puede acceder desde cualquier lado
        // private, se puede acceder unicamente en la clase donde fue declarado
        // protected, se puede acceder unicamente en la clase donde fue declarado y sus derivadas (rompe encapsulamiento)
        // internal, se puede acceder en el mismo assembly
        // protected internal, se puede acceder en el mismo assambly y clases derivadas (NO SE USA)
        
        // Attributos de la Clase
        private String _marca;
        private String _modelo;
        private String _numeroSerie;
        private String _encendido;

        // Constructor
        // Se ejecutan siempre primero
        // No se pueden heredar
        public Vehiculos()
        {
            this._marca = "";
            this._modelo = "";
            this._numeroSerie = "";
            this._encendido = "";
        }

        // Constructor, Overloading (Sobrecarga del Constructor) 
        public Vehiculos(String marca)
        {
            this._marca = marca;
            this._modelo = "";
            this._numeroSerie = "";
            this._encendido = "";
        }

        // Getters y Setters

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

        public String getNumeroSerie()
        {
            return _numeroSerie;
        }

        public void setNumeroSerie(String numeroSerie)
        {
            _numeroSerie = numeroSerie;
        }

        public String getEncendido()
        {
            return _encendido;
        }

        // Metodos parte de la clase Vehiculo

        public void encenderVehiculo()
        {
            _encendido = "Llave Encendido"
;        }

        public void apagarVehiculo()
        {
            _encendido = "Llave Apagado";
        }

    }
}
