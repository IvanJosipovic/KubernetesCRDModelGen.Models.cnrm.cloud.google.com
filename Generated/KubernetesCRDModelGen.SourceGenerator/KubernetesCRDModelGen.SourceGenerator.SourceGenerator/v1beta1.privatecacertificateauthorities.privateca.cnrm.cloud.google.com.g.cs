#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.privateca.cnrm.cloud.google.com;
/// <summary>PrivateCACertificateAuthority is the Schema for the PrivateCACertificateAuthority API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateCACertificateAuthorityList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PrivateCACertificateAuthority>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateCACertificateAuthorityList";
    public const string KubeGroup = "privateca.cnrm.cloud.google.com";
    public const string KubePluralName = "privatecacertificateauthorities";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "privateca.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PrivateCACertificateAuthorityList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1PrivateCACertificateAuthority objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1PrivateCACertificateAuthority> Items { get; set; }
}

/// <summary>Immutable. Optional. The PrivateCACAPool that includes this CertificateAuthority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecCaPoolRef
{
    /// <summary>A reference to an externally managed PrivateCACAPool resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/caPools/{{caPoolID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a PrivateCACAPool resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a PrivateCACAPool resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Contains distinguished name fields such as the common name, location and organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubject
{
    /// <summary>The &quot;common name&quot; of the subject.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The country code of the subject.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The locality or city of the subject.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The organization of the subject.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>The organizational_unit of the subject.</summary>
    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    /// <summary>The postal code of the subject.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>The province, territory, or regional state of the subject.</summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>The street address of the subject.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }
}

/// <summary>Required. The OID for this X.509 extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubjectAltNameCustomSansObjectId
{
    /// <summary>Required. The parts of an OID path.</summary>
    [JsonPropertyName("objectIdPath")]
    public required IList<long> ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubjectAltNameCustomSans
{
    /// <summary>Optional. Indicates whether or not this extension is critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Required. The OID for this X.509 extension.</summary>
    [JsonPropertyName("objectId")]
    public required V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubjectAltNameCustomSansObjectId ObjectId { get; set; }

    /// <summary>Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>Optional. The subject alternative name fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubjectAltName
{
    /// <summary>Contains additional subject alternative name values.</summary>
    [JsonPropertyName("customSans")]
    public IList<V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubjectAltNameCustomSans>? CustomSans { get; set; }

    /// <summary>Contains only valid, fully-qualified host names.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>Contains only valid RFC 2822 E-mail addresses.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Contains only valid 32-bit IPv4 addresses or RFC 4291 IPv6 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>Contains only valid RFC 3986 URIs.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary>Required. Specifies some of the values in a certificate that are related to the subject.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfig
{
    /// <summary>Required. Contains distinguished name fields such as the common name, location and organization.</summary>
    [JsonPropertyName("subject")]
    public required V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubject Subject { get; set; }

    /// <summary>Optional. The subject alternative name fields.</summary>
    [JsonPropertyName("subjectAltName")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfigSubjectAltName? SubjectAltName { get; set; }
}

/// <summary>Required. The OID for this X.509 extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigAdditionalExtensionsObjectId
{
    /// <summary>Required. The parts of an OID path.</summary>
    [JsonPropertyName("objectIdPath")]
    public required IList<long> ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigAdditionalExtensions
{
    /// <summary>Optional. Indicates whether or not this extension is critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Required. The OID for this X.509 extension.</summary>
    [JsonPropertyName("objectId")]
    public required V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigAdditionalExtensionsObjectId ObjectId { get; set; }

    /// <summary>Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigCaOptions
{
    /// <summary>Optional. Refers to the &quot;CA&quot; boolean field in the X.509 extension. When this value is missing, the basic constraints extension will be omitted from the certificate.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>Optional. Refers to the path length constraint field in the X.509 extension. For a CA certificate, this value describes the depth of subordinate CA certificates that are allowed. If this value is less than 0, the request will fail. If this value is missing, the max path length will be omitted from the certificate.</summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public int? MaxIssuerPathLength { get; set; }

    /// <summary>Optional. When true, the &quot;path length constraint&quot; in Basic Constraints extension will be set to 0. if both max_issuer_path_length and zero_max_issuer_path_length are unset, the max path length will be omitted from the CA certificate.</summary>
    [JsonPropertyName("zeroMaxIssuerPathLength")]
    public bool? ZeroMaxIssuerPathLength { get; set; }
}

/// <summary>Describes high-level ways in which a key may be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsageBaseKeyUsage
{
    /// <summary>The key may be used to sign certificates.</summary>
    [JsonPropertyName("certSign")]
    public bool? CertSign { get; set; }

    /// <summary>The key may be used for cryptographic commitments. Note that this may also be referred to as &quot;non-repudiation&quot;.</summary>
    [JsonPropertyName("contentCommitment")]
    public bool? ContentCommitment { get; set; }

    /// <summary>The key may be used sign certificate revocation lists.</summary>
    [JsonPropertyName("crlSign")]
    public bool? CrlSign { get; set; }

    /// <summary>The key may be used to encipher data.</summary>
    [JsonPropertyName("dataEncipherment")]
    public bool? DataEncipherment { get; set; }

    /// <summary>The key may be used to decipher only.</summary>
    [JsonPropertyName("decipherOnly")]
    public bool? DecipherOnly { get; set; }

    /// <summary>The key may be used for digital signatures.</summary>
    [JsonPropertyName("digitalSignature")]
    public bool? DigitalSignature { get; set; }

    /// <summary>The key may be used to encipher only.</summary>
    [JsonPropertyName("encipherOnly")]
    public bool? EncipherOnly { get; set; }

    /// <summary>The key may be used in a key agreement protocol.</summary>
    [JsonPropertyName("keyAgreement")]
    public bool? KeyAgreement { get; set; }

    /// <summary>The key may be used to encipher other keys.</summary>
    [JsonPropertyName("keyEncipherment")]
    public bool? KeyEncipherment { get; set; }
}

/// <summary>Detailed scenarios in which a key may be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsageExtendedKeyUsage
{
    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.2. Officially described as &quot;TLS WWW client authentication&quot;, though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("clientAuth")]
    public bool? ClientAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.3. Officially described as &quot;Signing of downloadable executable code client authentication&quot;.</summary>
    [JsonPropertyName("codeSigning")]
    public bool? CodeSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.4. Officially described as &quot;Email protection&quot;.</summary>
    [JsonPropertyName("emailProtection")]
    public bool? EmailProtection { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.9. Officially described as &quot;Signing OCSP responses&quot;.</summary>
    [JsonPropertyName("ocspSigning")]
    public bool? OcspSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.1. Officially described as &quot;TLS WWW server authentication&quot;, though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("serverAuth")]
    public bool? ServerAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.8. Officially described as &quot;Binding the hash of an object to a time&quot;.</summary>
    [JsonPropertyName("timeStamping")]
    public bool? TimeStamping { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>Required. The parts of an OID path.</summary>
    [JsonPropertyName("objectIdPath")]
    public required IList<long> ObjectIdPath { get; set; }
}

/// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsage
{
    /// <summary>Describes high-level ways in which a key may be used.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>Detailed scenarios in which a key may be used.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>Used to describe extended key usages that are not listed in the KeyUsage.ExtendedKeyUsageOptions message.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigPolicyIds
{
    /// <summary>Required. The parts of an OID path.</summary>
    [JsonPropertyName("objectIdPath")]
    public required IList<long> ObjectIdPath { get; set; }
}

/// <summary>Required. Describes how some of the technical X.509 fields in a certificate should be populated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfigX509Config
{
    /// <summary>Optional. Describes custom X.509 extensions.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
    [JsonPropertyName("caOptions")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigCaOptions? CaOptions { get; set; }

    /// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
    [JsonPropertyName("keyUsage")]
    public V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigKeyUsage? KeyUsage { get; set; }

    /// <summary>Optional. Describes the X.509 certificate policy object identifiers.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1PrivateCACertificateAuthoritySpecConfigX509ConfigPolicyIds>? PolicyIds { get; set; }
}

/// <summary>Immutable. Required. Immutable. The config used to create a self-signed X.509 certificate or CSR.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecConfig
{
    /// <summary>Required. Specifies some of the values in a certificate that are related to the subject.</summary>
    [JsonPropertyName("subjectConfig")]
    public required V1beta1PrivateCACertificateAuthoritySpecConfigSubjectConfig SubjectConfig { get; set; }

    /// <summary>Required. Describes how some of the technical X.509 fields in a certificate should be populated.</summary>
    [JsonPropertyName("x509Config")]
    public required V1beta1PrivateCACertificateAuthoritySpecConfigX509Config X509Config { get; set; }
}

/// <summary>Immutable. Optional. The StorageBucket where this CertificateAuthority&apos;s CA certificate is published.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecGcsBucketRef
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

/// <summary>Optional. The resource name for an existing Cloud KMS CryptoKeyVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecKeySpecCloudKmsKeyVersionRef
{
    /// <summary>A reference to an externally managed cryptoKeyVersion. Should be in the format `projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}/cryptoKeyVersions/{{version}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKeyVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKeyVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Required. Immutable. Used when issuing certificates for this CertificateAuthority. If this CertificateAuthority is a self-signed CertificateAuthority, this key is also used to sign the self-signed CA certificate. Otherwise, it is used to sign a CSR.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecKeySpec
{
    /// <summary>Optional. The algorithm to use for creating a managed Cloud KMS key.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Optional. The resource name for an existing Cloud KMS CryptoKeyVersion.</summary>
    [JsonPropertyName("cloudKmsKeyVersionRef")]
    public V1beta1PrivateCACertificateAuthoritySpecKeySpecCloudKmsKeyVersionRef? CloudKmsKeyVersionRef { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpecProjectRef
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

/// <summary>PrivateCACertificateAuthoritySpec defines the desired state of PrivateCACertificateAuthority</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthoritySpec
{
    /// <summary>Immutable. Optional. The PrivateCACAPool that includes this CertificateAuthority.</summary>
    [JsonPropertyName("caPoolRef")]
    public required V1beta1PrivateCACertificateAuthoritySpecCaPoolRef CaPoolRef { get; set; }

    /// <summary>Immutable. Required. Immutable. The config used to create a self-signed X.509 certificate or CSR.</summary>
    [JsonPropertyName("config")]
    public required V1beta1PrivateCACertificateAuthoritySpecConfig Config { get; set; }

    /// <summary>Immutable. Optional. The StorageBucket where this CertificateAuthority&apos;s CA certificate is published.</summary>
    [JsonPropertyName("gcsBucketRef")]
    public V1beta1PrivateCACertificateAuthoritySpecGcsBucketRef? GcsBucketRef { get; set; }

    /// <summary>Immutable. Required. Immutable. Used when issuing certificates for this CertificateAuthority. If this CertificateAuthority is a self-signed CertificateAuthority, this key is also used to sign the self-signed CA certificate. Otherwise, it is used to sign a CSR.</summary>
    [JsonPropertyName("keySpec")]
    public required V1beta1PrivateCACertificateAuthoritySpecKeySpec KeySpec { get; set; }

    /// <summary>Immutable. Required. The desired lifetime of the CA certificate. Used to create the &quot;not_before_time&quot; and &quot;not_after_time&quot; fields inside an X.509 certificate.</summary>
    [JsonPropertyName("lifetime")]
    public required string Lifetime { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1PrivateCACertificateAuthoritySpecProjectRef ProjectRef { get; set; }

    /// <summary>The PrivateCACertificateAuthority name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Required. Immutable. The Type of this CertificateAuthority. Possible values: SELF_SIGNED, SUBORDINATE</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Output only. URLs for accessing content published by this CA, such as the CA certificate and CRLs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusAccessUrls
{
    /// <summary>The URL where this CertificateAuthority&apos;s CA certificate is published. This will only be set for CAs that have been activated.</summary>
    [JsonPropertyName("caCertificateAccessUrl")]
    public string? CaCertificateAccessUrl { get; set; }

    /// <summary>The URLs where this CertificateAuthority&apos;s CRLs are published. This will only be set for CAs that have been activated.</summary>
    [JsonPropertyName("crlAccessUrls")]
    public IList<string>? CrlAccessUrls { get; set; }
}

/// <summary>Identifies the subject_key_id of the parent certificate, per https://tools.ietf.org/html/rfc5280#section-4.2.1.1</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsAuthorityKeyId
{
    /// <summary>Optional. The value of this KeyId encoded in lowercase hexadecimal. This is most likely the 160 bit SHA-1 hash of the public key.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary>The hash of the x.509 certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsCertFingerprint
{
    /// <summary>The SHA 256 hash, encoded in hexadecimal, of the DER x509 certificate.</summary>
    [JsonPropertyName("sha256Hash")]
    public string? Sha256Hash { get; set; }
}

/// <summary>The public key that corresponds to an issued certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsPublicKey
{
    /// <summary>Required. The format of the public key. Possible values: PEM</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Required. A public key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Contains distinguished name fields such as the common name, location and organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubject
{
    /// <summary>The &quot;common name&quot; of the subject.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The country code of the subject.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The locality or city of the subject.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The organization of the subject.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>The organizational_unit of the subject.</summary>
    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    /// <summary>The postal code of the subject.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>The province, territory, or regional state of the subject.</summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>The street address of the subject.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }
}

/// <summary>Optional. The OID for this X.509 extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubjectAltNameCustomSansObjectId
{
    /// <summary>Optional. The parts of an OID path.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubjectAltNameCustomSans
{
    /// <summary>Optional. Indicates whether or not this extension is critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Optional. The OID for this X.509 extension.</summary>
    [JsonPropertyName("objectId")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubjectAltNameCustomSansObjectId? ObjectId { get; set; }

    /// <summary>Optional. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The subject alternative name fields.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubjectAltName
{
    /// <summary>Contains additional subject alternative name values.</summary>
    [JsonPropertyName("customSans")]
    public IList<V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubjectAltNameCustomSans>? CustomSans { get; set; }

    /// <summary>Contains only valid, fully-qualified host names.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>Contains only valid RFC 2822 E-mail addresses.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Contains only valid 32-bit IPv4 addresses or RFC 4291 IPv6 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>Contains only valid RFC 3986 URIs.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary>Describes some of the values in a certificate that are related to the subject and lifetime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescription
{
    /// <summary>The serial number encoded in lowercase hexadecimal.</summary>
    [JsonPropertyName("hexSerialNumber")]
    public string? HexSerialNumber { get; set; }

    /// <summary>For convenience, the actual lifetime of an issued certificate.</summary>
    [JsonPropertyName("lifetime")]
    public string? Lifetime { get; set; }

    /// <summary>The time after which the certificate is expired. Per RFC 5280, the validity period for a certificate is the period of time from not_before_time through not_after_time, inclusive. Corresponds to &apos;not_before_time&apos; + &apos;lifetime&apos; - 1 second.</summary>
    [JsonPropertyName("notAfterTime")]
    public DateTime? NotAfterTime { get; set; }

    /// <summary>The time at which the certificate becomes valid.</summary>
    [JsonPropertyName("notBeforeTime")]
    public DateTime? NotBeforeTime { get; set; }

    /// <summary>Contains distinguished name fields such as the common name, location and organization.</summary>
    [JsonPropertyName("subject")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubject? Subject { get; set; }

    /// <summary>The subject alternative name fields.</summary>
    [JsonPropertyName("subjectAltName")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescriptionSubjectAltName? SubjectAltName { get; set; }
}

/// <summary>Provides a means of identifiying certificates that contain a particular public key, per https://tools.ietf.org/html/rfc5280#section-4.2.1.2.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectKeyId
{
    /// <summary>Optional. The value of this KeyId encoded in lowercase hexadecimal. This is most likely the 160 bit SHA-1 hash of the public key.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary>Optional. The OID for this X.509 extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionAdditionalExtensionsObjectId
{
    /// <summary>Optional. The parts of an OID path.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionAdditionalExtensions
{
    /// <summary>Optional. Indicates whether or not this extension is critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Optional. The OID for this X.509 extension.</summary>
    [JsonPropertyName("objectId")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionAdditionalExtensionsObjectId? ObjectId { get; set; }

    /// <summary>Optional. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionCaOptions
{
    /// <summary>Optional. Refers to the &quot;CA&quot; field in the Basic Constraints extension. If this is true, the certificate is a CA certificate, and can be used to sign other certificates.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>Optional. Refers to the path length constraint field in the Basic Constraints extension. This constraint specifies the maximum number of non-self-issued intermediate certificates that may follow this certificate in a valid certification path.</summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public long? MaxIssuerPathLength { get; set; }
}

/// <summary>Describes high-level ways in which a key may be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsageBaseKeyUsage
{
    /// <summary>The key may be used to sign certificates.</summary>
    [JsonPropertyName("certSign")]
    public bool? CertSign { get; set; }

    /// <summary>The key may be used for cryptographic commitments. Note that this may also be referred to as &quot;non-repudiation&quot;.</summary>
    [JsonPropertyName("contentCommitment")]
    public bool? ContentCommitment { get; set; }

    /// <summary>The key may be used sign certificate revocation lists.</summary>
    [JsonPropertyName("crlSign")]
    public bool? CrlSign { get; set; }

    /// <summary>The key may be used to encipher data.</summary>
    [JsonPropertyName("dataEncipherment")]
    public bool? DataEncipherment { get; set; }

    /// <summary>The key may be used to decipher only.</summary>
    [JsonPropertyName("decipherOnly")]
    public bool? DecipherOnly { get; set; }

    /// <summary>The key may be used for digital signatures.</summary>
    [JsonPropertyName("digitalSignature")]
    public bool? DigitalSignature { get; set; }

    /// <summary>The key may be used to encipher only.</summary>
    [JsonPropertyName("encipherOnly")]
    public bool? EncipherOnly { get; set; }

    /// <summary>The key may be used in a key agreement protocol.</summary>
    [JsonPropertyName("keyAgreement")]
    public bool? KeyAgreement { get; set; }

    /// <summary>The key may be used to encipher other keys.</summary>
    [JsonPropertyName("keyEncipherment")]
    public bool? KeyEncipherment { get; set; }
}

/// <summary>Detailed scenarios in which a key may be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsageExtendedKeyUsage
{
    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.2. Officially described as &quot;TLS WWW client authentication&quot;, though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("clientAuth")]
    public bool? ClientAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.3. Officially described as &quot;Signing of downloadable executable code client authentication&quot;.</summary>
    [JsonPropertyName("codeSigning")]
    public bool? CodeSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.4. Officially described as &quot;Email protection&quot;.</summary>
    [JsonPropertyName("emailProtection")]
    public bool? EmailProtection { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.9. Officially described as &quot;Signing OCSP responses&quot;.</summary>
    [JsonPropertyName("ocspSigning")]
    public bool? OcspSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.1. Officially described as &quot;TLS WWW server authentication&quot;, though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("serverAuth")]
    public bool? ServerAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.8. Officially described as &quot;Binding the hash of an object to a time&quot;.</summary>
    [JsonPropertyName("timeStamping")]
    public bool? TimeStamping { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>Optional. The parts of an OID path.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long>? ObjectIdPath { get; set; }
}

/// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsage
{
    /// <summary>Describes high-level ways in which a key may be used.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>Detailed scenarios in which a key may be used.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>Used to describe extended key usages that are not listed in the KeyUsage.ExtendedKeyUsageOptions message.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionPolicyIds
{
    /// <summary>Optional. The parts of an OID path.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<long>? ObjectIdPath { get; set; }
}

/// <summary>Describes some of the technical X.509 fields in a certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509Description
{
    /// <summary>Optional. Describes custom X.509 extensions.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. Describes lists of Ocsps servers in &quot;Authority Information Access&quot; extension.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
    [JsonPropertyName("caOptions")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionCaOptions? CaOptions { get; set; }

    /// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
    [JsonPropertyName("keyUsage")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionKeyUsage? KeyUsage { get; set; }

    /// <summary>Optional. Describes the X.509 certificate policy object identifiers.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509DescriptionPolicyIds>? PolicyIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptions
{
    /// <summary>Describes lists of issuer CA certificate URLs that appear in the &quot;Authority Information Access&quot; extension in the certificate.</summary>
    [JsonPropertyName("aiaIssuingCertificateUrls")]
    public IList<string>? AiaIssuingCertificateUrls { get; set; }

    /// <summary>Identifies the subject_key_id of the parent certificate, per https://tools.ietf.org/html/rfc5280#section-4.2.1.1</summary>
    [JsonPropertyName("authorityKeyId")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsAuthorityKeyId? AuthorityKeyId { get; set; }

    /// <summary>The hash of the x.509 certificate.</summary>
    [JsonPropertyName("certFingerprint")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsCertFingerprint? CertFingerprint { get; set; }

    /// <summary>Describes a list of locations to obtain CRL information, i.e. the DistributionPoint.fullName described by https://tools.ietf.org/html/rfc5280#section-4.2.1.13</summary>
    [JsonPropertyName("crlDistributionPoints")]
    public IList<string>? CrlDistributionPoints { get; set; }

    /// <summary>The public key that corresponds to an issued certificate.</summary>
    [JsonPropertyName("publicKey")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsPublicKey? PublicKey { get; set; }

    /// <summary>Describes some of the values in a certificate that are related to the subject and lifetime.</summary>
    [JsonPropertyName("subjectDescription")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectDescription? SubjectDescription { get; set; }

    /// <summary>Provides a means of identifiying certificates that contain a particular public key, per https://tools.ietf.org/html/rfc5280#section-4.2.1.2.</summary>
    [JsonPropertyName("subjectKeyId")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsSubjectKeyId? SubjectKeyId { get; set; }

    /// <summary>Describes some of the technical X.509 fields in a certificate.</summary>
    [JsonPropertyName("x509Description")]
    public V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptionsX509Description? X509Description { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusConditions
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

/// <summary>Optional. The public key that corresponds to this config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusConfigPublicKey
{
    /// <summary>Required. The format of the public key. Possible values: PEM</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Required. A public key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusConfigX509Config
{
    /// <summary>Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the &quot;Authority Information Access&quot; extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusConfig
{
    /// <summary>Optional. The public key that corresponds to this config.</summary>
    [JsonPropertyName("publicKey")]
    public V1beta1PrivateCACertificateAuthorityStatusConfigPublicKey? PublicKey { get; set; }

    [JsonPropertyName("x509Config")]
    public V1beta1PrivateCACertificateAuthorityStatusConfigX509Config? X509Config { get; set; }
}

/// <summary>Required. Contains the certificate chain of the subordinate CA&apos;s issuer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusSubordinateConfigPemIssuerChain
{
    /// <summary>Required. Expected to be in leaf-to-root order according to RFC 5246.</summary>
    [JsonPropertyName("pemCertificates")]
    public IList<string>? PemCertificates { get; set; }
}

/// <summary>Optional. If this is a subordinate CertificateAuthority, this field will be set with the subordinate configuration, which describes its issuers. This may be updated, but this CertificateAuthority must continue to validate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatusSubordinateConfig
{
    /// <summary>Required. This can refer to a CertificateAuthority that was used to sign the subordinate CA.</summary>
    [JsonPropertyName("certificateAuthority")]
    public string? CertificateAuthority { get; set; }

    /// <summary>Required. Contains the certificate chain of the subordinate CA&apos;s issuer.</summary>
    [JsonPropertyName("pemIssuerChain")]
    public V1beta1PrivateCACertificateAuthorityStatusSubordinateConfigPemIssuerChain? PemIssuerChain { get; set; }
}

/// <summary>PrivateCACertificateAuthorityStatus defines the config connector machine state of PrivateCACertificateAuthority</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateAuthorityStatus
{
    /// <summary>Output only. URLs for accessing content published by this CA, such as the CA certificate and CRLs.</summary>
    [JsonPropertyName("accessUrls")]
    public V1beta1PrivateCACertificateAuthorityStatusAccessUrls? AccessUrls { get; set; }

    /// <summary>Output only. A structured description of this CertificateAuthority&apos;s CA certificate and its issuers. Ordered as self-to-root. Ordered as self-to-root.</summary>
    [JsonPropertyName("caCertificateDescriptions")]
    public IList<V1beta1PrivateCACertificateAuthorityStatusCaCertificateDescriptions>? CaCertificateDescriptions { get; set; }

    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrivateCACertificateAuthorityStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("config")]
    public V1beta1PrivateCACertificateAuthorityStatusConfig? Config { get; set; }

    /// <summary>Output only. The time at which this CertificateAuthority was created.</summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    /// <summary>Output only. The time at which this CertificateAuthority was soft deleted, if it is in the DELETED state.</summary>
    [JsonPropertyName("deleteTime")]
    public DateTime? DeleteTime { get; set; }

    /// <summary>Output only. The time at which this CertificateAuthority will be permanently purged, if it is in the DELETED state.</summary>
    [JsonPropertyName("expireTime")]
    public DateTime? ExpireTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Output only. This CertificateAuthority&apos;s certificate chain, including the current CertificateAuthority&apos;s certificate. Ordered such that the root issuer is the final element (consistent with RFC 5246). For a self-signed CA, this will only list the current CertificateAuthority&apos;s certificate.</summary>
    [JsonPropertyName("pemCaCertificates")]
    public IList<string>? PemCaCertificates { get; set; }

    /// <summary>Output only. The State for this CertificateAuthority. Possible values: ENABLED, DISABLED, STAGED, AWAITING_USER_ACTIVATION, DELETED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Optional. If this is a subordinate CertificateAuthority, this field will be set with the subordinate configuration, which describes its issuers. This may be updated, but this CertificateAuthority must continue to validate.</summary>
    [JsonPropertyName("subordinateConfig")]
    public V1beta1PrivateCACertificateAuthorityStatusSubordinateConfig? SubordinateConfig { get; set; }

    /// <summary>Output only. The CaPool.Tier of the CaPool that includes this CertificateAuthority. Possible values: ENTERPRISE, DEVOPS</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Output only. The time at which this CertificateAuthority was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }
}

/// <summary>PrivateCACertificateAuthority is the Schema for the PrivateCACertificateAuthority API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateCACertificateAuthority : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrivateCACertificateAuthoritySpec>, IStatus<V1beta1PrivateCACertificateAuthorityStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateCACertificateAuthority";
    public const string KubeGroup = "privateca.cnrm.cloud.google.com";
    public const string KubePluralName = "privatecacertificateauthorities";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "privateca.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PrivateCACertificateAuthority";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PrivateCACertificateAuthoritySpec defines the desired state of PrivateCACertificateAuthority</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PrivateCACertificateAuthoritySpec Spec { get; set; }

    /// <summary>PrivateCACertificateAuthorityStatus defines the config connector machine state of PrivateCACertificateAuthority</summary>
    [JsonPropertyName("status")]
    public V1beta1PrivateCACertificateAuthorityStatus? Status { get; set; }
}