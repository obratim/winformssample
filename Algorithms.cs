namespace winformssample;

class Algorithms
{
    private const int SIZE = 0x10000000; // размер массива
    private const int VALUES_IN_FILE = 1_000_000;
    private readonly decimal[] _data;

    public Algorithms()
    {
        // инициализация массива
        _data = new decimal[SIZE];

        // заполнение массива случайными числами в 4 потока
        Enumerable.Range(0, 4)
            .AsParallel()
            .ForAll(n =>
            {
                var chunkSize = SIZE / 4;
                var startPosition = n * chunkSize;
                for (var i = startPosition; i < startPosition + chunkSize; ++i)
                    _data[i] = (decimal)Random.Shared.NextDouble();
            });
    }

    public decimal Sum() => _data.Sum();

    public async Task<decimal> SumAsync(int chunkSize = SIZE / 4)
    {
        // посчитаем сумму в частях массива, затем сумму сумм

        var threads = (SIZE / chunkSize) + ((SIZE % chunkSize) > 0 ? 1 : 0); // считаем сколько потоков понадобится

        int[] positions = // позиции в массиве, начиная с которой будет посчитана сумма chunckSize чисел
            [
                ..Enumerable
                .Range(0, threads)
                .Select(i => i * chunkSize)
            ];
        Task<decimal>[] tasks = // задачи на вычисление сумм в частях
            [
                ..positions
                    .Select(position => Task.Run(() => _data.Skip(position).Take(chunkSize).Sum()))
            ];

        var results = await Task.WhenAll(tasks); // получение промежуточных результатов
        // при этом таски ещё есть, но у них статус "RanToCompletition"
        return results.Sum(); // итоговая сумма всего массива
    }

    private static string FileName(int i) => $"Values {i} - {i + VALUES_IN_FILE - 1}.txt";
    private string FileContent(int i) => string.Join('\n', _data.Skip(i).Take(VALUES_IN_FILE));

    public void SaveFiles()
    {
        for (var i = 0; i < SIZE; i += VALUES_IN_FILE)
        {
            var fileName = FileName(i);
            System.IO.File.WriteAllText(FileName(i), FileContent(i));
        }
    }

    public async Task SaveFilesAsync()
    {
        for (var i = 0; i < SIZE; i += VALUES_IN_FILE)
        {
            await System.IO.File.WriteAllTextAsync(FileName(i), FileContent(i));
        }
    }
}
