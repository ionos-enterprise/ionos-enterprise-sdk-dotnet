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
    public class LoadbalancerProperties : IEquatable<LoadbalancerProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadbalancerProperties" /> class.
        /// </summary>
        public LoadbalancerProperties()
        {
            this.Dhcp = false;

        }


        /// <summary>
        /// A name of that resource
        /// </summary>
        /// <value>A name of that resource</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }


        /// <summary>
        /// IPv4 address of the loadbalancer. All attached NICs will inherit this IP. Leaving value null will assign IP automatically
        /// </summary>
        /// <value>IPv4 address of the loadbalancer. All attached NICs will inherit this IP. Leaving value null will assign IP automatically</value>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        public string Ip { get; set; }


        /// <summary>
        /// Indicates if the loadbalancer will reserve an IP using DHCP
        /// </summary>
        /// <value>Indicates if the loadbalancer will reserve an IP using DHCP</value>
        [DataMember(Name = "dhcp", EmitDefaultValue = false)]
        public bool? Dhcp { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadbalancerProperties {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Dhcp: ").Append(Dhcp).Append("\n");

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
            return this.Equals(obj as LoadbalancerProperties);
        }

        /// <summary>
        /// Returns true if LoadbalancerProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of LoadbalancerProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoadbalancerProperties other)
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
                    this.Ip == other.Ip ||
                    this.Ip != null &&
                    this.Ip.Equals(other.Ip)
                ) &&
                (
                    this.Dhcp == other.Dhcp ||
                    this.Dhcp != null &&
                    this.Dhcp.Equals(other.Dhcp)
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

                if (this.Ip != null)
                    hash = hash * 59 + this.Ip.GetHashCode();

                if (this.Dhcp != null)
                    hash = hash * 59 + this.Dhcp.GetHashCode();

                return hash;
            }
        }

    }


}
