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
    /// Objeto conta
    /// </summary>
    [DataContract]
    public partial class ContaResponse :  IEquatable<ContaResponse>
    { 
    
        /// <summary>
        /// Fun\u00E7\u00E3o ativa da conta
        /// </summary>
        /// <value>Fun\u00E7\u00E3o ativa da conta</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FuncaoAtivaEnum {
            
            [EnumMember(Value = "DEBITO_CREDITO")]
            DebitoCredito,
            
            [EnumMember(Value = "CREDITO")]
            Credito,
            
            [EnumMember(Value = "DEBITO")]
            Debito
        }

    
        /// <summary>
        /// Fun\u00E7\u00E3o ativa da conta
        /// </summary>
        /// <value>Fun\u00E7\u00E3o ativa da conta</value>
        [DataMember(Name="funcaoAtiva", EmitDefaultValue=false)]
        public FuncaoAtivaEnum? FuncaoAtiva { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaResponse" /> class.
        /// Initializes a new instance of the <see cref="ContaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de identifica\u00E7\u00E3o de conta (id).</param>
        /// <param name="IdProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id).</param>
        /// <param name="IdOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta.</param>
        /// <param name="IdPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id).</param>
        /// <param name="IdStatusConta">C\u00F3digo de Identifica\u00E7\u00E3o do status atribuido a conta.</param>
        /// <param name="DiaVencimento">Apresenta o dia de vencimento.</param>
        /// <param name="MelhorDiaCompra">Apresenta o melhor dia de compra.</param>
        /// <param name="DataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela.</param>
        /// <param name="DataCadastro">Apresenta a data em que o cart\u00E3o foi gerado.</param>
        /// <param name="DataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00E7\u00E3o de vencimento.</param>
        /// <param name="ValorRenda">Apresenta o valor da renda comprovada.</param>
        /// <param name="IdProposta">C\u00F3digo identificador da proposta.</param>
        /// <param name="FuncaoAtiva">Fun\u00E7\u00E3o ativa da conta.</param>
        /// <param name="PossuiOverLimit">Sinaliza se o OverLimit da conta est\u00E1 ativo.</param>
        /// <param name="BehaviorScore">Apresenta valor de pontua\u00E7\u00E3o de comportamento (behavior score)..</param>

        public ContaResponse(long? Id = null, long? IdProduto = null, long? IdOrigemComercial = null, long? IdPessoa = null, long? IdStatusConta = null, int? DiaVencimento = null, int? MelhorDiaCompra = null, string DataStatusConta = null, string DataCadastro = null, string DataUltimaAlteracaoVencimento = null, double? ValorRenda = null, long? IdProposta = null, FuncaoAtivaEnum? FuncaoAtiva = null, bool? PossuiOverLimit = null, int? BehaviorScore = null)
        {
            this.Id = Id;
            this.IdProduto = IdProduto;
            this.IdOrigemComercial = IdOrigemComercial;
            this.IdPessoa = IdPessoa;
            this.IdStatusConta = IdStatusConta;
            this.DiaVencimento = DiaVencimento;
            this.MelhorDiaCompra = MelhorDiaCompra;
            this.DataStatusConta = DataStatusConta;
            this.DataCadastro = DataCadastro;
            this.DataUltimaAlteracaoVencimento = DataUltimaAlteracaoVencimento;
            this.ValorRenda = ValorRenda;
            this.IdProposta = IdProposta;
            this.FuncaoAtiva = FuncaoAtiva;
            this.PossuiOverLimit = PossuiOverLimit;
            this.BehaviorScore = BehaviorScore;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o de conta (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o de conta (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id)</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id)</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do status atribuido a conta
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do status atribuido a conta</value>
        [DataMember(Name="idStatusConta", EmitDefaultValue=false)]
        public long? IdStatusConta { get; set; }
    
        /// <summary>
        /// Apresenta o dia de vencimento
        /// </summary>
        /// <value>Apresenta o dia de vencimento</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// Apresenta o melhor dia de compra
        /// </summary>
        /// <value>Apresenta o melhor dia de compra</value>
        [DataMember(Name="melhorDiaCompra", EmitDefaultValue=false)]
        public int? MelhorDiaCompra { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela
        /// </summary>
        /// <value>Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela</value>
        [DataMember(Name="dataStatusConta", EmitDefaultValue=false)]
        public string DataStatusConta { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o cart\u00E3o foi gerado
        /// </summary>
        /// <value>Apresenta a data em que o cart\u00E3o foi gerado</value>
        [DataMember(Name="dataCadastro", EmitDefaultValue=false)]
        public string DataCadastro { get; set; }
    
        /// <summary>
        /// Apresenta a data da ultima altera\u00E7\u00E3o de vencimento
        /// </summary>
        /// <value>Apresenta a data da ultima altera\u00E7\u00E3o de vencimento</value>
        [DataMember(Name="dataUltimaAlteracaoVencimento", EmitDefaultValue=false)]
        public string DataUltimaAlteracaoVencimento { get; set; }
    
        /// <summary>
        /// Apresenta o valor da renda comprovada
        /// </summary>
        /// <value>Apresenta o valor da renda comprovada</value>
        [DataMember(Name="valorRenda", EmitDefaultValue=false)]
        public double? ValorRenda { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da proposta
        /// </summary>
        /// <value>C\u00F3digo identificador da proposta</value>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public long? IdProposta { get; set; }
    
        /// <summary>
        /// Sinaliza se o OverLimit da conta est\u00E1 ativo
        /// </summary>
        /// <value>Sinaliza se o OverLimit da conta est\u00E1 ativo</value>
        [DataMember(Name="possuiOverLimit", EmitDefaultValue=false)]
        public bool? PossuiOverLimit { get; set; }
    
        /// <summary>
        /// Apresenta valor de pontua\u00E7\u00E3o de comportamento (behavior score).
        /// </summary>
        /// <value>Apresenta valor de pontua\u00E7\u00E3o de comportamento (behavior score).</value>
        [DataMember(Name="behaviorScore", EmitDefaultValue=false)]
        public int? BehaviorScore { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdStatusConta: ").Append(IdStatusConta).Append("\n");
            sb.Append("  DiaVencimento: ").Append(DiaVencimento).Append("\n");
            sb.Append("  MelhorDiaCompra: ").Append(MelhorDiaCompra).Append("\n");
            sb.Append("  DataStatusConta: ").Append(DataStatusConta).Append("\n");
            sb.Append("  DataCadastro: ").Append(DataCadastro).Append("\n");
            sb.Append("  DataUltimaAlteracaoVencimento: ").Append(DataUltimaAlteracaoVencimento).Append("\n");
            sb.Append("  ValorRenda: ").Append(ValorRenda).Append("\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            sb.Append("  FuncaoAtiva: ").Append(FuncaoAtiva).Append("\n");
            sb.Append("  PossuiOverLimit: ").Append(PossuiOverLimit).Append("\n");
            sb.Append("  BehaviorScore: ").Append(BehaviorScore).Append("\n");
            
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
            return this.Equals(obj as ContaResponse);
        }

        /// <summary>
        /// Returns true if ContaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaResponse other)
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
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdStatusConta == other.IdStatusConta ||
                    this.IdStatusConta != null &&
                    this.IdStatusConta.Equals(other.IdStatusConta)
                ) && 
                (
                    this.DiaVencimento == other.DiaVencimento ||
                    this.DiaVencimento != null &&
                    this.DiaVencimento.Equals(other.DiaVencimento)
                ) && 
                (
                    this.MelhorDiaCompra == other.MelhorDiaCompra ||
                    this.MelhorDiaCompra != null &&
                    this.MelhorDiaCompra.Equals(other.MelhorDiaCompra)
                ) && 
                (
                    this.DataStatusConta == other.DataStatusConta ||
                    this.DataStatusConta != null &&
                    this.DataStatusConta.Equals(other.DataStatusConta)
                ) && 
                (
                    this.DataCadastro == other.DataCadastro ||
                    this.DataCadastro != null &&
                    this.DataCadastro.Equals(other.DataCadastro)
                ) && 
                (
                    this.DataUltimaAlteracaoVencimento == other.DataUltimaAlteracaoVencimento ||
                    this.DataUltimaAlteracaoVencimento != null &&
                    this.DataUltimaAlteracaoVencimento.Equals(other.DataUltimaAlteracaoVencimento)
                ) && 
                (
                    this.ValorRenda == other.ValorRenda ||
                    this.ValorRenda != null &&
                    this.ValorRenda.Equals(other.ValorRenda)
                ) && 
                (
                    this.IdProposta == other.IdProposta ||
                    this.IdProposta != null &&
                    this.IdProposta.Equals(other.IdProposta)
                ) && 
                (
                    this.FuncaoAtiva == other.FuncaoAtiva ||
                    this.FuncaoAtiva != null &&
                    this.FuncaoAtiva.Equals(other.FuncaoAtiva)
                ) && 
                (
                    this.PossuiOverLimit == other.PossuiOverLimit ||
                    this.PossuiOverLimit != null &&
                    this.PossuiOverLimit.Equals(other.PossuiOverLimit)
                ) && 
                (
                    this.BehaviorScore == other.BehaviorScore ||
                    this.BehaviorScore != null &&
                    this.BehaviorScore.Equals(other.BehaviorScore)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdStatusConta != null)
                    hash = hash * 59 + this.IdStatusConta.GetHashCode();
                
                if (this.DiaVencimento != null)
                    hash = hash * 59 + this.DiaVencimento.GetHashCode();
                
                if (this.MelhorDiaCompra != null)
                    hash = hash * 59 + this.MelhorDiaCompra.GetHashCode();
                
                if (this.DataStatusConta != null)
                    hash = hash * 59 + this.DataStatusConta.GetHashCode();
                
                if (this.DataCadastro != null)
                    hash = hash * 59 + this.DataCadastro.GetHashCode();
                
                if (this.DataUltimaAlteracaoVencimento != null)
                    hash = hash * 59 + this.DataUltimaAlteracaoVencimento.GetHashCode();
                
                if (this.ValorRenda != null)
                    hash = hash * 59 + this.ValorRenda.GetHashCode();
                
                if (this.IdProposta != null)
                    hash = hash * 59 + this.IdProposta.GetHashCode();
                
                if (this.FuncaoAtiva != null)
                    hash = hash * 59 + this.FuncaoAtiva.GetHashCode();
                
                if (this.PossuiOverLimit != null)
                    hash = hash * 59 + this.PossuiOverLimit.GetHashCode();
                
                if (this.BehaviorScore != null)
                    hash = hash * 59 + this.BehaviorScore.GetHashCode();
                
                return hash;
            }
        }

    }
}
