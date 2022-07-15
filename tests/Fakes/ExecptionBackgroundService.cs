﻿//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace nanoFramework.Hosting.UnitTests.Fakes
{
    public class ExecptionBackgroundService : BackgroundService
    {
        public override void Start()
        {
            base.Start();

            throw new NotImplementedException();
        }

        protected override void ExecuteAsync()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            base.Stop();

            throw new NotImplementedException();
        }
    }
}
