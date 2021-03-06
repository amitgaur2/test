// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Mvc.FunctionalTests
{
    public class VersioningTests : VersioningTestsBase<VersioningWebSite.Startup>
    {
        public VersioningTests(MvcTestFixture<VersioningWebSite.Startup> fixture)
            : base(fixture)
        {
        }
    }
}