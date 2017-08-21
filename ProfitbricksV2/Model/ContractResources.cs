using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ContractResources : IEquatable<ContractResources>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractResources" /> class.
        /// </summary>
        public ContractResources()
        {
        }

        /// <summary>
        /// The type of object that has been created
        /// </summary>
        /// <value>The type of object that has been created</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Resource's properties
        /// </summary>
        /// <value>Resource's properties</value>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public ContractResourcesProperties Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("class ContractResources {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(obj as ContractResources);
        }

        /// <summary>
        /// Returns true if ContractResources instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractResources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractResources other)
        {
            if (other == null)
                return false;

            return
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                return hash;
            }
        }
    }
}
