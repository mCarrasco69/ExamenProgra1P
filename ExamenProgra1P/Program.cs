class Program
{
    static void Main(string[] args)
    {
        try
        {
            Asignatura asignatura = new Asignatura();

          
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ingrese el nombre del alumno:");
            asignatura.NombreAlumno = Console.ReadLine();
            Console.WriteLine("Ingrese el número de cuenta:");
            asignatura.NumeroCuenta = Console.ReadLine();
            Console.WriteLine("Ingrese el email:");
            asignatura.Email = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la asignatura:");
            asignatura.NombreAsignatura = Console.ReadLine();
            Console.WriteLine("Ingrese el horario:");
            asignatura.Horario = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del docente:");
            asignatura.NombreDocente = Console.ReadLine();


            Console.WriteLine("Ingrese la nota del primer parcial (max 30%):");
            asignatura.N1 = int.Parse(Console.ReadLine());
            if (asignatura.N1 > 30) throw new Exception("La nota del primer parcial no puede exceder 30 %.");

            Console.WriteLine("Ingrese la nota del segundo parcial (max 30 %):");
            asignatura.N2 = int.Parse(Console.ReadLine());
            if (asignatura.N2 > 30) throw new Exception("La nota del segundo parcial no puede exceder 30 %.");

            Console.WriteLine("Ingrese la nota del tercer parcial (max 40 %):");
            asignatura.N3 = int.Parse(Console.ReadLine());
            if (asignatura.N3 > 40) throw new Exception("La nota del tercer parcial no puede exceder 40 %.");

            asignatura.Imprimir();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
