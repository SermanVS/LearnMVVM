using System;
using System.Collections.Generic;
using System.Text;

namespace LearnMVVM.Model
{
    class Item
    {
        private int value;
       
        public Item(int _value = 0)
        {
            this.setValue(_value);
        }

        public int getValue()
        {
            return value;
        }
        public void setValue(int _value)
        {
            this.value = _value;
        }
    }
}
