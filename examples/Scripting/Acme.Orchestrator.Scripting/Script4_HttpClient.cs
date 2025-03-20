using System;
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
            using var httpClient = context.CreateHttpClient();

            httpClient.BaseAddress = new Uri("https://timeapi.io");

            var response = await httpClient.GetFromJsonAsync<Reponse>("/api/Time/current/zone?timeZone=America/Los_Angeles");

            await context.UpdateGlobalVariableAsync("Time", response?.DateTime.ToString("G"));
        }

        public class Reponse
        {
            [JsonPropertyName("dateTime")]
            public DateTime DateTime { get; set; }

            [JsonPropertyName("dayOfWeek")]
            public string? DayOfWeek { get; set; }

            [JsonPropertyName("timeZone")]
            public string? TimeZone { get; set; }
        }
    }
}