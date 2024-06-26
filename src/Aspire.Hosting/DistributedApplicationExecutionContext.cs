// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Aspire.Hosting;

/// <summary>
/// Exposes the global contextual information for this invocation of the AppHost.
/// </summary>
/// <param name="operation">The operation being performed in this invocation of the AppHost.</param>
public class DistributedApplicationExecutionContext(DistributedApplicationOperation operation)
{
    /// <summary>
    /// The operation currently being performed by the AppHost.
    /// </summary>
    public DistributedApplicationOperation Operation { get; } = operation;

    private IServiceProvider? _serviceProvider;

    /// <summary>
    /// The <see cref="IServiceProvider"/> for the AppHost.
    /// </summary>
    public IServiceProvider ServiceProvider
    {
        get =>_serviceProvider ?? throw new InvalidOperationException("The ServiceProvider has not been set.");
        internal set => _serviceProvider = value;
    }

    /// <summary>
    /// Returns true if the current operation is publishing.
    /// </summary>
    public bool IsPublishMode => Operation == DistributedApplicationOperation.Publish;

    /// <summary>
    /// Returns true if the current operation is running.
    /// </summary>
    public bool IsRunMode => Operation == DistributedApplicationOperation.Run;
}
