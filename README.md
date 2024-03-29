<p align="center">
    <img src="assets/connect.svg?raw=true" width=350>
</p>

<p align="center">
<img src="https://img.shields.io/nuget/vpre/Dime.Scheduler.CLI?style=flat-square" />
<img src="https://img.shields.io/azure-devops/build/dimesoftware/Dime%20Software/204?style=flat-square" /> 
<img src="https://img.shields.io/azure-devops/coverage/dimesoftware/Dime%20Software/204">
<a href="https://codeclimate.com/github/dime-scheduler/ds-cli/maintainability"><img src="https://api.codeclimate.com/v1/badges/68140b51ba67c1fbf36e/maintainability" /></a> 
 <a href="https://github.com/dime-scheduler/ds-cli/discussions">
  <img src="https://img.shields.io/badge/chat-discussions-brightgreen?style=flat-square"> <img src="https://img.shields.io/badge/License-MIT-brightgreen.svg?style=flat-square"/> <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square" />
</a>
</p>
<h1 align="center">Dime.Scheduler CLI</h1>

Connect with Dime.Scheduler through the CLI. Check out the [📚 docs](https://docs.dimescheduler.com/develop/cli/intro) for all the information on the CLI.

## Installation

> 🚧 The Dime.Scheduler is currently in preview mode.

To install the CLI, open the command-line in Windows and run the following command:

```cmd
dotnet tool install Dime.Scheduler.CLI --global
```

For more information on the installation, check out the [package on NuGet](https://www.nuget.org/packages/Dime.Scheduler.CLI/).

## Prerequisites

To clone and run this application, you'll need Visual Studio 16.7 or higher. The application is built with C# 10 and targets .NET 6.0.

## Usage

The following example adds or updates a category in Dime.Scheduler:

```cmd
dimescheduler category add -k "MYAPIKEY" -n 'Service order 123' -h #32a852
```

To specify an environment, add `--env` followed by either `Dev`, `Test`, or `Staging`.

The entry point of the global tool is the `dimescheduler` command.

<img src="assets/cmd.png" />

See the [📚 docs](https://docs.dimescheduler.com/develop/cli/intro) for a list of all commands and their parameters.

To see the parameters of a command, simply run the `dimescheduler` + `verb` + `entity` + `--help` command and you'll get all the information you need:

<img src="assets/cmd-command.png" />

## Contributing

We welcome contributions. Please check out the contribution and code of conduct guidelines first.

To contribute:

1. Fork the project
2. Create a feature branch (`git checkout -b feature/mynewfeature`)
3. Commit your changes (`git commit -m 'Add mynewfeature'`)
4. Push to the branch (`git push origin feature/mynewfeature`)
5. Open a pull request
