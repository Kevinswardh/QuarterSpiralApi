# 🧩 Wizardworks Kodtest – Quarter Spiral Grid

Detta projekt är en lösning på Wizardworks kodtest där uppgiften är att skapa en webbsida som genererar ett rutnät av kvadrater med slumpmässiga färger. Varje gång användaren klickar på en knapp ska en ny ruta läggas till enligt ett spiralformat mönster, färgen sparas, och allt laddas från ett backend-API vid sidladdning.

---

## 🚀 Funktionalitet

✅ React-app med rutnätsrendering  
✅ Klick för att lägga till ny ruta (i rätt ordning)  
✅ Slumpmässig färg (ej samma som föregående)  
✅ All data skickas till .NET Web API  
✅ JSON-fil används för persistent lagring  
✅ Återladdning vid sidvisning  
✅ CORS korrekt konfigurerat  
✅ Kodstruktur med Repository + Service-pattern  
✅ Automatisk fil- och mappskapning

---

## 🗂️ Teknisk Struktur

/QuarterSpiralApp/       ← React frontend  
/QuarterSpiralApi/       ← .NET Web API  
  ├── Controllers/  
  │   └── GridController.cs  
  ├── Models/  
  │   └── GridSquare.cs  
  ├── Repositories/  
  │   ├── IGridRepository.cs  
  │   └── GridRepository.cs  
  ├── Services/  
  │   ├── IGridService.cs  
  │   └── GridService.cs  
  ├── JsonData/  
  │   └── grid.json       ← persistent lagring

---

## 🔧 API-specifikation

### GET /api/grid
Hämtar alla rutor i rutnätet.
[
  { "row": 0, "col": 0, "color": "#e74c3c" },
  { "row": 0, "col": 1, "color": "#3498db" },
  ...
]

### POST /api/grid
Sparar hela rutnätet som lista av { row, col, color }.
[
  { "row": 0, "col": 0, "color": "#2ecc71" },
  ...
]

---

## 🧠 Arkitektur & Motivation

- Repository Pattern: abstraktion för datalagring (filhantering)  
- Service Layer: affärslogik och vidare expansion (t.ex. validering)  
- React State: hanterar grid som en lista av { row, col, color }  
- JSON-bas: enkel och läsbar persistens

---

## 🛠️ Setup

1. .NET API  
   cd QuarterSpiralApi  
   dotnet run  

2. React frontend  
   cd QuarterSpiralApp  
   npm install  
   npm run dev

---

## 🛡️ CORS

React körs på http://localhost:5173, vilket är tillåtet i Program.cs:
.WithOrigins("http://localhost:5173")

---

## 📣 Slutord

Projektet visar på:
- förståelse för uppgiften,
- separation av ansvar (frontend/backend),
- persistens,
- hantering av state + API-kommunikation,
- kod som är enkel att läsa, testa och vidareutveckla.

Har du frågor eller vill diskutera lösningen? Tveka inte att kontakta mig!
