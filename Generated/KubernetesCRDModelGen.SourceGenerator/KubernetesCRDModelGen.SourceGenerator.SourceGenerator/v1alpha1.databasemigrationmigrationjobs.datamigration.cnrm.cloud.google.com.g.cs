#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datamigration.cnrm.cloud.google.com;
/// <summary>DatabaseMigrationMigrationJob is the Schema for the DatabaseMigrationMigrationJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DatabaseMigrationMigrationJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DatabaseMigrationMigrationJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DatabaseMigrationMigrationJobList";
    public const string KubeGroup = "datamigration.cnrm.cloud.google.com";
    public const string KubePluralName = "databasemigrationmigrationjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datamigration.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseMigrationMigrationJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DatabaseMigrationMigrationJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DatabaseMigrationMigrationJob> Items { get; set; }
}

/// <summary>The CMEK (customer-managed encryption key) fully qualified key name used for the migration job. This field supports all migration jobs types except for: * Mysql to Mysql (use the cmek field in the cloudsql connection profile instead). * PostrgeSQL to PostgreSQL (use the cmek field in the cloudsql connection profile instead). * PostgreSQL to AlloyDB (use the kms_key_name field in the alloydb connection profile instead). Each Cloud CMEK key has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME]</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecCmekKeyNameRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The conversion workspace used by the migration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecConversionWorkspace
{
    /// <summary>The commit ID of the conversion workspace.</summary>
    [JsonPropertyName("commitID")]
    public string? CommitID { get; set; }

    /// <summary>The resource name (URI) of the conversion workspace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The database engine type and provider of the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecDestinationDatabase
{
    /// <summary>The database engine.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The database provider.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }
}

/// <summary>Required. The Connection Profile of the destination connection profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecDestinationRef
{
    /// <summary>A reference to an externally managed DatabaseMigrationConnectionProfile resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/connectionProfiles/{{connectionProfileID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DatabaseMigrationConnectionProfile resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DatabaseMigrationConnectionProfile resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecDumpFlagsDumpFlags
{
    /// <summary>The name of the flag</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the flag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The initial dump flags. This field and the &quot;dump_path&quot; field are mutually exclusive.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecDumpFlags
{
    /// <summary>The flags for the initial dump.</summary>
    [JsonPropertyName("dumpFlags")]
    public IList<V1alpha1DatabaseMigrationMigrationJobSpecDumpFlagsDumpFlags>? DumpFlags { get; set; }
}

/// <summary>Optional. Data dump parallelism settings used by the migration. Currently applicable only for MySQL to Cloud SQL for MySQL migrations only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecPerformanceConfig
{
    /// <summary>Initial dump parallelism level.</summary>
    [JsonPropertyName("dumpParallelLevel")]
    public string? DumpParallelLevel { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecProjectRef
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

/// <summary>The name of the virtual machine (Compute Engine) used as the bastion server for the SSH tunnel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecReverseSSHConnectivityVmRef
{
    /// <summary>A reference to an externally managed ComputeInstance resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/instances/{{instanceID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeInstance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeInstance resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The name of the VPC to peer with the Cloud SQL private network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecReverseSSHConnectivityVpcRef
{
    /// <summary>A reference to an externally managed ComputeNetwork resource. Should be in the format &quot;projects/{{projectID}}/global/networks/{{networkID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The details needed to communicate to the source over Reverse SSH tunnel connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecReverseSSHConnectivity
{
    /// <summary>Required. The IP of the virtual machine (Compute Engine) used as the bastion server for the SSH tunnel.</summary>
    [JsonPropertyName("vmIP")]
    public string? VmIP { get; set; }

    /// <summary>Required. The forwarding port of the virtual machine (Compute Engine) used as the bastion server for the SSH tunnel.</summary>
    [JsonPropertyName("vmPort")]
    public int? VmPort { get; set; }

    /// <summary>The name of the virtual machine (Compute Engine) used as the bastion server for the SSH tunnel.</summary>
    [JsonPropertyName("vmRef")]
    public V1alpha1DatabaseMigrationMigrationJobSpecReverseSSHConnectivityVmRef? VmRef { get; set; }

    /// <summary>The name of the VPC to peer with the Cloud SQL private network.</summary>
    [JsonPropertyName("vpcRef")]
    public V1alpha1DatabaseMigrationMigrationJobSpecReverseSSHConnectivityVpcRef? VpcRef { get; set; }
}

/// <summary>The database engine type and provider of the source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecSourceDatabase
{
    /// <summary>The database engine.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The database provider.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }
}

/// <summary>Required. The Connection Profile resource of the source connection profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecSourceRef
{
    /// <summary>A reference to an externally managed DatabaseMigrationConnectionProfile resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/connectionProfiles/{{connectionProfileID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DatabaseMigrationConnectionProfile resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DatabaseMigrationConnectionProfile resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The name of the VPC network to peer with the Cloud SQL private network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecVpcPeeringConnectivityVpcRef
{
    /// <summary>A reference to an externally managed ComputeNetwork resource. Should be in the format &quot;projects/{{projectID}}/global/networks/{{networkID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The details of the VPC network that the source database is located in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpecVpcPeeringConnectivity
{
    /// <summary>The name of the VPC network to peer with the Cloud SQL private network.</summary>
    [JsonPropertyName("vpcRef")]
    public V1alpha1DatabaseMigrationMigrationJobSpecVpcPeeringConnectivityVpcRef? VpcRef { get; set; }
}

/// <summary>DatabaseMigrationMigrationJobSpec defines the desired state of DatabaseMigrationMigrationJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobSpec
{
    /// <summary>The CMEK (customer-managed encryption key) fully qualified key name used for the migration job. This field supports all migration jobs types except for: * Mysql to Mysql (use the cmek field in the cloudsql connection profile instead). * PostrgeSQL to PostgreSQL (use the cmek field in the cloudsql connection profile instead). * PostgreSQL to AlloyDB (use the kms_key_name field in the alloydb connection profile instead). Each Cloud CMEK key has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME]</summary>
    [JsonPropertyName("cmekKeyNameRef")]
    public V1alpha1DatabaseMigrationMigrationJobSpecCmekKeyNameRef? CmekKeyNameRef { get; set; }

    /// <summary>The conversion workspace used by the migration.</summary>
    [JsonPropertyName("conversionWorkspace")]
    public V1alpha1DatabaseMigrationMigrationJobSpecConversionWorkspace? ConversionWorkspace { get; set; }

    /// <summary>The database engine type and provider of the destination.</summary>
    [JsonPropertyName("destinationDatabase")]
    public V1alpha1DatabaseMigrationMigrationJobSpecDestinationDatabase? DestinationDatabase { get; set; }

    /// <summary>Required. The Connection Profile of the destination connection profile.</summary>
    [JsonPropertyName("destinationRef")]
    public V1alpha1DatabaseMigrationMigrationJobSpecDestinationRef? DestinationRef { get; set; }

    /// <summary>The migration job display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The initial dump flags. This field and the &quot;dump_path&quot; field are mutually exclusive.</summary>
    [JsonPropertyName("dumpFlags")]
    public V1alpha1DatabaseMigrationMigrationJobSpecDumpFlags? DumpFlags { get; set; }

    /// <summary>The path to the dump file in Google Cloud Storage, in the format: (gs://[BUCKET_NAME]/[OBJECT_NAME]). This field and the &quot;dump_flags&quot; field are mutually exclusive.</summary>
    [JsonPropertyName("dumpPath")]
    public string? DumpPath { get; set; }

    /// <summary>This field can be used to select the entities to migrate as part of the migration job. It uses AIP-160 notation to select a subset of the entities configured on the associated conversion-workspace. This field should not be set on migration-jobs that are not associated with a conversion workspace.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// The resource labels for migration job to use to annotate any related
    ///  underlying resources such as Compute Engine VMs. An object containing a
    ///  list of &quot;key&quot;: &quot;value&quot; pairs.
    /// 
    ///  Example: `{ &quot;name&quot;: &quot;wrench&quot;, &quot;mass&quot;: &quot;1.3kg&quot;, &quot;count&quot;: &quot;3&quot; }`.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. Data dump parallelism settings used by the migration. Currently applicable only for MySQL to Cloud SQL for MySQL migrations only.</summary>
    [JsonPropertyName("performanceConfig")]
    public V1alpha1DatabaseMigrationMigrationJobSpecPerformanceConfig? PerformanceConfig { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DatabaseMigrationMigrationJobSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DatabaseMigrationMigrationJob name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The details needed to communicate to the source over Reverse SSH tunnel connectivity.</summary>
    [JsonPropertyName("reverseSSHConnectivity")]
    public V1alpha1DatabaseMigrationMigrationJobSpecReverseSSHConnectivity? ReverseSSHConnectivity { get; set; }

    /// <summary>The database engine type and provider of the source.</summary>
    [JsonPropertyName("sourceDatabase")]
    public V1alpha1DatabaseMigrationMigrationJobSpecSourceDatabase? SourceDatabase { get; set; }

    /// <summary>Required. The Connection Profile resource of the source connection profile.</summary>
    [JsonPropertyName("sourceRef")]
    public V1alpha1DatabaseMigrationMigrationJobSpecSourceRef? SourceRef { get; set; }

    /// <summary>static ip connectivity data (default, no additional details needed).</summary>
    [JsonPropertyName("staticIPConnectivity")]
    public JsonNode? StaticIPConnectivity { get; set; }

    /// <summary>Required. The migration job type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The details of the VPC network that the source database is located in.</summary>
    [JsonPropertyName("vpcPeeringConnectivity")]
    public V1alpha1DatabaseMigrationMigrationJobSpecVpcPeeringConnectivity? VpcPeeringConnectivity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobStatusConditions
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

/// <summary>Output only. The error details in case of state FAILED.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobStatusObservedStateError
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobStatusObservedState
{
    /// <summary>Output only. The timestamp when the migration job resource was created. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The duration of the migration job (in seconds). A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Output only. If the migration job is completed, the time when it was completed.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. The error details in case of state FAILED.</summary>
    [JsonPropertyName("error")]
    public V1alpha1DatabaseMigrationMigrationJobStatusObservedStateError? Error { get; set; }

    /// <summary>Output only. The current migration job phase.</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>Output only. The current migration job state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The timestamp when the migration job resource was last updated. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DatabaseMigrationMigrationJobStatus defines the config connector machine state of DatabaseMigrationMigrationJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatabaseMigrationMigrationJobStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DatabaseMigrationMigrationJobStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DatabaseMigrationMigrationJob resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DatabaseMigrationMigrationJobStatusObservedState? ObservedState { get; set; }
}

/// <summary>DatabaseMigrationMigrationJob is the Schema for the DatabaseMigrationMigrationJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DatabaseMigrationMigrationJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DatabaseMigrationMigrationJobSpec>, IStatus<V1alpha1DatabaseMigrationMigrationJobStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DatabaseMigrationMigrationJob";
    public const string KubeGroup = "datamigration.cnrm.cloud.google.com";
    public const string KubePluralName = "databasemigrationmigrationjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datamigration.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseMigrationMigrationJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DatabaseMigrationMigrationJobSpec defines the desired state of DatabaseMigrationMigrationJob</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DatabaseMigrationMigrationJobSpec Spec { get; set; }

    /// <summary>DatabaseMigrationMigrationJobStatus defines the config connector machine state of DatabaseMigrationMigrationJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1DatabaseMigrationMigrationJobStatus? Status { get; set; }
}