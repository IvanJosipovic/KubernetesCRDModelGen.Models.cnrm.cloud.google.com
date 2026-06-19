#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dlp.cnrm.cloud.google.com;
/// <summary>DLPConnection is the Schema for the DLPConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DLPConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DLPConnection>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DLPConnectionList";
    public const string KubeGroup = "dlp.cnrm.cloud.google.com";
    public const string KubePluralName = "dlpconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dlp.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DLPConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DLPConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DLPConnection> Items { get; set; }
}

/// <summary>Built-in IAM authentication (must be configured in Cloud SQL).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPConnectionSpecCloudSQLCloudSQLIAM
{
}

/// <summary>Required. The Secret Manager secret version that stores the password.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPConnectionSpecCloudSQLUsernamePasswordSecretRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A username and password stored in Secret Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPConnectionSpecCloudSQLUsernamePassword
{
    /// <summary>Required. The Secret Manager secret version that stores the password.</summary>
    [JsonPropertyName("secretRef")]
    public required V1alpha1DLPConnectionSpecCloudSQLUsernamePasswordSecretRef SecretRef { get; set; }

    /// <summary>Required. The username.</summary>
    [JsonPropertyName("username")]
    public required string Username { get; set; }
}

/// <summary>Connect to a Cloud SQL instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPConnectionSpecCloudSQL
{
    /// <summary>Built-in IAM authentication (must be configured in Cloud SQL).</summary>
    [JsonPropertyName("cloudSQLIAM")]
    public V1alpha1DLPConnectionSpecCloudSQLCloudSQLIAM? CloudSQLIAM { get; set; }

    /// <summary>
    /// Optional. Immutable. The Cloud SQL instance for which the connection is
    ///  defined. Only one connection per instance is allowed. This can only be set
    ///  at creation time, and cannot be updated.
    /// 
    ///  It is an error to use a connection_name from different project or region
    ///  than the one that holds the connection.
    ///  For example, a Connection resource for Cloud SQL connection_name
    ///  `project-id:us-central1:sql-instance`
    ///  must be created under the parent
    ///  `projects/project-id/locations/us-central1`
    /// </summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Required. The database engine used by the Cloud SQL instance that this connection configures.</summary>
    [JsonPropertyName("databaseEngine")]
    public required string DatabaseEngine { get; set; }

    /// <summary>Required. The DLP API will limit its connections to max_connections. Must be 2 or greater.</summary>
    [JsonPropertyName("maxConnections")]
    public required int MaxConnections { get; set; }

    /// <summary>A username and password stored in Secret Manager.</summary>
    [JsonPropertyName("usernamePassword")]
    public V1alpha1DLPConnectionSpecCloudSQLUsernamePassword? UsernamePassword { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPConnectionSpecProjectRef
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

/// <summary>Required. The connection&apos;s state in its lifecycle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1DLPConnectionSpecStateEnum>))]
public enum V1alpha1DLPConnectionSpecStateEnum
{
    [EnumMember(Value = "CONNECTION_STATE_UNSPECIFIED"), JsonStringEnumMemberName("CONNECTION_STATE_UNSPECIFIED")]
    CONNECTIONSTATEUNSPECIFIED,
    [EnumMember(Value = "MISSING_CREDENTIALS"), JsonStringEnumMemberName("MISSING_CREDENTIALS")]
    MISSINGCREDENTIALS,
    [EnumMember(Value = "AVAILABLE"), JsonStringEnumMemberName("AVAILABLE")]
    AVAILABLE,
    [EnumMember(Value = "ERROR"), JsonStringEnumMemberName("ERROR")]
    ERROR
}

/// <summary>DLPConnectionSpec defines the desired state of DLPConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPConnectionSpec
{
    /// <summary>Connect to a Cloud SQL instance.</summary>
    [JsonPropertyName("cloudSQL")]
    public V1alpha1DLPConnectionSpecCloudSQL? CloudSQL { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DLPConnectionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DLPConnection name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The connection&apos;s state in its lifecycle.</summary>
    [JsonPropertyName("state")]
    public required V1alpha1DLPConnectionSpecStateEnum State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPConnectionStatusConditions
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

/// <summary>Detailed error codes and messages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPConnectionStatusObservedStateErrorsDetails
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPConnectionStatusObservedStateErrors
{
    /// <summary>Detailed error codes and messages.</summary>
    [JsonPropertyName("details")]
    public V1alpha1DLPConnectionStatusObservedStateErrorsDetails? Details { get; set; }

    /// <summary>Additional information about the error.</summary>
    [JsonPropertyName("extraInfo")]
    public string? ExtraInfo { get; set; }

    /// <summary>The times the error occurred. List includes the oldest timestamp and the last 9 timestamps.</summary>
    [JsonPropertyName("timestamps")]
    public IList<string>? Timestamps { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPConnectionStatusObservedState
{
    /// <summary>Output only. Set if status == ERROR, to provide additional details. Will store the last 10 errors sorted with the most recent first.</summary>
    [JsonPropertyName("errors")]
    public IList<V1alpha1DLPConnectionStatusObservedStateErrors>? Errors { get; set; }

    /// <summary>Output only. Name of the connection: `projects/{project}/locations/{location}/connections/{name}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>DLPConnectionStatus defines the config connector machine state of DLPConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DLPConnectionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DLPConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DLPConnection resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DLPConnectionStatusObservedState? ObservedState { get; set; }
}

/// <summary>DLPConnection is the Schema for the DLPConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DLPConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DLPConnectionSpec>, IStatus<V1alpha1DLPConnectionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DLPConnection";
    public const string KubeGroup = "dlp.cnrm.cloud.google.com";
    public const string KubePluralName = "dlpconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dlp.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DLPConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DLPConnectionSpec defines the desired state of DLPConnection</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DLPConnectionSpec Spec { get; set; }

    /// <summary>DLPConnectionStatus defines the config connector machine state of DLPConnection</summary>
    [JsonPropertyName("status")]
    public V1alpha1DLPConnectionStatus? Status { get; set; }
}