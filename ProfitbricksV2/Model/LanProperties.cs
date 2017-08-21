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
    public class LanProperties : IEquatable<LanProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanProperties" /> class.
        /// </summary>
        public LanProperties()
        {
            this.Public = false;

        }


        /// <summary>
        /// A name of that resource
        /// </summary>
        /// <value>A name of that resource</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }


        /// <summary>
        /// Does this LAN faces the public Internet or not
        /// </summary>
        /// <value>Does this LAN faces the public Internet or not</value>
        [DataMember(Name = "public", EmitDefaultValue = false)]
        public bool? Public { get; set; }

        /// <summary>
        /// List of IpFailover instances
        /// </summary>
        /// <value>List of IpFailover instances</value>
        [DataMember(Name = "ipFailover", EmitDefaultValue = false)]
        public List<IpFailover> IpFailover { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LanProperties {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  IpFailover: ").Append(IpFailover).Append("\n");

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
            return this.Equals(obj as LanProperties);
        }

        /// <summary>
        /// Returns true if LanProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of LanProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LanProperties other)
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
                    this.Public == other.Public ||
                    this.Public != null &&
                    this.Public.Equals(other.Public)
                ) &&
                (
                    this.IpFailover == other.IpFailover ||
                    this.IpFailover != null &&
                    this.IpFailover.Equals(other.IpFailover)
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

                if (this.Public != null)
                    hash = hash * 59 + this.Public.GetHashCode();

                if (this.IpFailover != null)
                    hash = hash * 59 + this.IpFailover.GetHashCode();

                return hash;
            }
        }

    }


}
