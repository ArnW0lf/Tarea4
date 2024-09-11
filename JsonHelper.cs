using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Tarea3Grafica
{
    public class JsonHelper
    {
        // Método para serializar una lista de vértices a un archivo JSON
        public static void Serializar(List<Vertice> vertices, string rutaArchivo)
        {
            try
            {
                var opcionesJson = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(vertices, opcionesJson);
                File.WriteAllText(rutaArchivo, json);
                Console.WriteLine("Vértices serializados correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al serializar los vértices: {ex.Message}");
            }
        }

        // Método para deserializar una lista de vértices desde un archivo JSON
        public static List<Vertice> Deserializar(string rutaArchivo)
        {
            try
            {
                string json = File.ReadAllText(rutaArchivo);
                var vertices = JsonSerializer.Deserialize<List<Vertice>>(json);
                Console.WriteLine("Vértices deserializados correctamente.");
                return vertices;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al deserializar los vértices: {ex.Message}");
                return null;
            }
        }
    }
}

