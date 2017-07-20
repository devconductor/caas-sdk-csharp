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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do recurso validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a.
    /// </summary>
    [DataContract]
    public partial class CodigoSegurancaSMSRequest :  IEquatable<CodigoSegurancaSMSRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CodigoSegurancaSMSRequest" /> class.
        /// Initializes a new instance of the <see cref="CodigoSegurancaSMSRequest" />class.
        /// </summary>
        /// <param name="Ddd">C\u00C3\u00B3digo DDD do telefone (id)..</param>
        /// <param name="Telefone">N\u00C3\u00BAmero do telefone..</param>
        /// <param name="CodigoSeguranca">Token para valida\u00C3\u00A7\u00C3\u00A3o..</param>

        public CodigoSegurancaSMSRequest(string Ddd = null, string Telefone = null, string CodigoSeguranca = null)
        {
            this.Ddd = Ddd;
            this.Telefone = Telefone;
            this.CodigoSeguranca = CodigoSeguranca;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo DDD do telefone (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo DDD do telefone (id).</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do telefone.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do telefone.</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// Token para valida\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Token para valida\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="codigoSeguranca", EmitDefaultValue=false)]
        public string CodigoSeguranca { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodigoSegurancaSMSRequest {\n");
            sb.Append("  Ddd: ").Append(Ddd).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
            sb.Append("  CodigoSeguranca: ").Append(CodigoSeguranca).Append("\n");
            
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
            return this.Equals(obj as CodigoSegurancaSMSRequest);
        }

        /// <summary>
        /// Returns true if CodigoSegurancaSMSRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CodigoSegurancaSMSRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodigoSegurancaSMSRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ddd == other.Ddd ||
                    this.Ddd != null &&
                    this.Ddd.Equals(other.Ddd)
                ) && 
                (
                    this.Telefone == other.Telefone ||
                    this.Telefone != null &&
                    this.Telefone.Equals(other.Telefone)
                ) && 
                (
                    this.CodigoSeguranca == other.CodigoSeguranca ||
                    this.CodigoSeguranca != null &&
                    this.CodigoSeguranca.Equals(other.CodigoSeguranca)
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
                
                if (this.Ddd != null)
                    hash = hash * 59 + this.Ddd.GetHashCode();
                
                if (this.Telefone != null)
                    hash = hash * 59 + this.Telefone.GetHashCode();
                
                if (this.CodigoSeguranca != null)
                    hash = hash * 59 + this.CodigoSeguranca.GetHashCode();
                
                return hash;
            }
        }

    }
}
