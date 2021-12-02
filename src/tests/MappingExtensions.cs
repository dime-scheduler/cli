using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    internal static class MappingExtensions
    {
        internal static void AssertEqualProperties(this object source, object target, string[] propertiesToIgnore = null)
        {
            foreach (PropertyInfo? targetProperty in target.GetType().GetProperties())
            {
                if (propertiesToIgnore != null && propertiesToIgnore.Contains(targetProperty.Name))
                    continue;

                PropertyInfo? sourceProperty = source.GetType().GetProperty(targetProperty.Name);
                if (sourceProperty != null)
                    Assert.Equal(targetProperty.GetValue(target), sourceProperty.GetValue(source));
                else
                    throw new MemberAccessException($"Property '{ (object)targetProperty.Name}' not found on source object.");
            }
        }
    }
}