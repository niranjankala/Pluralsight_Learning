using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MVP.SimpleMVPExample.Entities
{
    public interface IModel
    {
        void Set(string value);
        void Reverse(string value);

    }

    public class Model : IModel
    {
        string textValue;
        public event EventHandler<ValueChangeArgs> TextSet;
        public event EventHandler<ValueChangeArgs> TextReverse;
        public Model()
        { textValue = string.Empty; }

        public void Set(string value)
        {
            string previousValue = textValue;
            textValue = value;
            RaiseTextSetEvent(previousValue, value);
        }

        public void Reverse(string value)
        {
            string previousValue = textValue;
            textValue = value;
            RaiseTextSetEvent(previousValue, textValue);
        }
        private void RaiseTextSetEvent(string previousValue, string currentValue)
        {
            TextSet(this, new ValueChangeArgs(previousValue, currentValue));
        }
    }

    public class ValueChangeArgs : EventArgs
    {
        public string PreviousValue { get; set; }
        public string NewValue { get; set; }

        public ValueChangeArgs(string before, string after)
        {
            PreviousValue = before;
            NewValue = after;
        }
    }
}
