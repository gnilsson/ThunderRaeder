﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ThunderRaeder.Shared.ServerApiContracts
{
    public interface IOrderable
    {
        string OrderBy { get; set; }
    }
}
