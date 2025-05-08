using QuarterSpiralApi.Models;

namespace QuarterSpiralApi.Repositories
{
    /// <summary>
    /// Gränssnitt för dataåtkomstlagret som hanterar in- och utmatning av rutnätet.
    /// Implementeras av GridRepository och används av tjänstelagret (GridService).
    /// </summary>
    public interface IGridRepository
    {
        /// <summary>
        /// Läser rutnätet från lagringskällan (t.ex. en JSON-fil).
        /// </summary>
        /// <returns>En lista av GridSquare-objekt som representerar rutnätet.</returns>
        List<GridSquare> Load();

        /// <summary>
        /// Sparar det givna rutnätet till lagringskällan.
        /// </summary>
        /// <param name="grid">En lista av GridSquare-objekt som ska sparas.</param>
        void Save(List<GridSquare> grid);
    }
}
