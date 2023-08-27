# Dime.Scheduler CLI

Connect with Dime.Scheduler through the CLI. Version 2.x.x and up targets the cloud version of Dime.Scheduler. v1.x.x will be used for on-premise instances

## Installation

```cmd
dotnet tool install Dime.Scheduler.CLI --global --version 2.0.0-alpha.1
```

## Usage

The following example adds or updates a category in Dime.Scheduler:

```cmd
dimescheduler category add -k "MYAPIKEY" -n 'Service order 123' -h #32a852
```

The entry point of the global tool is the `dimescheduler` command. See the repo's wiki for a list of all commands and their parameters.
To see the parameters of a command, simply run the `dimescheduler` + `verb` + `--help` command and you'll get all the information you need:
