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
    public class Info : IEquatable<Info>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Info" /> class.
        /// </summary>
        public Info()
        {

        }


        /// <summary>
        /// API entry point
        /// </summary>
        /// <value>API entry point</value>
        [DataMember(Name = "href", EmitDefaultValue = false)]
        public string Href { get; set; }


        /// <summary>
        /// Name of the API
        /// </summary>
        /// <value>Name of the API</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }


        /// <summary>
        /// Version of the API
        /// </summary>
        /// <value>Version of the API</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string Version { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Info {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");

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
            return this.Equals(obj as Info);
        }

        /// <summary>
        /// Returns true if Info instances are equal
        /// </summary>
        /// <param name="other">Instance of Info to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Info other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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

                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                return hash;
            }
        }

    }


}
