#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudsecuritycompliance.cnrm.cloud.google.com;
/// <summary>CloudSecurityComplianceCloudControl is the Schema for the CloudSecurityComplianceCloudControl API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudSecurityComplianceCloudControlList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudSecurityComplianceCloudControl>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudSecurityComplianceCloudControlList";
    public const string KubeGroup = "cloudsecuritycompliance.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudsecuritycompliancecloudcontrols";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudsecuritycompliance.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudSecurityComplianceCloudControlList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudSecurityComplianceCloudControl objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudSecurityComplianceCloudControl> Items { get; set; }
}

/// <summary>The organization that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecOrganizationRef
{
    /// <summary>The &apos;name&apos; field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public required string External { get; set; }
}

/// <summary>Optional. Sub-parameter values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecDefaultValueOneofValue
{
    /// <summary>Required. The name or key of the parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Required. The value of the parameter.</summary>
    [JsonPropertyName("parameterValue")]
    public JsonNode? ParameterValue { get; set; }
}

/// <summary>Optional. A repeated string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecDefaultValueStringListValue
{
    /// <summary>Required. The strings in the list.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Optional. The default value of the parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecDefaultValue
{
    /// <summary>Optional. A boolean value.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>Optional. A double value.</summary>
    [JsonPropertyName("numberValue")]
    public double? NumberValue { get; set; }

    /// <summary>Optional. Sub-parameter values.</summary>
    [JsonPropertyName("oneofValue")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecDefaultValueOneofValue? OneofValue { get; set; }

    /// <summary>Optional. A repeated string.</summary>
    [JsonPropertyName("stringListValue")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecDefaultValueStringListValue? StringListValue { get; set; }

    /// <summary>Optional. A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Optional. Sub-parameter values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersDefaultValueOneofValue
{
    /// <summary>Required. The name or key of the parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Required. The value of the parameter.</summary>
    [JsonPropertyName("parameterValue")]
    public JsonNode? ParameterValue { get; set; }
}

/// <summary>Optional. A repeated string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersDefaultValueStringListValue
{
    /// <summary>Required. The strings in the list.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Optional. The default value of the parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersDefaultValue
{
    /// <summary>Optional. A boolean value.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>Optional. A double value.</summary>
    [JsonPropertyName("numberValue")]
    public double? NumberValue { get; set; }

    /// <summary>Optional. Sub-parameter values.</summary>
    [JsonPropertyName("oneofValue")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersDefaultValueOneofValue? OneofValue { get; set; }

    /// <summary>Optional. A repeated string.</summary>
    [JsonPropertyName("stringListValue")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersDefaultValueStringListValue? StringListValue { get; set; }

    /// <summary>Optional. A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Attribute substitution rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersSubstitutionRulesAttributeSubstitutionRule
{
    /// <summary>Fully qualified proto attribute path (in dot notation). Example: rules[0].cel_expression.resource_types_values</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }
}

/// <summary>Placeholder substitution rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersSubstitutionRulesPlaceholderSubstitutionRule
{
    /// <summary>Fully qualified proto attribute path (e.g., dot notation)</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersSubstitutionRules
{
    /// <summary>Attribute substitution rule.</summary>
    [JsonPropertyName("attributeSubstitutionRule")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersSubstitutionRulesAttributeSubstitutionRule? AttributeSubstitutionRule { get; set; }

    /// <summary>Placeholder substitution rule.</summary>
    [JsonPropertyName("placeholderSubstitutionRule")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersSubstitutionRulesPlaceholderSubstitutionRule? PlaceholderSubstitutionRule { get; set; }
}

/// <summary>Optional. Sub-parameter values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidationAllowedValuesValuesOneofValue
{
    /// <summary>Required. The name or key of the parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Required. The value of the parameter.</summary>
    [JsonPropertyName("parameterValue")]
    public JsonNode? ParameterValue { get; set; }
}

/// <summary>Optional. A repeated string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidationAllowedValuesValuesStringListValue
{
    /// <summary>Required. The strings in the list.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidationAllowedValuesValues
{
    /// <summary>Optional. A boolean value.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>Optional. A double value.</summary>
    [JsonPropertyName("numberValue")]
    public double? NumberValue { get; set; }

    /// <summary>Optional. Sub-parameter values.</summary>
    [JsonPropertyName("oneofValue")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidationAllowedValuesValuesOneofValue? OneofValue { get; set; }

    /// <summary>Optional. A repeated string.</summary>
    [JsonPropertyName("stringListValue")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidationAllowedValuesValuesStringListValue? StringListValue { get; set; }

    /// <summary>Optional. A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Allowed set of values for the parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidationAllowedValues
{
    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidationAllowedValuesValues>? Values { get; set; }
}

/// <summary>Allowed range for numeric parameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidationIntRange
{
    /// <summary>Required. Maximum allowed value for the numeric parameter (inclusive).</summary>
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    /// <summary>Required. Minimum allowed value for the numeric parameter (inclusive).</summary>
    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>Regular expression for string parameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidationRegexpPattern
{
    /// <summary>Required. Regex Pattern to match the value(s) of parameter.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>Optional. The permitted set of values for the parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidation
{
    /// <summary>Allowed set of values for the parameter.</summary>
    [JsonPropertyName("allowedValues")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidationAllowedValues? AllowedValues { get; set; }

    /// <summary>Allowed range for numeric parameters.</summary>
    [JsonPropertyName("intRange")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidationIntRange? IntRange { get; set; }

    /// <summary>Regular expression for string parameters.</summary>
    [JsonPropertyName("regexpPattern")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidationRegexpPattern? RegexpPattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParameters
{
    /// <summary>Optional. The default value of the parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersDefaultValue? DefaultValue { get; set; }

    /// <summary>Optional. The description of the parameter. The maximum length is 2000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. The friendly name of the parameter. The maximum length is 200 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Required. Whether the parameter is required.</summary>
    [JsonPropertyName("isRequired")]
    public bool? IsRequired { get; set; }

    /// <summary>Required. The name of the parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. The list of parameter substitutions.</summary>
    [JsonPropertyName("substitutionRules")]
    public IList<V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersSubstitutionRules>? SubstitutionRules { get; set; }

    /// <summary>Optional. The permitted set of values for the parameter.</summary>
    [JsonPropertyName("validation")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParametersValidation? Validation { get; set; }

    /// <summary>Required. The parameter value type.</summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary>Attribute substitution rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubstitutionRulesAttributeSubstitutionRule
{
    /// <summary>Fully qualified proto attribute path (in dot notation). Example: rules[0].cel_expression.resource_types_values</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }
}

/// <summary>Placeholder substitution rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubstitutionRulesPlaceholderSubstitutionRule
{
    /// <summary>Fully qualified proto attribute path (e.g., dot notation)</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubstitutionRules
{
    /// <summary>Attribute substitution rule.</summary>
    [JsonPropertyName("attributeSubstitutionRule")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubstitutionRulesAttributeSubstitutionRule? AttributeSubstitutionRule { get; set; }

    /// <summary>Placeholder substitution rule.</summary>
    [JsonPropertyName("placeholderSubstitutionRule")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubstitutionRulesPlaceholderSubstitutionRule? PlaceholderSubstitutionRule { get; set; }
}

/// <summary>Optional. Sub-parameter values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidationAllowedValuesValuesOneofValue
{
    /// <summary>Required. The name or key of the parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Required. The value of the parameter.</summary>
    [JsonPropertyName("parameterValue")]
    public JsonNode? ParameterValue { get; set; }
}

/// <summary>Optional. A repeated string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidationAllowedValuesValuesStringListValue
{
    /// <summary>Required. The strings in the list.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidationAllowedValuesValues
{
    /// <summary>Optional. A boolean value.</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>Optional. A double value.</summary>
    [JsonPropertyName("numberValue")]
    public double? NumberValue { get; set; }

    /// <summary>Optional. Sub-parameter values.</summary>
    [JsonPropertyName("oneofValue")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidationAllowedValuesValuesOneofValue? OneofValue { get; set; }

    /// <summary>Optional. A repeated string.</summary>
    [JsonPropertyName("stringListValue")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidationAllowedValuesValuesStringListValue? StringListValue { get; set; }

    /// <summary>Optional. A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Allowed set of values for the parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidationAllowedValues
{
    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidationAllowedValuesValues>? Values { get; set; }
}

/// <summary>Allowed range for numeric parameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidationIntRange
{
    /// <summary>Required. Maximum allowed value for the numeric parameter (inclusive).</summary>
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    /// <summary>Required. Minimum allowed value for the numeric parameter (inclusive).</summary>
    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>Regular expression for string parameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidationRegexpPattern
{
    /// <summary>Required. Regex Pattern to match the value(s) of parameter.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>Optional. The permitted set of values for the parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidation
{
    /// <summary>Allowed set of values for the parameter.</summary>
    [JsonPropertyName("allowedValues")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidationAllowedValues? AllowedValues { get; set; }

    /// <summary>Allowed range for numeric parameters.</summary>
    [JsonPropertyName("intRange")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidationIntRange? IntRange { get; set; }

    /// <summary>Regular expression for string parameters.</summary>
    [JsonPropertyName("regexpPattern")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidationRegexpPattern? RegexpPattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpec
{
    /// <summary>Optional. The default value of the parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecDefaultValue? DefaultValue { get; set; }

    /// <summary>Optional. The description of the parameter. The maximum length is 2000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. The friendly name of the parameter. The maximum length is 200 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Required. Whether the parameter is required.</summary>
    [JsonPropertyName("isRequired")]
    public bool? IsRequired { get; set; }

    /// <summary>Required. The name of the parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. The parameter specification for `oneOf` attributes.</summary>
    [JsonPropertyName("subParameters")]
    public IList<V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubParameters>? SubParameters { get; set; }

    /// <summary>Optional. The list of parameter substitutions.</summary>
    [JsonPropertyName("substitutionRules")]
    public IList<V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecSubstitutionRules>? SubstitutionRules { get; set; }

    /// <summary>Optional. The permitted set of values for the parameter.</summary>
    [JsonPropertyName("validation")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpecValidation? Validation { get; set; }

    /// <summary>Required. The parameter value type.</summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary>The resource instance types on which this expression is defined. Format will be of the form : `&lt;canonical service name&gt;/&lt;type&gt;` Example: `compute.googleapis.com/Instance`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecRulesCelExpressionResourceTypesValues
{
    /// <summary>Required. The strings in the list.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Logic expression in CEL language.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecRulesCelExpression
{
    /// <summary>Required. Logic expression in CEL language. The max length of the condition is 1000 characters.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The resource instance types on which this expression is defined. Format will be of the form : `&lt;canonical service name&gt;/&lt;type&gt;` Example: `compute.googleapis.com/Instance`.</summary>
    [JsonPropertyName("resourceTypesValues")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecRulesCelExpressionResourceTypesValues? ResourceTypesValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpecRules
{
    /// <summary>Logic expression in CEL language.</summary>
    [JsonPropertyName("celExpression")]
    public V1alpha1CloudSecurityComplianceCloudControlSpecRulesCelExpression? CelExpression { get; set; }

    /// <summary>Optional. Description of the Rule. The maximum length is 2000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The functionality enabled by the Rule.</summary>
    [JsonPropertyName("ruleActionTypes")]
    public IList<string>? RuleActionTypes { get; set; }
}

/// <summary>CloudSecurityComplianceCloudControlSpec defines the desired state of CloudSecurityComplianceCloudControl</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlSpec
{
    /// <summary>Optional. The categories for the cloud control.</summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>Optional. A description of the cloud control. The maximum length is 2000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. The friendly name of the cloud control. The maximum length is 200 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. The finding category for the cloud control findings. The maximum length is 255 characters.</summary>
    [JsonPropertyName("findingCategory")]
    public string? FindingCategory { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The organization that this resource belongs to.</summary>
    [JsonPropertyName("organizationRef")]
    public required V1alpha1CloudSecurityComplianceCloudControlSpecOrganizationRef OrganizationRef { get; set; }

    /// <summary>Optional. The parameter specifications for the cloud control.</summary>
    [JsonPropertyName("parameterSpec")]
    public IList<V1alpha1CloudSecurityComplianceCloudControlSpecParameterSpec>? ParameterSpec { get; set; }

    /// <summary>Optional. The remediation steps for the cloud control findings. The maximum length is 400 characters.</summary>
    [JsonPropertyName("remediationSteps")]
    public string? RemediationSteps { get; set; }

    /// <summary>The CloudSecurityComplianceCloudControl name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The rules that you can enforce to meet your security or compliance intent.</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1CloudSecurityComplianceCloudControlSpecRules>? Rules { get; set; }

    /// <summary>Optional. The severity of the findings that are generated by the cloud control.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Optional. The supported cloud providers.</summary>
    [JsonPropertyName("supportedCloudProviders")]
    public IList<string>? SupportedCloudProviders { get; set; }

    /// <summary>Optional. The target resource types that are supported by the cloud control.</summary>
    [JsonPropertyName("supportedTargetResourceTypes")]
    public IList<string>? SupportedTargetResourceTypes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlStatusConditions
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
public partial class V1alpha1CloudSecurityComplianceCloudControlStatusObservedState
{
    /// <summary>Output only. The time that the cloud control was last updated. create_time is used because a new cloud control is created whenever an existing cloud control is updated.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The major version of the cloud control, which is incremented in ascending order.</summary>
    [JsonPropertyName("majorRevisionID")]
    public long? MajorRevisionID { get; set; }

    /// <summary>Output only. The frameworks that include this cloud control.</summary>
    [JsonPropertyName("relatedFrameworks")]
    public IList<string>? RelatedFrameworks { get; set; }

    /// <summary>Output only. The supported enforcement modes for the cloud control.</summary>
    [JsonPropertyName("supportedEnforcementModes")]
    public IList<string>? SupportedEnforcementModes { get; set; }
}

/// <summary>CloudSecurityComplianceCloudControlStatus defines the config connector machine state of CloudSecurityComplianceCloudControl</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudSecurityComplianceCloudControlStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudSecurityComplianceCloudControlStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CloudSecurityComplianceCloudControl resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudSecurityComplianceCloudControlStatusObservedState? ObservedState { get; set; }
}

/// <summary>CloudSecurityComplianceCloudControl is the Schema for the CloudSecurityComplianceCloudControl API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudSecurityComplianceCloudControl : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudSecurityComplianceCloudControlSpec>, IStatus<V1alpha1CloudSecurityComplianceCloudControlStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudSecurityComplianceCloudControl";
    public const string KubeGroup = "cloudsecuritycompliance.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudsecuritycompliancecloudcontrols";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudsecuritycompliance.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudSecurityComplianceCloudControl";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudSecurityComplianceCloudControlSpec defines the desired state of CloudSecurityComplianceCloudControl</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CloudSecurityComplianceCloudControlSpec Spec { get; set; }

    /// <summary>CloudSecurityComplianceCloudControlStatus defines the config connector machine state of CloudSecurityComplianceCloudControl</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudSecurityComplianceCloudControlStatus? Status { get; set; }
}