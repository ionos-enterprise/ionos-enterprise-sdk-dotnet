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
    public class DatacenterElementMetadata : IEquatable<DatacenterElementMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatacenterElementMetadata" /> class.
        /// </summary>
        public DatacenterElementMetadata()
        {

        }


        /// <summary>
        /// The last time the resource was created
        /// </summary>
        /// <value>The last time the resource was created</value>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTime? CreatedDate { get; set; }


        /// <summary>
        /// The user who created the resource.
        /// </summary>
        /// <value>The user who created the resource.</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }


        /// <summary>
        /// Resource's Entity Tag as defined in http://www.w3.org/Protocols/rfc2616/rfc2616-sec3.html#sec3.11 . Entity Tag is also added as an 'ETag response header to requests which don't use 'depth' parameter.
        /// </summary>
        /// <value>Resource's Entity Tag as defined in http://www.w3.org/Protocols/rfc2616/rfc2616-sec3.html#sec3.11 . Entity Tag is also added as an 'ETag response header to requests which don't use 'depth' parameter.</value>
        [DataMember(Name = "etag", EmitDefaultValue = false)]
        public string Etag { get; set; }


        /// <summary>
        /// The last time the resource has been modified
        /// </summary>
        /// <value>The last time the resource has been modified</value>
        [DataMember(Name = "lastModifiedDate", EmitDefaultValue = false)]
        public DateTime? LastModifiedDate { get; set; }


        /// <summary>
        /// The user who last modified the resource.
        /// </summary>
        /// <value>The user who last modified the resource.</value>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }


        /// <summary>
        /// State of the resource. *AVAILABLE* There are no pending modification requests for this item; *BUSY* There is at least one modification request pending and all following requests will be queued; *INACTIVE* Resource has been de-provisioned.
        /// </summary>
        /// <value>State of the resource. *AVAILABLE* There are no pending modification requests for this item; *BUSY* There is at least one modification request pending and all following requests will be queued; *INACTIVE* Resource has been de-provisioned.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatacenterElementMetadata {\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");

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
            return this.Equals(obj as DatacenterElementMetadata);
        }

        /// <summary>
        /// Returns true if DatacenterElementMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of DatacenterElementMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatacenterElementMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) &&
                (
                    this.LastModifiedDate == other.LastModifiedDate ||
                    this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(other.LastModifiedDate)
                ) &&
                (
                    this.LastModifiedBy == other.LastModifiedBy ||
                    this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(other.LastModifiedBy)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();

                if (this.LastModifiedDate != null)
                    hash = hash * 59 + this.LastModifiedDate.GetHashCode();

                if (this.LastModifiedBy != null)
                    hash = hash * 59 + this.LastModifiedBy.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                return hash;
            }
        }

    }


}
