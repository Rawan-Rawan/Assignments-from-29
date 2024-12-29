using System.Collections;
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEngine;
namespace Assignment29
{
    public class CustomObject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public CustomObject(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public override string ToString() => $"Object [ID: {ID}, Name: {Name}]";
        //[Optional]
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is CustomObject)) return false;
            CustomObject other = (CustomObject)obj;
            return this.ID == other.ID && this.Name == other.Name;
        }
        //[Optional]
        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {
            if (ReferenceEquals(obj1, obj2)) return true;
            if (ReferenceEquals(obj1, null) || ReferenceEquals(obj2, null)) return false;
            return obj1.Equals(obj2);
        }

        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            return !(obj1 == obj2);
        }
    }
}