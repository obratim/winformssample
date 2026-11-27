namespace winformssample;

class Algorithms
{
    private const int SIZE = 0x10000000;
    private readonly decimal[] _data;

    public Algorithms()
    {
        _data = new decimal[SIZE];
        for (var i = 0; i < _data.Length; ++i)
            _data[i] = (decimal)Random.Shared.NextDouble();
    }

    public decimal Sum() => _data.Sum();

    public async Task<decimal> SumAsync(int chunckSize = SIZE / 4)
    {
        var threads = (SIZE / chunckSize) + ((SIZE % chunckSize) > 0 ? 1 : 0); // считаем сколько потоков понадобится

        var tasks = Enumerable
            .Range(0, threads)
            .Select(i => Task.Run(() => _data.Skip(i * chunckSize).Take(chunckSize).Sum()))
            ;

        var results = await Task.WhenAll(tasks);
        return results.Sum();
    }
}
