namespace Algorithm.DataStructure
{
    public class PriorityQueue<TElement>
    {
        private readonly List<(TElement value, int priority)> _heap;

        private int _size;

        public PriorityQueue()
        {
            _heap = new List<(TElement, int)>();
            _size = 0;
        }

        public void Enqueue(TElement value, int priority)
        {
            _heap.Add((value, priority));
            UpHeap(_size);
            _size++;
        }

        public TElement Dequeue()
        {
            var value = _heap[0].value;
            if (_size > 1)
            {
                _heap[0] = _heap[_size - 1];
                DownHeap(0);
            }
            _heap[_size - 1] = default;
            _size--;

            return value;
        }

        public void UpHeap(int index)
        {
            var target = _heap[index];
            while (true)
            {
                if (index <= 0)
                {
                    break;
                }
                var parentIndex = (index - 1) / 2;
                if (target.priority <= _heap[parentIndex].priority)
                {
                    break;
                }
                _heap[index] = _heap[parentIndex];
                index = parentIndex;
            }
            _heap[index] = target;
        }

        public void DownHeap(int index)
        {
            var target = _heap[index];
            int temp = index;
            while (true)
            {
                var left = temp * 2 + 1;
                var right = temp * 2 + 2;
                int large = 0;
                if (left > _size)
                {
                    break;
                }
                else if (right > _size || _heap[left].priority > _heap[right].priority)
                {
                    large = left;
                }
                else
                {
                    large = right;
                }

                if (_heap[large].priority > target.priority)
                {
                    _heap[temp] = _heap[large];
                    temp = large;
                }
                else
                {
                    break;
                }
            }
            _heap[temp] = target;
        }
    }
}
