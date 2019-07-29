﻿/*
********************************************************************
*
*    曹旭升（sheng.c）
*    E-mail: cao.silhouette@msn.com
*    QQ: 279060597
*    https://github.com/iccb1013
*    http://shengxunwei.com
*
*    © Copyright 2016
*
********************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sheng.SQLite.Plus
{
    public class JustGuidFormStringConvertAttribute : DataHelperConvertAttribute
    {
        public override object CovertTo(object value)
        {
            return value;
        }

        public override object CovertFrom(object value)
        {
            if (value == null)
                return null;

            Guid guid = new Guid();
            Guid.TryParse(value.ToString(), out guid);
            return guid;
        }
    }
}
