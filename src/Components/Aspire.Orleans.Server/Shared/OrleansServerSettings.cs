// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.Configuration;

namespace Aspire.Orleans.Server;

internal sealed class OrleansServerSettings
{
    /// <summary>
    /// Gets the cluster membership settings.
    /// </summary>
    public IConfigurationSection? Clustering { get; set; }

    public IConfigurationSection? Reminders { get; set; }

    public Dictionary<string, IConfigurationSection>? GrainStorage { get; set; }

    public Dictionary<string, IConfigurationSection>? Streaming { get; set; }
}
