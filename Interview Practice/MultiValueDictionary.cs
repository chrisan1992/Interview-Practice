using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Practice
{
    public class MultiValueDictionary<K, V> : IMultiValueDictionary<K, V>
    {
        //Dictionary definition to store the keys and multiple values
        private Dictionary<K, List<V>> _multiValueDict;

        //default contructor
        public MultiValueDictionary()
        {
            this._multiValueDict = new Dictionary<K, List<V>>();
        }

        //adds a new entry on the multi value dictionary
        public bool Add(K key, V value)
        {
            if (this._multiValueDict.ContainsKey(key))
            {
                //there is already an entry for this key
                /*
                List<V> values = _multiValueDict[key];
                values.Add(value);
                _multiValueDict[key] = values;
                */
                _multiValueDict[key].Add(value);//adds the value on the list for [key]
            }
            else
            {
                //no entry on the Dictionary for this key, need to create a new one

                //create a new list
                List<V> values = new List<V>();
                values.Add(value);//add the new value
                _multiValueDict.Add(key, values);//create the entry on the dictionary
            }

            return true;
        }

        /// Returns a sequence of values for the given key. throws KeyNotFoundException if the key is not present
        public IEnumerable<V> Get(K key)
        {
            if (this._multiValueDict.ContainsKey(key))
            {
                //checks if the key is present
                return this._multiValueDict[key];
            }
            else
            {
                //throws the exception as the key is not on the dictionary
                throw new KeyNotFoundException();
            }
        }

        /// Returns a sequence of values for the given key. returns empty sequence if the key is not present
        public IEnumerable<V> GetOrDefault(K key)
        {
            if (this._multiValueDict.ContainsKey(key))
            {
                //the key is present on the dictionary
                return this._multiValueDict[key];
            }
            else
            {
                //the key is not present, return an empty list
                return new List<V>();
            }
        }


        /// <summary>
        /// Removes the value from the values associated with the given key. throws KeyNotFoundException if the key is not present
        /// </summary>
        /// <param name="key">key which values need to be adjusted</param>
        /// <param name="value">value to remove from the values for the given key</param>
        public void Remove(K key, V value)
        {
            if (this._multiValueDict.ContainsKey(key))
            {
                //the key is present
                List<V> values = this._multiValueDict[key];//retrieve the list
                values.Remove(value);//remove the value form the list
                this._multiValueDict[key] = values;//save the new list
            }
            else
            {
                //the key is not present on the dictionary, throw the exception
                throw new KeyNotFoundException();
            }
        }

        /// <summary>
        /// Removes the given key from the dictionary with all the values associated with it
        /// </summary>
        /// <param name="key">key to remove from the dictionary</param>
        public void Clear(K key)
        {
            //removes the key and the value from the dictionary
            this._multiValueDict.Remove(key);
        }

        public IEnumerable<KeyValuePair<K, V>> Flatten()
        {
            //the list to return
            List<KeyValuePair<K, V>> flattenDict = new List<KeyValuePair<K, V>>();
            foreach (KeyValuePair<K, List<V>> entry in _multiValueDict)
            {//iterate on the multi value dictionary

                foreach (V value in entry.Value)
                {//iterate on the list of values for every key
                    //create a new key value pair
                    KeyValuePair<K, V> pair = new KeyValuePair<K, V>(entry.Key, value);
                    flattenDict.Add(pair);//add the key value pair to the list
                }
            }

            //return the list
            return flattenDict;
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            var flattened = Flatten();

            foreach (var value in flattened)
                yield return value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
