﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SharedSettings.Policies
{
    public class CoreApiAuthorizationPolicy
    {
        public const string PolicyName = "Admin";
        public const string ClaimName = "name";
        public const string ClaimValue = "admin";
    }
}
