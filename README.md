# My First Semantic Kernel Project (C# / .NET 8)

This project is based on [Microsoft's Semantic Kernel Training Module](https://learn.microsoft.com/en-us/training/modules/build-your-kernel/). The project demonstrates how to use Microsoft's **Semantic Kernel** framework in **C#** with **.NET 8** to integrate and leverage AI capabilities, such as GPT-based models, for various tasks.

## Project Overview

The objective of this project is to:
- Create a Semantic Kernel in **.NET 8**.
- Integrate AI models, such as **OpenAI GPT** or **Azure OpenAI**.
- Build and run AI-driven workflows, including text summarization, question-answering, and custom skills.

## Key Features

- **Text Summarization**: Automatically generate summaries for longer text inputs.
- **Question Answering**: Provide concise answers to user queries based on input text.
- **Skill Integration**: Combine multiple AI skills to form powerful AI workflows.
  
## Prerequisites

Ensure the following are installed before running this project:

- **.NET 8 SDK**: [Download here](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- **Visual Studio 2022** or **Visual Studio Code**
- **Azure OpenAI API key, Endpoint and deployment name**



### Clone the Repository and Build the Project
```bash
git clone https://github.com/nicolasandereson/SKProject.git
cd my-first-semantic-kernel
dotnet restore
dotnet run