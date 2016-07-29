﻿using System.Collections.Generic;

namespace SimplCommerce.Infrastructure
{
    public static class GlobalConfiguration
    {
        static GlobalConfiguration()
        {
            Modules = new List<ModuleInfo>();
        }

        public static IList<ModuleInfo> Modules { get; set; }
    }
}
