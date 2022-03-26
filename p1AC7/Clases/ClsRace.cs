using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1AC7.Clases
{
    internal class ClsRace
    {
        private Carro CarroA;
        private Carro CarroB;


        public void PedirDatosCarrera()
        {
           
            CarroA = GetData();
            Console.WriteLine("Ahora datos del B");
            CarroB = GetData();
        }

        public void IniciarCarrera()
        {
            string msgCarroA, msgCarroB;
            Random velRandom = new Random();

            msgCarroA = CarroA.EncenderMotor();
            msgCarroB = CarroB.EncenderMotor();
            Console.WriteLine($"{CarroA.Marca} {msgCarroA}");
            Console.WriteLine($"{CarroB.Marca} {msgCarroB}");


            for (int i = 0; i < 10; i++)
            {
                int acelera;
                acelera = velRandom.Next(1, 21);
                msgCarroA = CarroA.acelerar(acelera);
                acelera = velRandom.Next(1, 21);
                msgCarroB = CarroB.acelerar(acelera);
                Console.WriteLine($"{i + 1}- {CarroA.owner}:{msgCarroA}  {CarroB.owner}:{msgCarroB}");

            }

            if (CarroA.GetVelocidadActual() > CarroB.GetVelocidadActual())
            {
                Console.WriteLine($"{CarroA.owner} Wins!!!");
            }
            else
            {
                Console.WriteLine($"{CarroB.owner} Wins!!!");
            }

        }




        private Carro GetData()
        {
            string marca;
            int modelo;
            int velocidad;
            string propietario;
            Carro carroTemporal;


            Console.WriteLine("Ingrese marca");
            marca = Console.ReadLine();

            Console.WriteLine("ingrese modelo");
            modelo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese velocidad max");
            velocidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Propietario:");
            propietario = Console.ReadLine();
            carroTemporal = new Carro(marca, modelo, velocidad, propietario);
            return carroTemporal;
        }




    }
}
