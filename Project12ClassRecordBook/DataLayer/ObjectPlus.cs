using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Project12ClassRecordBook.DataLayer
{
    public class ObjectPlus
    {
        public static Dictionary<Type, BindingList<object>> Objects { get; private set; } = new Dictionary<Type, BindingList<object>>();
        public ObjectPlus()
        {
            AddObject();
        }
        public void AddObject()
        {
            if (!Objects.ContainsKey(GetType()))
            {
                Objects[GetType()] = new BindingList<object>();
            }
            Objects[GetType()].Add(this);
        }
    }
}
