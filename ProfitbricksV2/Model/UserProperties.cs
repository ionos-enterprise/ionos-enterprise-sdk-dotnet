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
    public class UserProperties : IEquatable<UserProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProperties" /> class.
        /// </summary>
        public UserProperties()
        {
        }

        /// <summary>
        /// A name for the user
        /// </summary>
        /// <value>A name for the user</value>
        [DataMember(Name = "firstname", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// A name for the user
        /// </summary>
        /// <value>A name for the user</value>
        [DataMember(Name = "lastname", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// An e-mail address for the user
        /// </summary>
        /// <value>An e-mail address for the user</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// A password for the user
        /// </summary>
        /// <value>A password for the user</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Indicates if the user have administrative rights.
        /// </summary>
        /// <value>Indicates if the user have administrative rights.</value>
        [DataMember(Name = "administrator", EmitDefaultValue = false)]
        public bool? Administrator { get; set; }

        /// <summary>
        /// Indicates if secure (two-factor) authentication should be forced for the user.
        /// </summary>
        /// <value>Indicates if secure (two-factor) authentication should be forced for the user.</value>
        [DataMember(Name = "forceSecAuth", EmitDefaultValue = false)]
        public bool? ForceSecAuth { get; set; }

        /// <summary>
        /// Indicates if secure (two-factor) authentication for the user is active.
        /// </summary>
        /// <value>Indicates if secure (two-factor) authentication for the user is active.</value>
        [DataMember(Name = "secAuthActive", EmitDefaultValue = false)]
        public bool? SecAuthActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProperties {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Administrator: ").Append(Administrator).Append("\n");
            sb.Append("  ForceSecAuth: ").Append(ForceSecAuth).Append("\n");
            sb.Append("  SecAuthActive: ").Append(SecAuthActive).Append("\n");

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
            return this.Equals(obj as UserProperties);
        }

        /// <summary>
        /// Returns true if UserProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of UserProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProperties other)
        {
            if (other == null)
                return false;

            return
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) &&
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) &&
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) &&
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) &&
                (
                    this.Administrator == other.Administrator ||
                    this.Administrator != null &&
                    this.Administrator.Equals(other.Administrator)
                ) &&
                (
                    this.ForceSecAuth == other.ForceSecAuth ||
                    this.ForceSecAuth != null &&
                    this.ForceSecAuth.Equals(other.ForceSecAuth)
                ) &&
                (
                    this.SecAuthActive == other.SecAuthActive ||
                    this.SecAuthActive != null &&
                    this.SecAuthActive.Equals(other.SecAuthActive)
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

                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();

                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();

                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();

                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();

                if (this.Administrator != null)
                    hash = hash * 59 + this.Administrator.GetHashCode();

                if (this.ForceSecAuth != null)
                    hash = hash * 59 + this.ForceSecAuth.GetHashCode();

                if (this.SecAuthActive != null)
                    hash = hash * 59 + this.SecAuthActive.GetHashCode();

                return hash;
            }
        }
    }
}
