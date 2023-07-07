# Biosero Orchestrator Dev Tools

Biosero Orchestrator DevTools is a suite of developer tools (packages, examples, etc.) to help you implement and manage your Orchestrator environment.

## Scripting Tools

The Scripting Tools package is designed to improve the developer experience when writing Orchestrator Workflow scripts.  The driving motivation here is **BYOIDE** (Bring Your Own Integrated Development Environment).  All from inside Visual Studio or VS Code, you can code, debug, and test your Orchestrator Workflow scripts.  Then when you are ready, just copy them into the Biosero Designer application.  The Scripting Tools NuGet package will provide you with mock classes that can be used to simulate running a script during an Orchestrator Workflow.

### Getting started

Biosero Orchestrator Scripting Tools is installed via NuGet from Biosero's private GitHub packages feed.  You will need to add this feed as a package source.  Full documentation on how to authenticate to a GitHub feed can be found [here](https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-nuget-registry#authenticating-with-a-personal-access-token).  The easiest way to do this locally on Windows is to find the _C:\Users\YOUR_WINDOWS_USERNAME\AppData\Roaming\NuGet\Nuget.Config_ file, and add the source and credentials there.

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <packageSources>
        <!-- other sources here like nuget.org -->

        <add key="github-biosero" value="https://nuget.pkg.github.com/biosero/index.json" />
    </packageSources>
    <packageSourceCredentials>
        <github-biosero>
            <add key="Username" value="YOUR_GITHUB_USERNAME" />
            <add key="ClearTextPassword" value="YOUR_GITHUB_PERSONAL_ACCESS_TOKEN" />
        </github-biosero>
    </packageSourceCredentials>
</configuration>
```

Once the Biosero GitHub package source is successfully installed, you should be able to add the Scripting Tools package to any .NET project.

```
dotnet add package Biosero.Orchestrator.ScriptingTools
```

### Writing Orchestrator Scripts

Orchestartor Workflow scripts must be contained within a class with a parameterless constructor and a `RunAsync` method matching the below signature.

```csharp
using System;
using System.Threading;
using System.Threading.Tasks;
using Biosero.DataServices.Client;
using Biosero.Orchestrator.WorkflowService;

namespace Acme.Orchestrator.Scripting
{
    public class MyNewScript
    {
        public Task RunAsync(DataServicesClient client, WorkflowContext context, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
```

The `DataServicesClient` class is a strongly typed HTTP client for the Data Services API.  The actual class is auto generated from our Open API (Swagger) documentation.  A mock version of the class exists in the Scripting Tools package.  The mock version is an abstract class with all abstract methods that mirror the signatures of the actual version.  This allows a matching contract while easily enabling the mocking of the abstract methods with unit testing tools like [Moq](https://github.com/moq/moq).

```csharp
var client = new Mock<DataServicesClient>().Object;
```

The `WorkflowContext` class provides access to reading and writing global variables associated with the running workflow.  The mock version provided by the Scripting Tools package is backed by a simple `Parameter` collection.  This makes it easy to arrange and assert against it in unit tests.

```csharp
var context = new WorkflowContext(
    new Parameter
    {
        Name = "StringVariableName",
        ValueType = ParameterValueType.String,
        Value = "A string value"
    },
    new Parameter
    {
        Name = "IntegerVariableName",
        ValueType = ParameterValueType.Integer,
        Value = "1"
    },
    new Parameter
    {
        Name = "DoubleVariableName",
        ValueType = ParameterValueType.Double,
        Value = "0.5"
    },
    new Parameter
    {
        Name = "BooleanVariableName",
        ValueType = ParameterValueType.Boolean,
        Value = "true"
    });
```

### Testing Orchestrator Scripts

The Scripting Tools package provides a `ScriptHelper` to simulate how the Orchestrator Workflow Engine would compile and run your script.  The `Compile` and `RunAsync` methods could help with writing unit tests against your scripts.

```csharp
[TestMethod]
public void Compile_As_Script()
{
    var scriptText = File.ReadAllText("Script1_DoesNothing.cs");

    ScriptHelper.Compile(scriptText);
}

[TestMethod]
public async Task Execute_As_Script()
{
    var scriptText = File.ReadAllText("Script1_DoesNothing.cs");
    var client = new Mock<DataServicesClient>().Object;
    var context = new WorkflowContext();

    await ScriptHelper.RunAsync(scriptText, client, context);
}
```

If you are interested in further recommendations on how to organization your scripting solution, checkout our _examples/Scripting/_ directory in the repository.