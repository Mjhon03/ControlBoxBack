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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICorresponsal" in both code and config file together.
    [ServiceContract]
    public interface ICorresponsal
    {
        [OperationContract]
        DataSet GetDataCorresponsal();
        [OperationContract]
        string AddDataCorresponsal(corresponsales cor);
        [OperationContract]
        string UpdateDataCorresponsal(corresponsales cor);
        [OperationContract]
        string DeleteCorresponsal(corresponsales cor);
    }
}
