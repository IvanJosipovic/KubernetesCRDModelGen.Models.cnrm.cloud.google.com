#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.cnrm.cloud.google.com;
/// <summary>ApigeeAPIProduct is the Schema for the ApigeeAPIProduct API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ApigeeAPIProductList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ApigeeAPIProduct>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ApigeeAPIProductList";
    public const string KubeGroup = "apigee.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeapiproducts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigee.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApigeeAPIProductList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ApigeeAPIProduct objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ApigeeAPIProduct> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecAttributes
{
    /// <summary>API key of the attribute.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecGraphQLOperationGroupOperationConfigsAttributes
{
    /// <summary>API key of the attribute.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecGraphQLOperationGroupOperationConfigsOperations
{
    /// <summary>GraphQL operation name. The name and operation type will be used to apply quotas. If no name is specified, the quota will be applied to all GraphQL operations irrespective of their operation names in the payload.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>Required. GraphQL operation types. Valid values include `query` or `mutation`. **Note**: Apigee does not currently support `subscription` types.</summary>
    [JsonPropertyName("operationTypes")]
    public IList<string>? OperationTypes { get; set; }
}

/// <summary>Quota parameters to be enforced for the resources, methods, and API source combination. If none are specified, quota enforcement will not be done.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecGraphQLOperationGroupOperationConfigsQuota
{
    /// <summary>Required. Time interval over which the number of request messages is calculated.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Required. Upper limit allowed for the time interval and time unit specified. Requests exceeding this limit will be rejected.</summary>
    [JsonPropertyName("limit")]
    public string? Limit { get; set; }

    /// <summary>Time unit defined for the `interval`. Valid values include `minute`, `hour`, `day`, or `month`. If `limit` and `interval` are valid, the default value is `hour`; otherwise, the default is null.</summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecGraphQLOperationGroupOperationConfigs
{
    /// <summary>Required. Name of the API proxy endpoint or remote service with which the GraphQL operation and quota are associated.</summary>
    [JsonPropertyName("apiSource")]
    public string? ApiSource { get; set; }

    /// <summary>Custom attributes associated with the operation.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1alpha1ApigeeAPIProductSpecGraphQLOperationGroupOperationConfigsAttributes>? Attributes { get; set; }

    /// <summary>Required. List of GraphQL name/operation type pairs for the proxy or remote service to which quota will be applied. If only operation types are specified, the quota will be applied to all GraphQL requests irrespective of the GraphQL name. **Note**: Currently, you can specify only a single GraphQLOperation. Specifying more than one will cause the operation to fail.</summary>
    [JsonPropertyName("operations")]
    public IList<V1alpha1ApigeeAPIProductSpecGraphQLOperationGroupOperationConfigsOperations>? Operations { get; set; }

    /// <summary>Quota parameters to be enforced for the resources, methods, and API source combination. If none are specified, quota enforcement will not be done.</summary>
    [JsonPropertyName("quota")]
    public V1alpha1ApigeeAPIProductSpecGraphQLOperationGroupOperationConfigsQuota? Quota { get; set; }
}

/// <summary>Configuration used to group Apigee proxies or remote services with graphQL operation name, graphQL operation type and quotas.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecGraphQLOperationGroup
{
    /// <summary>Flag that specifies whether the configuration is for Apigee API proxy or a remote service. Valid values include `proxy` or `remoteservice`. Defaults to `proxy`. Set to `proxy` when Apigee API proxies are associated with the API product. Set to `remoteservice` when non-Apigee proxies like Istio-Envoy are associated with the API product.</summary>
    [JsonPropertyName("operationConfigType")]
    public string? OperationConfigType { get; set; }

    /// <summary>Required. List of operation configurations for either Apigee API proxies or other remote services that are associated with this API product.</summary>
    [JsonPropertyName("operationConfigs")]
    public IList<V1alpha1ApigeeAPIProductSpecGraphQLOperationGroupOperationConfigs>? OperationConfigs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecGrpcOperationGroupOperationConfigsAttributes
{
    /// <summary>API key of the attribute.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Quota parameters to be enforced for the methods and API source combination. If none are specified, quota enforcement will not be done.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecGrpcOperationGroupOperationConfigsQuota
{
    /// <summary>Required. Time interval over which the number of request messages is calculated.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Required. Upper limit allowed for the time interval and time unit specified. Requests exceeding this limit will be rejected.</summary>
    [JsonPropertyName("limit")]
    public string? Limit { get; set; }

    /// <summary>Time unit defined for the `interval`. Valid values include `minute`, `hour`, `day`, or `month`. If `limit` and `interval` are valid, the default value is `hour`; otherwise, the default is null.</summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecGrpcOperationGroupOperationConfigs
{
    /// <summary>Required. Name of the API proxy with which the gRPC operation and quota are associated.</summary>
    [JsonPropertyName("apiSource")]
    public string? ApiSource { get; set; }

    /// <summary>Custom attributes associated with the operation.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1alpha1ApigeeAPIProductSpecGrpcOperationGroupOperationConfigsAttributes>? Attributes { get; set; }

    /// <summary>List of unqualified gRPC method names for the proxy to which quota will be applied. If this field is empty, the Quota will apply to all operations on the gRPC service defined on the proxy. Example: Given a proxy that is configured to serve com.petstore.PetService, the methods com.petstore.PetService.ListPets and com.petstore.PetService.GetPet would be specified here as simply [&quot;ListPets&quot;, &quot;GetPet&quot;].</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Quota parameters to be enforced for the methods and API source combination. If none are specified, quota enforcement will not be done.</summary>
    [JsonPropertyName("quota")]
    public V1alpha1ApigeeAPIProductSpecGrpcOperationGroupOperationConfigsQuota? Quota { get; set; }

    /// <summary>Required. gRPC Service name associated to be associated with the API proxy, on which quota rules can be applied upon.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>Optional. Configuration used to group Apigee proxies with gRPC services and method names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecGrpcOperationGroup
{
    /// <summary>Required. List of operation configurations for either Apigee API proxies that are associated with this API product.</summary>
    [JsonPropertyName("operationConfigs")]
    public IList<V1alpha1ApigeeAPIProductSpecGrpcOperationGroupOperationConfigs>? OperationConfigs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecLlmOperationGroupOperationConfigsAttributes
{
    /// <summary>API key of the attribute.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecLlmOperationGroupOperationConfigsLlmOperations
{
    /// <summary>Optional. methods refers to the REST verbs as in https://httpwg.org/specs/rfc9110.html For example: GET, POST, PUT, DELETE, etc. They need to be in uppercase. When none specified, all verb types are allowed.</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Required. LLM model name associated with the API proxy</summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Required. REST resource path associated with the API proxy or remote service.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>Required. LLM token Quota parameters to be enforced for the resources, methods, and API source &amp; LLM model combination. If none are specified, quota enforcement will not be done.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecLlmOperationGroupOperationConfigsLlmTokenQuota
{
    /// <summary>Required. Time interval over which the number of request messages is calculated.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Required. Upper limit of LLM tokens allowed for the time interval and time unit specified. Requests exceeding this limit will be rejected.</summary>
    [JsonPropertyName("limit")]
    public string? Limit { get; set; }

    /// <summary>Optional. Time unit defined for the `interval`. Valid values include `minute`, `hour`, `day`, or `month`. If `limit` and `interval` are valid, the default value is `hour`; otherwise, the default is null.</summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecLlmOperationGroupOperationConfigs
{
    /// <summary>Required. Name of the API proxy or remote service with which the resources, methods, and quota are associated.</summary>
    [JsonPropertyName("apiSource")]
    public string? ApiSource { get; set; }

    /// <summary>Optional. Custom attributes associated with the operation.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1alpha1ApigeeAPIProductSpecLlmOperationGroupOperationConfigsAttributes>? Attributes { get; set; }

    /// <summary>Required. List of resource/method/model for the API proxy to which quota will applied. **Note**: Currently, you can specify only a single resource/method/model mapping. The call will fail if more than one resource/method/model mappings are provided.</summary>
    [JsonPropertyName("llmOperations")]
    public IList<V1alpha1ApigeeAPIProductSpecLlmOperationGroupOperationConfigsLlmOperations>? LlmOperations { get; set; }

    /// <summary>Required. LLM token Quota parameters to be enforced for the resources, methods, and API source &amp; LLM model combination. If none are specified, quota enforcement will not be done.</summary>
    [JsonPropertyName("llmTokenQuota")]
    public V1alpha1ApigeeAPIProductSpecLlmOperationGroupOperationConfigsLlmTokenQuota? LlmTokenQuota { get; set; }
}

/// <summary>Optional. Configuration used to group Apigee proxies with resources, method types, LLM model and quotas.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecLlmOperationGroup
{
    /// <summary>Required. List of LLM operation configurations for either Apigee API proxies that are associated with this API product.</summary>
    [JsonPropertyName("operationConfigs")]
    public IList<V1alpha1ApigeeAPIProductSpecLlmOperationGroupOperationConfigs>? OperationConfigs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecOperationGroupOperationConfigsAttributes
{
    /// <summary>API key of the attribute.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecOperationGroupOperationConfigsOperations
{
    /// <summary>methods refers to the REST verbs as in https://www.w3.org/Protocols/rfc2616/rfc2616-sec9.html. When none specified, all verb types are allowed.</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Required. REST resource path associated with the API proxy or remote service.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>Quota parameters to be enforced for the resources, methods, and API source combination. If none are specified, quota enforcement will not be done.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecOperationGroupOperationConfigsQuota
{
    /// <summary>Required. Time interval over which the number of request messages is calculated.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Required. Upper limit allowed for the time interval and time unit specified. Requests exceeding this limit will be rejected.</summary>
    [JsonPropertyName("limit")]
    public string? Limit { get; set; }

    /// <summary>Time unit defined for the `interval`. Valid values include `minute`, `hour`, `day`, or `month`. If `limit` and `interval` are valid, the default value is `hour`; otherwise, the default is null.</summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecOperationGroupOperationConfigs
{
    /// <summary>Required. Name of the API proxy or remote service with which the resources, methods, and quota are associated.</summary>
    [JsonPropertyName("apiSource")]
    public string? ApiSource { get; set; }

    /// <summary>Custom attributes associated with the operation.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1alpha1ApigeeAPIProductSpecOperationGroupOperationConfigsAttributes>? Attributes { get; set; }

    /// <summary>List of resource/method pairs for the API proxy or remote service to which quota will applied. **Note**: Currently, you can specify only a single resource/method pair. The call will fail if more than one resource/method pair is provided.</summary>
    [JsonPropertyName("operations")]
    public IList<V1alpha1ApigeeAPIProductSpecOperationGroupOperationConfigsOperations>? Operations { get; set; }

    /// <summary>Quota parameters to be enforced for the resources, methods, and API source combination. If none are specified, quota enforcement will not be done.</summary>
    [JsonPropertyName("quota")]
    public V1alpha1ApigeeAPIProductSpecOperationGroupOperationConfigsQuota? Quota { get; set; }
}

/// <summary>Configuration used to group Apigee proxies or remote services with resources, method types, and quotas.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecOperationGroup
{
    /// <summary>Flag that specifes whether the configuration is for Apigee API proxy or a remote service. Valid values include `proxy` or `remoteservice`. Defaults to `proxy`. Set to `proxy` when Apigee API proxies are associated with the API product. Set to `remoteservice` when non-Apigee proxies like Istio-Envoy are associated with the API product.</summary>
    [JsonPropertyName("operationConfigType")]
    public string? OperationConfigType { get; set; }

    /// <summary>Required. List of operation configurations for either Apigee API proxies or other remote services that are associated with this API product.</summary>
    [JsonPropertyName("operationConfigs")]
    public IList<V1alpha1ApigeeAPIProductSpecOperationGroupOperationConfigs>? OperationConfigs { get; set; }
}

/// <summary>Reference to the organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpecOrganizationRef
{
    /// <summary>A reference to an externally managed ApigeeOrganization resource. Should be in the format &quot;organizations/{{organizationID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of an ApigeeOrganization resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of an ApigeeOrganization resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ApigeeAPIProductSpec defines the desired state of ApigeeAPIProduct</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductSpec
{
    /// <summary>Comma-separated list of API resources to be bundled in the API product.</summary>
    [JsonPropertyName("apiResources")]
    public IList<string>? ApiResources { get; set; }

    /// <summary>Flag that specifies how API keys are approved to access the APIs defined by the API product.</summary>
    [JsonPropertyName("approvalType")]
    public string? ApprovalType { get; set; }

    /// <summary>Array of attributes that may be used to extend the default API product profile with customer-specific metadata.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1alpha1ApigeeAPIProductSpecAttributes>? Attributes { get; set; }

    /// <summary>Description of the API product.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name displayed in the UI or developer portal to developers registering for API access.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Comma-separated list of environment names to which the API product is bound.</summary>
    [JsonPropertyName("environments")]
    public IList<string>? Environments { get; set; }

    /// <summary>Configuration used to group Apigee proxies or remote services with graphQL operation name, graphQL operation type and quotas.</summary>
    [JsonPropertyName("graphQLOperationGroup")]
    public V1alpha1ApigeeAPIProductSpecGraphQLOperationGroup? GraphQLOperationGroup { get; set; }

    /// <summary>Optional. Configuration used to group Apigee proxies with gRPC services and method names.</summary>
    [JsonPropertyName("grpcOperationGroup")]
    public V1alpha1ApigeeAPIProductSpecGrpcOperationGroup? GrpcOperationGroup { get; set; }

    /// <summary>Optional. Configuration used to group Apigee proxies with resources, method types, LLM model and quotas.</summary>
    [JsonPropertyName("llmOperationGroup")]
    public V1alpha1ApigeeAPIProductSpecLlmOperationGroup? LlmOperationGroup { get; set; }

    /// <summary>Optional. Number of LLM tokens permitted per app by this API product for the specified `llm_quota_interval` and `llm_quota_time_unit`.</summary>
    [JsonPropertyName("llmQuota")]
    public string? LlmQuota { get; set; }

    /// <summary>Optional. Time interval over which the number of tokens from LLM responses is calculated.</summary>
    [JsonPropertyName("llmQuotaInterval")]
    public string? LlmQuotaInterval { get; set; }

    /// <summary>Optional. Time unit defined for the `llm_quota_interval`. Valid values include `minute`, `hour`, `day`, or `month`.</summary>
    [JsonPropertyName("llmQuotaTimeUnit")]
    public string? LlmQuotaTimeUnit { get; set; }

    /// <summary>Configuration used to group Apigee proxies or remote services with resources, method types, and quotas.</summary>
    [JsonPropertyName("operationGroup")]
    public V1alpha1ApigeeAPIProductSpecOperationGroup? OperationGroup { get; set; }

    /// <summary>Reference to the organization.</summary>
    [JsonPropertyName("organizationRef")]
    public required V1alpha1ApigeeAPIProductSpecOrganizationRef OrganizationRef { get; set; }

    /// <summary>Comma-separated list of API proxy names to which this API product is bound.</summary>
    [JsonPropertyName("proxies")]
    public IList<string>? Proxies { get; set; }

    /// <summary>Number of request messages permitted per app by this API product for the specified `quotaInterval` and `quotaTimeUnit`.</summary>
    [JsonPropertyName("quota")]
    public string? Quota { get; set; }

    /// <summary>Scope of the quota decides how the quota counter gets applied and evaluate for quota violation.</summary>
    [JsonPropertyName("quotaCounterScope")]
    public string? QuotaCounterScope { get; set; }

    /// <summary>Time interval over which the number of request messages is calculated.</summary>
    [JsonPropertyName("quotaInterval")]
    public string? QuotaInterval { get; set; }

    /// <summary>Time unit defined for the `quotaInterval`.</summary>
    [JsonPropertyName("quotaTimeUnit")]
    public string? QuotaTimeUnit { get; set; }

    /// <summary>The ApigeeAPIProduct name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Comma-separated list of OAuth scopes that are validated at runtime.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductStatusObservedState
{
    /// <summary>Response only. Creation time of this environment as milliseconds since epoch.</summary>
    [JsonPropertyName("createdAt")]
    public long? CreatedAt { get; set; }

    /// <summary>Response only. Modified time of this environment as milliseconds since epoch.</summary>
    [JsonPropertyName("lastModifiedAt")]
    public long? LastModifiedAt { get; set; }
}

/// <summary>ApigeeAPIProductStatus defines the config connector machine state of ApigeeAPIProduct</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApigeeAPIProductStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ApigeeAPIProductStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ApigeeAPIProduct resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ApigeeAPIProductStatusObservedState? ObservedState { get; set; }
}

/// <summary>ApigeeAPIProduct is the Schema for the ApigeeAPIProduct API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ApigeeAPIProduct : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ApigeeAPIProductSpec>, IStatus<V1alpha1ApigeeAPIProductStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ApigeeAPIProduct";
    public const string KubeGroup = "apigee.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeapiproducts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigee.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApigeeAPIProduct";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApigeeAPIProductSpec defines the desired state of ApigeeAPIProduct</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ApigeeAPIProductSpec Spec { get; set; }

    /// <summary>ApigeeAPIProductStatus defines the config connector machine state of ApigeeAPIProduct</summary>
    [JsonPropertyName("status")]
    public V1alpha1ApigeeAPIProductStatus? Status { get; set; }
}