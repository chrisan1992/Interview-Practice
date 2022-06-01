using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Practice
{
    public class MultiMap
    {
        /// <summary>
        /// Dictionary property
        /// </summary>
        private Dictionary<string, List<string>> _multiMap;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MultiMap()
        {
            //initialize the multimap
            this._multiMap = new Dictionary<string, List<string>>();
        }

        /// <summary>
        /// Adds a new value to the multimap
        /// If the key is not there, it creates a new entry
        /// </summary>
        /// <param name="key">key to add</param>
        /// <param name="value">value to add</param>
        public void Add(string key, string value)
        {
            if (this._multiMap.ContainsKey(key))
            {
                //we already have this key in the multimap, add a new value into the list on [key]
                this._multiMap[key].Add(value);
            }
            else
            {
                //the key is still not on the MultiMap
                List<string> list = new List<string>();
                list.Add(value);
                this._multiMap.Add(key, list);
            }
        }

        /// <summary>
        /// Prints the multiMap
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            String result = "";//resulting string
            foreach (KeyValuePair<string, List<string>> kv in this._multiMap)
            {//iterate on all entries
                result += kv.Key + " { ";
                foreach (string val in kv.Value)
                {
                    result += val + " ";
                }
                result += "}\n";
            }
            return result;
        }

        /// <summary>
        /// Returns a list with all the keys in the multiMap
        /// </summary>
        /// <returns></returns>
        public List<string> GetKeys()
        {
            List<string> result = new List<string>();//the resulting list
            foreach (KeyValuePair<string, List<string>> kv in this._multiMap)
            {//iterates on the entries to retrieve the keys
                result.Add(kv.Key);
            }
            return result;
        }

        /// <summary>
        /// Removes an entry from the multimap
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            this._multiMap.Remove(key);
        }
    }
}