using System;
using System.Collections.Generic;
using System.Text;

namespace HeapImplementation
{
   public class MaxHeap
    {
        private int[] _elements;
        private int _size;
        private int capacity;
        public MaxHeap()
        {
            capacity = 10;
            _size = 0;
            _elements = new int[capacity];

        }
        public int Count
        {
            get
            {
                return _size;
            }
        }
        public int GetLeftChildIndex(int index)
        {
            return 2 * index + 1;
        }
        public int GetRightChildIndex(int index)
        {
            return 2 * index + 2;
        }
        public int GetParentIndex(int index)
        {
            return (index - 1) / 2;
        }
        public bool HasLeftChild(int index)
        {
            return GetLeftChildIndex(index) > _size ? false : true;
        }
        public bool HasRightChild(int index)
        {
            return GetRightChildIndex(index) > _size ? false : true;
        }
        public bool HasParent(int index)
        {
            return GetParentIndex(index) >= 0 ? true : false;
        }
        public bool IsRoot(int index)
        {
            return index == 0 ? true : false;
        }
        public int GetLeftChild(int index)
        {
            if (!HasLeftChild(index))
            {
                throw new IndexOutOfRangeException();
            }
            return _elements[GetLeftChildIndex(index)];
        }
        public int GetRightChild(int index)
        {
            if (!HasRightChild(index))
            {
                throw new IndexOutOfRangeException();
            }
            return _elements[GetRightChildIndex(index)];
        }
        public int GetParent(int index)
        {
            if (!HasParent(index))
            {
                throw new IndexOutOfRangeException();
            }
            return _elements[GetParentIndex(index)];
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            int temp = _elements[firstIndex];
            _elements[firstIndex] = _elements[secondIndex];
            _elements[secondIndex] = temp;
        }
        public void ensureCapacity()
        {
            if (_size == capacity)
            {
                capacity = capacity << 1;
                Array.Resize(ref _elements, capacity);
            }
        }
        public int Peek()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            return _elements[0];
        }
        public int Pop()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            var result = _elements[0];
            _elements[0] = _elements[Count - 1];
            _size--;
            ReCalculateDown();
            return result;
        }
        public void Add(int element)
        {
            ensureCapacity();
            //Array.Resize(ref _elements, Count*2);
            _size++;
            _elements[_size - 1] = element;

            ReCalculateUp();
        }

        private void ReCalculateDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var biggerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index) > GetLeftChild(index))
                {
                    biggerIndex = GetRightChildIndex(index);
                }

                if (_elements[biggerIndex] < _elements[index])
                {
                    break;
                }

                Swap(biggerIndex, index);
                index = biggerIndex;
            }
        }
       
        private void ReCalculateUp()
        {
            var index = _size - 1;
            while (!IsRoot(index) && _elements[index] > GetParent(index))
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
    }
}
