using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class LocationProperties : IEquatable<LocationProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationProperties" /> class.
        /// </summary>
        public LocationProperties()
        {
        }

        /// <summary>
        /// A name of that location
        /// </summary>
        /// <value>A name of that location</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Features of the location
        /// </summary>
        /// <value>Features of the location</value>
        [DataMember(Name = "features", EmitDefaultValue = false)]
        public string[] Features { get; set; }

        /// <summary>
        /// Image aliases for the public images available at the location
        /// </summary>
        /// <value>Image aliases for the public images available at the location</value>
        [DataMember(Name = "imageAliases", EmitDefaultValue = false)]
        public string[] ImageAliases { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationProperties {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  ImageAliases: ").Append(ImageAliases).Append("\n");

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
            return this.Equals(obj as LocationProperties);
        }

        /// <summary>
        /// Returns true if LocationProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of LocationProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationProperties other)
        {
            if (other == null)
                return false;

            return
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.Equals(other.Features)
                ) &&
                (
                    this.ImageAliases == other.ImageAliases ||
                    this.ImageAliases != null &&
                    this.ImageAliases.Equals(other.ImageAliases)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 41;

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Features != null)
                    hash = hash * 59 + this.Features.GetHashCode();

                if (this.ImageAliases != null)
                    hash = hash * 59 + this.ImageAliases.GetHashCode();

                return hash;
            }
        }
    }
}
