// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerRegistry_2017_06_01_preview
    {
        private const string ProviderNamespace = "Microsoft.ContainerRegistry";
        private const string ApiVersion = "2017-06-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_registries = new ResourceTypeReference(ProviderNamespace, new[]{"registries"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_registries_replications = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "replications"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_registries_webhooks = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "webhooks"}, ApiVersion);
        private static Lazy<Microsoft_ContainerRegistry_2017_06_01_preview> InstanceLazy = new Lazy<Microsoft_ContainerRegistry_2017_06_01_preview>(() => new Microsoft_ContainerRegistry_2017_06_01_preview());
        private Microsoft_ContainerRegistry_2017_06_01_preview()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            RegistryProperties = new NamedObjectType("RegistryProperties", new ITypeProperty[]{new TypeProperty("adminUserEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("storageAccount", () => StorageAccountProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            StorageAccountProperties = new NamedObjectType("StorageAccountProperties", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ReplicationProperties = new NamedObjectType("ReplicationProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            WebhookPropertiesCreateParameters = new NamedObjectType("WebhookPropertiesCreateParameters", new ITypeProperty[]{new TypeProperty("serviceUri", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("customHeaders", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scope", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("actions", LanguageConstants.Array, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_registries = new ResourceType("Microsoft.ContainerRegistry/registries", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => RegistryProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries);
            ResourceType_registries_replications = new ResourceType("Microsoft.ContainerRegistry/registries/replications", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ReplicationProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries_replications);
            ResourceType_registries_webhooks = new ResourceType("Microsoft.ContainerRegistry/registries/webhooks", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => WebhookPropertiesCreateParameters, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries_webhooks);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_registries, () => InstanceLazy.Value.ResourceType_registries);
            registrar.RegisterType(ResourceTypeReference_registries_replications, () => InstanceLazy.Value.ResourceType_registries_replications);
            registrar.RegisterType(ResourceTypeReference_registries_webhooks, () => InstanceLazy.Value.ResourceType_registries_webhooks);
        }
        private readonly ResourceType ResourceType_registries;
        private readonly ResourceType ResourceType_registries_replications;
        private readonly ResourceType ResourceType_registries_webhooks;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol RegistryProperties;
        private readonly TypeSymbol StorageAccountProperties;
        private readonly TypeSymbol ReplicationProperties;
        private readonly TypeSymbol WebhookPropertiesCreateParameters;
    }
}
