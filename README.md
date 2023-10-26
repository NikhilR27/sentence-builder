# sentence-builder

App does not fully run in Docker, so a local instance MS SQL Server is required:

Run `docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Admin@123" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest` to create your MS SQL instance in Docker

Run SQL script to initialize database `data/init.sql`

Run `cd ./WebAPI`

Run `dotnet run`

The application will not startup on port 5242 (http://localhost:5242)

