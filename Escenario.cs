using System;
using System.Collections.Generic;

namespace Tarea3Grafica
{
    public class Escenario
    {
        private List<Objeto> objetos = new List<Objeto>();
        private List<int> ids = new List<int>();

        public void Add(int id, Objeto objeto)
        {
            int index = ids.IndexOf(id);
            if (index >= 0)
            {
                objetos[index] = objeto;
            }
            else
            {
                ids.Add(id);
                objetos.Add(objeto);
            }
        }

        public Objeto Get(int id)
        {
            int index = ids.IndexOf(id);
            if (index >= 0)
            {
                return objetos[index];
            }
            return null;
        }

        public void Delete(int id)
        {
            int index = ids.IndexOf(id);
            if (index >= 0)
            {
                ids.RemoveAt(index);
                objetos.RemoveAt(index);
            }
        }

        public void Draw()
        {
            foreach (var objeto in objetos)
            {
                objeto.Draw();
            }
        }
    }
}