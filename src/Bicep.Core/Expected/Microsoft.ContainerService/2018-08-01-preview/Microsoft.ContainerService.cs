// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerService_2018_08_01_preview
    {
        private const string ProviderNamespace = "Microsoft.ContainerService";
        private const string ApiVersion = "2018-08-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_managedClusters = new ResourceTypeReference(ProviderNamespace, new[]{"managedClusters"}, ApiVersion);
        private static Lazy<Microsoft_ContainerService_2018_08_01_preview> InstanceLazy = new Lazy<Microsoft_ContainerService_2018_08_01_preview>(() => new Microsoft_ContainerService_2018_08_01_preview());
        private Microsoft_ContainerService_2018_08_01_preview()
        {
            ManagedClusterProperties = new NamedObjectType("ManagedClusterProperties", new ITypeProperty[]{new TypeProperty("kubernetesVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dnsPrefix", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("agentPoolProfiles", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("linuxProfile", () => ContainerServiceLinuxProfile, TypePropertyFlags.None), new LazyTypeProperty("servicePrincipalProfile", () => ManagedClusterServicePrincipalProfile, TypePropertyFlags.None), new TypeProperty("addonProfiles", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("enableRBAC", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("networkProfile", () => ContainerServiceNetworkProfile, TypePropertyFlags.None), new LazyTypeProperty("aadProfile", () => ManagedClusterAADProfile, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterAgentPoolProfile = new NamedObjectType("ManagedClusterAgentPoolProfile", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("vmSize", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("osDiskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("vnetSubnetID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maxPods", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maxCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("minCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("enableAutoScaling", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerServiceLinuxProfile = new NamedObjectType("ContainerServiceLinuxProfile", new ITypeProperty[]{new TypeProperty("adminUsername", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("ssh", () => ContainerServiceSshConfiguration, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerServiceSshConfiguration = new NamedObjectType("ContainerServiceSshConfiguration", new ITypeProperty[]{new TypeProperty("publicKeys", LanguageConstants.Array, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerServiceSshPublicKey = new NamedObjectType("ContainerServiceSshPublicKey", new ITypeProperty[]{new TypeProperty("keyData", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ManagedClusterServicePrincipalProfile = new NamedObjectType("ManagedClusterServicePrincipalProfile", new ITypeProperty[]{new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("secret", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterAddonProfile = new NamedObjectType("ManagedClusterAddonProfile", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("config", LanguageConstants.Any, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerServiceNetworkProfile = new NamedObjectType("ContainerServiceNetworkProfile", new ITypeProperty[]{new TypeProperty("networkPlugin", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("networkPolicy", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("podCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serviceCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dnsServiceIP", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dockerBridgeCidr", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedClusterAADProfile = new NamedObjectType("ManagedClusterAADProfile", new ITypeProperty[]{new TypeProperty("clientAppID", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("serverAppID", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("serverAppSecret", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tenantID", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_managedClusters = new ResourceType("Microsoft.ContainerService/managedClusters", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ManagedClusterProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_managedClusters);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_managedClusters, () => InstanceLazy.Value.ResourceType_managedClusters);
        }
        private readonly ResourceType ResourceType_managedClusters;
        private readonly TypeSymbol ManagedClusterProperties;
        private readonly TypeSymbol ManagedClusterAgentPoolProfile;
        private readonly TypeSymbol ContainerServiceLinuxProfile;
        private readonly TypeSymbol ContainerServiceSshConfiguration;
        private readonly TypeSymbol ContainerServiceSshPublicKey;
        private readonly TypeSymbol ManagedClusterServicePrincipalProfile;
        private readonly TypeSymbol ManagedClusterAddonProfile;
        private readonly TypeSymbol ContainerServiceNetworkProfile;
        private readonly TypeSymbol ManagedClusterAADProfile;
    }
}
