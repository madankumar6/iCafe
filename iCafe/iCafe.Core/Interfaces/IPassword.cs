﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCafe.Core.Interfaces
{
    public interface IPassword
    {
        string CreateHashingPasssword(string password);
    }
}
