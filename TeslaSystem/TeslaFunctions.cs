﻿using System;
using System.Collections.Generic;

namespace TeslaSystem
{
    // Declaración de la estructura Tesla que almacena información sobre un automóvil Tesla
    public struct Tesla
    {
        public string Modelo; // El modelo del Tesla
        public int Anio; // El año del Tesla
        public double KmActual; // El kilometraje actual del Tesla
        public double KmService; // El kilometraje del último service del Tesla
        public string Color; // El color del Tesla
        public string Dueno; // El dueño del Tesla
    }

    public struct TeslaFunctions
    {
        // Función para dar de alta un nuevo Tesla en la lista
        public static void DarDeAlta(List<Tesla> TeslaList)
        {
            // Crear un nuevo Tesla y pedir al usuario que ingrese sus detalles
            Tesla nuevoTesla = new Tesla();

            Console.WriteLine("\n\nIngrese el modelo:");
            nuevoTesla.Modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el año:");
            nuevoTesla.Anio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el kilometraje actual:");
            nuevoTesla.KmActual = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el kilometraje de service:");
            nuevoTesla.KmService = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el color:");
            nuevoTesla.Color = Console.ReadLine();

            Console.WriteLine("Ingrese el dueño:");
            nuevoTesla.Dueno = Console.ReadLine();

            // Agregar el nuevo Tesla a la lista
            TeslaList.Add(nuevoTesla);
            Console.WriteLine("Tesla agregado exitosamente!");
        }

        // Función para eliminar un Tesla de la lista
        public static void EliminarTesla(List<Tesla> TeslaList)
        {
            ListarTeslas(TeslaList);
            Console.WriteLine("\n\nIngrese el id del Tesla a eliminar:");
            int indice = Convert.ToInt32(Console.ReadLine());

            if (indice < TeslaList.Count)
            {
                TeslaList.RemoveAt(indice);
                Console.WriteLine("Tesla eliminado exitosamente!");
            }
            else
            {
                Console.WriteLine("Id inválido.");
            }
        }

        // Función para mostrar la lista de Teslas
        public static void ListarTeslas(List<Tesla> TeslaList)
        {
            Console.WriteLine("\n\nListado de Teslas:");

            for (int i = 0; i < TeslaList.Count; i++)
            {
                Tesla t = TeslaList[i];
                Console.WriteLine($"Id: {i}, Modelo: {t.Modelo}, Año: {t.Anio}, Kilometraje: {t.KmActual}, Dueño: {t.Dueno}");
            }
        }

        // Función para ordenar Teslas por año
        public static void ListadoOrdenadoPorAnio(List<Tesla> TeslaList)
        {
            // Ordena la lista de Teslas por año utilizando la función Sort y una lambda expression que compara los años de dos Teslas.
            TeslaList.Sort((x, y) => x.Anio.CompareTo(y.Anio));
            Console.WriteLine("\n\nListado de Teslas ordenados por año:");
            // Recorre la lista ordenada y muestra la información de cada Tesla.
            foreach (Tesla t in TeslaList)
            {
                Console.WriteLine($"Modelo: {t.Modelo}, Año: {t.Anio}, Kilometraje: {t.KmActual}, Dueño: {t.Dueno}");
            }
        }

        // Función para ordenar Teslas por kilómetros
        public static void ReordenarPorKms(List<Tesla> TeslaList)
        {
            // Ordena la lista de Teslas por kilómetros utilizando la función Sort y una lambda expression que compara los kilómetros de dos Teslas.
            TeslaList.Sort((x, y) => x.KmActual.CompareTo(y.KmActual));
            Console.WriteLine("\n\nListado de Teslas reordenados por kilometraje actual:");
            // Recorre la lista ordenada y muestra la información de cada Tesla.
            foreach (Tesla t in TeslaList)
            {
                Console.WriteLine($"Modelo: {t.Modelo}, Año: {t.Anio}, Kilometraje: {t.KmActual}, Dueño: {t.Dueno}");
            }
        }

        // Función para mostrar el Tesla con más kilometraje
        public static void MostrarMasKms(List<Tesla> TeslaList)
        {
            // Verifica si la lista de Teslas está vacía
            if (TeslaList.Count == 0)
            {
                Console.WriteLine("No hay Teslas registrados.");
                return;
            }

            // Inicializa la variable maxKmTesla con el primer Tesla de la lista.
            Tesla maxKmTesla = TeslaList[0];

            // Recorre la lista de Teslas y actualiza maxKmTesla si encuentra un Tesla con más kilómetros que el actual.
            foreach (Tesla t in TeslaList)
            {
                if (t.KmActual > maxKmTesla.KmActual)
                {
                    maxKmTesla = t;
                }
            }

            // Muestra la información del Tesla con más kilómetros.
            Console.WriteLine($"\n\nEl Tesla con más kilometraje es: {maxKmTesla.Modelo} ({maxKmTesla.Anio}), con {maxKmTesla.KmActual} km.");
        }
    }
}
