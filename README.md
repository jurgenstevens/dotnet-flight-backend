# DotNetFlights API

## Starting SQL Server
```powershell
$sa_password = "[SA PASSWORD HERE]"
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=$sa_password" -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server
```

## Setting the connection string to secret manager
```powershell
$sa_password = "[SA PASSWORD HERE]"
dotnet user-secrets set "ConnectionStrings:DotNetFlightsContext" "Server=localhost; Database=DotNetFlights; User Id=sa;  Password=$sa_password;TrustServerCertificate=True"

```