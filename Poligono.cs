using System.Collections.Generic;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Tarea3Grafica
{
    public class Poligono
    {
        private Dictionary<int, Vertice> vertices = new Dictionary<int, Vertice>();
        public Color4 Color { get; set; }

        public void Add(int id, Vertice vertice)
        {
            vertices[id] = vertice;
        }

        public Vertice Get(int id)
        {
            return vertices.ContainsKey(id) ? vertices[id] : null;
        }

        public void Delete(int id)
        {
            vertices.Remove(id);
        }

        public void Draw()
        {
            GL.Begin(PrimitiveType.Polygon);
            GL.Color4(Color);
            foreach (var vertice in vertices.Values)
            {
                GL.Vertex3(vertice.X, vertice.Y, vertice.Z);
            }
            GL.End();
        }

        // Método público para obtener todos los vértices
        public IEnumerable<Vertice> GetVertices()
        {
            return vertices.Values;
        }
    }
}
