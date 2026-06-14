#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.discoveryengine.cnrm.cloud.google.com;
/// <summary>DiscoveryEngineControl is the Schema for the DiscoveryEngineControl API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DiscoveryEngineControlList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DiscoveryEngineControl>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DiscoveryEngineControlList";
    public const string KubeGroup = "discoveryengine.cnrm.cloud.google.com";
    public const string KubePluralName = "discoveryenginecontrols";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "discoveryengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiscoveryEngineControlList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DiscoveryEngineControl objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DiscoveryEngineControl> Items { get; set; }
}

/// <summary>Required. Specifies which data store&apos;s documents can be boosted by this control. Full data store name e.g. projects/123/locations/global/collections/default_collection/dataStores/default_data_store</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecBoostActionDataStoreRef
{
    /// <summary>A reference to an externally managed DiscoveryEngineDataStore resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/datastores/{{datastoreID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DiscoveryEngineDataStore resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DiscoveryEngineDataStore resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecBoostActionInterpolationBoostSpecControlPoints
{
    /// <summary>Optional. Can be one of: 1. The numerical field value. 2. The duration spec for freshness: The value must be formatted as an XSD `dayTimeDuration` value (a restricted subset of an ISO 8601 duration value). The pattern for this is: `[nD][T[nH][nM][nS]]`.</summary>
    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }

    /// <summary>Optional. The value between -1 to 1 by which to boost the score if the attribute_value evaluates to the value specified above.</summary>
    [JsonPropertyName("boostAmount")]
    public double? BoostAmount { get; set; }
}

/// <summary>Optional. Complex specification for custom ranking based on customer defined attribute value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecBoostActionInterpolationBoostSpec
{
    /// <summary>Optional. The attribute type to be used to determine the boost amount. The attribute value can be derived from the field value of the specified field_name. In the case of numerical it is straightforward i.e. attribute_value = numerical_field_value. In the case of freshness however, attribute_value = (time.now() - datetime_field_value).</summary>
    [JsonPropertyName("attributeType")]
    public string? AttributeType { get; set; }

    /// <summary>Optional. The control points used to define the curve. The monotonic function (defined through the interpolation_type above) passes through the control points listed here.</summary>
    [JsonPropertyName("controlPoints")]
    public IList<V1alpha1DiscoveryEngineControlSpecBoostActionInterpolationBoostSpecControlPoints>? ControlPoints { get; set; }

    /// <summary>Optional. The name of the field whose value will be used to determine the boost amount.</summary>
    [JsonPropertyName("fieldName")]
    public string? FieldName { get; set; }

    /// <summary>Optional. The interpolation type to be applied to connect the control points listed below.</summary>
    [JsonPropertyName("interpolationType")]
    public string? InterpolationType { get; set; }
}

/// <summary>Defines a boost-type control</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecBoostAction
{
    /// <summary>Strength of the boost, which should be in [-1, 1]. Negative boost means demotion. Default is 0.0 (No-op).</summary>
    [JsonPropertyName("boost")]
    public double? Boost { get; set; }

    /// <summary>Required. Specifies which data store&apos;s documents can be boosted by this control. Full data store name e.g. projects/123/locations/global/collections/default_collection/dataStores/default_data_store</summary>
    [JsonPropertyName("dataStoreRef")]
    public V1alpha1DiscoveryEngineControlSpecBoostActionDataStoreRef? DataStoreRef { get; set; }

    /// <summary>
    /// Required. Specifies which products to apply the boost to.
    /// 
    ///  If no filter is provided all products will be boosted (No-op).
    ///  Syntax documentation:
    ///  https://cloud.google.com/retail/docs/filter-and-order
    ///  Maximum length is 5000 characters.
    ///  Otherwise an INVALID ARGUMENT error is thrown.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>Optional. Strength of the boost, which should be in [-1, 1]. Negative boost means demotion. Default is 0.0 (No-op).</summary>
    [JsonPropertyName("fixedBoost")]
    public double? FixedBoost { get; set; }

    /// <summary>Optional. Complex specification for custom ranking based on customer defined attribute value.</summary>
    [JsonPropertyName("interpolationBoostSpec")]
    public V1alpha1DiscoveryEngineControlSpecBoostActionInterpolationBoostSpec? InterpolationBoostSpec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecConditionsActiveTimeRange
{
    /// <summary>
    /// End of time range.
    /// 
    ///  Range is inclusive.
    ///  Must be in the future.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// Start of time range.
    /// 
    ///  Range is inclusive.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecConditionsQueryTerms
{
    /// <summary>Whether the search query needs to exactly match the query term.</summary>
    [JsonPropertyName("fullMatch")]
    public bool? FullMatch { get; set; }

    /// <summary>
    /// The specific query value to match against
    /// 
    ///  Must be lowercase, must be UTF-8.
    ///  Can have at most 3 space separated terms if full_match is true.
    ///  Cannot be an empty string.
    ///  Maximum length of 5000 characters.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecConditions
{
    /// <summary>
    /// Range of time(s) specifying when condition is active.
    /// 
    ///  Maximum of 10 time ranges.
    /// </summary>
    [JsonPropertyName("activeTimeRange")]
    public IList<V1alpha1DiscoveryEngineControlSpecConditionsActiveTimeRange>? ActiveTimeRange { get; set; }

    /// <summary>Optional. Query regex to match the whole search query. Cannot be set when [Condition.query_terms][google.cloud.discoveryengine.v1.Condition.query_terms] is set. Only supported for Basic Site Search promotion serving controls.</summary>
    [JsonPropertyName("queryRegex")]
    public string? QueryRegex { get; set; }

    /// <summary>
    /// Search only
    ///  A list of terms to match the query on.
    ///  Cannot be set when
    ///  [Condition.query_regex][google.cloud.discoveryengine.v1.Condition.query_regex]
    ///  is set.
    /// 
    ///  Maximum of 10 query terms.
    /// </summary>
    [JsonPropertyName("queryTerms")]
    public IList<V1alpha1DiscoveryEngineControlSpecConditionsQueryTerms>? QueryTerms { get; set; }
}

/// <summary>Immutable. The DataStore this control belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecDataStoreRef
{
    /// <summary>A reference to an externally managed DiscoveryEngineDataStore resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/datastores/{{datastoreID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DiscoveryEngineDataStore resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DiscoveryEngineDataStore resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Specifies which data store&apos;s documents can be filtered by this control. Full data store name e.g. projects/123/locations/global/collections/default_collection/dataStores/default_data_store</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecFilterActionDataStoreRef
{
    /// <summary>A reference to an externally managed DiscoveryEngineDataStore resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/datastores/{{datastoreID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DiscoveryEngineDataStore resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DiscoveryEngineDataStore resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Defines a filter-type control Currently not supported by Recommendation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecFilterAction
{
    /// <summary>Required. Specifies which data store&apos;s documents can be filtered by this control. Full data store name e.g. projects/123/locations/global/collections/default_collection/dataStores/default_data_store</summary>
    [JsonPropertyName("dataStoreRef")]
    public V1alpha1DiscoveryEngineControlSpecFilterActionDataStoreRef? DataStoreRef { get; set; }

    /// <summary>
    /// Required. A filter to apply on the matching condition results.
    /// 
    ///  Required
    ///  Syntax documentation:
    ///  https://cloud.google.com/retail/docs/filter-and-order
    ///  Maximum length is 5000 characters. Otherwise an INVALID
    ///  ARGUMENT error is thrown.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecProjectRef
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

/// <summary>Required. Data store with which this promotion is attached to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecPromoteActionDataStoreRef
{
    /// <summary>A reference to an externally managed DiscoveryEngineDataStore resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/datastores/{{datastoreID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DiscoveryEngineDataStore resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DiscoveryEngineDataStore resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Promotion attached to this action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecPromoteActionSearchLinkPromotion
{
    /// <summary>Optional. The Promotion description. Maximum length: 200 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. The [Document][google.cloud.discoveryengine.v1.Document] the user wants to promote. For site search, leave unset and only populate uri. Can be set along with uri.</summary>
    [JsonPropertyName("document")]
    public string? Document { get; set; }

    /// <summary>
    /// Optional. The enabled promotion will be returned for any serving configs
    ///  associated with the parent of the control this promotion is attached to.
    /// 
    ///  This flag is used for basic site search only.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional. The promotion thumbnail image url.</summary>
    [JsonPropertyName("imageURI")]
    public string? ImageURI { get; set; }

    /// <summary>Required. The title of the promotion. Maximum length: 160 characters.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Optional. The URL for the page the user wants to promote. Must be set for site search. For other verticals, this is optional.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Promote certain links based on predefined trigger queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecPromoteAction
{
    /// <summary>Required. Data store with which this promotion is attached to.</summary>
    [JsonPropertyName("dataStoreRef")]
    public V1alpha1DiscoveryEngineControlSpecPromoteActionDataStoreRef? DataStoreRef { get; set; }

    /// <summary>Required. Promotion attached to this action.</summary>
    [JsonPropertyName("searchLinkPromotion")]
    public V1alpha1DiscoveryEngineControlSpecPromoteActionSearchLinkPromotion? SearchLinkPromotion { get; set; }
}

/// <summary>Defines a redirect-type control.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecRedirectAction
{
    /// <summary>
    /// Required. The URI to which the shopper will be redirected.
    /// 
    ///  Required.
    ///  URI must have length equal or less than 2000 characters.
    ///  Otherwise an INVALID ARGUMENT error is thrown.
    /// </summary>
    [JsonPropertyName("redirectURI")]
    public string? RedirectURI { get; set; }
}

/// <summary>Treats a group of terms as synonyms of one another.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpecSynonymsAction
{
    /// <summary>Defines a set of synonyms. Can specify up to 100 synonyms. Must specify at least 2 synonyms. Otherwise an INVALID ARGUMENT error is thrown.</summary>
    [JsonPropertyName("synonyms")]
    public IList<string>? Synonyms { get; set; }
}

/// <summary>DiscoveryEngineControlSpec defines the desired state of DiscoveryEngineControl</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlSpec
{
    /// <summary>Defines a boost-type control</summary>
    [JsonPropertyName("boostAction")]
    public V1alpha1DiscoveryEngineControlSpecBoostAction? BoostAction { get; set; }

    /// <summary>
    /// Determines when the associated action will trigger.
    /// 
    /// Omit to always apply the action.
    /// Currently only a single condition may be specified.
    /// Otherwise an INVALID ARGUMENT error is thrown.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DiscoveryEngineControlSpecConditions>? Conditions { get; set; }

    /// <summary>Immutable. The DataStore this control belongs to.</summary>
    [JsonPropertyName("dataStoreRef")]
    public required V1alpha1DiscoveryEngineControlSpecDataStoreRef DataStoreRef { get; set; }

    /// <summary>
    /// Required. Human readable name. The identifier used in UI views.
    /// 
    /// Must be UTF-8 encoded string. Length limit is 128 characters.
    /// Otherwise an INVALID ARGUMENT error is thrown.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Defines a filter-type control Currently not supported by Recommendation</summary>
    [JsonPropertyName("filterAction")]
    public V1alpha1DiscoveryEngineControlSpecFilterAction? FilterAction { get; set; }

    /// <summary>Immutable. The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DiscoveryEngineControlSpecProjectRef ProjectRef { get; set; }

    /// <summary>Promote certain links based on predefined trigger queries.</summary>
    [JsonPropertyName("promoteAction")]
    public V1alpha1DiscoveryEngineControlSpecPromoteAction? PromoteAction { get; set; }

    /// <summary>Defines a redirect-type control.</summary>
    [JsonPropertyName("redirectAction")]
    public V1alpha1DiscoveryEngineControlSpecRedirectAction? RedirectAction { get; set; }

    /// <summary>The DiscoveryEngineControl name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// Required. Immutable. What solution the control belongs to.
    /// 
    /// Must be compatible with vertical of resource.
    /// Otherwise an INVALID ARGUMENT error is thrown.
    /// </summary>
    [JsonPropertyName("solutionType")]
    public string? SolutionType { get; set; }

    /// <summary>Treats a group of terms as synonyms of one another.</summary>
    [JsonPropertyName("synonymsAction")]
    public V1alpha1DiscoveryEngineControlSpecSynonymsAction? SynonymsAction { get; set; }

    /// <summary>Specifies the use case for the control. Affects what condition fields can be set. Only applies to [SOLUTION_TYPE_SEARCH][google.cloud.discoveryengine.v1.SolutionType.SOLUTION_TYPE_SEARCH]. Currently only allow one use case per control. Must be set when solution_type is [SolutionType.SOLUTION_TYPE_SEARCH][google.cloud.discoveryengine.v1.SolutionType.SOLUTION_TYPE_SEARCH].</summary>
    [JsonPropertyName("useCases")]
    public IList<string>? UseCases { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlStatusConditions
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
public partial class V1alpha1DiscoveryEngineControlStatusObservedState
{
}

/// <summary>DiscoveryEngineControlStatus defines the config connector machine state of DiscoveryEngineControl</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DiscoveryEngineControlStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DiscoveryEngineControlStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DiscoveryEngineControl resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DiscoveryEngineControlStatusObservedState? ObservedState { get; set; }
}

/// <summary>DiscoveryEngineControl is the Schema for the DiscoveryEngineControl API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DiscoveryEngineControl : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DiscoveryEngineControlSpec>, IStatus<V1alpha1DiscoveryEngineControlStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DiscoveryEngineControl";
    public const string KubeGroup = "discoveryengine.cnrm.cloud.google.com";
    public const string KubePluralName = "discoveryenginecontrols";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "discoveryengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiscoveryEngineControl";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DiscoveryEngineControlSpec defines the desired state of DiscoveryEngineControl</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DiscoveryEngineControlSpec Spec { get; set; }

    /// <summary>DiscoveryEngineControlStatus defines the config connector machine state of DiscoveryEngineControl</summary>
    [JsonPropertyName("status")]
    public V1alpha1DiscoveryEngineControlStatus? Status { get; set; }
}