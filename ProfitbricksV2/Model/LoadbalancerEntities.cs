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
    public class LoadbalancerEntities : IEquatable<LoadbalancerEntities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadbalancerEntities" /> class.
        /// </summary>
        public LoadbalancerEntities()
        {

        }


        /// <summary>
        /// Collection of nics being balanced
        /// </summary>
        /// <value>Collection of nics being balanced</value>
        [DataMember(Name = "balancednics", EmitDefaultValue = false)]
        public BalancedNics Balancednics { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadbalancerEntities {\n");
            sb.Append("  Balancednics: ").Append(Balancednics).Append("\n");

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
            return this.Equals(obj as LoadbalancerEntities);
        }

        /// <summary>
        /// Returns true if LoadbalancerEntities instances are equal
        /// </summary>
        /// <param name="other">Instance of LoadbalancerEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoadbalancerEntities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Balancednics == other.Balancednics ||
                    this.Balancednics != null &&
                    this.Balancednics.Equals(other.Balancednics)
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

                if (this.Balancednics != null)
                    hash = hash * 59 + this.Balancednics.GetHashCode();

                return hash;
            }
        }

    }


}
