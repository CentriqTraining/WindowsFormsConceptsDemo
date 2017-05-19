using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseObjects.Interfacess
{
    public interface IDSRepository
    {
        DataSet GetBusinessAreas();
        DataSet GetInventoryItems();
        DataSet GetData();
    }
}
