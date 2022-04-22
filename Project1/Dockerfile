FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Project1.csproj", "Project1/"]
RUN dotnet restore "Project1/Project1.csproj"

COPY . Project1/.
RUN dotnet publish -c Release -o /app Project1/Project1.csproj 

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS publish
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "Project1.dll"]