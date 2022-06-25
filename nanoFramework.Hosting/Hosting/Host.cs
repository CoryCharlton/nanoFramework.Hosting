﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace nanoFramework.Hosting
{
    /// <summary>
    /// Provides convenience methods for creating instances of <see cref="IHostBuilder"/> with pre-configured defaults.
    /// </summary>
    public static class Host
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HostBuilder"/> class with pre-configured defaults.
        /// </summary>
        /// <returns>The initialized <see cref="IHostBuilder"/>.</returns>
        public static IHostBuilder CreateDefaultBuilder()
        {
            var builder = new HostBuilder();
            return builder;
        }
    }
}