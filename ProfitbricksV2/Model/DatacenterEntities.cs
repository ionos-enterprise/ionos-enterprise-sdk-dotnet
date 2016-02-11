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
    public class DatacenterEntities : IEquatable<DatacenterEntities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatacenterEntities" /> class.
        /// </summary>
        public DatacenterEntities()
        {

        }


        /// <summary>
        /// Collection of servers defined in that datacenter
        /// </summary>
        /// <value>Collection of servers defined in that datacenter</value>
        [DataMember(Name = "servers", EmitDefaultValue = false)]
        public Servers Servers { get; set; }


        /// <summary>
        /// Collection of volumes defined in that datacenter
        /// </summary>
        /// <value>Collection of volumes defined in that datacenter</value>
        [DataMember(Name = "volumes", EmitDefaultValue = false)]
        public Volumes Volumes { get; set; }


        /// <summary>
        /// Collection of loadbalancers defined in that datacenter
        /// </summary>
        /// <value>Collection of loadbalancers defined in that datacenter</value>
        [DataMember(Name = "loadbalancers", EmitDefaultValue = false)]
        public Loadbalancers Loadbalancers { get; set; }


        /// <summary>
        /// Collection of lans defined in that datacenter
        /// </summary>
        /// <value>Collection of lans defined in that datacenter</value>
        [DataMember(Name = "lans", EmitDefaultValue = false)]
        public Lans Lans { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatacenterEntities {\n");
            sb.Append("  Servers: ").Append(Servers).Append("\n");
            sb.Append("  Volumes: ").Append(Volumes).Append("\n");
            sb.Append("  Loadbalancers: ").Append(Loadbalancers).Append("\n");
            sb.Append("  Lans: ").Append(Lans).Append("\n");

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
            return this.Equals(obj as DatacenterEntities);
        }

        /// <summary>
        /// Returns true if DatacenterEntities instances are equal
        /// </summary>
        /// <param name="other">Instance of DatacenterEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatacenterEntities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Servers == other.Servers ||
                    this.Servers != null &&
                    this.Servers.Equals(other.Servers)
                ) &&
                (
                    this.Volumes == other.Volumes ||
                    this.Volumes != null &&
                    this.Volumes.Equals(other.Volumes)
                ) &&
                (
                    this.Loadbalancers == other.Loadbalancers ||
                    this.Loadbalancers != null &&
                    this.Loadbalancers.Equals(other.Loadbalancers)
                ) &&
                (
                    this.Lans == other.Lans ||
                    this.Lans != null &&
                    this.Lans.Equals(other.Lans)
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

                if (this.Servers != null)
                    hash = hash * 59 + this.Servers.GetHashCode();

                if (this.Volumes != null)
                    hash = hash * 59 + this.Volumes.GetHashCode();

                if (this.Loadbalancers != null)
                    hash = hash * 59 + this.Loadbalancers.GetHashCode();

                if (this.Lans != null)
                    hash = hash * 59 + this.Lans.GetHashCode();

                return hash;
            }
        }

    }


}
