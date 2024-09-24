using Microsoft.SemanticKernel;

var builder = Kernel.CreateBuilder();


// your deployment name from earlier step 
// your API key and endpoint under Resource Management in Azure portal
builder.AddAzureOpenAIChatCompletion(
    "your-deployment-name",
    "your-endpoint",
    "your-api-key");

var kernel = builder.Build();

var result = await kernel.InvokePromptAsync(
        "What are autonomous cars?");
    Console.WriteLine(result);