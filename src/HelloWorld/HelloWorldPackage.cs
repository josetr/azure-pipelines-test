// Copyright (c) 2018 Jose Torres. All rights reserved. Licensed under the Apache License, Version 2.0. See LICENSE.md file in the project root for full license information.

namespace VsixTesting.Invoker
{
    using System;
    using Microsoft.VisualStudio;
    using Microsoft.VisualStudio.Shell;

    [PackageRegistration(UseManagedResourcesOnly = true)]
#if DEBUG
    [ProvideAutoLoad(VSConstants.UICONTEXT.SolutionExists_string)]
    [ProvideAutoLoad(VSConstants.UICONTEXT.NoSolution_string)]
#endif
    public sealed class HelloWorldPackage : Package
    {    
#if DEBUG
        protected override void Initialize()
            => base.Initialize();
#endif
    }
}
