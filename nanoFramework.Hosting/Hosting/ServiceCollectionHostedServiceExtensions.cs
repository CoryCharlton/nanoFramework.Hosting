﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

using nanoFramework.DependencyInjection;

namespace nanoFramework.Hosting
{
    public static class ServiceCollectionHostedServiceExtensions
    {
        /// <summary>
        /// Add an <see cref="IHostedService"/> registration for the given type.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to register with.</param>
        /// <param name="implementationType">The implementation type of the service.</param>
        /// <returns>The original <see cref="IServiceCollection"/>.</returns>
        public static IServiceCollection AddHostedService(this IServiceCollection services, Type implementationType)
        {
            services.AddSingleton(typeof(IHostedService), implementationType);

            return services;
        }
    }
}