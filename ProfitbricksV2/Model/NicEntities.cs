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
    public class NicEntities : IEquatable<NicEntities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NicEntities" /> class.
        /// </summary>
        public NicEntities()
        {

        }


        /// <summary>
        /// Collection of firewall rules for that nic
        /// </summary>
        /// <value>Collection of firewall rules for that nic</value>
        [DataMember(Name = "firewallrules", EmitDefaultValue = false)]
        public FirewallRules Firewallrules { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NicEntities {\n");
            sb.Append("  Firewallrules: ").Append(Firewallrules).Append("\n");

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
            return this.Equals(obj as NicEntities);
        }

        /// <summary>
        /// Returns true if NicEntities instances are equal
        /// </summary>
        /// <param name="other">Instance of NicEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NicEntities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Firewallrules == other.Firewallrules ||
                    this.Firewallrules != null &&
                    this.Firewallrules.Equals(other.Firewallrules)
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

                if (this.Firewallrules != null)
                    hash = hash * 59 + this.Firewallrules.GetHashCode();

                return hash;
            }
        }

    }


}
