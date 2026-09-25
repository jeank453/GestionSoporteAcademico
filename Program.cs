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

            // R2 y R9:
            // La variable codigo es local a Main.
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

            // R6 y R9:
            // La variable nombre es local a Main.
            string nombre;

            do
            {
                Console.Write("Nombre completo       : ");
                nombre = Console.ReadLine() ?? "";

                if (!ValidarTexto(nombre))
                {
                    Console.WriteLine();
                    Console.WriteLine("⚠ El nombre es obligatorio.");
                    Console.WriteLine();
                }

            } while (!ValidarTexto(nombre));

            // R3 y R9:
            // La variable tipoConsulta es local a Main.
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

            // R6 y R9:
            // La variable descripcion es local a Main.
            string descripcion;

            do
            {
                Console.Write("Descripción breve     : ");
                descripcion = Console.ReadLine() ?? "";

                if (!ValidarTexto(descripcion))
                {
                    Console.WriteLine();
                    Console.WriteLine("⚠ La descripción es obligatoria.");
                    Console.WriteLine();
                }

            } while (!ValidarTexto(descripcion));

            // R5, R8 y R9:
            // La variable prioridad es local a Main.
            string prioridad = CalcularPrioridad(tipoConsulta);

            // R7 y R8:
            // Los datos se pasan como parámetros.
            MostrarResumen(
                codigo,
                nombre,
                tipoConsulta,
                descripcion,
                prioridad
            );
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

    // R4 y R9:
    // Esta función no utiliza variables globales.
    // Las variables que utiliza tienen alcance local.
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

    // R5 y R8:
    // Recibe el tipo de consulta como parámetro
    // y devuelve la prioridad correspondiente.
    static string CalcularPrioridad(string tipoConsulta)
    {
        // R9:
        // La variable tipo tiene alcance local dentro de esta función.
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

    // R6 y R9:
    // El parámetro texto tiene alcance local dentro de esta función.
    static bool ValidarTexto(string texto)
    {
        return !string.IsNullOrWhiteSpace(texto);
    }

    // R7 y R8:
    // Recibe los datos mediante parámetros.
    // R9: Los parámetros tienen alcance local en esta función.
    static void MostrarResumen(
        string codigo,
        string nombre,
        string tipoConsulta,
        string descripcion,
        string prioridad)
    {
        Console.WriteLine();
        Console.WriteLine("╔══════════════════════════════════════════╗");
        Console.WriteLine("║             RESUMEN DE ATENCIÓN         ║");
        Console.WriteLine("╠══════════════════════════════════════════╣");
        Console.WriteLine($"║ Código      : {codigo}");
        Console.WriteLine($"║ Estudiante  : {nombre}");
        Console.WriteLine($"║ Consulta    : {tipoConsulta}");
        Console.WriteLine($"║ Descripción : {descripcion}");
        Console.WriteLine($"║ Prioridad   : {prioridad}");
        Console.WriteLine("╚══════════════════════════════════════════╝");
    }
}