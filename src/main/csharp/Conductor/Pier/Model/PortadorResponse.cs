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
    /// Portador
    /// </summary>
    [DataContract]
    public partial class PortadorResponse :  IEquatable<PortadorResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PortadorResponse" /> class.
        /// Initializes a new instance of the <see cref="PortadorResponse" />class.
        /// </summary>
        /// <param name="Observacao">Observa\u00E7\u00E3o do portador.</param>
        /// <param name="Parentesco">Parentesco do portador.</param>
        /// <param name="IdConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id).</param>
        /// <param name="IdProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id).</param>
        /// <param name="IdPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id).</param>
        /// <param name="IdParentesco">C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id).</param>
        /// <param name="TipoPortador">Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional).</param>
        /// <param name="NomeImpresso">Apresenta o nome a ser impresso no cart\u00E3o.</param>
        /// <param name="IdTipoCartao">Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta.</param>
        /// <param name="FlagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o.</param>
        /// <param name="DataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o.</param>
        /// <param name="DataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o.</param>

        public PortadorResponse(string Observacao = null, string Parentesco = null, long? IdConta = null, long? IdProduto = null, long? IdPessoa = null, long? IdParentesco = null, string TipoPortador = null, string NomeImpresso = null, long? IdTipoCartao = null, int? FlagAtivo = null, string DataCadastroPortador = null, string DataCancelamentoPortador = null)
        {
            this.Observacao = Observacao;
            this.Parentesco = Parentesco;
            this.IdConta = IdConta;
            this.IdProduto = IdProduto;
            this.IdPessoa = IdPessoa;
            this.IdParentesco = IdParentesco;
            this.TipoPortador = TipoPortador;
            this.NomeImpresso = NomeImpresso;
            this.IdTipoCartao = IdTipoCartao;
            this.FlagAtivo = FlagAtivo;
            this.DataCadastroPortador = DataCadastroPortador;
            this.DataCancelamentoPortador = DataCancelamentoPortador;
            
        }
        
    
        /// <summary>
        /// Observa\u00E7\u00E3o do portador
        /// </summary>
        /// <value>Observa\u00E7\u00E3o do portador</value>
        [DataMember(Name="observacao", EmitDefaultValue=false)]
        public string Observacao { get; set; }
    
        /// <summary>
        /// Parentesco do portador
        /// </summary>
        /// <value>Parentesco do portador</value>
        [DataMember(Name="parentesco", EmitDefaultValue=false)]
        public string Parentesco { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id)</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Parentesco (id)</value>
        [DataMember(Name="idParentesco", EmitDefaultValue=false)]
        public long? IdParentesco { get; set; }
    
        /// <summary>
        /// Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional)
        /// </summary>
        /// <value>Apresenta o tipo do Portador do cart\u00E3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional)</value>
        [DataMember(Name="tipoPortador", EmitDefaultValue=false)]
        public string TipoPortador { get; set; }
    
        /// <summary>
        /// Apresenta o nome a ser impresso no cart\u00E3o
        /// </summary>
        /// <value>Apresenta o nome a ser impresso no cart\u00E3o</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta
        /// </summary>
        /// <value>Apresenta o c\u00F3digo de identifica\u00E7\u00E3o do tipo do cart\u00E3o (id), que ser\u00E1 utilizado para gerar os cart\u00F5es deste portador, vinculados a sua respectiva conta atrav\u00E9s do campo idConta</value>
        [DataMember(Name="idTipoCartao", EmitDefaultValue=false)]
        public long? IdTipoCartao { get; set; }
    
        /// <summary>
        /// Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o
        /// </summary>
        /// <value>Quanto ativa, indica que o cadastro do Portador est\u00E1 ativo, em emissores que realizam este tipo de gest\u00E3o</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public int? FlagAtivo { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o
        /// </summary>
        /// <value>Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00E7\u00E3o</value>
        [DataMember(Name="dataCadastroPortador", EmitDefaultValue=false)]
        public string DataCadastroPortador { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o
        /// </summary>
        /// <value>Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00E7\u00E3o</value>
        [DataMember(Name="dataCancelamentoPortador", EmitDefaultValue=false)]
        public string DataCancelamentoPortador { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortadorResponse {\n");
            sb.Append("  Observacao: ").Append(Observacao).Append("\n");
            sb.Append("  Parentesco: ").Append(Parentesco).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdParentesco: ").Append(IdParentesco).Append("\n");
            sb.Append("  TipoPortador: ").Append(TipoPortador).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  IdTipoCartao: ").Append(IdTipoCartao).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            sb.Append("  DataCadastroPortador: ").Append(DataCadastroPortador).Append("\n");
            sb.Append("  DataCancelamentoPortador: ").Append(DataCancelamentoPortador).Append("\n");
            
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
            return this.Equals(obj as PortadorResponse);
        }

        /// <summary>
        /// Returns true if PortadorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PortadorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortadorResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Observacao == other.Observacao ||
                    this.Observacao != null &&
                    this.Observacao.Equals(other.Observacao)
                ) && 
                (
                    this.Parentesco == other.Parentesco ||
                    this.Parentesco != null &&
                    this.Parentesco.Equals(other.Parentesco)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdParentesco == other.IdParentesco ||
                    this.IdParentesco != null &&
                    this.IdParentesco.Equals(other.IdParentesco)
                ) && 
                (
                    this.TipoPortador == other.TipoPortador ||
                    this.TipoPortador != null &&
                    this.TipoPortador.Equals(other.TipoPortador)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.IdTipoCartao == other.IdTipoCartao ||
                    this.IdTipoCartao != null &&
                    this.IdTipoCartao.Equals(other.IdTipoCartao)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
                ) && 
                (
                    this.DataCadastroPortador == other.DataCadastroPortador ||
                    this.DataCadastroPortador != null &&
                    this.DataCadastroPortador.Equals(other.DataCadastroPortador)
                ) && 
                (
                    this.DataCancelamentoPortador == other.DataCancelamentoPortador ||
                    this.DataCancelamentoPortador != null &&
                    this.DataCancelamentoPortador.Equals(other.DataCancelamentoPortador)
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
                
                if (this.Observacao != null)
                    hash = hash * 59 + this.Observacao.GetHashCode();
                
                if (this.Parentesco != null)
                    hash = hash * 59 + this.Parentesco.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdParentesco != null)
                    hash = hash * 59 + this.IdParentesco.GetHashCode();
                
                if (this.TipoPortador != null)
                    hash = hash * 59 + this.TipoPortador.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.IdTipoCartao != null)
                    hash = hash * 59 + this.IdTipoCartao.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                if (this.DataCadastroPortador != null)
                    hash = hash * 59 + this.DataCadastroPortador.GetHashCode();
                
                if (this.DataCancelamentoPortador != null)
                    hash = hash * 59 + this.DataCancelamentoPortador.GetHashCode();
                
                return hash;
            }
        }

    }
}
