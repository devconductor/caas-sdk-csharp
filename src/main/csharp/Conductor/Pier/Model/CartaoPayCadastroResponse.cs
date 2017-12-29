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
    /// Resposta da requisi\u00C3\u00A7\u00C3\u00A3o para cadastro de cart\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class CartaoPayCadastroResponse :  IEquatable<CartaoPayCadastroResponse>
    { 
    
        /// <summary>
        /// Status do cart\u00C3\u00A3o
        /// </summary>
        /// <value>Status do cart\u00C3\u00A3o</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "ATIVO")]
            Ativo,
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "BLOQUEADO")]
            Bloqueado
        }

    
        /// <summary>
        /// Status do cart\u00C3\u00A3o
        /// </summary>
        /// <value>Status do cart\u00C3\u00A3o</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoPayCadastroResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoPayCadastroResponse" />class.
        /// </summary>
        /// <param name="Id">Id do cart\u00C3\u00A3o.</param>
        /// <param name="NumeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o real criptografado.</param>
        /// <param name="DataValidadeCartao">Data de validade do cart\u00C3\u00A3o.</param>
        /// <param name="NomeImpresso">Nome impresso no cart\u00C3\u00A3o criptografado.</param>
        /// <param name="IdEntidade">Identificador do emissor do cart\u00C3\u00A3o.</param>
        /// <param name="NomeEntidade">Nome do emissor do cart\u00C3\u00A3o.</param>
        /// <param name="Status">Status do cart\u00C3\u00A3o.</param>
        /// <param name="DataValidadeChaveCriptograma">Data de validade da chave do criptograma.</param>
        /// <param name="Cvv">CVV do cart\u00C3\u00A3o criptografado.</param>
        /// <param name="ChaveCriptograma">Chave de gera\u00C3\u00A7\u00C3\u00A3o de criptograma criptografada.</param>

        public CartaoPayCadastroResponse(long? Id = null, string NumeroCartao = null, string DataValidadeCartao = null, string NomeImpresso = null, long? IdEntidade = null, string NomeEntidade = null, StatusEnum? Status = null, string DataValidadeChaveCriptograma = null, string Cvv = null, string ChaveCriptograma = null)
        {
            this.Id = Id;
            this.NumeroCartao = NumeroCartao;
            this.DataValidadeCartao = DataValidadeCartao;
            this.NomeImpresso = NomeImpresso;
            this.IdEntidade = IdEntidade;
            this.NomeEntidade = NomeEntidade;
            this.Status = Status;
            this.DataValidadeChaveCriptograma = DataValidadeChaveCriptograma;
            this.Cvv = Cvv;
            this.ChaveCriptograma = ChaveCriptograma;
            
        }
        
    
        /// <summary>
        /// Id do cart\u00C3\u00A3o
        /// </summary>
        /// <value>Id do cart\u00C3\u00A3o</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do cart\u00C3\u00A3o real criptografado
        /// </summary>
        /// <value>N\u00C3\u00BAmero do cart\u00C3\u00A3o real criptografado</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Data de validade do cart\u00C3\u00A3o
        /// </summary>
        /// <value>Data de validade do cart\u00C3\u00A3o</value>
        [DataMember(Name="dataValidadeCartao", EmitDefaultValue=false)]
        public string DataValidadeCartao { get; set; }
    
        /// <summary>
        /// Nome impresso no cart\u00C3\u00A3o criptografado
        /// </summary>
        /// <value>Nome impresso no cart\u00C3\u00A3o criptografado</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Identificador do emissor do cart\u00C3\u00A3o
        /// </summary>
        /// <value>Identificador do emissor do cart\u00C3\u00A3o</value>
        [DataMember(Name="idEntidade", EmitDefaultValue=false)]
        public long? IdEntidade { get; set; }
    
        /// <summary>
        /// Nome do emissor do cart\u00C3\u00A3o
        /// </summary>
        /// <value>Nome do emissor do cart\u00C3\u00A3o</value>
        [DataMember(Name="nomeEntidade", EmitDefaultValue=false)]
        public string NomeEntidade { get; set; }
    
        /// <summary>
        /// Data de validade da chave do criptograma
        /// </summary>
        /// <value>Data de validade da chave do criptograma</value>
        [DataMember(Name="dataValidadeChaveCriptograma", EmitDefaultValue=false)]
        public string DataValidadeChaveCriptograma { get; set; }
    
        /// <summary>
        /// CVV do cart\u00C3\u00A3o criptografado
        /// </summary>
        /// <value>CVV do cart\u00C3\u00A3o criptografado</value>
        [DataMember(Name="cvv", EmitDefaultValue=false)]
        public string Cvv { get; set; }
    
        /// <summary>
        /// Chave de gera\u00C3\u00A7\u00C3\u00A3o de criptograma criptografada
        /// </summary>
        /// <value>Chave de gera\u00C3\u00A7\u00C3\u00A3o de criptograma criptografada</value>
        [DataMember(Name="chaveCriptograma", EmitDefaultValue=false)]
        public string ChaveCriptograma { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoPayCadastroResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  DataValidadeCartao: ").Append(DataValidadeCartao).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  IdEntidade: ").Append(IdEntidade).Append("\n");
            sb.Append("  NomeEntidade: ").Append(NomeEntidade).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataValidadeChaveCriptograma: ").Append(DataValidadeChaveCriptograma).Append("\n");
            sb.Append("  Cvv: ").Append(Cvv).Append("\n");
            sb.Append("  ChaveCriptograma: ").Append(ChaveCriptograma).Append("\n");
            
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
            return this.Equals(obj as CartaoPayCadastroResponse);
        }

        /// <summary>
        /// Returns true if CartaoPayCadastroResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoPayCadastroResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoPayCadastroResponse other)
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
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.DataValidadeCartao == other.DataValidadeCartao ||
                    this.DataValidadeCartao != null &&
                    this.DataValidadeCartao.Equals(other.DataValidadeCartao)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.IdEntidade == other.IdEntidade ||
                    this.IdEntidade != null &&
                    this.IdEntidade.Equals(other.IdEntidade)
                ) && 
                (
                    this.NomeEntidade == other.NomeEntidade ||
                    this.NomeEntidade != null &&
                    this.NomeEntidade.Equals(other.NomeEntidade)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.DataValidadeChaveCriptograma == other.DataValidadeChaveCriptograma ||
                    this.DataValidadeChaveCriptograma != null &&
                    this.DataValidadeChaveCriptograma.Equals(other.DataValidadeChaveCriptograma)
                ) && 
                (
                    this.Cvv == other.Cvv ||
                    this.Cvv != null &&
                    this.Cvv.Equals(other.Cvv)
                ) && 
                (
                    this.ChaveCriptograma == other.ChaveCriptograma ||
                    this.ChaveCriptograma != null &&
                    this.ChaveCriptograma.Equals(other.ChaveCriptograma)
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
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.DataValidadeCartao != null)
                    hash = hash * 59 + this.DataValidadeCartao.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.IdEntidade != null)
                    hash = hash * 59 + this.IdEntidade.GetHashCode();
                
                if (this.NomeEntidade != null)
                    hash = hash * 59 + this.NomeEntidade.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DataValidadeChaveCriptograma != null)
                    hash = hash * 59 + this.DataValidadeChaveCriptograma.GetHashCode();
                
                if (this.Cvv != null)
                    hash = hash * 59 + this.Cvv.GetHashCode();
                
                if (this.ChaveCriptograma != null)
                    hash = hash * 59 + this.ChaveCriptograma.GetHashCode();
                
                return hash;
            }
        }

    }
}
