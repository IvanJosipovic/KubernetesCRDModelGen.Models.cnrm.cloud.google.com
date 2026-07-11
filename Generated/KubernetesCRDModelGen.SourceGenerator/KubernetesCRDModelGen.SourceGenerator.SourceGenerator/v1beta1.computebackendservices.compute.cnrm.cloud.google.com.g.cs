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
/// <summary>ComputeBackendService is the Schema for the ComputeBackendService API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeBackendServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeBackendService>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeBackendServiceList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computebackendservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeBackendServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ComputeBackendService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ComputeBackendService> Items { get; set; }
}

/// <summary>Reference to a ComputeInstanceGroup resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecBackendGroupInstanceGroupRef
{
    /// <summary>A reference to an externally managed ComputeInstanceGroup resource. Should be in the format &quot;projects/{{projectID}}/zones/{{zone}}/instanceGroups/{{instanceGroupID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeInstanceGroup resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeInstanceGroup resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to a ComputeNetworkEndpointGroup resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecBackendGroupNetworkEndpointGroupRef
{
    /// <summary>A reference to an externally managed ComputeNetworkEndpointGroup resource. Should be in the format &quot;projects/{project}/zones/{zone}/networkEndpointGroups/{networkEndpointGroup}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetworkEndpointGroup resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetworkEndpointGroup resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Reference to a ComputeInstanceGroup or ComputeNetworkEndpointGroup
///  resource. In case of instance group this defines the list of
///  instances that serve traffic. Member virtual machine instances from
///  each instance group must live in the same zone as the instance
///  group itself. No two backends in a backend service are allowed to
///  use same Instance Group resource.
/// 
///  For Network Endpoint Groups this defines list of endpoints. All
///  endpoints of Network Endpoint Group must be hosted on instances
///  located in the same zone as the Network Endpoint Group.
/// 
///  Backend services cannot mix Instance Group and Network Endpoint
///  Group backends.
/// 
///  When the &apos;load_balancing_scheme&apos; is INTERNAL, only instance groups
///  are supported.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecBackendGroup
{
    /// <summary>Reference to a ComputeInstanceGroup resource.</summary>
    [JsonPropertyName("instanceGroupRef")]
    public V1beta1ComputeBackendServiceSpecBackendGroupInstanceGroupRef? InstanceGroupRef { get; set; }

    /// <summary>Reference to a ComputeNetworkEndpointGroup resource.</summary>
    [JsonPropertyName("networkEndpointGroupRef")]
    public V1beta1ComputeBackendServiceSpecBackendGroupNetworkEndpointGroupRef? NetworkEndpointGroupRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecBackend
{
    /// <summary>Specifies the balancing mode for this backend.</summary>
    [JsonPropertyName("balancingMode")]
    public string? BalancingMode { get; set; }

    /// <summary>A multiplier applied to the group&apos;s maximum servicing capacity.</summary>
    [JsonPropertyName("capacityScaler")]
    public double? CapacityScaler { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>This field designates whether this is a failover backend.</summary>
    [JsonPropertyName("failover")]
    public bool? Failover { get; set; }

    /// <summary>
    /// Reference to a ComputeInstanceGroup or ComputeNetworkEndpointGroup
    ///  resource. In case of instance group this defines the list of
    ///  instances that serve traffic. Member virtual machine instances from
    ///  each instance group must live in the same zone as the instance
    ///  group itself. No two backends in a backend service are allowed to
    ///  use same Instance Group resource.
    /// 
    ///  For Network Endpoint Groups this defines list of endpoints. All
    ///  endpoints of Network Endpoint Group must be hosted on instances
    ///  located in the same zone as the Network Endpoint Group.
    /// 
    ///  Backend services cannot mix Instance Group and Network Endpoint
    ///  Group backends.
    /// 
    ///  When the &apos;load_balancing_scheme&apos; is INTERNAL, only instance groups
    ///  are supported.
    /// </summary>
    [JsonPropertyName("group")]
    public required V1beta1ComputeBackendServiceSpecBackendGroup Group { get; set; }

    /// <summary>The max number of simultaneous connections for the group.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>The max number of simultaneous connections that a single backend network endpoint can handle.</summary>
    [JsonPropertyName("maxConnectionsPerEndpoint")]
    public int? MaxConnectionsPerEndpoint { get; set; }

    /// <summary>The max number of simultaneous connections that a single backend instance can handle.</summary>
    [JsonPropertyName("maxConnectionsPerInstance")]
    public int? MaxConnectionsPerInstance { get; set; }

    /// <summary>The max requests per second (RPS) of the group.</summary>
    [JsonPropertyName("maxRate")]
    public int? MaxRate { get; set; }

    /// <summary>The max requests per second (RPS) that a single backend network endpoint can handle.</summary>
    [JsonPropertyName("maxRatePerEndpoint")]
    public double? MaxRatePerEndpoint { get; set; }

    /// <summary>The max requests per second (RPS) that a single backend instance can handle.</summary>
    [JsonPropertyName("maxRatePerInstance")]
    public double? MaxRatePerInstance { get; set; }

    /// <summary>Used when balancingMode is UTILIZATION. This ratio defines the CPU utilization target for the group.</summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecCdnPolicyBypassCacheOnRequestHeaders
{
    /// <summary>The header field name to match on when bypassing cache. Values are case-insensitive.</summary>
    [JsonPropertyName("headerName")]
    public required string HeaderName { get; set; }
}

/// <summary>The CacheKeyPolicy for this CdnPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecCdnPolicyCacheKeyPolicy
{
    /// <summary>If true, requests to different hosts will be cached separately.</summary>
    [JsonPropertyName("includeHost")]
    public bool? IncludeHost { get; set; }

    /// <summary>Allows HTTP request headers (by name) to be used in the cache key.</summary>
    [JsonPropertyName("includeHttpHeaders")]
    public IList<string>? IncludeHttpHeaders { get; set; }

    /// <summary>Allows HTTP cookies (by name) to be used in the cache key. The name=value pair will be used in the cache key Cloud CDN generates.</summary>
    [JsonPropertyName("includeNamedCookies")]
    public IList<string>? IncludeNamedCookies { get; set; }

    /// <summary>If true, http and https requests will be cached separately.</summary>
    [JsonPropertyName("includeProtocol")]
    public bool? IncludeProtocol { get; set; }

    /// <summary>If true, include query string parameters in the cache key according to query_string_whitelist and query_string_blacklist. If neither is set, the entire query string will be included. If false, the query string will be excluded from the cache key entirely.</summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>Names of query string parameters to exclude in cache keys. All other parameters will be included. Either specify query_string_whitelist or query_string_blacklist, not both. &apos; &amp; &apos; and &apos;=&apos; will be percent encoded and not treated as delimiters.</summary>
    [JsonPropertyName("queryStringBlacklist")]
    public IList<string>? QueryStringBlacklist { get; set; }

    /// <summary>Names of query string parameters to include in cache keys. All other parameters will be excluded. Either specify query_string_whitelist or query_string_blacklist, not both. &apos; &amp; &apos; and &apos;=&apos; will be percent encoded and not treated as delimiters.</summary>
    [JsonPropertyName("queryStringWhitelist")]
    public IList<string>? QueryStringWhitelist { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecCdnPolicyNegativeCachingPolicy
{
    /// <summary>The HTTP status code to define a TTL against. Only HTTP status codes 300, 301, 302, 307, 308, 404, 405, 410, 421, 451 and 501 are can be specified as values, and you cannot specify a status code more than once.</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>The TTL (in seconds) for which to cache responses with the corresponding status code. The maximum allowed value is 1800s (30 minutes), noting that infrequently accessed objects may be evicted from the cache before the defined TTL.</summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }
}

/// <summary>Cloud CDN configuration for this BackendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecCdnPolicy
{
    /// <summary>Bypass the cache when the specified request headers are matched - e.g. Pragma or Authorization headers. Up to 5 headers can be specified. The cache is bypassed for all cdnPolicy.cacheMode settings.</summary>
    [JsonPropertyName("bypassCacheOnRequestHeaders")]
    public IList<V1beta1ComputeBackendServiceSpecCdnPolicyBypassCacheOnRequestHeaders>? BypassCacheOnRequestHeaders { get; set; }

    /// <summary>The CacheKeyPolicy for this CdnPolicy.</summary>
    [JsonPropertyName("cacheKeyPolicy")]
    public V1beta1ComputeBackendServiceSpecCdnPolicyCacheKeyPolicy? CacheKeyPolicy { get; set; }

    /// <summary>Specifies the cache setting for all responses from this backend. The possible values are: USE_ORIGIN_HEADERS Requires the origin to set valid caching headers to cache content. Responses without these headers will not be cached at Google&apos;s edge, and will require a full trip to the origin on every request, potentially impacting performance and increasing load on the origin server. FORCE_CACHE_ALL Cache all content, ignoring any &quot;private&quot;, &quot;no-store&quot; or &quot;no-cache&quot; directives in Cache-Control response headers. Warning: this may result in Cloud CDN caching private, per-user (user identifiable) content. CACHE_ALL_STATIC Automatically cache static content, including common image formats, media (video and audio), and web assets (JavaScript and CSS). Requests and responses that are marked as uncacheable, as well as dynamic content (including HTML), will not be cached. If no value is provided for cdnPolicy.cacheMode, it defaults to CACHE_ALL_STATIC. Check the CacheMode enum for the list of possible values.</summary>
    [JsonPropertyName("cacheMode")]
    public string? CacheMode { get; set; }

    /// <summary>Specifies a separate client (e.g. browser client) maximum TTL. This is used to clamp the max-age (or Expires) value sent to the client. With FORCE_CACHE_ALL, the lesser of client_ttl and default_ttl is used for the response max-age directive, along with a &quot;public&quot; directive. For cacheable content in CACHE_ALL_STATIC mode, client_ttl clamps the max-age from the origin (if specified), or else sets the response max-age directive to the lesser of the client_ttl and default_ttl, and also ensures a &quot;public&quot; cache-control directive is present. If a client TTL is not specified, a default value (1 hour) will be used. The maximum allowed value is 31,622,400s (1 year).</summary>
    [JsonPropertyName("clientTtl")]
    public int? ClientTtl { get; set; }

    /// <summary>Specifies the default TTL for cached content served by this origin for responses that do not have an existing valid TTL (max-age or s-maxage). Setting a TTL of &quot;0&quot; means &quot;always revalidate&quot;. The value of defaultTTL cannot be set to a value greater than that of maxTTL, but can be equal. When the cacheMode is set to FORCE_CACHE_ALL, the defaultTTL will overwrite the TTL set in all responses. The maximum allowed value is 31,622,400s (1 year), noting that infrequently accessed objects may be evicted from the cache before the defined TTL.</summary>
    [JsonPropertyName("defaultTtl")]
    public int? DefaultTtl { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin. Cache directives that attempt to set a max-age or s-maxage higher than this, or an Expires header more than maxTTL seconds in the future will be capped at the value of maxTTL, as if it were the value of an s-maxage Cache-Control directive. Headers sent to the client will not be modified. Setting a TTL of &quot;0&quot; means &quot;always revalidate&quot;. The maximum allowed value is 31,622,400s (1 year), noting that infrequently accessed objects may be evicted from the cache before the defined TTL.</summary>
    [JsonPropertyName("maxTtl")]
    public int? MaxTtl { get; set; }

    /// <summary>Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects. This can reduce the load on your origin and improve end-user experience by reducing response latency. When the cache mode is set to CACHE_ALL_STATIC or USE_ORIGIN_HEADERS, negative caching applies to responses with the specified response code that lack any Cache-Control, Expires, or Pragma: no-cache directives. When the cache mode is set to FORCE_CACHE_ALL, negative caching applies to all responses with the specified response code, and override any caching headers. By default, Cloud CDN will apply the following default TTLs to these status codes: HTTP 300 (Multiple Choice), 301, 308 (Permanent Redirects): 10m HTTP 404 (Not Found), 410 (Gone), 451 (Unavailable For Legal Reasons): 120s HTTP 405 (Method Not Found), 421 (Misdirected Request), 501 (Not Implemented): 60s. These defaults can be overridden in negative_caching_policy.</summary>
    [JsonPropertyName("negativeCaching")]
    public bool? NegativeCaching { get; set; }

    /// <summary>Sets a cache TTL for the specified HTTP status code. negative_caching must be enabled to configure negative_caching_policy. Omitting the policy and leaving negative_caching enabled will use Cloud CDN&apos;s default cache TTLs. Note that when specifying an explicit negative_caching_policy, you should take care to specify a cache TTL for all response codes that you wish to cache. Cloud CDN will not apply any default negative caching when a policy exists.</summary>
    [JsonPropertyName("negativeCachingPolicy")]
    public IList<V1beta1ComputeBackendServiceSpecCdnPolicyNegativeCachingPolicy>? NegativeCachingPolicy { get; set; }

    /// <summary>Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache. This setting defines the default &quot;max-stale&quot; duration for any cached responses that do not specify a max-stale directive. Stale responses that exceed the TTL configured here will not be served. The default limit (max-stale) is 86400s (1 day), which will allow stale content to be served up to this limit beyond the max-age (or s-maxage) of a cached response. The maximum allowed value is 604800 (1 week). Set this to zero (0) to disable serve-while-stale.</summary>
    [JsonPropertyName("serveWhileStale")]
    public int? ServeWhileStale { get; set; }

    /// <summary>Maximum number of seconds the response to a signed URL request will be considered fresh. After this time period, the response will be revalidated before being served. Defaults to 1hr (3600s). When serving responses to signed URL requests, Cloud CDN will internally behave as though all responses from this backend had a &quot;Cache-Control: public, max-age=[TTL]&quot; header, regardless of any existing Cache-Control header. The actual headers served in responses will not be altered.</summary>
    [JsonPropertyName("signedUrlCacheMaxAgeSec")]
    public long? SignedUrlCacheMaxAgeSec { get; set; }
}

/// <summary>Not supported by proxy. Connect timeout for the backend service. The timeout is the maximum amount of time KCC will wait for the proxy to connect to the backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecCircuitBreakersConnectTimeout
{
    /// <summary>Span of time that&apos;s a fraction of a second at nanosecond resolution. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

/// <summary>Settings controlling the circuit breaking behavior for this BackendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecCircuitBreakers
{
    /// <summary>Not supported by proxy. Connect timeout for the backend service. The timeout is the maximum amount of time KCC will wait for the proxy to connect to the backend.</summary>
    [JsonPropertyName("connectTimeout")]
    public V1beta1ComputeBackendServiceSpecCircuitBreakersConnectTimeout? ConnectTimeout { get; set; }

    /// <summary>The maximum number of connections to the backend service. If not specified, there is no limit. Not supported when the backend service is referenced by a URL map that is bound to target gRPC proxy that has validateForProxyless field set to true.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>The maximum number of pending requests allowed to the backend service. If not specified, there is no limit. Not supported when the backend service is referenced by a URL map that is bound to target gRPC proxy that has validateForProxyless field set to true.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public int? MaxPendingRequests { get; set; }

    /// <summary>The maximum number of parallel requests that allowed to the backend service. If not specified, there is no limit.</summary>
    [JsonPropertyName("maxRequests")]
    public int? MaxRequests { get; set; }

    /// <summary>Maximum requests for a single connection to the backend service. This parameter is respected by both the HTTP/1.1 and HTTP/2 implementations. If not specified, there is no limit. Setting this parameter to 1 will effectively disable keep alive. Not supported when the backend service is referenced by a URL map that is bound to target gRPC proxy that has validateForProxyless field set to true.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public int? MaxRequestsPerConnection { get; set; }

    /// <summary>The maximum number of parallel retries allowed to the backend cluster. If not specified, the default is 1. Not supported when the backend service is referenced by a URL map that is bound to target gRPC proxy that has validateForProxyless field set to true.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }
}

/// <summary>Connection Tracking configuration for this BackendService. Connection tracking policy settings are only available for external passthrough Network Load Balancers and internal passthrough Network Load Balancers. connectionTrackingPolicy cannot be specified with haPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecConnectionTrackingPolicy
{
    /// <summary>Specifies connection persistence when backends are unhealthy. The default value is DEFAULT_FOR_PROTOCOL. If set to DEFAULT_FOR_PROTOCOL, the existing connections persist on unhealthy backends only for connection-oriented protocols (TCP and SCTP) and only if the Tracking Mode is PER_CONNECTION (default tracking mode) or the Session Affinity is configured for 5-tuple. They do not persist for UDP. If set to NEVER_PERSIST, after a backend becomes unhealthy, the existing connections on the unhealthy backend are never persisted on the unhealthy backend. They are always diverted to newly selected healthy backends (unless all backends are unhealthy). If set to ALWAYS_PERSIST, existing connections always persist on unhealthy backends regardless of protocol and session affinity. It is generally not recommended to use this mode overriding the default. For more details, see [Connection Persistence for Network Load Balancing](https://cloud.google.com/load-balancing/docs/network/networklb-backend-service#connection-persistence) and [Connection Persistence for Internal TCP/UDP Load Balancing](https://cloud.google.com/load-balancing/docs/internal#connection-persistence). Check the ConnectionPersistenceOnUnhealthyBackends enum for the list of possible values.</summary>
    [JsonPropertyName("connectionPersistenceOnUnhealthyBackends")]
    public string? ConnectionPersistenceOnUnhealthyBackends { get; set; }

    /// <summary>Enable Strong Session Affinity for external passthrough Network Load Balancers. This option is not available publicly.</summary>
    [JsonPropertyName("enableStrongAffinity")]
    public bool? EnableStrongAffinity { get; set; }

    /// <summary>Specifies how long to keep a Connection Tracking entry while there is no matching traffic (in seconds). For internal passthrough Network Load Balancers: - The minimum (default) is 10 minutes and the maximum is 16 hours. - It can be set only if Connection Tracking is less than 5-tuple (i.e. Session Affinity is CLIENT_IP_NO_DESTINATION, CLIENT_IP or CLIENT_IP_PROTO, and Tracking Mode is PER_SESSION). For external passthrough Network Load Balancers the default is 60 seconds. This option is not available publicly.</summary>
    [JsonPropertyName("idleTimeoutSec")]
    public int? IdleTimeoutSec { get; set; }

    /// <summary>Specifies the key used for connection tracking. There are two options: - PER_CONNECTION: This is the default mode. The Connection Tracking is performed as per the Connection Key (default Hash Method) for the specific protocol. - PER_SESSION: The Connection Tracking is performed as per the configured Session Affinity. It matches the configured Session Affinity. For more details, see [Tracking Mode for Network Load Balancing](https://cloud.google.com/load-balancing/docs/network/networklb-backend-service#tracking-mode) and [Tracking Mode for Internal TCP/UDP Load Balancing](https://cloud.google.com/load-balancing/docs/internal#tracking-mode). Check the TrackingMode enum for the list of possible values.</summary>
    [JsonPropertyName("trackingMode")]
    public string? TrackingMode { get; set; }
}

/// <summary>Lifetime of the cookie.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecConsistentHashHttpCookieTtl
{
    /// <summary>Span of time that&apos;s a fraction of a second at nanosecond resolution. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

/// <summary>Hash session affinity settings when using STRONG_COOKIE_AFFINITY or STRONG_HEADER_AFFINITY.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecConsistentHashHttpCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie.</summary>
    [JsonPropertyName("ttl")]
    public V1beta1ComputeBackendServiceSpecConsistentHashHttpCookieTtl? Ttl { get; set; }
}

/// <summary>Consistent Hash-based load balancing can be used to provide soft session affinity based on HTTP headers, cookies or other properties. This load balancing policy is applicable only for HTTP connections. The affinity to a particular destination host will be lost when one or more hosts are added/removed from the destination service. This field specifies parameters that control consistent hashing. This field is only applicable when localityLbPolicy is set to MAGLEV or RING_HASH. This field is applicable to either: - A regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and load_balancing_scheme set to INTERNAL_MANAGED. - A global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecConsistentHash
{
    /// <summary>Hash session affinity settings when using STRONG_COOKIE_AFFINITY or STRONG_HEADER_AFFINITY.</summary>
    [JsonPropertyName("httpCookie")]
    public V1beta1ComputeBackendServiceSpecConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>The name of the HTTP header field to map onto. Required if the load balancing policy is MAGLEV or RING_HASH and session affinity is STRONG_HEADER_AFFINITY.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>The minimum ring size. Valid values are between 1 and 4096. Required if the load balancing policy is RING_HASH.</summary>
    [JsonPropertyName("minimumRingSize")]
    public long? MinimumRingSize { get; set; }
}

/// <summary>ComputeSecurityPolicyRef is a reference to a ComputeSecurityPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecEdgeSecurityPolicyRef
{
    /// <summary>A reference to an externally managed ComputeSecurityPolicy resource. Should be in the format &quot;projects/{{projectID}}/global/securityPolicies/{{name}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeSecurityPolicy resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeSecurityPolicy resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Requires at least one backend instance group to be defined as a backup (failover) backend. For load balancers that have configurable failover: [Internal passthrough Network Load Balancers](https://cloud.google.com/load-balancing/docs/internal/failover-overview) and [external passthrough Network Load Balancers](https://cloud.google.com/load-balancing/docs/network/networklb-failover-overview). failoverPolicy cannot be specified with haPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecFailoverPolicy
{
    /// <summary>This can be set to true only if the protocol is TCP. The default is false.</summary>
    [JsonPropertyName("disableConnectionDrainOnFailover")]
    public bool? DisableConnectionDrainOnFailover { get; set; }

    /// <summary>If set to true, connections to the load balancer are dropped when all primary and all backup backend VMs are unhealthy.If set to false, connections are distributed among all primary VMs when all primary and all backup backend VMs are unhealthy. For load balancers that have configurable failover: [Internal passthrough Network Load Balancers](https://cloud.google.com/load-balancing/docs/internal/failover-overview) and [external passthrough Network Load Balancers](https://cloud.google.com/load-balancing/docs/network/networklb-failover-overview). The default is false.</summary>
    [JsonPropertyName("dropTrafficIfUnhealthy")]
    public bool? DropTrafficIfUnhealthy { get; set; }

    /// <summary>The value of the field must be in the range [0, 1]. If the value is 0, the load balancer performs a failover when the number of healthy primary VMs equals zero. For all other values, the load balancer performs a failover when the total number of healthy primary VMs is less than this ratio. For load balancers that have configurable failover: [Internal TCP/UDP Load Balancing](https://cloud.google.com/load-balancing/docs/internal/failover-overview) and [external TCP/UDP Load Balancing](https://cloud.google.com/load-balancing/docs/network/networklb-failover-overview).</summary>
    [JsonPropertyName("failoverRatio")]
    public double? FailoverRatio { get; set; }
}

/// <summary>Reference to a ComputeHealthCheck resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecHealthChecksHealthCheckRef
{
    /// <summary>
    /// The URL for the health check that signals autohealing.
    /// 
    /// Allowed value: The `selfLink` field of a `ComputeHealthCheck` resource.
    /// </summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to a ComputeHTTPHealthCheck resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecHealthChecksHttpHealthCheckRef
{
    /// <summary>A reference to an externally managed ComputeHTTPHealthCheck resource. Should be in the format &quot;projects/{{projectID}}/global/httpHealthChecks/{{httpHealthCheckID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeHTTPHealthCheck resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeHTTPHealthCheck resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The health check resources for health checking this ComputeBackendService. Currently at most one health check can be specified, and a health check is required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecHealthChecks
{
    /// <summary>Reference to a ComputeHealthCheck resource.</summary>
    [JsonPropertyName("healthCheckRef")]
    public V1beta1ComputeBackendServiceSpecHealthChecksHealthCheckRef? HealthCheckRef { get; set; }

    /// <summary>Reference to a ComputeHTTPHealthCheck resource.</summary>
    [JsonPropertyName("httpHealthCheckRef")]
    public V1beta1ComputeBackendServiceSpecHealthChecksHttpHealthCheckRef? HttpHealthCheckRef { get; set; }
}

/// <summary>Reference to a ComputeBackendServiceOauth2ClientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecIapOauth2ClientIdRef
{
    /// <summary>External is the Google OAuth2 Client ID, e.g. `CLIENT_ID.apps.googleusercontent.com` matching the Cloud Asset Inventory Format.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource&apos;s namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecIapOauth2ClientSecretValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Source for the field&apos;s value. Cannot be used if &apos;value&apos; is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecIapOauth2ClientSecretValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource&apos;s namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ComputeBackendServiceSpecIapOauth2ClientSecretValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>OAuth2 client secret to use for the authentication flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecIapOauth2ClientSecret
{
    /// <summary>Value of the field. Cannot be used if &apos;valueFrom&apos; is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field&apos;s value. Cannot be used if &apos;value&apos; is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ComputeBackendServiceSpecIapOauth2ClientSecretValueFrom? ValueFrom { get; set; }
}

/// <summary>The configurations for Identity-Aware Proxy on this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecIap
{
    /// <summary>OAuth2 client ID to use for the authentication flow.</summary>
    [JsonPropertyName("oauth2ClientId")]
    public string? Oauth2ClientId { get; set; }

    /// <summary>Reference to a ComputeBackendServiceOauth2ClientId.</summary>
    [JsonPropertyName("oauth2ClientIdRef")]
    public V1beta1ComputeBackendServiceSpecIapOauth2ClientIdRef? Oauth2ClientIdRef { get; set; }

    /// <summary>OAuth2 client secret to use for the authentication flow.</summary>
    [JsonPropertyName("oauth2ClientSecret")]
    public V1beta1ComputeBackendServiceSpecIapOauth2ClientSecret? Oauth2ClientSecret { get; set; }

    /// <summary>[Output Only] SHA256 hash value for the field oauth2_client_secret above.</summary>
    [JsonPropertyName("oauth2ClientSecretSha256")]
    public string? Oauth2ClientSecretSha256 { get; set; }
}

/// <summary>The configuration for a custom policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecLocalityLbPoliciesCustomPolicy
{
    /// <summary>An optional, arbitrary JSON object with configuration data.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>The name of a custom policy.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>The configuration for a predefined policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecLocalityLbPoliciesPolicy
{
    /// <summary>The name of a locality load balancing policy.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecLocalityLbPolicies
{
    /// <summary>The configuration for a custom policy.</summary>
    [JsonPropertyName("customPolicy")]
    public V1beta1ComputeBackendServiceSpecLocalityLbPoliciesCustomPolicy? CustomPolicy { get; set; }

    /// <summary>The configuration for a predefined policy.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeBackendServiceSpecLocalityLbPoliciesPolicy? Policy { get; set; }
}

/// <summary>This field denotes the logging options for the load balancer traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecLogConfig
{
    /// <summary>This field denotes whether to enable logging for the load balancer traffic.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>This field defines the log sampling rate.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>ComputeNetworkRef is a reference to a GCP ComputeNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecNetworkRef
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

/// <summary>The base time that a host is ejected for. The real time is equal to the base ejection time multiplied by the number of times the host has been ejected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecOutlierDetectionBaseEjectionTime
{
    /// <summary>Span of time that&apos;s a fraction of a second at nanosecond resolution. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

/// <summary>Time interval between ejection sweep analysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecOutlierDetectionInterval
{
    /// <summary>Span of time that&apos;s a fraction of a second at nanosecond resolution. Must be from 0 to 999,999,999 inclusive.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.</summary>
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

/// <summary>Settings controlling the ejection of unhealthy backend endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecOutlierDetection
{
    /// <summary>The base time that a host is ejected for. The real time is equal to the base ejection time multiplied by the number of times the host has been ejected.</summary>
    [JsonPropertyName("baseEjectionTime")]
    public V1beta1ComputeBackendServiceSpecOutlierDetectionBaseEjectionTime? BaseEjectionTime { get; set; }

    /// <summary>Number of consecutive errors before ejection.</summary>
    [JsonPropertyName("consecutiveErrors")]
    public int? ConsecutiveErrors { get; set; }

    /// <summary>Number of consecutive gateway failures before ejection.</summary>
    [JsonPropertyName("consecutiveGatewayFailure")]
    public int? ConsecutiveGatewayFailure { get; set; }

    /// <summary>Percentage of consecutive errors to enforce.</summary>
    [JsonPropertyName("enforcingConsecutiveErrors")]
    public int? EnforcingConsecutiveErrors { get; set; }

    /// <summary>Percentage of consecutive gateway failures to enforce.</summary>
    [JsonPropertyName("enforcingConsecutiveGatewayFailure")]
    public int? EnforcingConsecutiveGatewayFailure { get; set; }

    /// <summary>Percentage of success rate to enforce.</summary>
    [JsonPropertyName("enforcingSuccessRate")]
    public int? EnforcingSuccessRate { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public V1beta1ComputeBackendServiceSpecOutlierDetectionInterval? Interval { get; set; }

    /// <summary>Maximum percentage of hosts that can be ejected.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public int? MaxEjectionPercent { get; set; }

    /// <summary>Minimum number of hosts for success rate analysis.</summary>
    [JsonPropertyName("successRateMinimumHosts")]
    public int? SuccessRateMinimumHosts { get; set; }

    /// <summary>Minimum request volume for success rate analysis.</summary>
    [JsonPropertyName("successRateRequestVolume")]
    public int? SuccessRateRequestVolume { get; set; }

    /// <summary>Standard deviation factor for success rate analysis.</summary>
    [JsonPropertyName("successRateStdevFactor")]
    public int? SuccessRateStdevFactor { get; set; }
}

/// <summary>ComputeSecurityPolicyRef is a reference to a ComputeSecurityPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecSecurityPolicyRef
{
    /// <summary>A reference to an externally managed ComputeSecurityPolicy resource. Should be in the format &quot;projects/{{projectID}}/global/securityPolicies/{{name}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeSecurityPolicy resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeSecurityPolicy resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to a ComputeSecuritySettingsClientTLSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecSecuritySettingsClientTLSPolicyRef
{
    /// <summary>External is the selfLink of the referent.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>This field specifies the security settings that apply to this backend service. This field is applicable to a global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecSecuritySettings
{
    /// <summary>Reference to a ComputeSecuritySettingsClientTLSPolicy.</summary>
    [JsonPropertyName("clientTLSPolicyRef")]
    public required V1beta1ComputeBackendServiceSpecSecuritySettingsClientTLSPolicyRef ClientTLSPolicyRef { get; set; }

    /// <summary>Subject Alternative Names.</summary>
    [JsonPropertyName("subjectAltNames")]
    public required IList<string> SubjectAltNames { get; set; }
}

/// <summary>subsetting cannot be specified with haPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpecSubsetting
{
    /// <summary>The subsetting policy. The only supported policy is CONSISTENT_HASH_SUBSETTING.</summary>
    [JsonPropertyName("policy")]
    public required string Policy { get; set; }
}

/// <summary>The desired state of the ComputeBackendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceSpec
{
    /// <summary>Lifetime of cookies in seconds if session_affinity is GENERATED_COOKIE.</summary>
    [JsonPropertyName("affinityCookieTtlSec")]
    public int? AffinityCookieTtlSec { get; set; }

    /// <summary>The set of backends that serve this BackendService.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta1ComputeBackendServiceSpecBackend>? Backend { get; set; }

    /// <summary>Cloud CDN configuration for this BackendService.</summary>
    [JsonPropertyName("cdnPolicy")]
    public V1beta1ComputeBackendServiceSpecCdnPolicy? CdnPolicy { get; set; }

    /// <summary>Settings controlling the circuit breaking behavior for this BackendService.</summary>
    [JsonPropertyName("circuitBreakers")]
    public V1beta1ComputeBackendServiceSpecCircuitBreakers? CircuitBreakers { get; set; }

    /// <summary>Compress text responses using Brotli or gzip compression, based on the client&apos;s Accept-Encoding header.</summary>
    [JsonPropertyName("compressionMode")]
    public string? CompressionMode { get; set; }

    /// <summary>Time for which instance will be drained (not accept new connections, but still work to finish started).</summary>
    [JsonPropertyName("connectionDrainingTimeoutSec")]
    public int? ConnectionDrainingTimeoutSec { get; set; }

    /// <summary>Connection Tracking configuration for this BackendService. Connection tracking policy settings are only available for external passthrough Network Load Balancers and internal passthrough Network Load Balancers. connectionTrackingPolicy cannot be specified with haPolicy.</summary>
    [JsonPropertyName("connectionTrackingPolicy")]
    public V1beta1ComputeBackendServiceSpecConnectionTrackingPolicy? ConnectionTrackingPolicy { get; set; }

    /// <summary>Consistent Hash-based load balancing can be used to provide soft session affinity based on HTTP headers, cookies or other properties. This load balancing policy is applicable only for HTTP connections. The affinity to a particular destination host will be lost when one or more hosts are added/removed from the destination service. This field specifies parameters that control consistent hashing. This field is only applicable when localityLbPolicy is set to MAGLEV or RING_HASH. This field is applicable to either: - A regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and load_balancing_scheme set to INTERNAL_MANAGED. - A global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("consistentHash")]
    public V1beta1ComputeBackendServiceSpecConsistentHash? ConsistentHash { get; set; }

    /// <summary>Headers that the load balancer adds to proxied requests. See [Creating custom headers](https://cloud.google.com/load-balancing/docs/custom-headers).</summary>
    [JsonPropertyName("customRequestHeaders")]
    public IList<string>? CustomRequestHeaders { get; set; }

    /// <summary>Headers that the load balancer adds to proxied responses. See [Creating custom headers](https://cloud.google.com/load-balancing/docs/custom-headers).</summary>
    [JsonPropertyName("customResponseHeaders")]
    public IList<string>? CustomResponseHeaders { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ComputeSecurityPolicyRef is a reference to a ComputeSecurityPolicy.</summary>
    [JsonPropertyName("edgeSecurityPolicyRef")]
    public V1beta1ComputeBackendServiceSpecEdgeSecurityPolicyRef? EdgeSecurityPolicyRef { get; set; }

    /// <summary>If true, enables Cloud CDN for the backend service.</summary>
    [JsonPropertyName("enableCdn")]
    public bool? EnableCdn { get; set; }

    /// <summary>Requires at least one backend instance group to be defined as a backup (failover) backend. For load balancers that have configurable failover: [Internal passthrough Network Load Balancers](https://cloud.google.com/load-balancing/docs/internal/failover-overview) and [external passthrough Network Load Balancers](https://cloud.google.com/load-balancing/docs/network/networklb-failover-overview). failoverPolicy cannot be specified with haPolicy.</summary>
    [JsonPropertyName("failoverPolicy")]
    public V1beta1ComputeBackendServiceSpecFailoverPolicy? FailoverPolicy { get; set; }

    [JsonPropertyName("healthChecks")]
    public IList<V1beta1ComputeBackendServiceSpecHealthChecks>? HealthChecks { get; set; }

    /// <summary>The configurations for Identity-Aware Proxy on this resource.</summary>
    [JsonPropertyName("iap")]
    public V1beta1ComputeBackendServiceSpecIap? Iap { get; set; }

    /// <summary>Specifies the load balancer type.</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>A list of locality load-balancing policies to be used in order of preference. When you use localityLbPolicies, you must set at least one value for either the localityLbPolicies[].policy or the localityLbPolicies[].customPolicy field. localityLbPolicies overrides any value set in the localityLbPolicy field. For an example of how to use this field, see Define a list of preferred policies. Caution: This field and its children are intended for use in a service mesh that includes gRPC clients only. Envoy proxies can&apos;t use backend services that have this configuration.</summary>
    [JsonPropertyName("localityLbPolicies")]
    public IList<V1beta1ComputeBackendServiceSpecLocalityLbPolicies>? LocalityLbPolicies { get; set; }

    /// <summary>The load balancing algorithm used within the scope of the locality.</summary>
    [JsonPropertyName("localityLbPolicy")]
    public string? LocalityLbPolicy { get; set; }

    /// <summary>Location of the resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>This field denotes the logging options for the load balancer traffic.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta1ComputeBackendServiceSpecLogConfig? LogConfig { get; set; }

    /// <summary>ComputeNetworkRef is a reference to a GCP ComputeNetwork.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ComputeBackendServiceSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>Settings controlling the ejection of unhealthy backend endpoints.</summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta1ComputeBackendServiceSpecOutlierDetection? OutlierDetection { get; set; }

    /// <summary>A named port on a backend instance group representing the port for communication to the backend VMs in that group. The named port must be [defined on each backend instance group](https://cloud.google.com/load-balancing/docs/backend-service#named_ports). This parameter has no meaning if the backends are NEGs. For internal passthrough Network Load Balancers and external passthrough Network Load Balancers, omit port_name.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>The protocol this BackendService uses to communicate with backends. Possible values are HTTP, HTTPS, HTTP2, H2C, TCP, SSL, UDP or GRPC. depending on the chosen load balancer or Traffic Director configuration. Refer to the documentation for the load balancers or for Traffic Director for more information. Must be set to GRPC when the backend service is referenced by a URL map that is bound to target gRPC proxy.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The ComputeBackendService name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The URL of the security policy associated with this backend service.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>ComputeSecurityPolicyRef is a reference to a ComputeSecurityPolicy.</summary>
    [JsonPropertyName("securityPolicyRef")]
    public V1beta1ComputeBackendServiceSpecSecurityPolicyRef? SecurityPolicyRef { get; set; }

    /// <summary>This field specifies the security settings that apply to this backend service. This field is applicable to a global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("securitySettings")]
    public V1beta1ComputeBackendServiceSpecSecuritySettings? SecuritySettings { get; set; }

    /// <summary>Type of session affinity to use. The default is NONE. Only NONE and HEADER_FIELD are supported when the backend service is referenced by a URL map that is bound to target gRPC proxy that has validateForProxyless field set to true. For more details, see: [Session Affinity](https://cloud.google.com/load-balancing/docs/backend-service#session_affinity). sessionAffinity cannot be specified with haPolicy.</summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>subsetting cannot be specified with haPolicy.</summary>
    [JsonPropertyName("subsetting")]
    public V1beta1ComputeBackendServiceSpecSubsetting? Subsetting { get; set; }

    /// <summary>The backend service timeout.</summary>
    [JsonPropertyName("timeoutSec")]
    public int? TimeoutSec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceStatusConditions
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

/// <summary>The observed state of the ComputeBackendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeBackendServiceStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeBackendServiceStatusConditions>? Conditions { get; set; }

    /// <summary>[Output Only] Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>Fingerprint of this resource. A hash of the contents stored in this object.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>[Output Only] The unique identifier for the resource. This identifier is defined by the server.</summary>
    [JsonPropertyName("generatedId")]
    public long? GeneratedId { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>[Output Only] Server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary>ComputeBackendService is the Schema for the ComputeBackendService API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeBackendService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeBackendServiceSpec>, IStatus<V1beta1ComputeBackendServiceStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeBackendService";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computebackendservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeBackendService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired state of the ComputeBackendService.</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ComputeBackendServiceSpec Spec { get; set; }

    /// <summary>The observed state of the ComputeBackendService.</summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeBackendServiceStatus? Status { get; set; }
}