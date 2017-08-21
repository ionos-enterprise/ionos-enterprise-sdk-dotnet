using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ContractResourcesProperties : IEquatable<ContractResourcesProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractResourcesProperties" /> class.
        /// </summary>
        public ContractResourcesProperties()
        {
        }

        /// <summary>
        /// The contract number
        /// </summary>
        /// <value>The contract number</value>
        [DataMember(Name = "contractNumber", EmitDefaultValue = false)]
        public ulong? ContractNumber { get; set; }

        /// <summary>
        /// The contract owner e-mail
        /// </summary>
        /// <value>The contract owner e-mail</value>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public string Owner { get; set; }

        /// <summary>
        /// The contract status
        /// </summary>
        /// <value>The contract status</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The contract resources limits
        /// </summary>
        /// <value>The contract resources limits</value>
        [DataMember(Name = "resourceLimits", EmitDefaultValue = false)]
        public ResourceLimits ResourceLimits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("class ContractResourcesProperties {\n");
            sb.Append("  ContractNumber: ").Append(ContractNumber).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ResourceLimits: ").Append(ResourceLimits).Append("\n");

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
            return this.Equals(obj as ContractResourcesProperties);
        }

        /// <summary>
        /// Returns true if ContractResourcesProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractResourcesProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractResourcesProperties other)
        {
            if (other == null)
                return false;

            return
                (
                    this.ContractNumber == other.ContractNumber ||
                    this.ContractNumber != null &&
                    this.ContractNumber.Equals(other.ContractNumber)
                ) &&
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ResourceLimits == other.ResourceLimits ||
                    this.ResourceLimits != null &&
                    this.ResourceLimits.Equals(other.ResourceLimits)
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

                if (this.ContractNumber != null)
                    hash = hash * 59 + this.ContractNumber.GetHashCode();

                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ResourceLimits != null)
                    hash = hash * 59 + this.ResourceLimits.GetHashCode();

                return hash;
            }
        }
    }
}
