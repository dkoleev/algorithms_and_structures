using System;

namespace Algorithms_and_Structures.SimpleHashMap {
    public class Item<TKey, TValue> {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public Item() { }

        public Item(TKey key, TValue value) {
            if (key == null) {
                throw new ArgumentNullException(nameof(key));
            }

            if (value == null) {
                throw new ArgumentNullException(nameof(value));
            }

            Key = key;
            Value = value;
        }

        public override string ToString() {
            return Value.ToString();
        }
    }
}
