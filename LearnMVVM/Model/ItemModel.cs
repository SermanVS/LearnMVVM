using System;
using System.Collections.Generic;
using System.Text;

namespace LearnMVVM.Model
{
    class ItemModel
    {
        public Item itemA;
        public Item itemB;
        public Item result;

        public ItemModel(int _valueA = 0, int _valueB = 0)
        {
            itemA = new Item(_valueA);
            itemB = new Item(_valueB);
            result = new Item(_valueA + _valueB);
        }
        public void getSumOf(Item itemA, Item itemB)
        {
            result.setValue(itemA.getValue() + itemB.getValue());
        }
    }
}
