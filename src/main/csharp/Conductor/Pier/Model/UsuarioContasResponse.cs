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
    /// {{{usuario_conta_resposta_descricao}}}
    /// </summary>
    [DataContract]
    public partial class UsuarioContasResponse :  IEquatable<UsuarioContasResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioContasResponse" /> class.
        /// Initializes a new instance of the <see cref="UsuarioContasResponse" />class.
        /// </summary>
        /// <param name="Id">{{{usuario_conta_resposta_id_descricao}}}.</param>
        /// <param name="IdConta">{{{usuario_conta_resposta_id_conta_descricao}}}.</param>
        /// <param name="IdPessoa">{{{usuario_conta_resposta_id_pessoa_descricao}}}.</param>
        /// <param name="IdUsuario">{{{usuario_conta_resposta_id_usuario_descricao}}}.</param>
        /// <param name="NivelAcesso">{{{usuario_conta_resposta_nivel_acesso_descricao}}}.</param>

        public UsuarioContasResponse(long? Id = null, long? IdConta = null, long? IdPessoa = null, long? IdUsuario = null, int? NivelAcesso = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.IdPessoa = IdPessoa;
            this.IdUsuario = IdUsuario;
            this.NivelAcesso = NivelAcesso;
            
        }
        
    
        /// <summary>
        /// {{{usuario_conta_resposta_id_descricao}}}
        /// </summary>
        /// <value>{{{usuario_conta_resposta_id_descricao}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{usuario_conta_resposta_id_conta_descricao}}}
        /// </summary>
        /// <value>{{{usuario_conta_resposta_id_conta_descricao}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{usuario_conta_resposta_id_pessoa_descricao}}}
        /// </summary>
        /// <value>{{{usuario_conta_resposta_id_pessoa_descricao}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{usuario_conta_resposta_id_usuario_descricao}}}
        /// </summary>
        /// <value>{{{usuario_conta_resposta_id_usuario_descricao}}}</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// {{{usuario_conta_resposta_nivel_acesso_descricao}}}
        /// </summary>
        /// <value>{{{usuario_conta_resposta_nivel_acesso_descricao}}}</value>
        [DataMember(Name="nivelAcesso", EmitDefaultValue=false)]
        public int? NivelAcesso { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsuarioContasResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdUsuario: ").Append(IdUsuario).Append("\n");
            sb.Append("  NivelAcesso: ").Append(NivelAcesso).Append("\n");
            
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
            return this.Equals(obj as UsuarioContasResponse);
        }

        /// <summary>
        /// Returns true if UsuarioContasResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UsuarioContasResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsuarioContasResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdUsuario == other.IdUsuario ||
                    this.IdUsuario != null &&
                    this.IdUsuario.Equals(other.IdUsuario)
                ) && 
                (
                    this.NivelAcesso == other.NivelAcesso ||
                    this.NivelAcesso != null &&
                    this.NivelAcesso.Equals(other.NivelAcesso)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdUsuario != null)
                    hash = hash * 59 + this.IdUsuario.GetHashCode();
                
                if (this.NivelAcesso != null)
                    hash = hash * 59 + this.NivelAcesso.GetHashCode();
                
                return hash;
            }
        }

    }
}