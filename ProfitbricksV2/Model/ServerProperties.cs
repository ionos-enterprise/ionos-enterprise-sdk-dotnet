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
    public class ServerProperties : IEquatable<ServerProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerProperties" /> class.
        /// </summary>
        public ServerProperties()
        {

        }


        /// <summary>
        /// A name of that resource
        /// </summary>
        /// <value>A name of that resource</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }


        /// <summary>
        /// The total number of cores for the server
        /// </summary>
        /// <value>The total number of cores for the server</value>
        [DataMember(Name = "cores", EmitDefaultValue = false)]
        public int? Cores { get; set; }


        /// <summary>
        /// The amount of memory for the server in MB, e.g. 2048. Size must be specified in multiples of 256 MB with a minimum of 256 MB; however, if you set ramHotPlug to TRUE then you must use a minimum of 1024 MB
        /// </summary>
        /// <value>The amount of memory for the server in MB, e.g. 2048. Size must be specified in multiples of 256 MB with a minimum of 256 MB; however, if you set ramHotPlug to TRUE then you must use a minimum of 1024 MB</value>
        [DataMember(Name = "ram", EmitDefaultValue = false)]
        public int? Ram { get; set; }


        /// <summary>
        /// The availability zone in which the server should exist
        /// </summary>
        /// <value>The availability zone in which the server should exist</value>
        [DataMember(Name = "availabilityZone", EmitDefaultValue = false)]
        public string AvailabilityZone { get; set; }


        /// <summary>
        /// Status of the virtual Machine
        /// </summary>
        /// <value>Status of the virtual Machine</value>
        [DataMember(Name = "vmState", EmitDefaultValue = false)]
        public string VmState { get; set; }


        /// <summary>
        /// Reference to a CD-ROM used for booting. If not 'null' then bootVolume has to be 'null'
        /// </summary>
        /// <value>Reference to a CD-ROM used for booting. If not 'null' then bootVolume has to be 'null'</value>
        [DataMember(Name = "bootCdrom", EmitDefaultValue = false)]
        public ResourceReference BootCdrom { get; set; }


        /// <summary>
        /// Reference to a Volume used for booting. If not 'null' then bootCdrom has to be 'null'
        /// </summary>
        /// <value>Reference to a Volume used for booting. If not 'null' then bootCdrom has to be 'null'</value>
        [DataMember(Name = "bootVolume", EmitDefaultValue = false)]
        public ResourceReference BootVolume { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerProperties {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Cores: ").Append(Cores).Append("\n");
            sb.Append("  Ram: ").Append(Ram).Append("\n");
            sb.Append("  AvailabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  VmState: ").Append(VmState).Append("\n");
            sb.Append("  BootCdrom: ").Append(BootCdrom).Append("\n");
            sb.Append("  BootVolume: ").Append(BootVolume).Append("\n");

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
            return this.Equals(obj as ServerProperties);
        }

        /// <summary>
        /// Returns true if ServerProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of ServerProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerProperties other)
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
                    this.Cores == other.Cores ||
                    this.Cores != null &&
                    this.Cores.Equals(other.Cores)
                ) &&
                (
                    this.Ram == other.Ram ||
                    this.Ram != null &&
                    this.Ram.Equals(other.Ram)
                ) &&
                (
                    this.AvailabilityZone == other.AvailabilityZone ||
                    this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(other.AvailabilityZone)
                ) &&
                (
                    this.VmState == other.VmState ||
                    this.VmState != null &&
                    this.VmState.Equals(other.VmState)
                ) &&
                (
                    this.BootCdrom == other.BootCdrom ||
                    this.BootCdrom != null &&
                    this.BootCdrom.Equals(other.BootCdrom)
                ) &&
                (
                    this.BootVolume == other.BootVolume ||
                    this.BootVolume != null &&
                    this.BootVolume.Equals(other.BootVolume)
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

                if (this.Cores != null)
                    hash = hash * 59 + this.Cores.GetHashCode();

                if (this.Ram != null)
                    hash = hash * 59 + this.Ram.GetHashCode();

                if (this.AvailabilityZone != null)
                    hash = hash * 59 + this.AvailabilityZone.GetHashCode();

                if (this.VmState != null)
                    hash = hash * 59 + this.VmState.GetHashCode();

                if (this.BootCdrom != null)
                    hash = hash * 59 + this.BootCdrom.GetHashCode();

                if (this.BootVolume != null)
                    hash = hash * 59 + this.BootVolume.GetHashCode();

                return hash;
            }
        }

    }


}
