// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerInstance_2018_09_01
    {
        private const string ProviderNamespace = "Microsoft.ContainerInstance";
        private const string ApiVersion = "2018-09-01";
        private static readonly ResourceTypeReference ResourceTypeReference_containerGroups = new ResourceTypeReference(ProviderNamespace, new[]{"containerGroups"}, ApiVersion);
        private static Lazy<Microsoft_ContainerInstance_2018_09_01> InstanceLazy = new Lazy<Microsoft_ContainerInstance_2018_09_01>(() => new Microsoft_ContainerInstance_2018_09_01());
        private Microsoft_ContainerInstance_2018_09_01()
        {
            ContainerGroupProperties = new NamedObjectType("ContainerGroupProperties", new ITypeProperty[]{new TypeProperty("containers", LanguageConstants.Array, TypePropertyFlags.Required), new TypeProperty("imageRegistryCredentials", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("restartPolicy", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("ipAddress", () => IpAddress, TypePropertyFlags.None), new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("volumes", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("diagnostics", () => ContainerGroupDiagnostics, TypePropertyFlags.None), new LazyTypeProperty("networkProfile", () => ContainerGroupNetworkProfile, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Container = new NamedObjectType("Container", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => ContainerProperties, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerProperties = new NamedObjectType("ContainerProperties", new ITypeProperty[]{new TypeProperty("image", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("command", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("ports", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("environmentVariables", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("resources", () => ResourceRequirements, TypePropertyFlags.Required), new TypeProperty("volumeMounts", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("livenessProbe", () => ContainerProbe, TypePropertyFlags.None), new LazyTypeProperty("readinessProbe", () => ContainerProbe, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerPort = new NamedObjectType("ContainerPort", new ITypeProperty[]{new TypeProperty("protocol", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            EnvironmentVariable = new NamedObjectType("EnvironmentVariable", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("secureValue", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceRequirements = new NamedObjectType("ResourceRequirements", new ITypeProperty[]{new LazyTypeProperty("requests", () => ResourceRequests, TypePropertyFlags.Required), new LazyTypeProperty("limits", () => ResourceLimits, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceRequests = new NamedObjectType("ResourceRequests", new ITypeProperty[]{new TypeProperty("memoryInGB", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceLimits = new NamedObjectType("ResourceLimits", new ITypeProperty[]{new TypeProperty("memoryInGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VolumeMount = new NamedObjectType("VolumeMount", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("mountPath", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("readOnly", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerProbe = new NamedObjectType("ContainerProbe", new ITypeProperty[]{new LazyTypeProperty("exec", () => ContainerExec, TypePropertyFlags.None), new LazyTypeProperty("httpGet", () => ContainerHttpGet, TypePropertyFlags.None), new TypeProperty("initialDelaySeconds", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("periodSeconds", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("failureThreshold", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("successThreshold", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("timeoutSeconds", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerExec = new NamedObjectType("ContainerExec", new ITypeProperty[]{new TypeProperty("command", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerHttpGet = new NamedObjectType("ContainerHttpGet", new ITypeProperty[]{new TypeProperty("path", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("scheme", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ImageRegistryCredential = new NamedObjectType("ImageRegistryCredential", new ITypeProperty[]{new TypeProperty("server", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("username", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            IpAddress = new NamedObjectType("IpAddress", new ITypeProperty[]{new TypeProperty("ports", LanguageConstants.Array, TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("ip", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dnsNameLabel", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Port = new NamedObjectType("Port", new ITypeProperty[]{new TypeProperty("protocol", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Volume = new NamedObjectType("Volume", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("azureFile", () => AzureFileVolume, TypePropertyFlags.None), new TypeProperty("emptyDir", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("secret", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("gitRepo", () => GitRepoVolume, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AzureFileVolume = new NamedObjectType("AzureFileVolume", new ITypeProperty[]{new TypeProperty("shareName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("readOnly", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountKey", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            GitRepoVolume = new NamedObjectType("GitRepoVolume", new ITypeProperty[]{new TypeProperty("directory", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("repository", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("revision", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerGroupDiagnostics = new NamedObjectType("ContainerGroupDiagnostics", new ITypeProperty[]{new LazyTypeProperty("logAnalytics", () => LogAnalytics, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            LogAnalytics = new NamedObjectType("LogAnalytics", new ITypeProperty[]{new TypeProperty("workspaceId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("workspaceKey", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("logType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("metadata", LanguageConstants.Any, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerGroupNetworkProfile = new NamedObjectType("ContainerGroupNetworkProfile", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_containerGroups = new ResourceType("Microsoft.ContainerInstance/containerGroups", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ContainerGroupProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_containerGroups);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_containerGroups, () => InstanceLazy.Value.ResourceType_containerGroups);
        }
        private readonly ResourceType ResourceType_containerGroups;
        private readonly TypeSymbol ContainerGroupProperties;
        private readonly TypeSymbol Container;
        private readonly TypeSymbol ContainerProperties;
        private readonly TypeSymbol ContainerPort;
        private readonly TypeSymbol EnvironmentVariable;
        private readonly TypeSymbol ResourceRequirements;
        private readonly TypeSymbol ResourceRequests;
        private readonly TypeSymbol ResourceLimits;
        private readonly TypeSymbol VolumeMount;
        private readonly TypeSymbol ContainerProbe;
        private readonly TypeSymbol ContainerExec;
        private readonly TypeSymbol ContainerHttpGet;
        private readonly TypeSymbol ImageRegistryCredential;
        private readonly TypeSymbol IpAddress;
        private readonly TypeSymbol Port;
        private readonly TypeSymbol Volume;
        private readonly TypeSymbol AzureFileVolume;
        private readonly TypeSymbol GitRepoVolume;
        private readonly TypeSymbol ContainerGroupDiagnostics;
        private readonly TypeSymbol LogAnalytics;
        private readonly TypeSymbol ContainerGroupNetworkProfile;
    }
}
