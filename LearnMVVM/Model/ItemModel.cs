using System;
using System.Collections.Generic;
using System.Text;

namespace LearnMVVM.Model
{
    class ItemModel
    {
        private int value;
       
        public ItemModel(int _value = 0)
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
        
        public ItemModel getAsSumOf(ItemModel valueA, ItemModel valueB)
        {
            this.setValue(valueA.getValue() + valueB.getValue());
            return this;
        }
    }
}
