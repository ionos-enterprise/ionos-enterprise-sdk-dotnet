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
    public class FirewallruleProperties : IEquatable<FirewallruleProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallruleProperties" /> class.
        /// </summary>
        public FirewallruleProperties()
        {

        }


        /// <summary>
        /// A name of that resource
        /// </summary>
        /// <value>A name of that resource</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }


        /// <summary>
        /// The protocol for the rule. Property cannot be modified after creation (disallowed in update requests)
        /// </summary>
        /// <value>The protocol for the rule. Property cannot be modified after creation (disallowed in update requests)</value>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public string Protocol { get; set; }


        /// <summary>
        /// Only traffic originating from the respective MAC address is allowed. Valid format: aa:bb:cc:dd:ee:ff. Value null allows all source MAC address
        /// </summary>
        /// <value>Only traffic originating from the respective MAC address is allowed. Valid format: aa:bb:cc:dd:ee:ff. Value null allows all source MAC address</value>
        [DataMember(Name = "sourceMac", EmitDefaultValue = false)]
        public string SourceMac { get; set; }


        /// <summary>
        /// Only traffic originating from the respective IPv4 address is allowed. Value null allows all source IPs
        /// </summary>
        /// <value>Only traffic originating from the respective IPv4 address is allowed. Value null allows all source IPs</value>
        [DataMember(Name = "sourceIp", EmitDefaultValue = false)]
        public string SourceIp { get; set; }


        /// <summary>
        /// In case the target NIC has multiple IP addresses, only traffic directed to the respective IP address of the NIC is allowed. Value null allows all target IPs
        /// </summary>
        /// <value>In case the target NIC has multiple IP addresses, only traffic directed to the respective IP address of the NIC is allowed. Value null allows all target IPs</value>
        [DataMember(Name = "targetIp", EmitDefaultValue = false)]
        public string TargetIp { get; set; }


        /// <summary>
        /// Defines the allowed code (from 0 to 254) if protocol ICMP is chosen. Value null allows all codes
        /// </summary>
        /// <value>Defines the allowed code (from 0 to 254) if protocol ICMP is chosen. Value null allows all codes</value>
        [DataMember(Name = "icmpCode", EmitDefaultValue = false)]
        public int? IcmpCode { get; set; }


        /// <summary>
        /// Defines the allowed type (from 0 to 254) if the protocol ICMP is chosen. Value null allows all types
        /// </summary>
        /// <value>Defines the allowed type (from 0 to 254) if the protocol ICMP is chosen. Value null allows all types</value>
        [DataMember(Name = "icmpType", EmitDefaultValue = false)]
        public int? IcmpType { get; set; }


        /// <summary>
        /// Defines the start range of the allowed port (from 1 to 65534) if protocol TCP or UDP is chosen. Leave portRangeStart and portRangeEnd value null to allow all ports
        /// </summary>
        /// <value>Defines the start range of the allowed port (from 1 to 65534) if protocol TCP or UDP is chosen. Leave portRangeStart and portRangeEnd value null to allow all ports</value>
        [DataMember(Name = "portRangeStart", EmitDefaultValue = false)]
        public int? PortRangeStart { get; set; }


        /// <summary>
        /// Defines the end range of the allowed port (from 1 to 65534) if the protocol TCP or UDP is chosen. Leave portRangeStart and portRangeEnd null to allow all ports
        /// </summary>
        /// <value>Defines the end range of the allowed port (from 1 to 65534) if the protocol TCP or UDP is chosen. Leave portRangeStart and portRangeEnd null to allow all ports</value>
        [DataMember(Name = "portRangeEnd", EmitDefaultValue = false)]
        public int? PortRangeEnd { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirewallruleProperties {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  SourceMac: ").Append(SourceMac).Append("\n");
            sb.Append("  SourceIp: ").Append(SourceIp).Append("\n");
            sb.Append("  TargetIp: ").Append(TargetIp).Append("\n");
            sb.Append("  IcmpCode: ").Append(IcmpCode).Append("\n");
            sb.Append("  IcmpType: ").Append(IcmpType).Append("\n");
            sb.Append("  PortRangeStart: ").Append(PortRangeStart).Append("\n");
            sb.Append("  PortRangeEnd: ").Append(PortRangeEnd).Append("\n");

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
            return this.Equals(obj as FirewallruleProperties);
        }

        /// <summary>
        /// Returns true if FirewallruleProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of FirewallruleProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirewallruleProperties other)
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
                    this.Protocol == other.Protocol ||
                    this.Protocol != null &&
                    this.Protocol.Equals(other.Protocol)
                ) &&
                (
                    this.SourceMac == other.SourceMac ||
                    this.SourceMac != null &&
                    this.SourceMac.Equals(other.SourceMac)
                ) &&
                (
                    this.SourceIp == other.SourceIp ||
                    this.SourceIp != null &&
                    this.SourceIp.Equals(other.SourceIp)
                ) &&
                (
                    this.TargetIp == other.TargetIp ||
                    this.TargetIp != null &&
                    this.TargetIp.Equals(other.TargetIp)
                ) &&
                (
                    this.IcmpCode == other.IcmpCode ||
                    this.IcmpCode != null &&
                    this.IcmpCode.Equals(other.IcmpCode)
                ) &&
                (
                    this.IcmpType == other.IcmpType ||
                    this.IcmpType != null &&
                    this.IcmpType.Equals(other.IcmpType)
                ) &&
                (
                    this.PortRangeStart == other.PortRangeStart ||
                    this.PortRangeStart != null &&
                    this.PortRangeStart.Equals(other.PortRangeStart)
                ) &&
                (
                    this.PortRangeEnd == other.PortRangeEnd ||
                    this.PortRangeEnd != null &&
                    this.PortRangeEnd.Equals(other.PortRangeEnd)
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

                if (this.Protocol != null)
                    hash = hash * 59 + this.Protocol.GetHashCode();

                if (this.SourceMac != null)
                    hash = hash * 59 + this.SourceMac.GetHashCode();

                if (this.SourceIp != null)
                    hash = hash * 59 + this.SourceIp.GetHashCode();

                if (this.TargetIp != null)
                    hash = hash * 59 + this.TargetIp.GetHashCode();

                if (this.IcmpCode != null)
                    hash = hash * 59 + this.IcmpCode.GetHashCode();

                if (this.IcmpType != null)
                    hash = hash * 59 + this.IcmpType.GetHashCode();

                if (this.PortRangeStart != null)
                    hash = hash * 59 + this.PortRangeStart.GetHashCode();

                if (this.PortRangeEnd != null)
                    hash = hash * 59 + this.PortRangeEnd.GetHashCode();

                return hash;
            }
        }

    }


}
