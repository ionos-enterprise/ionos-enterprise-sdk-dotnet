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
    public class GroupEntities : IEquatable<GroupEntities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupEntities" /> class.
        /// </summary>
        public GroupEntities()
        {
        }

        /// <summary>
        /// Group users
        /// </summary>
        /// <value>Group users</value>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public Users Users { get; set; }

        /// <summary>
        /// Group resources
        /// </summary>
        /// <value>Group resources</value>
        [DataMember(Name = "resources", EmitDefaultValue = false)]
        public ManagedResources Resources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupEntities {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");

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
            return this.Equals(obj as GroupEntities);
        }

        /// <summary>
        /// Returns true if GroupEntities instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupEntities other)
        {
            if (other == null)
                return false;

            return
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.Equals(other.Users)
                ) &&
                (
                    this.Resources == other.Resources ||
                    this.Resources != null &&
                    this.Resources.Equals(other.Resources)
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

                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();

                if (this.Resources != null)
                    hash = hash * 59 + this.Resources.GetHashCode();

                return hash;
            }
        }
    }
}