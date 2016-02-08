using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;



namespace  Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class VolumeProperties : IEquatable<VolumeProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeProperties" /> class.
        /// </summary>
        public VolumeProperties()
        {

        }


        /// <summary>
        /// A name of that resource
        /// </summary>
        /// <value>A name of that resource</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }


        /// <summary>
        /// Hardware type of the volume. Default is HDD
        /// </summary>
        /// <value>Hardware type of the volume. Default is HDD</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }


        /// <summary>
        /// The size of the volume in GB
        /// </summary>
        /// <value>The size of the volume in GB</value>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int? Size { get; set; }


        /// <summary>
        /// Image or snapshot ID to be used as template for this volume
        /// </summary>
        /// <value>Image or snapshot ID to be used as template for this volume</value>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public string Image { get; set; }


        /// <summary>
        /// Initial password to be set for installed OS. Works with Profitbricks public images only. Not modifiable, forbidden in update requests
        /// </summary>
        /// <value>Initial password to be set for installed OS. Works with Profitbricks public images only. Not modifiable, forbidden in update requests</value>
        [DataMember(Name = "imagePassword", EmitDefaultValue = false)]
        public string ImagePassword { get; set; }


        /// <summary>
        /// The bus type of the volume. Default is VIRTIO
        /// </summary>
        /// <value>The bus type of the volume. Default is VIRTIO</value>
        [DataMember(Name = "bus", EmitDefaultValue = false)]
        public string Bus { get; set; }


        /// <summary>
        /// OS type of this volume
        /// </summary>
        /// <value>OS type of this volume</value>
        [DataMember(Name = "licenceType", EmitDefaultValue = false)]
        public string LicenceType { get; set; }


        /// <summary>
        /// Is capable of CPU hot plug (no reboot required)
        /// </summary>
        /// <value>Is capable of CPU hot plug (no reboot required)</value>
        [DataMember(Name = "cpuHotPlug", EmitDefaultValue = false)]
        public bool? CpuHotPlug { get; set; }


        /// <summary>
        /// Is capable of CPU hot unplug (no reboot required)
        /// </summary>
        /// <value>Is capable of CPU hot unplug (no reboot required)</value>
        [DataMember(Name = "cpuHotUnplug", EmitDefaultValue = false)]
        public bool? CpuHotUnplug { get; set; }


        /// <summary>
        /// Is capable of memory hot plug (no reboot required)
        /// </summary>
        /// <value>Is capable of memory hot plug (no reboot required)</value>
        [DataMember(Name = "ramHotPlug", EmitDefaultValue = false)]
        public bool? RamHotPlug { get; set; }


        /// <summary>
        /// Is capable of memory hot unplug (no reboot required)
        /// </summary>
        /// <value>Is capable of memory hot unplug (no reboot required)</value>
        [DataMember(Name = "ramHotUnplug", EmitDefaultValue = false)]
        public bool? RamHotUnplug { get; set; }


        /// <summary>
        /// Is capable of nic hot plug (no reboot required)
        /// </summary>
        /// <value>Is capable of nic hot plug (no reboot required)</value>
        [DataMember(Name = "nicHotPlug", EmitDefaultValue = false)]
        public bool? NicHotPlug { get; set; }


        /// <summary>
        /// Is capable of nic hot unplug (no reboot required)
        /// </summary>
        /// <value>Is capable of nic hot unplug (no reboot required)</value>
        [DataMember(Name = "nicHotUnplug", EmitDefaultValue = false)]
        public bool? NicHotUnplug { get; set; }


        /// <summary>
        /// Is capable of Virt-IO drive hot plug (no reboot required)
        /// </summary>
        /// <value>Is capable of Virt-IO drive hot plug (no reboot required)</value>
        [DataMember(Name = "discVirtioHotPlug", EmitDefaultValue = false)]
        public bool? DiscVirtioHotPlug { get; set; }


        /// <summary>
        /// Is capable of Virt-IO drive hot unplug (no reboot required)
        /// </summary>
        /// <value>Is capable of Virt-IO drive hot unplug (no reboot required)</value>
        [DataMember(Name = "discVirtioHotUnplug", EmitDefaultValue = false)]
        public bool? DiscVirtioHotUnplug { get; set; }


        /// <summary>
        /// Is capable of SCSI drive hot plug (no reboot required)
        /// </summary>
        /// <value>Is capable of SCSI drive hot plug (no reboot required)</value>
        [DataMember(Name = "discScsiHotPlug", EmitDefaultValue = false)]
        public bool? DiscScsiHotPlug { get; set; }


        /// <summary>
        /// Is capable of SCSI drive hot unplug (no reboot required)
        /// </summary>
        /// <value>Is capable of SCSI drive hot unplug (no reboot required)</value>
        [DataMember(Name = "discScsiHotUnplug", EmitDefaultValue = false)]
        public bool? DiscScsiHotUnplug { get; set; }


        /// <summary>
        /// The LUN ID of the storage volume. Null for volumes not mounted to any VM
        /// </summary>
        /// <value>The LUN ID of the storage volume. Null for volumes not mounted to any VM</value>
        [DataMember(Name = "deviceNumber", EmitDefaultValue = false)]
        public long? DeviceNumber { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeProperties {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  ImagePassword: ").Append(ImagePassword).Append("\n");
            sb.Append("  Bus: ").Append(Bus).Append("\n");
            sb.Append("  LicenceType: ").Append(LicenceType).Append("\n");
            sb.Append("  CpuHotPlug: ").Append(CpuHotPlug).Append("\n");
            sb.Append("  CpuHotUnplug: ").Append(CpuHotUnplug).Append("\n");
            sb.Append("  RamHotPlug: ").Append(RamHotPlug).Append("\n");
            sb.Append("  RamHotUnplug: ").Append(RamHotUnplug).Append("\n");
            sb.Append("  NicHotPlug: ").Append(NicHotPlug).Append("\n");
            sb.Append("  NicHotUnplug: ").Append(NicHotUnplug).Append("\n");
            sb.Append("  DiscVirtioHotPlug: ").Append(DiscVirtioHotPlug).Append("\n");
            sb.Append("  DiscVirtioHotUnplug: ").Append(DiscVirtioHotUnplug).Append("\n");
            sb.Append("  DiscScsiHotPlug: ").Append(DiscScsiHotPlug).Append("\n");
            sb.Append("  DiscScsiHotUnplug: ").Append(DiscScsiHotUnplug).Append("\n");
            sb.Append("  DeviceNumber: ").Append(DeviceNumber).Append("\n");

            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as VolumeProperties);
        }

        /// <summary>
        /// Returns true if VolumeProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of VolumeProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) &&
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) &&
                (
                    this.ImagePassword == other.ImagePassword ||
                    this.ImagePassword != null &&
                    this.ImagePassword.Equals(other.ImagePassword)
                ) &&
                (
                    this.Bus == other.Bus ||
                    this.Bus != null &&
                    this.Bus.Equals(other.Bus)
                ) &&
                (
                    this.LicenceType == other.LicenceType ||
                    this.LicenceType != null &&
                    this.LicenceType.Equals(other.LicenceType)
                ) &&
                (
                    this.CpuHotPlug == other.CpuHotPlug ||
                    this.CpuHotPlug != null &&
                    this.CpuHotPlug.Equals(other.CpuHotPlug)
                ) &&
                (
                    this.CpuHotUnplug == other.CpuHotUnplug ||
                    this.CpuHotUnplug != null &&
                    this.CpuHotUnplug.Equals(other.CpuHotUnplug)
                ) &&
                (
                    this.RamHotPlug == other.RamHotPlug ||
                    this.RamHotPlug != null &&
                    this.RamHotPlug.Equals(other.RamHotPlug)
                ) &&
                (
                    this.RamHotUnplug == other.RamHotUnplug ||
                    this.RamHotUnplug != null &&
                    this.RamHotUnplug.Equals(other.RamHotUnplug)
                ) &&
                (
                    this.NicHotPlug == other.NicHotPlug ||
                    this.NicHotPlug != null &&
                    this.NicHotPlug.Equals(other.NicHotPlug)
                ) &&
                (
                    this.NicHotUnplug == other.NicHotUnplug ||
                    this.NicHotUnplug != null &&
                    this.NicHotUnplug.Equals(other.NicHotUnplug)
                ) &&
                (
                    this.DiscVirtioHotPlug == other.DiscVirtioHotPlug ||
                    this.DiscVirtioHotPlug != null &&
                    this.DiscVirtioHotPlug.Equals(other.DiscVirtioHotPlug)
                ) &&
                (
                    this.DiscVirtioHotUnplug == other.DiscVirtioHotUnplug ||
                    this.DiscVirtioHotUnplug != null &&
                    this.DiscVirtioHotUnplug.Equals(other.DiscVirtioHotUnplug)
                ) &&
                (
                    this.DiscScsiHotPlug == other.DiscScsiHotPlug ||
                    this.DiscScsiHotPlug != null &&
                    this.DiscScsiHotPlug.Equals(other.DiscScsiHotPlug)
                ) &&
                (
                    this.DiscScsiHotUnplug == other.DiscScsiHotUnplug ||
                    this.DiscScsiHotUnplug != null &&
                    this.DiscScsiHotUnplug.Equals(other.DiscScsiHotUnplug)
                ) &&
                (
                    this.DeviceNumber == other.DeviceNumber ||
                    this.DeviceNumber != null &&
                    this.DeviceNumber.Equals(other.DeviceNumber)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();

                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();

                if (this.ImagePassword != null)
                    hash = hash * 59 + this.ImagePassword.GetHashCode();

                if (this.Bus != null)
                    hash = hash * 59 + this.Bus.GetHashCode();

                if (this.LicenceType != null)
                    hash = hash * 59 + this.LicenceType.GetHashCode();

                if (this.CpuHotPlug != null)
                    hash = hash * 59 + this.CpuHotPlug.GetHashCode();

                if (this.CpuHotUnplug != null)
                    hash = hash * 59 + this.CpuHotUnplug.GetHashCode();

                if (this.RamHotPlug != null)
                    hash = hash * 59 + this.RamHotPlug.GetHashCode();

                if (this.RamHotUnplug != null)
                    hash = hash * 59 + this.RamHotUnplug.GetHashCode();

                if (this.NicHotPlug != null)
                    hash = hash * 59 + this.NicHotPlug.GetHashCode();

                if (this.NicHotUnplug != null)
                    hash = hash * 59 + this.NicHotUnplug.GetHashCode();

                if (this.DiscVirtioHotPlug != null)
                    hash = hash * 59 + this.DiscVirtioHotPlug.GetHashCode();

                if (this.DiscVirtioHotUnplug != null)
                    hash = hash * 59 + this.DiscVirtioHotUnplug.GetHashCode();

                if (this.DiscScsiHotPlug != null)
                    hash = hash * 59 + this.DiscScsiHotPlug.GetHashCode();

                if (this.DiscScsiHotUnplug != null)
                    hash = hash * 59 + this.DiscScsiHotUnplug.GetHashCode();

                if (this.DeviceNumber != null)
                    hash = hash * 59 + this.DeviceNumber.GetHashCode();

                return hash;
            }
        }

    }


}
