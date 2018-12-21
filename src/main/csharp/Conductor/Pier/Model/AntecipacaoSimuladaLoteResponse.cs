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
    /// {{{antecipacao_simulada_lote_response_description}}}
    /// </summary>
    [DataContract]
    public partial class AntecipacaoSimuladaLoteResponse :  IEquatable<AntecipacaoSimuladaLoteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AntecipacaoSimuladaLoteResponse" /> class.
        /// Initializes a new instance of the <see cref="AntecipacaoSimuladaLoteResponse" />class.
        /// </summary>
        /// <param name="ValorTotalAntecipado">{{{antecipacao_simulada_lote_response_valor_total_antecipado_value}}}.</param>
        /// <param name="ValorTotalDesconto">{{{antecipacao_simulada_lote_response_valor_total_desconto_value}}}.</param>
        /// <param name="ValorTotalComDesconto">{{{antecipacao_simulada_lote_response_valor_total_com_desconto_value}}}.</param>
        /// <param name="AntecipacoesSimuladas">{{{antecipacao_simulada_lote_response_antecipacoes_simuladas_value}}}.</param>

        public AntecipacaoSimuladaLoteResponse(double? ValorTotalAntecipado = null, double? ValorTotalDesconto = null, double? ValorTotalComDesconto = null, List<AntecipacaoSimuladaResponse> AntecipacoesSimuladas = null)
        {
            this.ValorTotalAntecipado = ValorTotalAntecipado;
            this.ValorTotalDesconto = ValorTotalDesconto;
            this.ValorTotalComDesconto = ValorTotalComDesconto;
            this.AntecipacoesSimuladas = AntecipacoesSimuladas;
            
        }
        
    
        /// <summary>
        /// {{{antecipacao_simulada_lote_response_valor_total_antecipado_value}}}
        /// </summary>
        /// <value>{{{antecipacao_simulada_lote_response_valor_total_antecipado_value}}}</value>
        [DataMember(Name="valorTotalAntecipado", EmitDefaultValue=false)]
        public double? ValorTotalAntecipado { get; set; }
    
        /// <summary>
        /// {{{antecipacao_simulada_lote_response_valor_total_desconto_value}}}
        /// </summary>
        /// <value>{{{antecipacao_simulada_lote_response_valor_total_desconto_value}}}</value>
        [DataMember(Name="valorTotalDesconto", EmitDefaultValue=false)]
        public double? ValorTotalDesconto { get; set; }
    
        /// <summary>
        /// {{{antecipacao_simulada_lote_response_valor_total_com_desconto_value}}}
        /// </summary>
        /// <value>{{{antecipacao_simulada_lote_response_valor_total_com_desconto_value}}}</value>
        [DataMember(Name="valorTotalComDesconto", EmitDefaultValue=false)]
        public double? ValorTotalComDesconto { get; set; }
    
        /// <summary>
        /// {{{antecipacao_simulada_lote_response_antecipacoes_simuladas_value}}}
        /// </summary>
        /// <value>{{{antecipacao_simulada_lote_response_antecipacoes_simuladas_value}}}</value>
        [DataMember(Name="antecipacoesSimuladas", EmitDefaultValue=false)]
        public List<AntecipacaoSimuladaResponse> AntecipacoesSimuladas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AntecipacaoSimuladaLoteResponse {\n");
            sb.Append("  ValorTotalAntecipado: ").Append(ValorTotalAntecipado).Append("\n");
            sb.Append("  ValorTotalDesconto: ").Append(ValorTotalDesconto).Append("\n");
            sb.Append("  ValorTotalComDesconto: ").Append(ValorTotalComDesconto).Append("\n");
            sb.Append("  AntecipacoesSimuladas: ").Append(AntecipacoesSimuladas).Append("\n");
            
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
            return this.Equals(obj as AntecipacaoSimuladaLoteResponse);
        }

        /// <summary>
        /// Returns true if AntecipacaoSimuladaLoteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AntecipacaoSimuladaLoteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntecipacaoSimuladaLoteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ValorTotalAntecipado == other.ValorTotalAntecipado ||
                    this.ValorTotalAntecipado != null &&
                    this.ValorTotalAntecipado.Equals(other.ValorTotalAntecipado)
                ) && 
                (
                    this.ValorTotalDesconto == other.ValorTotalDesconto ||
                    this.ValorTotalDesconto != null &&
                    this.ValorTotalDesconto.Equals(other.ValorTotalDesconto)
                ) && 
                (
                    this.ValorTotalComDesconto == other.ValorTotalComDesconto ||
                    this.ValorTotalComDesconto != null &&
                    this.ValorTotalComDesconto.Equals(other.ValorTotalComDesconto)
                ) && 
                (
                    this.AntecipacoesSimuladas == other.AntecipacoesSimuladas ||
                    this.AntecipacoesSimuladas != null &&
                    this.AntecipacoesSimuladas.SequenceEqual(other.AntecipacoesSimuladas)
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
                
                if (this.ValorTotalAntecipado != null)
                    hash = hash * 59 + this.ValorTotalAntecipado.GetHashCode();
                
                if (this.ValorTotalDesconto != null)
                    hash = hash * 59 + this.ValorTotalDesconto.GetHashCode();
                
                if (this.ValorTotalComDesconto != null)
                    hash = hash * 59 + this.ValorTotalComDesconto.GetHashCode();
                
                if (this.AntecipacoesSimuladas != null)
                    hash = hash * 59 + this.AntecipacoesSimuladas.GetHashCode();
                
                return hash;
            }
        }

    }
}
