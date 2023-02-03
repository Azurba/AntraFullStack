using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assingment7
{
    public class MyStack<T>
    {
        int top;
        int capacity;
        T[] stack;
        int count;

        public MyStack(int max) {
            capacity = max;
            stack = new T[capacity];
        }

        public int Count() {
            return count;
        }
        public T Pop() {
            T elementRemoved;
            T temp = default(T);
            //check if it is not already empty
            if (!(top <= 0))
            {
                elementRemoved = stack[top];
                top = top - 1;
                return elementRemoved;

            }
            if (count != 0) {
                count--;
            }

            return temp;
        }

        public void Push(T element) {
            //Check if new element is going to overflow
            if (top == capacity - 1)
            {
                Console.WriteLine("Can't add, no space");
            }
            else
            {
                top = top + 1;
                stack[top] = element;
                if (count < capacity)
                {
                    count++;
                }

            }


        }
    }
}
