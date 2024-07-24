using System;
using System.Collections.Generic;

namespace Lab1
{
    class Stack<T>
    {
        private LinkedList<T> stack;
        public Stack()
        {
            stack = new LinkedList<T>();
        }
        // добавление элемента в вершину стека(голову)
        public void Push(T item)
        {
            stack.AddLast(item);
        }
        // удаление последнего добавленного элемента из головы стека
        public T Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            T item = stack.Last.Value;
            stack.RemoveLast();
            return item;
        }
        // возвращает первый верхний элемент без его удаления
        public T Peek()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            return stack.Last.Value;
        }
        // чтение элемента по индексу из стека
        public T ElementAt(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException();
            if (IsEmpty())
                return default;
            T item = default(T);
            for (int _ = 0; _ < Length(); _++)
            {
                if (_ == index)
                    item = Peek();
                Push(Pop());
            }

            return item;
        }
        // вставка элемента по индексу
        public void Replace(int index, T item)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException();
            if (index >= Length())
            {
                int length = Length();
                for (int _ = 0; _ < index - length; _++)
                {
                    Push(default(T));
                }

                Push(item);
                return;
            }

            for (int _ = 0; _ < Length(); _++)
            {
                if (_ == index)
                {
                    Pop();
                    Push(item);
                }
                else
                    Push(Pop());
            }
        }

        // поменять местами два элемента стека
        public void SwapElements(int index1, int index2)
        {
            T temp = ElementAt(index1);
            Replace(index1, ElementAt(index2));
            Replace(index2, temp);
        }
        // длина стека
        public int Length()
        {
            return stack.Count;
        }
        // проверить на наличие элементов в стеке
        public bool IsEmpty()
        {
            return Length() == 0;
        }
    }
      

}
