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
    public class UserEntities : IEquatable<UserEntities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEntities" /> class.
        /// </summary>
        public UserEntities()
        {
        }

        /// <summary>
        /// Entities that the user owns
        /// </summary>
        /// <value>Entities that the user owns</value>
        [DataMember(Name = "owns", EmitDefaultValue = false)]
        public OwnedEntities Owns { get; set; }

        /// <summary>
        /// User groups
        /// </summary>
        /// <value>User groups</value>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public Groups Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserEntities {\n");
            sb.Append("  Owns: ").Append(Owns).Append("\n");
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
            return this.Equals(obj as UserEntities);
        }

        /// <summary>
        /// Returns true if UserEntities instances are equal
        /// </summary>
        /// <param name="other">Instance of UserEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserEntities other)
        {
            if (other == null)
                return false;

            return
                (
                    this.Owns == other.Owns ||
                    this.Owns != null &&
                    this.Owns.Equals(other.Owns)
                ) &&
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

                if (this.Owns != null)
                    hash = hash * 59 + this.Owns.GetHashCode();

                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();

                return hash;
            }
        }
    }
}