using CodeFactory.Iterators;

namespace CodeFactory.Aggregates
{
    public interface IAggregate<T>
    {
        public void Add(T obj);
        public void Remove(T obj);
        public void Clear();
        public T At(int index);
        public void Insert(T obj, int index);
        public IIterator GetIterator();
    }
}
