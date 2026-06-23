#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.run.cnrm.cloud.google.com;
/// <summary>RunWorkerPool is the Schema for the RunWorkerPool API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RunWorkerPoolList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1RunWorkerPool>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RunWorkerPoolList";
    public const string KubeGroup = "run.cnrm.cloud.google.com";
    public const string KubePluralName = "runworkerpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "run.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RunWorkerPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1RunWorkerPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1RunWorkerPool> Items { get; set; }
}

/// <summary>Optional. Settings for the Binary Authorization feature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecBinaryAuthorization
{
    /// <summary>Optional. If present, indicates to use Breakglass using this justification. If use_default is False, then it must be empty. For more information on breakglass, see https://cloud.google.com/binary-authorization/docs/using-breakglass</summary>
    [JsonPropertyName("breakglassJustification")]
    public string? BreakglassJustification { get; set; }

    /// <summary>Optional. If True, indicates to use the default project&apos;s binary authorization policy. If False, binary authorization will be disabled.</summary>
    [JsonPropertyName("useDefault")]
    public bool? UseDefault { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecInstanceSplits
{
    /// <summary>Specifies percent of the instance split to this Revision. This defaults to zero if unspecified.</summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }

    /// <summary>Revision to which to assign this portion of instances, if split allocation is by revision.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>The allocation type for this instance split.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecProjectRef
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

/// <summary>Optional. Specifies worker-pool-level scaling settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecScaling
{
    /// <summary>Optional. The total number of instances in manual scaling mode.</summary>
    [JsonPropertyName("manualInstanceCount")]
    public int? ManualInstanceCount { get; set; }
}

/// <summary>Required. The name of the secret in Cloud Secret Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersEnvValueSourceSecretKeyRefSecretRef
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

/// <summary>The Cloud Secret Manager secret version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersEnvValueSourceSecretKeyRefVersionRef
{
    /// <summary>A reference to an externally managed SecretManagerSecretVersion resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secretversions/{{secretversionID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecretVersion resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecretVersion resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Selects a secret and a specific version from Cloud Secret Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersEnvValueSourceSecretKeyRef
{
    /// <summary>Required. The name of the secret in Cloud Secret Manager.</summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1RunWorkerPoolSpecTemplateContainersEnvValueSourceSecretKeyRefSecretRef? SecretRef { get; set; }

    /// <summary>The Cloud Secret Manager secret version.</summary>
    [JsonPropertyName("versionRef")]
    public V1alpha1RunWorkerPoolSpecTemplateContainersEnvValueSourceSecretKeyRefVersionRef? VersionRef { get; set; }
}

/// <summary>Source for the environment variable&apos;s value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersEnvValueSource
{
    /// <summary>Selects a secret and a specific version from Cloud Secret Manager.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1RunWorkerPoolSpecTemplateContainersEnvValueSourceSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersEnv
{
    /// <summary>Required. Name of the environment variable. Must not exceed 32768 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Literal value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable&apos;s value.</summary>
    [JsonPropertyName("valueSource")]
    public V1alpha1RunWorkerPoolSpecTemplateContainersEnvValueSource? ValueSource { get; set; }
}

/// <summary>Optional. GRPC specifies an action involving a gRPC port. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersLivenessProbeGrpc
{
    /// <summary>Optional. Port number of the gRPC service. Number must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Optional. Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md ). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>Required. The header field name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Optional. HTTPGet specifies the http request to perform. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersLivenessProbeHttpGet
{
    /// <summary>Optional. Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RunWorkerPoolSpecTemplateContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Optional. Path to access on the HTTP server. Defaults to &apos;/&apos;.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>Optional. TCPSocket specifies an action involving a TCP port. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersLivenessProbeTcpSocket
{
    /// <summary>Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>Periodic probe of container liveness.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersLivenessProbe
{
    /// <summary>Optional. Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>Optional. GRPC specifies an action involving a gRPC port. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
    [JsonPropertyName("grpc")]
    public V1alpha1RunWorkerPoolSpecTemplateContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary>Optional. HTTPGet specifies the http request to perform. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RunWorkerPoolSpecTemplateContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Optional. Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>Optional. How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeout_seconds.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Optional. TCPSocket specifies an action involving a TCP port. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1RunWorkerPoolSpecTemplateContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Optional. Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than period_seconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid TCP port number, 0 &lt; container_port &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public int? ContainerPort { get; set; }

    /// <summary>If specified, used to specify which protocol to use. Allowed values are &quot;http1&quot; and &quot;h2c&quot;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Compute Resource requirements by this container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersResources
{
    /// <summary>Determines whether CPU is only allocated during requests (true by default). However, if ResourceRequirements is set, the caller must explicitly set this field to true to preserve the default behavior.</summary>
    [JsonPropertyName("cpuIdle")]
    public bool? CpuIdle { get; set; }

    /// <summary>
    /// Only `memory` and `cpu` keys in the map are supported.
    /// 
    ///  &lt;p&gt;Notes:
    ///   * The only supported values for CPU are &apos;1&apos;, &apos;2&apos;, &apos;4&apos;, and &apos;8&apos;. Setting 4
    ///  CPU requires at least 2Gi of memory. For more information, go to
    ///  https://cloud.google.com/run/docs/configuring/cpu.
    ///    * For supported &apos;memory&apos; values and syntax, go to
    ///   https://cloud.google.com/run/docs/configuring/memory-limits
    /// </summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary>Determines whether CPU should be boosted on startup of a new container instance above the requested CPU threshold, this can help reduce cold-start latency.</summary>
    [JsonPropertyName("startupCPUBoost")]
    public bool? StartupCPUBoost { get; set; }
}

/// <summary>Optional. GRPC specifies an action involving a gRPC port. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersStartupProbeGrpc
{
    /// <summary>Optional. Port number of the gRPC service. Number must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Optional. Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md ). If this is not specified, the default behavior is defined by gRPC.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>Required. The header field name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Optional. HTTPGet specifies the http request to perform. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersStartupProbeHttpGet
{
    /// <summary>Optional. Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1alpha1RunWorkerPoolSpecTemplateContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Optional. Path to access on the HTTP server. Defaults to &apos;/&apos;.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>Optional. TCPSocket specifies an action involving a TCP port. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersStartupProbeTcpSocket
{
    /// <summary>Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>Startup probe of application within the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersStartupProbe
{
    /// <summary>Optional. Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>Optional. GRPC specifies an action involving a gRPC port. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
    [JsonPropertyName("grpc")]
    public V1alpha1RunWorkerPoolSpecTemplateContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary>Optional. HTTPGet specifies the http request to perform. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
    [JsonPropertyName("httpGet")]
    public V1alpha1RunWorkerPoolSpecTemplateContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>Optional. Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>Optional. How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeout_seconds.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Optional. TCPSocket specifies an action involving a TCP port. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1alpha1RunWorkerPoolSpecTemplateContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Optional. Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than period_seconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainersVolumeMounts
{
    /// <summary>Required. Path within the container at which the volume should be mounted. Must not contain &apos;:&apos;. For Cloud SQL volumes, it can be left empty, or must otherwise be `/cloudsql`. All instances defined in the Volume will be available as `/cloudsql/[instance]`. For more information on Cloud SQL volumes, visit https://cloud.google.com/sql/docs/mysql/connect-run</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Required. This must match the Name of a Volume.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateContainers
{
    /// <summary>Arguments to the entrypoint.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Base image for this container. Only supported for services.</summary>
    [JsonPropertyName("baseImageURI")]
    public string? BaseImageURI { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Names of the containers that must start before this container.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<string>? DependsOn { get; set; }

    /// <summary>List of environment variables to set in the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1RunWorkerPoolSpecTemplateContainersEnv>? Env { get; set; }

    /// <summary>Required. Name of the container image in Dockerhub, Google Artifact Registry, or Google Container Registry.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Periodic probe of container liveness.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1alpha1RunWorkerPoolSpecTemplateContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Name of the container specified as a DNS_LABEL (RFC 1123).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of ports to expose from the container.</summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1RunWorkerPoolSpecTemplateContainersPorts>? Ports { get; set; }

    /// <summary>Compute Resource requirements by this container.</summary>
    [JsonPropertyName("resources")]
    public V1alpha1RunWorkerPoolSpecTemplateContainersResources? Resources { get; set; }

    /// <summary>Startup probe of application within the container.</summary>
    [JsonPropertyName("startupProbe")]
    public V1alpha1RunWorkerPoolSpecTemplateContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>Volume to mount into the container&apos;s filesystem.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1alpha1RunWorkerPoolSpecTemplateContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container&apos;s working directory.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateEncryptionKeyRef
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

/// <summary>Optional. The node selector for the revision template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateNodeSelector
{
    /// <summary>Required. GPU accelerator type to attach to an instance.</summary>
    [JsonPropertyName("accelerator")]
    public string? Accelerator { get; set; }
}

/// <summary>Optional. Email address of the IAM service account associated with the revision of the service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateServiceAccountRef
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

/// <summary>The Mesh resource name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateServiceMeshMeshRef
{
    /// <summary>A reference to an externally managed NetworkServicesMesh resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/meshes/{{meshID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a NetworkServicesMesh resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a NetworkServicesMesh resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Enables service mesh connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateServiceMesh
{
    /// <summary>The Mesh resource name.</summary>
    [JsonPropertyName("meshRef")]
    public V1alpha1RunWorkerPoolSpecTemplateServiceMeshMeshRef? MeshRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVolumesCloudSQLInstanceInstanceRefs
{
    /// <summary>The SQLInstance selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVolumesCloudSQLInstance
{
    /// <summary>The Cloud SQL instance connection names.</summary>
    [JsonPropertyName("instanceRefs")]
    public IList<V1alpha1RunWorkerPoolSpecTemplateVolumesCloudSQLInstanceInstanceRefs>? InstanceRefs { get; set; }
}

/// <summary>Ephemeral storage used as a shared volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVolumesEmptyDir
{
    /// <summary>The medium on which the data is stored. Acceptable values today is only MEMORY or none. When none, the default will currently be backed by memory but could change over time. +optional</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers. The default is nil which means that the limit is undefined. More info: https://cloud.google.com/run/docs/configuring/in-memory-volumes#configure-volume. Info in Kubernetes: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>Cloud Storage Bucket name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVolumesGcsBucketRef
{
    /// <summary>A reference to an externally managed StorageBucket resource. Should be in the format &quot;projects/{{projectID}}/buckets/{{bucketID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a StorageBucket resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a StorageBucket resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Persistent storage backed by a Google Cloud Storage bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVolumesGcs
{
    /// <summary>Cloud Storage Bucket name.</summary>
    [JsonPropertyName("bucketRef")]
    public V1alpha1RunWorkerPoolSpecTemplateVolumesGcsBucketRef? BucketRef { get; set; }

    /// <summary>A list of additional flags to pass to the gcsfuse CLI.</summary>
    [JsonPropertyName("mountOptions")]
    public IList<string>? MountOptions { get; set; }

    /// <summary>If true, the volume will be mounted as read only for all mounts.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

/// <summary>For NFS Voumes, contains the path to the nfs Volume</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVolumesNfs
{
    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>If true, the volume will be mounted as read only for all mounts.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Hostname or IP address of the NFS server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary>The Cloud Secret Manager secret version. Can be &apos;latest&apos; for the latest value, or an integer or a secret alias for a specific version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVolumesSecretItemsVersionRef
{
    /// <summary>A reference to an externally managed SecretManagerSecretVersion resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secretversions/{{secretversionID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecretVersion resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecretVersion resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVolumesSecretItems
{
    /// <summary>Integer octal mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set, the Volume&apos;s default mode will be used.</summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>Required. The relative path of the secret in the container.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be &apos;latest&apos; for the latest value, or an integer or a secret alias for a specific version.</summary>
    [JsonPropertyName("versionRef")]
    public V1alpha1RunWorkerPoolSpecTemplateVolumesSecretItemsVersionRef? VersionRef { get; set; }
}

/// <summary>Required. The name of the secret in Cloud Secret Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVolumesSecretSecretRef
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

/// <summary>Secret represents a secret that should populate this volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVolumesSecret
{
    /// <summary>Integer representation of mode bits to use on created files by default.</summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>If unspecified, the volume will expose a file whose name is the secret, relative to VolumeMount.mount_path.</summary>
    [JsonPropertyName("items")]
    public IList<V1alpha1RunWorkerPoolSpecTemplateVolumesSecretItems>? Items { get; set; }

    /// <summary>Required. The name of the secret in Cloud Secret Manager.</summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1RunWorkerPoolSpecTemplateVolumesSecretSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVolumes
{
    /// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted.</summary>
    [JsonPropertyName("cloudSQLInstance")]
    public V1alpha1RunWorkerPoolSpecTemplateVolumesCloudSQLInstance? CloudSQLInstance { get; set; }

    /// <summary>Ephemeral storage used as a shared volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1alpha1RunWorkerPoolSpecTemplateVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>Persistent storage backed by a Google Cloud Storage bucket.</summary>
    [JsonPropertyName("gcs")]
    public V1alpha1RunWorkerPoolSpecTemplateVolumesGcs? Gcs { get; set; }

    /// <summary>Required. Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>For NFS Voumes, contains the path to the nfs Volume</summary>
    [JsonPropertyName("nfs")]
    public V1alpha1RunWorkerPoolSpecTemplateVolumesNfs? Nfs { get; set; }

    /// <summary>Secret represents a secret that should populate this volume.</summary>
    [JsonPropertyName("secret")]
    public V1alpha1RunWorkerPoolSpecTemplateVolumesSecret? Secret { get; set; }
}

/// <summary>VPC Access connector name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVpcAccessConnectorRef
{
    /// <summary>A reference to an externally managed VPCAccessConnector resource. Should be in the format `projects/{project_id}/locations/{location}/connectors/{connector_id}`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a VPCAccessConnector resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a VPCAccessConnector resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The VPC network that the Cloud Run resource will be able to send traffic to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVpcAccessNetworkInterfacesNetworkRef
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

/// <summary>Optional. The VPC subnetwork that the Cloud Run resource will get IPs from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVpcAccessNetworkInterfacesSubnetworkRef
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
public partial class V1alpha1RunWorkerPoolSpecTemplateVpcAccessNetworkInterfaces
{
    /// <summary>Optional. The VPC network that the Cloud Run resource will be able to send traffic to.</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1RunWorkerPoolSpecTemplateVpcAccessNetworkInterfacesNetworkRef? NetworkRef { get; set; }

    /// <summary>Optional. The VPC subnetwork that the Cloud Run resource will get IPs from.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1alpha1RunWorkerPoolSpecTemplateVpcAccessNetworkInterfacesSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Optional. Network tags applied to this Cloud Run resource.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary>Optional. VPC Access configuration to use for this Revision.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplateVpcAccess
{
    /// <summary>VPC Access connector name.</summary>
    [JsonPropertyName("connectorRef")]
    public V1alpha1RunWorkerPoolSpecTemplateVpcAccessConnectorRef? ConnectorRef { get; set; }

    /// <summary>Optional. Traffic VPC egress settings.</summary>
    [JsonPropertyName("egress")]
    public string? Egress { get; set; }

    /// <summary>Optional. Direct VPC egress settings. Currently only single network interface is supported.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1alpha1RunWorkerPoolSpecTemplateVpcAccessNetworkInterfaces>? NetworkInterfaces { get; set; }
}

/// <summary>Required. The template used to create revisions for this WorkerPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpecTemplate
{
    /// <summary>Optional. Unstructured key value map that may be set by external tools to store and arbitrary metadata.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Holds list of the containers that defines the unit of execution for this Revision.</summary>
    [JsonPropertyName("containers")]
    public IList<V1alpha1RunWorkerPoolSpecTemplateContainers>? Containers { get; set; }

    /// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image.</summary>
    [JsonPropertyName("encryptionKeyRef")]
    public V1alpha1RunWorkerPoolSpecTemplateEncryptionKeyRef? EncryptionKeyRef { get; set; }

    /// <summary>Optional. The action to take if the encryption key is revoked.</summary>
    [JsonPropertyName("encryptionKeyRevocationAction")]
    public string? EncryptionKeyRevocationAction { get; set; }

    /// <summary>Optional. If encryption_key_revocation_action is SHUTDOWN, the duration before shutting down all instances.</summary>
    [JsonPropertyName("encryptionKeyShutdownDuration")]
    public string? EncryptionKeyShutdownDuration { get; set; }

    /// <summary>Optional. The node selector for the revision template.</summary>
    [JsonPropertyName("nodeSelector")]
    public V1alpha1RunWorkerPoolSpecTemplateNodeSelector? NodeSelector { get; set; }

    /// <summary>Optional. The unique name for the revision. If this field is omitted, it will be automatically generated based on the WorkerPool name.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Optional. Email address of the IAM service account associated with the revision of the service.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1RunWorkerPoolSpecTemplateServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Optional. Enables service mesh connectivity.</summary>
    [JsonPropertyName("serviceMesh")]
    public V1alpha1RunWorkerPoolSpecTemplateServiceMesh? ServiceMesh { get; set; }

    /// <summary>Optional. A list of Volumes to make available to containers.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1RunWorkerPoolSpecTemplateVolumes>? Volumes { get; set; }

    /// <summary>Optional. VPC Access configuration to use for this Revision.</summary>
    [JsonPropertyName("vpcAccess")]
    public V1alpha1RunWorkerPoolSpecTemplateVpcAccess? VpcAccess { get; set; }
}

/// <summary>RunWorkerPoolSpec defines the desired state of RunWorkerPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolSpec
{
    /// <summary>Optional. Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Optional. Settings for the Binary Authorization feature.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1alpha1RunWorkerPoolSpecBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>Arbitrary identifier for the API client.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>Arbitrary version identifier for the API client.</summary>
    [JsonPropertyName("clientVersion")]
    public string? ClientVersion { get; set; }

    /// <summary>Optional. One or more custom audiences that you want this worker pool to support. Specify each custom audience as the full URL in a string.</summary>
    [JsonPropertyName("customAudiences")]
    public IList<string>? CustomAudiences { get; set; }

    /// <summary>User-provided description of the WorkerPool. This field currently has a 512-character limit.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Specifies how to distribute instances over a collection of Revisions belonging to the WorkerPool. If instance split is empty or not provided, defaults to 100% instances assigned to the latest `Ready` Revision.</summary>
    [JsonPropertyName("instanceSplits")]
    public IList<V1alpha1RunWorkerPoolSpecInstanceSplits>? InstanceSplits { get; set; }

    /// <summary>Optional. The launch stage as defined by [Google Cloud Platform Launch Stages](https://cloud.google.com/terms/launch-stages).</summary>
    [JsonPropertyName("launchStage")]
    public string? LaunchStage { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1RunWorkerPoolSpecProjectRef ProjectRef { get; set; }

    /// <summary>The RunWorkerPool name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Specifies worker-pool-level scaling settings</summary>
    [JsonPropertyName("scaling")]
    public V1alpha1RunWorkerPoolSpecScaling? Scaling { get; set; }

    /// <summary>Required. The template used to create revisions for this WorkerPool.</summary>
    [JsonPropertyName("template")]
    public V1alpha1RunWorkerPoolSpecTemplate? Template { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolStatusConditions
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
public partial class V1alpha1RunWorkerPoolStatusObservedStateInstanceSplitStatuses
{
    /// <summary>Specifies percent of the instance split to this Revision.</summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }

    /// <summary>Revision to which this instance split is assigned.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>The allocation type for this instance split.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolStatusObservedStateObservedConditions
{
    /// <summary>A reason for the execution condition.</summary>
    [JsonPropertyName("executionReason")]
    public string? ExecutionReason { get; set; }

    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human readable message indicating details about the current status.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A common (service-level) reason for this condition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>A reason for the revision condition.</summary>
    [JsonPropertyName("revisionReason")]
    public string? RevisionReason { get; set; }

    /// <summary>How to interpret failures of this condition, one of Error, Warning, Info</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>State of the condition.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>type is used to communicate the status of the reconciliation process. See also: https://github.com/knative/serving/blob/main/docs/spec/errors.md#error-conditions-and-reporting Types common to all resources include: * &quot;Ready&quot;: True when the Resource is ready.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Output only. The build info of the container image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolStatusObservedStateTemplateContainersBuildInfo
{
    /// <summary>Output only. Entry point of the function when the image is a Cloud Run function.</summary>
    [JsonPropertyName("functionTarget")]
    public string? FunctionTarget { get; set; }

    /// <summary>Output only. Source code location of the image.</summary>
    [JsonPropertyName("sourceLocation")]
    public string? SourceLocation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolStatusObservedStateTemplateContainers
{
    /// <summary>Output only. The build info of the container image.</summary>
    [JsonPropertyName("buildInfo")]
    public V1alpha1RunWorkerPoolStatusObservedStateTemplateContainersBuildInfo? BuildInfo { get; set; }
}

/// <summary>Required. The template used to create revisions for this WorkerPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolStatusObservedStateTemplate
{
    /// <summary>Holds list of the containers that defines the unit of execution for this Revision.</summary>
    [JsonPropertyName("containers")]
    public IList<V1alpha1RunWorkerPoolStatusObservedStateTemplateContainers>? Containers { get; set; }

    /// <summary>Output only. The unique name for the revision.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

/// <summary>Output only. The Condition of this WorkerPool, containing its readiness status, and detailed error information in case it did not reach a serving state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolStatusObservedStateTerminalCondition
{
    /// <summary>A reason for the execution condition.</summary>
    [JsonPropertyName("executionReason")]
    public string? ExecutionReason { get; set; }

    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human readable message indicating details about the current status.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A common (service-level) reason for this condition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>A reason for the revision condition.</summary>
    [JsonPropertyName("revisionReason")]
    public string? RevisionReason { get; set; }

    /// <summary>How to interpret failures of this condition, one of Error, Warning, Info</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>State of the condition.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>type is used to communicate the status of the reconciliation process. See also: https://github.com/knative/serving/blob/main/docs/spec/errors.md#error-conditions-and-reporting Types common to all resources include: * &quot;Ready&quot;: True when the Resource is ready.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolStatusObservedState
{
    /// <summary>Output only. The creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Email address of the authenticated creator.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>Output only. One or more custom audiences that you want this worker pool to support.</summary>
    [JsonPropertyName("customAudiences")]
    public IList<string>? CustomAudiences { get; set; }

    /// <summary>Output only. The deletion time. It is only populated as a response to a Delete request.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. For a deleted resource, the time after which it will be permanently deleted.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Output only. A number that monotonically increases every time the user modifies the desired state.</summary>
    [JsonPropertyName("generation")]
    public long? Generation { get; set; }

    /// <summary>Output only. Detailed status information for corresponding instance splits.</summary>
    [JsonPropertyName("instanceSplitStatuses")]
    public IList<V1alpha1RunWorkerPoolStatusObservedStateInstanceSplitStatuses>? InstanceSplitStatuses { get; set; }

    /// <summary>Output only. Email address of the last authenticated modifier.</summary>
    [JsonPropertyName("lastModifier")]
    public string? LastModifier { get; set; }

    /// <summary>Output only. Name of the last created revision.</summary>
    [JsonPropertyName("latestCreatedRevision")]
    public string? LatestCreatedRevision { get; set; }

    /// <summary>Output only. Name of the latest revision that is serving traffic.</summary>
    [JsonPropertyName("latestReadyRevision")]
    public string? LatestReadyRevision { get; set; }

    /// <summary>Output only. The Conditions of all other associated sub-resources. They contain additional diagnostics information in case the WorkerPool does not reach its Serving state.</summary>
    [JsonPropertyName("observedConditions")]
    public IList<V1alpha1RunWorkerPoolStatusObservedStateObservedConditions>? ObservedConditions { get; set; }

    /// <summary>Output only. The generation of this WorkerPool currently serving traffic.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Output only. Returns true if the WorkerPool is currently being acted upon by the system to bring it into the desired state.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. Reserved for future use.</summary>
    [JsonPropertyName("satisfiesPzs")]
    public bool? SatisfiesPzs { get; set; }

    /// <summary>Required. The template used to create revisions for this WorkerPool.</summary>
    [JsonPropertyName("template")]
    public V1alpha1RunWorkerPoolStatusObservedStateTemplate? Template { get; set; }

    /// <summary>Output only. The Condition of this WorkerPool, containing its readiness status, and detailed error information in case it did not reach a serving state.</summary>
    [JsonPropertyName("terminalCondition")]
    public V1alpha1RunWorkerPoolStatusObservedStateTerminalCondition? TerminalCondition { get; set; }

    /// <summary>Output only. Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The last-modified time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>RunWorkerPoolStatus defines the config connector machine state of RunWorkerPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RunWorkerPoolStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RunWorkerPoolStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the RunWorkerPool resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1RunWorkerPoolStatusObservedState? ObservedState { get; set; }
}

/// <summary>RunWorkerPool is the Schema for the RunWorkerPool API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RunWorkerPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RunWorkerPoolSpec>, IStatus<V1alpha1RunWorkerPoolStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RunWorkerPool";
    public const string KubeGroup = "run.cnrm.cloud.google.com";
    public const string KubePluralName = "runworkerpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "run.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RunWorkerPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RunWorkerPoolSpec defines the desired state of RunWorkerPool</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1RunWorkerPoolSpec Spec { get; set; }

    /// <summary>RunWorkerPoolStatus defines the config connector machine state of RunWorkerPool</summary>
    [JsonPropertyName("status")]
    public V1alpha1RunWorkerPoolStatus? Status { get; set; }
}