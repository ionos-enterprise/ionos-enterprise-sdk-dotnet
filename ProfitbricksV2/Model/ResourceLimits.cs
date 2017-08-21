using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ResourceLimits : IEquatable<ResourceLimits>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceLimits" /> class.
        /// </summary>
        public ResourceLimits()
        {
        }

        /// <summary>
        /// The total number of cores per server
        /// </summary>
        /// <value>The total number of cores per server</value>
        [DataMember(Name = "coresPerServer", EmitDefaultValue = false)]
        public int? CoresPerServer { get; set; }

        /// <summary>
        /// The total number of cores per contract
        /// </summary>
        /// <value>The total number of cores per contract</value>
        [DataMember(Name = "coresPerContract", EmitDefaultValue = false)]
        public int? CoresPerContract { get; set; }

        /// <summary>
        /// The number of cores currently in use
        /// </summary>
        /// <value>The number of cores currently in use</value>
        [DataMember(Name = "coresProvisioned", EmitDefaultValue = false)]
        public int? CoresProvisioned { get; set; }

        /// <summary>
        /// The total amount of RAM per server
        /// </summary>
        /// <value>The total amount of RAM per server</value>
        [DataMember(Name = "ramPerServer", EmitDefaultValue = false)]
        public int? RamPerServer { get; set; }

        /// <summary>
        /// The total amount of RAM per contract
        /// </summary>
        /// <value>The total amount of RAM per contract</value>
        [DataMember(Name = "ramPerContract", EmitDefaultValue = false)]
        public int? RamPerContract { get; set; }

        /// <summary>
        /// The total amount of RAM currently in use
        /// </summary>
        /// <value>The total amount of RAM currently in use</value>
        [DataMember(Name = "ramProvisioned", EmitDefaultValue = false)]
        public int? RamProvisioned { get; set; }

        /// <summary>
        /// The total size of HDD disk space per contract
        /// </summary>
        /// <value>The total size of HDD disk space per contract</value>
        [DataMember(Name = "hddLimitPerContract", EmitDefaultValue = false)]
        public int? HddLimitPerContract { get; set; }

        /// <summary>
        /// The total size of HDD disk space per volume
        /// </summary>
        /// <value>The total size of HDD disk space per volume</value>
        [DataMember(Name = "hddLimitPerVolume", EmitDefaultValue = false)]
        public int? HddLimitPerVolume { get; set; }

        /// <summary>
        /// The total size of HDD disk space currently in use
        /// </summary>
        /// <value>The total size of HDD disk space currently in use</value>
        [DataMember(Name = "hddVolumeProvisioned", EmitDefaultValue = false)]
        public int? HddVolumeProvisioned { get; set; }

        /// <summary>
        /// The total size of SSD disk space per contract
        /// </summary>
        /// <value>The total size of SSD disk space per contract</value>
        [DataMember(Name = "ssdLimitPerContract", EmitDefaultValue = false)]
        public int? SsdLimitPerContract { get; set; }

        /// <summary>
        /// The total size of SSD disk space per volume
        /// </summary>
        /// <value>The total size of SSD disk space per volume</value>
        [DataMember(Name = "ssdLimitPerVolume", EmitDefaultValue = false)]
        public int? SsdLimitPerVolume { get; set; }

        /// <summary>
        /// The total size of SSD disk space currently in use
        /// </summary>
        /// <value>The total size of SSD disk space currently in use</value>
        [DataMember(Name = "ssdVolumeProvisioned", EmitDefaultValue = false)]
        public int? SsdVolumeProvisioned { get; set; }

        /// <summary>
        /// The number of reservable IPs
        /// </summary>
        /// <value>The number of reservable IPs</value>
        [DataMember(Name = "reservableIps", EmitDefaultValue = false)]
        public int? ReservableIps { get; set; }

        /// <summary>
        /// The total number of reservable IPs on contract
        /// </summary>
        /// <value>The total number of reservable IPs on contract</value>
        [DataMember(Name = "reservedIpsOnContract", EmitDefaultValue = false)]
        public int? ReservedIpsOnContract { get; set; }

        /// <summary>
        /// The number of reservable IPs currently in use
        /// </summary>
        /// <value>The number of reservable IPs currently in use</value>
        [DataMember(Name = "reservedIpsInUse", EmitDefaultValue = false)]
        public int? ReservedIpsInUse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceLimits {\n");
            sb.Append("  CoresPerServer: ").Append(CoresPerServer).Append("\n");
            sb.Append("  CoresPerContract: ").Append(CoresPerContract).Append("\n");
            sb.Append("  CoresProvisioned: ").Append(CoresProvisioned).Append("\n");
            sb.Append("  RamPerServer: ").Append(RamPerServer).Append("\n");
            sb.Append("  RamPerContract: ").Append(RamPerContract).Append("\n");
            sb.Append("  RamProvisioned: ").Append(RamProvisioned).Append("\n");
            sb.Append("  HddLimitPerVolume: ").Append(HddLimitPerVolume).Append("\n");
            sb.Append("  HddLimitPerContract: ").Append(HddLimitPerContract).Append("\n");
            sb.Append("  HddVolumeProvisioned: ").Append(HddVolumeProvisioned).Append("\n");
            sb.Append("  SsdLimitPerVolume: ").Append(SsdLimitPerVolume).Append("\n");
            sb.Append("  SsdLimitPerContract: ").Append(SsdLimitPerContract).Append("\n");
            sb.Append("  SsdVolumeProvisioned: ").Append(SsdVolumeProvisioned).Append("\n");
            sb.Append("  ReservableIps: ").Append(ReservableIps).Append("\n");
            sb.Append("  ReservedIpsOnContract: ").Append(ReservedIpsOnContract).Append("\n");
            sb.Append("  ReservedIpsInUse: ").Append(ReservedIpsInUse).Append("\n");

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
            return this.Equals(obj as ResourceLimits);
        }

        /// <summary>
        /// Returns true if ResourceLimits instances are equal
        /// </summary>
        /// <param name="other">Instance of ResourceLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceLimits other)
        {
            if (other == null)
                return false;

            return
                (
                    this.CoresPerServer == other.CoresPerServer ||
                    this.CoresPerServer != null &&
                    this.CoresPerServer.Equals(other.CoresPerServer)
                ) &&
                (
                    this.CoresPerContract == other.CoresPerContract ||
                    this.CoresPerContract != null &&
                    this.CoresPerContract.Equals(other.CoresPerContract)
                ) &&
                (
                    this.CoresProvisioned == other.CoresProvisioned ||
                    this.CoresProvisioned != null &&
                    this.CoresProvisioned.Equals(other.CoresProvisioned)
                ) &&
                (
                    this.RamPerServer == other.RamPerServer ||
                    this.RamPerServer != null &&
                    this.RamPerServer.Equals(other.RamPerServer)
                ) &&
                (
                    this.RamPerContract == other.RamPerContract ||
                    this.RamPerContract != null &&
                    this.RamPerContract.Equals(other.RamPerContract)
                ) &&
                (
                    this.RamProvisioned == other.RamProvisioned ||
                    this.RamProvisioned != null &&
                    this.RamProvisioned.Equals(other.RamProvisioned)
                ) &&
                (
                    this.HddLimitPerVolume == other.HddLimitPerVolume ||
                    this.HddLimitPerVolume != null &&
                    this.HddLimitPerVolume.Equals(other.HddLimitPerVolume)
                ) &&
                (
                    this.HddLimitPerContract == other.HddLimitPerContract ||
                    this.HddLimitPerContract != null &&
                    this.HddLimitPerContract.Equals(other.HddLimitPerContract)
                ) &&
                (
                    this.HddVolumeProvisioned == other.HddVolumeProvisioned ||
                    this.HddVolumeProvisioned != null &&
                    this.HddVolumeProvisioned.Equals(other.HddVolumeProvisioned)
                ) &&
                (
                    this.SsdLimitPerVolume == other.SsdLimitPerVolume ||
                    this.SsdLimitPerVolume != null &&
                    this.SsdLimitPerVolume.Equals(other.SsdLimitPerVolume)
                ) &&
                (
                    this.SsdLimitPerContract == other.SsdLimitPerContract ||
                    this.SsdLimitPerContract != null &&
                    this.SsdLimitPerContract.Equals(other.SsdLimitPerContract)
                ) &&
                (
                    this.SsdVolumeProvisioned == other.SsdVolumeProvisioned ||
                    this.SsdVolumeProvisioned != null &&
                    this.SsdVolumeProvisioned.Equals(other.SsdVolumeProvisioned)
                ) &&
                (
                    this.ReservableIps == other.ReservableIps ||
                    this.ReservableIps != null &&
                    this.ReservableIps.Equals(other.ReservableIps)
                ) &&
                (
                    this.ReservedIpsOnContract == other.ReservedIpsOnContract ||
                    this.ReservedIpsOnContract != null &&
                    this.ReservedIpsOnContract.Equals(other.ReservedIpsOnContract)
                ) &&
                (
                    this.ReservedIpsInUse == other.ReservedIpsInUse ||
                    this.ReservedIpsInUse != null &&
                    this.ReservedIpsInUse.Equals(other.ReservedIpsInUse)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 41;

                if (this.CoresPerServer != null)
                    hash = hash * 59 + this.CoresPerServer.GetHashCode();

                if (this.CoresPerContract != null)
                    hash = hash * 59 + this.CoresPerContract.GetHashCode();

                if (this.CoresProvisioned != null)
                    hash = hash * 59 + this.CoresProvisioned.GetHashCode();

                if (this.RamPerServer != null)
                    hash = hash * 59 + this.RamPerServer.GetHashCode();

                if (this.RamPerContract != null)
                    hash = hash * 59 + this.RamPerContract.GetHashCode();

                if (this.RamProvisioned != null)
                    hash = hash * 59 + this.RamProvisioned.GetHashCode();

                if (this.HddLimitPerVolume != null)
                    hash = hash * 59 + this.HddLimitPerVolume.GetHashCode();

                if (this.HddLimitPerContract != null)
                    hash = hash * 59 + this.HddLimitPerContract.GetHashCode();

                if (this.HddVolumeProvisioned != null)
                    hash = hash * 59 + this.HddVolumeProvisioned.GetHashCode();

                if (this.SsdLimitPerVolume != null)
                    hash = hash * 59 + this.SsdLimitPerVolume.GetHashCode();

                if (this.SsdLimitPerContract != null)
                    hash = hash * 59 + this.SsdLimitPerContract.GetHashCode();

                if (this.SsdVolumeProvisioned != null)
                    hash = hash * 59 + this.SsdVolumeProvisioned.GetHashCode();

                if (this.ReservableIps != null)
                    hash = hash * 59 + this.ReservableIps.GetHashCode();

                if (this.ReservedIpsOnContract != null)
                    hash = hash * 59 + this.ReservedIpsOnContract.GetHashCode();

                if (this.ReservedIpsInUse != null)
                    hash = hash * 59 + this.ReservedIpsInUse.GetHashCode();

                return hash;
            }
        }
    }
}
