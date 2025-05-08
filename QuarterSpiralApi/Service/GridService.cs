using QuarterSpiralApi.Models; // Importerar modellen GridSquare som representerar en ruta i rutnätet
using QuarterSpiralApi.Repositories; // Importerar repository-interfacet för att använda datalagring

namespace QuarterSpiralApi.Services
{
    // 🔧 Tjänst (Service Layer) som hanterar affärslogik för rutnätet
    public class GridService : IGridService
    {
        // 💾 Repository-fältet där all dataåtkomst sker (via interface)
        private readonly IGridRepository _repository;

        // 🧱 Konstruktor: tar in ett repository (via dependency injection)
        public GridService(IGridRepository repository)
        {
            _repository = repository; // Sparar referensen till repository
        }

        // 📥 Hämtar rutnätet från repositoryn (som i sin tur läser från fil)
        public List<GridSquare> GetGrid()
        {
            return _repository.Load(); // Returnerar innehållet i grid.json som lista av GridSquare
        }

        // 💾 Sparar ett nytt rutnät till repositoryn (som i sin tur sparar till fil)
        public void SaveGrid(List<GridSquare> grid)
        {
            _repository.Save(grid); // Serialiserar och sparar rutnätet till grid.json
        }
    }
}
