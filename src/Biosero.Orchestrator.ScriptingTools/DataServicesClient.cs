﻿#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Biosero.DataServices.Client
{
    public abstract class DataServicesClient
    {
        public abstract Task<EventIdOnly> AddEventAsync(AddEventCommand body, CancellationToken cancellationToken = default);
        public abstract Task AddWorkflowErrorAsync(int workflowStackElementId, AddWorkflowErrorCommand body, CancellationToken cancellationToken = default);
        public abstract Task AddWorkflowGlobalVariableAsync(int workflowProcessId, AddWorkflowGlobalVariableCommand body, CancellationToken cancellationToken = default);
        public abstract Task AddWorkflowLocalVariableAsync(int workflowStackElementId, AddWorkflowLocalVariableCommand body, CancellationToken cancellationToken = default);
        public abstract Task BuildIdentitiesAsync(CancellationToken cancellationToken = default);
        public abstract Task CancelErroredWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract Task CancelWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract Task CompleteWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract Task ContinueErroredWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract Task<string> CreateOrderAsync(CreateOrderCommand body = null, CancellationToken cancellationToken = default);
        public abstract Task<TransportationRequestIdentifierOnly> CreateTransportationRequestAsync(CreateTransportationRequestCommand body, CancellationToken cancellationToken = default);
        public abstract Task<TransportationRequestGroupIdentifierOnly> CreateTransportationRequestGroupAsync(CreateTransportationRequestGroupCommand body, CancellationToken cancellationToken = default);
        public abstract Task<WebhookIdOnly> CreateWebhookAsync(CreateWebhookCommand body, CancellationToken cancellationToken = default);
        public abstract Task CreateWorkflowProcessAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract Task<WorkflowThreadIdOnly> CreateWorkflowThreadAsync(int workflowProcessId, CreateWorkflowThreadCommand body, CancellationToken cancellationToken = default);
        public abstract Task DeleteOrderTemplateAsync(string name, CancellationToken cancellationToken = default);
        public abstract Task DeleteTransformationJobAsync(string name, CancellationToken cancellationToken = default);
        public abstract Task DeleteWebhookAsync(int webhookId, CancellationToken cancellationToken = default);
        public abstract Task DeleteWorkflowGlobalVariableAsync(int workflowProcessId, string name, CancellationToken cancellationToken = default);
        public abstract Task DeleteWorkflowLocalVariableAsync(int workflowStackElementId, string name, CancellationToken cancellationToken = default);
        public abstract Task DisableTransformationJobAsync(string name, CancellationToken cancellationToken = default);
        public abstract Task EnableTransformationJobAsync(string name, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<MaterialInContainerSearchResult>> FindMaterialAsync(string containerId = null, string name = null, string structure = null, string casNumber = null, MaterialState? materialState = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<SampleInContainerSearchResult>> FindSampleAsync(string containerId = null, string name = null, string collectedBy = null, string sampleType = null, DateTimeOffset? collectedBefore = null, DateTimeOffset? collectedAfter = null, MaterialState? materialState = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<WorkflowThread>> GetAliveWorkflowThreadsAsync(IEnumerable<WorkflowThreadStatusCodes> statusCode = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task<AuthenticationTypeOnly> GetAuthenticationTypeAsync(CancellationToken cancellationToken = default);
        public abstract Task<AzureActiveDirectoryConfiguration> GetAzureActiveDirectoryConfigurationAsync(CancellationToken cancellationToken = default);
        public abstract Task<Volume> GetContainerNetVolumeAsync(string containerId, CancellationToken cancellationToken = default);
        public abstract Task<Weight> GetContainerNetWeightFromTransfersAsync(string containerId, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<Order>> GetDescendantOrdersAndSelfAsync(string orderId, bool? workflowsOnly = null, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<EventMessage>> GetEventsAsync(DateTimeOffset? createdFrom = null, DateTimeOffset? createdTo = null, string createdAfterEventId = null, string topic = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task<EventMessagePage> GetEventsPageAsync(DateTimeOffset? createdFrom = null, DateTimeOffset? createdTo = null, string topic = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<string>> GetEventTopicsAsync(DateTimeOffset? createdFrom = null, DateTimeOffset? createdTo = null, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<Order>> GetExecutingOrdersAsync(string sourceIdentifier = null, string assignedTo = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task<FileResponse> GetFileAsync(FileType fileType, string identifier, CancellationToken cancellationToken = default);
        public abstract Task<HostEnvironmentNameOnly> GetHostEnvironmentAsync(CancellationToken cancellationToken = default);
        public abstract Task<ICollection<Identity>> GetIdentitiesAsync(string name = null, string typeIdentifier = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task<Identity> GetIdentityAsync(string identifier, CancellationToken cancellationToken = default);
        public abstract Task<Location> GetIdentityLocationAsync(string identifier, CancellationToken cancellationToken = default);
        public abstract Task GetIdentityLocationPathAsync(string identifier, CancellationToken cancellationToken = default);
        public abstract Task<Identity> GetIdentityOrNullAsync(string identifier, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<InstrumentOperationEvent>> GetInstrumentOperationEventsAsync(string instrumentId, DateTimeOffset? start = null, DateTimeOffset? end = null, int? offset = null, int? limit = null, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<Instrument>> GetInstrumentsAsync(string workcellId, CancellationToken cancellationToken = default);
        public abstract Task<IDictionary<string, ICollection<Parameter>>> GetLatestLocalVariablesPerNodeAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract Task<TransportationRequest> GetNextTransportationRequestOrNullAsync(CancellationToken cancellationToken = default);
        public abstract Task<WorkflowThread> GetNextWorkflowThreadOrNullAsync(CancellationToken cancellationToken = default);
        public abstract Task<Order> GetOrderAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract Task<OrderPage> GetOrderPageAsync(int? limit = null, int? offset = null, string sortColumn = null, PageSortType? sortType = null, IEnumerable<PageFilter> filter = null, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<Order>> GetOrdersAsync(DateTimeOffset? createdOnOrBefore = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task<OrderTemplate> GetOrderTemplateAsync(string name, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<OrderTemplate>> GetOrderTemplatesAsync(bool? excludeHidden = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task<OrderWorkflow> GetOrderWorkflowAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<Identity>> GetTransferStationsAsync(CancellationToken cancellationToken = default);
        public abstract Task<ICollection<TransformationJob>> GetTransformationJobsAsync(CancellationToken cancellationToken = default);
        public abstract Task<TransportationRequest> GetTransportationRequestAsync(string requestIdentifier, CancellationToken cancellationToken = default);
        public abstract Task<TransportationRequestPage> GetTransportationRequestPageAsync(int? limit = null, int? offset = null, string sortColumn = null, PageSortType? sortType = null, IEnumerable<PageFilter> filter = null, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<TransportationRequest>> GetTransportationRequestsAsync(string requestGroupIdentifier = null, IEnumerable<TransportationRequestStatus> status = null, bool? isAssigned = null, bool? isProcessing = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<Order>> GetUnassignedOrdersAsync(string restrictToModuleIds = null, IEnumerable<string> templateName = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task GetVersionAsync(CancellationToken cancellationToken = default);
        public abstract Task<Webhook> GetWebhookAsync(int webhookId, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<Webhook>> GetWebhooksAsync(int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<WeightEvent>> GetWeightEventsAsync(string containerId, WeightMeasurementType? measurementType = null, DateTimeOffset? start = null, DateTimeOffset? end = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task GetWellIdentifierAsync(CancellationToken cancellationToken = default);
        public abstract Task<ICollection<WorkcellOperationEvent>> GetWorkcellOperationEventsAsync(string workcellId, DateTimeOffset? start = null, DateTimeOffset? end = null, int? offset = null, int? limit = null, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<Workcell>> GetWorkcellsAsync(int? offset = null, int? limit = null, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<ModuleStatusUpdateEvent>> GetWorkcellStatusesAsync(CancellationToken cancellationToken = default);
        public abstract Task<ICollection<WorkflowNodeExecutionState>> GetWorkflowExecutionStateAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract Task<WorkflowProcess> GetWorkflowProcessAsync(int workflowProcessId, CancellationToken cancellationToken = default);
        public abstract Task<WorkflowServiceSwitch> GetWorkflowServiceSwitchAsync(CancellationToken cancellationToken = default);
        public abstract Task<WorkflowThread> GetWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract Task<WorkflowThreadError> GetWorkflowThreadErrorAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract Task<WorkflowThreadHealthPage> GetWorkflowThreadHealthPageAsync(int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Task<ICollection<WorkflowThread>> GetWorkflowThreadsAsync(int workflowProcessId, CancellationToken cancellationToken = default);
        public abstract Task<TransportationRequest> PeekNextTransportationRequestOrNullAsync(CancellationToken cancellationToken = default);
        public abstract Task<WorkflowStackElement> PeekWorkflowStackOrNullAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract Task PersistOrderStateAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract Task PingHeartbeatAsync(CancellationToken cancellationToken = default);
        public abstract Task PopAndPushWorkflowStackAsync(int workflowThreadId, PopAndPushWorkflowStackCommand body, CancellationToken cancellationToken = default);
        public abstract Task PopWorkflowStackAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract Task PushWorkflowStackAsync(int workflowThreadId, PushWorkflowStackCommand body, CancellationToken cancellationToken = default);
        public abstract Task RegisterIdentityAsync(string identifier, RegisterIdentityCommand body, CancellationToken cancellationToken = default);
        public abstract Task RegisterOrderTemplateAsync(OrderTemplate body = null, CancellationToken cancellationToken = default);
        public abstract Task ReleaseTransportationRequestAsync(string requestIdentifier, ReleaseTransportationRequestCommand body, CancellationToken cancellationToken = default);
        public abstract Task RemoveIdentityAsync(string identifier, CancellationToken cancellationToken = default);
        public abstract Task RetryErroredWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract Task SetOrderOutputParameterAsync(string orderId, string name, SetOutputParameterCommand body, CancellationToken cancellationToken = default);
        public abstract Task SkipErroredWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract Task SleepWorkflowThreadAsync(int workflowThreadId, SleepWorkflowThreadCommand body, CancellationToken cancellationToken = default);
        public abstract Task<OrderAssignedOnly> TryAssignOrderAsync(string orderId, TryAssignOrderCommand body, CancellationToken cancellationToken = default);
        public abstract Task<TransportationRequestAssignedOnly> TryAssignTransportationRequestAsync(string requestIdentifier, TryAssignTransportationRequestCommand body, CancellationToken cancellationToken = default);
        public abstract Task UpdateOrderAsync(string orderId, UpdateOrderCommand body = null, CancellationToken cancellationToken = default);
        public abstract Task UpdateOrderStatusAsync(string orderId, UpdateOrderStatusCommand body, CancellationToken cancellationToken = default);
        public abstract Task UpdateOrderTemplateAsync(string name, UpdateOrderTemplateCommand body, CancellationToken cancellationToken = default);
        public abstract Task UpdateTransportationRequestItemIdentifierAsync(string requestIdentifier, UpdateTransportationRequestItemIdentifierCommand body, CancellationToken cancellationToken = default);
        public abstract Task UpdateTransportationRequestItemMetadataAsync(string requestIdentifier, UpdateTransportationRequestItemMetadataCommand body, CancellationToken cancellationToken = default);
        public abstract Task UpdateTransportationRequestStatusAsync(string requestIdentifier, UpdateTransportationRequestStatusCommand body, CancellationToken cancellationToken = default);
        public abstract Task UpdateTransportationRequestVehicleIdentifierAsync(string requestIdentifier, UpdateTransportationRequestVehicleIdentifierCommand body, CancellationToken cancellationToken = default);
        public abstract Task UpdateWebhookAsync(int webhookId, UpdateWebhookCommand body = null, CancellationToken cancellationToken = default);
        public abstract Task UpdateWorkflowGlobalVariableValueAsync(int workflowProcessId, string name, UpdateWorkflowGlobalVariableValueCommand body, CancellationToken cancellationToken = default);
        public abstract Task UpdateWorkflowLocalVariableValueAsync(int workflowStackElementId, string name, UpdateWorkflowLocalVariableValueCommand body, CancellationToken cancellationToken = default);
        public abstract Task UploadTransformationJobAsync(CancellationToken cancellationToken = default);
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member