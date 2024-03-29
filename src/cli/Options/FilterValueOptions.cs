﻿using CommandLine;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("filtervalue", HelpText = "Add or remove a filter value.")]
    public class FilterValueOptions : BaseOptions, IImportConvertable
    {
        [Option(HelpText = "The filter group name.")]
        public string Group { get; set; }

        [Option(HelpText = "The filter value.")]
        public string Value { get; set; }

        public IImportRequestable ToImport() => (FilterValue)this;

        public static implicit operator FilterValue(FilterValueOptions options)
          => new(options.Group, options.Value);
    }
}