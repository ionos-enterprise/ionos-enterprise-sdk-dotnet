# .NET SDK

Version: profitbricks-sdk-net **3.0.4**

## Table of Contents

* [Description](#description)
* [Getting Started](#getting-started)
  * [Installation](#installation)
  * [Authenticating](#authenticating)
* [Reference](#reference)
  * [Data Centers](#data-centers)
    * [List Data Centers](#list-data-centers)
    * [Retrieve a Data Center](#retrieve-a-data-center)
    * [Create a Data Center](#create-a-data-center)
    * [Update a Data Center](#update-a-data-center)
    * [Delete a Data Center](#delete-a-data-center)
  * [Locations](#locations)
    * [List Locations](#list-locations)
    * [Get a Location](#get-a-location)
  * [Servers](#servers)
    * [List Servers](#list-servers)
    * [Retrieve a Server](#retrieve-a-server)
    * [Create a Server](#create-a-server)
    * [Update a Server](#update-a-server)
    * [Delete a Server](#delete-a-server)
    * [List Attached Volumes](#list-attached-volumes)
    * [Attach a Volume](#attach-a-volume)
    * [Retrieve an Attached Volume](#retrieve-an-attached-volume)
    * [Detach a Volume](#detach-a-volume)
    * [List Attached CD-ROMs](#list-attached-cd-roms)
    * [Attach a CD-ROM](#attach-a-cd-rom)
    * [Retrieve an Attached CD-ROM](#retrieve-an-attached-cd-rom)
    * [Detach a CD-ROM](#detach-a-cd-rom)
    * [Reboot a Server](#reboot-a-server)
    * [Start a Server](#start-a-server)
    * [Stop a Server](#stop-a-server)
  * [Images](#images)
    * [List Images](#list-images)
    * [Get an Image](#get-an-image)
    * [Update an Image](#update-an-image)
    * [Delete an Image](#delete-an-image)
  * [Volumes](#volumes)
    * [List Volumes](#list-volumes)
    * [Get a Volume](#get-a-volume)
    * [Create a Volume](#create-a-volume)
    * [Update a Volume](#update-a-volume)
    * [Delete a Volume](#delete-a-volume)
    * [Create a Volume Snapshot](#create-a-volume-snapshot)
    * [Restore a Volume Snapshot](#restore-a-volume-snapshot)
  * [Snapshots](#snapshots)
    * [List Snapshots](#list-snapshots)
    * [Get a Snapshot](#get-a-snapshot)
    * [Update a Snapshot](#update-a-snapshot)
    * [Delete a Snapshot](#delete-a-snapshot)
  * [IP Blocks](#ip-blocks)
    * [List IP Blocks](#list-ip-blocks)
    * [Get an IP Block](#get-an-ip-block)
    * [Create an IP Block](#create-an-ip-block)
    * [Delete an IP Block](#delete-an-ip-block)
  * [LANs](#lans)
    * [List LANs](#list-lans)
    * [Create a LAN](#create-a-lan)
    * [Get a LAN](#get-a-lan)
    * [Update a LAN](#update-a-lan)
    * [Delete a LAN](#delete-a-lan)
  * [Network Interfaces (NICs)](#network-interfaces)
    * [List NICs](#list-nics)
    * [Get a NIC](#get-a-nic)
    * [Create a NIC](#create-a-nic)
    * [Update a NIC](#update-a-nic)
    * [Delete a NIC](#delete-a-nic)
  * [Firewall Rules](#firewall-rules)
    * [List Firewall Rules](#list-firewall-rules)
    * [Get a Firewall Rule](#get-a-firewall-rule)
    * [Create a Firewall Rule](#create-a-firewall-rule)
    * [Update a Firewall Rule](#update-a-firewall-rule)
    * [Delete a Firewall Rule](#delete-a-firewall-rule)
  * [Load Balancers](#load-balancers)
    * [List Load Balancers](#list-load-balancers)
    * [Get a Load Balancer](#get-a-load-balancer)
    * [Create a Load Balancer](#create-a-load-balancer)
    * [Update a Load Balancer](#update-a-load-balancer)
    * [List Load Balanced NICs](#list-load-balanced-nics)
    * [Get a Load Balanced NIC](#get-a-load-balanced-nic)
    * [Associate NIC to a Load Balancer](#associate-nic-to-a-load-balancer)
    * [Remove a NIC Association](#remove-a-nic-association)
  * [Requests](#requests)
    * [List Requests](#list-requests)
    * [Get a Request](#get-a-request)
    * [Get a Request Status](#get-a-request-status)
* [Examples](#examples)
* [Support](#support)
* [Testing](#testing)
* [Contributing](#contributing)

## Description

This .NET library wraps the ProfitBricks Cloud API. All API operations are performed over a SSL/TLS secured connection and authenticated using your ProfitBricks portal credentials. The Cloud API can be accessed over the public Internet from any application that can send an HTTPS request and receive an HTTPS response.

This guide will show you how to programmatically perform common management tasks using the [.NET SDK](https://github.com/profitbricks/profitbricks-sdk-net) for the ProfitBricks Cloud API.

[.NET](http://www.microsoft.com/net) is a software framework developed by Microsoft that primarily runs on the Microsoft Windows operating system.

## Getting Started

Before you begin you will need to have [signed-up](https://www.profitbricks.com/signup) for a ProfitBricks account. The credentials you setup during sign-up will be used to authenticate against the Cloud API.

### Installation

The official .NET library is available from the [ProfitBricks GitHub account](https://github.com/profitbricks/profitbricks-sdk-net). You can download the latest stable version by cloning the repository and then adding the project to your solution.

Or you can add the SDK by using `nuget`:

	Install-Package ProfitBricksSDK

### Authenticating

Connecting to ProfitBricks is handled by first setting up your authentication credentials.

To setup your credentials you will have to provide an instance of the Configuration class provided with your username and password

    public static Configuration Configuration
        {
            get
            {
                return new Configuration
                {
                    Username = Environment.GetEnvironmentVariable("PROFITBRICKS_USERNAME"),
                    Password = Environment.GetEnvironmentVariable("PROFITBRICKS_PASSWORD"),

                };
            }
        }


You can choose to read them from the environment variables like in the example above, or just provide the strting value for *Username* and *Password*.

You can now use create an instance of any API class and pass the Configuration property for any future request.

	 LocationApi locApi = new LocationApi(Configuration);

## Reference

This section provides details on all the available operations and the parameters they accept. Brief code snippets demonstrating usage are also included.

### Data Centers

Virtual data centers (VDCs) are the foundation of the ProfitBricks platform. VDCs act as logical containers for all other objects you will be creating, e.g., servers. You can provision as many VDCs as you want. VDCs have their own private network and are logically segmented from each other to create isolation.

Create an instace of the api class:

         DataCenterApi dcApi = new DataCenterApi(Configuration);

#### List Data Centers

This operation will list all currently provisioned VDCs that your account credentials provide access to.

The optional `depth` parameter defines the level, one being the least and five being the most, of information returned with the response.

```
var list = dcApi.FindAll(depth: 5);
```

---

#### Retrieve a Data Center

Use this to retrieve details about a specific VDC.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |

```
var dc = dcApi.FindById(DatacenterId, depth: 5);
```

---

#### Create a Data Center

Use this operation to create a new VDC. You can create a "simple" VDC by supplying just the required *name* and *location* parameters. This operation also has the capability of provisioning a "complex" VDC by supplying additional parameters for servers, volumes, LANs, and/or load balancers.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| Name | **yes** | string | The name of the data center. |
| Location | **yes** | string | The physical ProfitBricks location where the VDC will be created. |
| Description | no | string | A description for the data center, e.g. staging, production. |
| Servers | no | collection | Details about creating one or more servers. See [create a server](#create-a-server). |
| Volumes | no | collection | Details about creating one or more volumes. See [create a volume](#create-a-volume). |
| Lans | no | collection | Details about creating one or more LANs. See [create a lan](#create-a-lan). |
| Loadbalancers | no | collection | Details about creating one or more load balancers. See [create a load balancer](#create-a-load- balancer). |

The following table outlines the locations currently supported:

| Value| Country | City |
|---|---|---|
| us/las | United States | Las Vegas |
| de/fra | Germany | Frankfurt |
| de/fkb | Germany | Karlsruhe |

**NOTES**:
- The value for `Name` cannot contain the following characters: (@, /, , |, ‘’, ‘).
- You cannot change the virtual data center `Location` once it has been provisioned.

```
var datacenter = new Datacenter
            {
                Properties = new DatacenterProperties
                {
                    Name = ".Net V2 - DC Test " + DateTime.Now.ToShortTimeString(),
                    Description = "Unit test for .Net SDK PB REST V2",
                    Location = "us/las"
                },
                Entities = new DatacenterEntities
                {
                    Servers = new Servers
                    {
                        Items = new List<Server>
                        {
                            new Server
                            {
                                Properties = new ServerProperties
                                {
                                    Name = "Test Server",
                                    Cores = 1,
                                    Ram = 1024
                                }
                            }
                        }
                    }
                }
            };

datacenter = dcApi.Create(datacenter);

```

---

#### Update a Data Center

After retrieving a data center, either by getting it by id, or as a create response object, you can change its properties by calling the `PartialUpdate` or the `Update` method. Some parameters may not be changed using either of the update methods.

The following table describes the available request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| Name | no | string | The new name of the VDC. |
| Description | no | string | The new description of the VDC. |

```
var resp = dcApi.PartialUpdate(DatacenterId, new DatacenterProperties { Name ="tes update"});
```

**NOTE**: You may also use `Update()` instead of `PartialUpdate()`. For an `Update()` operation you will need to supply values for **all** the parameters.

---

#### Delete a Data Center

This will remove all objects within the virtual data center AND remove the virtual data center object itself.

**NOTE**: This is a highly destructive operation which should be used with extreme caution!

The following table describes the available request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC that you want to delete. |

```
var resp = dcApi.Delete(DatacenterId);
```

---

### Locations

Locations are the physical ProfitBricks data centers where you can provision your VDCs.

Create an instace of the api class:

        LocationApi locApi = new LocationApi(Configuration);

#### List Locations

This operation will return the list of currently available locations.

There are no request parameters to supply.

```
var locations = locApi.FindAll();
```

---

#### Get a Location

Retrieves the attributes of a specific location.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| locationId | **yes** | string | The ID consisting of country/city. |

```
Location loc = locApi.FindById(locationId);
```

---

### Servers

Create an instace of these api classes:

```
ServerApi serverApi = new ServerApi(Configuration);
AttachedCDROMsApi attachCDROMApi = new AttachedCDROMsApi(Configuration);
AttachedVolumesApi attachedVolumesApi = new AttachedVolumesApi(Configuration);

```

#### List Servers

You can retrieve a list of all the servers provisioned inside a specific VDC.


The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |

```
var list = serverApi.FindAll(DatacenterId);
```

---

#### Retrieve a Server

Returns information about a specific server such as its configuration, provisioning status, etc.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |

```
var server = serverApi.FindById(DatacenterId, ServerId);
```

---

#### Create a Server

Creates a server within an existing VDC. You can configure additional properties such as specifying a boot volume and connecting the server to a LAN.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| Name | **yes** | string | The name of the server. |
| Cores | **yes** | int | The total number of cores for the server. |
| Ram | **yes** | int | The amount of memory for the server in MB, e.g. 2048. Size must be specified in multiples of 256 MB with a minimum of 256 MB; however, if you set `ram_hot_plug` to *True* then you must use a minimum of 1024 MB. |
| AvailabilityZone | no | string | The availability zone in which the server should exist. |
| CpuFamily | no | string | Sets the CPU type. "AMD_OPTERON" or "INTEL_XEON". Defaults to "AMD_OPTERON". |
| BootVolume | no | object | Reference to a volume used for booting. If not *null* then `BootCdrom` has to be *null*. |
| BootCdrom | no | object | Reference to a CD-ROM used for booting. If not *null* then `BootVolume` has to be *null*. |
| Volumes | no | object | A collection of volume objects that you want to create and attach to the server.|
| Nics | no | object | A collection of NICs you wish to create at the time the server is provisioned. |

The following table outlines the server availability zones currently supported:

| Availability Zone | Comment |
|---|---|
| AUTO | Automatically Selected Zone |
| ZONE_1 | Fire Zone 1 |
| ZONE_2 | Fire Zone 2 |

```
var server = new Server
            {
                Properties = new ServerProperties
                {
                    Name = "Test Server",
                    Cores = 1,
                    Ram = 1024,
                }
            };
serverApi.Create(DatacenterId, server);
```

---

#### Update a Server

Perform updates to the attributes of a server.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |
| Name | no | string | The name of the server. |
| Cores | no | int | The number of cores for the server. |
| Ram | no | int | The amount of memory in the server. |
| AvailabilityZone | no | string | The new availability zone for the server. |
| CpuFamily | no | string | Sets the CPU type. "AMD_OPTERON" or "INTEL_XEON". Defaults to "AMD_OPTERON". |
| BootVolume | no | object | Reference to a volume used for booting. If not *null* then `BootCdrom` has to be *null* |
| BootCdrom | no | object | Reference to a CD-ROM used for booting. If not *null* then `BootVolume` has to be *null*. |

After retrieving a server, either by getting it by id, or as a create response object, you can change its properties and call the `PartialUpdate` method:

```
var updated = serverApi.PartialUpdate(DatacenterId, ServerId, new ServerProperties { Name ="Updated" });
```

**NOTE**: You can also use `Update()`, for that operation you will update all the properties.

---

#### Delete a Server

This will remove a server from a data center. **NOTE**: This will not automatically remove the storage volume(s) attached to a server. A separate operation is required to delete a storage volume.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |

After retrieving a server, either by getting it by id, or as a create response object, you can call the `Delete` method directly:

```
var response = serverApi.Delete(DatacenterId, ServerId);
```

---

#### List Attached Volumes

Retrieves a list of volumes attached to the server.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |

After retrieving a server, either by getting it by id, or as a create response object, you can call the `FindAll` method directly:

```
var all = attachedVolumesApi.FindAll(DatacenterId, ServerId);
```

---

#### Attach a Volume

This will attach a pre-existing storage volume to the server.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |
| volumeId | **yes** | string | The ID of a storage volume. |

After retrieving a server, either by getting it by id, or as a create response object, you can call the `AttachVolume` method directly.

```
var resp = attachedVolumesApi.AttachVolume(DatacenterId, ServerId, new Volume { Id = volumeId });
```

---

#### Retrieve an Attached Volume

This will retrieve the properties of an attached volume.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |
| volumeId | **yes** | string | The ID of the attached volume. |

After retrieving a server, either by getting it by id, or as a create response object, you can call the `FindById` method directly.

```
var attachedVol = attachedVolumesApi.FindById(DatacenterId, ServerId, volumeId);
```

---

#### Detach a Volume

This will detach the volume from the server. Depending on the volume `hot_unplug` settings, this may result in the server being rebooted.

This will NOT delete the volume from your virtual data center. You will need to make a separate request to delete a volume.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |
| volumeId | **yes** | string | The ID of the attached volume. |

After retrieving a server, either by getting it by id, or as a create response object, you can call the `DetachVolume` method directly.

```
var resp = attachedVolumesApi.DetachVolume(DatacenterId,ServerId, volumeId);
```

---

#### List Attached CD-ROMs

Retrieves a list of CD-ROMs attached to a server.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |

After retrieving a server, either by getting it by id, or as a create response object, you can call the `FindAll` method directly.

```
 var listAttached = attachCDROMApi.FindAll(DatacenterId, ServerId);
```

---

#### Attach a CD-ROM

You can attach a CD-ROM to an existing server.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |
| cdROMImageId | **yes** | string | The ID of a CD-ROM. |

After retrieving a server, either by getting it by id, or as a create response object, you can call the `Attach` method directly.

```
var attached = attachCDROMApi.Attach(DatacenterId, ServerId, new Image { Id=cdROMImageId});
```

---

#### Retrieve an Attached CD-ROM

You can retrieve a specific CD-ROM attached to the server.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |
| cdROMImageId | **yes** | string | The ID of the attached CD-ROM. |

After retrieving a server, either by getting it by id, or as a create response object, you can call the `FindById` method directly.

```
var getAttached = attachCDROMApi.FindById(DatacenterId, ServerId, cdROMImageId);
```

---

#### Detach a CD-ROM

This will detach a CD-ROM from the server.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |
| cdROMImageId | **yes** | string | The ID of the attached CD-ROM. |

After retrieving a server, either by getting it by id, or as a create response object, you can call the `Detach` method directly.

```
var removed = attachCDROMApi.Detach(DatacenterId, ServerId, cdROMImageId);
```

---

#### Reboot a Server

This will force a hard reboot of the server. Do not use this method if you want to gracefully reboot the machine. This is the equivalent of powering off the machine and turning it back on.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |

After retrieving a server, either by getting it by id, or as a create response object, you can call the `Reboot` method directly.

```
var resp = serverApi.Reboot(DatacenterId, ServerId);
```

---

#### Start a Server

This will start a server. If the server's public IP was deallocated then a new IP will be assigned.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |

After retrieving a server, either by getting it by id, or as a create response object, you can call the `Start` method directly.

```
var start = serverApi.Start(DatacenterId, ServerId);
```

---

#### Stop a Server

This will stop a server. The machine will be forcefully powered off, billing will cease, and the public IP, if one is allocated, will be deallocated.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |

After retrieving a server, either by getting it by id, or as a create response object, you can call the `Stop` method directly.

```
var error = serverApi.Stop(DatacenterId, ServerId);
```

---

### Images

Create an instace of the api class:

         ImageApi imageApi = new ImageApi(Configuration);

#### List Images

Retrieve a list of images.

```
var list = imageApi.FindAll();
```

---

#### Get an Image

Retrieves the attributes of a specific image.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| imageId | **yes** | string | The ID of the image. |

```
var img = imageApi.FindById(imageId);
```

---

### Volumes

Create an instace of the api class:

         AttachedVolumesApi attachedVolumesApi = new AttachedVolumesApi(Configuration);

#### List Volumes

Retrieve a list of volumes within the virtual data center. If you want to retrieve a list of volumes attached to a server please see the [List Attached Volumes](#list-attached-volumes) entry in the Server section for details.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |

```
var list = volumeApi.FindAll(DatacenterId);
```

---

#### Get a Volume

Retrieves the attributes of a given volume.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| volumeId | **yes** | string | The ID of the volume. |

```
var volume = volumeApi.FindById(DatacenterId, volumeId);
```

---

#### Create a Volume

Creates a volume within the virtual data center. This will NOT attach the volume to a server. Please see the [Attach a Volume](#attach-a-volume) entry in the Server section for details on how to attach storage volumes.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| Name | no | string | The name of the volume. |
| Size | **yes** | int | The size of the volume in GB. |
| Bus | no | string | The bus type of the volume (VIRTIO or IDE). Default: VIRTIO. |
| Image | **yes** | string | The image or snapshot ID. |
| Type | **yes** | string | The volume type, HDD or SSD. |
| LicenceType | **yes** | string | The licence type of the volume. Options: LINUX, WINDOWS, WINDOWS2016, UNKNOWN, OTHER |
| ImagePassword | **yes** | string | One-time password is set on the Image for the appropriate root or administrative account. This field may only be set in creation requests. When reading, it always returns *null*. The password has to contain 8-50 characters. Only these characters are allowed: [abcdefghjkmnpqrstuvxABCDEFGHJKLMNPQRSTUVX23456789] |
| SshKeys | **yes** | string | SSH keys to allow access to the volume via SSH. |
| AvailabilityZone | no | string | The storage availability zone assigned to the volume. Valid values: AUTO, ZONE_1, ZONE_2, or ZONE_3. This only applies to HDD volumes. Leave blank or set to AUTO when provisioning SSD volumes. |

The following table outlines the various licence types you can define:

| Licence Type | Comment |
|---|---|
| WINDOWS2016 | Use this for the Microsoft Windows Server 2016 operating system. |
| WINDOWS | Use this for the Microsoft Windows Server 2008 and 2012 operating systems. |
| LINUX |Use this for Linux distributions such as CentOS, Ubuntu, Debian, etc. |
| OTHER | Use this for any volumes that do not match one of the other licence types. |
| UNKNOWN | This value may be inherited when you've uploaded an image and haven't set the license type. Use one of the options above instead. |

The following table outlines the storage availability zones currently supported:

| Availability Zone | Comment |
|---|---|
| AUTO | Automatically Selected Zone |
| ZONE_1 | Fire Zone 1 |
| ZONE_2 | Fire Zone 2 |
| ZONE_3 | Fire Zone 3 |

* You will need to provide either the `Image` or the `LicenceType` parameters. `LicenceType` is required, but if `Image` is supplied, it is already set and cannot be changed. Similarly either the `ImagePassword` or `SshKeys` parameters need to be supplied when creating a volume. We recommend setting a valid value for `image_password` even when using `SshKeys` so that it is possible to authenticate using the remote console feature of the DCD.

```
var volume = new Volume
            {
                Properties = new VolumeProperties
                {
                    Size = 4,
                    LicenceType = "UNKNOWN",
                    Type = "HDD",
                    Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString(),
                    AvailabilityZone = "ZONE_3"
                }
            };
            volume = volumeApi.Create(DatacenterId, volume, depth: 5);
```

---

#### Update a Volume

You can update -- in full or partially -- various attributes on the volume; however, some restrictions are in place:

You can increase the size of an existing storage volume. You cannot reduce the size of an existing storage volume. The volume size will be increased without requiring a reboot if the relevant hot plug settings have been set to *true*. The additional capacity is not added automatically added to any partition, therefore you will need to handle that inside the OS afterwards. Once you have increased the volume size you cannot decrease the volume size.

Since an existing volume is being modified, none of the request parameters are specifically required as long as the changes being made satisfy the requirements for creating a volume.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| volumeId | **yes** | string | The ID of the volume. |
| Name | no | string | The name of the volume. |
| Size | no | int | The size of the volume in GB. Only increase when updating. |
| Bus | no | string | The bus type of the volume (VIRTIO or IDE). Default: VIRTIO. |
| Image | no | string | The image or snapshot ID. |
| Type | no | string | The volume type, HDD or SSD. |
| LicenceType | no | string | The licence type of the volume. Options: LINUX, WINDOWS, WINDOWS2016, UNKNOWN, OTHER |
| AvailabilityZone | no | string | The storage availability zone assigned to the volume. Valid values: AUTO, ZONE_1, ZONE_2, or ZONE_3. This only applies to HDD volumes. Leave blank or set to AUTO when provisioning SSD volumes. |

After retrieving a volume, either by getting it by id, or as a create response object, you can change its properties and call the `PartialUpdate` method:

```
var newVolume = volumeApi.PartialUpdate(DatacenterId, volumeId, new VolumeProperties { Size = volume.Properties.Size + 1 });
```

**NOTE**: You can also use `Update()`, for that operation you will update all the properties.

---

#### Delete a Volume

Deletes the specified volume. This will result in the volume being removed from your data center. Use this with caution.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| volumeId | **yes** | string | The ID of the volume. |

After retrieving a volume, either by getting it by id, or as a create response object, you can call the `Delete` method directly.

```
 var response = volumeApi.Delete(DatacenterId, volumeId);
```

---

#### Create a Volume Snapshot

Creates a snapshot of a volume within the virtual data center. You can use a snapshot to create a new storage volume or to restore a storage volume.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| volumeId | **yes** | string | The ID of the volume. |
| Name | no | string | The name of the snapshot. |
| Description | no | string | The description of the snapshot. |

After retrieving a volume, either by getting it by id, or as a create response object, you can call the `CreateSnapshot` method directly.

```
var resp = volumeApi.CreateSnapshot(DatacenterId, volumeId, Name, Description);
```

---

#### Restore a Volume Snapshot

This will restore a snapshot onto a volume. A snapshot is created as just another image that can be used to create new volumes or to restore an existing volume.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| snapshotId | **yes** | string |  The ID of the snapshot. |

After retrieving a volume, either by getting it by id, or as a create response object, you can call the `RestoreSnapshot` method directly.

```
var resp = volumeApi.RestoreSnapshot(DatacenterId, snapshotId);
```

---

### Snapshots

Create an instace of the api class:

         SnapshotApi snapshotApi = new SnapshotApi(Configuration);

#### List Snapshots

You can retrieve a list of all available snapshots.

There are no request parameters to supply.

```
var list = snapshotApi.FindAll(depth: 5);
```

---

#### Get a Snapshot

Retrieves the attributes of a specific snapshot.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| snapshotId | **yes** | string | The ID of the snapshot. |

```
var snapshot = snapshotApi.FindById(snapshotId);
```

---

#### Update a Snapshot

Perform updates to attributes of a snapshot.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| snapshotId | **yes** | string | The ID of the snapshot. |
| Name | no | string | The name of the snapshot. |
| Description | no | string | The description of the snapshot. |
| LicenceType | no | string | The snapshot's licence type: LINUX, WINDOWS, WINDOWS2016, or OTHER. |
| CpuHotPlug | no | bool | This volume is capable of CPU hot plug (no reboot required) |
| CpuHotUnplug | no | bool | This volume is capable of CPU hot unplug (no reboot required) |
| RamHotPlug | no | bool |  This volume is capable of memory hot plug (no reboot required) |
| RamHotUnplug | no | bool | This volume is capable of memory hot unplug (no reboot required) |
| NicHotPlug | no | bool | This volume is capable of NIC hot plug (no reboot required) |
| NicHotUnplug | no | bool | This volume is capable of NIC hot unplug (no reboot required) |
| DiscVirtioHotPlug | no | bool | This volume is capable of VirtIO drive hot plug (no reboot required) |
| DiscVirtioHotUnplug | no | bool | This volume is capable of VirtIO drive hot unplug (no reboot required) |
| DiscScsiHotPlug | no | bool | This volume is capable of SCSI drive hot plug (no reboot required) |
| DiscScsiHotUnplug | no | bool | This volume is capable of SCSI drive hot unplug (no reboot required) |

After retrieving a snapshot, either by getting it by id, or as a create response object, you can change its properties and call the `PartialUpdate` method:

```
var updated = snapshotApi.PartialUpdate(snapshotId, new SnapshotProperties { Name ="Updated" });
```

**NOTE**: You can also use `Update()`, for that operation you will update all the properties.

---

#### Delete a Snapshot

Deletes the specified snapshot.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| snapshotId | **yes** | string | The ID of the snapshot. |

After retrieving a snapshot, either by getting it by id, or as a create response object, you can call the `Delete` method directly.

```
var resp = snapshotApi.Delete(snapshotId);
```

---

### IP Blocks

The IP block operations assist with managing reserved /static public IP addresses.

Create an instace of the api class:

         IPBlocksApi ipApi = new IPBlocksApi(Configuration);

#### List IP Blocks

Retrieve a list of available IP blocks.

```
var list = ipApi.FindAll();
```

#### Get an IP Block

Retrieves the attributes of a specific IP block.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| ipBlockId | **yes** | string | The ID of the IP block. |

```
var ip = ipApi.FindById(ipBlockId);
```

---

#### Create an IP Block

Creates an IP block. IP blocks are attached to a location, so you must specify a valid `location` along with a `size` parameter indicating the number of IP addresses you want to reserve in the IP block. Servers or other resources using an IP address from an IP block must be in the same `location`.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| Location | **yes** | string | This must be one of the locations: us/las, de/fra, de/fkb. |
| Size | **yes** | int | The size of the IP block you want. |
| Name | no | string | A descriptive name for the IP block |

The following table outlines the locations currently supported:

| Value| Country | City |
|---|---|---|
| us/las | United States | Las Vegas |
| de/fra | Germany | Frankfurt |
| de/fkb | Germany | Karlsruhe |

To create an IP block, establish the parameters and then call `reserve_ipblock`.

```
var ipBlock = new IpBlock { Properties = new IpBlockProperties { Location = "us/las", Size = 1 } };
ipBlock = ipApi.Create(ipBlock);
```

---

#### Delete an IP Block

Deletes the specified IP Block.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| ipblockId | **yes** | string | The ID of the IP block. |

After retrieving an IP block, either by getting it by id, or as a create response object, you can call the `Delete` method directly.

```
var resp = ipApi.Delete(ipBlockId);
```

---

### LANs

#### List LANs

Retrieve a list of LANs within the virtual data center.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |

```
var list = lanApi.FindAll(DatacenterId);
```

---

#### Create a LAN

Creates a LAN within a virtual data center.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| Name | no | string | The name of your LAN. |
| Public | **Yes** | bool | Boolean indicating if the LAN faces the public Internet or not. |
| Nics | no | object | A collection of NICs associated with the LAN. |

```
var lan = lanApi.Create(DatacenterId, new Lan
            {
                Properties = new LanProperties
                {
                    Public = true,
                    Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString()
                },
                Entities=new LanEntities{
                    Nics= new LanNics
                    {
                        Items= new List<Nic>()
                        {
                            new Nic
                            {
                                Id=nic.Id
                            }
                        }

                    }

                }
            });
```

---

#### Get a LAN

Retrieves the attributes of a given LAN.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| lanId | **yes** | int | The ID of the LAN. |

```
var lan = lanApi.FindById(DatacenterId, lanId);
```

---

#### Update a LAN

Perform updates to attributes of a LAN.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| lanId | **yes** | int | The ID of the LAN. |
| Name | no | string | A descriptive name for the LAN. |
| Public | no | bool | Boolean indicating if the LAN faces the public Internet or not. |

After retrieving a LAN, either by getting it by id, or as a create response object, you can change its properties and call the `PartialUpdate` method:

```
var updated = lanApi.PartialUpdate(DatacenterId, lanId, new LanProperties { Public = True });
```

**NOTE**: You can also use `Update()`, for that operation you will update all the properties.

---

#### Delete a LAN

Deletes the specified LAN.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| lanId | **yes** | string | The ID of the LAN. |

After retrieving a LAN, either by getting it by id, or as a create response object, you can call the `Delete` method directly.

```
lanApi.Delete(DatacenterId,lanId);
```

---

### Network Interfaces

Create an instance of the api class:

         NetworkInterfacesApi nicApi = new NetworkInterfacesApi(Configuration);

#### List NICs

Retrieve a list of LANs within the virtual data center.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |

```
 var list = nicApi.FindAll(DatacenterId, ServerId);
```

---

#### Get a NIC

Retrieves the attributes of a given NIC.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |
| nicId | **yes** | string | The ID of the NIC. |

```
var nic = nicApi.FindById(DatacenterId, ServerId, nicId);
```

---

#### Create a NIC

Adds a NIC to the target server.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string| The ID of the server. |
| Name | no | string | The name of the NIC. |
| Ips | no | string collection | IPs assigned to the NIC. This can be a collection. |
| Dhcp | no | bool | Set to FALSE if you wish to disable DHCP on the NIC. Default: TRUE. |
| Lan | **yes** | int | The LAN ID the NIC will sit on. If the LAN ID does not exist it will be created. |
| Nat | no | bool | Indicates the private IP address has outbound access to the public internet. |
| FirewallActive | no | bool | Once you add a firewall rule this will reflect a true value. |
| Firewallrules | no | object| A list of firewall rules associated to the NIC represented as a collection. |

```
var nic = new Nic { Properties = new NicProperties { Lan = 1, Nat = false } };

nic = nicApi.Create(DatacenterId, ServerId, nic);
```

---

#### Update a NIC

You can update -- in full or partially -- various attributes on the NIC; however, some restrictions are in place:

The primary address of a NIC connected to a load balancer can only be changed by changing the IP of the load balancer. You can also add additional reserved, public IPs to the NIC.

The user can specify and assign private IPs manually. Valid IP addresses for private networks are 10.0.0.0/8, 172.16.0.0/12 or 192.168.0.0/16.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string| The ID of the server. |
| nicId | **yes** | string| The ID of the NIC. |
| Name | no | string | The name of the NIC. |
| Ips | no | string collection | IPs assigned to the NIC represented as a collection. |
| Dhcp | no | bool | Boolean value that indicates if the NIC is using DHCP or not. |
| Lan | no | int | The LAN ID the NIC sits on. |
| Nat | no | bool | Indicates the private IP address has outbound access to the public internet. |

After retrieving a NIC, either by getting it by id, or as a create response object, you can call the `PartialUpdate` method directly.

```
var updated = nicApi.PartialUpdate(DatacenterId, ServerId, nicId, new NicProperties { Name ="Update", Ips = new System.Collections.Generic.List<string> { "10.8.52.225", "1.1.1.1" } });
```

**NOTE**: You can also use `Update()`, for that operation you will update all the properties.

---

#### Delete a NIC

Deletes the specified NIC.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string| The ID of the server. |
| nicId | **yes** | string| The ID of the NIC. |

After retrieving a NIC, either by getting it by id, or as a create response object, you can call the `Delete` method directly.

```
var resp = nicApi.Delete(DatacenterId, ServerId, nicId);
```

---

### Firewall Rules

Create an instace of the api class:

         FirewallRuleApi fwApi = new FirewallRuleApi(Configuration);

#### List Firewall Rules

Retrieves a list of firewall rules associated with a particular NIC.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |
| nicId | **yes** | string | The ID of the NIC. |

```
var list = fwApi.FindAll(DatacenterId, ServerId, nicId);
```

---

#### Get a Firewall Rule

Retrieves the attributes of a given firewall rule.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |
| nicId | **yes** | string | The ID of the NIC. |
| fwId | **yes** | string | The ID of the firewall rule. |

```
var newFw = fwApi.FindById(DatacenterId, ServerId, nicId, fwId);
```

---

#### Create a Firewall Rule

This will add a firewall rule to the NIC.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |
| nicId | **yes** | string | The ID of the NIC. |
| Name | no | string | The name of the firewall rule. |
| Protocol | **yes** | string | The protocol for the rule: TCP, UDP, ICMP, ANY. |
| SourceMac | no | string | Only traffic originating from the respective MAC address is allowed. Valid format: aa:bb:cc:dd:ee:ff. A *null* value allows all source MAC address. |
| SourceIp | no | string | Only traffic originating from the respective IPv4 address is allowed. A *null* value allows all source IPs. |
| TargetIp | no | string | In case the target NIC has multiple IP addresses, only traffic directed to the respective IP address of the NIC is allowed. A *null* value allows all target IPs. |
| PortRangeStart | no | string | Defines the start range of the allowed port (from 1 to 65534) if protocol TCP or UDP is chosen. Leave `PortRangeStart` and `PortRangeEnd` value as *null* to allow all ports. |
| PortRangeEnd | no | string | Defines the end range of the allowed port (from 1 to 65534) if the protocol TCP or UDP is chosen. Leave `PortRangeStart` and `PortRangeEnd` value as *null* to allow all ports. |
| IcmpType | no | string | Defines the allowed type (from 0 to 254) if the protocol ICMP is chosen. A *null* value allows all types. |
| IcmpCode | no | string | Defines the allowed code (from 0 to 254) if protocol ICMP is chosen. A *null* value allows all codes. |

```
var fw = new FirewallRule { Properties = new FirewallruleProperties { Protocol = "TCP", Name = ".Net" } };

fw = fwApi.Create(DatacenterId, ServerId, nicId, fw);
```

---

#### Update a Firewall Rule

Perform updates to attributes of a firewall rule.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |
| nicId | **yes** | string | The ID of the NIC. |
| fwId | **yes** | string | The ID of the firewall rule. |
| Name | no | string | The name of the firewall rule. |
| SourceMac | no | string | Only traffic originating from the respective MAC address is allowed. Valid format: aa:bb:cc:dd:ee:ff. A *null* value allows all source MAC address. |
| SourceIp | no | string | Only traffic originating from the respective IPv4 address is allowed. A *null* value allows all source IPs. |
| TargetIp | no | string | In case the target NIC has multiple IP addresses, only traffic directed to the respective IP address of the NIC is allowed. A *null* value allows all target IPs. |
| PortRangeStart | no | string | Defines the start range of the allowed port (from 1 to 65534) if protocol TCP or UDP is chosen. Leave `port_range_start` and `port_range_end` value as *null* to allow all ports. |
| PortRangeEnd | no | string | Defines the end range of the allowed port (from 1 to 65534) if the protocol TCP or UDP is chosen. Leave `port_range_start` and `port_range_end` value as *null* to allow all ports. |
| IcmpType | no | string | Defines the allowed type (from 0 to 254) if the protocol ICMP is chosen. A *null* value allows all types. |
| IcmpCode | no | string | Defines the allowed code (from 0 to 254) if protocol ICMP is chosen. A *null* value allows all codes. |

After retrieving a firewall rule, either by getting it by id, or as a create response object, you can change its properties and call the `PartialUpdate` method:

```
var updated = fwApi.PartialUpdate(DatacenterId, ServerId, nicId, fwId, new FirewallruleProperties {Name = "Updated" });
```

**NOTE**: You can also use `Update()`, for that operation you will update all the properties.

---

#### Delete a Firewall Rule

Removes the specific firewall rule.

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| ServerId | **yes** | string | The ID of the server. |
| nicId | **yes** | string | The ID of the NIC. |
| fwId | **yes** | string | The ID of the firewall rule. |

After retrieving a firewall rule, either by getting it by id, or as a create response object, you can call the `Delete` method directly.

```
var resp = fwApi.Delete(DatacenterId, ServerId, nicId, fwId);
```

---



### Load Balancers

Create an instace of the api class:

         LoadBalancerApi lbApi = new LoadBalancerApi(Configuration)

#### List Load Balancers

Retrieve a list of load balancers within the data center.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |

```
var list = lbApi.FindAll(DatacenterId);
```

---

#### Get a Load Balancer

Retrieves the attributes of a given load balancer.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| loadbalancerId | **yes** | string | The ID of the load balancer. |

```
var lb = lbApi.FindById(DatacenterId, loadbalancerId);
```

---

#### Create a Load Balancer

Creates a load balancer within the virtual data center. Load balancers can be used for public or private IP traffic.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| Name | **yes** | string | The name of the load balancer. |
| Ip | no | string | IPv4 address of the load balancer. All attached NICs will inherit this IP. |
| Dhcp | no | bool | Indicates if the load balancer will reserve an IP using DHCP. |
| Balancednics | no | string collection | List of NICs taking part in load-balancing. All balanced NICs inherit the IP of the load balancer. |

```
var lb = new Loadbalancer
                {
                    Properties = new LoadbalancerProperties
                    {
                        Name = ".Net V2 - Test " + DateTime.Now.ToShortTimeString()
                    }
                };

lb = lbApi.Create(DatacenterId, lb, depth: 5);
```

---

#### Update a Load Balancer

Perform updates to attributes of a load balancer.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| loadbalancerId | **yes** | string | The ID of the load balancer. |
| Name | no | string | The name of the load balancer. |
| Ip | no | string | The IP of the load balancer. |
| Dhcp | no | bool | Indicates if the load balancer will reserve an IP using DHCP. |

After retrieving a load balancer, either by getting it by id, or as a create response object, you can change it's properties and call the `PartialUpdate` method:

```
var newLb = lbApi.PartialUpdate(DatacenterId, loadbalancerId, new LoadbalancerProperties { Name = "Updated" });
```

**NOTE**: You can also use `Update()`, for that operation you will update all the properties.

---

#### Delete a Load Balancer

Deletes the specified load balancer.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| loadbalancerId | **yes** | string | The ID of the load balancer. |

After retrieving a load balancer, either by getting it by id, or as a create response object, you can call the `Delete` method directly.

```
var resp = lbApi.Delete(DatacenterId, loadbalancerId);
```

---

#### List Load Balanced NICs

This will retrieve a list of NICs associated with the load balancer.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| loadbalancerId | **yes** | string | The ID of the load balancer. |
| depth | no | int | The level of details returned. |

After retrieving a load balancer, either by getting it by id, or as a create response object, you can call the `FindAll` method directly.

```
 var balancedNics = lbApi.FindAll(DatacenterId, loadbalancerId, depth);
```

---

#### Get a Load Balanced NIC

Retrieves the attributes of a given load balanced NIC.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| loadbalancerId | **yes** | string | The ID of the load balancer. |
| nicId | **yes** | string | The ID of the NIC. |
| depth | no | int | The level of details returned. |

After retrieving a load balancer, either by getting it by id, or as a create response object, you can call the `get_loadbalanced_nic` method directly.

```
var balancedNic = lbApi.FindById(DatacenterId, loadbalancerId, nicId, depth);
```

---

#### Associate NIC to a Load Balancer

This will associate a NIC to a load balancer, enabling the NIC to participate in load-balancing.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| loadbalancerId | **yes** | string | The ID of the load balancer. |
| nicId | **yes** | string | The ID of the NIC. |

After retrieving a load balancer, either by getting it by id, or as a create response object, you can call the `AttachNic` method directly.

```
NetworkInterfacesApi nicApi = new NetworkInterfacesApi(Configuration);
var attachedNic = nicApi.AttachNic(DatacenterId, loadbalancerId, new Nic { Id = nicId });
```

---

#### Remove a NIC Association

Removes the association of a NIC with a load balancer.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| DatacenterId | **yes** | string | The ID of the VDC. |
| loadbalancerId | **yes** | string | The ID of the load balancer. |
| nicId | **yes** | string | The ID of the NIC. |

After retrieving a load balancer, either by getting it by id, or as a create response object, you can call the `DetachNic` method directly.

```
var resp = nicApi.DetachNic(DatacenterId, loadbalancerId, nicId);
```

---

### Requests

Each call to the ProfitBricks Cloud API is assigned a request ID. These operations can be used to get information about the requests that have been submitted and their current status.

Create an instace of the api class:

         RequestApi reqApi = new RequestApi(Configuration);

#### List Requests

Retrieve a list of requests.

```
var requests = reqApi.List();
```

---

#### Get a Request

Retrieves the attributes of a specific request.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| requestId | **yes** | string | The ID of the request. |

```
var req = reqApi.Get(requestId);
```

---

#### Get a Request Status

Retrieves the status of a request.

The following table describes the request arguments:

| Name| Required | Type | Description |
|---|:-:|---|---|
| requestId | **yes** | string | The ID of the request. |

```
RequestStatus req = reqApi.GetStatus(requestId);
```

---

## Examples

Here are a few examples on how to use the module.

The next few sections describe some commonly used features of this .NET library and provide implementation examples.

### Create Virtual Data Center

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

### Delete Virtual Data Center

You will want to exercise a bit of caution here. Removing a virtual data center will **destroy** all objects contained within that virtual data center -- servers, volumes, snapshots, and so on. The objects -- once removed -- will **NOT be recoverable**.

The following is an example of how to remove the virtual data center created above:

    dcApi.Delete(datacenter.Id);

### Create Server

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

### Update Cores, Memory, and Disk

ProfitBricks allows users to dynamically update the values assigned to cores, memory, and disk independently of each other. This removes the restriction of needing to upgrade to the next server or instance size just to get access to more memory. This helps manage costs as provisioned resources can be configured to match your actual resource needs.

The following code illustrates how you can update cores and memory:

    server = serverApi.PartialUpdate(datacenter.Id, server.Id, new ServerProperties { Name = server.Properties.Name + " -Updated" });

### Detach and Reattach a Storage Volume

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

### List Servers, Volumes, and Virtual Data Centers

You can pull various resource lists from your virtual data centers using the .NET library. The three most commonly queried resources are virtual data centers, servers, and volumes.

The following code illustrates how to pull these three list types:

    var dcs = dcApi.FindAll(depth: 5);
    var servers = serverApi.FindAll(datacenter.Id, depth: 5);
    var volumes = volumeApi.FindAll(datacenter.Id, depth: 5);

### Create Additional Network Interfaces

The ProfitBricks cloud platform supports adding multiple NICs to a server. These NICs can be used to create different, segmented networks on the platform.

The sample below shows you how to add a second NIC to an existing server:

    var nic = new Nic { Properties = new NicProperties { Lan = 1 , Dhcp = true, Name = "Nic name"} };

    nic = nicApi.Create(datacenter.Id, server.Id, nic);

**Please Note:** Using this function will result in a running server being rebooted.

### Example

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
                // DatacenterId: Defines the virtual data center wherein the server is to be created.
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
                // DatacenterId: Defines the virtual data center wherein the storage is to be created. If left empty, the storage will be created in a new virtual data center
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

## Testing

You can find a full list of tests inside the `ProfitbricksV2.Tests` project.You can run tests from the Visual Studio Test Explorer.

## Contributing

1. Fork it ( https://github.com/profitbricks/profitbricks-sdk-net/fork )
2. Create your feature branch (`git checkout -b my-new-feature`)
3. Commit your changes (`git commit -am 'Add some feature'`)
4. Push to the branch (`git push origin my-new-feature`)
5. Create a new Pull Request
