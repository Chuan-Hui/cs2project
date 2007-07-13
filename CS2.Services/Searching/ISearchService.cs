using System.Collections.Generic;
using Lucene.Net.Documents;
using Lucene.Net.Highlight;

namespace CS2.Services.Searching
{
    public interface ISearchService
    {
        Formatter Formatter { get; set; }

        Fragmenter Fragmenter { get; set; }

        Encoder Encoder { get; set; }

        IEnumerable<Document> Search(string query);
        IEnumerable<SearchResult> SearchWithHighlighting(string query);
    }
}