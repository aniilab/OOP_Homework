using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!

    //Порушено принцип Single Responsibility, після виправлення матиме такий вигляд:
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public double CalculateTotalSum() {/*...*/}
        public List<Item> GetItems() {/*...*/}
        public int GetItemCount() {/*...*/}
        public bool AddItem(Item item) {/*...*/}
        public bool DeleteItem(Item item) {/*...*/}

    }

    class OrderOutput {

        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}
    }

    class OrderManager
    {
        public bool Load(Order order) {/*...*/}
        public bool Save(Order order) {/*...*/}
        public bool Update(Order order) {/*...*/}
        public bool Delete(Order order) {/*...*/}
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
