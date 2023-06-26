using ControlBoxWCF.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ControlBoxWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOficinas" in both code and config file together.
    [ServiceContract]
    public interface IOficinas
    {
        [OperationContract]
        IEnumerable<oficina> GetDataOficinas();
        [OperationContract]
        IEnumerable<oficina> GetAllOficinas();
        [OperationContract]
        string AddDataOficinas(oficina ofi);
        [OperationContract]
        string UpdateDataOficinas(oficina ofi);
        [OperationContract]
        string DeleteOficinas(oficina ofi);
    }
}
