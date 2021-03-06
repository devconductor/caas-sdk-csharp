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
    /// Objeto de Requisi\u00E7\u00E3o de Autoriza\u00E7\u00E3o
    /// </summary>
    [DataContract]
    public partial class AutorizacaoOnUsRequest :  IEquatable<AutorizacaoOnUsRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AutorizacaoOnUsRequest" /> class.
        /// Initializes a new instance of the <see cref="AutorizacaoOnUsRequest" />class.
        /// </summary>
        /// <param name="NsuOrigem">N\u00FAmero Sequencial \u00DAnico que identifica a transa\u00E7\u00E3o no sistema que a originou (required).</param>
        /// <param name="NumeroParcelas">N\u00FAmero de Parcelas (required).</param>
        /// <param name="CodigoProcessamento">C\u00F3digo de Processamento que identifica o Tipo da Transa\u00E7\u00E3o (required).</param>
        /// <param name="CodigoSegurancaCartao">C\u00F3digo de Seguran\u00E7a do Cart\u00E3o.</param>
        /// <param name="NomeEstabelecimento">Nome do Estabelecimento.</param>
        /// <param name="ValorTransacao">Valor da transa\u00E7\u00E3o com duas casas decimais para os centavos (required).</param>
        /// <param name="NumeroRealCartao">N\u00FAmero Real do Cart\u00E3o (required).</param>
        /// <param name="DataValidadeCartao">Data de Validade do Cart\u00E3o. Ex: AAMM (required).</param>
        /// <param name="NumeroEstabelecimento">N\u00FAmero do Estabelecimento (N\u00FAmero+DV) (required).</param>
        /// <param name="DataHoraTerminal">Apresenta a data e hora local da consulta yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (required).</param>
        /// <param name="TerminalRequisitante">Apresenta a identifica\u00E7\u00E3o do terminal requisitante (required).</param>

        public AutorizacaoOnUsRequest(string NsuOrigem = null, long? NumeroParcelas = null, string CodigoProcessamento = null, string CodigoSegurancaCartao = null, string NomeEstabelecimento = null, double? ValorTransacao = null, string NumeroRealCartao = null, string DataValidadeCartao = null, long? NumeroEstabelecimento = null, string DataHoraTerminal = null, string TerminalRequisitante = null)
        {
            // to ensure "NsuOrigem" is required (not null)
            if (NsuOrigem == null)
            {
                throw new InvalidDataException("NsuOrigem is a required property for AutorizacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.NsuOrigem = NsuOrigem;
            }
            // to ensure "NumeroParcelas" is required (not null)
            if (NumeroParcelas == null)
            {
                throw new InvalidDataException("NumeroParcelas is a required property for AutorizacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.NumeroParcelas = NumeroParcelas;
            }
            // to ensure "CodigoProcessamento" is required (not null)
            if (CodigoProcessamento == null)
            {
                throw new InvalidDataException("CodigoProcessamento is a required property for AutorizacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.CodigoProcessamento = CodigoProcessamento;
            }
            // to ensure "ValorTransacao" is required (not null)
            if (ValorTransacao == null)
            {
                throw new InvalidDataException("ValorTransacao is a required property for AutorizacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.ValorTransacao = ValorTransacao;
            }
            // to ensure "NumeroRealCartao" is required (not null)
            if (NumeroRealCartao == null)
            {
                throw new InvalidDataException("NumeroRealCartao is a required property for AutorizacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.NumeroRealCartao = NumeroRealCartao;
            }
            // to ensure "DataValidadeCartao" is required (not null)
            if (DataValidadeCartao == null)
            {
                throw new InvalidDataException("DataValidadeCartao is a required property for AutorizacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.DataValidadeCartao = DataValidadeCartao;
            }
            // to ensure "NumeroEstabelecimento" is required (not null)
            if (NumeroEstabelecimento == null)
            {
                throw new InvalidDataException("NumeroEstabelecimento is a required property for AutorizacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.NumeroEstabelecimento = NumeroEstabelecimento;
            }
            // to ensure "DataHoraTerminal" is required (not null)
            if (DataHoraTerminal == null)
            {
                throw new InvalidDataException("DataHoraTerminal is a required property for AutorizacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.DataHoraTerminal = DataHoraTerminal;
            }
            // to ensure "TerminalRequisitante" is required (not null)
            if (TerminalRequisitante == null)
            {
                throw new InvalidDataException("TerminalRequisitante is a required property for AutorizacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.TerminalRequisitante = TerminalRequisitante;
            }
            this.CodigoSegurancaCartao = CodigoSegurancaCartao;
            this.NomeEstabelecimento = NomeEstabelecimento;
            
        }
        
    
        /// <summary>
        /// N\u00FAmero Sequencial \u00DAnico que identifica a transa\u00E7\u00E3o no sistema que a originou
        /// </summary>
        /// <value>N\u00FAmero Sequencial \u00DAnico que identifica a transa\u00E7\u00E3o no sistema que a originou</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public string NsuOrigem { get; set; }
    
        /// <summary>
        /// N\u00FAmero de Parcelas
        /// </summary>
        /// <value>N\u00FAmero de Parcelas</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public long? NumeroParcelas { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Processamento que identifica o Tipo da Transa\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de Processamento que identifica o Tipo da Transa\u00E7\u00E3o</value>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Seguran\u00E7a do Cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de Seguran\u00E7a do Cart\u00E3o</value>
        [DataMember(Name="codigoSegurancaCartao", EmitDefaultValue=false)]
        public string CodigoSegurancaCartao { get; set; }
    
        /// <summary>
        /// Nome do Estabelecimento
        /// </summary>
        /// <value>Nome do Estabelecimento</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Valor da transa\u00E7\u00E3o com duas casas decimais para os centavos
        /// </summary>
        /// <value>Valor da transa\u00E7\u00E3o com duas casas decimais para os centavos</value>
        [DataMember(Name="valorTransacao", EmitDefaultValue=false)]
        public double? ValorTransacao { get; set; }
    
        /// <summary>
        /// N\u00FAmero Real do Cart\u00E3o
        /// </summary>
        /// <value>N\u00FAmero Real do Cart\u00E3o</value>
        [DataMember(Name="numeroRealCartao", EmitDefaultValue=false)]
        public string NumeroRealCartao { get; set; }
    
        /// <summary>
        /// Data de Validade do Cart\u00E3o. Ex: AAMM
        /// </summary>
        /// <value>Data de Validade do Cart\u00E3o. Ex: AAMM</value>
        [DataMember(Name="dataValidadeCartao", EmitDefaultValue=false)]
        public string DataValidadeCartao { get; set; }
    
        /// <summary>
        /// N\u00FAmero do Estabelecimento (N\u00FAmero+DV)
        /// </summary>
        /// <value>N\u00FAmero do Estabelecimento (N\u00FAmero+DV)</value>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public long? NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Apresenta a data e hora local da consulta yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00
        /// </summary>
        /// <value>Apresenta a data e hora local da consulta yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00</value>
        [DataMember(Name="dataHoraTerminal", EmitDefaultValue=false)]
        public string DataHoraTerminal { get; set; }
    
        /// <summary>
        /// Apresenta a identifica\u00E7\u00E3o do terminal requisitante
        /// </summary>
        /// <value>Apresenta a identifica\u00E7\u00E3o do terminal requisitante</value>
        [DataMember(Name="terminalRequisitante", EmitDefaultValue=false)]
        public string TerminalRequisitante { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutorizacaoOnUsRequest {\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  CodigoProcessamento: ").Append(CodigoProcessamento).Append("\n");
            sb.Append("  CodigoSegurancaCartao: ").Append(CodigoSegurancaCartao).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
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
            return this.Equals(obj as AutorizacaoOnUsRequest);
        }

        /// <summary>
        /// Returns true if AutorizacaoOnUsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AutorizacaoOnUsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutorizacaoOnUsRequest other)
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
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.CodigoProcessamento == other.CodigoProcessamento ||
                    this.CodigoProcessamento != null &&
                    this.CodigoProcessamento.Equals(other.CodigoProcessamento)
                ) && 
                (
                    this.CodigoSegurancaCartao == other.CodigoSegurancaCartao ||
                    this.CodigoSegurancaCartao != null &&
                    this.CodigoSegurancaCartao.Equals(other.CodigoSegurancaCartao)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
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
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.CodigoProcessamento != null)
                    hash = hash * 59 + this.CodigoProcessamento.GetHashCode();
                
                if (this.CodigoSegurancaCartao != null)
                    hash = hash * 59 + this.CodigoSegurancaCartao.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
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
