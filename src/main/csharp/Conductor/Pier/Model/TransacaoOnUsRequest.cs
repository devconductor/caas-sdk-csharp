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
    /// Objeto de Requisi\u00C3\u00A7\u00C3\u00A3o de Transa\u00C3\u00A7\u00C3\u00A3o On Us
    /// </summary>
    [DataContract]
    public partial class TransacaoOnUsRequest :  IEquatable<TransacaoOnUsRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacaoOnUsRequest" /> class.
        /// Initializes a new instance of the <see cref="TransacaoOnUsRequest" />class.
        /// </summary>
        /// <param name="NsuOrigem">N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou. (required).</param>
        /// <param name="CodigoProcessamento">C\u00C3\u00B3digo de Processamento que identifica o Tipo da Transa\u00C3\u00A7\u00C3\u00A3o. (required).</param>
        /// <param name="ValorTransacao">Valor da transa\u00C3\u00A7\u00C3\u00A3o com duas casas decimais para os centavos. (required).</param>
        /// <param name="NumeroRealCartao">N\u00C3\u00BAmero Real do Cart\u00C3\u00A3o. (required).</param>
        /// <param name="DataValidadeCartao">Data de Validade do Cart\u00C3\u00A3o. Ex: AAMM (required).</param>
        /// <param name="NumeroEstabelecimento">N\u00C3\u00BAmero do Estabelecimento (N\u00C3\u00BAmero+DV). (required).</param>
        /// <param name="DataHoraTerminal">Apresenta a data e hora local da consulta yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (required).</param>
        /// <param name="TerminalRequisitante">Apresenta a identifica\u00C3\u00A7\u00C3\u00A3o do terminal requisitante (required).</param>

        public TransacaoOnUsRequest(string NsuOrigem = null, string CodigoProcessamento = null, double? ValorTransacao = null, string NumeroRealCartao = null, string DataValidadeCartao = null, long? NumeroEstabelecimento = null, string DataHoraTerminal = null, string TerminalRequisitante = null)
        {
            // to ensure "NsuOrigem" is required (not null)
            if (NsuOrigem == null)
            {
                throw new InvalidDataException("NsuOrigem is a required property for TransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.NsuOrigem = NsuOrigem;
            }
            // to ensure "CodigoProcessamento" is required (not null)
            if (CodigoProcessamento == null)
            {
                throw new InvalidDataException("CodigoProcessamento is a required property for TransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.CodigoProcessamento = CodigoProcessamento;
            }
            // to ensure "ValorTransacao" is required (not null)
            if (ValorTransacao == null)
            {
                throw new InvalidDataException("ValorTransacao is a required property for TransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.ValorTransacao = ValorTransacao;
            }
            // to ensure "NumeroRealCartao" is required (not null)
            if (NumeroRealCartao == null)
            {
                throw new InvalidDataException("NumeroRealCartao is a required property for TransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.NumeroRealCartao = NumeroRealCartao;
            }
            // to ensure "DataValidadeCartao" is required (not null)
            if (DataValidadeCartao == null)
            {
                throw new InvalidDataException("DataValidadeCartao is a required property for TransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.DataValidadeCartao = DataValidadeCartao;
            }
            // to ensure "NumeroEstabelecimento" is required (not null)
            if (NumeroEstabelecimento == null)
            {
                throw new InvalidDataException("NumeroEstabelecimento is a required property for TransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.NumeroEstabelecimento = NumeroEstabelecimento;
            }
            // to ensure "DataHoraTerminal" is required (not null)
            if (DataHoraTerminal == null)
            {
                throw new InvalidDataException("DataHoraTerminal is a required property for TransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.DataHoraTerminal = DataHoraTerminal;
            }
            // to ensure "TerminalRequisitante" is required (not null)
            if (TerminalRequisitante == null)
            {
                throw new InvalidDataException("TerminalRequisitante is a required property for TransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.TerminalRequisitante = TerminalRequisitante;
            }
            
        }
        
    
        /// <summary>
        /// N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou.
        /// </summary>
        /// <value>N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou.</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public string NsuOrigem { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Processamento que identifica o Tipo da Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Processamento que identifica o Tipo da Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// Valor da transa\u00C3\u00A7\u00C3\u00A3o com duas casas decimais para os centavos.
        /// </summary>
        /// <value>Valor da transa\u00C3\u00A7\u00C3\u00A3o com duas casas decimais para os centavos.</value>
        [DataMember(Name="valorTransacao", EmitDefaultValue=false)]
        public double? ValorTransacao { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero Real do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>N\u00C3\u00BAmero Real do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="numeroRealCartao", EmitDefaultValue=false)]
        public string NumeroRealCartao { get; set; }
    
        /// <summary>
        /// Data de Validade do Cart\u00C3\u00A3o. Ex: AAMM
        /// </summary>
        /// <value>Data de Validade do Cart\u00C3\u00A3o. Ex: AAMM</value>
        [DataMember(Name="dataValidadeCartao", EmitDefaultValue=false)]
        public string DataValidadeCartao { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do Estabelecimento (N\u00C3\u00BAmero+DV).
        /// </summary>
        /// <value>N\u00C3\u00BAmero do Estabelecimento (N\u00C3\u00BAmero+DV).</value>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public long? NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Apresenta a data e hora local da consulta yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00
        /// </summary>
        /// <value>Apresenta a data e hora local da consulta yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00</value>
        [DataMember(Name="dataHoraTerminal", EmitDefaultValue=false)]
        public string DataHoraTerminal { get; set; }
    
        /// <summary>
        /// Apresenta a identifica\u00C3\u00A7\u00C3\u00A3o do terminal requisitante
        /// </summary>
        /// <value>Apresenta a identifica\u00C3\u00A7\u00C3\u00A3o do terminal requisitante</value>
        [DataMember(Name="terminalRequisitante", EmitDefaultValue=false)]
        public string TerminalRequisitante { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransacaoOnUsRequest {\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  CodigoProcessamento: ").Append(CodigoProcessamento).Append("\n");
            sb.Append("  ValorTransacao: ").Append(ValorTransacao).Append("\n");
            sb.Append("  NumeroRealCartao: ").Append(NumeroRealCartao).Append("\n");
            sb.Append("  DataValidadeCartao: ").Append(DataValidadeCartao).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
            sb.Append("  DataHoraTerminal: ").Append(DataHoraTerminal).Append("\n");
            sb.Append("  TerminalRequisitante: ").Append(TerminalRequisitante).Append("\n");
            
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
            return this.Equals(obj as TransacaoOnUsRequest);
        }

        /// <summary>
        /// Returns true if TransacaoOnUsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TransacaoOnUsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransacaoOnUsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NsuOrigem == other.NsuOrigem ||
                    this.NsuOrigem != null &&
                    this.NsuOrigem.Equals(other.NsuOrigem)
                ) && 
                (
                    this.CodigoProcessamento == other.CodigoProcessamento ||
                    this.CodigoProcessamento != null &&
                    this.CodigoProcessamento.Equals(other.CodigoProcessamento)
                ) && 
                (
                    this.ValorTransacao == other.ValorTransacao ||
                    this.ValorTransacao != null &&
                    this.ValorTransacao.Equals(other.ValorTransacao)
                ) && 
                (
                    this.NumeroRealCartao == other.NumeroRealCartao ||
                    this.NumeroRealCartao != null &&
                    this.NumeroRealCartao.Equals(other.NumeroRealCartao)
                ) && 
                (
                    this.DataValidadeCartao == other.DataValidadeCartao ||
                    this.DataValidadeCartao != null &&
                    this.DataValidadeCartao.Equals(other.DataValidadeCartao)
                ) && 
                (
                    this.NumeroEstabelecimento == other.NumeroEstabelecimento ||
                    this.NumeroEstabelecimento != null &&
                    this.NumeroEstabelecimento.Equals(other.NumeroEstabelecimento)
                ) && 
                (
                    this.DataHoraTerminal == other.DataHoraTerminal ||
                    this.DataHoraTerminal != null &&
                    this.DataHoraTerminal.Equals(other.DataHoraTerminal)
                ) && 
                (
                    this.TerminalRequisitante == other.TerminalRequisitante ||
                    this.TerminalRequisitante != null &&
                    this.TerminalRequisitante.Equals(other.TerminalRequisitante)
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
                
                if (this.NsuOrigem != null)
                    hash = hash * 59 + this.NsuOrigem.GetHashCode();
                
                if (this.CodigoProcessamento != null)
                    hash = hash * 59 + this.CodigoProcessamento.GetHashCode();
                
                if (this.ValorTransacao != null)
                    hash = hash * 59 + this.ValorTransacao.GetHashCode();
                
                if (this.NumeroRealCartao != null)
                    hash = hash * 59 + this.NumeroRealCartao.GetHashCode();
                
                if (this.DataValidadeCartao != null)
                    hash = hash * 59 + this.DataValidadeCartao.GetHashCode();
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
                if (this.DataHoraTerminal != null)
                    hash = hash * 59 + this.DataHoraTerminal.GetHashCode();
                
                if (this.TerminalRequisitante != null)
                    hash = hash * 59 + this.TerminalRequisitante.GetHashCode();
                
                return hash;
            }
        }

    }
}
