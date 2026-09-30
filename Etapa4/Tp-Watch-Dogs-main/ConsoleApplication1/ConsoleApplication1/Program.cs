using System;
class Notificador
{
    public virtual void enviar_notificacion(string usuario, string mensaje)
    {
        Console.WriteLine("enviando notificacion...");
    }
}
class NotificadorEmail : Notificador
{
    public override void enviar_notificacion(string usuario, string mensaje)
    {
        Console.WriteLine("notificacion por email");
        Console.WriteLine("destinatario: " + usuario);
        Console.WriteLine("asunto: notificacion ");
        Console.WriteLine(" mensaje: " + mensaje);
    }
}
class NotificadorSms : Notificador
{
    public override void enviar_notificacion(string usuario, string mensaje)
    {
        Console.WriteLine("notificacion por sms ");
        Console.WriteLine("numero: " + usuario);
        Console.WriteLine("mensaje: " + mensaje);

        if (mensaje.Length > 160)
{
            Console.WriteLine("el mensaje supera los 160 caracteres.");
        }
    }
}
class NotificadorPush : Notificador
{
    public override void enviar_notificacion(string usuario, string mensaje)
    {
        Console.WriteLine("notificacion push");
        Console.WriteLine("usuario: " + usuario);
        Console.WriteLine("mensaje: " + mensaje);
    }
}
class Program
{
    static void Main()
    {
        int opcion = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("===== sistema de notificaciones =====");
            Console.WriteLine("1. enviar por email");
            Console.WriteLine("2. enviar por sms");
            Console.WriteLine("3. enviar por push");
            Console.WriteLine("4. salir");
            Console.Write("opcion: ");
            opcion = int.Parse(Console.ReadLine());
            if (opcion >= 1 && opcion <= 3)
{
                Console.WriteLine();
                Console.Write("usuario o destinatario: ");
                string usuario = Console.ReadLine();
                Console.Write("mensaje: ");
                string mensaje = Console.ReadLine();
                Notificador notificador;

                if (opcion == 1)
                {
                    notificador = new NotificadorEmail();
                }
                else if (opcion == 2)
                {
                    notificador = new NotificadorSms();
                }
                else
                {
                    notificador = new NotificadorPush();
                }
                Console.WriteLine();
                notificador.enviar_notificacion(usuario, mensaje);
            }
            Console.WriteLine();
            Console.WriteLine("presiona una tecla para continuar...");
            Console.ReadKey();
        } while (opcion != 4);
    }
}