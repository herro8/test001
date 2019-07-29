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
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Sheng.SQLite.Plus
{
    public class SqlExpression
    {
        public string Sql
        {
            get;
            set;
        }

        private List<SQLiteParameter> _parameterList = new List<SQLiteParameter>();
        public List<SQLiteParameter> ParameterList
        {
            get { return _parameterList; }
            set { _parameterList = value; }
        }

        public override string ToString()
        {
            string str = String.Empty;
            if (String.IsNullOrEmpty(Sql) == false)
                str += Sql;

            if (_parameterList != null && _parameterList.Count > 0)
            {
                str += Environment.NewLine;
                foreach (var item in _parameterList)
                {
                    if (item.Value == null)
                    {
                        str += item.ParameterName + ":[C# NULL] , ";
                    }
                    else
                    {
                        str += item.ParameterName + ":" + item.Value.ToString() + " , ";
                    }
                }
            }

            return str;
        }
    }
}
