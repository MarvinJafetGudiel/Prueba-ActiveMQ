using System;
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.Util;

class Program
{
    static void Main(string[] args)
    {
        string direccionBroker = "activemq:tcp://localhost:61616";

        IConnectionFactory fabricaConexion = new ConnectionFactory(direccionBroker);

        using (IConnection conexion = fabricaConexion.CreateConnection())
        {
            conexion.Start();

            using (ISession sesion = conexion.CreateSession())
            {
                IDestination colaDestino = SessionUtil.GetDestination(sesion, "queue://cola.demo");

                using (IMessageConsumer consumidor = sesion.CreateConsumer(colaDestino))
                {
                    Console.WriteLine("Esperando mensaje...");

                    ITextMessage mensajeRecibido = consumidor.Receive() as ITextMessage;

                    if (mensajeRecibido != null)
                    {
                        Console.WriteLine("Mensaje recibido:");
                        Console.WriteLine(mensajeRecibido.Text);
                    }
                }
            }
        }

        Console.ReadLine();
    }
}