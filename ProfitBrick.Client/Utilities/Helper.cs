using ProfitBricks.Client.ProfitBricksProxy;
using ProfitBricks.POCO;
using ProfitBricks.POCO.Enums;
using System.Collections.Generic;
using System.Linq;

namespace ProfitBricks.Client.Helper
{
    /// <summary>
    /// Represents a class that contains static methods for converting raw server objects into ProfitBricks Client library objects.
    /// </summary>
    public class Converters
    {
        /// <summary>
        /// Converts ProfitBricksProxy.server object into ProfitBricks.POCO.Server
        /// </summary>
        /// <param name="server">ProfitBricksProxy.server</param>
        /// <returns>ProfitBricks.POCO.Server</returns>
        public static Server ConvertServer(server server)
        {
            var toReturn = new Server
            {
                ServerId = server.serverId,
                ServerName = server.serverName,
                Cores = server.cores,
                Ram = server.ram,
                InternetAccess = server.internetAccess,

                CreationTime = server.creationTime,
                LastModificationTime = server.lastModificationTime,
                OsType = (OsType)server.osType,
                AvailabilityZone = (AvailabilityZone)server.availabilityZone,
                CpuHotPlug = server.cpuHotPlug,
                RamHotPlug = server.ramHotPlug,
                NicHotPlug = server.nicHotPlug,
                NicHotUnPlug = server.nicHotUnPlug,
                DiscVirtioHotPlug = server.discVirtioHotPlug,
                DiscVirtioHotUnPlug = server.discVirtioHotUnPlug,
                VirtualMachineState = (VirtualMachineState)server.virtualMachineState,
                ProvisioningState = (ProvisioningState)server.provisioningState,
            };

            toReturn.Ips = server.ips == null ? new List<string>() : server.ips.ToList();

            toReturn.Nics = new List<Nic>();

            #region Nic

            if (server.nics != null)
            {
                foreach (var nic in server.nics)
                {
                    toReturn.Nics.Add(ConvertNic(nic));
                }
            }
            #endregion

            #region Rom drives

            toReturn.RomDrives = new List<RomDrive>();

            if (server.romDrives != null)
            {
                foreach (var romDrive in server.romDrives)
                {
                    toReturn.RomDrives.Add(new RomDrive
                    {
                        BootDevice = romDrive.bootDevice,
                        ImageId = romDrive.imageId,
                        ImageName = romDrive.imageName
                    });
                }
            }

            #endregion

            #region Connected volumes

            toReturn.ConnectedVolumes = new List<ConnectedVolume>();

            if (server.connectedStorages != null)
            {
                foreach (var cStorages in server.connectedStorages)
                {
                    toReturn.ConnectedVolumes.Add(new ConnectedVolume
                    {
                        BootDevice = cStorages.bootDevice,
                        BusType = (BusType)cStorages.busType,
                        DeviceNumber = cStorages.deviceNumber,
                        Size = cStorages.size,
                        StorageId = cStorages.storageId,
                        StorageName = cStorages.storageName

                    });
                }
            }

            #endregion

            return toReturn;
        }

        /// <summary>
        /// Converts ProfitBricksProxy.nic object into ProfitBricks.POCO.Nic
        /// </summary>
        /// <param name="nic">ProfitBricksProxy.nic</param>
        /// <returns>ProfitBricks.POCO.Nic</returns>
        internal static Nic ConvertNic(nic nic)
        {
            var newNic = new Nic
            {
                NicId = nic.nicId,
                NicName = nic.nicName,
                LanId = nic.lanId,
                InternetAccess = nic.internetAccess,
                ServerId = nic.serverId,
                MacAddress = nic.macAddress,
                DhcpActive = nic.dhcpActive,
                GatewayIp = nic.gatewayIp,
                Ips = nic.ips == null ? new List<string>() : nic.ips.ToList()
            };

            if (nic.firewall != null)
            {
                newNic.Firewall = new Firewall
                {
                    Active = nic.firewall.active,
                    FirewallId = nic.firewall.firewallId,
                    NicId = nic.firewall.nicId
                };

            }

            return newNic;
        }

        /// <summary>
        /// Converts ProfitBricksProxy.dataCenter object into ProfitBricks.POCO.DataCenter
        /// </summary>
        /// <param name="datacenter">ProfitBricksProxy.dataCenter</param>
        /// <returns>ProfitBricks.POCO.DataCenter</returns>
        public static DataCenter ConvertDataCenter(dataCenter datacenter)
        {
            var toReturn = new POCO.DataCenter
            {
                DataCenterId = datacenter.dataCenterId,
                DataCenterVersion = datacenter.dataCenterVersion,
                DataCenterName = datacenter.dataCenterName,
                Location = (Location)datacenter.location,
                ProvisioningState = (ProvisioningState)datacenter.provisioningState
            };

            #region Servers

            toReturn.Servers = new List<Server>();

            if (datacenter.servers != null)
            {
                foreach (var server in datacenter.servers)
                {
                    toReturn.Servers.Add(Converters.ConvertServer(server));
                }
            }

            #endregion

            #region Volumes

            if (datacenter.storages != null)
            {
                toReturn.Volumes = new List<Volume>();

                foreach (var volume in datacenter.storages)
                {
                    toReturn.Volumes.Add(ConvertStorages(volume));
                }
            }

            #endregion

            #region Loadbalancers

            toReturn.LoadBalancers = new List<LoadBalancer>();

            if (datacenter.loadBalancers != null)
            {
                foreach (var loadBalancer in datacenter.loadBalancers)
                {
                    toReturn.LoadBalancers.Add(Converters.ConvertLoadBalancer(loadBalancer));
                }
            }

            #endregion
            return toReturn;
        }

        /// <summary>
        /// Converts ProfitBricksProxy.loadBalancer object into ProfitBricks.POCO.LoadBalancer
        /// </summary>
        /// <param name="loadBalancer">ProfitBricksProxy.loadBalancer</param>
        /// <returns>ProfitBricks.POCO.LoadBalancer</returns>
        public static LoadBalancer ConvertLoadBalancer(loadBalancer loadBalancer)
        {
            #region Load Balancer

            var toReturn = new LoadBalancer
            {
                LoadBalancerId = loadBalancer.loadBalancerId,
                LoadBalancerName = loadBalancer.loadBalancerName,
                LoadBalancerAlgorithm = (LoadBalancerAlgorithm)loadBalancer.loadBalancerAlgorithm,
                InternetAccess = loadBalancer.internetAccess,
                Ip = loadBalancer.ip,
                LanId = loadBalancer.lanId,

            };

            #endregion

            #region Balanced Server

            toReturn.BalancedServers = new List<BalancedServer>();
            if (loadBalancer.balancedServers != null)
            {
                foreach (var balancedServer in loadBalancer.balancedServers)
                {
                    toReturn.BalancedServers.Add(new BalancedServer
                    {
                        Activate = balancedServer.activate,
                        BlancedNicId = balancedServer.balancedNicId,
                        ServerId = balancedServer.serverId,
                        ServerName = balancedServer.serverName
                    });
                }
            }
            #endregion

            #region Firewall

            toReturn.Firewall = ConvertFirewall(loadBalancer.firewall);

            #endregion

            return toReturn;
        }

        /// <summary>
        /// Converts ProfitBricksProxy.storage object into ProfitBricks.POCO.Volume
        /// </summary>
        /// <param name="volume">ProfitBricksProxy.storage</param>
        /// <returns>ProfitBricks.POCO.Volume</returns>
        public static Volume ConvertStorages(storage volume)
        {
            var toReturn = new Volume
            {
                StorageId = volume.storageId,
                StorageName = volume.storageName,
                CreationTime = volume.creationTime,
                LastModificationTime = volume.lastModificationTime,
                Size = volume.size,
                ProvisioningState = (ProvisioningState)volume.provisioningState
            };

            if (volume.mountImage != null)
            {
                toReturn.MountImage = new MountImage
                {
                    ImageId = volume.mountImage.imageId,
                    ImageName = volume.mountImage.imageName
                };
            }

            toReturn.serverIds = volume.serverIds != null ? volume.serverIds.ToList() : new List<string>();

            return toReturn;
        }

        /// <summary>
        /// Converts ProfitBricksProxy.snapshot object into ProfitBricks.POCO.Snapshot
        /// </summary>
        /// <param name="snapshot">ProfitBricksProxy.snapshot</param>
        /// <returns>ProfitBricks.POCO.Snapshot</returns>
        internal static Snapshot ConvertSnapshot(snapshot snapshot)
        {
            var toReturn = new Snapshot
            {
                SnapshotId = snapshot.snapshotId,
                Description = snapshot.description,
                SnapshotSize = snapshot.snapshotSize,
                SnapshotName = snapshot.snapshotName,
                Bootable = snapshot.bootable,
                OsType = (OsType)snapshot.osType,
                CpuHotPlug = snapshot.cpuHotPlug,
                CpuHotUnPlug = snapshot.cpuHotUnPlug,
                DiscVirtioHotPlug = snapshot.discVirtioHotPlug,
                DiscVirtioHotUnPlug = snapshot.discVirtioHotUnPlug,
                RamHotPlug = snapshot.ramHotPlug,
                RamHotUnPlug = snapshot.ramHotUnPlug,
                NicHotPlug = snapshot.nicHotPlug,
                NicHotUnPlug = snapshot.nicHotUnPlug,
                CreationTimestamp = snapshot.creationTimestamp,
                ModificationTimestamp = snapshot.modificationTimestamp,
                Location = (Location)snapshot.location
            };

            return toReturn;
        }

        /// <summary>
        /// Converts ProfitBricksProxy.notification object into ProfitBricks.POCO.Notification
        /// </summary>
        /// <param name="notification">ProfitBricksProxy.notification</param>
        /// <returns>ProfitBricks.POCO.Notification</returns>
        internal static Notification ConvertNotification(notification notification)
        {
            return new Notification
             {
                 Id = notification.id,
                 NetworkUUid = notification.networkUUid,
                 RelatedItemUuid = notification.relatedItemUuid,
                 Timestamp = notification.timestamp,
                 MessageCode = (NotificationCode)notification.messageCode,
                 RelatedItemType = (VirtualItemType)notification.relatedItemType,
                 Message = notification.message
             };
        }

        /// <summary>
        /// Converts ProfitBricksProxy.firewall object into ProfitBricks.POCO.Firewall
        /// </summary>
        /// <param name="firewall">ProfitBricksProxy.firewall</param>
        /// <returns>ProfitBricks.POCO.Firewall</returns>
        internal static Firewall ConvertFirewall(firewall firewall)
        {
            if (firewall == null)
                return new Firewall();

            var toReturn = new Firewall
            {
                Active = firewall.active,
                FirewallId = firewall.firewallId,
                NicId = firewall.nicId
            };

            toReturn.FirewallRules = ConvertFirewallRules(firewall.firewallRules);

            return toReturn;
        }

        /// <summary>
        /// Converts collection of ProfitBricksProxy.firewallRule object into generic list ProfitBricks.POCO.FirewallRule
        /// </summary>
        /// <param name="firewallRules">Array of ProfitBricksProxy.firewall</param>
        /// <returns>Generic list of ProfitBricks.POCO.Firewall</returns>
        internal static List<FirewallRule> ConvertFirewallRules(firewallRule[] firewallRules)
        {
            var toReturn = new List<FirewallRule>();

            if (firewallRules != null)
            {
                foreach (var rule in firewallRules)
                {
                    toReturn.Add(new FirewallRule
                    {
                        FirewallRuleId = rule.firewallRuleId,
                        Name = rule.name,
                        IcmpCode = rule.icmpCode,
                        IcmpType = rule.icmpType,
                        PortRangeEnd = rule.portRangeEnd,
                        PortRangeStart = rule.portRangeStart,
                        Protocol = (Protocol)rule.protocol,
                        SourceIp = rule.sourceIp,
                        SourceMac = rule.sourceMac,
                        TargetIp = rule.targetIp
                    });
                }
            }

            return toReturn;
        }


        /// <summary>
        /// Converts ProfitBricksProxy.image object into ProfitBricks.POCO.Image
        /// </summary>
        /// <param name="image">ProfitBricksProxy.image</param>
        /// <returns>ProfitBricks.POCO.Image</returns>
        internal static Image ConvertImage(image image)
        {
            return new Image
            {
                Bootable = image.bootable,
                CpuHotPlug = image.cpuHotPlug,
                CpuHotUnPlug = image.cpuHotUnPlug,
                Description = image.description,
                DiscVirtioHotPlug = image.discVirtioHotPlug,
                DiscVirtioHotUnPlug = image.discVirtioHotUnPlug,
                ImageId = image.imageId,
                ImageName = image.imageName,
                ImageSize = image.imageSize,
                ImageType = (ImageType)image.imageType,
                Location = (Location)image.location,
                NicHotPlug = image.nicHotPlug,
                NicHotUnPlug = image.nicHotUnPlug,
                OsType = (OsType)image.osType,
                Public = image.@public,
                RamHotPlug = image.ramHotPlug,
                RamHotUnPlug = image.ramHotUnPlug,
                Writeable = image.writeable,
                ServerIds = image.serverIds == null ? new List<string>() : image.serverIds.ToList()
            };
        }

        /// <summary>
        /// Converts ProfitBricksProxy.ipBlock object into ProfitBricks.POCO.IpBlock
        /// </summary>
        /// <param name="ipBlock">ProfitBricksProxy.ipBlock</param>
        /// <returns>ProfitBricks.POCO.IpBlock</returns>
        internal static IpBlock ConvertIp(ipBlock ipBlock)
        {
            var toReturn = new IpBlock
            {
                BlockId = ipBlock.blockId,
                Location = (Location)ipBlock.location,
            };

            toReturn.PublicIps = new List<PublicIpBlock>();
            if (ipBlock.publicIps != null)
            {
                foreach (var pip in ipBlock.publicIps)
                {
                    toReturn.PublicIps.Add(new PublicIpBlock { Ip = pip.ip, NicId = pip.nicId });
                }
            }

            return toReturn;
        }
    }
}
