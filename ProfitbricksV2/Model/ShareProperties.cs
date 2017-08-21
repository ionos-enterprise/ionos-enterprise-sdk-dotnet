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
    public class ShareProperties : IEquatable<ShareProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareProperties" /> class.
        /// </summary>
        public ShareProperties()
        {
        }

        /// <summary>
        /// Indicates if the group has permission to edit privileges on this resource.
        /// </summary>
        /// <value>Indicates if the group has permission to edit privileges on this resource.</value>
        [DataMember(Name = "editPrivilege", EmitDefaultValue = false)]
        public bool? EditPrivilege { get; set; }

        /// <summary>
        /// Indicates if the group has permission to share this resource.
        /// </summary>
        /// <value>Indicates if the group has permission to share this resource.</value>
        [DataMember(Name = "sharePrivilege", EmitDefaultValue = false)]
        public bool? SharePrivilege { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareProperties {\n");
            sb.Append("  EditPrivilege: ").Append(EditPrivilege).Append("\n");
            sb.Append("  SharePrivilege: ").Append(SharePrivilege).Append("\n");

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
            return this.Equals(obj as ShareProperties);
        }

        /// <summary>
        /// Returns true if ShareProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of ShareProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareProperties other)
        {
            if (other == null)
                return false;

            return
                (
                    this.EditPrivilege == other.EditPrivilege ||
                    this.EditPrivilege != null &&
                    this.EditPrivilege.Equals(other.EditPrivilege)
                ) &&
                (
                    this.SharePrivilege == other.SharePrivilege ||
                    this.SharePrivilege != null &&
                    this.SharePrivilege.Equals(other.SharePrivilege)
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

                if (this.EditPrivilege != null)
                    hash = hash * 59 + this.EditPrivilege.GetHashCode();

                if (this.SharePrivilege != null)
                    hash = hash * 59 + this.SharePrivilege.GetHashCode();

                return hash;
            }
        }
    }
}