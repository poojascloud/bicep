// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Automation_2017_05_15_preview
    {
        private const string ProviderNamespace = "Microsoft.Automation";
        private const string ApiVersion = "2017-05-15-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_softwareUpdateConfigurations = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "softwareUpdateConfigurations"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_sourceControls = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "sourceControls"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_jobs = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "jobs"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_sourceControls_sourceControlSyncJobs = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "sourceControls", "sourceControlSyncJobs"}, ApiVersion);
        private static Lazy<Microsoft_Automation_2017_05_15_preview> InstanceLazy = new Lazy<Microsoft_Automation_2017_05_15_preview>(() => new Microsoft_Automation_2017_05_15_preview());
        private Microsoft_Automation_2017_05_15_preview()
        {
            SoftwareUpdateConfigurationProperties = new NamedObjectType("SoftwareUpdateConfigurationProperties", new ITypeProperty[]{new LazyTypeProperty("updateConfiguration", () => UpdateConfiguration, TypePropertyFlags.Required), new LazyTypeProperty("scheduleInfo", () => SchedulePropertiesModel, TypePropertyFlags.Required), new LazyTypeProperty("error", () => ErrorResponse, TypePropertyFlags.None), new LazyTypeProperty("tasks", () => SoftwareUpdateConfigurationTasks, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            UpdateConfiguration = new NamedObjectType("UpdateConfiguration", new ITypeProperty[]{new TypeProperty("operatingSystem", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("windows", () => WindowsProperties, TypePropertyFlags.None), new LazyTypeProperty("linux", () => LinuxProperties, TypePropertyFlags.None), new TypeProperty("duration", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("azureVirtualMachines", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("nonAzureComputerNames", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("targets", () => TargetProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            WindowsProperties = new NamedObjectType("WindowsProperties", new ITypeProperty[]{new TypeProperty("includedUpdateClassifications", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("excludedKbNumbers", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("includedKbNumbers", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("rebootSetting", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            LinuxProperties = new NamedObjectType("LinuxProperties", new ITypeProperty[]{new TypeProperty("includedPackageClassifications", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("excludedPackageNameMasks", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("includedPackageNameMasks", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("rebootSetting", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            TargetProperties = new NamedObjectType("TargetProperties", new ITypeProperty[]{new TypeProperty("azureQueries", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("nonAzureQueries", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AzureQueryProperties = new NamedObjectType("AzureQueryProperties", new ITypeProperty[]{new TypeProperty("scope", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("locations", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("tagSettings", () => TagSettingsProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            TagSettingsProperties = new NamedObjectType("TagSettingsProperties", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("filterOperator", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NonAzureQueryProperties = new NamedObjectType("NonAzureQueryProperties", new ITypeProperty[]{new TypeProperty("functionAlias", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("workspaceId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SchedulePropertiesModel = new NamedObjectType("SchedulePropertiesModel", new ITypeProperty[]{new TypeProperty("startTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("expiryTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("expiryTimeOffsetMinutes", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("isEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("nextRun", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("nextRunOffsetMinutes", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("interval", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("frequency", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("timeZone", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("advancedSchedule", () => AdvancedSchedule, TypePropertyFlags.None), new TypeProperty("creationTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastModifiedTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AdvancedSchedule = new NamedObjectType("AdvancedSchedule", new ITypeProperty[]{new TypeProperty("weekDays", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("monthDays", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("monthlyOccurrences", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AdvancedScheduleMonthlyOccurrence = new NamedObjectType("AdvancedScheduleMonthlyOccurrence", new ITypeProperty[]{new TypeProperty("occurrence", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("day", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ErrorResponse = new NamedObjectType("ErrorResponse", new ITypeProperty[]{new TypeProperty("code", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("message", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SoftwareUpdateConfigurationTasks = new NamedObjectType("SoftwareUpdateConfigurationTasks", new ITypeProperty[]{new LazyTypeProperty("preTask", () => TaskProperties, TypePropertyFlags.None), new LazyTypeProperty("postTask", () => TaskProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            TaskProperties = new NamedObjectType("TaskProperties", new ITypeProperty[]{new TypeProperty("parameters", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("source", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SourceControlCreateOrUpdateProperties = new NamedObjectType("SourceControlCreateOrUpdateProperties", new ITypeProperty[]{new TypeProperty("repoUrl", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("branch", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("folderPath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("autoSync", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("publishRunbook", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("sourceType", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("securityToken", () => SourceControlSecurityTokenProperties, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SourceControlSecurityTokenProperties = new NamedObjectType("SourceControlSecurityTokenProperties", new ITypeProperty[]{new TypeProperty("accessToken", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("refreshToken", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tokenType", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SourceControlSyncJobCreateProperties = new NamedObjectType("SourceControlSyncJobCreateProperties", new ITypeProperty[]{new TypeProperty("commitId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            JobCreateProperties = new NamedObjectType("JobCreateProperties", new ITypeProperty[]{new LazyTypeProperty("runbook", () => RunbookAssociationProperty, TypePropertyFlags.None), new TypeProperty("parameters", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("runOn", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            RunbookAssociationProperty = new NamedObjectType("RunbookAssociationProperty", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_automationAccounts_softwareUpdateConfigurations = new ResourceType("Microsoft.Automation/automationAccounts/softwareUpdateConfigurations", new ITypeProperty[]{new LazyTypeProperty("properties", () => SoftwareUpdateConfigurationProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_automationAccounts_softwareUpdateConfigurations);
            ResourceType_automationAccounts_sourceControls = new ResourceType("Microsoft.Automation/automationAccounts/sourceControls", new ITypeProperty[]{new LazyTypeProperty("properties", () => SourceControlCreateOrUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_automationAccounts_sourceControls);
            ResourceType_automationAccounts_jobs = new ResourceType("Microsoft.Automation/automationAccounts/jobs", new ITypeProperty[]{new LazyTypeProperty("properties", () => JobCreateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_automationAccounts_jobs);
            ResourceType_automationAccounts_sourceControls_sourceControlSyncJobs = new ResourceType("Microsoft.Automation/automationAccounts/sourceControls/sourceControlSyncJobs", new ITypeProperty[]{new LazyTypeProperty("properties", () => SourceControlSyncJobCreateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_automationAccounts_sourceControls_sourceControlSyncJobs);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_automationAccounts_softwareUpdateConfigurations, () => InstanceLazy.Value.ResourceType_automationAccounts_softwareUpdateConfigurations);
            registrar.RegisterType(ResourceTypeReference_automationAccounts_sourceControls, () => InstanceLazy.Value.ResourceType_automationAccounts_sourceControls);
            registrar.RegisterType(ResourceTypeReference_automationAccounts_jobs, () => InstanceLazy.Value.ResourceType_automationAccounts_jobs);
            registrar.RegisterType(ResourceTypeReference_automationAccounts_sourceControls_sourceControlSyncJobs, () => InstanceLazy.Value.ResourceType_automationAccounts_sourceControls_sourceControlSyncJobs);
        }
        private readonly ResourceType ResourceType_automationAccounts_softwareUpdateConfigurations;
        private readonly ResourceType ResourceType_automationAccounts_sourceControls;
        private readonly ResourceType ResourceType_automationAccounts_jobs;
        private readonly ResourceType ResourceType_automationAccounts_sourceControls_sourceControlSyncJobs;
        private readonly TypeSymbol SoftwareUpdateConfigurationProperties;
        private readonly TypeSymbol UpdateConfiguration;
        private readonly TypeSymbol WindowsProperties;
        private readonly TypeSymbol LinuxProperties;
        private readonly TypeSymbol TargetProperties;
        private readonly TypeSymbol AzureQueryProperties;
        private readonly TypeSymbol TagSettingsProperties;
        private readonly TypeSymbol NonAzureQueryProperties;
        private readonly TypeSymbol SchedulePropertiesModel;
        private readonly TypeSymbol AdvancedSchedule;
        private readonly TypeSymbol AdvancedScheduleMonthlyOccurrence;
        private readonly TypeSymbol ErrorResponse;
        private readonly TypeSymbol SoftwareUpdateConfigurationTasks;
        private readonly TypeSymbol TaskProperties;
        private readonly TypeSymbol SourceControlCreateOrUpdateProperties;
        private readonly TypeSymbol SourceControlSecurityTokenProperties;
        private readonly TypeSymbol SourceControlSyncJobCreateProperties;
        private readonly TypeSymbol JobCreateProperties;
        private readonly TypeSymbol RunbookAssociationProperty;
    }
}
