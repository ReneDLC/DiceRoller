using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DiceRoller3000Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDiceService" in both code and config file together.
    [ServiceContract]
    public interface IDiceService
    {
        [OperationContract]
        void DoWork();
    }
}
