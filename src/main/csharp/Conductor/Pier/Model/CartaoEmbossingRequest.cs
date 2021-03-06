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
    /// Parametros de requisi\u00E7\u00E3o da gera\u00E7\u00E3o do cart\u00E3o embossing
    /// </summary>
    [DataContract]
    public partial class CartaoEmbossingRequest :  IEquatable<CartaoEmbossingRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoEmbossingRequest" /> class.
        /// Initializes a new instance of the <see cref="CartaoEmbossingRequest" />class.
        /// </summary>
        /// <param name="IdPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence (id).</param>
        /// <param name="IdTipoPlastico">C\u00F3digo de identifica\u00E7\u00E3o do TipoPlastico (id).</param>
        /// <param name="IdImagem">C\u00F3digo de identifica\u00E7\u00E3o da imagem (id).</param>
        /// <param name="IdMifare">C\u00F3digo identificador da tecnologia MIFARE.</param>
        /// <param name="MatriculaMifare">N\u00FAmero da matricula do portador.</param>

        public CartaoEmbossingRequest(long? IdPessoa = null, long? IdTipoPlastico = null, long? IdImagem = null, long? IdMifare = null, string MatriculaMifare = null)
        {
            this.IdPessoa = IdPessoa;
            this.IdTipoPlastico = IdTipoPlastico;
            this.IdImagem = IdImagem;
            this.IdMifare = IdMifare;
            this.MatriculaMifare = MatriculaMifare;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o cart\u00E3o pertence (id)</value>
        [DataMember(Name="id_pessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do TipoPlastico (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do TipoPlastico (id)</value>
        [DataMember(Name="id_tipo_plastico", EmitDefaultValue=false)]
        public long? IdTipoPlastico { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da imagem (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da imagem (id)</value>
        [DataMember(Name="idImagem", EmitDefaultValue=false)]
        public long? IdImagem { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da tecnologia MIFARE
        /// </summary>
        /// <value>C\u00F3digo identificador da tecnologia MIFARE</value>
        [DataMember(Name="idMifare", EmitDefaultValue=false)]
        public long? IdMifare { get; set; }
    
        /// <summary>
        /// N\u00FAmero da matricula do portador
        /// </summary>
        /// <value>N\u00FAmero da matricula do portador</value>
        [DataMember(Name="matriculaMifare", EmitDefaultValue=false)]
        public string MatriculaMifare { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoEmbossingRequest {\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdTipoPlastico: ").Append(IdTipoPlastico).Append("\n");
            sb.Append("  IdImagem: ").Append(IdImagem).Append("\n");
            sb.Append("  IdMifare: ").Append(IdMifare).Append("\n");
            sb.Append("  MatriculaMifare: ").Append(MatriculaMifare).Append("\n");
            
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
            return this.Equals(obj as CartaoEmbossingRequest);
        }

        /// <summary>
        /// Returns true if CartaoEmbossingRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoEmbossingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoEmbossingRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdTipoPlastico == other.IdTipoPlastico ||
                    this.IdTipoPlastico != null &&
                    this.IdTipoPlastico.Equals(other.IdTipoPlastico)
                ) && 
                (
                    this.IdImagem == other.IdImagem ||
                    this.IdImagem != null &&
                    this.IdImagem.Equals(other.IdImagem)
                ) && 
                (
                    this.IdMifare == other.IdMifare ||
                    this.IdMifare != null &&
                    this.IdMifare.Equals(other.IdMifare)
                ) && 
                (
                    this.MatriculaMifare == other.MatriculaMifare ||
                    this.MatriculaMifare != null &&
                    this.MatriculaMifare.Equals(other.MatriculaMifare)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdTipoPlastico != null)
                    hash = hash * 59 + this.IdTipoPlastico.GetHashCode();
                
                if (this.IdImagem != null)
                    hash = hash * 59 + this.IdImagem.GetHashCode();
                
                if (this.IdMifare != null)
                    hash = hash * 59 + this.IdMifare.GetHashCode();
                
                if (this.MatriculaMifare != null)
                    hash = hash * 59 + this.MatriculaMifare.GetHashCode();
                
                return hash;
            }
        }

    }
}
