// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DeploymentManager_2018_09_01_preview
    {
        private const string ProviderNamespace = "Microsoft.DeploymentManager";
        private const string ApiVersion = "2018-09-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_serviceTopologies = new ResourceTypeReference(ProviderNamespace, new[]{"serviceTopologies"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_steps = new ResourceTypeReference(ProviderNamespace, new[]{"steps"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_rollouts = new ResourceTypeReference(ProviderNamespace, new[]{"rollouts"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_artifactSources = new ResourceTypeReference(ProviderNamespace, new[]{"artifactSources"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_serviceTopologies_services = new ResourceTypeReference(ProviderNamespace, new[]{"serviceTopologies", "services"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_serviceTopologies_services_serviceUnits = new ResourceTypeReference(ProviderNamespace, new[]{"serviceTopologies", "services", "serviceUnits"}, ApiVersion);
        private static Lazy<Microsoft_DeploymentManager_2018_09_01_preview> InstanceLazy = new Lazy<Microsoft_DeploymentManager_2018_09_01_preview>(() => new Microsoft_DeploymentManager_2018_09_01_preview());
        private Microsoft_DeploymentManager_2018_09_01_preview()
        {
            ServiceTopologyResourceProperties = new NamedObjectType("ServiceTopologyResourceProperties", new ITypeProperty[]{new TypeProperty("artifactSourceId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServiceResourceProperties = new NamedObjectType("ServiceResourceProperties", new ITypeProperty[]{new TypeProperty("targetLocation", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("targetSubscriptionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ServiceUnitResourceProperties = new NamedObjectType("ServiceUnitResourceProperties", new ITypeProperty[]{new TypeProperty("targetResourceGroup", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("deploymentMode", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("artifacts", () => ServiceUnitArtifacts, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServiceUnitArtifacts = new NamedObjectType("ServiceUnitArtifacts", new ITypeProperty[]{new TypeProperty("templateUri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("parametersUri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("templateArtifactSourceRelativePath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("parametersArtifactSourceRelativePath", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            StepProperties = new NamedObjectType("StepProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            WaitStepProperties = new NamedObjectType("WaitStepProperties", new ITypeProperty[]{new LazyTypeProperty("attributes", () => WaitStepAttributes, TypePropertyFlags.None), new TypeProperty("stepType", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            WaitStepAttributes = new NamedObjectType("WaitStepAttributes", new ITypeProperty[]{new TypeProperty("duration", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Identity = new NamedObjectType("Identity", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("identityIds", LanguageConstants.Array, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            RolloutRequestProperties = new NamedObjectType("RolloutRequestProperties", new ITypeProperty[]{new TypeProperty("buildVersion", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("artifactSourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("targetServiceTopologyId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("stepGroups", LanguageConstants.Array, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Step = new NamedObjectType("Step", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("dependsOnStepGroups", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("preDeploymentSteps", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("deploymentTargetId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("postDeploymentSteps", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PrePostStep = new NamedObjectType("PrePostStep", new ITypeProperty[]{new TypeProperty("stepId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ArtifactSourceProperties = new NamedObjectType("ArtifactSourceProperties", new ITypeProperty[]{new TypeProperty("sourceType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("artifactRoot", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("authentication", () => Authentication, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Authentication = new NamedObjectType("Authentication", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            SasAuthentication = new NamedObjectType("SasAuthentication", new ITypeProperty[]{new LazyTypeProperty("properties", () => SasProperties, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SasProperties = new NamedObjectType("SasProperties", new ITypeProperty[]{new TypeProperty("sasUri", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_serviceTopologies = new ResourceType("Microsoft.DeploymentManager/serviceTopologies", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => ServiceTopologyResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_serviceTopologies);
            ResourceType_steps = new ResourceType("Microsoft.DeploymentManager/steps", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => StepProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_steps);
            ResourceType_rollouts = new ResourceType("Microsoft.DeploymentManager/rollouts", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("identity", () => Identity, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => RolloutRequestProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_rollouts);
            ResourceType_artifactSources = new ResourceType("Microsoft.DeploymentManager/artifactSources", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => ArtifactSourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_artifactSources);
            ResourceType_serviceTopologies_services = new ResourceType("Microsoft.DeploymentManager/serviceTopologies/services", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => ServiceResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_serviceTopologies_services);
            ResourceType_serviceTopologies_services_serviceUnits = new ResourceType("Microsoft.DeploymentManager/serviceTopologies/services/serviceUnits", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => ServiceUnitResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_serviceTopologies_services_serviceUnits);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_serviceTopologies, () => InstanceLazy.Value.ResourceType_serviceTopologies);
            registrar.RegisterType(ResourceTypeReference_steps, () => InstanceLazy.Value.ResourceType_steps);
            registrar.RegisterType(ResourceTypeReference_rollouts, () => InstanceLazy.Value.ResourceType_rollouts);
            registrar.RegisterType(ResourceTypeReference_artifactSources, () => InstanceLazy.Value.ResourceType_artifactSources);
            registrar.RegisterType(ResourceTypeReference_serviceTopologies_services, () => InstanceLazy.Value.ResourceType_serviceTopologies_services);
            registrar.RegisterType(ResourceTypeReference_serviceTopologies_services_serviceUnits, () => InstanceLazy.Value.ResourceType_serviceTopologies_services_serviceUnits);
        }
        private readonly ResourceType ResourceType_serviceTopologies;
        private readonly ResourceType ResourceType_steps;
        private readonly ResourceType ResourceType_rollouts;
        private readonly ResourceType ResourceType_artifactSources;
        private readonly ResourceType ResourceType_serviceTopologies_services;
        private readonly ResourceType ResourceType_serviceTopologies_services_serviceUnits;
        private readonly TypeSymbol ServiceTopologyResourceProperties;
        private readonly TypeSymbol ServiceResourceProperties;
        private readonly TypeSymbol ServiceUnitResourceProperties;
        private readonly TypeSymbol ServiceUnitArtifacts;
        private readonly TypeSymbol StepProperties;
        private readonly TypeSymbol WaitStepProperties;
        private readonly TypeSymbol WaitStepAttributes;
        private readonly TypeSymbol Identity;
        private readonly TypeSymbol RolloutRequestProperties;
        private readonly TypeSymbol Step;
        private readonly TypeSymbol PrePostStep;
        private readonly TypeSymbol ArtifactSourceProperties;
        private readonly TypeSymbol Authentication;
        private readonly TypeSymbol SasAuthentication;
        private readonly TypeSymbol SasProperties;
    }
}
