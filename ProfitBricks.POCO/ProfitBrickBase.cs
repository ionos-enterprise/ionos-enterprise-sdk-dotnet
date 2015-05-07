using ProfitBricks.POCO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfitBricks.POCO
{
    /// <summary>
    /// PB Base class.
    /// </summary>
    public class ProfitBricksBase
    {
        /// <summary>
        /// Parameter used for execute function in <c ref="ProfitBricks.Client.Service" >Service</c>
        /// </summary>
        public string FunctionName { get; set; }

        /// <summary>
        /// Provisioning State of the target Virtual PB object (INACTIVE, INPROCESS, AVAILABLE, DELETED, ERROR)
        /// </summary>
        public ProvisioningState ProvisioningState { get; set; }
    }
}
