﻿#region import

using System;

#endregion

namespace Plugins.UnityMonstackCore.DependencyInjections
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class InjectAttribute : Attribute
    {
        public bool CreateOnStartup { get; set; }
    }
}