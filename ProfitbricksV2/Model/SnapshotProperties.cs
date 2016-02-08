using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace  Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class SnapshotProperties : IEquatable<SnapshotProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotProperties" /> class.
        /// </summary>
        public SnapshotProperties()
        {
            this.CpuHotPlug = false;
            this.CpuHotUnplug = false;
            this.RamHotPlug = false;
            this.RamHotUnplug = false;
            this.NicHotPlug = false;
            this.NicHotUnplug = false;
            this.DiscVirtioHotPlug = false;
            this.DiscVirtioHotUnplug = false;
            this.DiscScsiHotPlug = false;
            this.DiscScsiHotUnplug = false;

        }


        /// <summary>
        /// A name of that resource
        /// </summary>
        /// <value>A name of that resource</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }


        /// <summary>
        /// Human readable description
        /// </summary>
        /// <value>Human readable description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }


        /// <summary>
        /// Location of that image/snapshot.
        /// </summary>
        /// <value>Location of that image/snapshot.</value>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }


        /// <summary>
        /// The size of the image in GB
        /// </summary>
        /// <value>The size of the image in GB</value>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public double? Size { get; set; }


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
        /// OS type of this Snapshot
        /// </summary>
        /// <value>OS type of this Snapshot</value>
        [DataMember(Name = "licenceType", EmitDefaultValue = false)]
        public string LicenceType { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SnapshotProperties {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            sb.Append("  LicenceType: ").Append(LicenceType).Append("\n");

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
            return this.Equals(obj as SnapshotProperties);
        }

        /// <summary>
        /// Returns true if SnapshotProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of SnapshotProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotProperties other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) &&
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
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
                    this.LicenceType == other.LicenceType ||
                    this.LicenceType != null &&
                    this.LicenceType.Equals(other.LicenceType)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();

                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();

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

                if (this.LicenceType != null)
                    hash = hash * 59 + this.LicenceType.GetHashCode();

                return hash;
            }
        }

    }


}
