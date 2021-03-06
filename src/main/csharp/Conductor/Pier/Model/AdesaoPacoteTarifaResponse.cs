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
    /// Representa\u00E7\u00E3o do recurso Ades\u00E3o Pacote Tarifa
    /// </summary>
    [DataContract]
    public partial class AdesaoPacoteTarifaResponse :  IEquatable<AdesaoPacoteTarifaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdesaoPacoteTarifaResponse" /> class.
        /// Initializes a new instance of the <see cref="AdesaoPacoteTarifaResponse" />class.
        /// </summary>
        /// <param name="AplicacaoUtilizado">Aplica\u00E7\u00E3o utilizado.</param>
        /// <param name="BilheteUnicoUtilizado">Bilhete \u00FAnico utilizado.</param>
        /// <param name="BoletoUtilizado">Boleto utilizado.</param>
        /// <param name="Ciclo">Ciclo da ades\u00E3o.</param>
        /// <param name="CobraTarifa">Tarifa cobrada.</param>
        /// <param name="DataFimCiclo">Data fim do ciclo.</param>
        /// <param name="DataHoraAtivacao">Data da ativa\u00E7\u00E3o.</param>
        /// <param name="DataHoraDesativacao">Data da desativa\u00E7\u00E3o.</param>
        /// <param name="Id">Id da ades\u00E3o.</param>
        /// <param name="IdConta">Id da conta.</param>
        /// <param name="PacoteTarifa">Pacote de tarifa.</param>
        /// <param name="PagamentoContaUtilizado">Pagamento de conta utilizado.</param>
        /// <param name="RecargaCelularUtilizado">Recarga de celular utilizado.</param>
        /// <param name="SaqueUtilizado">Saque utilizado.</param>
        /// <param name="TarifaManutencaoCobrada">Tarifa manuten\u00E7\u00E3o cobrada.</param>
        /// <param name="TransferenciaUtilizado">Transfer\u00EAncia utilizado.</param>

        public AdesaoPacoteTarifaResponse(int? AplicacaoUtilizado = null, int? BilheteUnicoUtilizado = null, int? BoletoUtilizado = null, int? Ciclo = null, bool? CobraTarifa = null, string DataFimCiclo = null, string DataHoraAtivacao = null, string DataHoraDesativacao = null, long? Id = null, long? IdConta = null, PacoteTarifaResponse PacoteTarifa = null, int? PagamentoContaUtilizado = null, int? RecargaCelularUtilizado = null, int? SaqueUtilizado = null, bool? TarifaManutencaoCobrada = null, int? TransferenciaUtilizado = null)
        {
            this.AplicacaoUtilizado = AplicacaoUtilizado;
            this.BilheteUnicoUtilizado = BilheteUnicoUtilizado;
            this.BoletoUtilizado = BoletoUtilizado;
            this.Ciclo = Ciclo;
            this.CobraTarifa = CobraTarifa;
            this.DataFimCiclo = DataFimCiclo;
            this.DataHoraAtivacao = DataHoraAtivacao;
            this.DataHoraDesativacao = DataHoraDesativacao;
            this.Id = Id;
            this.IdConta = IdConta;
            this.PacoteTarifa = PacoteTarifa;
            this.PagamentoContaUtilizado = PagamentoContaUtilizado;
            this.RecargaCelularUtilizado = RecargaCelularUtilizado;
            this.SaqueUtilizado = SaqueUtilizado;
            this.TarifaManutencaoCobrada = TarifaManutencaoCobrada;
            this.TransferenciaUtilizado = TransferenciaUtilizado;
            
        }
        
    
        /// <summary>
        /// Aplica\u00E7\u00E3o utilizado
        /// </summary>
        /// <value>Aplica\u00E7\u00E3o utilizado</value>
        [DataMember(Name="aplicacaoUtilizado", EmitDefaultValue=false)]
        public int? AplicacaoUtilizado { get; set; }
    
        /// <summary>
        /// Bilhete \u00FAnico utilizado
        /// </summary>
        /// <value>Bilhete \u00FAnico utilizado</value>
        [DataMember(Name="bilheteUnicoUtilizado", EmitDefaultValue=false)]
        public int? BilheteUnicoUtilizado { get; set; }
    
        /// <summary>
        /// Boleto utilizado
        /// </summary>
        /// <value>Boleto utilizado</value>
        [DataMember(Name="boletoUtilizado", EmitDefaultValue=false)]
        public int? BoletoUtilizado { get; set; }
    
        /// <summary>
        /// Ciclo da ades\u00E3o
        /// </summary>
        /// <value>Ciclo da ades\u00E3o</value>
        [DataMember(Name="ciclo", EmitDefaultValue=false)]
        public int? Ciclo { get; set; }
    
        /// <summary>
        /// Tarifa cobrada
        /// </summary>
        /// <value>Tarifa cobrada</value>
        [DataMember(Name="cobraTarifa", EmitDefaultValue=false)]
        public bool? CobraTarifa { get; set; }
    
        /// <summary>
        /// Data fim do ciclo
        /// </summary>
        /// <value>Data fim do ciclo</value>
        [DataMember(Name="dataFimCiclo", EmitDefaultValue=false)]
        public string DataFimCiclo { get; set; }
    
        /// <summary>
        /// Data da ativa\u00E7\u00E3o
        /// </summary>
        /// <value>Data da ativa\u00E7\u00E3o</value>
        [DataMember(Name="dataHoraAtivacao", EmitDefaultValue=false)]
        public string DataHoraAtivacao { get; set; }
    
        /// <summary>
        /// Data da desativa\u00E7\u00E3o
        /// </summary>
        /// <value>Data da desativa\u00E7\u00E3o</value>
        [DataMember(Name="dataHoraDesativacao", EmitDefaultValue=false)]
        public string DataHoraDesativacao { get; set; }
    
        /// <summary>
        /// Id da ades\u00E3o
        /// </summary>
        /// <value>Id da ades\u00E3o</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Id da conta
        /// </summary>
        /// <value>Id da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Pacote de tarifa
        /// </summary>
        /// <value>Pacote de tarifa</value>
        [DataMember(Name="pacoteTarifa", EmitDefaultValue=false)]
        public PacoteTarifaResponse PacoteTarifa { get; set; }
    
        /// <summary>
        /// Pagamento de conta utilizado
        /// </summary>
        /// <value>Pagamento de conta utilizado</value>
        [DataMember(Name="pagamentoContaUtilizado", EmitDefaultValue=false)]
        public int? PagamentoContaUtilizado { get; set; }
    
        /// <summary>
        /// Recarga de celular utilizado
        /// </summary>
        /// <value>Recarga de celular utilizado</value>
        [DataMember(Name="recargaCelularUtilizado", EmitDefaultValue=false)]
        public int? RecargaCelularUtilizado { get; set; }
    
        /// <summary>
        /// Saque utilizado
        /// </summary>
        /// <value>Saque utilizado</value>
        [DataMember(Name="saqueUtilizado", EmitDefaultValue=false)]
        public int? SaqueUtilizado { get; set; }
    
        /// <summary>
        /// Tarifa manuten\u00E7\u00E3o cobrada
        /// </summary>
        /// <value>Tarifa manuten\u00E7\u00E3o cobrada</value>
        [DataMember(Name="tarifaManutencaoCobrada", EmitDefaultValue=false)]
        public bool? TarifaManutencaoCobrada { get; set; }
    
        /// <summary>
        /// Transfer\u00EAncia utilizado
        /// </summary>
        /// <value>Transfer\u00EAncia utilizado</value>
        [DataMember(Name="transferenciaUtilizado", EmitDefaultValue=false)]
        public int? TransferenciaUtilizado { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdesaoPacoteTarifaResponse {\n");
            sb.Append("  AplicacaoUtilizado: ").Append(AplicacaoUtilizado).Append("\n");
            sb.Append("  BilheteUnicoUtilizado: ").Append(BilheteUnicoUtilizado).Append("\n");
            sb.Append("  BoletoUtilizado: ").Append(BoletoUtilizado).Append("\n");
            sb.Append("  Ciclo: ").Append(Ciclo).Append("\n");
            sb.Append("  CobraTarifa: ").Append(CobraTarifa).Append("\n");
            sb.Append("  DataFimCiclo: ").Append(DataFimCiclo).Append("\n");
            sb.Append("  DataHoraAtivacao: ").Append(DataHoraAtivacao).Append("\n");
            sb.Append("  DataHoraDesativacao: ").Append(DataHoraDesativacao).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  PacoteTarifa: ").Append(PacoteTarifa).Append("\n");
            sb.Append("  PagamentoContaUtilizado: ").Append(PagamentoContaUtilizado).Append("\n");
            sb.Append("  RecargaCelularUtilizado: ").Append(RecargaCelularUtilizado).Append("\n");
            sb.Append("  SaqueUtilizado: ").Append(SaqueUtilizado).Append("\n");
            sb.Append("  TarifaManutencaoCobrada: ").Append(TarifaManutencaoCobrada).Append("\n");
            sb.Append("  TransferenciaUtilizado: ").Append(TransferenciaUtilizado).Append("\n");
            
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
            return this.Equals(obj as AdesaoPacoteTarifaResponse);
        }

        /// <summary>
        /// Returns true if AdesaoPacoteTarifaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AdesaoPacoteTarifaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdesaoPacoteTarifaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AplicacaoUtilizado == other.AplicacaoUtilizado ||
                    this.AplicacaoUtilizado != null &&
                    this.AplicacaoUtilizado.Equals(other.AplicacaoUtilizado)
                ) && 
                (
                    this.BilheteUnicoUtilizado == other.BilheteUnicoUtilizado ||
                    this.BilheteUnicoUtilizado != null &&
                    this.BilheteUnicoUtilizado.Equals(other.BilheteUnicoUtilizado)
                ) && 
                (
                    this.BoletoUtilizado == other.BoletoUtilizado ||
                    this.BoletoUtilizado != null &&
                    this.BoletoUtilizado.Equals(other.BoletoUtilizado)
                ) && 
                (
                    this.Ciclo == other.Ciclo ||
                    this.Ciclo != null &&
                    this.Ciclo.Equals(other.Ciclo)
                ) && 
                (
                    this.CobraTarifa == other.CobraTarifa ||
                    this.CobraTarifa != null &&
                    this.CobraTarifa.Equals(other.CobraTarifa)
                ) && 
                (
                    this.DataFimCiclo == other.DataFimCiclo ||
                    this.DataFimCiclo != null &&
                    this.DataFimCiclo.Equals(other.DataFimCiclo)
                ) && 
                (
                    this.DataHoraAtivacao == other.DataHoraAtivacao ||
                    this.DataHoraAtivacao != null &&
                    this.DataHoraAtivacao.Equals(other.DataHoraAtivacao)
                ) && 
                (
                    this.DataHoraDesativacao == other.DataHoraDesativacao ||
                    this.DataHoraDesativacao != null &&
                    this.DataHoraDesativacao.Equals(other.DataHoraDesativacao)
                ) && 
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
                    this.PacoteTarifa == other.PacoteTarifa ||
                    this.PacoteTarifa != null &&
                    this.PacoteTarifa.Equals(other.PacoteTarifa)
                ) && 
                (
                    this.PagamentoContaUtilizado == other.PagamentoContaUtilizado ||
                    this.PagamentoContaUtilizado != null &&
                    this.PagamentoContaUtilizado.Equals(other.PagamentoContaUtilizado)
                ) && 
                (
                    this.RecargaCelularUtilizado == other.RecargaCelularUtilizado ||
                    this.RecargaCelularUtilizado != null &&
                    this.RecargaCelularUtilizado.Equals(other.RecargaCelularUtilizado)
                ) && 
                (
                    this.SaqueUtilizado == other.SaqueUtilizado ||
                    this.SaqueUtilizado != null &&
                    this.SaqueUtilizado.Equals(other.SaqueUtilizado)
                ) && 
                (
                    this.TarifaManutencaoCobrada == other.TarifaManutencaoCobrada ||
                    this.TarifaManutencaoCobrada != null &&
                    this.TarifaManutencaoCobrada.Equals(other.TarifaManutencaoCobrada)
                ) && 
                (
                    this.TransferenciaUtilizado == other.TransferenciaUtilizado ||
                    this.TransferenciaUtilizado != null &&
                    this.TransferenciaUtilizado.Equals(other.TransferenciaUtilizado)
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
                
                if (this.AplicacaoUtilizado != null)
                    hash = hash * 59 + this.AplicacaoUtilizado.GetHashCode();
                
                if (this.BilheteUnicoUtilizado != null)
                    hash = hash * 59 + this.BilheteUnicoUtilizado.GetHashCode();
                
                if (this.BoletoUtilizado != null)
                    hash = hash * 59 + this.BoletoUtilizado.GetHashCode();
                
                if (this.Ciclo != null)
                    hash = hash * 59 + this.Ciclo.GetHashCode();
                
                if (this.CobraTarifa != null)
                    hash = hash * 59 + this.CobraTarifa.GetHashCode();
                
                if (this.DataFimCiclo != null)
                    hash = hash * 59 + this.DataFimCiclo.GetHashCode();
                
                if (this.DataHoraAtivacao != null)
                    hash = hash * 59 + this.DataHoraAtivacao.GetHashCode();
                
                if (this.DataHoraDesativacao != null)
                    hash = hash * 59 + this.DataHoraDesativacao.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.PacoteTarifa != null)
                    hash = hash * 59 + this.PacoteTarifa.GetHashCode();
                
                if (this.PagamentoContaUtilizado != null)
                    hash = hash * 59 + this.PagamentoContaUtilizado.GetHashCode();
                
                if (this.RecargaCelularUtilizado != null)
                    hash = hash * 59 + this.RecargaCelularUtilizado.GetHashCode();
                
                if (this.SaqueUtilizado != null)
                    hash = hash * 59 + this.SaqueUtilizado.GetHashCode();
                
                if (this.TarifaManutencaoCobrada != null)
                    hash = hash * 59 + this.TarifaManutencaoCobrada.GetHashCode();
                
                if (this.TransferenciaUtilizado != null)
                    hash = hash * 59 + this.TransferenciaUtilizado.GetHashCode();
                
                return hash;
            }
        }

    }
}
