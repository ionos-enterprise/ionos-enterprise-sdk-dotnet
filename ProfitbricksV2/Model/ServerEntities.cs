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
    public class ServerEntities : IEquatable<ServerEntities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerEntities" /> class.
        /// </summary>
        public ServerEntities()
        {

        }


        /// <summary>
        /// Collection of CD-ROMs attached to that server
        /// </summary>
        /// <value>Collection of CD-ROMs attached to that server</value>
        [DataMember(Name = "cdroms", EmitDefaultValue = false)]
        public Cdroms Cdroms { get; set; }


        /// <summary>
        /// Collection of volumes attached to that server
        /// </summary>
        /// <value>Collection of volumes attached to that server</value>
        [DataMember(Name = "volumes", EmitDefaultValue = false)]
        public AttachedVolumes Volumes { get; set; }


        /// <summary>
        /// Collection of nics of that server
        /// </summary>
        /// <value>Collection of nics of that server</value>
        [DataMember(Name = "nics", EmitDefaultValue = false)]
        public Nics Nics { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerEntities {\n");
            sb.Append("  Cdroms: ").Append(Cdroms).Append("\n");
            sb.Append("  Volumes: ").Append(Volumes).Append("\n");
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
            return this.Equals(obj as ServerEntities);
        }

        /// <summary>
        /// Returns true if ServerEntities instances are equal
        /// </summary>
        /// <param name="other">Instance of ServerEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerEntities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Cdroms == other.Cdroms ||
                    this.Cdroms != null &&
                    this.Cdroms.Equals(other.Cdroms)
                ) &&
                (
                    this.Volumes == other.Volumes ||
                    this.Volumes != null &&
                    this.Volumes.Equals(other.Volumes)
                ) &&
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

                if (this.Cdroms != null)
                    hash = hash * 59 + this.Cdroms.GetHashCode();

                if (this.Volumes != null)
                    hash = hash * 59 + this.Volumes.GetHashCode();

                if (this.Nics != null)
                    hash = hash * 59 + this.Nics.GetHashCode();

                return hash;
            }
        }

    }


}
