This guide will show you how to programmatically perform common management tasks using the [.NET SDK](https://github.com/profitbricks/profitbricks-sdk-net) for the ProfitBricks Cloud API.

[.NET](http://www.microsoft.com/net) is a software framework developed by Microsoft that primarily runs on the Microsoft Windows operating system.

# Table of Contents

* [Concepts](#concepts)
* [Getting Started](#getting-started)
    * [Installation](#installation)
    * [Using the Driver](#using-the-driver)
* [Operations](#operations)
    * [Create Virtual Data Center](#create-virtual-data-center)
    * [Delete Virtual Data Center](#delete-virtual-data-center)
    * [Create Server](#create-server)
    * [Update Cores, Memory, and Disk](#update-cores-memory-disk)
    * [Detach and Reattach a Storage Volume](#detach-reattach-storage-volume)
    * [List Servers, Volumes, and Virtual Data Centers](#list-servers-volumes-data-centers)
    * [Create Additional Network Interfaces](#create-additional-network-interfaces)
* [Example](#example)
* [Support](#support)

# Concepts

This .NET library wraps the ProfitBricks Cloud API. All API operations are performed over a SSL/TLS secured connection and authenticated using your ProfitBricks portal credentials. The Cloud API can be accessed over the public Internet from any application that can send an HTTPS request and receive an HTTPS response.

# Getting Started

Before you begin you will need to have [signed-up](https://www.profitbricks.com/signup) for a ProfitBricks account. The credentials you setup during sign-up will be used to authenticate against the Cloud API.

## Installation

The official .NET library is available from the [ProfitBricks GitHub account](https://github.com/profitbricks/profitbricks-sdk-net). You can download the latest stable version by cloning the repository and then adding the project to your solution.

Or you can add the SDK by using `nuget`:

	Install-Package ProfitBricksSDK

## Using the Driver

Here is a simple example on how to use the library.

List all virtual data centers:

     var dcs = dcApi.FindAll(depth: 5);

This will list all virtual data centers you have under your account.

# Operations

The next few sections describe some commonly used features of this .NET library and provide implementation examples.

## Create Virtual Data Center

ProfitBricks utilizes the concept of virtual data centers. These are logically separated from one and the other and allow you to have a self-contained environment for all servers, volumes, networking, snapshots, and so forth. The goal is to replicate the experience of managing resources in a physical data center.

You are required to have a virtual data center created before you can create any other objects. Think of the virtual data center as a bucket in which all objects, such as servers and volumes, live.

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
                // If location parameter is left empty the virtual data center will be created in the user's default region
                var datacenter = new Datacenter
                {
                    Properties = new DatacenterProperties
                    {
                        Name = "dotNet Test " + DateTime.Now.ToShortTimeString(),
                        Description = "Test for dotNet SDK",
                        Location = "us/las"
                    }
                };


                datacenter = dcApi.Create(datacenter);
            }
        }
    }

## Delete Virtual Data Center

You will want to exercise a bit of caution here. Removing a virtual data center will **destroy** all objects contained within that virtual data center -- servers, volumes, snapshots, and so on. The objects -- once removed -- will **NOT be recoverable**.

The following is an example of how to remove the virtual data center created above:

    dcApi.Delete(datacenter.Id);

## Create Server

The following example illustrates how you would create a server and assign it a number of processing cores and memory. This example also shows specifying the *CpuFamily* as "INTEL_XEON" rather than the default of "AMD_OPTERON" You may wish to refer to the Cloud API documentation to see the complete list of attributes available.

    var server = new Server
    {
    Properties = new ServerProperties
    {
        Name = "dotNet Test " + DateTime.Now.ToShortTimeString(),
        Cores = 1,
        Ram = 256,
        CpuFamily = "INTEL_XEON"
    }
    };

    // response will contain Id of a newly created server.
    server = serverApi.Create(datacenter.Id, server);

One of the unique features of the ProfitBricks platform when compared with some other cloud providers is that it enables you to set the values for cores, memory, and volume size independently. You are not required to provision your servers by selecting  from a set of pre-sized "instances."

## Update Cores, Memory, and Disk

ProfitBricks allows users to dynamically update the values assigned to cores, memory, and disk independently of each other. This removes the restriction of needing to upgrade to the next server or instance size just to get access to more memory. This helps manage costs as provisioned resources can be configured to match your actual resource needs.

The following code illustrates how you can update cores and memory:

    server = serverApi.PartialUpdate(datacenter.Id, server.Id, new ServerProperties { Name = server.Properties.Name + " -Updated" });

## Detach and Reattach a Storage Volume

ProfitBricks allows for the creation of multiple storage volumes. You can detach and reattach these on the fly. This allows for various scenarios such as re-attaching a failed OS disk to another server for possible recovery or moving a volume to another location and re-attaching it to a different server.

The following illustrates how you would create a new 40 GB volume:

    //First we need to create a volume.
    var volume = new Volume
    {
        Properties = new VolumeProperties
        {
            Size = 40,
            Image = "fbaae2b2-c899-11e5-aa10-52540005ab80",
            Type = "HDD",
            Name = "dotNet Test " + DateTime.Now.ToShortTimeString(),
            ImagePassword = "r@nd0m_S3cure%str1nG"
            SshKeys = new System.Collections.Generic.List<string> { "hQGOEJeFL91EG3+l9TtRbWNjzhDVHeLuL3NWee6bekA=" }
        }
    };

    volume = volumeApi.Create(datacenter.Id, volume);

Please review these notes about the create volume example:

* The value supplied for *Image* is an example and is unlikely to be valid. ProfitBricks supplies a number of different images for various operating systems. These images are updated from time to time and these updates often result in a new UUID being issued. The .NET SDK can help you to locate valid image IDs. There are also [CLI](https://devops.profitbricks.com/tools/cli) and [PowerShell](https://devops.profitbricks.com/tools/powershell) tools available on [DevOps Central](https://devops.profitbricks.com/tools/) that can help you find the currently available UUIDs.

* The value supplied for *Type* can be set to "HDD" or "SSD", depending on what storage type you want to use.

* Volumes **need** to have either an *ImagePassword* or *SshKeys* set. It is possible to set both, however, *SshKeys* are only applicable to Linux images. Therefore you **MUST** provide an *ImagePassword* when creating volumes based on a Microsoft Windows *Image*.

To attach the volume to a server identified by *server.Id*:

    //Then we are going to attach the newly volume to a server.
    attachedVolumesApi.AttachVolume(datacenter.Id, server.Id, new Volume { Id = volume.Id });

To detach the volume from a server identified by *server.Id*:

    //Here we are going to detach it from the server.
    attachedVolumesApi.DetachVolume(datacenter.Id, server.Id, volume.Id);

## List Servers, Volumes, and Virtual Data Centers

You can pull various resource lists from your virtual data centers using the .NET library. The three most commonly queried resources are virtual data centers, servers, and volumes.

The following code illustrates how to pull these three list types:

    var dcs = dcApi.FindAll(depth: 5);
    var servers = serverApi.FindAll(datacenter.Id, depth: 5);
    var volumes = volumeApi.FindAll(datacenter.Id, depth: 5);

## Create Additional Network Interfaces

The ProfitBricks cloud platform supports adding multiple NICs to a server. These NICs can be used to create different, segmented networks on the platform.

The sample below shows you how to add a second NIC to an existing server:

    var nic = new Nic { Properties = new NicProperties { Lan = 1 , Dhcp = true, Name = "Nic name"} };

    nic = nicApi.Create(datacenter.Id, server.Id, nic);

**Please Note:** Using this function will result in a running server being rebooted.

## Example

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
                        Name = "dotNet Test " + DateTime.Now.ToShortTimeString(),
                        Description = "Test for dotNet SDK",
                        Location = "us/las"
                    }
                };

                // Response will contain Id of a newly created virtual data center.
                datacenter = dcApi.Create(datacenter);

                // CreateServer.
                // DataCenterId: Defines the virtual data center wherein the server is to be created.
                // AvailabilityZone: Selects the zone in which the server is going to be created (AUTO, ZONE_1, ZONE_2).
                // Cores: Number of cores to be assigned to the specified server. Required field.
                // InternetAccess: Set to TRUE to connect the server to the Internet via the specified LAN ID.
                // OsType: Sets the OS type of the server.
                // Ram: Amount of RAM memory (in MiB) to be assigned to the server.
                var server = new Server
                {
                    Properties = new ServerProperties
                    {
                        Name = "dotNet Test " + DateTime.Now.ToShortTimeString(),
                        Cores = 1,
                        Ram = 256
                    }
                };

                // response will contain the Id of a newly created server.
                server = serverApi.Create(datacenter.Id, server);

                // UpdateServer
                // ServerId: Id of the server to be updated.
                // ServerName: Renames target virtual server
                // Cores: Updates the amount of cores of the target virtual server
                // Ram: Updates the RAM memory (in MiB) of the target virtual server. The minimum RAM size is 256 MiB
                server = serverApi.PartialUpdate(datacenter.Id, server.Id, new ServerProperties { Name = server.Properties.Name + " -Updated" });


                // CreateVolume
                // DataCenterId: Defines the virtual data center wherein the storage is to be created. If left empty, the storage will be created in a new virtual data center
                // Size: Storage size (in GiB). Required Field.
                // Type: SSD or HDD disk type, Required Field
                // SshKeys: SSH keys, Optional field
                var volume = new Volume
                {
                    Properties = new VolumeProperties
                    {
                        Size = 4,
                        Image = "fbaae2b2-c899-11e5-aa10-52540005ab80",
                        Type = "HDD",
                        Name = "dotNet Test " + DateTime.Now.ToShortTimeString(),
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

## Support

You can engage with us in the ProfitBricks [DevOps Central community](https://devops.profitbricks.com/community) and we'll be more than happy to answer any questions you might have about using this .NET library.

Please report any issues or bugs your encounter using the [GitHub Issue Tracker](https://github.com/profitbricks/profitbricks-sdk-net/issues).
