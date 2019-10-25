using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms_and_Structures.SimpleHashMap {
    public class Map<TKey, TValue> {
        public int Count => _items.Count;
        public IReadOnlyList<TKey> Keys => _items.Select(i => i.Key).ToList();
        
        private List<Item<TKey, TValue>> _items = new List<Item<TKey, TValue>>();

        public void Add(Item<TKey, TValue> item) {
            if (item == null) {
                throw new ArgumentNullException(nameof(item));
            }

            if (_items.Any(i => i.Key.Equals(item.Key))) {
                throw new ArgumentException($"dictionary contains item with key {item.Key}", nameof(item));
            }

            _items.Add(item);
        }

        public void Add(TKey key, TValue value) {
            if (key == null) {
                throw new ArgumentNullException(nameof(key));
            }
            
            if (value == null) {
                throw new ArgumentNullException(nameof(value));
            }

            if (_items.Any(i => i.Key.Equals(key))) {
                throw new ArgumentException($"dictionary contains item with key {key}", nameof(key));
            }
            
            _items.Add(new Item<TKey, TValue>(key, value));
        }
    }
}
