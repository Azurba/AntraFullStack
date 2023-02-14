using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assingment7
{
    class MyList<T>
    {
        private T[] data;
        private int size = 0;
        private int capacity;

        public MyList(int capacity = 5)
        {
            this.capacity = capacity;
            data = new T[capacity];
        }

        public void add(T element)
        {
            if (size == capacity)
            {
                Console.WriteLine("Can't add it");
            }

            data[size] = element;
            size++;
        }

        //same as delete at?
        public T remove(int index)
        {
            T returnedElement = default(T);
            for (int i = index; i < size - 1; i++)
            {
                if (!(data[i].Equals(null))) {
                    data[i] = returnedElement;
                }
                data[i] = data[i + 1];

            }

            data[size - 1] = default(T);
            size--;
            return returnedElement;
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < size; i++)
            {
                T currentValue = data[i];
                if (currentValue.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public void clear() {
            data = new T[capacity];
            size = 0;
        }

        public void insertAt(T element, int index)
        {
            if (size == capacity)
            {
                Console.WriteLine("Can't add it");
            }

            for (int i = size; i > index; i--)
            {
                data[i] = data[i - 1];
            }

            data[index] = element;
            size++;
        }

        public void DeleteAt(int index)
        {
            for (int i = index; i < size - 1; i++)
            {
                data[i] = data[i + 1];
            }

            data[size - 1] = default(T);
            size--;

        }

        public int find(T element) {
            for (int i = 0; i <= capacity; i++)
            {
                data[i].Equals(element);
                return i;
            }
            return -1;

        }
    }
}
