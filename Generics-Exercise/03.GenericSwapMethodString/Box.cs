﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
    {
    public class Box<T>
        {
        private List<T> items;

        public Box()
            {
           items= new List<T>();
            }

        public void Add(T item)
            {
            items.Add(item);
            }
        public void Replace(int replace, int with)
            {
            T item = items[replace];
            items[replace] = items[with];
            items[with] = item;
            }
        public override string ToString()
            {
            StringBuilder sb = new StringBuilder();
            foreach (T item in items)
                {
                sb.AppendLine($"{typeof(T)}: {item} ");
                }
            return sb.ToString().TrimEnd();
            }
        }
    }