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
    public class GroupProperties : IEquatable<GroupProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupProperties" /> class.
        /// </summary>
        public GroupProperties()
        {
        }

        /// <summary>
        /// A name of the group
        /// </summary>
        /// <value>A name of the group</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the group is allowed to create virtual data centers.
        /// </summary>
        /// <value>Indicates if the group is allowed to create virtual data centers.</value>
        [DataMember(Name = "createDataCenter", EmitDefaultValue = false)]
        public bool? CreateDataCenter { get; set; }

        /// <summary>
        /// Indicates if the group is allowed to create snapshots.
        /// </summary>
        /// <value>Indicates if the group is allowed to create snapshots.</value>
        [DataMember(Name = "createSnapshot", EmitDefaultValue = false)]
        public bool? CreateSnapshot { get; set; }

        /// <summary>
        /// Indicates if the group is allowed to allocate IP addresses.
        /// </summary>
        /// <value>Indicates if the group is allowed to allocate IP addresses.</value>
        [DataMember(Name = "reserveIp", EmitDefaultValue = false)]
        public bool? ReserveIp { get; set; }

        /// <summary>
        /// Indicates if the group is allowed to access activity log.
        /// </summary>
        /// <value>Indicates if the group is allowed to access activity log.</value>
        [DataMember(Name = "accessActivityLog", EmitDefaultValue = false)]
        public bool? AccessActivityLog { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupProperties {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreateDataCenter: ").Append(CreateDataCenter).Append("\n");
            sb.Append("  CreateSnapshot: ").Append(CreateSnapshot).Append("\n");
            sb.Append("  ReserveIp: ").Append(ReserveIp).Append("\n");
            sb.Append("  AccessActivityLog: ").Append(AccessActivityLog).Append("\n");

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
            return this.Equals(obj as GroupProperties);
        }

        /// <summary>
        /// Returns true if GroupProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupProperties other)
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
                    this.CreateDataCenter == other.CreateDataCenter ||
                    this.CreateDataCenter != null &&
                    this.CreateDataCenter.Equals(other.CreateDataCenter)
                ) &&
                (
                    this.CreateSnapshot == other.CreateSnapshot ||
                    this.CreateSnapshot != null &&
                    this.CreateSnapshot.Equals(other.CreateSnapshot)
                ) &&
                (
                    this.ReserveIp == other.ReserveIp ||
                    this.ReserveIp != null &&
                    this.ReserveIp.Equals(other.ReserveIp)
                ) &&
                (
                    this.AccessActivityLog == other.AccessActivityLog ||
                    this.AccessActivityLog != null &&
                    this.AccessActivityLog.Equals(other.AccessActivityLog)
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

                if (this.CreateDataCenter != null)
                    hash = hash * 59 + this.CreateDataCenter.GetHashCode();

                if (this.CreateSnapshot != null)
                    hash = hash * 59 + this.CreateSnapshot.GetHashCode();

                if (this.ReserveIp != null)
                    hash = hash * 59 + this.ReserveIp.GetHashCode();

                if (this.AccessActivityLog != null)
                    hash = hash * 59 + this.AccessActivityLog.GetHashCode();

                return hash;
            }
        }
    }
}