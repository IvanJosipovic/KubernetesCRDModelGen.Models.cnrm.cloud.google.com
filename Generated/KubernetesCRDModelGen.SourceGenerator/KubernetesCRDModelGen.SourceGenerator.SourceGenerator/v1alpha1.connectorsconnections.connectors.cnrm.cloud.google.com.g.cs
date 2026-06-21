#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.connectors.cnrm.cloud.google.com;
/// <summary>ConnectorsConnection is the Schema for the ConnectorsConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ConnectorsConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ConnectorsConnection>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ConnectorsConnectionList";
    public const string KubeGroup = "connectors.cnrm.cloud.google.com";
    public const string KubePluralName = "connectorsconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "connectors.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConnectorsConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ConnectorsConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ConnectorsConnection> Items { get; set; }
}

/// <summary>Value is a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecAuthConfigAdditionalVariablesSecretValueRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecAuthConfigAdditionalVariables
{
    /// <summary>Value is a bool.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>Value is an integer</summary>
    [JsonPropertyName("intValue")]
    public long? IntValue { get; set; }

    /// <summary>Key of the config variable.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value is a secret.</summary>
    [JsonPropertyName("secretValueRef")]
    public V1alpha1ConnectorsConnectionSpecAuthConfigAdditionalVariablesSecretValueRef? SecretValueRef { get; set; }

    /// <summary>Value is a string.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Secret version reference containing the client secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecAuthConfigOauth2ClientCredentialsClientSecretRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Oauth2ClientCredentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecAuthConfigOauth2ClientCredentials
{
    /// <summary>The client identifier.</summary>
    [JsonPropertyName("clientID")]
    public string? ClientID { get; set; }

    /// <summary>Secret version reference containing the client secret.</summary>
    [JsonPropertyName("clientSecretRef")]
    public V1alpha1ConnectorsConnectionSpecAuthConfigOauth2ClientCredentialsClientSecretRef? ClientSecretRef { get; set; }
}

/// <summary>Secret version reference containing a PKCS#8 PEM-encoded private key associated with the Client Certificate. This private key will be used to sign JWTs used for the jwt-bearer authorization grant. Specified in the form as: `projects/*/secrets/*/versions/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecAuthConfigOauth2JwtBearerClientKeyRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>JwtClaims providers fields to generate the token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecAuthConfigOauth2JwtBearerJwtClaims
{
    /// <summary>Value for the &quot;aud&quot; claim.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>Value for the &quot;iss&quot; claim.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Value for the &quot;sub&quot; claim.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>Oauth2JwtBearer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecAuthConfigOauth2JwtBearer
{
    /// <summary>Secret version reference containing a PKCS#8 PEM-encoded private key associated with the Client Certificate. This private key will be used to sign JWTs used for the jwt-bearer authorization grant. Specified in the form as: `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("clientKeyRef")]
    public V1alpha1ConnectorsConnectionSpecAuthConfigOauth2JwtBearerClientKeyRef? ClientKeyRef { get; set; }

    /// <summary>JwtClaims providers fields to generate the token.</summary>
    [JsonPropertyName("jwtClaims")]
    public V1alpha1ConnectorsConnectionSpecAuthConfigOauth2JwtBearerJwtClaims? JwtClaims { get; set; }
}

/// <summary>Password (passphrase) for ssh client certificate if it has one.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecAuthConfigSshPublicKeySshClientCertPassRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>SSH Client Cert. It should contain both public and private key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecAuthConfigSshPublicKeySshClientCertRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>SSH Public Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecAuthConfigSshPublicKey
{
    /// <summary>Format of SSH Client cert.</summary>
    [JsonPropertyName("certType")]
    public string? CertType { get; set; }

    /// <summary>Password (passphrase) for ssh client certificate if it has one.</summary>
    [JsonPropertyName("sshClientCertPassRef")]
    public V1alpha1ConnectorsConnectionSpecAuthConfigSshPublicKeySshClientCertPassRef? SshClientCertPassRef { get; set; }

    /// <summary>SSH Client Cert. It should contain both public and private key.</summary>
    [JsonPropertyName("sshClientCertRef")]
    public V1alpha1ConnectorsConnectionSpecAuthConfigSshPublicKeySshClientCertRef? SshClientCertRef { get; set; }

    /// <summary>The user account used to authenticate.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Secret version reference containing the password.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecAuthConfigUserPasswordSecretRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>UserPassword.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecAuthConfigUserPassword
{
    /// <summary>Secret version reference containing the password.</summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1ConnectorsConnectionSpecAuthConfigUserPasswordSecretRef? SecretRef { get; set; }

    /// <summary>Username.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Optional. Configuration for establishing the connection&apos;s authentication with an external system.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecAuthConfig
{
    /// <summary>List containing additional auth configs.</summary>
    [JsonPropertyName("additionalVariables")]
    public IList<V1alpha1ConnectorsConnectionSpecAuthConfigAdditionalVariables>? AdditionalVariables { get; set; }

    /// <summary>The type of authentication configured.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Oauth2ClientCredentials.</summary>
    [JsonPropertyName("oauth2ClientCredentials")]
    public V1alpha1ConnectorsConnectionSpecAuthConfigOauth2ClientCredentials? Oauth2ClientCredentials { get; set; }

    /// <summary>Oauth2JwtBearer.</summary>
    [JsonPropertyName("oauth2JwtBearer")]
    public V1alpha1ConnectorsConnectionSpecAuthConfigOauth2JwtBearer? Oauth2JwtBearer { get; set; }

    /// <summary>SSH Public Key.</summary>
    [JsonPropertyName("sshPublicKey")]
    public V1alpha1ConnectorsConnectionSpecAuthConfigSshPublicKey? SshPublicKey { get; set; }

    /// <summary>UserPassword.</summary>
    [JsonPropertyName("userPassword")]
    public V1alpha1ConnectorsConnectionSpecAuthConfigUserPassword? UserPassword { get; set; }
}

/// <summary>Value is a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecConfigVariablesSecretValueRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecConfigVariables
{
    /// <summary>Value is a bool.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>Value is an integer</summary>
    [JsonPropertyName("intValue")]
    public long? IntValue { get; set; }

    /// <summary>Key of the config variable.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value is a secret.</summary>
    [JsonPropertyName("secretValueRef")]
    public V1alpha1ConnectorsConnectionSpecConfigVariablesSecretValueRef? SecretValueRef { get; set; }

    /// <summary>Value is a string.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Required. Connector version on which the connection is created. The format is: projects/-*-/locations/-*-/providers/-*-/connectors/-*-/versions/-* Only global location is supported for ConnectorVersion resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecConnectorVersionRef
{
    /// <summary>A reference to an externally managed ConnectorsConnectorVersion resource. Should be in the format &quot;projects/{{projectID}}/locations/global/providers/{{providerID}}/connectors/{{connectorID}}/versions/{{versionID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ConnectorsConnectorVersion resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ConnectorsConnectorVersion resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>PSC service attachments. Format: projects/*/regions/*/serviceAttachments/*</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecDestinationConfigsDestinationsServiceAttachmentRef
{
    /// <summary>The ComputeServiceAttachment selflink in the form &quot;projects/{{project}}/regions/{{region}}/serviceAttachments/{{name}}&quot; when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeServiceAttachment` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeServiceAttachment` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecDestinationConfigsDestinations
{
    /// <summary>For publicly routable host.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The port is the target port number that is accepted by the destination.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>PSC service attachments. Format: projects/*/regions/*/serviceAttachments/*</summary>
    [JsonPropertyName("serviceAttachmentRef")]
    public V1alpha1ConnectorsConnectionSpecDestinationConfigsDestinationsServiceAttachmentRef? ServiceAttachmentRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecDestinationConfigs
{
    /// <summary>The destinations for the key.</summary>
    [JsonPropertyName("destinations")]
    public IList<V1alpha1ConnectorsConnectionSpecDestinationConfigsDestinations>? Destinations { get; set; }

    /// <summary>The key is the destination identifier that is supported by the Connector.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Optional. Configuration that indicates whether or not the Connection can be edited.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecLockConfig
{
    /// <summary>Indicates whether or not the connection is locked.</summary>
    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }

    /// <summary>Describes why a connection is locked.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>Optional. Node configuration for the connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecNodeConfig
{
    /// <summary>Maximum number of nodes in the runtime nodes.</summary>
    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    /// <summary>Minimum number of nodes in the runtime nodes.</summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Service account needed for runtime plane to access GCP resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Value is a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecSslConfigAdditionalVariablesSecretValueRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecSslConfigAdditionalVariables
{
    /// <summary>Value is a bool.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>Value is an integer</summary>
    [JsonPropertyName("intValue")]
    public long? IntValue { get; set; }

    /// <summary>Key of the config variable.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value is a secret.</summary>
    [JsonPropertyName("secretValueRef")]
    public V1alpha1ConnectorsConnectionSpecSslConfigAdditionalVariablesSecretValueRef? SecretValueRef { get; set; }

    /// <summary>Value is a string.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Client Certificate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecSslConfigClientCertificateRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Secret containing the passphrase protecting the Client Private Key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecSslConfigClientPrivateKeyPassRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Client Private Key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecSslConfigClientPrivateKeyRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Private Server Certificate. Needs to be specified if trust model is `PRIVATE`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecSslConfigPrivateServerCertificateRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Ssl config of a connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpecSslConfig
{
    /// <summary>Additional SSL related field values</summary>
    [JsonPropertyName("additionalVariables")]
    public IList<V1alpha1ConnectorsConnectionSpecSslConfigAdditionalVariables>? AdditionalVariables { get; set; }

    /// <summary>Type of Client Cert (PEM/JKS/.. etc.)</summary>
    [JsonPropertyName("clientCertType")]
    public string? ClientCertType { get; set; }

    /// <summary>Client Certificate</summary>
    [JsonPropertyName("clientCertificateRef")]
    public V1alpha1ConnectorsConnectionSpecSslConfigClientCertificateRef? ClientCertificateRef { get; set; }

    /// <summary>Secret containing the passphrase protecting the Client Private Key</summary>
    [JsonPropertyName("clientPrivateKeyPassRef")]
    public V1alpha1ConnectorsConnectionSpecSslConfigClientPrivateKeyPassRef? ClientPrivateKeyPassRef { get; set; }

    /// <summary>Client Private Key</summary>
    [JsonPropertyName("clientPrivateKeyRef")]
    public V1alpha1ConnectorsConnectionSpecSslConfigClientPrivateKeyRef? ClientPrivateKeyRef { get; set; }

    /// <summary>Private Server Certificate. Needs to be specified if trust model is `PRIVATE`.</summary>
    [JsonPropertyName("privateServerCertificateRef")]
    public V1alpha1ConnectorsConnectionSpecSslConfigPrivateServerCertificateRef? PrivateServerCertificateRef { get; set; }

    /// <summary>Type of Server Cert (PEM/JKS/.. etc.)</summary>
    [JsonPropertyName("serverCertType")]
    public string? ServerCertType { get; set; }

    /// <summary>Trust Model of the SSL connection</summary>
    [JsonPropertyName("trustModel")]
    public string? TrustModel { get; set; }

    /// <summary>Controls the ssl type for the given connector version.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Bool for enabling SSL</summary>
    [JsonPropertyName("useSSL")]
    public bool? UseSSL { get; set; }
}

/// <summary>ConnectorsConnectionSpec defines the desired state of ConnectorsConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionSpec
{
    /// <summary>Optional. Configuration for establishing the connection&apos;s authentication with an external system.</summary>
    [JsonPropertyName("authConfig")]
    public V1alpha1ConnectorsConnectionSpecAuthConfig? AuthConfig { get; set; }

    /// <summary>Optional. Configuration for configuring the connection with an external system.</summary>
    [JsonPropertyName("configVariables")]
    public IList<V1alpha1ConnectorsConnectionSpecConfigVariables>? ConfigVariables { get; set; }

    /// <summary>Required. Connector version on which the connection is created. The format is: projects/-*-/locations/-*-/providers/-*-/connectors/-*-/versions/-* Only global location is supported for ConnectorVersion resource.</summary>
    [JsonPropertyName("connectorVersionRef")]
    public required V1alpha1ConnectorsConnectionSpecConnectorVersionRef ConnectorVersionRef { get; set; }

    /// <summary>Optional. Description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Configuration of the Connector&apos;s destination. Only accepted for Connectors that accepts user defined destination(s).</summary>
    [JsonPropertyName("destinationConfigs")]
    public IList<V1alpha1ConnectorsConnectionSpecDestinationConfigs>? DestinationConfigs { get; set; }

    /// <summary>Optional. Resource labels to represent user-provided metadata. Refer to cloud documentation on labels for more details. https://cloud.google.com/compute/docs/labeling-resources</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. Configuration that indicates whether or not the Connection can be edited.</summary>
    [JsonPropertyName("lockConfig")]
    public V1alpha1ConnectorsConnectionSpecLockConfig? LockConfig { get; set; }

    /// <summary>Optional. Node configuration for the connection.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1alpha1ConnectorsConnectionSpecNodeConfig? NodeConfig { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1ConnectorsConnectionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The ConnectorsConnection name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Service account needed for runtime plane to access GCP resources.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1ConnectorsConnectionSpecServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Optional. Ssl config of a connection</summary>
    [JsonPropertyName("sslConfig")]
    public V1alpha1ConnectorsConnectionSpecSslConfig? SslConfig { get; set; }

    /// <summary>Optional. Suspended indicates if a user has suspended a connection or not.</summary>
    [JsonPropertyName("suspended")]
    public bool? Suspended { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Output only. Current status of the connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionStatusObservedStateStatus
{
    /// <summary>Description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>State.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Status provides detailed information for the state.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionStatusObservedState
{
    /// <summary>Output only. Created time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. GCR location where the envoy image is stored. formatted like: gcr.io/{bucketName}/{imageName}</summary>
    [JsonPropertyName("envoyImageLocation")]
    public string? EnvoyImageLocation { get; set; }

    /// <summary>Output only. GCR location where the runtime image is stored. formatted like: gcr.io/{bucketName}/{imageName}</summary>
    [JsonPropertyName("imageLocation")]
    public string? ImageLocation { get; set; }

    /// <summary>Output only. Resource name of the Connection. Format: projects/{project}/locations/{location}/connections/{connection}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. The name of the Service Directory service name. Used for Private Harpoon to resolve the ILB address. e.g. &quot;projects/cloud-connectors-e2e-testing/locations/us-central1/namespaces/istio-system/services/istio-ingressgateway-connectors&quot;</summary>
    [JsonPropertyName("serviceDirectory")]
    public string? ServiceDirectory { get; set; }

    /// <summary>Output only. Current status of the connection.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ConnectorsConnectionStatusObservedStateStatus? Status { get; set; }

    /// <summary>Output only. Updated time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ConnectorsConnectionStatus defines the config connector machine state of ConnectorsConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectorsConnectionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ConnectorsConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ConnectorsConnection resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ConnectorsConnectionStatusObservedState? ObservedState { get; set; }
}

/// <summary>ConnectorsConnection is the Schema for the ConnectorsConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ConnectorsConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ConnectorsConnectionSpec>, IStatus<V1alpha1ConnectorsConnectionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ConnectorsConnection";
    public const string KubeGroup = "connectors.cnrm.cloud.google.com";
    public const string KubePluralName = "connectorsconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "connectors.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConnectorsConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConnectorsConnectionSpec defines the desired state of ConnectorsConnection</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ConnectorsConnectionSpec Spec { get; set; }

    /// <summary>ConnectorsConnectionStatus defines the config connector machine state of ConnectorsConnection</summary>
    [JsonPropertyName("status")]
    public V1alpha1ConnectorsConnectionStatus? Status { get; set; }
}