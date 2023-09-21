namespace AlgoritmsLesson3_1
{
    public class SuperHashTable<T>
    {
        private Item<T>[] items;

        public SuperHashTable(int size)
        {
            items = new Item<T>[size];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item<T>(i);
            }
        }

        public void Add(T item)
        {
            var key = GetHash(item);
            if (items[key] == null)
            {
                items[key].Nodes.Add(item);
            }
            else
            {
                while (items[key] != null && key < items.Length)
                {
                    if (key + 1 < items.Length) key++;
                    else key = 0;
                    if (items[key] == null && key < items.Length)
                    {
                        items[key].Nodes.Add(item);
                        break;
                    }
                }
            }
        }

        public bool Search(T item)
        {
            var key = GetHash(item);
           return items[key].Nodes.Contains(item);
        }
        
        private int GetHash(T item)
        {
            return item.ToString().Length % items.Length;
        }
    }
}