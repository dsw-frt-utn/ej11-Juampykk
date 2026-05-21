namespace Dsw2026Ej11.Tests;

using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        Console.WriteLine("\n--- Agregando alumnos a la lista ---");
        CasoList casoList = new CasoList();
        var alum1 = new Alumno(1, "Juan", 8.5);
        var alum2 = new Alumno(3, "Pedro", 7.2);
        var alum3 = new Alumno(2, "Maria", 8.5);
        var alum4 = new Alumno(4, "Ana", 6.5);

        casoList.AgregarAlumno(alum1);
        casoList.AgregarAlumno(alum2);
        casoList.AgregarAlumno(alum3);
        casoList.AgregarAlumno(alum4);

        Console.WriteLine("\n--- Listando por consola los alumnos ---");
        foreach (var alumno in casoList.ListAlumnos) Console.WriteLine(alumno);

        Console.WriteLine("\n--- Buscando por nombre un alumno que exista ---");
        Console.WriteLine($"Alumno buscado por nombre: {casoList.BuscarPorNombre("Juan")?.Nombre}");

        Console.WriteLine("\n--- Buscando por nombre un alumno que no exista ---");
        Console.WriteLine($"Alumno buscado por nombre: {casoList.BuscarPorNombre("Carlos")?.Nombre ?? "No existe"}");

        Console.WriteLine("\n--- Eliminando un alumno y listando por consola los alumnos ---");
        if (casoList.EliminarAlumno(alum1)) Console.WriteLine($"Alumno eliminado: {alum1.Nombre}");
        else Console.WriteLine($"No se pudo eliminar el alumno: {alum1.Nombre}");

        foreach (var alumno in casoList.ListAlumnos) Console.WriteLine(alumno);

        Console.WriteLine("\n--- Eliminando el primer elemento de la lista y listando ---");
        casoList.EliminarAlumnoPorPosicion(0);
        Console.WriteLine("Alumno eliminado por posición: 0");

        foreach (var alumno in casoList.ListAlumnos) Console.WriteLine(alumno);
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        Console.WriteLine("\n--- Agregando alumnos al diccionario ---");
        var casoDictionary = new CasoDictionary();
        var alum1 = new Alumno(1, "Juan", 8.5);
        var alum2 = new Alumno(3, "Pedro", 7.2);
        var alum3 = new Alumno(2, "Maria", 8.5);
        var alum4 = new Alumno(4, "Ana", 6.5);

        casoDictionary.AgregarAlumno(alum1);
        casoDictionary.AgregarAlumno(alum2);
        casoDictionary.AgregarAlumno(alum3);
        casoDictionary.AgregarAlumno(alum4);

        Console.WriteLine("\n--- Listar por consola los alumnos ---");
        foreach (var alumno in casoDictionary.DiccionarioAlumnos.Values) Console.WriteLine(alumno);

        Console.WriteLine("\n--- Buscar un alumno por clave y mostrar por consola ---");
        Console.WriteLine($"Alumno buscado por legajo (1): {casoDictionary.BuscarPorLegajo(1)?.Nombre}");

        Console.WriteLine("\n--- Buscar un alumno por clave que no exista ---");
        Console.WriteLine($"Alumno buscado por legajo (5): {casoDictionary.BuscarPorLegajo(5)?.Nombre ?? "No existe"}");

        Console.WriteLine("\n--- Eliminar un alumno por clave y listar por consola ---");
        if (casoDictionary.EliminarAlumno(1)) Console.WriteLine("Alumno eliminado con legajo 1");
        else Console.WriteLine("No se pudo eliminar el alumno con legajo 1");

        foreach (var alumno in casoDictionary.DiccionarioAlumnos.Values) Console.WriteLine(alumno);
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var casoLinq = new CasoLinq();

        Console.WriteLine("\n--- 1. Obtener el primer libro ---");
        Console.WriteLine($"Primer libro: {casoLinq.GetPrimero()?.Titulo}");

        Console.WriteLine("\n--- 2. Obtener el último libro ---");
        Console.WriteLine($"Último libro: {casoLinq.GetUltimo()?.Titulo}");

        Console.WriteLine("\n--- 3. Obtener la suma de precios ---");
        Console.WriteLine($"Total precios: {casoLinq.GetTotalPrecios():C}");

        Console.WriteLine("\n--- 4. Obtener el promedio de precios ---");
        Console.WriteLine($"Promedio precios: {casoLinq.GetPromedioPrecios():C}");

        Console.WriteLine("\n--- 5. Obtener la lista de libros con Id mayor a 15 ---");
        foreach (var libro in casoLinq.GetListById()) Console.WriteLine($"- {libro.Titulo}");

        Console.WriteLine("\n--- 6. Obtener lista de cada libro con título y precio en formato moneda ---");
        foreach (var libroStr in casoLinq.GetLibros()) Console.WriteLine(libroStr);

        Console.WriteLine("\n--- 7. Obtener el libro con el precio más alto ---");
        Console.WriteLine($"Libro con el precio más alto: {casoLinq.GetMayorPrecio()?.Titulo}");

        Console.WriteLine("\n--- 8. Obtener el libro con el precio más bajo ---");
        Console.WriteLine($"Libro con el precio más bajo: {casoLinq.GetMenorPrecio()?.Titulo}");

        Console.WriteLine("\n--- 9. Obtener los libros cuyo precio sea mayor al promedio ---");
        foreach (var libro in casoLinq.GetMayorAlPromedio()) Console.WriteLine($"- {libro.Titulo} ({libro.Precio:C})");

        Console.WriteLine("\n--- 10. Obtener los libros ordenados por título de forma descendente ---");
        foreach (var libro in casoLinq.GetTituloOrdenDescendente()) Console.WriteLine($"- {libro.Titulo}");
    }
}