using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace  Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Server : IEquatable<Server>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Server" /> class.
        /// </summary>
        public Server()
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
        /// URL to the object’s representation (absolute path)
        /// </summary>
        /// <value>URL to the object’s representation (absolute path)</value>
        [DataMember(Name = "href", EmitDefaultValue = false)]
        public string Href { get; set; }


        /// <summary>
        /// Backend managed resource metadata
        /// </summary>
        /// <value>Backend managed resource metadata</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public DatacenterElementMetadata Metadata { get; set; }


        /// <summary>
        /// Resource's properties
        /// </summary>
        /// <value>Resource's properties</value>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public ServerProperties Properties { get; set; }


        /// <summary>
        /// Attached children and references. May be included in create calls. Disallowed in update calls
        /// </summary>
        /// <value>Attached children and references. May be included in create calls. Disallowed in update calls</value>
        [DataMember(Name = "entities", EmitDefaultValue = false)]
        public ServerEntities Entities { get; set; }

        public string Request { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Server {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Server);
        }

        /// <summary>
        /// Returns true if Server instances are equal
        /// </summary>
        /// <param name="other">Instance of Server to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Server other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
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
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                return hash;
            }
        }

    }


}
