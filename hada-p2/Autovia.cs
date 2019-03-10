using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hada
{
    class Autovia
    {
        //ArrayList<Vehiculo> coches = new ArrayList<Vehiculo>();
        List<Vehiculo> coches = new List<Vehiculo>();

        public Autovia(int nc)
        {
            Vehiculo aux;
            string auxs = "coche_";
            for (int i = 0; i < nc; i++)
            {
                auxs += i;
                aux = new Vehiculo(auxs, 50, 50, 50);
                coches.Add(aux);
                auxs = "coche_";
            }
        }

        public bool moverCoches()
        {
            bool mv = false;
            for (int i = 0; i < coches.Count; i++)
            {
                coches[i].mover();
                if (coches[i].todoOk())
                {
                    mv = true;
                }
            }
            return mv;
        }

        public void moverCochesEnBucle()
        {
            bool it = false;
            do {
                it = moverCoches();
            } while (it);
        }

        public List<Vehiculo> getCochesExcedenLimiteVelocidad()
        {
            List<Vehiculo> ev = new List<Vehiculo>();
            for (int i = 0; i < coches.Count; i++)
            {
                if (coches[i].velocidad > Vehiculo.maxVelocidad)
                {
                    ev.Add(coches[i]);
                }
            }
            return ev;
        }

        public List<Vehiculo> getCochesExcedenLimiteTemperatura()
        {
            List<Vehiculo> et = new List<Vehiculo>();
            for (int i = 0; i < coches.Count; i++)
            {
                if (coches[i].temperatura > Vehiculo.maxTemperatura)
                {
                    et.Add(coches[i]);
                }
            }
            return et;
        }

        public List<Vehiculo> getCochesExcedenMinimoCombustible()
        {
            List<Vehiculo> dc = new List<Vehiculo>();
            for (int i = 0; i < coches.Count; i++)
            {
                if (coches[i].combustible < Vehiculo.minCombustible)
                {
                    dc.Add(coches[i]);
                }
            }
            return dc;
        }

        public override string ToString()
        {
            // List aux = new List();
            string str = "";
            List<Vehiculo> ev = new List<Vehiculo>();
            ev = getCochesExcedenLimiteVelocidad();
            int cev = ev.Count();
            List<Vehiculo> et = new List<Vehiculo>();
            et = getCochesExcedenLimiteTemperatura();
            int cet = et.Count();
            List<Vehiculo> dc = new List<Vehiculo>();
            dc = getCochesExcedenMinimoCombustible();
            int cdc = dc.Count();
            str = "[AUTOVÍA] Exceso velocidad:" + cev + "; Exceso temperatura: " + cet + ": Déficit combustible: " + cdc + "\n";
            for (int i = 0; i < coches.Count; i++)
            {
                coches[i].ToString();
            }
            return str;
        }

        private void cuandoVelocidadMaximaExcedida(Vehiculo c)
        {
            Console.WriteLine("!!Velocidad máxima excedida!!\n");
            Console.WriteLine("Vehículo: " + c.nombre + "\n");
            Console.WriteLine("Velocidad: " + c.velocidad);


        }

        private void cuandoTemperaturaMaximaExcedida()
        {

        }

        private void cuandoCombustibleMinimoExcedido()
        {

        }
    }
}
