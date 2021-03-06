// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.Formatters;
using Microsoft.Practices.EnterpriseLibrary.Logging.Properties;

namespace Microsoft.Practices.EnterpriseLibrary.Logging.Configuration
{
    /// <summary>
    /// Represents the configuration settings for a log formatter.  This class is abstract.
    /// </summary>
    public class FormatterData : NameTypeConfigurationElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatterData"/> class.
        /// </summary>
        public FormatterData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatterData"/> class with a name and a formatter type.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="formatterType">The <see cref="Microsoft.Practices.EnterpriseLibrary.Logging.Formatters.ILogFormatter"/> type.</param>
        public FormatterData(string name, Type formatterType)
            : base(name, formatterType)
        {
        }

        /// <summary>
        /// Builds the <see cref="ILogFormatter" /> object represented by this configuration object.
        /// </summary>
        /// <returns>
        /// A formatter.
        /// </returns>
        public virtual ILogFormatter BuildFormatter()
        {
            throw new NotImplementedException(Resources.ExceptionMethodMustBeImplementedBySubclasses);
        }
    }
}
