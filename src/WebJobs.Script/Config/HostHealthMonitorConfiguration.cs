// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;

namespace Microsoft.Azure.WebJobs.Script
{
    public class HostHealthMonitorConfiguration
    {
        public HostHealthMonitorConfiguration()
        {
            Enabled = true;

            // these default numbers translate to a 50% health rating
            // over the window.
            HealthCheckInterval = TimeSpan.FromSeconds(15);
            UnhealthyAlertWindow = TimeSpan.FromMinutes(15);
            UnhealthyAlertThreshold = 30;
        }

        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the interval at which host health will be checked
        /// for threshold overages.
        /// </summary>
        public TimeSpan HealthCheckInterval { get; set; }

        /// <summary>
        /// Gets or sets a value defining the sliding time window
        /// that <see cref="UnhealthyAlertThreshold"/> applies to.
        /// </summary>
        public TimeSpan UnhealthyAlertWindow { get; set; }

        /// <summary>
        /// Gets or sets the threshold for the <see cref="UnhealthyAlertWindow"/>.
        /// When the host has been unhealthy a number of times exceeding this
        /// threshold, the host app domain will be recycled in an attempt to recover.
        /// </summary>
        public int UnhealthyAlertThreshold { get; set; }
    }
}
