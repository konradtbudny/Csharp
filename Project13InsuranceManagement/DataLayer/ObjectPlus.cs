using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Project13InsuranceManagement.DataLayer
{
    [Serializable]
    public class ObjectPlus
    {
        public static Dictionary<Type, BindingList<object>> Objects { get; private set; } = new Dictionary<Type, BindingList<object>>();
        public static string STORE_PATH => "Objects.bin";

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

        public static void Serialize()
        {
            using (FileStream fs = new FileStream(STORE_PATH, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, Objects);
            }
        }

        public static void Deserialize()
        {
            using (FileStream fs = new FileStream(STORE_PATH, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Objects = formatter.Deserialize(fs) as Dictionary<Type, BindingList<object>>;
            }
        }
    }
}