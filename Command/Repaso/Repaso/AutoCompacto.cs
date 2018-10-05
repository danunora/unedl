﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    // Herencia, Hereda de la clase Vehiculo
    class AutoCompacto : Vehiculos
    {
        // Atributos propios del AutoCompacto
        private int _puertas;
        private String _color;
        private int _velocidades;
        private String _encendido;

        // Constructor
        public AutoCompacto()
        {
            this._puertas = 2;
            this._color = "";
            this._velocidades = 5;
            this._encendido = "";
        }

        // Constructor que hace referencia al contructor de la "base"
        // se ejecuta el constructor de la "base" 
        public AutoCompacto(String marca)
            : base(marca)
        {
        }

        // Poliformismo
        public new string getEncendido()
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
