using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("╔══════════════════════════════════════════╗");
        Console.WriteLine("║       GESTIÓN DE ATENCIÓN ACADÉMICA     ║");
        Console.WriteLine("╚══════════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine("        REGISTRO DE NUEVA ATENCIÓN");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();

        Console.Write("Código del estudiante : ");
        string codigo = Console.ReadLine() ?? "";

        Console.Write("Nombre completo       : ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Tipo de consulta      : ");
        string tipoConsulta = Console.ReadLine() ?? "";

        Console.Write("Descripción breve     : ");
        string descripcion = Console.ReadLine() ?? "";

        Console.WriteLine();
        Console.WriteLine("============================================");
        Console.WriteLine("          ATENCIÓN REGISTRADA");
        Console.WriteLine("============================================");
        Console.WriteLine($"Código      : {codigo}");
        Console.WriteLine($"Estudiante  : {nombre}");
        Console.WriteLine($"Consulta    : {tipoConsulta}");
        Console.WriteLine($"Descripción : {descripcion}");
        Console.WriteLine("============================================");
        Console.WriteLine("Registro completado correctamente.");
    }
}