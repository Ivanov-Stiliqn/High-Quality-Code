﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2.Contracts
{
    public interface IPlayer
    {
        string Name { get; set; }

        int Points { get; set; }
    }
}
