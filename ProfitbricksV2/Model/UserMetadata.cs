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
    public class UserMetadata : IEquatable<UserMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetadata" /> class.
        /// </summary>
        public UserMetadata()
        {
        }

        /// <summary>
        /// The last time the user was created
        /// </summary>
        /// <value>The last time the user was created</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime? CreationDate { get; set; }


        /// <summary>
        /// The last time of the user login
        /// </summary>
        /// <value>The last time of the user login</value>
        [DataMember(Name = "lastLogin", EmitDefaultValue = false)]
        public string LastLogin { get; set; }

        /// <summary>
        /// Resource's Entity Tag as defined in http://www.w3.org/Protocols/rfc2616/rfc2616-sec3.html#sec3.11 . Entity Tag is also added as an 'ETag response header to requests which don't use 'depth' parameter.
        /// </summary>
        /// <value>Resource's Entity Tag as defined in http://www.w3.org/Protocols/rfc2616/rfc2616-sec3.html#sec3.11 . Entity Tag is also added as an 'ETag response header to requests which don't use 'depth' parameter.</value>
        [DataMember(Name = "etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserMetadata {\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");

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
            return this.Equals(obj as UserMetadata);
        }

        /// <summary>
        /// Returns true if UserMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of UserMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserMetadata other)
        {
            if (other == null)
                return false;

            return
                (
                    this.CreationDate == other.CreationDate ||
                    this.CreationDate != null &&
                    this.CreationDate.Equals(other.CreationDate)
                ) &&
                (
                    this.LastLogin == other.LastLogin ||
                    this.LastLogin != null &&
                    this.LastLogin.Equals(other.LastLogin)
                ) &&
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
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

                if (this.CreationDate != null)
                    hash = hash * 59 + this.CreationDate.GetHashCode();

                if (this.LastLogin != null)
                    hash = hash * 59 + this.LastLogin.GetHashCode();

                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();

                return hash;
            }
        }
    }
}
