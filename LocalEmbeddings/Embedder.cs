using SmartComponents.LocalEmbeddings;

namespace LocalEmbeddings;

public class Embedder
{
    private readonly LocalEmbedder _localEmbedder;
    public Embedder(LocalEmbedder localEmbedder) => _localEmbedder = localEmbedder;

    public SimilarityScore<string>[] PerformEmbedding(string input)
    {
        var batch = _localEmbedder.EmbedRange(new[]
        {
            "Cats can be blue",
            "Dogs can be red",
            "AI will take over the world in 20 years",
            "Pizza with pineapple is the best human invention ever"
        });
        var target = _localEmbedder.Embed(input);
        return LocalEmbedder.FindClosestWithScore(target, batch, maxResults: 20);
    }
}
