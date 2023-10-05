#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."

namespace Biosero.DataServices.Client
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AddEventCommand
    {
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Data { get; set; }

        [Newtonsoft.Json.JsonProperty("topic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Topic { get; set; }

        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Start { get; set; }

        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? End { get; set; }

        [Newtonsoft.Json.JsonProperty("organizationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        [Newtonsoft.Json.JsonProperty("groupId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        [Newtonsoft.Json.JsonProperty("ownerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OwnerId { get; set; }

        [Newtonsoft.Json.JsonProperty("accessPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccessPolicy { get; set; }

        [Newtonsoft.Json.JsonProperty("sharingPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SharingPolicy { get; set; }

        [Newtonsoft.Json.JsonProperty("retentionPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RetentionPolicy { get; set; }

        [Newtonsoft.Json.JsonProperty("associationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssociationId { get; set; }

        [Newtonsoft.Json.JsonProperty("activityId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActivityId { get; set; }

        [Newtonsoft.Json.JsonProperty("actorId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActorId { get; set; }

        [Newtonsoft.Json.JsonProperty("subjects", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Subjects { get; set; }

        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Tags { get; set; }

        [Newtonsoft.Json.JsonProperty("orchestratorId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrchestratorId { get; set; }

        [Newtonsoft.Json.JsonProperty("operatorId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OperatorId { get; set; }

        [Newtonsoft.Json.JsonProperty("moduleId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        [Newtonsoft.Json.JsonProperty("sourceTraceIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> SourceTraceIds { get; set; }

        [Newtonsoft.Json.JsonProperty("encryptionProvider", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EncryptionProvider { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AddWorkflowErrorCommand
    {
        [Newtonsoft.Json.JsonProperty("exception", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Exception { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AddWorkflowGlobalVariableCommand
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }

        [Newtonsoft.Json.JsonProperty("valueType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ParameterValueType ValueType { get; set; }

        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unit { get; set; }

        [Newtonsoft.Json.JsonProperty("defaultValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Tags { get; set; }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AddWorkflowLocalVariableCommand
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }

        [Newtonsoft.Json.JsonProperty("valueType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ParameterValueType ValueType { get; set; }

        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unit { get; set; }

        [Newtonsoft.Json.JsonProperty("defaultValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Tags { get; set; }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AuthenticationTypeOnly
    {
        [Newtonsoft.Json.JsonProperty("authenticationType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AuthenticationTypes AuthenticationType { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum AuthenticationTypes
    {

        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"AzureActiveDirectory")]
        AzureActiveDirectory = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AzureActiveDirectoryConfiguration
    {
        [Newtonsoft.Json.JsonProperty("instance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Instance { get; set; }

        [Newtonsoft.Json.JsonProperty("tenantId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        [Newtonsoft.Json.JsonProperty("dataServicesClientId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DataServicesClientId { get; set; }

        [Newtonsoft.Json.JsonProperty("conductorClientId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConductorClientId { get; set; }

        [Newtonsoft.Json.JsonProperty("schedulerClientId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchedulerClientId { get; set; }

        [Newtonsoft.Json.JsonProperty("insightsClientId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InsightsClientId { get; set; }

        [Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Scopes { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Concentration
    {
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Value { get; set; }

        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ConcentrationUnit Unit { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ConcentrationUnit
    {

        [System.Runtime.Serialization.EnumMember(Value = @"mM")]
        MM = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"uM")]
        UM = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"nM")]
        NM = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"mgmL")]
        MgmL = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateMobileRobotTransportCommand
    {
        [Newtonsoft.Json.JsonProperty("mobileRobotIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MobileRobotIdentifier { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateOrderCommand
    {
        /// <summary>
        /// Gets or sets the unique identifier of a parent order if the order was generated by a parent order. Null or empty if not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the run after identifier.  This is the identifier of an order that must complete successfully before this order can start.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("runAfterIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RunAfterIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the restrict to module ids.  This is a comma separated list of module ids that can be used to execute the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restrictToModuleIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RestrictToModuleIds { get; set; }

        /// <summary>
        /// Gets or sets the module restriction strategy. This defines how the RestrictToModuleIds is applied to limit the modules the order can be executed on.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("moduleRestrictionStrategy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ModuleRestrictionStrategy ModuleRestrictionStrategy { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the creator of the order, usually a User's identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets additional (optional) notes about the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the scheduled start time of the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scheduledStartTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ScheduledStartTime { get; set; }

        /// <summary>
        /// Gets or sets the estimated duration of the order in minutes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimatedDurationInMinutes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EstimatedDurationInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the name of the template used to create the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("templateName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Gets or sets the input parameters for the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inputParameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> InputParameters { get; set; }

        /// <summary>
        /// Gets or sets the output parameters for the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("outputParameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> OutputParameters { get; set; }

        /// <summary>
        /// Gets or sets the scheduling strategy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedulingStrategy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SchedulingStrategy SchedulingStrategy { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateTransportationRequestCommand
    {
        [Newtonsoft.Json.JsonProperty("sourceStationIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceStationIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("destinationStationIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DestinationStationIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("itemIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("itemMetadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemMetadata { get; set; }

        [Newtonsoft.Json.JsonProperty("orderIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateTransportationRequestGroupCommand
    {
        [Newtonsoft.Json.JsonProperty("sourceStationIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceStationIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("destinationStationIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DestinationStationIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("itemIdentifiers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ItemIdentifiers { get; set; }

        [Newtonsoft.Json.JsonProperty("itemMetadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemMetadata { get; set; }

        [Newtonsoft.Json.JsonProperty("orderIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateWebhookCommand
    {
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        [Newtonsoft.Json.JsonProperty("hexSecret", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HexSecret { get; set; }

        [Newtonsoft.Json.JsonProperty("eventTypeFilterRegex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EventTypeFilterRegex { get; set; }

        [Newtonsoft.Json.JsonProperty("isEnabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsEnabled { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateWorkflowThreadCommand
    {
        [Newtonsoft.Json.JsonProperty("workflowElementGuid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkflowElementGuid { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowElementName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkflowElementName { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowElementLocalVariables", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> WorkflowElementLocalVariables { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EventIdOnly
    {
        [Newtonsoft.Json.JsonProperty("eventId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EventId { get; set; }

    }

    /// <summary>
    /// Class EventMessage.
    /// <br/>Implements the Biosero.DataServices.Domain.Event.EventContext.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EventMessage
    {
        /// <summary>
        /// Gets or sets the topic.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// Gets or sets the event identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eventId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EventId { get; set; }

        /// <summary>
        /// Gets or sets the start time of the event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset Start { get; set; }

        /// <summary>
        /// Gets or sets the end time of the event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset End { get; set; }

        /// <summary>
        /// Gets or sets the organization identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the group identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets the owner identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ownerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the access policy for this data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accessPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccessPolicy { get; set; }

        /// <summary>
        /// Gets or sets the sharing policy for this data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharingPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SharingPolicy { get; set; }

        /// <summary>
        /// Gets or sets the retention policy for this data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retentionPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RetentionPolicy { get; set; }

        /// <summary>
        /// Gets or sets the association identifier links this data to a specific order, job, or task identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("associationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssociationId { get; set; }

        /// <summary>
        /// Gets or sets the activity identifier identifies the type of activity this event relates to.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Gets or sets the actor identifier identifies the actor responsible for the event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actorId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActorId { get; set; }

        /// <summary>
        /// Gets or sets the subjects.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjects", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Subjects { get; set; }

        /// <summary>
        /// Gets or sets the tags array can be used to tag the event with any associated data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the orchestrator identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orchestratorId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrchestratorId { get; set; }

        /// <summary>
        /// Gets or sets the operator identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operatorId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OperatorId { get; set; }

        /// <summary>
        /// Gets or sets the module identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("moduleId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// Gets or sets the source trace identifiers.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sourceTraceIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> SourceTraceIds { get; set; }

        /// <summary>
        /// Gets or sets the encryption provider.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encryptionProvider", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EncryptionProvider { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Data { get; set; }

        [Newtonsoft.Json.JsonProperty("createdDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CreatedDateUtc { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EventMessagePage
    {
        [Newtonsoft.Json.JsonProperty("rows", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<EventMessage> Rows { get; set; }

        [Newtonsoft.Json.JsonProperty("totalCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum FileType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"RdpFile")]
        RdpFile = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Image")]
        Image = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"License")]
        License = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetNextTransportationRequestCommand
    {
        [Newtonsoft.Json.JsonProperty("assignedToIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssignedToIdentifier { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HostEnvironmentNameOnly
    {
        [Newtonsoft.Json.JsonProperty("environmentName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EnvironmentName { get; set; }

    }

    /// <summary>
    /// Class Identity.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Identity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("typeIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("properties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> Properties { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [inherit properties].
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inheritProperties", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool InheritProperties { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is an instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isInstance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsInstance { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Instrument
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("typeIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("properties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> Properties { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [inherit properties].
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inheritProperties", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool InheritProperties { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is an instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isInstance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsInstance { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class InstrumentOperationEvent
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long Id { get; set; }

        [Newtonsoft.Json.JsonProperty("instrumentId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InstrumentId { get; set; }

        [Newtonsoft.Json.JsonProperty("instrumentProcess", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InstrumentProcess { get; set; }

        [Newtonsoft.Json.JsonProperty("instrumentCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InstrumentCategory { get; set; }

        [Newtonsoft.Json.JsonProperty("manufacturer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Manufacturer { get; set; }

        [Newtonsoft.Json.JsonProperty("instrumentName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InstrumentName { get; set; }

        [Newtonsoft.Json.JsonProperty("instrumentInstanceName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InstrumentInstanceName { get; set; }

        [Newtonsoft.Json.JsonProperty("workcellId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkcellId { get; set; }

        [Newtonsoft.Json.JsonProperty("workcellProcess", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkcellProcess { get; set; }

        [Newtonsoft.Json.JsonProperty("orderId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserId { get; set; }

        [Newtonsoft.Json.JsonProperty("userName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserName { get; set; }

        [Newtonsoft.Json.JsonProperty("operation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Operation { get; set; }

        [Newtonsoft.Json.JsonProperty("operationInputParameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OperationInputParameters { get; set; }

        [Newtonsoft.Json.JsonProperty("operationOutputParameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OperationOutputParameters { get; set; }

        [Newtonsoft.Json.JsonProperty("color", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Color { get; set; }

        [Newtonsoft.Json.JsonProperty("imageUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("platesOnInstrument", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlatesOnInstrument { get; set; }

        [Newtonsoft.Json.JsonProperty("plateProcess", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlateProcess { get; set; }

        [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Errors { get; set; }

        [Newtonsoft.Json.JsonProperty("errorsAndResponses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ErrorsAndResponses { get; set; }

        [Newtonsoft.Json.JsonProperty("wasCauseOfCriticalFailure", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool WasCauseOfCriticalFailure { get; set; }

        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset Start { get; set; }

        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset End { get; set; }

        [Newtonsoft.Json.JsonProperty("estimatedDuration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.TimeSpan EstimatedDuration { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LicenseConfiguration
    {
        [Newtonsoft.Json.JsonProperty("licenseKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LicenseKey { get; set; }

        [Newtonsoft.Json.JsonProperty("productId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid ProductId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LicenseState
    {
        [Newtonsoft.Json.JsonProperty("machineFingerprint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MachineFingerprint { get; set; }

        [Newtonsoft.Json.JsonProperty("machines", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Machines { get; set; }

        [Newtonsoft.Json.JsonProperty("maxMachines", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int MaxMachines { get; set; }

        [Newtonsoft.Json.JsonProperty("expirationDateUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpirationDateUtc { get; set; }

        [Newtonsoft.Json.JsonProperty("cloudServicesLastReachedUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CloudServicesLastReachedUtc { get; set; }

        [Newtonsoft.Json.JsonProperty("suspended", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Suspended { get; set; }

        [Newtonsoft.Json.JsonProperty("valid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Valid { get; set; }

    }

    /// <summary>
    /// Class Location.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Location
    {
        /// <summary>
        /// Gets or sets the parent identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("itemIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the coordinates.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coordinates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Coordinates { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MaintenanceModeSwitch
    {
        [Newtonsoft.Json.JsonProperty("isOn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsOn { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MaterialInContainerSearchResult
    {
        [Newtonsoft.Json.JsonProperty("containerIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContainerIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("materialIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaterialIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("concentration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Concentration Concentration { get; set; }

        [Newtonsoft.Json.JsonProperty("netVolume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Volume NetVolume { get; set; }

        [Newtonsoft.Json.JsonProperty("netWeight", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Weight NetWeight { get; set; }

        [Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Path { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum MaterialState
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Solid")]
        Solid = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Liquid")]
        Liquid = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Gas")]
        Gas = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Plasma")]
        Plasma = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MobileRobotIdentifierOnly
    {
        [Newtonsoft.Json.JsonProperty("mobileRobotIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MobileRobotIdentifier { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MobileRobotTransport
    {
        [Newtonsoft.Json.JsonProperty("mobileRobotIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MobileRobotIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MobileRobotTransportStatus Status { get; set; }

        [Newtonsoft.Json.JsonProperty("isFaulted", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsFaulted { get; set; }

        [Newtonsoft.Json.JsonProperty("stationIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StationIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("requestIdentifiers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> RequestIdentifiers { get; set; }

        [Newtonsoft.Json.JsonProperty("isProcessing", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsProcessing { get; set; }

        [Newtonsoft.Json.JsonProperty("runAfterDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset RunAfterDateUtc { get; set; }

        [Newtonsoft.Json.JsonProperty("modifiedDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ModifiedDateUtc { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum MobileRobotTransportStatus
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Offline")]
        Offline = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Available")]
        Available = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Assigned")]
        Assigned = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"MovingToStation")]
        MovingToStation = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"AtStation")]
        AtStation = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ModuleRestrictionStrategy
    {

        [System.Runtime.Serialization.EnumMember(Value = @"NoRestriction")]
        NoRestriction = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"UnlessBusy")]
        UnlessBusy = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"UnlessError")]
        UnlessError = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"UnlessOffline")]
        UnlessOffline = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"FullRestriction")]
        FullRestriction = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ModuleStatus
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Ready")]
        Ready = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Busy")]
        Busy = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Error")]
        Error = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Offline")]
        Offline = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ModuleStatusUpdateEvent
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long Id { get; set; }

        [Newtonsoft.Json.JsonProperty("moduleIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModuleIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("moduleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModuleName { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ModuleStatus Status { get; set; }

        [Newtonsoft.Json.JsonProperty("statusDetails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusDetails { get; set; }

        [Newtonsoft.Json.JsonProperty("image", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Image { get; set; }

        [Newtonsoft.Json.JsonProperty("ordersBeingProcessed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> OrdersBeingProcessed { get; set; }

        [Newtonsoft.Json.JsonProperty("allowSimultaneousExecution", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool AllowSimultaneousExecution { get; set; }

        [Newtonsoft.Json.JsonProperty("instrumentIdentifiers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> InstrumentIdentifiers { get; set; }

        [Newtonsoft.Json.JsonProperty("capabilities", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Capabilities { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Order
    {
        /// <summary>
        /// Gets or sets the unique identifier for this order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of a parent order if the order was generated by a parent order. Null or empty if not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of a root parent order.  If order is the root this will be it's identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sourceIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the run after identifier.  This is the identifier of an order that must complete successfully before this order can start.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("runAfterIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RunAfterIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the restrict to module ids.  This is a comma separated list of module ids that can be used to execute the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restrictToModuleIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RestrictToModuleIds { get; set; }

        /// <summary>
        /// Gets or sets the module restriction strategy. This defines how the RestrictToModuleIds is applied to limit the modules the order can be executed on.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("moduleRestrictionStrategy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ModuleRestrictionStrategy ModuleRestrictionStrategy { get; set; }

        /// <summary>
        /// Gets or sets the status details. This can be set by an executing order to provide additional details about the order status.  For example, during an error state the StatusDetails would include the error message.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusDetails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusDetails { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the creator of the order, usually a User's identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets additional (optional) notes about the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the status of the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creationTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the scheduled start time of the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scheduledStartTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ScheduledStartTime { get; set; }

        /// <summary>
        /// Gets or sets the actual start time of the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actualStartTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ActualStartTime { get; set; }

        /// <summary>
        /// Gets or sets the estimated duration of the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimatedDuration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.TimeSpan EstimatedDuration { get; set; }

        /// <summary>
        /// Gets or sets the actual end time of the order, set after the order has completed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actualEndTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ActualEndTime { get; set; }

        /// <summary>
        /// Gets or sets the name of the template used to create the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("templateName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Gets or sets the input parameters for the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inputParameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> InputParameters { get; set; }

        /// <summary>
        /// Gets or sets the output parameters for the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("outputParameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> OutputParameters { get; set; }

        /// <summary>
        /// Gets or sets the module or process that the order is assigned to.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("assignedTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssignedTo { get; set; }

        /// <summary>
        /// Gets or sets the validation errors.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ValidationErrors { get; set; }

        /// <summary>
        /// Gets or sets the state of the order. This is used to persist the state if orders are suspended or need to be recovered.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the scheduling strategy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedulingStrategy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SchedulingStrategy SchedulingStrategy { get; set; }

        /// <summary>
        /// Gets or sets the order execution log.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Log { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OrderAssignedOnly
    {
        [Newtonsoft.Json.JsonProperty("orderAssigned", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool OrderAssigned { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OrderPage
    {
        [Newtonsoft.Json.JsonProperty("rows", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Order> Rows { get; set; }

        [Newtonsoft.Json.JsonProperty("totalCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum OrderStatus
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Created")]
        Created = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Invalid")]
        Invalid = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Validated")]
        Validated = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Scheduled")]
        Scheduled = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Running")]
        Running = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"Paused")]
        Paused = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"Error")]
        Error = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"Complete")]
        Complete = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"Canceled")]
        Canceled = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"Consolidated")]
        Consolidated = 9,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OrderTemplate
    {
        /// <summary>
        /// Gets or sets the name of the order template.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the category.  The category is used to organize the templates in the UI.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the required capabilities.  This is a comma separated list of module capabilities that are required for execution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requiredCapabilities", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RequiredCapabilities { get; set; }

        /// <summary>
        /// Gets or sets the available module ids. A comma separated list of module ids that care capable of executing an order created from this template.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("availableModuleIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailableModuleIds { get; set; }

        /// <summary>
        /// Gets or sets the icon that is used for this template. The value can be a url or a PackIcon Kind name.  See MaterialDesignInXaml on github for more information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("icon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the color used to represent this order template.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("color", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the input parameters. These specify the parameters that get passed into the order when it is executed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inputParameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> InputParameters { get; set; }

        /// <summary>
        /// Gets or sets the output parameters. These parameters are set with any output from the execution of the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("outputParameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> OutputParameters { get; set; }

        /// <summary>
        /// Gets or sets the validation script.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validationScript", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ValidationScript { get; set; }

        /// <summary>
        /// Gets or sets the validation script language.  'C#' is the default.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validationScriptLanguage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ValidationScriptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the default estimated duration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("defaultEstimatedDuration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.TimeSpan DefaultEstimatedDuration { get; set; }

        /// <summary>
        /// Gets or sets the duration estimation script.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("durationEstimationScript", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DurationEstimationScript { get; set; }

        /// <summary>
        /// Gets or sets the duration estimation script language.  'C#' is the default.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("durationEstimationScriptLanguage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DurationEstimationScriptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the scheduling strategy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedulingStrategy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SchedulingStrategy SchedulingStrategy { get; set; }

        /// <summary>
        /// Gets or sets the workflow. This is the full json serialization of the workflow to execute if applicable.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("workflow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Workflow { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not this template is hidden.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isHidden", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsHidden { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OrderWorkflow
    {
        [Newtonsoft.Json.JsonProperty("orderIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OrderStatus Status { get; set; }

        [Newtonsoft.Json.JsonProperty("templateName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        [Newtonsoft.Json.JsonProperty("workflow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Workflow { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PageFilter
    {
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PageFilterType? Type { get; set; }

        [Newtonsoft.Json.JsonProperty("column", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Column { get; set; }

        [Newtonsoft.Json.JsonProperty("operator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PageFilterOperator? Operator { get; set; }

        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum PageFilterOperator
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Equals")]
        Equals = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"NotEqual")]
        NotEqual = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Contains")]
        Contains = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"LessThan")]
        LessThan = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"LessThanOrEqual")]
        LessThanOrEqual = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"GreaterThan")]
        GreaterThan = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"GreaterThanOrEqual")]
        GreaterThanOrEqual = 6,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum PageFilterType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Text")]
        Text = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Integer")]
        Integer = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Double")]
        Double = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Date")]
        Date = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Boolean")]
        Boolean = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"Set")]
        Set = 5,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum PageSortType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Ascending")]
        Ascending = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Descending")]
        Descending = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Parameter
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }

        [Newtonsoft.Json.JsonProperty("valueType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ParameterValueType ValueType { get; set; }

        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unit { get; set; }

        [Newtonsoft.Json.JsonProperty("defaultValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        [Newtonsoft.Json.JsonProperty("valueOptions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ValueOptions { get; set; }

        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Tags { get; set; }

        [Newtonsoft.Json.JsonProperty("identity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Identity { get; set; }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ParameterValueType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"String")]
        String = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Boolean")]
        Boolean = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Double")]
        Double = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Integer")]
        Integer = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Other")]
        Other = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PopAndPushWorkflowStackCommand
    {
        [Newtonsoft.Json.JsonProperty("stackElements", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<StackElement> StackElements { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ProblemDetails
    {
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Status { get; set; }

        [Newtonsoft.Json.JsonProperty("detail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Detail { get; set; }

        [Newtonsoft.Json.JsonProperty("instance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Instance { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PushWorkflowStackCommand
    {
        [Newtonsoft.Json.JsonProperty("stackElements", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<StackElement> StackElements { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RegisterIdentityCommand
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("typeIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        [Newtonsoft.Json.JsonProperty("properties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> Properties { get; set; }

        [Newtonsoft.Json.JsonProperty("inheritProperties", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool InheritProperties { get; set; }

        [Newtonsoft.Json.JsonProperty("isInstance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsInstance { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ReleaseMobileRobotTransportCommand
    {
        [Newtonsoft.Json.JsonProperty("runAfterDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset RunAfterDateUtc { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ReleaseTransportationRequestCommand
    {
        [Newtonsoft.Json.JsonProperty("runAfterDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset RunAfterDateUtc { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SampleInContainerSearchResult
    {
        [Newtonsoft.Json.JsonProperty("containerIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContainerIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("sampleIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SampleIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("concentration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Concentration Concentration { get; set; }

        [Newtonsoft.Json.JsonProperty("netVolume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Volume NetVolume { get; set; }

        [Newtonsoft.Json.JsonProperty("netWeight", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Weight NetWeight { get; set; }

        [Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Path { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum SchedulingStrategy
    {

        [System.Runtime.Serialization.EnumMember(Value = @"ImmediateExecution")]
        ImmediateExecution = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"FirstAvailableSlot")]
        FirstAvailableSlot = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SetOutputParameterCommand
    {
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SleepWorkflowThreadCommand
    {
        [Newtonsoft.Json.JsonProperty("nextRunDateUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? NextRunDateUtc { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StackElement
    {
        [Newtonsoft.Json.JsonProperty("workflowElementGuid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkflowElementGuid { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowElementName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkflowElementName { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TransformationJob
    {
        [Newtonsoft.Json.JsonProperty("key", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Key { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Version { get; set; }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        [Newtonsoft.Json.JsonProperty("topic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Topic { get; set; }

        [Newtonsoft.Json.JsonProperty("isEnabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsEnabled { get; set; }

        [Newtonsoft.Json.JsonProperty("script", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Script { get; set; }

        [Newtonsoft.Json.JsonProperty("scriptLanguage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScriptLanguage { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TransportationManagerSwitch
    {
        [Newtonsoft.Json.JsonProperty("isOn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsOn { get; set; }

    }

    /// <summary>
    /// Class TransportationRequest.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TransportationRequest
    {
        /// <summary>
        /// Gets or sets the request identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RequestIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the request group identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestGroupIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RequestGroupIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orderIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the source order identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sourceOrderIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceOrderIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the vehicle identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vehicleIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VehicleIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the transportation manager this request is assigned to.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("assignedToIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssignedToIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the request status.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TransportationRequestStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the previous request status.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("previousStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TransportationRequestStatus? PreviousStatus { get; set; }

        /// <summary>
        /// Gets or sets the status details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusDetails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusDetails { get; set; }

        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("itemIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the item metadata.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("itemMetadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemMetadata { get; set; }

        /// <summary>
        /// Gets or sets the source station identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sourceStationIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceStationIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the destination station identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("destinationStationIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DestinationStationIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the location at the source station that the item is being picked up from.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locationAtSource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationAtSource { get; set; }

        /// <summary>
        /// Gets or sets the location at destination that the item is being dropped off at.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locationAtDestination", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationAtDestination { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the creator of the order, usually a User's identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the created time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createdTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the started time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startedTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartedTime { get; set; }

        /// <summary>
        /// Gets or sets the pickup time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pickupTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset PickupTime { get; set; }

        /// <summary>
        /// Gets or sets the dropoff time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dropoffTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset DropoffTime { get; set; }

        /// <summary>
        /// Gets or sets the complete time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("completeTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CompleteTime { get; set; }

        /// <summary>
        /// Gets or sets the error time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errorTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ErrorTime { get; set; }

        /// <summary>
        /// Gets or sets the date the request will be ready to run by the Transportation Manager.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("runAfterDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset RunAfterDateUtc { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the request is currently being processed by the Transportation Manager.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isProcessing", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsProcessing { get; set; }

        /// <summary>
        /// Gets or sets the date the request was last modified.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modifiedDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ModifiedDateUtc { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TransportationRequestAssignedOnly
    {
        [Newtonsoft.Json.JsonProperty("requestAssigned", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool RequestAssigned { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TransportationRequestGroupIdentifierOnly
    {
        [Newtonsoft.Json.JsonProperty("requestGroupIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RequestGroupIdentifier { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TransportationRequestIdentifierOnly
    {
        [Newtonsoft.Json.JsonProperty("requestIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RequestIdentifier { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TransportationRequestPage
    {
        [Newtonsoft.Json.JsonProperty("rows", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TransportationRequest> Rows { get; set; }

        [Newtonsoft.Json.JsonProperty("totalCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

    }

    /// <summary>
    /// Enum TransportationRequestStatus.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum TransportationRequestStatus
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Created")]
        Created = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Started")]
        Started = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"ItemNotAvailableAtSource")]
        ItemNotAvailableAtSource = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"SpaceNotAvailableAtDestination")]
        SpaceNotAvailableAtDestination = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"NoVehicleAvailable")]
        NoVehicleAvailable = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"VehicleAssigned")]
        VehicleAssigned = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"VehicleMovingToPickup")]
        VehicleMovingToPickup = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"VehicleAtPickup")]
        VehicleAtPickup = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"PickupActive")]
        PickupActive = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"ItemLoadedOnVehicle")]
        ItemLoadedOnVehicle = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"VehicleMovingToDropoff")]
        VehicleMovingToDropoff = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"VehicleAtDropoff")]
        VehicleAtDropoff = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"DropoffActive")]
        DropoffActive = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"DropoffComplete")]
        DropoffComplete = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"Reset")]
        Reset = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"Aborted")]
        Aborted = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"Complete")]
        Complete = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"Canceled")]
        Canceled = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"Error")]
        Error = 18,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TryAssignOrderCommand
    {
        [Newtonsoft.Json.JsonProperty("to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string To { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TryAssignTransportationRequestCommand
    {
        [Newtonsoft.Json.JsonProperty("assignedToIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssignedToIdentifier { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TryAssignVehicleBatchCommand
    {
        [Newtonsoft.Json.JsonProperty("requestIdentifiers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> RequestIdentifiers { get; set; }

        [Newtonsoft.Json.JsonProperty("vehicleIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VehicleIdentifier { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateMobileRobotTransportCommand
    {
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MobileRobotTransportStatus Status { get; set; }

        [Newtonsoft.Json.JsonProperty("isFaulted", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsFaulted { get; set; }

        [Newtonsoft.Json.JsonProperty("stationIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StationIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("requestIdentifiers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> RequestIdentifiers { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateOrderCommand
    {
        /// <summary>
        /// Gets or sets the unique identifier of a parent order if the order was generated by a parent order. Null or empty if not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the run after identifier.  This is the identifier of an order that must complete successfully before this order can start.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("runAfterIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RunAfterIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the restrict to module ids.  This is a comma separated list of module ids that can be used to execute the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restrictToModuleIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RestrictToModuleIds { get; set; }

        /// <summary>
        /// Gets or sets the module restriction strategy. This defines how the RestrictToModuleIds is applied to limit the modules the order can be executed on.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("moduleRestrictionStrategy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ModuleRestrictionStrategy ModuleRestrictionStrategy { get; set; }

        /// <summary>
        /// Gets or sets additional (optional) notes about the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the status of the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the status details. This can be set by an executing order to provide additional details about the order status.  For example, during an error state the StatusDetails would include the error message.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusDetails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusDetails { get; set; }

        /// <summary>
        /// Gets or sets the scheduled start time of the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scheduledStartTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ScheduledStartTime { get; set; }

        /// <summary>
        /// Gets or sets the estimated duration of the order in minutes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimatedDurationInMinutes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal EstimatedDurationInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the name of the template used to create the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("templateName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Gets or sets the input parameters for the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inputParameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> InputParameters { get; set; }

        /// <summary>
        /// Gets or sets the output parameters for the order.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("outputParameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> OutputParameters { get; set; }

        /// <summary>
        /// Gets or sets the module or process that the order is assigned to.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("assignedTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssignedTo { get; set; }

        /// <summary>
        /// Gets or sets the validation errors.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validationErrors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ValidationErrors { get; set; }

        /// <summary>
        /// Gets or sets the state of the order. This is used to persist the state if orders are suspended or need to be recovered.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the scheduling strategy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedulingStrategy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SchedulingStrategy SchedulingStrategy { get; set; }

        /// <summary>
        /// Gets or sets the order execution log.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Log { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateOrderStatusCommand
    {
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OrderStatus Status { get; set; }

        [Newtonsoft.Json.JsonProperty("statusDetails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusDetails { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateOrderTemplateCommand
    {
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category { get; set; }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        [Newtonsoft.Json.JsonProperty("icon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Icon { get; set; }

        [Newtonsoft.Json.JsonProperty("color", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Color { get; set; }

        [Newtonsoft.Json.JsonProperty("isHidden", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsHidden { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateTransportationRequestItemIdentifierCommand
    {
        [Newtonsoft.Json.JsonProperty("itemIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemIdentifier { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateTransportationRequestItemMetadataCommand
    {
        [Newtonsoft.Json.JsonProperty("itemMetadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemMetadata { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateTransportationRequestStatusCommand
    {
        /// <summary>
        /// Enum TransportationRequestStatus.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TransportationRequestStatus Status { get; set; }

        [Newtonsoft.Json.JsonProperty("statusDetails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusDetails { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateTransportationRequestVehicleIdentifierCommand
    {
        [Newtonsoft.Json.JsonProperty("vehicleIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VehicleIdentifier { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateWebhookCommand
    {
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        [Newtonsoft.Json.JsonProperty("hexSecret", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HexSecret { get; set; }

        [Newtonsoft.Json.JsonProperty("eventTypeFilterRegex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EventTypeFilterRegex { get; set; }

        [Newtonsoft.Json.JsonProperty("isEnabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsEnabled { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateWorkflowGlobalVariableValueCommand
    {
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateWorkflowLocalVariableValueCommand
    {
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateWorkflowProcessCommand
    {
        [Newtonsoft.Json.JsonProperty("isPaused", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsPaused { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class VehicleBatchAssignedOnly
    {
        [Newtonsoft.Json.JsonProperty("vehicleBatchAssigned", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool VehicleBatchAssigned { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Volume
    {
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Amount { get; set; }

        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public VolumeUnit Unit { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum VolumeUnit
    {

        [System.Runtime.Serialization.EnumMember(Value = @"L")]
        L = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"mL")]
        ML = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"uL")]
        UL = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"nL")]
        NL = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"pL")]
        PL = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"fL")]
        FL = 5,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Webhook
    {
        [Newtonsoft.Json.JsonProperty("webhookId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WebhookId { get; set; }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        [Newtonsoft.Json.JsonProperty("hexSecret", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HexSecret { get; set; }

        [Newtonsoft.Json.JsonProperty("eventTypeFilterRegex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EventTypeFilterRegex { get; set; }

        [Newtonsoft.Json.JsonProperty("isEnabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsEnabled { get; set; }

        [Newtonsoft.Json.JsonProperty("isProcessing", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsProcessing { get; set; }

        [Newtonsoft.Json.JsonProperty("runAfterDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset RunAfterDateUtc { get; set; }

        [Newtonsoft.Json.JsonProperty("lastSentEventId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastSentEventId { get; set; }

        [Newtonsoft.Json.JsonProperty("modifiedDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ModifiedDateUtc { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WebhookIdOnly
    {
        [Newtonsoft.Json.JsonProperty("webhookId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WebhookId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Weight
    {
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Value { get; set; }

        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WeightUnit Unit { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WeightEvent
    {
        [Newtonsoft.Json.JsonProperty("weightEventId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WeightEventId { get; set; }

        [Newtonsoft.Json.JsonProperty("eventId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EventId { get; set; }

        [Newtonsoft.Json.JsonProperty("containerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContainerId { get; set; }

        [Newtonsoft.Json.JsonProperty("balanceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BalanceId { get; set; }

        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserId { get; set; }

        [Newtonsoft.Json.JsonProperty("capped", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Capped { get; set; }

        [Newtonsoft.Json.JsonProperty("measurementType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WeightMeasurementType MeasurementType { get; set; }

        [Newtonsoft.Json.JsonProperty("weightInGrams", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public decimal WeightInGrams { get; set; }

        [Newtonsoft.Json.JsonProperty("timeStampUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset TimeStampUtc { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum WeightMeasurementType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Gross")]
        Gross = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Tare")]
        Tare = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum WeightUnit
    {

        [System.Runtime.Serialization.EnumMember(Value = @"ug")]
        Ug = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"mg")]
        Mg = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"g")]
        G = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Kg")]
        Kg = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Workcell
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("typeIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("properties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> Properties { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [inherit properties].
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inheritProperties", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool InheritProperties { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is an instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isInstance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsInstance { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkcellOperationEvent
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long Id { get; set; }

        [Newtonsoft.Json.JsonProperty("workcellId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkcellId { get; set; }

        [Newtonsoft.Json.JsonProperty("workcellName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkcellName { get; set; }

        [Newtonsoft.Json.JsonProperty("workcellProcess", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkcellProcess { get; set; }

        [Newtonsoft.Json.JsonProperty("orderId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserId { get; set; }

        [Newtonsoft.Json.JsonProperty("userName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserName { get; set; }

        [Newtonsoft.Json.JsonProperty("color", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Color { get; set; }

        [Newtonsoft.Json.JsonProperty("imageUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("numberPlatesProcessed", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberPlatesProcessed { get; set; }

        [Newtonsoft.Json.JsonProperty("statusDetail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusDetail { get; set; }

        [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Errors { get; set; }

        [Newtonsoft.Json.JsonProperty("cancelled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Cancelled { get; set; }

        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset Start { get; set; }

        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset End { get; set; }

        [Newtonsoft.Json.JsonProperty("pausedDuration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.TimeSpan PausedDuration { get; set; }

        [Newtonsoft.Json.JsonProperty("inputParameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> InputParameters { get; set; }

        [Newtonsoft.Json.JsonProperty("outputParameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> OutputParameters { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkflowNodeExecutionState
    {
        [Newtonsoft.Json.JsonProperty("orderIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowElementGuid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkflowElementGuid { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("localVariables", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> LocalVariables { get; set; }

        [Newtonsoft.Json.JsonProperty("globalVariables", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> GlobalVariables { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkflowProcess
    {
        [Newtonsoft.Json.JsonProperty("workflowProcessId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WorkflowProcessId { get; set; }

        [Newtonsoft.Json.JsonProperty("orderIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("isPaused", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsPaused { get; set; }

        [Newtonsoft.Json.JsonProperty("globalVariables", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> GlobalVariables { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkflowProcessPaused
    {
        [Newtonsoft.Json.JsonProperty("workflowProgramId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? WorkflowProgramId { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowProcessId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WorkflowProcessId { get; set; }

        [Newtonsoft.Json.JsonProperty("orderIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("templateName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        [Newtonsoft.Json.JsonProperty("modifiedDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ModifiedDateUtc { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkflowProcessPausedPage
    {
        [Newtonsoft.Json.JsonProperty("rows", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<WorkflowProcessPaused> Rows { get; set; }

        [Newtonsoft.Json.JsonProperty("totalCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkflowServiceSwitch
    {
        [Newtonsoft.Json.JsonProperty("isOn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsOn { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkflowStackElement
    {
        [Newtonsoft.Json.JsonProperty("workflowStackElementId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WorkflowStackElementId { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowThreadId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WorkflowThreadId { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowElementGuid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkflowElementGuid { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowElementName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkflowElementName { get; set; }

        [Newtonsoft.Json.JsonProperty("isPopped", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsPopped { get; set; }

        [Newtonsoft.Json.JsonProperty("poppedDateUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PoppedDateUtc { get; set; }

        [Newtonsoft.Json.JsonProperty("localVariables", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> LocalVariables { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkflowThread
    {
        [Newtonsoft.Json.JsonProperty("workflowThreadId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WorkflowThreadId { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowProcessId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WorkflowProcessId { get; set; }

        [Newtonsoft.Json.JsonProperty("statusCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WorkflowThreadStatusCodes StatusCode { get; set; }

        [Newtonsoft.Json.JsonProperty("nextRunDateUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? NextRunDateUtc { get; set; }

        [Newtonsoft.Json.JsonProperty("modifiedDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ModifiedDateUtc { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkflowThreadError
    {
        [Newtonsoft.Json.JsonProperty("workflowThreadId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WorkflowThreadId { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowProcessId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WorkflowProcessId { get; set; }

        [Newtonsoft.Json.JsonProperty("orderIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowStackElementId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WorkflowStackElementId { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowElementGuid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkflowElementGuid { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowElementName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkflowElementName { get; set; }

        [Newtonsoft.Json.JsonProperty("localVariables", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> LocalVariables { get; set; }

        [Newtonsoft.Json.JsonProperty("globalVariables", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Parameter> GlobalVariables { get; set; }

        [Newtonsoft.Json.JsonProperty("exception", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Exception { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkflowThreadHealth
    {
        [Newtonsoft.Json.JsonProperty("workflowThreadId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WorkflowThreadId { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowProcessId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WorkflowProcessId { get; set; }

        [Newtonsoft.Json.JsonProperty("orderIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderIdentifier { get; set; }

        [Newtonsoft.Json.JsonProperty("templateName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        [Newtonsoft.Json.JsonProperty("statusCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WorkflowThreadStatusCodes StatusCode { get; set; }

        [Newtonsoft.Json.JsonProperty("modifiedDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ModifiedDateUtc { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowStackElementId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WorkflowStackElementId { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowElementGuid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkflowElementGuid { get; set; }

        [Newtonsoft.Json.JsonProperty("workflowElementName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkflowElementName { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkflowThreadHealthPage
    {
        [Newtonsoft.Json.JsonProperty("rows", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<WorkflowThreadHealth> Rows { get; set; }

        [Newtonsoft.Json.JsonProperty("totalCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkflowThreadIdOnly
    {
        [Newtonsoft.Json.JsonProperty("workflowThreadId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int WorkflowThreadId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum WorkflowThreadStatusCodes
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Sleeping")]
        Sleeping = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Running")]
        Running = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Error")]
        Error = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Completed")]
        Completed = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Canceled")]
        Canceled = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FileResponse : System.IDisposable
    {
        private System.IDisposable _client;
        private System.IDisposable _response;

        public int StatusCode { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public System.IO.Stream Stream { get; private set; }

        public bool IsPartial
        {
            get { return StatusCode == 206; }
        }

        public FileResponse(int statusCode, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.IO.Stream stream, System.IDisposable client, System.IDisposable response)
        {
            StatusCode = statusCode;
            Headers = headers;
            Stream = stream;
            _client = client;
            _response = response;
        }

        public void Dispose()
        {
            Stream.Dispose();
            if (_response != null)
                _response.Dispose();
            if (_client != null)
                _client.Dispose();
        }
    }


    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataServicesException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public DataServicesException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataServicesException<TResult> : DataServicesException
    {
        public TResult Result { get; private set; }

        public DataServicesException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }
}

#pragma warning restore 1591