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
    public class ManagedResourceEntities : IEquatable<ManagedResourceEntities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedResourceEntities" /> class.
        /// </summary>
        public ManagedResourceEntities()
        {
        }

        /// <summary>
        /// ManagedResourceEntities groups
        /// </summary>
        /// <value>ManagedResourceEntities groups</value>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public Groups Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagedResourceEntities {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");

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
            return this.Equals(obj as ManagedResourceEntities);
        }

        /// <summary>
        /// Returns true if ManagedResourceEntities instances are equal
        /// </summary>
        /// <param name="other">Instance of ManagedResourceEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagedResourceEntities other)
        {
            if (other == null)
                return false;

            return
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.Equals(other.Groups)
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

                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();

                return hash;
            }
        }
    }
}
