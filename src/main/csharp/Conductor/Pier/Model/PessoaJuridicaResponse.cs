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
    public partial class PessoaJuridicaResponse :  IEquatable<PessoaJuridicaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaJuridicaResponse" /> class.
        /// Initializes a new instance of the <see cref="PessoaJuridicaResponse" />class.
        /// </summary>
        /// <param name="Id">{{{pessoa_juridica_persist_id_value}}}.</param>
        /// <param name="Contato">{{{pessoa_juridica_persist_contato_value}}}.</param>
        /// <param name="RazaoSocial">{{{pessoa_juridica_persist_razao_social_value}}}.</param>
        /// <param name="NumeroReceitaFederal">{{{pessoa_juridica_persist_CGC_value}}}.</param>
        /// <param name="InscricaoEstadual">{{{pessoa_juridica_persist_inscricao_estadual_value}}}.</param>
        /// <param name="Banco">{{{pessoa_juridica_persist_banco_value}}}.</param>
        /// <param name="Agencia">{{{pessoa_juridica_persist_agencia_value}}}.</param>
        /// <param name="DigitoAgencia">{{{pessoa_juridica_persist_digito_agencia_value}}}.</param>
        /// <param name="ContaCorrente">{{{pessoa_juridica_persist_conta_corrente_value}}}.</param>
        /// <param name="DigitoContaCorrente">{{{pessoa_juridica_persist_digito_conta_corrente_value}}}.</param>

        public PessoaJuridicaResponse(long? Id = null, string Contato = null, string RazaoSocial = null, string NumeroReceitaFederal = null, string InscricaoEstadual = null, int? Banco = null, int? Agencia = null, string DigitoAgencia = null, string ContaCorrente = null, string DigitoContaCorrente = null)
        {
            this.Id = Id;
            this.Contato = Contato;
            this.RazaoSocial = RazaoSocial;
            this.NumeroReceitaFederal = NumeroReceitaFederal;
            this.InscricaoEstadual = InscricaoEstadual;
            this.Banco = Banco;
            this.Agencia = Agencia;
            this.DigitoAgencia = DigitoAgencia;
            this.ContaCorrente = ContaCorrente;
            this.DigitoContaCorrente = DigitoContaCorrente;
            
        }
        
    
        /// <summary>
        /// {{{pessoa_juridica_persist_id_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_persist_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_persist_contato_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_persist_contato_value}}}</value>
        [DataMember(Name="contato", EmitDefaultValue=false)]
        public string Contato { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_persist_razao_social_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_persist_razao_social_value}}}</value>
        [DataMember(Name="razaoSocial", EmitDefaultValue=false)]
        public string RazaoSocial { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_persist_CGC_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_persist_CGC_value}}}</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_persist_inscricao_estadual_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_persist_inscricao_estadual_value}}}</value>
        [DataMember(Name="inscricaoEstadual", EmitDefaultValue=false)]
        public string InscricaoEstadual { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_persist_banco_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_persist_banco_value}}}</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public int? Banco { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_persist_agencia_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_persist_agencia_value}}}</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public int? Agencia { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_persist_digito_agencia_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_persist_digito_agencia_value}}}</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_persist_conta_corrente_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_persist_conta_corrente_value}}}</value>
        [DataMember(Name="contaCorrente", EmitDefaultValue=false)]
        public string ContaCorrente { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_persist_digito_conta_corrente_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_persist_digito_conta_corrente_value}}}</value>
        [DataMember(Name="digitoContaCorrente", EmitDefaultValue=false)]
        public string DigitoContaCorrente { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaJuridicaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Contato: ").Append(Contato).Append("\n");
            sb.Append("  RazaoSocial: ").Append(RazaoSocial).Append("\n");
            sb.Append("  NumeroReceitaFederal: ").Append(NumeroReceitaFederal).Append("\n");
            sb.Append("  InscricaoEstadual: ").Append(InscricaoEstadual).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  Agencia: ").Append(Agencia).Append("\n");
            sb.Append("  DigitoAgencia: ").Append(DigitoAgencia).Append("\n");
            sb.Append("  ContaCorrente: ").Append(ContaCorrente).Append("\n");
            sb.Append("  DigitoContaCorrente: ").Append(DigitoContaCorrente).Append("\n");
            
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
            return this.Equals(obj as PessoaJuridicaResponse);
        }

        /// <summary>
        /// Returns true if PessoaJuridicaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaJuridicaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaJuridicaResponse other)
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
                    this.Contato == other.Contato ||
                    this.Contato != null &&
                    this.Contato.Equals(other.Contato)
                ) && 
                (
                    this.RazaoSocial == other.RazaoSocial ||
                    this.RazaoSocial != null &&
                    this.RazaoSocial.Equals(other.RazaoSocial)
                ) && 
                (
                    this.NumeroReceitaFederal == other.NumeroReceitaFederal ||
                    this.NumeroReceitaFederal != null &&
                    this.NumeroReceitaFederal.Equals(other.NumeroReceitaFederal)
                ) && 
                (
                    this.InscricaoEstadual == other.InscricaoEstadual ||
                    this.InscricaoEstadual != null &&
                    this.InscricaoEstadual.Equals(other.InscricaoEstadual)
                ) && 
                (
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.Agencia == other.Agencia ||
                    this.Agencia != null &&
                    this.Agencia.Equals(other.Agencia)
                ) && 
                (
                    this.DigitoAgencia == other.DigitoAgencia ||
                    this.DigitoAgencia != null &&
                    this.DigitoAgencia.Equals(other.DigitoAgencia)
                ) && 
                (
                    this.ContaCorrente == other.ContaCorrente ||
                    this.ContaCorrente != null &&
                    this.ContaCorrente.Equals(other.ContaCorrente)
                ) && 
                (
                    this.DigitoContaCorrente == other.DigitoContaCorrente ||
                    this.DigitoContaCorrente != null &&
                    this.DigitoContaCorrente.Equals(other.DigitoContaCorrente)
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
                
                if (this.Contato != null)
                    hash = hash * 59 + this.Contato.GetHashCode();
                
                if (this.RazaoSocial != null)
                    hash = hash * 59 + this.RazaoSocial.GetHashCode();
                
                if (this.NumeroReceitaFederal != null)
                    hash = hash * 59 + this.NumeroReceitaFederal.GetHashCode();
                
                if (this.InscricaoEstadual != null)
                    hash = hash * 59 + this.InscricaoEstadual.GetHashCode();
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.Agencia != null)
                    hash = hash * 59 + this.Agencia.GetHashCode();
                
                if (this.DigitoAgencia != null)
                    hash = hash * 59 + this.DigitoAgencia.GetHashCode();
                
                if (this.ContaCorrente != null)
                    hash = hash * 59 + this.ContaCorrente.GetHashCode();
                
                if (this.DigitoContaCorrente != null)
                    hash = hash * 59 + this.DigitoContaCorrente.GetHashCode();
                
                return hash;
            }
        }

    }
}
