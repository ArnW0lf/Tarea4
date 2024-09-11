using OpenTK.Graphics;
using System.Collections.Generic;

namespace Tarea3Grafica
{
    public class Vertice
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Vertice(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        private static Poligono CrearPoligonoConColor(Color4 color, params Vertice[] vertices)
        {
            var poligono = new Poligono();
            for (int i = 0; i < vertices.Length; i++)
            {
                poligono.Add(i, vertices[i]);
            }
            poligono.Color = color;
            return poligono;
        }

        public static Dictionary<string, Poligono> CrearPoligonos()
        {
            var poligonos = new Dictionary<string, Poligono>();

            // Colores
            var color1 = new Color4(1.0f, 1.0f, 0.0f, 1.0f);
            var color2 = new Color4(1.0f, 1.0f, 1.0f, 1.0f);

            // Crear los polígonos para la parte vertical
            poligonos["caraFrontalV"] = CrearPoligonoConColor(
                color1,
                new Vertice(0.2f, 0.8f, 0.0f),
                new Vertice(0.2f, -0.8f, 0.0f),
                new Vertice(-0.2f, -0.8f, 0.0f),
                new Vertice(-0.2f, 0.8f, 0.0f));

            poligonos["caraTraseraV"] = CrearPoligonoConColor(
                color1,
                new Vertice(0.2f, 0.8f, 0.2f),
                new Vertice(0.2f, -0.8f, 0.2f),
                new Vertice(-0.2f, -0.8f, 0.2f),
                new Vertice(-0.2f, 0.8f, 0.2f));

            poligonos["caraDerechaV"] = CrearPoligonoConColor(
                color1,
                new Vertice(0.2f, 0.8f, 0.2f),
                new Vertice(0.2f, -0.8f, 0.2f),
                new Vertice(0.2f, -0.8f, 0.0f),
                new Vertice(0.2f, 0.8f, 0.0f));

            poligonos["caraIzquierdaV"] = CrearPoligonoConColor(
                color1,
                new Vertice(-0.2f, 0.8f, 0.0f),
                new Vertice(-0.2f, 0.8f, 0.2f),
                new Vertice(-0.2f, -0.8f, 0.2f),
                new Vertice(-0.2f, -0.8f, 0.0f));

            poligonos["caraSuperiorV"] = CrearPoligonoConColor(
                color1,
                new Vertice(0.2f, 0.8f, 0.2f),
                new Vertice(0.2f, 0.8f, 0.0f),
                new Vertice(-0.2f, 0.8f, 0.0f),
                new Vertice(-0.2f, 0.8f, 0.2f));

            poligonos["caraInferiorV"] = CrearPoligonoConColor(
                color1,
                new Vertice(0.2f, -0.8f, 0.0f),
                new Vertice(0.2f, -0.8f, 0.2f),
                new Vertice(-0.2f, -0.8f, 0.2f),
                new Vertice(-0.2f, -0.8f, 0.0f));

            // Crear los polígonos para la parte superior de la T
            poligonos["caraTraseraH"] = CrearPoligonoConColor(
                color2,
                new Vertice(0.7f, 1.1f, 0.0f),
                new Vertice(0.7f, 0.8f, 0.0f),
                new Vertice(-0.7f, 0.8f, 0.0f),
                new Vertice(-0.7f, 1.1f, 0.0f));

            poligonos["caraFrontalH"] = CrearPoligonoConColor(
                color2,
                new Vertice(0.7f, 1.1f, 0.2f),
                new Vertice(0.7f, 0.8f, 0.2f),
                new Vertice(-0.7f, 0.8f, 0.2f),
                new Vertice(-0.7f, 1.1f, 0.2f));

            poligonos["caraDerechaH"] = CrearPoligonoConColor(
                color2,
                new Vertice(0.7f, 1.1f, 0.2f),
                new Vertice(0.7f, 0.8f, 0.2f),
                new Vertice(0.7f, 0.8f, 0.0f),
                new Vertice(0.7f, 1.1f, 0.0f));

            poligonos["caraIzquierdaH"] = CrearPoligonoConColor(
                color2,
                new Vertice(-0.7f, 1.1f, 0.0f),
                new Vertice(-0.7f, 0.8f, 0.0f),
                new Vertice(-0.7f, 0.8f, 0.2f),
                new Vertice(-0.7f, 1.1f, 0.2f));

            poligonos["caraSuperiorH"] = CrearPoligonoConColor(
                color2,
                new Vertice(0.7f, 1.1f, 0.2f),
                new Vertice(0.7f, 1.1f, 0.0f),
                new Vertice(-0.7f, 1.1f, 0.0f),
                new Vertice(-0.7f, 1.1f, 0.2f));

            poligonos["caraInferiorH"] = CrearPoligonoConColor(
                color2,
                new Vertice(0.7f, 0.8f, 0.0f),
                new Vertice(0.7f, 0.8f, 0.2f),
                new Vertice(-0.7f, 0.8f, 0.2f),
                new Vertice(-0.7f, 0.8f, 0.0f));

            return poligonos;
        }
    }
}