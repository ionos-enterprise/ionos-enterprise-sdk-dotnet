using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;



namespace  Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class DatacenterProperties : IEquatable<DatacenterProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatacenterProperties" /> class.
        /// </summary>
        public DatacenterProperties()
        {

        }


        /// <summary>
        /// A name of that resource
        /// </summary>
        /// <value>A name of that resource</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }


        /// <summary>
        /// A description for the datacenter, e.g. staging, production
        /// </summary>
        /// <value>A description for the datacenter, e.g. staging, production</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }


        /// <summary>
        /// The physical location where the datacenter will be created. This will be where all of your servers live. Property cannot be modified after datacenter creation (disallowed in update requests)
        /// </summary>
        /// <value>The physical location where the datacenter will be created. This will be where all of your servers live. Property cannot be modified after datacenter creation (disallowed in update requests)</value>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }


        /// <summary>
        /// The version of that Data Center. Gets incremented with every change
        /// </summary>
        /// <value>The version of that Data Center. Gets incremented with every change</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int? Version { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatacenterProperties {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");

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
            return this.Equals(obj as DatacenterProperties);
        }

        /// <summary>
        /// Returns true if DatacenterProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of DatacenterProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatacenterProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                return hash;
            }
        }

    }


}
