using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Text;

namespace SetGeneric
{
    class Set<T>  : IEnumerable<T>
    {
        private List<T> _setResult;

        public Set()
        {
             _setResult = new List<T>();
        }

        public Set(params T[] array) : this()
        {
            foreach(var t in array)
            {
                Insert(t);
            }
        }

        public void Intersect(Set<T> otherSet)
        { 
            for(int i = _setResult.Count-1 ; i >= 0; i--)
            {
                if(!otherSet.IsMember(_setResult[i]))
                {
                    Delete(_setResult[i]);
                }
            }
        }

        public void Union(Set<T> otherSet)
        {
            foreach(var member in otherSet)
            {
                Insert(member);
            }
        }

        public bool Subset(Set<T> otherSet)
        {
            foreach(var member in otherSet)
            {
                if(!this.IsMember(member))
                        return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            Set<T> otherSet = obj as Set<T>;
            if (otherSet == null)
                return false;
            if (otherSet._setResult.Count != _setResult.Count) return false;

            foreach(var member in otherSet)
            {
                if (!IsMember(member))
                    return false;
            }
            return true;
        }

        public void Delete(T member)
        {
            if (IsMember(member))
                _setResult.Remove(member);
        }

        public void Insert(T member)
        {
            if (!IsMember(member))
                _setResult.Add(member);
        }

        public bool IsMember(T member)
        {
            return _setResult.Contains(member);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _setResult.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            foreach (var member in _setResult)
            {
                stb.Append($"{member.ToString()},");
            }
            return stb.ToString();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}

