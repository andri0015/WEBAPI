# WEBAPI
Proyecto que contiene el listado del personal con su respectivo cargo, área a la que pertenece y centro de costos

Documentación de las API en https://localhost:7159/swagger/index.html  

dotnet tool install --global dotnet-ef

Migraciones 
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.0-preview.5.23280.1
dotnet ef database update

dotnet ef migrations add XXXX --- luego el anterior 

Como ejecutar el Docker
docker-compose up -d --build