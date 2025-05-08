using QuarterSpiralApi.Models; // Importerar modellen GridSquare som definierar varje ruta
using System.Text.Json; // Används för att serialisera och deserialisera JSON-data

namespace QuarterSpiralApi.Repositories
{
    // 💾 Repository-klassen hanterar filin- och utmatning av rutnätet (grid)
    public class GridRepository : IGridRepository
    {
        // 🛤️ Sökväg till mappen där filen ska sparas
        private readonly string folderPath;
        // 📄 Sökväg till JSON-filen som innehåller rutnätet
        private readonly string filePath;

        // 🏗️ Konstruktor – körs när klassen instansieras
        public GridRepository()
        {
            // 🔧 Mapp: rotkatalog + undermapp "JsonData"
            folderPath = Path.Combine(Directory.GetCurrentDirectory(), "JsonData");
            // 🔧 Fil: sökväg till grid.json i JsonData
            filePath = Path.Combine(folderPath, "grid.json");

            // 📁 Skapa mappen om den inte finns
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            // 📄 Skapa tom JSON-fil om den inte finns, med tom array []
            if (!File.Exists(filePath))
                File.WriteAllText(filePath, "[]");
        }

        // 📥 Hämtar rutnätet från filen och omvandlar till en lista av GridSquare-objekt
        public List<GridSquare> Load()
        {
            var json = File.ReadAllText(filePath); // Läser filinnehållet som text
            var grid = JsonSerializer.Deserialize<List<GridSquare>>(json); // Tolkar JSON till C#-objekt
            return grid ?? new List<GridSquare>(); // Om något går fel returneras en tom lista
        }

        // 💾 Sparar rutnätet till JSON-fil genom att skriva över tidigare innehåll
        public void Save(List<GridSquare> grid)
        {
            // 🔄 Serialiserar listan till formaterad JSON-text
            var json = JsonSerializer.Serialize(grid, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json); // Skriver JSON-strängen till filen
        }
    }
}
