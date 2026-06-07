#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigqueryreservation.cnrm.cloud.google.com;
/// <summary>BigQueryReservationCapacityCommitment is the Schema for the BigQueryReservationCapacityCommitment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryReservationCapacityCommitmentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BigQueryReservationCapacityCommitment>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryReservationCapacityCommitmentList";
    public const string KubeGroup = "bigqueryreservation.cnrm.cloud.google.com";
    public const string KubePluralName = "bigqueryreservationcapacitycommitments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigqueryreservation.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigQueryReservationCapacityCommitmentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1BigQueryReservationCapacityCommitment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1BigQueryReservationCapacityCommitment> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationCapacityCommitmentSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>BigQueryReservationCapacityCommitmentSpec defines the desired state of BigQueryReservationCapacityCommitment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationCapacityCommitmentSpec
{
    /// <summary>Immutable. The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>Immutable. If true, fail the request if another project in the organization has a capacity commitment.</summary>
    [JsonPropertyName("enforceSingleAdminProjectPerOrg")]
    public string? EnforceSingleAdminProjectPerOrg { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Capacity commitment plan. Valid values are at https://cloud.google.com/bigquery/docs/reference/reservations/rpc/google.cloud.bigquery.reservation.v1#commitmentplan.</summary>
    [JsonPropertyName("plan")]
    public required string Plan { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1BigQueryReservationCapacityCommitmentSpecProjectRef ProjectRef { get; set; }

    /// <summary>The plan this capacity commitment is converted to after commitmentEndTime passes. Once the plan is changed, committed period is extended according to commitment plan. Only applicable some commitment plans.</summary>
    [JsonPropertyName("renewalPlan")]
    public string? RenewalPlan { get; set; }

    /// <summary>The BigQueryReservationCapacityCommitment name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Number of slots in this commitment.</summary>
    [JsonPropertyName("slotCount")]
    public required long SlotCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationCapacityCommitmentStatusConditions
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

/// <summary>BigQueryReservationCapacityCommitmentStatus defines the config connector machine state of BigQueryReservationCapacityCommitment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryReservationCapacityCommitmentStatus
{
    /// <summary>The start of the current commitment period. It is applicable only for ACTIVE capacity commitments.</summary>
    [JsonPropertyName("commitmentEndTime")]
    public string? CommitmentEndTime { get; set; }

    /// <summary>The start of the current commitment period. It is applicable only for ACTIVE capacity commitments.</summary>
    [JsonPropertyName("commitmentStartTime")]
    public string? CommitmentStartTime { get; set; }

    /// <summary>Conditions represent the latest available observations of the BigQueryReservationCapacityCommitment&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryReservationCapacityCommitmentStatusConditions>? Conditions { get; set; }

    /// <summary>The resource name of the capacity commitment, e.g., projects/myproject/locations/US/capacityCommitments/123.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>State of the commitment.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>BigQueryReservationCapacityCommitment is the Schema for the BigQueryReservationCapacityCommitment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryReservationCapacityCommitment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigQueryReservationCapacityCommitmentSpec>, IStatus<V1alpha1BigQueryReservationCapacityCommitmentStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryReservationCapacityCommitment";
    public const string KubeGroup = "bigqueryreservation.cnrm.cloud.google.com";
    public const string KubePluralName = "bigqueryreservationcapacitycommitments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigqueryreservation.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigQueryReservationCapacityCommitment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigQueryReservationCapacityCommitmentSpec defines the desired state of BigQueryReservationCapacityCommitment</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1BigQueryReservationCapacityCommitmentSpec Spec { get; set; }

    /// <summary>BigQueryReservationCapacityCommitmentStatus defines the config connector machine state of BigQueryReservationCapacityCommitment</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigQueryReservationCapacityCommitmentStatus? Status { get; set; }
}