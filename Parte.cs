using System.Collections.Generic;

namespace Tarea3Grafica
{
    public class Parte
    {
        private List<Poligono> poligonos = new List<Poligono>();
        private List<int> ids = new List<int>();
        public CentroDeMasa CentroDeMasa { get; private set; }

        public void Add(int id, Poligono poligono)
        {
            int index = ids.IndexOf(id);
            if (index >= 0)
            {
                poligonos[index] = poligono;
            }
            else
            {
                ids.Add(id);
                poligonos.Add(poligono);
            }
        }

        public Poligono Get(int id)
        {
            int index = ids.IndexOf(id);
            if (index >= 0)
            {
                return poligonos[index];
            }
            return null;
        }

        public void Delete(int id)
        {
            int index = ids.IndexOf(id);
            if (index >= 0)
            {
                ids.RemoveAt(index);
                poligonos.RemoveAt(index);
            }
        }

        public void Draw()
        {
            foreach (var poligono in poligonos)
            {
                poligono.Draw();
            }
        }

        private void CalcularCentroDeMasa()
        {
            float sumaX = 0, sumaY = 0, sumaZ = 0;
            int totalVertices = 0;

            foreach (var poligono in poligonos)
            {
                foreach (var vertice in poligono.GetVertices())
                {
                    sumaX += vertice.X;
                    sumaY += vertice.Y;
                    sumaZ += vertice.Z;
                    totalVertices++;
                }
            }

            if (totalVertices > 0)
            {
                CentroDeMasa = new CentroDeMasa(sumaX / totalVertices, sumaY / totalVertices, sumaZ / totalVertices);
            }
        }

    }

}