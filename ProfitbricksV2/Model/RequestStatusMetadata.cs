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
    public class RequestStatusMetadata : IEquatable<RequestStatusMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestStatusMetadata" /> class.
        /// </summary>
        public RequestStatusMetadata()
        {

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }


        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }


        /// <summary>
        /// Resource's Entity Tag as defined in http://www.w3.org/Protocols/rfc2616/rfc2616-sec3.html#sec3.11 . Entity Tag is also added as an 'ETag response header to requests which don't use 'depth' parameter.
        /// </summary>
        /// <value>Resource's Entity Tag as defined in http://www.w3.org/Protocols/rfc2616/rfc2616-sec3.html#sec3.11 . Entity Tag is also added as an 'ETag response header to requests which don't use 'depth' parameter.</value>
        [DataMember(Name = "etag", EmitDefaultValue = false)]
        public string Etag { get; set; }


        /// <summary>
        /// Gets or Sets Targets
        /// </summary>
        [DataMember(Name = "targets", EmitDefaultValue = false)]
        public List<RequestTarget> Targets { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestStatusMetadata {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Targets: ").Append(Targets).Append("\n");

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
            return this.Equals(obj as RequestStatusMetadata);
        }

        /// <summary>
        /// Returns true if RequestStatusMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of RequestStatusMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestStatusMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) &&
                (
                    this.Targets == other.Targets ||
                    this.Targets != null &&
                    this.Targets.SequenceEqual(other.Targets)
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

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();

                if (this.Targets != null)
                    hash = hash * 59 + this.Targets.GetHashCode();

                return hash;
            }
        }

    }


}
