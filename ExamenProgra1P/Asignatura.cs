

using ExamenProgra1P;

public class Asignatura : Alumno, IAsignatura
{
    public int N1 { get; set; }
    public int N2 { get; set; }
    public int N3 { get; set; }
    public string NombreAsignatura { get; set; }
    public string Horario { get; set; }
    public string NombreDocente { get; set; }

    public double CalcularNotaFinal()
    {
        return N1 + N2 + N3;
    }

    public double CalcularNotaFinal(double n1, double n2, double n3)
    {
        return n1 + n2 + n3;
    }

    public string MensajeNotaFinal(double notaFinal)
    {
        if (notaFinal < 60)
            return "Ta frito raza";
        else if (notaFinal < 80)
            return "De wasa paso";
        else if (notaFinal < 90)
            return "Fresa raza paso";
        else
             return "Huy una birria ocupa la merese";
    }

    public void Imprimir()
    {
        double notaFinal1 = CalcularNotaFinal();
        double notaFinal2 = CalcularNotaFinal(N1, N2, N3);
        Console.WriteLine();
        Console.WriteLine($"Nombre del Alumno: {NombreAlumno}");
        Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Asignatura: {NombreAsignatura}");
        Console.WriteLine($"Horario: {Horario}");
        Console.WriteLine($"Docente: {NombreDocente}");
        Console.WriteLine($"Nota Final (sin parámetros): {notaFinal1} - {MensajeNotaFinal(notaFinal1)}%");
        Console.WriteLine($"Nota Final (con parámetros): {notaFinal2} - {MensajeNotaFinal(notaFinal2)}%");
        Console.WriteLine("***********************************************");
    }
}
