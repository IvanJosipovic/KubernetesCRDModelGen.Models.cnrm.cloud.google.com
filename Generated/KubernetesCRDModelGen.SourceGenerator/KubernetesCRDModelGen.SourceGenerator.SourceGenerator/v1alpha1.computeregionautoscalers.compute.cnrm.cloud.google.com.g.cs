#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>ComputeRegionAutoscaler is the Schema for the ComputeRegionAutoscaler API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeRegionAutoscalerList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ComputeRegionAutoscaler>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeRegionAutoscalerList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeregionautoscalers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeRegionAutoscalerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ComputeRegionAutoscaler objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ComputeRegionAutoscaler> Items { get; set; }
}

/// <summary>Defines the CPU utilization policy that allows the autoscaler to scale based on the average CPU utilization of a managed instance group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyCpuUtilization
{
    /// <summary>Indicates whether predictive autoscaling based on CPU metric is enabled.</summary>
    [JsonPropertyName("predictiveMethod")]
    public string? PredictiveMethod { get; set; }

    /// <summary>The target CPU utilization that the autoscaler maintains.</summary>
    [JsonPropertyName("target")]
    public required double Target { get; set; }
}

/// <summary>Configuration parameters of autoscaling based on load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyLoadBalancingUtilization
{
    /// <summary>Fraction of backend capacity utilization (set in HTTP(s) load balancing configuration) that the autoscaler maintains.</summary>
    [JsonPropertyName("target")]
    public required double Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyMetric
{
    /// <summary>A filter string, compatible with a Stackdriver Monitoring filter string for TimeSeries.list API call.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The identifier (type) of the Stackdriver Monitoring metric.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>If scaling is based on a per-group metric value that represents the total amount of work to be done or resource usage, set this value to an amount assigned for a single instance of the scaled group.</summary>
    [JsonPropertyName("singleInstanceAssignment")]
    public double? SingleInstanceAssignment { get; set; }

    /// <summary>The target value of the metric that autoscaler maintains.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }

    /// <summary>Defines how target utilization value is expressed for a Stackdriver Monitoring metric.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyScaleDownControlMaxScaledDownReplicas
{
    /// <summary>Specifies a fixed number of VM instances. This must be a positive integer.</summary>
    [JsonPropertyName("fixed")]
    public int? Fixed { get; set; }

    /// <summary>Specifies a percentage of instances between 0 to 100%, inclusive.</summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyScaleDownControl
{
    [JsonPropertyName("maxScaledDownReplicas")]
    public V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyScaleDownControlMaxScaledDownReplicas? MaxScaledDownReplicas { get; set; }

    [JsonPropertyName("timeWindowSec")]
    public int? TimeWindowSec { get; set; }
}

/// <summary>Maximum allowed number (or %) of VMs that can be deducted from the peak recommendation during the window.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyScaleInControlMaxScaledInReplicas
{
    /// <summary>Specifies a fixed number of VM instances. This must be a positive integer.</summary>
    [JsonPropertyName("fixed")]
    public int? Fixed { get; set; }

    /// <summary>Specifies a percentage of instances between 0 to 100%, inclusive.</summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyScaleInControl
{
    /// <summary>Maximum allowed number (or %) of VMs that can be deducted from the peak recommendation during the window.</summary>
    [JsonPropertyName("maxScaledInReplicas")]
    public V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyScaleInControlMaxScaledInReplicas? MaxScaledInReplicas { get; set; }

    /// <summary>How far back autoscaling looks when computing recommendations to include directives regarding slower scale in.</summary>
    [JsonPropertyName("timeWindowSec")]
    public int? TimeWindowSec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyScalingSchedules
{
    /// <summary>A description of a scaling schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A boolean value that specifies whether a scaling schedule can influence autoscaler recommendations.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The duration of time intervals, in seconds, for which this scaling schedule is to run.</summary>
    [JsonPropertyName("durationSec")]
    public required int DurationSec { get; set; }

    /// <summary>The minimum number of VM instances that the autoscaler will recommend in time intervals starting according to schedule.</summary>
    [JsonPropertyName("minRequiredReplicas")]
    public required int MinRequiredReplicas { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The start timestamps of time intervals when this scaling schedule is to provide a scaling signal.</summary>
    [JsonPropertyName("schedule")]
    public required string Schedule { get; set; }

    /// <summary>The time zone to use when interpreting the schedule.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>The configuration parameters for the autoscaling algorithm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicy
{
    /// <summary>The number of seconds that your application takes to initialize on a VM instance.</summary>
    [JsonPropertyName("cooldownPeriod")]
    public int? CooldownPeriod { get; set; }

    /// <summary>Defines the CPU utilization policy that allows the autoscaler to scale based on the average CPU utilization of a managed instance group.</summary>
    [JsonPropertyName("cpuUtilization")]
    public V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyCpuUtilization? CpuUtilization { get; set; }

    /// <summary>Configuration parameters of autoscaling based on load balancer.</summary>
    [JsonPropertyName("loadBalancingUtilization")]
    public V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyLoadBalancingUtilization? LoadBalancingUtilization { get; set; }

    /// <summary>The maximum number of instances that the autoscaler can scale out to.</summary>
    [JsonPropertyName("maxReplicas")]
    public required int MaxReplicas { get; set; }

    /// <summary>Configuration parameters of autoscaling based on a custom metric.</summary>
    [JsonPropertyName("metric")]
    public IList<V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyMetric>? Metric { get; set; }

    /// <summary>The minimum number of replicas that the autoscaler can scale in to.</summary>
    [JsonPropertyName("minReplicas")]
    public required int MinReplicas { get; set; }

    /// <summary>Defines the operating mode for this policy.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("scaleDownControl")]
    public V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyScaleDownControl? ScaleDownControl { get; set; }

    [JsonPropertyName("scaleInControl")]
    public V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyScaleInControl? ScaleInControl { get; set; }

    [JsonPropertyName("scalingSchedules")]
    public IList<V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicyScalingSchedules>? ScalingSchedules { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionAutoscalerSpecProjectRef
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

/// <summary>ComputeRegionAutoscalerSpec defines the desired state of ComputeRegionAutoscaler</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionAutoscalerSpec
{
    /// <summary>The configuration parameters for the autoscaling algorithm.</summary>
    [JsonPropertyName("autoscalingPolicy")]
    public required V1alpha1ComputeRegionAutoscalerSpecAutoscalingPolicy AutoscalingPolicy { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1ComputeRegionAutoscalerSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. URL of the region where the instance group resides.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The ComputeRegionAutoscaler name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public required string Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionAutoscalerStatusConditions
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

/// <summary>ComputeRegionAutoscalerStatus defines the config connector machine state of ComputeRegionAutoscaler</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeRegionAutoscalerStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ComputeRegionAutoscalerStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary>ComputeRegionAutoscaler is the Schema for the ComputeRegionAutoscaler API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeRegionAutoscaler : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ComputeRegionAutoscalerSpec>, IStatus<V1alpha1ComputeRegionAutoscalerStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeRegionAutoscaler";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeregionautoscalers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeRegionAutoscaler";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeRegionAutoscalerSpec defines the desired state of ComputeRegionAutoscaler</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ComputeRegionAutoscalerSpec Spec { get; set; }

    /// <summary>ComputeRegionAutoscalerStatus defines the config connector machine state of ComputeRegionAutoscaler</summary>
    [JsonPropertyName("status")]
    public V1alpha1ComputeRegionAutoscalerStatus? Status { get; set; }
}