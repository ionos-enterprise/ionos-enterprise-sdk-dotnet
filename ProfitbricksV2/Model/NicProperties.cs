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
    public class NicProperties : IEquatable<NicProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NicProperties" /> class.
        /// </summary>
        public NicProperties()
        {
            this.Dhcp = false;
            this.FirewallActive = false;

        }


        /// <summary>
        /// A name of that resource
        /// </summary>
        /// <value>A name of that resource</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }


        /// <summary>
        /// The MAC address of the NIC
        /// </summary>
        /// <value>The MAC address of the NIC</value>
        [DataMember(Name = "mac", EmitDefaultValue = false)]
        public string Mac { get; set; }


        /// <summary>
        /// Collection of IP addresses assigned to a nic. Explicitly assigned public IPs need to come from reserved IP blocks, Passing value null or empty array will assign an IP address automatically.
        /// </summary>
        /// <value>Collection of IP addresses assigned to a nic. Explicitly assigned public IPs need to come from reserved IP blocks, Passing value null or empty array will assign an IP address automatically.</value>
        [DataMember(Name = "ips", EmitDefaultValue = false)]
        public List<string> Ips { get; set; }


        /// <summary>
        /// Indicates if the nic will reserve an IP using DHCP
        /// </summary>
        /// <value>Indicates if the nic will reserve an IP using DHCP</value>
        [DataMember(Name = "dhcp", EmitDefaultValue = false)]
        public bool? Dhcp { get; set; }


        /// <summary>
        /// The LAN ID the NIC will sit on. If the LAN ID does not exist it will be implicitly created
        /// </summary>
        /// <value>The LAN ID the NIC will sit on. If the LAN ID does not exist it will be implicitly created</value>
        [DataMember(Name = "lan", EmitDefaultValue = false)]
        public int? Lan { get; set; }


        /// <summary>
        /// Once you add a firewall rule this will reflect a true value. Can also be used to temporarily disable a firewall without losing defined rules.
        /// </summary>
        /// <value>Once you add a firewall rule this will reflect a true value. Can also be used to temporarily disable a firewall without losing defined rules.</value>
        [DataMember(Name = "firewallActive", EmitDefaultValue = false)]
        public bool? FirewallActive { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NicProperties {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Mac: ").Append(Mac).Append("\n");
            sb.Append("  Ips: ").Append(Ips).Append("\n");
            sb.Append("  Dhcp: ").Append(Dhcp).Append("\n");
            sb.Append("  Lan: ").Append(Lan).Append("\n");
            sb.Append("  FirewallActive: ").Append(FirewallActive).Append("\n");

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
            return this.Equals(obj as NicProperties);
        }

        /// <summary>
        /// Returns true if NicProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of NicProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NicProperties other)
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
                    this.Mac == other.Mac ||
                    this.Mac != null &&
                    this.Mac.Equals(other.Mac)
                ) &&
                (
                    this.Ips == other.Ips ||
                    this.Ips != null &&
                    this.Ips.SequenceEqual(other.Ips)
                ) &&
                (
                    this.Dhcp == other.Dhcp ||
                    this.Dhcp != null &&
                    this.Dhcp.Equals(other.Dhcp)
                ) &&
                (
                    this.Lan == other.Lan ||
                    this.Lan != null &&
                    this.Lan.Equals(other.Lan)
                ) &&
                (
                    this.FirewallActive == other.FirewallActive ||
                    this.FirewallActive != null &&
                    this.FirewallActive.Equals(other.FirewallActive)
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

                if (this.Mac != null)
                    hash = hash * 59 + this.Mac.GetHashCode();

                if (this.Ips != null)
                    hash = hash * 59 + this.Ips.GetHashCode();

                if (this.Dhcp != null)
                    hash = hash * 59 + this.Dhcp.GetHashCode();

                if (this.Lan != null)
                    hash = hash * 59 + this.Lan.GetHashCode();

                if (this.FirewallActive != null)
                    hash = hash * 59 + this.FirewallActive.GetHashCode();

                return hash;
            }
        }

    }


}
