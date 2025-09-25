// Copyright 2023 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using Nuke.Common.Execution;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.CI.BuildServerConfigurationGeneration;

namespace Nuke.Common.CI;

public class GenerateBuildServerConfigurationsAttribute
    : BuildServerConfigurationGenerationAttributeBase, IOnBuildCreated
{
    public void OnBuildCreated(IReadOnlyCollection<ExecutableTarget> executableTargets)
    {
        var configurationArgument = ParameterService.GetParameter<string>(ConfigurationParameterName);

        if (configurationArgument != null)
        {
            var configurationSplit = configurationArgument.Split(',');

            foreach (var configurationId in configurationSplit)
            {
                var trimmedConfigurationId = configurationId.Trim();
                if (string.IsNullOrEmpty(trimmedConfigurationId))
                    continue;

                Assert.NotNull(Build.RootDirectory);

                var generator = GetGenerators(Build)
                    .Where(x => x.Id == trimmedConfigurationId)
                    .SingleOrDefaultOrError($"Found multiple {nameof(IConfigurationGenerator)} with same ID '{configurationId}'.")
                    .NotNull("generator != null");

                generator.Generate(executableTargets);
            }
        }

        Environment.Exit(0);
    }
}
