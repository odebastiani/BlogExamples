using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CollectionInitializers
{
    public class MyCollection : IEnumerable, IEnumerable<string>
    {
        #region fields

        private readonly List<string> _items = new List<string>();

        #endregion

        #region Indexer

        public string? this[int key]
        {
            get
            {
                return _items.FirstOrDefault(x => x.StartsWith($"{key} = "));
            }
            set
            {
                _items.Add($"{key} = {value}");
            }
        }

        public string? this[int key1,  int key2]
        {
            get
            {
                return _items.FirstOrDefault(x => x.StartsWith($"({key1}, {key2}) = "));
            }
            set
            {
                _items.Add($"({key1}, {key2}) = {value}");
            }
        }

        #endregion

        #region Add

        public void Add(string item)
        {
            _items.Add($"'{item}'");
        }

        public void Add(int item)
        {
            _items.Add(item.ToString());
        }

        public void Add(int number1, int number2)
        {
            _items.Add($"{number1} + {number2} = {number1 + number2}");
        }

        public void Add(params string[] items)
        {
            _items.Add("(" + string.Join(", ", items) + ")");
        }

        #endregion

        #region IEnumerable

        public IEnumerator<string> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
