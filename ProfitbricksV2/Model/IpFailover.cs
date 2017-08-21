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
    public class IpFailover : IEquatable<IpFailover>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpFailover" /> class.
        /// </summary>
        public IpFailover()
        {
        }

        /// <summary>
        /// The IP address to fail over
        /// </summary>
        /// <value>The IP address to fail over</value>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        public string Ip { get; set; }

        /// <summary>
        /// The NIC UUID
        /// </summary>
        /// <value>The NIC UUID</value>
        [DataMember(Name = "nicUuid", EmitDefaultValue = false)]
        public string NicUuid { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpFailover {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  NicUuid: ").Append(NicUuid).Append("\n");

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
            return this.Equals(obj as IpFailover);
        }

        /// <summary>
        /// Returns true if IpFailover instances are equal
        /// </summary>
        /// <param name="other">Instance of IpFailover to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpFailover other)
        {
            if (other == null)
                return false;

            return
                (
                    this.Ip == other.Ip ||
                    this.Ip != null &&
                    this.Ip.Equals(other.Ip)
                ) &&
                (
                    this.NicUuid == other.NicUuid ||
                    this.NicUuid != null &&
                    this.NicUuid.Equals(other.NicUuid)
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

                if (this.Ip != null)
                    hash = hash * 59 + this.Ip.GetHashCode();

                if (this.NicUuid != null)
                    hash = hash * 59 + this.NicUuid.GetHashCode();

                return hash;
            }
        }
    }
}
