# Dime.Scheduler CLI

Connect with Dime.Scheduler through the CLI..

## Installation

```cmd
dotnet tool install Dime.Scheduler.CLI --global --version 1.0.0-beta.7
```

## Usage

The following example adds or updates a category in Dime.Scheduler:

```cmd
dimescheduler category
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
-n Service order status
-h #32a852
```

The entry point of the global tool is the `dimescheduler` command. See the repo's wiki for a list of all commands and their parameters.
To see the parameters of a command, simply run the `dimescheduler` + `verb` + `--help` command and you'll get all the information you need:
