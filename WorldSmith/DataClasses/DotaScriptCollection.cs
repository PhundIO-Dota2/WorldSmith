﻿using KVLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSmith.DataClasses
{
    public class DotaScriptCollection <T> : IEnumerable<T> where T : DotaDataObject
    {

        public string ClassName
        {
            get
            {
                return KeyValue.Key;
            }
        }

        public KeyValue KeyValue
        {
            get;
            private set;
        }

        public DotaScriptCollection(KeyValue kv)
        {
            KeyValue = kv;
        }

        public DotaScriptCollection(string Classname)
            : this(new KeyValue(Classname).MakeEmptyParent())
        {

        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            foreach(KeyValue kv in KeyValue.Children)
            {
                T obj = typeof(T).GetConstructor(new Type[] { typeof(KeyValue) }).Invoke(new object[] { kv }) as T;
                yield return obj;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (KeyValue kv in KeyValue.Children)
            {
                T obj = typeof(T).GetConstructor(new Type[] { typeof(KeyValue) }).Invoke(new object[] { kv }) as T;
                yield return obj;
            }
        }
    }
}
