using System;
using System.Collections.Generic;

namespace Tarea3Grafica
{
    public class Objeto
    {
        private List<Parte> partes = new List<Parte>();
        private List<int> ids = new List<int>();
        public CentroDeMasa CentroDeMasa { get; private set; }

        public void Add(int id, Parte parte)
        {
            int index = ids.IndexOf(id);
            if (index >= 0)
            {
                partes[index] = parte;
            }
            else
            {
                ids.Add(id);
                partes.Add(parte);
            }
        }

        public Parte Get(int id)
        {
            int index = ids.IndexOf(id);
            if (index >= 0)
            {
                return partes[index];
            }
            return null;
        }

        public void Delete(int id)
        {
            int index = ids.IndexOf(id);
            if (index >= 0)
            {
                ids.RemoveAt(index);
                partes.RemoveAt(index);
            }
        }

        public void Draw()
        {
            foreach (var parte in partes)
            {
                parte.Draw();
            }
        }

        private void CalcularCentroDeMasa()
        {
            float sumaX = 0, sumaY = 0, sumaZ = 0;
            int totalPartes = partes.Count;

            if (totalPartes > 0)
            {
                foreach (var parte in partes)
                {
                    if (parte.CentroDeMasa != null)
                    {
                        sumaX += parte.CentroDeMasa.X;
                        sumaY += parte.CentroDeMasa.Y;
                        sumaZ += parte.CentroDeMasa.Z;
                    }
                }
                CentroDeMasa = new CentroDeMasa(sumaX / totalPartes, sumaY / totalPartes, sumaZ / totalPartes);
            }
        }

    }
}