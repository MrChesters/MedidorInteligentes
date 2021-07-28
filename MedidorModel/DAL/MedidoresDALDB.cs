using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public class MedidoresDALDB : IMedidorDAL
    {

        private MedidorInteligenteEntities medidorDB = new MedidorInteligenteEntities();


        public List<Medidor> ObtenerMedidor()
        {
            return this.medidorDB.Medidors.ToList();
        }
    
    }
}
