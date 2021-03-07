<p align="center">
    <img src="assets/connect.svg?raw=true" width=350>
</p>

<h1 align="center">Dime.Scheduler .NET Tool</h1>

## Installation

🚧 The .NET Tool is published in Dime.Scheduler's private NuGet feed.

```cmd
dotnet tool install Dime.Scheduler.DotNetTool -g --add-source https://pkgs.dev.azure.com/dimenicsbe/_packaging/Dime.Scheduler/nuget/v3/index.json --version 0.0.1-alpha.1
```

## Prerequisites

To clone and run this application, you'll need Visual Studio 16.7 or higher. The application is built with C# 9 and targets .NET 5.0.

## Usage

The entry point of the global tool is the `dimescheduler` command.

<img src="assets/cmd.png" />

The .NET tool currently supports the following verbs:

| Verb                    |
| ----------------------- |
| addCategory             |
| addLiveResourceLocation |

To see the parameters, simply run the `dimescheduler` + `verb` + `--help` command and you'll get all the information you need:

<img src="assets/cmd-command.png" />


## Contributing

We welcome contributions. Please check out the contribution and code of conduct guidelines first.

To contribute:

1. Fork the project
2. Create a feature branch (`git checkout -b feature/mynewfeature`)
3. Commit your changes (`git commit -m 'Add mynewfeature'`)
4. Push to the branch (`git push origin feature/mynewfeature`)
5. Open a pull request
