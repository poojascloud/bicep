// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_HDInsight_2018_06_01_preview
    {
        private const string ProviderNamespace = "Microsoft.HDInsight";
        private const string ApiVersion = "2018-06-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_clusters = new ResourceTypeReference(ProviderNamespace, new[]{"clusters"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_clusters_applications = new ResourceTypeReference(ProviderNamespace, new[]{"clusters", "applications"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_clusters_extensions = new ResourceTypeReference(ProviderNamespace, new[]{"clusters", "extensions"}, ApiVersion);
        private static Lazy<Microsoft_HDInsight_2018_06_01_preview> InstanceLazy = new Lazy<Microsoft_HDInsight_2018_06_01_preview>(() => new Microsoft_HDInsight_2018_06_01_preview());
        private Microsoft_HDInsight_2018_06_01_preview()
        {
            ClusterCreateProperties = new NamedObjectType("ClusterCreateProperties", new ITypeProperty[]{new TypeProperty("clusterVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("clusterDefinition", () => ClusterDefinition, TypePropertyFlags.None), new LazyTypeProperty("kafkaRestProperties", () => KafkaRestProperties, TypePropertyFlags.None), new LazyTypeProperty("securityProfile", () => SecurityProfile, TypePropertyFlags.None), new LazyTypeProperty("computeProfile", () => ComputeProfile, TypePropertyFlags.None), new LazyTypeProperty("storageProfile", () => StorageProfile, TypePropertyFlags.None), new LazyTypeProperty("diskEncryptionProperties", () => DiskEncryptionProperties, TypePropertyFlags.None), new LazyTypeProperty("encryptionInTransitProperties", () => EncryptionInTransitProperties, TypePropertyFlags.None), new TypeProperty("minSupportedTlsVersion", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("networkSettings", () => NetworkSettings, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ClusterDefinition = new NamedObjectType("ClusterDefinition", new ITypeProperty[]{new TypeProperty("blueprint", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("componentVersion", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("configurations", LanguageConstants.Any, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            KafkaRestProperties = new NamedObjectType("KafkaRestProperties", new ITypeProperty[]{new LazyTypeProperty("clientGroupInfo", () => ClientGroupInfo, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ClientGroupInfo = new NamedObjectType("ClientGroupInfo", new ITypeProperty[]{new TypeProperty("groupName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("groupId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SecurityProfile = new NamedObjectType("SecurityProfile", new ITypeProperty[]{new TypeProperty("directoryType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("domain", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("organizationalUnitDN", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("ldapsUrls", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("domainUsername", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("domainUserPassword", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clusterUsersGroupDNs", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("aaddsResourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("msiResourceId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ComputeProfile = new NamedObjectType("ComputeProfile", new ITypeProperty[]{new TypeProperty("roles", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Role = new NamedObjectType("Role", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("minInstanceCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("targetInstanceCount", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("autoscale", () => Autoscale, TypePropertyFlags.None), new LazyTypeProperty("hardwareProfile", () => HardwareProfile, TypePropertyFlags.None), new LazyTypeProperty("osProfile", () => OsProfile, TypePropertyFlags.None), new LazyTypeProperty("virtualNetworkProfile", () => VirtualNetworkProfile, TypePropertyFlags.None), new TypeProperty("dataDisksGroups", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("scriptActions", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Autoscale = new NamedObjectType("Autoscale", new ITypeProperty[]{new LazyTypeProperty("capacity", () => AutoscaleCapacity, TypePropertyFlags.None), new LazyTypeProperty("recurrence", () => AutoscaleRecurrence, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AutoscaleCapacity = new NamedObjectType("AutoscaleCapacity", new ITypeProperty[]{new TypeProperty("minInstanceCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("maxInstanceCount", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AutoscaleRecurrence = new NamedObjectType("AutoscaleRecurrence", new ITypeProperty[]{new TypeProperty("timeZone", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("schedule", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AutoscaleSchedule = new NamedObjectType("AutoscaleSchedule", new ITypeProperty[]{new TypeProperty("days", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("timeAndCapacity", () => AutoscaleTimeAndCapacity, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AutoscaleTimeAndCapacity = new NamedObjectType("AutoscaleTimeAndCapacity", new ITypeProperty[]{new TypeProperty("time", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("minInstanceCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("maxInstanceCount", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            HardwareProfile = new NamedObjectType("HardwareProfile", new ITypeProperty[]{new TypeProperty("vmSize", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OsProfile = new NamedObjectType("OsProfile", new ITypeProperty[]{new LazyTypeProperty("linuxOperatingSystemProfile", () => LinuxOperatingSystemProfile, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            LinuxOperatingSystemProfile = new NamedObjectType("LinuxOperatingSystemProfile", new ITypeProperty[]{new TypeProperty("username", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("sshProfile", () => SshProfile, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SshProfile = new NamedObjectType("SshProfile", new ITypeProperty[]{new TypeProperty("publicKeys", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SshPublicKey = new NamedObjectType("SshPublicKey", new ITypeProperty[]{new TypeProperty("certificateData", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VirtualNetworkProfile = new NamedObjectType("VirtualNetworkProfile", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("subnet", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DataDisksGroups = new NamedObjectType("DataDisksGroups", new ITypeProperty[]{new TypeProperty("disksPerNode", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ScriptAction = new NamedObjectType("ScriptAction", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("uri", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("parameters", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            StorageProfile = new NamedObjectType("StorageProfile", new ITypeProperty[]{new TypeProperty("storageaccounts", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            StorageAccount = new NamedObjectType("StorageAccount", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("isDefault", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("container", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("fileSystem", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("key", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("resourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("msiResourceId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DiskEncryptionProperties = new NamedObjectType("DiskEncryptionProperties", new ITypeProperty[]{new TypeProperty("vaultUri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("encryptionAlgorithm", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("msiResourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("encryptionAtHost", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EncryptionInTransitProperties = new NamedObjectType("EncryptionInTransitProperties", new ITypeProperty[]{new TypeProperty("isEncryptionInTransitEnabled", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NetworkSettings = new NamedObjectType("NetworkSettings", new ITypeProperty[]{new TypeProperty("publicNetworkAccess", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("outboundOnlyPublicNetworkAccessType", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ClusterIdentity = new NamedObjectType("ClusterIdentity", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("userAssignedIdentities", LanguageConstants.Any, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Componentsc51ht8schemasclusteridentitypropertiesuserassignedidentitiesadditionalproperties = new NamedObjectType("Componentsc51ht8schemasclusteridentitypropertiesuserassignedidentitiesadditionalproperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            ApplicationProperties = new NamedObjectType("ApplicationProperties", new ITypeProperty[]{new LazyTypeProperty("computeProfile", () => ComputeProfile, TypePropertyFlags.None), new TypeProperty("installScriptActions", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("uninstallScriptActions", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("httpsEndpoints", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("sshEndpoints", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("applicationType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("errors", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            RuntimeScriptAction = new NamedObjectType("RuntimeScriptAction", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("uri", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("parameters", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("roles", LanguageConstants.Array, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ApplicationGetHttpsEndpoint = new NamedObjectType("ApplicationGetHttpsEndpoint", new ITypeProperty[]{new TypeProperty("accessModes", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("destinationPort", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("publicPort", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("subDomainSuffix", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("disableGatewayAuth", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ApplicationGetEndpoint = new NamedObjectType("ApplicationGetEndpoint", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("destinationPort", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("publicPort", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Errors = new NamedObjectType("Errors", new ITypeProperty[]{new TypeProperty("code", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("message", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_clusters = new ResourceType("Microsoft.HDInsight/clusters", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ClusterCreateProperties, TypePropertyFlags.Required), new LazyTypeProperty("identity", () => ClusterIdentity, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_clusters);
            ResourceType_clusters_applications = new ResourceType("Microsoft.HDInsight/clusters/applications", new ITypeProperty[]{new TypeProperty("etag", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ApplicationProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_clusters_applications);
            ResourceType_clusters_extensions = new ResourceType("Microsoft.HDInsight/clusters/extensions", new ITypeProperty[]{new TypeProperty("workspaceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("primaryKey", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_clusters_extensions);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_clusters, () => InstanceLazy.Value.ResourceType_clusters);
            registrar.RegisterType(ResourceTypeReference_clusters_applications, () => InstanceLazy.Value.ResourceType_clusters_applications);
            registrar.RegisterType(ResourceTypeReference_clusters_extensions, () => InstanceLazy.Value.ResourceType_clusters_extensions);
        }
        private readonly ResourceType ResourceType_clusters;
        private readonly ResourceType ResourceType_clusters_applications;
        private readonly ResourceType ResourceType_clusters_extensions;
        private readonly TypeSymbol ClusterCreateProperties;
        private readonly TypeSymbol ClusterDefinition;
        private readonly TypeSymbol KafkaRestProperties;
        private readonly TypeSymbol ClientGroupInfo;
        private readonly TypeSymbol SecurityProfile;
        private readonly TypeSymbol ComputeProfile;
        private readonly TypeSymbol Role;
        private readonly TypeSymbol Autoscale;
        private readonly TypeSymbol AutoscaleCapacity;
        private readonly TypeSymbol AutoscaleRecurrence;
        private readonly TypeSymbol AutoscaleSchedule;
        private readonly TypeSymbol AutoscaleTimeAndCapacity;
        private readonly TypeSymbol HardwareProfile;
        private readonly TypeSymbol OsProfile;
        private readonly TypeSymbol LinuxOperatingSystemProfile;
        private readonly TypeSymbol SshProfile;
        private readonly TypeSymbol SshPublicKey;
        private readonly TypeSymbol VirtualNetworkProfile;
        private readonly TypeSymbol DataDisksGroups;
        private readonly TypeSymbol ScriptAction;
        private readonly TypeSymbol StorageProfile;
        private readonly TypeSymbol StorageAccount;
        private readonly TypeSymbol DiskEncryptionProperties;
        private readonly TypeSymbol EncryptionInTransitProperties;
        private readonly TypeSymbol NetworkSettings;
        private readonly TypeSymbol ClusterIdentity;
        private readonly TypeSymbol Componentsc51ht8schemasclusteridentitypropertiesuserassignedidentitiesadditionalproperties;
        private readonly TypeSymbol ApplicationProperties;
        private readonly TypeSymbol RuntimeScriptAction;
        private readonly TypeSymbol ApplicationGetHttpsEndpoint;
        private readonly TypeSymbol ApplicationGetEndpoint;
        private readonly TypeSymbol Errors;
    }
}
