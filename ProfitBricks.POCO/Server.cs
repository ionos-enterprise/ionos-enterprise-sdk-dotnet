using ProfitBricks.POCO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfitBricks.POCO
{
    /// <summary>
    /// Server class
    /// </summary>
    public class Server : ProfitBricksBase
    {
        /// <summary>
        /// ServerID
        /// </summary>
        public string ServerId { get; set; }

        /// <summary>
        /// ServerName
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Cores
        /// </summary>
        public int Cores { get; set; }

        /// <summary>
        /// Ram
        /// </summary>
        public int Ram { get; set; }

        /// <summary>
        /// InternetAccess
        /// </summary>
        public bool InternetAccess { get; set; }

        /// <summary>
        /// Ips
        /// </summary>
        public List<string> Ips { get; set; }

        /// <summary>
        /// CreationTime
        /// </summary>
        public System.DateTime CreationTime { get; set; }

        /// <summary>
        /// LastModificationTime
        /// </summary>
        public System.DateTime LastModificationTime { get; set; }

        /// <summary>
        /// OS type of the server (WINDOWS, LINUX, OTHER, UNKOWN)
        /// </summary>
        public OsType OsType { get; set; }

        /// <summary>
        /// Zone in which the server is located (AUTO, ZONE_1, ZONE_2)
        /// </summary>
        public AvailabilityZone AvailabilityZone { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool CpuHotPlug { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool RamHotPlug { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool NicHotPlug { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool NicHotUnPlug { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DiscVirtioHotPlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool DiscVirtioHotUnPlug { get; set; }

        /// <summary>
        /// Lists all storages connected to the server, including the following paramenters:
        /// - storageId: storage identifier
        /// - storageName: name of the storage
        /// - size: storage size (in GiB)
        /// For these three parameter see also Create Storage or Get Storage
        /// - busType: Bus type to which the storage is connected
        /// - deviceNumber: device number the storage is connected
        /// For these two parameter see also Connect Storage
        /// - bootDevice: a flag, indicating whether server is booting from this storage or not [TRUE/FALSE]
        /// </summary>
        public List<ConnectedVolume> ConnectedVolumes { get; set; }

        /// <summary>
        /// Lists all CD-ROM drives assigned to the server, including the parameters of the CD-ROM/DVDs image, such as:
        /// - imageId: CD-ROM/DVD image identifier
        /// - imageName: name of the CD-ROM/DVD image
        /// - bootDevice: a flag, indicating whether server is booting from this drive or not [TRUE/FALSE]
        /// </summary>
        public List<RomDrive> RomDrives { get; set; }

        /// <summary>
        /// Lists all NICs assigned to the server.
        /// </summary>
        public List<Nic> Nics { get; set; }

        /// <summary>
        /// Describes the current provisioning state of the specified virtual server (INACTIVE, INPROCESS, AVAILABLE, DELETED, ERROR)
        /// </summary>
        public VirtualMachineState VirtualMachineState { get; set; }
    }
}
