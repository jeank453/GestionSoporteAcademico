using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // R10: Lista para almacenar múltiples atenciones.
        List<string> atenciones = new List<string>();

        bool continuar = true;

        while (continuar)
        {
            MostrarMenu();

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine() ?? "";

            if (opcion == "1")
            {
                RegistrarAtencion(atenciones);

                Console.WriteLine();
                Console.WriteLine("✓ Atención registrada correctamente.");
                Console.WriteLine($"Total de atenciones: {atenciones.Count}");
                Console.WriteLine();
            }
            else if (opcion == "2")
            {
                MostrarAtenciones(atenciones);
            }
            else if (opcion == "3")
            {
                continuar = false;

                Console.WriteLine();
                Console.WriteLine("Gracias por utilizar el sistema.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("⚠ Opción no válida.");
            }
        }
    }

    // R4: Muestra el menú principal.
    // R10: Permite seleccionar entre registrar, consultar o salir.
    static void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("╔══════════════════════════════════════════╗");
        Console.WriteLine("║       GESTIÓN DE ATENCIÓN ACADÉMICA     ║");
        Console.WriteLine("╠══════════════════════════════════════════╣");
        Console.WriteLine("║  1. Registrar nueva atención             ║");
        Console.WriteLine("║  2. Ver atenciones registradas           ║");
        Console.WriteLine("║  3. Salir                                ║");
        Console.WriteLine("╚══════════════════════════════════════════╝");
        Console.WriteLine();
    }

    // R10: Registra una nueva atención y la almacena en la lista.
    static void RegistrarAtencion(List<string> atenciones)
    {
        Console.WriteLine();
        Console.WriteLine("╔══════════════════════════════════════════╗");
        Console.WriteLine("║          NUEVA ATENCIÓN ACADÉMICA       ║");
        Console.WriteLine("╚══════════════════════════════════════════╝");
        Console.WriteLine();

        // R2 y R9:
        // La variable codigo es local a esta función.
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
        // La variable nombre es local a esta función.
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

        // R3:
        // Validación del tipo de consulta.
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

        // R6:
        // Validación de la descripción.
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

        // R5 y R8:
        // Se pasa tipoConsulta como parámetro.
        string prioridad = CalcularPrioridad(tipoConsulta);

        // R7 y R8:
        // Se crea el resumen utilizando parámetros.
        string resumen = CrearResumen(
            codigo,
            nombre,
            tipoConsulta,
            descripcion,
            prioridad
        );

        // R10:
        // Se almacena la atención en la lista.
        atenciones.Add(resumen);
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
        // R9: Variable local de esta función.
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
    // El parámetro texto tiene alcance local.
    static bool ValidarTexto(string texto)
    {
        return !string.IsNullOrWhiteSpace(texto);
    }

    // R7 y R8:
    // Recibe todos los datos mediante parámetros
    // y devuelve el resumen como texto.
    static string CrearResumen(
        string codigo,
        string nombre,
        string tipoConsulta,
        string descripcion,
        string prioridad)
    {
        return
            "╔══════════════════════════════════════════╗\n" +
            "║             RESUMEN DE ATENCIÓN         ║\n" +
            "╠══════════════════════════════════════════╣\n" +
            $"║ Código      : {codigo}\n" +
            $"║ Estudiante  : {nombre}\n" +
            $"║ Consulta    : {tipoConsulta}\n" +
            $"║ Descripción : {descripcion}\n" +
            $"║ Prioridad   : {prioridad}\n" +
            "╚══════════════════════════════════════════╝";
    }

    // R10: Muestra todas las atenciones almacenadas.
    static void MostrarAtenciones(List<string> atenciones)
    {
        Console.WriteLine();

        if (atenciones.Count == 0)
        {
            Console.WriteLine("⚠ No hay atenciones registradas.");
            return;
        }

        Console.WriteLine("╔══════════════════════════════════════════╗");
        Console.WriteLine("║          ATENCIONES REGISTRADAS         ║");
        Console.WriteLine("╚══════════════════════════════════════════╝");

        Console.WriteLine();

        for (int i = 0; i < atenciones.Count; i++)
        {
            Console.WriteLine($"ATENCIÓN #{i + 1}");
            Console.WriteLine(atenciones[i]);
            Console.WriteLine();
        }

        Console.WriteLine($"Total de atenciones: {atenciones.Count}");
    }
}