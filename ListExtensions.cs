using System;
using System.Collections.Generic;

namespace CollectionInsert
{
    public static class ListExtensions
    {
        // Extension method for a list of elements that can be compared.
        public static List<T> MyInsert<T>(this List<T> list, T elem) where T : IComparable<T>
        {
            if (!list.IsSorted())
            {
                throw new ArgumentException("List is not sorted in ascending order.");
            }

            if (list.Count == 0)
            {
                list.Add(elem);
            }
            else
            {
                for (int i = 0; i < list.Count; ++i)
                {
                    if (list[i].CompareTo(elem) >= 0)
                    {
                        list.Insert(i, elem);
                        break;
                    }
                    else if (i == list.Count - 1)
                    {
                       list.Add(elem);
                        break;
                    }
                }
            }

            return list;
            
        }

        public static bool IsSorted<T>(this List<T> list) where T : IComparable<T>
        {
            if (list.Count == 0 || list.Count == 1) return true;
            for (int i = 1; i < list.Count; ++i)
            {
                if (list[i].CompareTo(list[i - 1]) < 0) return false;
            }
            return true;
        }
    }
}