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

                using (IMessageProducer productor = sesion.CreateProducer(colaDestino))
                {
                    ITextMessage mensaje = sesion.CreateTextMessage("Usando ActiveMQ desde C#");

                    productor.Send(mensaje);

                    Console.WriteLine("Mensaje enviado correctamente.");
                }
            }
        }

        Console.ReadLine();
    }
}