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
    /// {{{notificacao_push_response_description}}}
    /// </summary>
    [DataContract]
    public partial class NotificacaoPushResponseValue :  IEquatable<NotificacaoPushResponseValue>
    { 
    
        /// <summary>
        /// {{{notificacao_push_response_tipo_evento_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_tipo_evento_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoEventoEnum {
            
            [EnumMember(Value = "RISCO_FRAUDE")]
            RiscoFraude,
            
            [EnumMember(Value = "CODIGO_SEGURANCA")]
            CodigoSeguranca,
            
            [EnumMember(Value = "OUTROS")]
            Outros
        }

    
        /// <summary>
        /// {{{notificacao_push_response_status_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_status_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "PENDENTE")]
            Pendente,
            
            [EnumMember(Value = "ENCAMINHADO")]
            Encaminhado,
            
            [EnumMember(Value = "ENVIADO")]
            Enviado,
            
            [EnumMember(Value = "RESPONDIDO")]
            Respondido,
            
            [EnumMember(Value = "ERRO")]
            Erro,
            
            [EnumMember(Value = "ERRO_RESPOSTA")]
            ErroResposta,
            
            [EnumMember(Value = "SUCESSO_RESPOSTA")]
            SucessoResposta
        }

    
        /// <summary>
        /// {{{notificacao_push_response_plataforma_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_plataforma_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlataformaEnum {
            
            [EnumMember(Value = "APNS")]
            Apns,
            
            [EnumMember(Value = "FCM")]
            Fcm,
            
            [EnumMember(Value = "GCM")]
            Gcm
        }

    
        /// <summary>
        /// {{{notificacao_push_response_tipo_evento_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_tipo_evento_value}}}</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public TipoEventoEnum? TipoEvento { get; set; }
    
        /// <summary>
        /// {{{notificacao_push_response_status_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// {{{notificacao_push_response_plataforma_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_plataforma_value}}}</value>
        [DataMember(Name="plataforma", EmitDefaultValue=false)]
        public PlataformaEnum? Plataforma { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacaoPushResponseValue" /> class.
        /// Initializes a new instance of the <see cref="NotificacaoPushResponseValue" />class.
        /// </summary>
        /// <param name="DataEnvio">{{{notificacao_push_response_data_envio_value}}}.</param>
        /// <param name="IdEmissor">{{{notificacao_push_response_id_emissor_value}}}.</param>
        /// <param name="TipoEvento">{{{notificacao_push_response_tipo_evento_value}}}.</param>
        /// <param name="Status">{{{notificacao_push_response_status_value}}}.</param>
        /// <param name="IdPessoa">{{{notificacao_push_response_id_pessoa_value}}} (required).</param>
        /// <param name="IdConta">{{{notificacao_push_response_id_conta_value}}} (required).</param>
        /// <param name="TokenDispositivo">{{{notificacao_push_response_token_dispositivo_value}}} (required).</param>
        /// <param name="Titulo">{{{notificacao_push_response_titulo_value}}} (required).</param>
        /// <param name="Conteudo">{{{notificacao_push_response_conteudo_value}}} (required).</param>
        /// <param name="Plataforma">{{{notificacao_push_response_plataforma_value}}}.</param>
        /// <param name="Protocolo">{{{notificacao_push_response_protocolo_value}}}.</param>

        public NotificacaoPushResponseValue(string DataEnvio = null, long? IdEmissor = null, TipoEventoEnum? TipoEvento = null, StatusEnum? Status = null, long? IdPessoa = null, long? IdConta = null, string TokenDispositivo = null, string Titulo = null, string Conteudo = null, PlataformaEnum? Plataforma = null, string Protocolo = null)
        {
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for NotificacaoPushResponseValue and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for NotificacaoPushResponseValue and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "TokenDispositivo" is required (not null)
            if (TokenDispositivo == null)
            {
                throw new InvalidDataException("TokenDispositivo is a required property for NotificacaoPushResponseValue and cannot be null");
            }
            else
            {
                this.TokenDispositivo = TokenDispositivo;
            }
            // to ensure "Titulo" is required (not null)
            if (Titulo == null)
            {
                throw new InvalidDataException("Titulo is a required property for NotificacaoPushResponseValue and cannot be null");
            }
            else
            {
                this.Titulo = Titulo;
            }
            // to ensure "Conteudo" is required (not null)
            if (Conteudo == null)
            {
                throw new InvalidDataException("Conteudo is a required property for NotificacaoPushResponseValue and cannot be null");
            }
            else
            {
                this.Conteudo = Conteudo;
            }
            this.DataEnvio = DataEnvio;
            this.IdEmissor = IdEmissor;
            this.TipoEvento = TipoEvento;
            this.Status = Status;
            this.Plataforma = Plataforma;
            this.Protocolo = Protocolo;
            
        }
        
    
        /// <summary>
        /// {{{notificacao_push_response_data_envio_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_data_envio_value}}}</value>
        [DataMember(Name="dataEnvio", EmitDefaultValue=false)]
        public string DataEnvio { get; set; }
    
        /// <summary>
        /// {{{notificacao_push_response_id_emissor_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_id_emissor_value}}}</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// {{{notificacao_push_response_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{notificacao_push_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{notificacao_push_response_token_dispositivo_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_token_dispositivo_value}}}</value>
        [DataMember(Name="tokenDispositivo", EmitDefaultValue=false)]
        public string TokenDispositivo { get; set; }
    
        /// <summary>
        /// {{{notificacao_push_response_titulo_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_titulo_value}}}</value>
        [DataMember(Name="titulo", EmitDefaultValue=false)]
        public string Titulo { get; set; }
    
        /// <summary>
        /// {{{notificacao_push_response_conteudo_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_conteudo_value}}}</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// {{{notificacao_push_response_protocolo_value}}}
        /// </summary>
        /// <value>{{{notificacao_push_response_protocolo_value}}}</value>
        [DataMember(Name="protocolo", EmitDefaultValue=false)]
        public string Protocolo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificacaoPushResponseValue {\n");
            sb.Append("  DataEnvio: ").Append(DataEnvio).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  TokenDispositivo: ").Append(TokenDispositivo).Append("\n");
            sb.Append("  Titulo: ").Append(Titulo).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            sb.Append("  Plataforma: ").Append(Plataforma).Append("\n");
            sb.Append("  Protocolo: ").Append(Protocolo).Append("\n");
            
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
            return this.Equals(obj as NotificacaoPushResponseValue);
        }

        /// <summary>
        /// Returns true if NotificacaoPushResponseValue instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificacaoPushResponseValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificacaoPushResponseValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataEnvio == other.DataEnvio ||
                    this.DataEnvio != null &&
                    this.DataEnvio.Equals(other.DataEnvio)
                ) && 
                (
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.TipoEvento == other.TipoEvento ||
                    this.TipoEvento != null &&
                    this.TipoEvento.Equals(other.TipoEvento)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.TokenDispositivo == other.TokenDispositivo ||
                    this.TokenDispositivo != null &&
                    this.TokenDispositivo.Equals(other.TokenDispositivo)
                ) && 
                (
                    this.Titulo == other.Titulo ||
                    this.Titulo != null &&
                    this.Titulo.Equals(other.Titulo)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
                ) && 
                (
                    this.Plataforma == other.Plataforma ||
                    this.Plataforma != null &&
                    this.Plataforma.Equals(other.Plataforma)
                ) && 
                (
                    this.Protocolo == other.Protocolo ||
                    this.Protocolo != null &&
                    this.Protocolo.Equals(other.Protocolo)
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
                
                if (this.DataEnvio != null)
                    hash = hash * 59 + this.DataEnvio.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.TokenDispositivo != null)
                    hash = hash * 59 + this.TokenDispositivo.GetHashCode();
                
                if (this.Titulo != null)
                    hash = hash * 59 + this.Titulo.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                if (this.Plataforma != null)
                    hash = hash * 59 + this.Plataforma.GetHashCode();
                
                if (this.Protocolo != null)
                    hash = hash * 59 + this.Protocolo.GetHashCode();
                
                return hash;
            }
        }

    }
}