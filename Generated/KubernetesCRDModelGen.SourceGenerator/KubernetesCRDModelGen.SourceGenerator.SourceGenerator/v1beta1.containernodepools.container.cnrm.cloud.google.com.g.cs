#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.container.cnrm.cloud.google.com;
/// <summary>ContainerNodePool is the Schema for the ContainerNodePool API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerNodePoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ContainerNodePool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerNodePoolList";
    public const string KubeGroup = "container.cnrm.cloud.google.com";
    public const string KubePluralName = "containernodepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "container.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContainerNodePoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ContainerNodePool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ContainerNodePool> Items { get; set; }
}

/// <summary>Autoscaler configuration for this NodePool. Autoscaler is enabled only if a valid configuration is present.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecAutoscaling
{
    /// <summary>Location policy used when scaling up a nodepool.</summary>
    [JsonPropertyName("locationPolicy")]
    public string? LocationPolicy { get; set; }

    /// <summary>Maximum number of nodes for one location in the node pool. Must be &gt;= min_node_count. There has to be enough quota to scale up the cluster.</summary>
    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    /// <summary>Minimum number of nodes for one location in the node pool. Must be greater than or equal to 0 and less than or equal to max_node_count.</summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }

    /// <summary>Maximum number of nodes in the node pool. Must be greater than or equal to total_min_node_count. There has to be enough quota to scale up the cluster. The total_*_node_count fields are mutually exclusive with the *_node_count fields.</summary>
    [JsonPropertyName("totalMaxNodeCount")]
    public int? TotalMaxNodeCount { get; set; }

    /// <summary>Minimum number of nodes in the node pool. Must be greater than or equal to 0 and less than or equal to total_max_node_count. The total_*_node_count fields are mutually exclusive with the *_node_count fields.</summary>
    [JsonPropertyName("totalMinNodeCount")]
    public int? TotalMinNodeCount { get; set; }
}

/// <summary>The GKE cluster this node pool belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecClusterRef
{
    /// <summary>The GKE cluster. Valid formats: `projects/{projectID}/locations/{location}/clusters/{clusterID}` `projects/{projectID}/zones/{zone}/clusters/{clusterID}`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names */</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the project resource. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/ */</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>NodeManagement configuration for this NodePool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecManagement
{
    /// <summary>A flag that specifies whether the node auto-repair is enabled for the node pool. If enabled, the nodes in this node pool will be monitored and, if they fail health checks too many times, an automatic repair action will be triggered.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>A flag that specifies whether node auto-upgrade is enabled for the node pool. If enabled, node auto-upgrade helps keep the nodes in your node pool up to date with the latest release version of Kubernetes.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }
}

/// <summary>ComputeNetworkRef is a reference to a GCP ComputeNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNetworkConfigAdditionalNodeNetworkConfigsNetworkRef
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

/// <summary>ComputeSubnetworkRef is a reference to a GCP ComputeSubnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNetworkConfigAdditionalNodeNetworkConfigsSubnetworkRef
{
    /// <summary>A reference to an externally managed ComputeSubnetwork resource. Should be in the format &quot;projects/{{projectID}}/regions/{{region}}/subnetworks/{{subnetworkID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeSubnetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeSubnetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNetworkConfigAdditionalNodeNetworkConfigs
{
    /// <summary>ComputeNetworkRef is a reference to a GCP ComputeNetwork.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ContainerNodePoolSpecNetworkConfigAdditionalNodeNetworkConfigsNetworkRef? NetworkRef { get; set; }

    /// <summary>ComputeSubnetworkRef is a reference to a GCP ComputeSubnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ContainerNodePoolSpecNetworkConfigAdditionalNodeNetworkConfigsSubnetworkRef? SubnetworkRef { get; set; }
}

/// <summary>ComputeSubnetworkRef is a reference to a GCP ComputeSubnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNetworkConfigAdditionalPodNetworkConfigsSubnetworkRef
{
    /// <summary>A reference to an externally managed ComputeSubnetwork resource. Should be in the format &quot;projects/{{projectID}}/regions/{{region}}/subnetworks/{{subnetworkID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeSubnetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeSubnetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNetworkConfigAdditionalPodNetworkConfigs
{
    /// <summary>The maximum number of pods per node which use this pod network.</summary>
    [JsonPropertyName("maxPodsPerNode")]
    public int? MaxPodsPerNode { get; set; }

    /// <summary>The name of the secondary range on the subnet which provides IP address for this pod range.</summary>
    [JsonPropertyName("secondaryPodRange")]
    public string? SecondaryPodRange { get; set; }

    /// <summary>ComputeSubnetworkRef is a reference to a GCP ComputeSubnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ContainerNodePoolSpecNetworkConfigAdditionalPodNetworkConfigsSubnetworkRef? SubnetworkRef { get; set; }
}

/// <summary>[PRIVATE FIELD] Pod CIDR size overprovisioning config for the nodepool. Pod CIDR size per node depends on max_pods_per_node. By default, the value of max_pods_per_node is rounded off to next power of 2 and we then double that to get the size of pod CIDR block per node. Example: max_pods_per_node of 30 would result in 64 IPs (/26). This config can disable the doubling of IPs (we still round off to next power of 2) Example: max_pods_per_node of 30 will result in 32 IPs (/27) when overprovisioning is disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNetworkConfigPodCidrOverprovisionConfig
{
    [JsonPropertyName("disabled")]
    public required bool Disabled { get; set; }
}

/// <summary>ComputeSubnetworkRef is a reference to a GCP ComputeSubnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNetworkConfigSubnetworkRef
{
    /// <summary>A reference to an externally managed ComputeSubnetwork resource. Should be in the format &quot;projects/{{projectID}}/regions/{{region}}/subnetworks/{{subnetworkID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeSubnetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeSubnetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Networking configuration for this NodePool. If specified, it overrides the cluster-level defaults.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNetworkConfig
{
    /// <summary>We specify the additional node networks for this node pool using this list. Each node network corresponds to an additional interface.</summary>
    [JsonPropertyName("additionalNodeNetworkConfigs")]
    public IList<V1beta1ContainerNodePoolSpecNetworkConfigAdditionalNodeNetworkConfigs>? AdditionalNodeNetworkConfigs { get; set; }

    /// <summary>We specify the additional pod networks for this node pool using this list. Each pod network corresponds to an additional alias IP range for the node.</summary>
    [JsonPropertyName("additionalPodNetworkConfigs")]
    public IList<V1beta1ContainerNodePoolSpecNetworkConfigAdditionalPodNetworkConfigs>? AdditionalPodNetworkConfigs { get; set; }

    /// <summary>Input only. Whether to create a new range for pod IPs in this node pool. Defaults are provided for `pod_range` and `pod_ipv4_cidr_block` if they are not specified. If neither `create_pod_range` or `pod_range` are specified, the cluster-level default (`ip_allocation_policy.cluster_ipv4_cidr_block`) is used. Only applicable if `ip_allocation_policy.use_ip_aliases` is true. This field cannot be changed after the node pool has been created.</summary>
    [JsonPropertyName("createPodRange")]
    public bool? CreatePodRange { get; set; }

    /// <summary>Whether nodes have internal IP addresses only. If enable_private_nodes is not specified, then the value is derived from [Cluster.NetworkConfig.default_enable_private_nodes].</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    /// <summary>[PRIVATE FIELD] Pod CIDR size overprovisioning config for the nodepool. Pod CIDR size per node depends on max_pods_per_node. By default, the value of max_pods_per_node is rounded off to next power of 2 and we then double that to get the size of pod CIDR block per node. Example: max_pods_per_node of 30 would result in 64 IPs (/26). This config can disable the doubling of IPs (we still round off to next power of 2) Example: max_pods_per_node of 30 will result in 32 IPs (/27) when overprovisioning is disabled.</summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public V1beta1ContainerNodePoolSpecNetworkConfigPodCidrOverprovisionConfig? PodCidrOverprovisionConfig { get; set; }

    /// <summary>The IP address range for pod IPs in this node pool. Only applicable if `create_pod_range` is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. `/14`) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. `10.96.0.0/14`) to pick a specific range to use. Only applicable if `ip_allocation_policy.use_ip_aliases` is true. This field cannot be changed after the node pool has been created.</summary>
    [JsonPropertyName("podIpv4CidrBlock")]
    public string? PodIpv4CidrBlock { get; set; }

    /// <summary>The ID of the secondary range for pod IPs. If `create_pod_range` is true, this ID is used for the new range. If `create_pod_range` is false, uses an existing secondary range with this ID. Only applicable if `ip_allocation_policy.use_ip_aliases` is true. This field cannot be changed after the node pool has been created.</summary>
    [JsonPropertyName("podRange")]
    public string? PodRange { get; set; }

    /// <summary>ComputeSubnetworkRef is a reference to a GCP ComputeSubnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ContainerNodePoolSpecNetworkConfigSubnetworkRef? SubnetworkRef { get; set; }
}

/// <summary>Immutable. Specifies options for controlling advanced machine features.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigAdvancedMachineFeatures
{
    /// <summary>Immutable. Whether or not to enable nested virtualization (defaults to false).</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Immutable. The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.</summary>
    [JsonPropertyName("threadsPerCore")]
    public int? ThreadsPerCore { get; set; }
}

/// <summary>Immutable. Cryptographic key used to encrypt the boot disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigBootDiskKMSCryptoKeyRef
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

/// <summary>Immutable. Configuration for the confidential nodes feature, which makes nodes run on confidential VMs. Warning: This configuration can&apos;t be changed (or added/removed) after pool creation without deleting and recreating the entire pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigConfidentialNodes
{
    /// <summary>Immutable. Defines the type of technology used by the confidential node.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Immutable. Whether Confidential Nodes feature is enabled for all nodes in this pool.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>Immutable. Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigEphemeralStorageConfig
{
    /// <summary>Immutable. Number of local SSDs to use to back ephemeral storage. Uses NVMe interfaces. Each local SSD must be 375 or 3000 GB in size, and all local SSDs must share the same size.</summary>
    [JsonPropertyName("localSsdCount")]
    public required int LocalSsdCount { get; set; }
}

/// <summary>Immutable. Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigEphemeralStorageLocalSsdConfig
{
    /// <summary>Immutable. Number of local SSDs to be utilized for GKE Data Cache. Uses NVMe interfaces.</summary>
    [JsonPropertyName("dataCacheCount")]
    public int? DataCacheCount { get; set; }

    /// <summary>Immutable. Number of local SSDs to use to back ephemeral storage. Uses NVMe interfaces. Each local SSD must be 375 or 3000 GB in size, and all local SSDs must share the same size.</summary>
    [JsonPropertyName("localSsdCount")]
    public required int LocalSsdCount { get; set; }
}

/// <summary>Enable or disable NCCL Fast Socket in the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigFastSocket
{
    /// <summary>Whether or not NCCL Fast Socket is enabled.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>Immutable. GCFS configuration for this node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigGcfsConfig
{
    /// <summary>Whether or not GCFS is enabled.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>Immutable. Configuration for auto installation of GPU driver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigGuestAcceleratorGpuDriverInstallationConfig
{
    /// <summary>Immutable. Mode for how the GPU driver is installed.</summary>
    [JsonPropertyName("gpuDriverVersion")]
    public required string GpuDriverVersion { get; set; }
}

/// <summary>Immutable. Configuration for GPU sharing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigGuestAcceleratorGpuSharingConfig
{
    /// <summary>Immutable. The type of GPU sharing strategy to enable on the GPU node. Possible values are described in the API package (https://pkg.go.dev/google.golang.org/api/container/v1#GPUSharingConfig).</summary>
    [JsonPropertyName("gpuSharingStrategy")]
    public required string GpuSharingStrategy { get; set; }

    /// <summary>Immutable. The maximum number of containers that can share a GPU.</summary>
    [JsonPropertyName("maxSharedClientsPerGpu")]
    public required int MaxSharedClientsPerGpu { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigGuestAccelerator
{
    /// <summary>Immutable. The number of the accelerator cards exposed to an instance.</summary>
    [JsonPropertyName("count")]
    public required int Count { get; set; }

    /// <summary>Immutable. Configuration for auto installation of GPU driver.</summary>
    [JsonPropertyName("gpuDriverInstallationConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfigGuestAcceleratorGpuDriverInstallationConfig? GpuDriverInstallationConfig { get; set; }

    /// <summary>Immutable. Size of partitions to create on the GPU. Valid values are described in the NVIDIA mig user guide (https://docs.nvidia.com/datacenter/tesla/mig-user-guide/#partitioning).</summary>
    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    /// <summary>Immutable. Configuration for GPU sharing.</summary>
    [JsonPropertyName("gpuSharingConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfigGuestAcceleratorGpuSharingConfig? GpuSharingConfig { get; set; }

    /// <summary>Immutable. The accelerator type resource name.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Immutable. Enable or disable gvnic in the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigGvnic
{
    /// <summary>Immutable. Whether or not gvnic is enabled.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>Immutable. The maintenance policy for the hosts on which the GKE VMs run on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigHostMaintenancePolicy
{
    /// <summary>Immutable. .</summary>
    [JsonPropertyName("maintenanceInterval")]
    public required string MaintenanceInterval { get; set; }
}

/// <summary>Node kubelet configs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigKubeletConfig
{
    /// <summary>Enable CPU CFS quota enforcement for containers that specify CPU limits.</summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary>Set the CPU CFS quota period value &apos;cpu.cfs_period_us&apos;.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>Control the CPU management policy on the node.</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public required string CpuManagerPolicy { get; set; }

    /// <summary>Controls the maximum number of processes allowed to run in a pod.</summary>
    [JsonPropertyName("podPidsLimit")]
    public int? PodPidsLimit { get; set; }
}

/// <summary>Parameters that can be configured on Linux nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigLinuxNodeConfig
{
    /// <summary>cgroupMode specifies the cgroup mode to be used on the node.</summary>
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    /// <summary>The Linux kernel parameters to be applied to the nodes and all pods running on the nodes.</summary>
    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}

/// <summary>Immutable. Parameters for raw-block local NVMe SSDs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigLocalNvmeSsdBlockConfig
{
    /// <summary>Immutable. Number of raw-block local NVMe SSD disks to be attached to the node. Each local SSD is 375 GB in size.</summary>
    [JsonPropertyName("localSsdCount")]
    public required int LocalSsdCount { get; set; }
}

/// <summary>Immutable. Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigNodeGroupRef
{
    /// <summary>A reference to an externally managed ComputeNodeGroup resource. Should be in the format &quot;projects/{{projectID}}/zones/{{zone}}/nodeGroups/{{nodeGroupID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNodeGroup resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNodeGroup resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The reservation affinity configuration for the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigReservationAffinity
{
    /// <summary>Immutable. Corresponds to the type of reservation consumption.</summary>
    [JsonPropertyName("consumeReservationType")]
    public required string ConsumeReservationType { get; set; }

    /// <summary>Immutable. The label key of a reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Immutable. The label values of the reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Immutable. Sandbox configuration for this node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigSandboxConfig
{
    /// <summary>Type of the sandbox to use for the node (e.g. &apos;gvisor&apos;).</summary>
    [JsonPropertyName("sandboxType")]
    public required string SandboxType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigServiceAccountRef
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

/// <summary>Immutable. Shielded Instance options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigShieldedInstanceConfig
{
    /// <summary>Immutable. Defines whether the instance has integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Immutable. Defines whether the instance has Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigSoleTenantConfigNodeAffinity
{
    /// <summary>Immutable. .</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Immutable. .</summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>Immutable. .</summary>
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

/// <summary>Immutable. Node affinity options for sole tenant node pools.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigSoleTenantConfig
{
    /// <summary>Immutable. .</summary>
    [JsonPropertyName("nodeAffinity")]
    public required IList<V1beta1ContainerNodePoolSpecNodeConfigSoleTenantConfigNodeAffinity> NodeAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigTaint
{
    /// <summary>Effect for taint.</summary>
    [JsonPropertyName("effect")]
    public required string Effect { get; set; }

    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value for taint.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>Parameters that can be configured on Windows nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigWindowsNodeConfig
{
    /// <summary>Operating system version of the Windows nodes.</summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}

/// <summary>The workload metadata configuration for this node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfigWorkloadMetadataConfig
{
    /// <summary>Mode is the configuration for how to expose metadata to workloads running on the node.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>DEPRECATED. Deprecated in favor of mode. NodeMetadata is the configuration for how to expose metadata to the workloads running on the node.</summary>
    [JsonPropertyName("nodeMetadata")]
    public string? NodeMetadata { get; set; }
}

/// <summary>The node configuration of the pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecNodeConfig
{
    /// <summary>Immutable. Specifies options for controlling advanced machine features.</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1ContainerNodePoolSpecNodeConfigAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>Immutable. Cryptographic key used to encrypt the boot disk.</summary>
    [JsonPropertyName("bootDiskKMSCryptoKeyRef")]
    public V1beta1ContainerNodePoolSpecNodeConfigBootDiskKMSCryptoKeyRef? BootDiskKMSCryptoKeyRef { get; set; }

    /// <summary>Immutable. Configuration for the confidential nodes feature, which makes nodes run on confidential VMs. Warning: This configuration can&apos;t be changed (or added/removed) after pool creation without deleting and recreating the entire pool.</summary>
    [JsonPropertyName("confidentialNodes")]
    public V1beta1ContainerNodePoolSpecNodeConfigConfidentialNodes? ConfidentialNodes { get; set; }

    /// <summary>Immutable. Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public int? DiskSizeGb { get; set; }

    /// <summary>Immutable. Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd.</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>Immutable. Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk.</summary>
    [JsonPropertyName("ephemeralStorageConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfigEphemeralStorageConfig? EphemeralStorageConfig { get; set; }

    /// <summary>Immutable. Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk.</summary>
    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfigEphemeralStorageLocalSsdConfig? EphemeralStorageLocalSsdConfig { get; set; }

    /// <summary>Enable or disable NCCL Fast Socket in the node pool.</summary>
    [JsonPropertyName("fastSocket")]
    public V1beta1ContainerNodePoolSpecNodeConfigFastSocket? FastSocket { get; set; }

    /// <summary>Immutable. GCFS configuration for this node.</summary>
    [JsonPropertyName("gcfsConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfigGcfsConfig? GcfsConfig { get; set; }

    /// <summary>Immutable. List of the type and count of accelerator cards attached to the instance.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1ContainerNodePoolSpecNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>Immutable. Enable or disable gvnic in the node pool.</summary>
    [JsonPropertyName("gvnic")]
    public V1beta1ContainerNodePoolSpecNodeConfigGvnic? Gvnic { get; set; }

    /// <summary>Immutable. The maintenance policy for the hosts on which the GKE VMs run on.</summary>
    [JsonPropertyName("hostMaintenancePolicy")]
    public V1beta1ContainerNodePoolSpecNodeConfigHostMaintenancePolicy? HostMaintenancePolicy { get; set; }

    /// <summary>The image type to use for this node. Note that for a given image type, the latest version of it will be used.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>Node kubelet configs.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfigKubeletConfig? KubeletConfig { get; set; }

    /// <summary>Immutable. The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to any default label(s) that Kubernetes may apply to the node.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Parameters that can be configured on Linux nodes.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    /// <summary>Immutable. Parameters for raw-block local NVMe SSDs.</summary>
    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfigLocalNvmeSsdBlockConfig? LocalNvmeSsdBlockConfig { get; set; }

    /// <summary>Immutable. The number of local SSD disks to be attached to the node.</summary>
    [JsonPropertyName("localSsdCount")]
    public int? LocalSsdCount { get; set; }

    /// <summary>Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.</summary>
    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }

    /// <summary>Immutable. The name of a Google Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Immutable. The metadata key/value pairs assigned to instances in the cluster.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Immutable. Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Immutable. Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.</summary>
    [JsonPropertyName("nodeGroupRef")]
    public V1beta1ContainerNodePoolSpecNodeConfigNodeGroupRef? NodeGroupRef { get; set; }

    /// <summary>Immutable. The set of Google API scopes to be made available on all of the node VMs.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>Immutable. Whether the nodes are created as preemptible VM instances.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Immutable. The reservation affinity configuration for the node pool.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1ContainerNodePoolSpecNodeConfigReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>The GCE resource labels (a map of key/value pairs) to be applied to the node pool.</summary>
    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    /// <summary>Immutable. Sandbox configuration for this node.</summary>
    [JsonPropertyName("sandboxConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfigSandboxConfig? SandboxConfig { get; set; }

    [JsonPropertyName("serviceAccountRef")]
    public V1beta1ContainerNodePoolSpecNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Immutable. Shielded Instance options.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Immutable. Node affinity options for sole tenant node pools.</summary>
    [JsonPropertyName("soleTenantConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfigSoleTenantConfig? SoleTenantConfig { get; set; }

    /// <summary>Immutable. Whether the nodes are created as spot VM instances.</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    /// <summary>The list of instance tags applied to all nodes.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>List of Kubernetes taints to be applied to each node.</summary>
    [JsonPropertyName("taint")]
    public IList<V1beta1ContainerNodePoolSpecNodeConfigTaint>? Taint { get; set; }

    /// <summary>Parameters that can be configured on Windows nodes.</summary>
    [JsonPropertyName("windowsNodeConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfigWindowsNodeConfig? WindowsNodeConfig { get; set; }

    /// <summary>The workload metadata configuration for this node.</summary>
    [JsonPropertyName("workloadMetadataConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig { get; set; }
}

/// <summary>If set, refers to the name of a custom resource policy supplied by the user. The resource policy must be in the same project and region as the node pool. If not found, InvalidArgument error is returned.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecPlacementPolicyPolicyNameRef
{
    /// <summary>A reference to an externally managed ComputeResourcePolicy resource. Should be in the format &quot;projects/{project}/regions/{region}/resourcePolicies/{resourcePolicy}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeResourcePolicy resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeResourcePolicy resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Specifies the node placement policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecPlacementPolicy
{
    /// <summary>If set, refers to the name of a custom resource policy supplied by the user. The resource policy must be in the same project and region as the node pool. If not found, InvalidArgument error is returned.</summary>
    [JsonPropertyName("policyNameRef")]
    public V1beta1ContainerNodePoolSpecPlacementPolicyPolicyNameRef? PolicyNameRef { get; set; }

    /// <summary>Optional. TPU placement topology for pod slice node pool.</summary>
    [JsonPropertyName("tpuTopology")]
    public string? TpuTopology { get; set; }

    /// <summary>The type of placement.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Standard policy for the blue-green upgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
{
    /// <summary>Number of blue nodes to drain in a batch.</summary>
    [JsonPropertyName("batchNodeCount")]
    public int? BatchNodeCount { get; set; }

    /// <summary>Percentage of the bool pool nodes to drain in a batch. The range of this field should be (0.0, 1.0].</summary>
    [JsonPropertyName("batchPercentage")]
    public double? BatchPercentage { get; set; }

    /// <summary>Soak time after each batch gets drained. A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;.</summary>
    [JsonPropertyName("batchSoakDuration")]
    public string? BatchSoakDuration { get; set; }
}

/// <summary>Settings for blue-green upgrade strategy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecUpgradeSettingsBlueGreenSettings
{
    /// <summary>Time needed after draining entire blue pool. After this period, blue pool will be cleaned up.</summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>Standard policy for the blue-green upgrade.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public required V1beta1ContainerNodePoolSpecUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy StandardRolloutPolicy { get; set; }
}

/// <summary>Upgrade settings control disruption and speed of the upgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpecUpgradeSettings
{
    /// <summary>Settings for blue-green upgrade strategy.</summary>
    [JsonPropertyName("blueGreenSettings")]
    public V1beta1ContainerNodePoolSpecUpgradeSettingsBlueGreenSettings? BlueGreenSettings { get; set; }

    /// <summary>The maximum number of nodes that can be created beyond the current size of the node pool during the upgrade process.</summary>
    [JsonPropertyName("maxSurge")]
    public int? MaxSurge { get; set; }

    /// <summary>The maximum number of nodes that can be simultaneously unavailable during the upgrade process. A node is considered available if its status is Ready.</summary>
    [JsonPropertyName("maxUnavailable")]
    public int? MaxUnavailable { get; set; }

    /// <summary>Update strategy of the node pool.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

/// <summary>ContainerNodePoolSpec defines the desired state of ContainerNodePool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolSpec
{
    /// <summary>Autoscaler configuration for this NodePool. Autoscaler is enabled only if a valid configuration is present.</summary>
    [JsonPropertyName("autoscaling")]
    public V1beta1ContainerNodePoolSpecAutoscaling? Autoscaling { get; set; }

    /// <summary>The GKE cluster this node pool belongs to.</summary>
    [JsonPropertyName("clusterRef")]
    public required V1beta1ContainerNodePoolSpecClusterRef ClusterRef { get; set; }

    /// <summary>The initial node count for the pool. You must ensure that your Compute Engine resource quota is sufficient for this number of instances. You must also have available firewall and routes quota.</summary>
    [JsonPropertyName("initialNodeCount")]
    public int? InitialNodeCount { get; set; }

    /// <summary>Immutable. The location (region or zone) of the cluster.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>NodeManagement configuration for this NodePool.</summary>
    [JsonPropertyName("management")]
    public V1beta1ContainerNodePoolSpecManagement? Management { get; set; }

    /// <summary>The constraint on the maximum number of pods that can be run simultaneously on a node in the node pool.</summary>
    [JsonPropertyName("maxPodsPerNode")]
    public int? MaxPodsPerNode { get; set; }

    /// <summary>Immutable. Creates a unique name for the node pool beginning with the specified prefix. Conflicts with name.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>Networking configuration for this NodePool. If specified, it overrides the cluster-level defaults.</summary>
    [JsonPropertyName("networkConfig")]
    public V1beta1ContainerNodePoolSpecNetworkConfig? NetworkConfig { get; set; }

    /// <summary>The node configuration of the pool.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta1ContainerNodePoolSpecNodeConfig? NodeConfig { get; set; }

    /// <summary>The node count of the pool.</summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    /// <summary>The list of Google Compute Engine zones in which the NodePool&apos;s nodes should be located.</summary>
    [JsonPropertyName("nodeLocations")]
    public IList<string>? NodeLocations { get; set; }

    /// <summary>Specifies the node placement policy.</summary>
    [JsonPropertyName("placementPolicy")]
    public V1beta1ContainerNodePoolSpecPlacementPolicy? PlacementPolicy { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Upgrade settings control disruption and speed of the upgrade.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta1ContainerNodePoolSpecUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>The version of Kubernetes running on this NodePool&apos;s nodes.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolStatusConditions
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

/// <summary>The observed state of the underlying GCP resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolStatusObservedState
{
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>ContainerNodePoolStatus defines the config connector machine state of ContainerNodePool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerNodePoolStatus
{
    /// <summary>Conditions represent the latest available observations of the ContainerNodePool&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ContainerNodePoolStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ContainerNodePool resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>The resource URLs of the managed instance groups associated with this node pool.</summary>
    [JsonPropertyName("instanceGroupUrls")]
    public IList<string>? InstanceGroupUrls { get; set; }

    /// <summary>List of instance group URLs which have been assigned to this node pool.</summary>
    [JsonPropertyName("managedInstanceGroupUrls")]
    public IList<string>? ManagedInstanceGroupUrls { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>The observed state of the underlying GCP resource.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1ContainerNodePoolStatusObservedState? ObservedState { get; set; }

    [JsonPropertyName("operation")]
    public string? Operation { get; set; }
}

/// <summary>ContainerNodePool is the Schema for the ContainerNodePool API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerNodePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ContainerNodePoolSpec>, IStatus<V1beta1ContainerNodePoolStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerNodePool";
    public const string KubeGroup = "container.cnrm.cloud.google.com";
    public const string KubePluralName = "containernodepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "container.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContainerNodePool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ContainerNodePoolSpec defines the desired state of ContainerNodePool</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ContainerNodePoolSpec Spec { get; set; }

    /// <summary>ContainerNodePoolStatus defines the config connector machine state of ContainerNodePool</summary>
    [JsonPropertyName("status")]
    public V1beta1ContainerNodePoolStatus? Status { get; set; }
}