using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    internal static class MappingExtensions
    {
        internal static void AssertEqualProperties(this object source, object target, string[]? propertiesToIgnore = null)
        {
            foreach (PropertyInfo? sourceProperty in source.GetType().GetProperties())
            {
                if (propertiesToIgnore != null && propertiesToIgnore.Contains(sourceProperty.Name))
                    continue;

                PropertyInfo? targetProperty = target.GetType().GetProperty(sourceProperty.Name);
                if (targetProperty != null)
                    Assert.Equal(targetProperty.GetValue(target), sourceProperty.GetValue(source));
            }
        }
    }
}