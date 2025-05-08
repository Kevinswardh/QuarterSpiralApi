using QuarterSpiralApi.Models;

namespace QuarterSpiralApi.Services
{
    /// <summary>
    /// Gränssnitt som definierar kontraktet för rutnätsrelaterade tjänster.
    /// Används som mellanlager mellan controller och repository.
    /// </summary>
    public interface IGridService
    {
        /// <summary>
        /// Hämtar det aktuella rutnätet från lagringen.
        /// </summary>
        /// <returns>En lista av GridSquare-objekt som representerar rutnätet.</returns>
        List<GridSquare> GetGrid();

        /// <summary>
        /// Sparar ett nytt rutnät till lagringen.
        /// </summary>
        /// <param name="grid">En lista av GridSquare-objekt som ska sparas.</param>
        void SaveGrid(List<GridSquare> grid);
    }
}
