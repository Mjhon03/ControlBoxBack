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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICorresponsales" in both code and config file together.
    [ServiceContract]
    public interface ICorresponsales
    {
        [OperationContract]
        IEnumerable<corresponsal> GetDataCorresponsal();
        [OperationContract]
        string AddDataCorresponsal(corresponsal cor);
        [OperationContract]
        string UpdateDataCorresponsal(corresponsal cor);
        [OperationContract]
        string DeleteCorresponsal(corresponsal cor);
    }
}
