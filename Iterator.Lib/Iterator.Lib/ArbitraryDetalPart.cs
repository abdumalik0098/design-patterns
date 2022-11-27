using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Lib
{
    public class ArbitraryDetalPart:IDetalPart
    {
        int id;
        int capacity;
        DetalItem[] items;

        public ArbitraryDetalPart()
        {
            id = 1234;
            capacity = 7;
            items = new DetalItem[capacity];
        }

        public DetalItem this[int index]
        {
            get
            {
                if (index >= 0 && index < capacity)
                {
                    return items[index];
                }
                else return null;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public void AddDetal(DetalItem Item)
        {
            for (int i = 0; i < capacity; i++)
            {
                if (items[i] == null)
                {
                    items[i] = Item;
                    break;
                }
            }
        }

        public IDetalIterator CreateDetalIterator()
        {
            return new ConcreteDetalIterator(this);
        }

        public DetalItem MoveDetalToDefective(int Id)
        {
            DetalItem DefectDetal = null;
            for (int i = 0; i < capacity; i++)
            {
                if (items[i].ID == Id)
                {
                    DefectDetal = items[i];
                    items[i] = null;
                    break;
                }
            }
            return DefectDetal;
        }

    }
}
