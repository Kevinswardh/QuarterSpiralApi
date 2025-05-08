# QuarterSpiralAPI

Detta projekt är ett backend-API byggt i **.NET** som hanterar logiken för att generera och lagra ett rutnät av färgade kvadrater. API:t tillåter frontend-appen att spara och hämta rutnätets tillstånd. Rutnätet fylls i spiralordning.

## Funktioner

- Skapar och lagrar rutnät med färgade kvadrater.
- Hämtar det senaste sparade rutnätet.
- Skickar uppdaterat rutnät från frontend till servern.

## API-endpoints

- `GET /api/grid` – Hämtar det sparade rutnätet (tvådimensionell array med färger eller null).
- `POST /api/grid` – Tar emot ett uppdaterat rutnät och sparar det.

## Teknisk översikt

- Byggt med **.NET Core**.
- API:t använder en enkel in-memory-databas för att lagra rutnätet.

## Exempel på användning

För att hämta det sparade rutnätet, gör en `GET`-förfrågan till: GET http://localhost:7049/api/grid


För att skicka ett uppdaterat rutnät till servern, gör en `POST`-förfrågan till: POST http://localhost:7049/api/grid

Med en JSON-body som representerar det nya rutnätet, t.ex.:

```json
[
  ["#e74c3c", "#9b59b6", "#f1c40f"],
  ["#2ecc71", "#3498db", "#e67e22"],
  ["#1abc9c", "#ff69b4", "#e74c3c"]
]
