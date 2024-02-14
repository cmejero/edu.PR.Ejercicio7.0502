namespace edu.PR.Ejercicio7._0502
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String fechaUsuario;
                Console.WriteLine("Introduzca una fecha: dd/MM/YYYY");
            fechaUsuario = Console.ReadLine();

            int numeroUsuario;
            Console.WriteLine("Introduzca el numero de dias con el que quiera operar");
            numeroUsuario = Convert.ToInt32(Console.ReadLine());

            DateTime usuarioFecha = Convert.ToDateTime(fechaUsuario);
            Console.WriteLine(usuarioFecha.ToString());

            DateTime sumaDias = usuarioFecha.AddDays(numeroUsuario);
            Console.WriteLine("Suma de los dias: " + sumaDias.ToString());
            DateTime restaDias = usuarioFecha.AddDays(-numeroUsuario);
            Console.WriteLine("Resta de los dias: "+ restaDias.ToString());
        }
    }
}