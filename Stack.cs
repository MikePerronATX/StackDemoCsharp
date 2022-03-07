namespace Stack
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Null");
            }
            else
            {
                _list.Add(obj);
            }
        }

        public void Display()
        {

            Console.WriteLine("List");
            var li = _list;
            for (int i = 0; i < li.Count; i ++)
            {
                Console.WriteLine("Element: " + li[i]);
            }
           // _list.ForEach(Console.WriteLine);
        }

        public void Pop()
        {
            if(_list.Count == 0)
            {
                throw new InvalidOperationException("None in Stack");
            }
            else
            {
                _list.RemoveAt(_list.Count - 1);
            }
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}