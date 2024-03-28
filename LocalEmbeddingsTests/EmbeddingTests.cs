using LocalEmbeddings;
using SmartComponents.LocalEmbeddings;

namespace LocalEmbeddingsTests;

public class EmbeddingTests
{
    private readonly Embedder _embedder;

    public EmbeddingTests()
    {
        _embedder = new Embedder(new LocalEmbedder());
    }

    [Fact]
    public void Test1()
    {
        _embedder.PerformEmbedding("Dogs cannot be green");
    }
}
