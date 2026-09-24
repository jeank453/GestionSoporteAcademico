using System;

class Program
{
    static void Main()
    {
        MostrarMenu();

        Console.Write("Seleccione una opción: ");
        string opcion = Console.ReadLine() ?? "";

        if (opcion == "1")
        {
            Console.WriteLine();
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║          NUEVA ATENCIÓN ACADÉMICA       ║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
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

            // R5: Asignación de prioridad
            string prioridad = CalcularPrioridad(tipoConsulta);

            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("          ATENCIÓN REGISTRADA");
            Console.WriteLine("============================================");
            Console.WriteLine($"Código      : {codigo}");
            Console.WriteLine($"Estudiante  : {nombre}");
            Console.WriteLine($"Consulta    : {tipoConsulta}");
            Console.WriteLine($"Descripción : {descripcion}");
            Console.WriteLine($"Prioridad   : {prioridad}");
            Console.WriteLine("============================================");
            Console.WriteLine("Registro completado correctamente.");
        }
        else if (opcion == "2")
        {
            Console.WriteLine();
            Console.WriteLine("Gracias por utilizar el sistema.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("⚠ Opción no válida.");
        }
    }

    // R4: Muestra el menú principal.
    static void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("╔══════════════════════════════════════════╗");
        Console.WriteLine("║       GESTIÓN DE ATENCIÓN ACADÉMICA     ║");
        Console.WriteLine("╠══════════════════════════════════════════╣");
        Console.WriteLine("║  1. Registrar nueva atención             ║");
        Console.WriteLine("║  2. Salir                                ║");
        Console.WriteLine("╚══════════════════════════════════════════╝");
        Console.WriteLine();
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

    // R5: Asigna una prioridad según el tipo de consulta.
    static string CalcularPrioridad(string tipoConsulta)
    {
        string tipo = tipoConsulta.Trim().ToLower();

        if (tipo == "pagos" || tipo == "plataforma")
        {
            return "Alta";
        }
        else if (tipo == "matrícula")
        {
            return "Media";
        }
        else
        {
            return "Baja";
        }
    }
}