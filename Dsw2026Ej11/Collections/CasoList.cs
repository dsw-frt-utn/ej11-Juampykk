namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    public List<Alumno> ListAlumnos { get; }
    public CasoList() => ListAlumnos = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)=>ListAlumnos.Add(alumno);
    

    public Alumno? BuscarPorNombre(string nombre) => ListAlumnos.Find(alumno => alumno.Nombre == nombre);

    public bool EliminarAlumno(Alumno alumno) => ListAlumnos.Remove(alumno);

    public void EliminarAlumnoPorPosicion(int posicion) => ListAlumnos.RemoveAt(posicion);

}
