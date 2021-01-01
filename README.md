## Run web application

`$ dotnet run --project WebApplication/WebApplication.csproj `

`HTTP GET: https://localhost:5001/api/foo%2Fbar`

**Returns expected HTTP 200 with content `foo%2Fbar`.**

## Run Test

`$ dotnet test`

**Expected:** Test expecting HTTP 200 should not fail. \
**Actual:** Test failing with HTTP 404 Not Found response.
