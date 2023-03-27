namespace TP01Bis;
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int dineroCurso;
        int menu;
        string nombreCurso;
        Dictionary<string, int> datosCursos = new Dictionary<string, int>(); 
        menu = IngresarInt("Ingrese la opcion del menu:\n" 
        + "1. Ingrese el importe de 1 curso\n"
        + "2. Ver estadisticas\n"
        + "3. Salir del programa");
        while (menu != 3)
        {
        switch (menu)
        {
            case 1:
            nombreCurso = IngresarString("Ingrese el nombre del curso");
            dineroCurso = Curso(nombreCurso);
            datosCursos.Add(nombreCurso, dineroCurso);
                break;
            case 2:
            Estadisticas(datosCursos);
                break;
        }   
        menu = IngresarInt("Ingrese la opcion del menu:\n" 
        + "1. Ingrese el importe de 1 curso\n"
        + "2. Ver estadisticas\n"
        + "3. Salir del programa");
        }
    }
#region Ingresar
    static string IngresarString(string mensaje)
    {
        Console.WriteLine(mensaje);
        return Console.ReadLine();
    }
    static int IngresarInt(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.Parse(Console.ReadLine());
    }
#endregion
#region Funciones
    static int Curso(string nombreCurso)
    {
        int dineroTotal = 0;
        int dineroPorPersona;
        int cantidadPersonas = IngresarInt("Ingrese la cantidad de personas en el curso " + nombreCurso);
        for (int i = 0; i < cantidadPersonas; i++)
        {
            dineroPorPersona = IngresarInt("Ingrese el dinero de la persona N°" + (i + 1));
            dineroTotal += dineroPorPersona;
        }
        return dineroTotal;
    }
    static void Estadisticas(Dictionary<string, int> datosCursos)
    {
        string cursoMasGasto = "";
        int mayorPlata = -1;
        int promedioPlata;
        int recaudacionTotal = 0;
        int cantidadCursos;
        foreach (string item in datosCursos.Keys)
        {
            if (datosCursos[item] > mayorPlata)
            {
                mayorPlata = datosCursos[item];
                cursoMasGasto = item;
            }
            recaudacionTotal += datosCursos[item];
        }
        promedioPlata = recaudacionTotal / datosCursos.Count;
        cantidadCursos = datosCursos.Count;
        Console.WriteLine("a) El curso que mas plata puso fue el " + cursoMasGasto + ", con " + mayorPlata + "\n"
        + "b) El promedio de plata fue de " + promedioPlata + "\n"
        + "c) La recaudacion total fue de " + recaudacionTotal + "\n"
        + "d) La cantidad de cursos que participan es de " + cantidadCursos);
    }
#endregion //EL END?
}   