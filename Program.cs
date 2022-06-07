using System;
/**
Cocinero: producir hambuerguesa entre 30 y 50s 
S: cocinero.producirHambur()
Empleado: pagar 45s más 10 segundos por hamburguesa
S: vendedor.pagar()
almacenar hamb
S:Linea 25 (int hamburProducidas =0)
cliente cada 2min (add lista = fila)
S:
si hay mas de 3 personas, que se active la funcion (quedarse o irse) 1/4 random
S:
periodo total de 4hrs
S:
las personas no pueden ser atendidas si no hay las suficientes hamburguesas para el pedido.
funcion de hacer pedido: cuantas hamb, pagar

Preguntas:
a) El número total de de clientes que llegan, y el número total de clientes perdidos.
b) El tiempo medio que debe esperar un cliente para tener su pedido.
c) El porcentaje de tiempo que los empleados son productivos.
d) El número máximo de clientes que llegan a esperar ser atendidos.
**/


namespace burgerDCI{
    class Program{
        static void Main(string[]args){
            Empleado cocinero = new Empleado("Cocinero");
            Empleado vendedor = new Empleado("Vendedor");
            int tiempoFinal = 14400;
            int tiempoActual = 0; 
            int hamburProducidas = 0;

            //simulacion de la fila de clientes
            List<string> fila = new List<string>();
            List<string> clientesAtendidos = new List<string>();
            List<string> clientesPerdidos = new List<string>();

            //matriz que almacene cuanto demora en envolver y cobrar
            //...

            //manejo de clientes
            fila.Add("cliente");
            fila.Remove("cliente");

            
            int llegadaCliente =0;
            int tiempoXhamb =0;//cuando demoró en hacer la hambur
            //acciones
            while(tiempoActual<tiempoFinal){
                tiempoXhamb =cocinero.producirHambur();
                tiempoActual+=tiempoXhamb;
                llegadaCliente+= tiempoXhamb;
                hamburProducidas++;
                

                Console.WriteLine("Tiempo cliente antes de if: "+llegadaCliente);

                
                if(llegadaCliente==120 | llegadaCliente>120){
                    fila.Add("Cliente");
                    llegadaCliente-=120;
                }
            }

            Console.WriteLine("Hamburguesas producidas: "+hamburProducidas);
            Console.WriteLine("Tiempo transcurrido: "+tiempoActual);
            Console.WriteLine("Clientes generados: "+fila.Count);

            //cuando demora en pagar en base a las hamb pedidas
            int tiempoPago = vendedor.pagar(6); 


            
        }
        //que retorne la cantidad de hamburguesas a pedir
        public int pedidoCliente(){
            //probabilidades
            return 0;
        }

        public bool quedarseIrse(){
            return true;
        }
    }
}