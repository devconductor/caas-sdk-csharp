using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conductor.Pier.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Chronology :  IEquatable<Chronology>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Chronology" /> class.
        /// Initializes a new instance of the <see cref="Chronology" />class.
        /// </summary>
        /// <param name="CalendarType">CalendarType.</param>
        /// <param name="Id">Id.</param>

        public Chronology(string CalendarType = null, string Id = null)
        {
            this.CalendarType = CalendarType;
            this.Id = Id;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CalendarType
        /// </summary>
        [DataMember(Name="calendarType", EmitDefaultValue=false)]
        public string CalendarType { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Chronology {\n");
            sb.Append("  CalendarType: ").Append(CalendarType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            
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
            return this.Equals(obj as Chronology);
        }

        /// <summary>
        /// Returns true if Chronology instances are equal
        /// </summary>
        /// <param name="other">Instance of Chronology to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Chronology other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CalendarType == other.CalendarType ||
                    this.CalendarType != null &&
                    this.CalendarType.Equals(other.CalendarType)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                
                if (this.CalendarType != null)
                    hash = hash * 59 + this.CalendarType.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                return hash;
            }
        }

    }
}
