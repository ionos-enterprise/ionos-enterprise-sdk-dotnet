This guide will show you how to programmatically perform common management tasks using the .NET SDK for the ProfitBricks API. [.NET] (http://www.microsoft.com/net) is a software framework developed by Microsoft that runs primarily on Microsoft Windows. 

## Table of Contents

* [Concepts](#Concepts)
* [Getting Started](#GettingStarted)
* [How to: Create a Data Center](#CreateDataCenter)
* [How to: Delete a Data Center](#DeleteDataCenter)
* [How to: Create a Server](#CreateServer)
* [How to: Update Cores, Memory, and Disk](#UpdateCoresMemoryDisk)
* [How to: Detach and Reattach a Storage Volume](#DetachReattachStorageVolume)
* [How to: List Servers, Volumes, and Data Centers](#ListServersVolumesDataCenters)
* [How to: Create Additional Network Interfaces](#CreateNic)
* [Example](#Example)

--------------

## <a name="Concepts"></a>Concepts

This .NET library wraps the ProfitBricks SOAP API. All API operations are performed over SSL and authenticated using your ProfitBricks portal credentials. The API can be accessed within an instance running in ProfitBricks or directly over the Internet from any application that can send an HTTPS request and receive an HTTPS response. 

## <a name="GettingStarted"></a>Getting Started

Before you begin you will need to have [signed-up](https://www.profitbricks.com/signup) for a ProfitBricks account. The credentials you setup during sign-up will be used to authenticate against the API.
 
### Installation

The official .NET library is available from the ProfitBricks GitHub account found [here](https://github.com/profitbricks/profitbricks-sdk-net). You can download the latest stable version by cloning the repository and then adding the project to your solution.
	
Or you can add the SDK by using nuget:

	Install-Package ProfitBricksSDK

### Using the Driver

Here is a simple example on how to use the library.

List all data centers: 

     var dcs = dcApi.FindAll(depth: 5);
    
This will list all virtual data centers you have under your account.

### Additional Documentation and Support

You can engage with us in the community and we'll be more than happy to answer any questions you might have. 

## <a name="CreateDataCenter"> </a>How to: Create a Data Center

ProfitBricks introduces the concept of data centers. These are logically separated from one and the other and allow you to have a self-contained environment for all servers, volumes, networking, snapshots, and so forth. The goal is to give you the same experience as you would have if you were running your own physical data center.

You are required to have a data center created before you can create any other objects. Think of the data center as a bucket in which all objects, such as servers and volumes, live. 

The following code example shows you how to programmatically create a data center: 

	

    namespace ProfitbricksV2.Example
    {
        class Program
        {
            static void Main(string[] args)
            {
                var configuration = new Configuration
                {
                    Username = "username",
                    Password = "password",

                };
                var dcApi = new DataCenterApi(configuration);
            


                // CreateDataCenterRequest. 
                // The only required field is DataCenterName. 
                // If location parameter is left empty data center will be created in the default region of the customer
                var datacenter = new Datacenter
                {
                    Properties = new DatacenterProperties
                    {
                        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                        Description = "Unit test for .Net SDK PB REST V2",
                        Location = "us/lasdev"
                    }
                };


                datacenter = dcApi.Create(datacenter);
            }
        }
    }


## <a name="DeleteDataCenter"></a>How to: Delete a Data Center

You will want to exercise a bit of caution here. Removing a data center will **destroy** all objects contained within that data center -- servers, volumes, snapshots, and so on. The objects -- once removed -- will be unrecoverable. 

The following is an example on how to remove the data center created above:

    dcApi.Delete(datacenter.Id);

## <a name="CreateServer"></a>How to: Create a Server

The following example illustrates how you would create a server and assign it an OS, cores, and memory. We urge you to check the [documentation](https://devops.profitbricks.com/api/soap/) to see the complete list attributes available.

    var server = new Server
    {
    Properties = new ServerProperties
    {
        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
        Cores = 1,
        Ram = 256
    }
    };

    // response will contain Id of a newly created server.
    server = serverApi.Create(datacenter.Id, server);

One of the unique features of the ProfitBricks platform when compared with the other providers is that it allows you to define your own settings for cores, memory, and disk size without being tied to a particular size.  

## <a name="UpdateServer"></a>How to: Update Cores, Memory, and Disk

ProfitBricks allows users to dynamically update cores, memory, and disk independently of each other. This removes the restriction of needing to upgrade to the next size up to receive an increase in memory. You can now simply increase the instances memory keeping your costs in-line with your resource needs. 

The following code illustrates how you can update cores and memory: 

    server = serverApi.PartialUpdate(datacenter.Id, server.Id, new ServerProperties { Name = server.Properties.Name + " -Updated" });


## <a name="DetachReattachStorageVolume"></a>How to: Detach and Reattach a Storage Volume

ProfitBricks allows for the creation of multiple storage volumes. You can detach and reattach these on the fly. This allows for various scenarios such as re-attaching a failed OS disk to another server for possible recovery, move a volume to another location and re-attaching to a different server and spinning it up. 

The following illustrates how you would attach a volume and then detach it from a server:

    //First we need to create a volume.
    var volume = new Volume
    {
        Properties = new VolumeProperties
        {
            Size = 4,
            Image = "fbaae2b2-c899-11e5-aa10-52540005ab80",
            Type = "HDD",
            Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
            SshKeys = new System.Collections.Generic.List<string> { "hQGOEJeFL91EG3+l9TtRbWNjzhDVHeLuL3NWee6bekA=" }
        }
    };

    volume = volumeApi.Create(datacenter.Id, volume);

    //Then we are going to attach the newly volume to a server.   
    attachedVolumesApi.AttachVolume(datacenter.Id, server.Id, new Volume { Id = volume.Id });

    //Here we are going to detach it from the server.
    attachedVolumesApi.DetachVolume(datacenter.Id, server.Id, volume.Id);

## <a name="ListServersVolumesDataCenters"></a>How to: List Servers, Volumes, and Data Centers

You can pull various resource lists from your data centers using the .NET library. The three most common resources are data centers, Servers, and Volumes.

The following code illustrates how to pull these three list types: 

    var dcs = dcApi.FindAll(depth: 5);
    var servers = serverApi.FindAll(datacenter.Id, depth: 5);
    var volumes = volumeApi.FindAll(datacenter.Id, depth: 5);


## <a name="CreateNic"></a>How to: Create Additional Network Interfaces

The ProfitBricks platform supports adding multiple NICs to a server. These NICs can be used to create different, segmented networks on the platform.
The sample below shows you how to add a second NIC to an existing server: 

    var nic = new Nic { Properties = new NicProperties { Lan = 1 , Dhcp = true, Name = "Nic name"} };

    nic = nicApi.Create(datacenter.Id, server.Id, nic);

One item to note is this function will result in the server being rebooted. 

## <a name="Example"></a> Example

    using Api;
    using Client;
    using Model;
    using System;

    namespace ProfitbricksV2.Example
    {
        class Program
        {
            static void Main(string[] args)
            {
                var configuration = new Configuration
                {
                    Username = "username",
                    Password = "password",

                };
                var dcApi = new DataCenterApi(configuration);
                var serverApi = new ServerApi(configuration);
                var volumeApi = new VolumeApi(configuration);
                var attachedVolumesApi = new AttachedVolumesApi(configuration);
                var nicApi = new NetworkInterfacesApi(configuration);


                // CreateDataCenterRequest. 
                // The only required field is DataCenterName. 
                // If location parameter is left empty data center will be created in the default region of the customer
                var datacenter = new Datacenter
                {
                    Properties = new DatacenterProperties
                    {
                        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                        Description = "Unit test for .Net SDK PB REST V2",
                        Location = "us/lasdev"
                    }
                };

                // Response will contain Id of a newly created data center.
                datacenter = dcApi.Create(datacenter);

                // CreateServer. 
                // DataCenterId: Defines the data center wherein the server is to be created.
                // AvailabilityZone: Selects the zone in which the server is going to be created (AUTO, ZONE_1, ZONE_2).
                // Cores: Number of cores to be assigned to the specified server. Required field.
                // InternetAccess: Set to TRUE to connect the server to the Internet via the specified LAN ID.
                // OsType: Sets the OS type of the server.
                // Ram: Number of RAM memory (in MiB) to be assigned to the server.
                var server = new Server
                {
                    Properties = new ServerProperties
                    {
                        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                        Cores = 1,
                        Ram = 256
                    }
                };

                // response will contain Id of a newly created server.
                server = serverApi.Create(datacenter.Id, server);

                // UpdateServer
                // ServerId: Id of the server to be updated.
                // ServerName: Renames target virtual server
                // Cores: Updates the amount of cores of the target virtual server
                // Ram: Updates the RAM memory (in MiB) of the target virtual server. The minimum RAM size is 256 MiB
                server = serverApi.PartialUpdate(datacenter.Id, server.Id, new ServerProperties { Name = server.Properties.Name + " -Updated" });


                // CreateVolume
                // DataCenterId: Defines the data center wherein the storage is to be created. If left empty, the storage will be created in a new data center
                // Size: Storage size (in GiB). Required Field.
                // Type: SSD or HDD disk type, Required Field
                // SshKeys: Ssh key, Optional field
                var volume = new Volume
                {
                    Properties = new VolumeProperties
                    {
                        Size = 4,
                        Image = "fbaae2b2-c899-11e5-aa10-52540005ab80",
                        Type = "HDD",
                        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                        SshKeys = new System.Collections.Generic.List<string> { "hQGOEJeFL91EG3+l9TtRbWNjzhDVHeLuL3NWee6bekA=" }
                    }
                };

                // Response will contain Id of a newly created volume.
                volume = volumeApi.Create(datacenter.Id, volume);

                // AttachVolume
                // ServerId: Identifier of the target virtual storage. Required field.
                // StorageId: Identifier of the virtual storage to be connected. Required field.
                // BusType: Bus type to which the storage will be connected
                attachedVolumesApi.AttachVolume(datacenter.Id, server.Id, new Volume { Id = volume.Id });

                attachedVolumesApi.DetachVolume(datacenter.Id, server.Id, volume.Id);

                // Fetches list of all Data Centers
                var dcs = dcApi.FindAll(depth: 5);

                // Fetches list of all Servers
                var servers = serverApi.FindAll(datacenter.Id, depth: 5);

                // Fetches list of all Volumes
                var volumes = volumeApi.FindAll(datacenter.Id, depth: 5);

                // CreateNicRequest
                // Identifier of the target virtual server. Required field.
                // Nic: Names the NIC
                // Toggles usage of ProfitBricks DHCP
                // Lan
                var nic = new Nic { Properties = new NicProperties { Lan = 1 , Dhcp = true, Name = "Nic name"} };

                nic = nicApi.Create(datacenter.Id, server.Id, nic);

            }
        }
    }
