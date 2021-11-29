![Dime.Scheduler logo](https://cdn.dimescheduler.com/dime-scheduler/Dime.Scheduler-Black.png)

# Dime.Scheduler .NET Tool

Connect with Dime.Scheduler through a .NET Tool.

## Installation

```cmd
dotnet tool install Dime.Scheduler.CLI --global --version 0.0.1-alpha.4
```

## Prerequisites

To clone and run this application, you'll need Visual Studio 16.7 or higher. The application is built with C# 10 and targets .NET 6.0.

## Usage

The following example adds or updates a category in Dime.Scheduler:

```cmd
dimescheduler addCategory
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
-n Service order status
-h #32a852
```

The entry point of the global tool is the `dimescheduler` command. See the repo's wiki for a list of all commands and their parameters.
To see the parameters of a command, simply run the `dimescheduler` + `verb` + `--help` command and you'll get all the information you need:
