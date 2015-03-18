﻿using System;
using System.Collections.Generic;

namespace LFNet.SSO
{
    public class PagedResult<TData>
    {
        public PagedResult()
        {
            
        }

        public IList<TData> Data { get; private set; }

        public long RecordNum { get; set; }
    }
}