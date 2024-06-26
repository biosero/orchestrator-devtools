﻿#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."

namespace Biosero.DataServices.Client
{
    public abstract class DataServicesClient
    {
        public abstract EventIdOnly AddEvent(AddEventCommand body);
        public abstract Task<EventIdOnly> AddEventAsync(AddEventCommand body, CancellationToken cancellationToken = default);
        public abstract WorkflowApprovalIdOnly AddWorkflowApproval(int workflowStackElementId);
        public abstract Task<WorkflowApprovalIdOnly> AddWorkflowApprovalAsync(int workflowStackElementId, CancellationToken cancellationToken = default);
        public abstract void AddWorkflowError(int workflowStackElementId, AddWorkflowErrorCommand body);
        public abstract Task AddWorkflowErrorAsync(int workflowStackElementId, AddWorkflowErrorCommand body, CancellationToken cancellationToken = default);
        public abstract void AddWorkflowGlobalVariable(int workflowProcessId, AddWorkflowGlobalVariableCommand body);
        public abstract Task AddWorkflowGlobalVariableAsync(int workflowProcessId, AddWorkflowGlobalVariableCommand body, CancellationToken cancellationToken = default);
        public abstract void AddWorkflowLocalVariable(int workflowStackElementId, AddWorkflowLocalVariableCommand body);
        public abstract Task AddWorkflowLocalVariableAsync(int workflowStackElementId, AddWorkflowLocalVariableCommand body, CancellationToken cancellationToken = default);
        public abstract void BuildIdentities();
        public abstract Task BuildIdentitiesAsync(CancellationToken cancellationToken = default);
        public abstract void CalculateOrderStatus(string orderId);
        public abstract Task CalculateOrderStatusAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract void CancelErroredWorkflowThread(int workflowThreadId);
        public abstract Task CancelErroredWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract void CancelWorkflowThread(int workflowThreadId);
        public abstract Task CancelWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract void CompleteWorkflowThread(int workflowThreadId);
        public abstract Task CompleteWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract void ContinueErroredWorkflowThread(int workflowThreadId);
        public abstract Task ContinueErroredWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract MobileRobotIdentifierOnly CreateMobileRobotTransport(CreateMobileRobotTransportCommand body);
        public abstract Task<MobileRobotIdentifierOnly> CreateMobileRobotTransportAsync(CreateMobileRobotTransportCommand body, CancellationToken cancellationToken = default);
        public abstract string CreateOrder(CreateOrderCommand body = null);
        public abstract Task<string> CreateOrderAsync(CreateOrderCommand body = null, CancellationToken cancellationToken = default);
        public abstract void CreateOrderFromWebhook(EventMessage body, string x_biosero_event_id = null, string x_biosero_event_type = null, string x_biosero_signature = null, string x_biosero_webhook_id = null, string templateName = null);
        public abstract Task CreateOrderFromWebhookAsync(EventMessage body, string x_biosero_event_id = null, string x_biosero_event_type = null, string x_biosero_signature = null, string x_biosero_webhook_id = null, string templateName = null, CancellationToken cancellationToken = default);
        public abstract TransportationRequestIdentifierOnly CreateTransportationRequest(CreateTransportationRequestCommand body);
        public abstract Task<TransportationRequestIdentifierOnly> CreateTransportationRequestAsync(CreateTransportationRequestCommand body, CancellationToken cancellationToken = default);
        public abstract TransportationRequestGroupIdentifierOnly CreateTransportationRequestGroup(CreateTransportationRequestGroupCommand body);
        public abstract Task<TransportationRequestGroupIdentifierOnly> CreateTransportationRequestGroupAsync(CreateTransportationRequestGroupCommand body, CancellationToken cancellationToken = default);
        public abstract WebhookIdOnly CreateWebhook(CreateWebhookCommand body);
        public abstract Task<WebhookIdOnly> CreateWebhookAsync(CreateWebhookCommand body, CancellationToken cancellationToken = default);
        public abstract void CreateWorkflowProcess(string orderId);
        public abstract Task CreateWorkflowProcessAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract WorkflowThreadIdOnly CreateWorkflowThread(int workflowProcessId, CreateWorkflowThreadCommand body);
        public abstract Task<WorkflowThreadIdOnly> CreateWorkflowThreadAsync(int workflowProcessId, CreateWorkflowThreadCommand body, CancellationToken cancellationToken = default);
        public abstract void DeleteMobileRobotTransport(string mobileRobotIdentifier);
        public abstract Task DeleteMobileRobotTransportAsync(string mobileRobotIdentifier, CancellationToken cancellationToken = default);
        public abstract void DeleteOrderTemplate(string name);
        public abstract Task DeleteOrderTemplateAsync(string name, CancellationToken cancellationToken = default);
        public abstract void DeleteTransformationJob(string name);
        public abstract Task DeleteTransformationJobAsync(string name, CancellationToken cancellationToken = default);
        public abstract void DeleteWebhook(int webhookId);
        public abstract Task DeleteWebhookAsync(int webhookId, CancellationToken cancellationToken = default);
        public abstract void DeleteWorkflowGlobalVariable(int workflowProcessId, string name);
        public abstract Task DeleteWorkflowGlobalVariableAsync(int workflowProcessId, string name, CancellationToken cancellationToken = default);
        public abstract void DeleteWorkflowLocalVariable(int workflowStackElementId, string name);
        public abstract Task DeleteWorkflowLocalVariableAsync(int workflowStackElementId, string name, CancellationToken cancellationToken = default);
        public abstract void DisableTransformationJob(string name);
        public abstract Task DisableTransformationJobAsync(string name, CancellationToken cancellationToken = default);
        public abstract void EnableTransformationJob(string name);
        public abstract Task EnableTransformationJobAsync(string name, CancellationToken cancellationToken = default);
        public abstract ICollection<MaterialInContainerSearchResult> FindMaterial(string containerId = null, string name = null, string structure = null, string casNumber = null, MaterialState? materialState = null, int? limit = null, int? offset = null);
        public abstract Task<ICollection<MaterialInContainerSearchResult>> FindMaterialAsync(string containerId = null, string name = null, string structure = null, string casNumber = null, MaterialState? materialState = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract ICollection<SampleInContainerSearchResult> FindSample(string containerId = null, string name = null, string collectedBy = null, string sampleType = null, DateTimeOffset? collectedBefore = null, DateTimeOffset? collectedAfter = null, MaterialState? materialState = null, int? limit = null, int? offset = null);
        public abstract Task<ICollection<SampleInContainerSearchResult>> FindSampleAsync(string containerId = null, string name = null, string collectedBy = null, string sampleType = null, DateTimeOffset? collectedBefore = null, DateTimeOffset? collectedAfter = null, MaterialState? materialState = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract ICollection<WorkflowThread> GetAliveWorkflowThreads(IEnumerable<WorkflowThreadStatusCodes> statusCode = null, int? limit = null, int? offset = null);
        public abstract Task<ICollection<WorkflowThread>> GetAliveWorkflowThreadsAsync(IEnumerable<WorkflowThreadStatusCodes> statusCode = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract AzureActiveDirectoryConfiguration GetAzureActiveDirectoryConfiguration();
        public abstract Task<AzureActiveDirectoryConfiguration> GetAzureActiveDirectoryConfigurationAsync(CancellationToken cancellationToken = default);
        public abstract CloudServicesConfiguration GetCloudServicesConfiguration();
        public abstract Task<CloudServicesConfiguration> GetCloudServicesConfigurationAsync(CancellationToken cancellationToken = default);
        public abstract Volume GetContainerNetVolume(string containerId);
        public abstract Task<Volume> GetContainerNetVolumeAsync(string containerId, CancellationToken cancellationToken = default);
        public abstract Weight GetContainerNetWeightFromTransfers(string containerId);
        public abstract Task<Weight> GetContainerNetWeightFromTransfersAsync(string containerId, CancellationToken cancellationToken = default);
        public abstract ICollection<Order> GetDescendantOrdersAndSelf(string orderId, bool? workflowsOnly = null);
        public abstract Task<ICollection<Order>> GetDescendantOrdersAndSelfAsync(string orderId, bool? workflowsOnly = null, CancellationToken cancellationToken = default);
        public abstract EventMessage GetEvent(string eventId);
        public abstract Task<EventMessage> GetEventAsync(string eventId, CancellationToken cancellationToken = default);
        public abstract ICollection<EventMessage> GetEvents(DateTimeOffset? createdFrom = null, DateTimeOffset? createdTo = null, string createdAfterEventId = null, string topic = null, int? limit = null, int? offset = null);
        public abstract Task<ICollection<EventMessage>> GetEventsAsync(DateTimeOffset? createdFrom = null, DateTimeOffset? createdTo = null, string createdAfterEventId = null, string topic = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract EventMessagePage GetEventsPage(DateTimeOffset? createdFrom = null, DateTimeOffset? createdTo = null, string topic = null, int? limit = null, int? offset = null);
        public abstract Task<EventMessagePage> GetEventsPageAsync(DateTimeOffset? createdFrom = null, DateTimeOffset? createdTo = null, string topic = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract ICollection<string> GetEventTopics(DateTimeOffset? createdFrom = null, DateTimeOffset? createdTo = null);
        public abstract Task<ICollection<string>> GetEventTopicsAsync(DateTimeOffset? createdFrom = null, DateTimeOffset? createdTo = null, CancellationToken cancellationToken = default);
        public abstract ICollection<Order> GetExecutingOrders(string sourceIdentifier = null, string assignedTo = null, int? limit = null, int? offset = null);
        public abstract Task<ICollection<Order>> GetExecutingOrdersAsync(string sourceIdentifier = null, string assignedTo = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract FileResponse GetFile(FileType fileType, string identifier);
        public abstract Task<FileResponse> GetFileAsync(FileType fileType, string identifier, CancellationToken cancellationToken = default);
        public abstract HostEnvironmentNameOnly GetHostEnvironment();
        public abstract Task<HostEnvironmentNameOnly> GetHostEnvironmentAsync(CancellationToken cancellationToken = default);
        public abstract ICollection<Identity> GetIdentities(string name = null, string typeIdentifier = null, int? limit = null, int? offset = null);
        public abstract Task<ICollection<Identity>> GetIdentitiesAsync(string name = null, string typeIdentifier = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract Identity GetIdentity(string identifier);
        public abstract Task<Identity> GetIdentityAsync(string identifier, CancellationToken cancellationToken = default);
        public abstract Location GetIdentityLocation(string identifier);
        public abstract Task<Location> GetIdentityLocationAsync(string identifier, CancellationToken cancellationToken = default);
        public abstract void GetIdentityLocationPath(string identifier);
        public abstract Task GetIdentityLocationPathAsync(string identifier, CancellationToken cancellationToken = default);
        public abstract ICollection<InstrumentOperationEvent> GetInstrumentOperationEvents(string instrumentId, DateTimeOffset? start = null, DateTimeOffset? end = null, int? offset = null, int? limit = null);
        public abstract Task<ICollection<InstrumentOperationEvent>> GetInstrumentOperationEventsAsync(string instrumentId, DateTimeOffset? start = null, DateTimeOffset? end = null, int? offset = null, int? limit = null, CancellationToken cancellationToken = default);
        public abstract ICollection<Instrument> GetInstruments(string workcellId);
        public abstract Task<ICollection<Instrument>> GetInstrumentsAsync(string workcellId, CancellationToken cancellationToken = default);
        public abstract IDictionary<string, ICollection<Parameter>> GetLatestLocalVariablesPerNode(string orderId);
        public abstract Task<IDictionary<string, ICollection<Parameter>>> GetLatestLocalVariablesPerNodeAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract LicenseConfiguration GetLicenseConfiguration();
        public abstract Task<LicenseConfiguration> GetLicenseConfigurationAsync(CancellationToken cancellationToken = default);
        public abstract LicenseState GetLicenseStatus();
        public abstract Task<LicenseState> GetLicenseStatusAsync(CancellationToken cancellationToken = default);
        public abstract MaintenanceModeSwitch GetMaintenanceModeSwitch();
        public abstract Task<MaintenanceModeSwitch> GetMaintenanceModeSwitchAsync(CancellationToken cancellationToken = default);
        public abstract MobileRobotTransport GetMobileRobotTransport(string mobileRobotIdentifier);
        public abstract Task<MobileRobotTransport> GetMobileRobotTransportAsync(string mobileRobotIdentifier, CancellationToken cancellationToken = default);
        public abstract ICollection<MobileRobotTransport> GetMobileRobotTransports(IEnumerable<MobileRobotTransportStatus> status = null);
        public abstract Task<ICollection<MobileRobotTransport>> GetMobileRobotTransportsAsync(IEnumerable<MobileRobotTransportStatus> status = null, CancellationToken cancellationToken = default);
        public abstract ICollection<MobileRobotTransport> GetNextMobileRobotTransport();
        public abstract Task<ICollection<MobileRobotTransport>> GetNextMobileRobotTransportAsync(CancellationToken cancellationToken = default);
        public abstract ICollection<TransportationRequest> GetNextTransportationRequest();
        public abstract Task<ICollection<TransportationRequest>> GetNextTransportationRequestAsync(CancellationToken cancellationToken = default);
        public abstract ICollection<WorkflowThread> GetNextWorkflowThread();
        public abstract Task<ICollection<WorkflowThread>> GetNextWorkflowThreadAsync(CancellationToken cancellationToken = default);
        public abstract Order GetOrder(string orderId);
        public abstract Task<Order> GetOrderAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract OrderPage GetOrderPage(int? limit = null, int? offset = null, string sortColumn = null, PageSortDirection? sortDirection = null, PageFilter rootFilter = null);
        public abstract Task<OrderPage> GetOrderPageAsync(int? limit = null, int? offset = null, string sortColumn = null, PageSortDirection? sortDirection = null, PageFilter rootFilter = null, CancellationToken cancellationToken = default);
        public abstract ICollection<Order> GetOrders(DateTimeOffset? createdOnOrBefore = null, int? limit = null, int? offset = null);
        public abstract Task<ICollection<Order>> GetOrdersAsync(DateTimeOffset? createdOnOrBefore = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract OrderTemplate GetOrderTemplate(string name);
        public abstract Task<OrderTemplate> GetOrderTemplateAsync(string name, CancellationToken cancellationToken = default);
        public abstract ICollection<OrderTemplate> GetOrderTemplates(bool? excludeHidden = null, int? limit = null, int? offset = null);
        public abstract Task<ICollection<OrderTemplate>> GetOrderTemplatesAsync(bool? excludeHidden = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract OrderWorkflow GetOrderWorkflow(string orderId);
        public abstract Task<OrderWorkflow> GetOrderWorkflowAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract ICollection<Identity> GetTransferStations();
        public abstract Task<ICollection<Identity>> GetTransferStationsAsync(CancellationToken cancellationToken = default);
        public abstract ICollection<TransformationJob> GetTransformationJobs();
        public abstract Task<ICollection<TransformationJob>> GetTransformationJobsAsync(CancellationToken cancellationToken = default);
        public abstract TransportationManagerSwitch GetTransportationManagerSwitch();
        public abstract Task<TransportationManagerSwitch> GetTransportationManagerSwitchAsync(CancellationToken cancellationToken = default);
        public abstract TransportationRequest GetTransportationRequest(string requestIdentifier);
        public abstract Task<TransportationRequest> GetTransportationRequestAsync(string requestIdentifier, CancellationToken cancellationToken = default);
        public abstract TransportationRequestPage GetTransportationRequestPage(int? limit = null, int? offset = null, string sortColumn = null, PageSortDirection? sortDirection = null, PageFilter rootFilter = null);
        public abstract Task<TransportationRequestPage> GetTransportationRequestPageAsync(int? limit = null, int? offset = null, string sortColumn = null, PageSortDirection? sortDirection = null, PageFilter rootFilter = null, CancellationToken cancellationToken = default);
        public abstract ICollection<TransportationRequest> GetTransportationRequests(string requestGroupIdentifier = null, IEnumerable<TransportationRequestStatus> status = null, string vehicleIdentifier = null, bool? isAssigned = null, bool? isActive = null, bool? isProcessing = null, int? limit = null, int? offset = null);
        public abstract Task<ICollection<TransportationRequest>> GetTransportationRequestsAsync(string requestGroupIdentifier = null, IEnumerable<TransportationRequestStatus> status = null, string vehicleIdentifier = null, bool? isAssigned = null, bool? isActive = null, bool? isProcessing = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract ICollection<Order> GetUnassignedOrders(string restrictToModuleIds = null, IEnumerable<string> templateName = null, int? limit = null, int? offset = null);
        public abstract Task<ICollection<Order>> GetUnassignedOrdersAsync(string restrictToModuleIds = null, IEnumerable<string> templateName = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract UserActionPage GetUserActionPage(string orderId = null, int? limit = null, int? offset = null, string sortColumn = null, PageSortDirection? sortDirection = null, PageFilter rootFilter = null);
        public abstract Task<UserActionPage> GetUserActionPageAsync(string orderId = null, int? limit = null, int? offset = null, string sortColumn = null, PageSortDirection? sortDirection = null, PageFilter rootFilter = null, CancellationToken cancellationToken = default);
        public abstract ICollection<UserAction> GetUserActions(string orderId = null, DateTimeOffset? createdOnOrBefore = null, int? limit = null, int? offset = null);
        public abstract Task<ICollection<UserAction>> GetUserActionsAsync(string orderId = null, DateTimeOffset? createdOnOrBefore = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract void GetVersion();
        public abstract Task GetVersionAsync(CancellationToken cancellationToken = default);
        public abstract Webhook GetWebhook(int webhookId);
        public abstract Task<Webhook> GetWebhookAsync(int webhookId, CancellationToken cancellationToken = default);
        public abstract ICollection<Webhook> GetWebhooks(int? limit = null, int? offset = null);
        public abstract Task<ICollection<Webhook>> GetWebhooksAsync(int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract ICollection<WeightEvent> GetWeightEvents(string containerId, WeightMeasurementType? measurementType = null, DateTimeOffset? start = null, DateTimeOffset? end = null, int? limit = null, int? offset = null);
        public abstract Task<ICollection<WeightEvent>> GetWeightEventsAsync(string containerId, WeightMeasurementType? measurementType = null, DateTimeOffset? start = null, DateTimeOffset? end = null, int? limit = null, int? offset = null, CancellationToken cancellationToken = default);
        public abstract void GetWellIdentifier();
        public abstract Task GetWellIdentifierAsync(CancellationToken cancellationToken = default);
        public abstract ICollection<WorkcellOperationEvent> GetWorkcellOperationEvents(string workcellId, DateTimeOffset? start = null, DateTimeOffset? end = null, int? offset = null, int? limit = null);
        public abstract Task<ICollection<WorkcellOperationEvent>> GetWorkcellOperationEventsAsync(string workcellId, DateTimeOffset? start = null, DateTimeOffset? end = null, int? offset = null, int? limit = null, CancellationToken cancellationToken = default);
        public abstract ICollection<Workcell> GetWorkcells(int? offset = null, int? limit = null);
        public abstract Task<ICollection<Workcell>> GetWorkcellsAsync(int? offset = null, int? limit = null, CancellationToken cancellationToken = default);
        public abstract ICollection<ModuleStatusUpdateEvent> GetWorkcellStatuses();
        public abstract Task<ICollection<ModuleStatusUpdateEvent>> GetWorkcellStatusesAsync(CancellationToken cancellationToken = default);
        public abstract WorkflowApproval GetWorkflowApproval(int workflowApprovalId);
        public abstract Task<WorkflowApproval> GetWorkflowApprovalAsync(int workflowApprovalId, CancellationToken cancellationToken = default);
        public abstract WorkflowApprovalViewPage GetWorkflowApprovalPage(int? limit = null, int? offset = null, string sortColumn = null, PageSortDirection? sortDirection = null, PageFilter rootFilter = null);
        public abstract Task<WorkflowApprovalViewPage> GetWorkflowApprovalPageAsync(int? limit = null, int? offset = null, string sortColumn = null, PageSortDirection? sortDirection = null, PageFilter rootFilter = null, CancellationToken cancellationToken = default);
        public abstract ICollection<WorkflowNodeExecutionState> GetWorkflowExecutionState(string orderId);
        public abstract Task<ICollection<WorkflowNodeExecutionState>> GetWorkflowExecutionStateAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract WorkflowProcessPausedPage GetWorkflowPausedPage(int? limit = null, int? offset = null, string sortColumn = null, PageSortDirection? sortDirection = null, PageFilter rootFilter = null);
        public abstract Task<WorkflowProcessPausedPage> GetWorkflowPausedPageAsync(int? limit = null, int? offset = null, string sortColumn = null, PageSortDirection? sortDirection = null, PageFilter rootFilter = null, CancellationToken cancellationToken = default);
        public abstract WorkflowProcess GetWorkflowProcess(int workflowProcessId);
        public abstract Task<WorkflowProcess> GetWorkflowProcessAsync(int workflowProcessId, CancellationToken cancellationToken = default);
        public abstract WorkflowProcess GetWorkflowProcessByOrderId(string orderId);
        public abstract Task<WorkflowProcess> GetWorkflowProcessByOrderIdAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract WorkflowServiceSwitch GetWorkflowServiceSwitch();
        public abstract Task<WorkflowServiceSwitch> GetWorkflowServiceSwitchAsync(CancellationToken cancellationToken = default);
        public abstract WorkflowThread GetWorkflowThread(int workflowThreadId);
        public abstract Task<WorkflowThread> GetWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract WorkflowThreadError GetWorkflowThreadError(int workflowThreadId);
        public abstract Task<WorkflowThreadError> GetWorkflowThreadErrorAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract WorkflowThreadHealthPage GetWorkflowThreadHealthPage(int? limit = null, int? offset = null, string sortColumn = null, PageSortDirection? sortDirection = null, PageFilter rootFilter = null);
        public abstract Task<WorkflowThreadHealthPage> GetWorkflowThreadHealthPageAsync(int? limit = null, int? offset = null, string sortColumn = null, PageSortDirection? sortDirection = null, PageFilter rootFilter = null, CancellationToken cancellationToken = default);
        public abstract ICollection<WorkflowThread> GetWorkflowThreads(int workflowProcessId);
        public abstract Task<ICollection<WorkflowThread>> GetWorkflowThreadsAsync(int workflowProcessId, CancellationToken cancellationToken = default);
        public abstract ICollection<MobileRobotTransport> PeekNextMobileRobotTransport();
        public abstract Task<ICollection<MobileRobotTransport>> PeekNextMobileRobotTransportAsync(CancellationToken cancellationToken = default);
        public abstract ICollection<TransportationRequest> PeekNextTransportationRequest();
        public abstract Task<ICollection<TransportationRequest>> PeekNextTransportationRequestAsync(CancellationToken cancellationToken = default);
        public abstract ICollection<WorkflowStackElement> PeekWorkflowStack(int workflowThreadId);
        public abstract Task<ICollection<WorkflowStackElement>> PeekWorkflowStackAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract void PersistOrderState(string orderId);
        public abstract Task PersistOrderStateAsync(string orderId, CancellationToken cancellationToken = default);
        public abstract void PopAndPushWorkflowStack(int workflowThreadId, PopAndPushWorkflowStackCommand body);
        public abstract Task PopAndPushWorkflowStackAsync(int workflowThreadId, PopAndPushWorkflowStackCommand body, CancellationToken cancellationToken = default);
        public abstract void PopWorkflowStack(int workflowThreadId);
        public abstract Task PopWorkflowStackAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract void PushWorkflowStack(int workflowThreadId, PushWorkflowStackCommand body);
        public abstract Task PushWorkflowStackAsync(int workflowThreadId, PushWorkflowStackCommand body, CancellationToken cancellationToken = default);
        public abstract void ReceiveWebhook(EventMessage body, string x_biosero_event_id = null, string x_biosero_event_type = null, string x_biosero_signature = null, string x_biosero_webhook_id = null);
        public abstract Task ReceiveWebhookAsync(EventMessage body, string x_biosero_event_id = null, string x_biosero_event_type = null, string x_biosero_signature = null, string x_biosero_webhook_id = null, CancellationToken cancellationToken = default);
        public abstract void RegisterIdentity(string identifier, RegisterIdentityCommand body);
        public abstract Task RegisterIdentityAsync(string identifier, RegisterIdentityCommand body, CancellationToken cancellationToken = default);
        public abstract void RegisterOrderTemplate(OrderTemplate body = null);
        public abstract Task RegisterOrderTemplateAsync(OrderTemplate body = null, CancellationToken cancellationToken = default);
        public abstract void ReleaseMobileRobotTransport(string mobileRobotIdentifier, ReleaseMobileRobotTransportCommand body);
        public abstract Task ReleaseMobileRobotTransportAsync(string mobileRobotIdentifier, ReleaseMobileRobotTransportCommand body, CancellationToken cancellationToken = default);
        public abstract void ReleaseTransportationRequest(string requestIdentifier, ReleaseTransportationRequestCommand body);
        public abstract Task ReleaseTransportationRequestAsync(string requestIdentifier, ReleaseTransportationRequestCommand body, CancellationToken cancellationToken = default);
        public abstract void RemoveIdentity(string identifier);
        public abstract Task RemoveIdentityAsync(string identifier, CancellationToken cancellationToken = default);
        public abstract void RetryErroredWorkflowThread(int workflowThreadId);
        public abstract Task RetryErroredWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract void SetOrderOutputParameter(string orderId, string name, SetOutputParameterCommand body);
        public abstract Task SetOrderOutputParameterAsync(string orderId, string name, SetOutputParameterCommand body, CancellationToken cancellationToken = default);
        public abstract void SkipErroredWorkflowThread(int workflowThreadId);
        public abstract Task SkipErroredWorkflowThreadAsync(int workflowThreadId, CancellationToken cancellationToken = default);
        public abstract void SleepWorkflowThread(int workflowThreadId, SleepWorkflowThreadCommand body);
        public abstract Task SleepWorkflowThreadAsync(int workflowThreadId, SleepWorkflowThreadCommand body, CancellationToken cancellationToken = default);
        public abstract OrderAssignedOnly TryAssignOrder(string orderId, TryAssignOrderCommand body);
        public abstract Task<OrderAssignedOnly> TryAssignOrderAsync(string orderId, TryAssignOrderCommand body, CancellationToken cancellationToken = default);
        public abstract TransportationRequestAssignedOnly TryAssignTransportationRequest(string requestIdentifier, TryAssignTransportationRequestCommand body);
        public abstract Task<TransportationRequestAssignedOnly> TryAssignTransportationRequestAsync(string requestIdentifier, TryAssignTransportationRequestCommand body, CancellationToken cancellationToken = default);
        public abstract VehicleBatchAssignedOnly TryAssignVehicleBatch(TryAssignVehicleBatchCommand body);
        public abstract Task<VehicleBatchAssignedOnly> TryAssignVehicleBatchAsync(TryAssignVehicleBatchCommand body, CancellationToken cancellationToken = default);
        public abstract void UpdateMobileRobotTransport(string mobileRobotIdentifier, UpdateMobileRobotTransportCommand body);
        public abstract Task UpdateMobileRobotTransportAsync(string mobileRobotIdentifier, UpdateMobileRobotTransportCommand body, CancellationToken cancellationToken = default);
        public abstract void UpdateOrder(string orderId, UpdateOrderCommand body = null);
        public abstract Task UpdateOrderAsync(string orderId, UpdateOrderCommand body = null, CancellationToken cancellationToken = default);
        public abstract void UpdateOrderStatus(string orderId, UpdateOrderStatusCommand body);
        public abstract Task UpdateOrderStatusAsync(string orderId, UpdateOrderStatusCommand body, CancellationToken cancellationToken = default);
        public abstract void UpdateOrderTemplate(string name, UpdateOrderTemplateCommand body);
        public abstract Task UpdateOrderTemplateAsync(string name, UpdateOrderTemplateCommand body, CancellationToken cancellationToken = default);
        public abstract void UpdateTransportationRequestItemIdentifier(string requestIdentifier, UpdateTransportationRequestItemIdentifierCommand body);
        public abstract Task UpdateTransportationRequestItemIdentifierAsync(string requestIdentifier, UpdateTransportationRequestItemIdentifierCommand body, CancellationToken cancellationToken = default);
        public abstract void UpdateTransportationRequestItemMetadata(string requestIdentifier, UpdateTransportationRequestItemMetadataCommand body);
        public abstract Task UpdateTransportationRequestItemMetadataAsync(string requestIdentifier, UpdateTransportationRequestItemMetadataCommand body, CancellationToken cancellationToken = default);
        public abstract void UpdateTransportationRequestStatus(string requestIdentifier, UpdateTransportationRequestStatusCommand body);
        public abstract Task UpdateTransportationRequestStatusAsync(string requestIdentifier, UpdateTransportationRequestStatusCommand body, CancellationToken cancellationToken = default);
        public abstract void UpdateTransportationRequestVehicleIdentifier(string requestIdentifier, UpdateTransportationRequestVehicleIdentifierCommand body);
        public abstract Task UpdateTransportationRequestVehicleIdentifierAsync(string requestIdentifier, UpdateTransportationRequestVehicleIdentifierCommand body, CancellationToken cancellationToken = default);
        public abstract void UpdateWebhook(int webhookId, UpdateWebhookCommand body = null);
        public abstract Task UpdateWebhookAsync(int webhookId, UpdateWebhookCommand body = null, CancellationToken cancellationToken = default);
        public abstract void UpdateWorkflowApproval(int workflowApprovalId, UpdateWorkflowApprovalCommand body);
        public abstract Task UpdateWorkflowApprovalAsync(int workflowApprovalId, UpdateWorkflowApprovalCommand body, CancellationToken cancellationToken = default);
        public abstract void UpdateWorkflowGlobalVariableValue(int workflowProcessId, string name, UpdateWorkflowGlobalVariableValueCommand body);
        public abstract Task UpdateWorkflowGlobalVariableValueAsync(int workflowProcessId, string name, UpdateWorkflowGlobalVariableValueCommand body, CancellationToken cancellationToken = default);
        public abstract void UpdateWorkflowLocalVariableValue(int workflowStackElementId, string name, UpdateWorkflowLocalVariableValueCommand body);
        public abstract Task UpdateWorkflowLocalVariableValueAsync(int workflowStackElementId, string name, UpdateWorkflowLocalVariableValueCommand body, CancellationToken cancellationToken = default);
        public abstract void UpdateWorkflowProcess(int workflowProcessId, UpdateWorkflowProcessCommand body);
        public abstract Task UpdateWorkflowProcessAsync(int workflowProcessId, UpdateWorkflowProcessCommand body, CancellationToken cancellationToken = default);
        public abstract void UploadTransformationJob();
        public abstract Task UploadTransformationJobAsync(CancellationToken cancellationToken = default);
    }
}

#pragma warning restore CS1591