using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BagClass
{
    public struct _Object
    {
        string name;
        int volume;
        int weight;

        public _Object(string name, int volume, int weight)
        {
            this.name = name;
            this.volume = volume;
            this.weight = weight;
        }
    }

    public delegate void AddItemDelegate(_Object newObj);

    public class AddItemEventSource
    {
        public event AddItemDelegate ev;
        public void GenerateEvent(_Object newObject)
        {
            ev(newObject);
        }
    }
    public class Bag
    {
      
        public string Color { get; set; }
        public string Brand { get; set; }
        private int totalWeight=0;
        public int TotalWeight { get { return totalWeight; } }
        private int totalVolume=100;
        public int TotalVolume { get { return totalVolume; } }

        _Object[] obj;
        public void AddItem(_Object newObject)
        {
            _Object[] newArr = new _Object[obj.Length+1];
            for(int i=0; i< obj.Length; i++)
            {
                newArr[i] = obj[i];
            }
            newArr[newArr.Length - 1]=newObject;
        }
    }
}
