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
    public class LanEntities : IEquatable<LanEntities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanEntities" /> class.
        /// </summary>
        public LanEntities()
        {

        }


        /// <summary>
        /// Collection of nics attached to this lan
        /// </summary>
        /// <value>Collection of nics attached to this lan</value>
        [DataMember(Name = "nics", EmitDefaultValue = false)]
        public LanNics Nics { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LanEntities {\n");
            sb.Append("  Nics: ").Append(Nics).Append("\n");

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
            return this.Equals(obj as LanEntities);
        }

        /// <summary>
        /// Returns true if LanEntities instances are equal
        /// </summary>
        /// <param name="other">Instance of LanEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LanEntities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Nics == other.Nics ||
                    this.Nics != null &&
                    this.Nics.Equals(other.Nics)
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

                if (this.Nics != null)
                    hash = hash * 59 + this.Nics.GetHashCode();

                return hash;
            }
        }

    }


}
