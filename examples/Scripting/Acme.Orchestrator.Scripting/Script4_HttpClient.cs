using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Biosero.DataServices.Client;
using Biosero.Orchestrator.WorkflowService;

namespace Acme.Orchestrator.Scripting
{
    // Scripts require a class with a parameterless constructor and a RunAsync method matching the below signature.
    public class Script4_HttpClient
    {
        public async Task RunAsync(DataServicesClient client, WorkflowContext context, CancellationToken cancellationToken)
        {
            using var httpClient = new HttpClient { BaseAddress = new Uri("http://worldtimeapi.org") };

            var response = await httpClient.GetFromJsonAsync<Reponse>("/api/ip");

            await context.UpdateGlobalVariableAsync("Time", response?.DateTime.ToString("G"));
        }

        public class Reponse
        {
            [JsonPropertyName("datetime")]
            public DateTimeOffset DateTime { get; set; }

            [JsonPropertyName("day_of_week")]
            public DayOfWeek DayOfWeek { get; set; }

            [JsonPropertyName("timezone")]
            public string? Timezone { get; set; }
        }
    }
}