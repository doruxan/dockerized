FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Logistics.API/Logistics.API.csproj", "Logistics.API/"]
COPY ["Logistics.Business/Logistics.Business.csproj", "Logistics.Business/"]
COPY ["Logistics.Business.Core/Logistics.Business.Core.csproj", "Logistics.Business.Core/"]
COPY ["Logistics.Data/Logistics.Data.csproj", "Logistics.Data/"]
COPY ["Logistics.Data.Core/Logistics.Data.Core.csproj", "Logistics.Data.Core/"]
RUN dotnet restore "Logistics.API/Logistics.API.csproj"
COPY . .
WORKDIR "/src/Logistics.API"
RUN dotnet build "Logistics.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Logistics.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Logistics.API.dll"]
