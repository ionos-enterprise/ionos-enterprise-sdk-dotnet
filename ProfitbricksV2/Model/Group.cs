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
    public class Group : IEquatable<Group>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        public Group()
        {
        }

        /// <summary>
        /// The resource's unique identifier
        /// </summary>
        /// <value>The resource's unique identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The type of object that has been created
        /// </summary>
        /// <value>The type of object that has been created</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// URL to the object's representation (absolute path)
        /// </summary>
        /// <value>URL to the object's representation (absolute path)</value>
        [DataMember(Name = "href", EmitDefaultValue = false)]
        public string Href { get; set; }

        /// <summary>
        /// Group properties
        /// </summary>
        /// <value>Group properties</value>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public GroupProperties Properties { get; set; }

        /// <summary>
        /// Group entities
        /// </summary>
        /// <value>Group entities</value>
        [DataMember(Name = "entities", EmitDefaultValue = false)]
        public GroupEntities Entities { get; set; }

        public string Request { get; internal set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Group {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");

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
            return this.Equals(obj as Group);
        }

        /// <summary>
        /// Returns true if Group instances are equal
        /// </summary>
        /// <param name="other">Instance of Group to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Group other)
        {
            if (other == null)
                return false;

            return
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
                ) &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.Equals(other.Entities)
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

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                return hash;
            }
        }
    }
}
