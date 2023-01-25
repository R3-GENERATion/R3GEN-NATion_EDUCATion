using CodeFactory.Aggregates;

namespace CodeFactory.Helpers
{
    public interface IShuffler<T>
    {
        public void Shuffle(IAggregate<T> aggregate);
    }
}
