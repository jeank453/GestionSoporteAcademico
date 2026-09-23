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

        // R2: Validación del código
        string codigo;

        do
        {
            Console.Write("Código del estudiante : ");
            codigo = Console.ReadLine() ?? "";

            if (!ValidarCodigo(codigo))
            {
                Console.WriteLine();
                Console.WriteLine("⚠ El código debe tener al menos 6 caracteres.");
                Console.WriteLine();
            }

        } while (!ValidarCodigo(codigo));

        Console.Write("Nombre completo       : ");
        string nombre = Console.ReadLine() ?? "";

        // R3: Validación del tipo de consulta
        string tipoConsulta;

        do
        {
            Console.Write("Tipo de consulta      : ");
            tipoConsulta = Console.ReadLine() ?? "";

            if (!ValidarTipoConsulta(tipoConsulta))
            {
                Console.WriteLine();
                Console.WriteLine("⚠ Tipo de consulta no válido.");
                Console.WriteLine(
                    "Opciones: matrícula, pagos, constancia, plataforma u otro."
                );
                Console.WriteLine();
            }

        } while (!ValidarTipoConsulta(tipoConsulta));

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

    // R2: Valida el código del estudiante.
    static bool ValidarCodigo(string codigo)
    {
        return !string.IsNullOrWhiteSpace(codigo)
               && codigo.Trim().Length >= 6;
    }

    // R3: Valida el tipo de consulta.
    static bool ValidarTipoConsulta(string tipoConsulta)
    {
        string tipo = tipoConsulta.Trim().ToLower();

        return tipo == "matrícula" ||
               tipo == "pagos" ||
               tipo == "constancia" ||
               tipo == "plataforma" ||
               tipo == "otro";
    }
}