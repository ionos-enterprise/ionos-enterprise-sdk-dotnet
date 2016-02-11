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
    public class RequestTarget : IEquatable<RequestTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTarget" /> class.
        /// </summary>
        public RequestTarget()
        {

        }


        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", EmitDefaultValue = false)]
        public ResourceReference Target { get; set; }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestTarget {\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");

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
            return this.Equals(obj as RequestTarget);
        }

        /// <summary>
        /// Returns true if RequestTarget instances are equal
        /// </summary>
        /// <param name="other">Instance of RequestTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestTarget other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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

                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                return hash;
            }
        }

    }


}
