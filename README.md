# GestionSoporteAcademico

## Autor
Jean Paul Sayan

## Correo
jeanpaulsayan3@gmail.com

## Descripcion
Sistema de orientacion y registro de atenciones para el modulo de soporte academico.

## Lenguaje
C#

## Tipo de aplicacion
Aplicacion de consola

## Requisitos
El proyecto desarrolla los requisitos R1 al R12 mediante funciones, validaciones, registro de atenciones, pruebas y documentacion.

## Tecnologias
- C#
- .NET
- Git
- GitHub

## R11 - Pruebas realizadas

### Prueba 1: Registro correcto
- Codigo: `N00538598`
- Nombre: Jean Paul Sayan
- Tipo de consulta: `pagos`
- Descripcion: Consulta sobre matricula
- Resultado: Correcto.

### Prueba 2: Codigo incorrecto
- Codigo ingresado: `123`
- Resultado: El sistema solicita nuevamente un codigo valido.
- Resultado: Correcto.

### Prueba 3: Tipo de consulta no valido
- Tipo ingresado: `biblioteca`
- Resultado: El sistema muestra un mensaje de tipo no valido.
- Resultado: Correcto.

### Prueba 4: Prioridad alta
- Tipo de consulta: `pagos`
- Resultado esperado: Prioridad `Alta`.
- Resultado: Correcto.

### Prueba 5: Prioridad baja
- Tipo de consulta: `constancia`
- Resultado esperado: Prioridad `Baja`.
- Resultado: Correcto.

### Prueba 6: Varias atenciones
- Se registraron 3 atenciones durante una misma ejecucion.
- Resultado: Las atenciones fueron almacenadas y mostradas correctamente.

## R12 - Relacion entre requisitos y funciones

| Requisito | Funcion o elemento | Descripcion |
|---|---|---|
| R1 | Main / RegistrarAtencion | Permite ingresar los datos principales de una atencion. |
| R2 | ValidarCodigo | Comprueba que el codigo tenga una longitud minima. |
| R3 | ValidarTipoConsulta | Comprueba que el tipo de consulta sea valido. |
| R4 | MostrarMenu | Presenta las opciones principales del sistema. |
| R5 | CalcularPrioridad | Determina la prioridad segun el tipo de consulta. |
| R6 | ValidarTexto | Comprueba que los campos de texto obligatorios no esten vacios. |
| R7 | CrearResumen | Genera el resumen de cada atencion registrada. |
| R8 | Parametros de funciones | Permite enviar los datos necesarios entre las funciones. |
| R9 | Variables locales | Mantiene las variables dentro del alcance de cada funcion. |
| R10 | List y RegistrarAtencion | Permite almacenar y registrar varias atenciones durante una ejecucion. |
| R11 | Pruebas documentadas | Registra las pruebas realizadas al sistema. |
| R12 | README.md | Documenta la relacion entre los requisitos y las funciones. |