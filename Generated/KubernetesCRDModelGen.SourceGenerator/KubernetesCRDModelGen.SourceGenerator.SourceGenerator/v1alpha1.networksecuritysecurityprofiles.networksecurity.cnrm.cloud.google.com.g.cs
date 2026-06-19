#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networksecurity.cnrm.cloud.google.com;
/// <summary>NetworkSecuritySecurityProfile is the Schema for the NetworkSecuritySecurityProfile API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecuritySecurityProfileList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NetworkSecuritySecurityProfile>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecuritySecurityProfileList";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecuritysecurityprofiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecuritySecurityProfileList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NetworkSecuritySecurityProfile objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NetworkSecuritySecurityProfile> Items { get; set; }
}

/// <summary>Required. The target InterceptEndpointGroup. When a firewall rule with this security profile attached matches a packet, the packet will be intercepted to the location-local target in this group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileSpecCustomInterceptProfileInterceptEndpointGroupRef
{
    /// <summary>A reference to an externally managed NetworkSecurityInterceptEndpointGroup resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/interceptEndpointGroups/{{intercept_endpoint_group}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a NetworkSecurityInterceptEndpointGroup resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a NetworkSecurityInterceptEndpointGroup resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The custom TPPI configuration for the SecurityProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileSpecCustomInterceptProfile
{
    /// <summary>Required. The target InterceptEndpointGroup. When a firewall rule with this security profile attached matches a packet, the packet will be intercepted to the location-local target in this group.</summary>
    [JsonPropertyName("interceptEndpointGroupRef")]
    public V1alpha1NetworkSecuritySecurityProfileSpecCustomInterceptProfileInterceptEndpointGroupRef? InterceptEndpointGroupRef { get; set; }
}

/// <summary>Required. Immutable. The target MirroringEndpointGroup. When a mirroring rule with this security profile attached matches a packet, a replica will be mirrored to the location-local target in this group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileSpecCustomMirroringProfileMirroringEndpointGroupRef
{
    /// <summary>A reference to an externally managed NetworkSecurityMirroringEndpointGroup resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/mirroringEndpointGroups/{{mirroring_endpoint_group}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a NetworkSecurityMirroringEndpointGroup resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a NetworkSecurityMirroringEndpointGroup resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The custom Packet Mirroring v2 configuration for the SecurityProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileSpecCustomMirroringProfile
{
    /// <summary>Required. Immutable. The target MirroringEndpointGroup. When a mirroring rule with this security profile attached matches a packet, a replica will be mirrored to the location-local target in this group.</summary>
    [JsonPropertyName("mirroringEndpointGroupRef")]
    public V1alpha1NetworkSecuritySecurityProfileSpecCustomMirroringProfileMirroringEndpointGroupRef? MirroringEndpointGroupRef { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileSpecProjectRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileSpecThreatPreventionProfileAntivirusOverrides
{
    /// <summary>Required. Threat action override. For some threat types, only a subset of actions applies.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Required. Protocol to match.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileSpecThreatPreventionProfileSeverityOverrides
{
    /// <summary>Required. Threat action override.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Required. Severity level to match.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileSpecThreatPreventionProfileThreatOverrides
{
    /// <summary>Required. Threat action override. For some threat types, only a subset of actions applies.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Required. Vendor-specific ID of a threat to override.</summary>
    [JsonPropertyName("threatID")]
    public string? ThreatID { get; set; }
}

/// <summary>The threat prevention configuration for the SecurityProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileSpecThreatPreventionProfile
{
    /// <summary>Optional. Configuration for overriding antivirus actions per protocol.</summary>
    [JsonPropertyName("antivirusOverrides")]
    public IList<V1alpha1NetworkSecuritySecurityProfileSpecThreatPreventionProfileAntivirusOverrides>? AntivirusOverrides { get; set; }

    /// <summary>Optional. Configuration for overriding threats actions by severity match.</summary>
    [JsonPropertyName("severityOverrides")]
    public IList<V1alpha1NetworkSecuritySecurityProfileSpecThreatPreventionProfileSeverityOverrides>? SeverityOverrides { get; set; }

    /// <summary>Optional. Configuration for overriding threats actions by threat_id match. If a threat is matched both by configuration provided in severity_overrides and threat_overrides, the threat_overrides action is applied.</summary>
    [JsonPropertyName("threatOverrides")]
    public IList<V1alpha1NetworkSecuritySecurityProfileSpecThreatPreventionProfileThreatOverrides>? ThreatOverrides { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileSpecUrlFilteringProfileUrlFilters
{
    /// <summary>Required. The action taken when this filter is applied.</summary>
    [JsonPropertyName("filteringAction")]
    public string? FilteringAction { get; set; }

    /// <summary>Required. The priority of this filter within the URL Filtering Profile. Lower integers indicate higher priorities. The priority of a filter must be unique within a URL Filtering Profile.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Required. The list of strings that a URL must match with for this filter to be applied.</summary>
    [JsonPropertyName("urls")]
    public IList<string>? Urls { get; set; }
}

/// <summary>The URL filtering configuration for the SecurityProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileSpecUrlFilteringProfile
{
    /// <summary>Optional. The list of filtering configs in which each config defines an action to take for some URL match.</summary>
    [JsonPropertyName("urlFilters")]
    public IList<V1alpha1NetworkSecuritySecurityProfileSpecUrlFilteringProfileUrlFilters>? UrlFilters { get; set; }
}

/// <summary>NetworkSecuritySecurityProfileSpec defines the desired state of NetworkSecuritySecurityProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileSpec
{
    /// <summary>The custom TPPI configuration for the SecurityProfile.</summary>
    [JsonPropertyName("customInterceptProfile")]
    public V1alpha1NetworkSecuritySecurityProfileSpecCustomInterceptProfile? CustomInterceptProfile { get; set; }

    /// <summary>The custom Packet Mirroring v2 configuration for the SecurityProfile.</summary>
    [JsonPropertyName("customMirroringProfile")]
    public V1alpha1NetworkSecuritySecurityProfileSpecCustomMirroringProfile? CustomMirroringProfile { get; set; }

    /// <summary>Optional. An optional description of the profile. Max length 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Labels as key value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1NetworkSecuritySecurityProfileSpecProjectRef ProjectRef { get; set; }

    /// <summary>The NetworkSecuritySecurityProfile name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The threat prevention configuration for the SecurityProfile.</summary>
    [JsonPropertyName("threatPreventionProfile")]
    public V1alpha1NetworkSecuritySecurityProfileSpecThreatPreventionProfile? ThreatPreventionProfile { get; set; }

    /// <summary>Immutable. The single ProfileType that the SecurityProfile resource configures.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The URL filtering configuration for the SecurityProfile.</summary>
    [JsonPropertyName("urlFilteringProfile")]
    public V1alpha1NetworkSecuritySecurityProfileSpecUrlFilteringProfile? UrlFilteringProfile { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileStatusObservedStateThreatPreventionProfileThreatOverrides
{
    /// <summary>Output only. Type of the threat (read only).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The threat prevention configuration for the SecurityProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileStatusObservedStateThreatPreventionProfile
{
    /// <summary>Optional. Configuration for overriding threats actions by threat_id match. If a threat is matched both by configuration provided in severity_overrides and threat_overrides, the threat_overrides action is applied.</summary>
    [JsonPropertyName("threatOverrides")]
    public IList<V1alpha1NetworkSecuritySecurityProfileStatusObservedStateThreatPreventionProfileThreatOverrides>? ThreatOverrides { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileStatusObservedState
{
    /// <summary>Output only. Resource creation timestamp.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The threat prevention configuration for the SecurityProfile.</summary>
    [JsonPropertyName("threatPreventionProfile")]
    public V1alpha1NetworkSecuritySecurityProfileStatusObservedStateThreatPreventionProfile? ThreatPreventionProfile { get; set; }

    /// <summary>Output only. Last resource update timestamp.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>NetworkSecuritySecurityProfileStatus defines the config connector machine state of NetworkSecuritySecurityProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecuritySecurityProfileStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkSecuritySecurityProfileStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NetworkSecuritySecurityProfile resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NetworkSecuritySecurityProfileStatusObservedState? ObservedState { get; set; }
}

/// <summary>NetworkSecuritySecurityProfile is the Schema for the NetworkSecuritySecurityProfile API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecuritySecurityProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkSecuritySecurityProfileSpec>, IStatus<V1alpha1NetworkSecuritySecurityProfileStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecuritySecurityProfile";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecuritysecurityprofiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecuritySecurityProfile";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkSecuritySecurityProfileSpec defines the desired state of NetworkSecuritySecurityProfile</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1NetworkSecuritySecurityProfileSpec Spec { get; set; }

    /// <summary>NetworkSecuritySecurityProfileStatus defines the config connector machine state of NetworkSecuritySecurityProfile</summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkSecuritySecurityProfileStatus? Status { get; set; }
}