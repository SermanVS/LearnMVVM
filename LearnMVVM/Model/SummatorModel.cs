using System;
using System.Collections.Generic;
using System.Text;

namespace LearnMVVM.Model
{
    class SummatorModel
    {
        public Item _itemA;
        public Item _itemB;
        public Item _result;

        public SummatorModel(int valueA = 0, int valueB = 0)
        {
            _itemA = new Item(valueA);
            _itemB = new Item(valueB);
            _result = new Item(valueA + valueB);
        }
        public void setResultAsSum()
        {
            _result.setValue(_itemA.getValue() + _itemB.getValue());
        }
    }

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
