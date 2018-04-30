﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.


namespace EnterpriseLibrary.Common.Configuration.Fluent
{
    /// <summary>
    /// Fluent interface that allows tracelisteners to be configured for a Category Source.
    /// </summary>
    public interface ILoggingConfigurationCategoryContd : ILoggingConfigurationContd, IFluentInterface
    {
        /// <summary>
        /// Entry point for attaching Trace Listeners to a Category Source.
        /// </summary>
        ILoggingConfigurationSendTo SendTo { get; }
    }
}