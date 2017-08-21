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
    public class IpBlockProperties : IEquatable<IpBlockProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpBlockProperties" /> class.
        /// </summary>
        public IpBlockProperties()
        {

        }

        /// <summary>
        /// A name of that resource
        /// </summary>
        /// <value>A name of that resource</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A collection of IPs associated with the IP Block
        /// </summary>
        /// <value>A collection of IPs associated with the IP Block</value>
        [DataMember(Name = "ips", EmitDefaultValue = false)]
        public List<string> Ips { get; set; }


        /// <summary>
        /// Location of that IP Block. Property cannot be modified after creation (disallowed in update requests)
        /// </summary>
        /// <value>Location of that IP Block. Property cannot be modified after creation (disallowed in update requests)</value>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }


        /// <summary>
        /// The size of the IP block
        /// </summary>
        /// <value>The size of the IP block</value>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int? Size { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpBlockProperties {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ips: ").Append(Ips).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");

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
            return this.Equals(obj as IpBlockProperties);
        }

        /// <summary>
        /// Returns true if IpBlockProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of IpBlockProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpBlockProperties other)
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
                    this.Ips == other.Ips ||
                    this.Ips != null &&
                    this.Ips.SequenceEqual(other.Ips)
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

                if (this.Ips != null)
                    hash = hash * 59 + this.Ips.GetHashCode();

                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();

                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();

                return hash;
            }
        }

    }


}
