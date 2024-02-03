using System;

namespace DefaultNamespace.Service
{
    public class Field<T>
    {
        private T _value;
        public event Action Changed;

        public Field(T initialValue = default)
        {
            _value = initialValue;
        }
    
        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                Changed?.Invoke();
            }
        }
    }
}