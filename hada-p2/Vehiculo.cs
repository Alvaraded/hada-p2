using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hada
{
    class Vehiculo
    {
        public static int maxVelocidad
        {
            set;
            get;
        }
        public static int maxTemperatura
        {
            set;
            get;
        }
        public static int minCombustible
        {
            set;
            get;
        }
        public static Random rand
        {
            private get; set;
        }

        private int _velocidad;
        private int _temperatura;
        private int _combustible;

        public string nombre
        {
            get; private set;
        }
        public Vehiculo(string nombre, int velocidad, int temperatura, int combustible)
        {
            this.nombre = nombre;
            _velocidad = velocidad;
            _temperatura = temperatura;
            _combustible = combustible;
        }

        public int temperatura
        {
            set
            {
                if (value > maxTemperatura)
                {
                //    temperaturaMaximaExcedida(this, new TemperaturaMaximaExcedidaArgs(value));
                }
                else
                {
                    _temperatura = value;
                }
            }
            get
            {
                return _temperatura;
            }
        }

        public int combustible
        {
            set
            {
                if (value <= minCombustible)
                {
                  //  combustibleMinimoExcedido(this, new CombustibleMinimoExcedidoArgs(value));
                }
                else
                {
                    _combustible = value;
                }
            }
            get
            {
                return _combustible;
            }

        }

        public int velocidad
        {
            get
            {
                return _velocidad;
            }
            set
            {
                if (value >= maxVelocidad)
                {
                   // velocidadMaximaExcedida(this, new VelocidadMaximaExcedidaArgs(value));
                }
                else
                {
                    if (value < 0)
                    {
                        _velocidad = 0;
                    }
                    else
                    {
                        _velocidad = value;
                    }
                }
            }
        }
        public void incVelocidad()
        {
            try
            {
                //Generamos número aleatorio y aumentamos la velocidad
                velocidad += rand.Next(1, 8);  //Llama a la función de velocidad y la aumenta si corresponde
                //velocidad
           }
            catch (Exception e) {

           }
        }

        public void incTemperatura()
        {
            int tmp;
            try
            {
                //Generamos número aleatorio y llamamos a función para que aumente
                temperatura += rand.Next(1, 6);
            }
            catch(Exception d) {
            }
        }

        public void decCombustible()
        {
            try
            {
                combustible -= rand.Next(1, 6);
            }
            catch (Exception d) {

            }
        }

        public void mover()
        {
            if (this.todoOk())
            {
                this.decCombustible();
                this.incTemperatura();
                this.incVelocidad();
            }
        }
        public bool todoOk()
        {
            bool ok = false;
            if (this.temperatura <= maxTemperatura && this.combustible >= minCombustible)
            {
                ok = true;
            }
            return ok;
        }
        public override string ToString()
        {
            string ok = "False";
            string str = "";
            if (this.todoOk())
            {
                ok = "True";
            }
            str = "[" + this.nombre + "] Velocidad: " + this.velocidad + " km/h; Temperatura " +
                ": " + this.temperatura + "ºC; Combustible: " + this.combustible + " %; Ok: " + ok;
            return str;
        }
    }
}
