// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.Formatters;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Fluent;
using Microsoft.Practices.EnterpriseLibrary.Common.Properties;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// <see cref="FormatterBuilder"/> extensions to configure <see cref="BinaryLogFormatter"/> instances.
    /// </summary>
    /// <seealso cref="BinaryLogFormatter"/>
    /// <seealso cref="BinaryLogFormatterData"/>
    public static class BinaryFormatterBuilderExtensions
    {
        /// <summary>
        /// Creates the configuration builder for a <see cref="BinaryLogFormatter"/> instance.
        /// </summary>
        /// <param name="builder">Fluent interface extension point.</param>
        /// <param name="formatterName">The name of the <see cref="BinaryLogFormatter"/> instance that will be added to configuration.</param>
        /// <seealso cref="BinaryLogFormatter"/>
        /// <seealso cref="BinaryLogFormatterData"/>
        public static BinaryFormatterBuilder BinaryFormatterNamed(this FormatterBuilder builder, string formatterName)
        {
            if (formatterName == null) 
                throw new ArgumentException(Resources.ExceptionStringNullOrEmpty, "formatterName");

            return new BinaryFormatterBuilder(formatterName);
        }
    }
}
