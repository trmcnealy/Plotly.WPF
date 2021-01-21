using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Plotly
{
    public class ObservableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, INotifyCollectionChanged, INotifyPropertyChanged
        where TKey : notnull
    {
        // Licensed to the .NET Foundation under one or more agreements.
        // The .NET Foundation licenses this file to you under the MIT license.
        // See the LICENSE file in the project root for more information.

        #region Private Fields

        /// <summary>
        ///     The internal data structure.
        /// </summary>
        private readonly Dictionary<TKey, TValue> _nameValues;

        #endregion Private Fields

        #region Constructors

        /// <summary>
        ///     Creates a ContentLocatorPart with the specified type name and namespace.
        /// </summary>
        public ObservableDictionary()
        {
            _nameValues = new Dictionary<TKey, TValue>();
        }

        #endregion Constructors
        
        #region Public Events

        /// <summary>
        ///
        /// </summary>
        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion Public Events
        
        #region Private Methods

        /// <summary>
        ///     Notify the owner this ContentLocatorPart has changed.
        /// </summary>
        private void FireDictionaryChanged(NotifyCollectionChangedAction action, object? changedItem)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(action, changedItem));
        }

        #endregion Private Methods

        #region Public Methods

        /// <summary>
        ///     Adds a key/value pair to the ContentLocatorPart.  If a value for the key already
        ///     exists, the old value is overwritten by the new value.
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="val">value</param>
        /// <exception cref="ArgumentNullException">key or val is null</exception>
        /// <exception cref="ArgumentException">a value for key is already present in the locator part</exception>
        public void Add(TKey   key,
                        TValue val)
        {
            if(val == null)
            {
                throw new ArgumentNullException(nameof(val));
            }

            _nameValues.Add(key, val);
            FireDictionaryChanged(NotifyCollectionChangedAction.Add, this);
        }

        /// <summary>
        ///     Removes all name/value pairs from the ContentLocatorPart.
        /// </summary>
        public void Clear()
        {
            int count = _nameValues.Count;

            if(count > 0)
            {
                _nameValues.Clear();

                // Only fire changed event if the dictionary actually changed
                FireDictionaryChanged(NotifyCollectionChangedAction.Reset, this);
            }
        }

        /// <summary>
        ///     Returns whether or not a value of the key exists in this ContentLocatorPart.
        /// </summary>
        /// <param name="key">the key to check for</param>
        /// <returns>true - yes, false - no</returns>
        public bool ContainsKey(TKey key)
        {
            return _nameValues.ContainsKey(key);
        }

        /// <summary>
        ///     Removes the key and its value from the ContentLocatorPart.
        /// </summary>
        /// <param name="key">key to be removed</param>
        /// <returns>true - the key was found in the ContentLocatorPart, false o- it wasn't</returns>
        public bool Remove(TKey key)
        {
            bool exists = _nameValues.Remove(key);

            // Only fire changed event if the key was actually removed
            if(exists)
            {
                FireDictionaryChanged(NotifyCollectionChangedAction.Remove, this);
            }

            return exists;
        }

        /// <summary>
        ///     Returns an enumerator for the key/value pairs in this ContentLocatorPart.
        /// </summary>
        /// <returns>an enumerator for the key/value pairs; never returns null</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _nameValues.GetEnumerator();
        }

        /// <summary>
        ///     Returns an enumerator forthe key/value pairs in this ContentLocatorPart.
        /// </summary>
        /// <returns>an enumerator for the key/value pairs; never returns null</returns>
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<TKey, TValue>>)_nameValues).GetEnumerator();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">key is null</exception>
        public bool TryGetValue(TKey       key,
                                out TValue value)
        {
            if(key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            return _nameValues.TryGetValue(key, out value);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pair"></param>
        /// <exception cref="ArgumentNullException">pair is null</exception>
        void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> pair)
        {
            ((ICollection<KeyValuePair<TKey, TValue>>)_nameValues).Add(pair);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pair"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">pair is null</exception>
        bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> pair)
        {
            return ((ICollection<KeyValuePair<TKey, TValue>>)_nameValues).Contains(pair);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pair"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">pair is null</exception>
        bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> pair)
        {
            return ((ICollection<KeyValuePair<TKey, TValue>>)_nameValues).Remove(pair);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="target"></param>
        /// <param name="startIndex"></param>
        /// <exception cref="ArgumentNullException">target is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">startIndex is less than zero or greater than the lenght of target</exception>
        void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] target,
                                                            int                          startIndex)
        {
            if(target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            if(startIndex < 0 || startIndex > target.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            ((ICollection<KeyValuePair<TKey, TValue>>)_nameValues).CopyTo(target, startIndex);
        }

        #endregion Public Methods
        
        #region Public Properties

        /// <summary>
        ///     The number of name/value pairs in this ContentLocatorPart.
        /// </summary>
        /// <value>count of name/value pairs</value>
        public int Count
        {
            get { return _nameValues.Count; }
        }

        /// <summary>
        ///     Indexer provides lookup of values by key.  Gets or sets the value
        ///     in the ContentLocatorPart for the specified key.  If the key does not exist
        ///     in the ContentLocatorPart,
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>the value stored in this locator part for key</returns>
        public TValue this[TKey key]
        {
            get
            {
                if(key == null)
                {
                    throw new ArgumentNullException(nameof(key));
                }

                _nameValues.TryGetValue(key, out TValue value);

                return value;
            }
            set
            {
                if(key == null)
                {
                    throw new ArgumentNullException(nameof(key));
                }

                if(value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                
                _nameValues.TryGetValue(key, out TValue oldValue);

                // If the new value is actually different, then we add it and fire
                // a change notification
                if(oldValue == null || !oldValue.Equals(value))
                {
                    _nameValues[key] = value;
                    FireDictionaryChanged(NotifyCollectionChangedAction.Replace, this);
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsReadOnly
        {
            get { return false; }
        }

        /// <summary>
        ///     Returns a collection of all the keys in this ContentLocatorPart.
        /// </summary>
        /// <value>keys</value>
        public ICollection<TKey> Keys
        {
            get { return _nameValues.Keys; }
        }

        /// <summary>
        ///     Returns a collection of all the values in this ContentLocatorPart.
        /// </summary>
        /// <value>values</value>
        public ICollection<TValue> Values
        {
            get { return _nameValues.Values; }
        }

        #endregion Public Properties

        public Dictionary<TKey, TValue> ToDictionary()
        {
            return _nameValues;
        }
    }
}