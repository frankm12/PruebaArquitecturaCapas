using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_negocios
{
    public class People
    {
        public static List<Datos.una_tabla> Get()
        {
            using (Datos.capasEntities db = new Datos.capasEntities())
            {
                return db.una_tabla.ToList();
            }
        }
    }
}
