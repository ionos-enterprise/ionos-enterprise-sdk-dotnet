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
    public class Loadbalancers : IEquatable<Loadbalancers>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Loadbalancers" /> class.
        /// </summary>
        public Loadbalancers()
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
        /// Array of items in that collection
        /// </summary>
        /// <value>Array of items in that collection</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<Loadbalancer> Items { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Loadbalancers {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");

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
            return this.Equals(obj as Loadbalancers);
        }

        /// <summary>
        /// Returns true if Loadbalancers instances are equal
        /// </summary>
        /// <param name="other">Instance of Loadbalancers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Loadbalancers other)
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
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
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

                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();

                return hash;
            }
        }

    }


}
