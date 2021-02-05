FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build

RUN curl --silent --location https://deb.nodesource.com/setup_10.x | bash -
RUN apt-get install --yes nodejs
WORKDIR /src
COPY ["Logistics.Client.React/Logistics.Client.React.csproj", "Logistics.Client.React/"]
COPY ["Logistics.Data/Logistics.Data.csproj", "Logistics.Data/"]
COPY ["Logistics.Data.Core/Logistics.Data.Core.csproj", "Logistics.Data.Core/"]
RUN dotnet restore "Logistics.Client.React/Logistics.Client.React.csproj"
COPY . .
WORKDIR "/src/Logistics.Client.React"
RUN dotnet build "Logistics.Client.React.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Logistics.Client.React.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Logistics.Client.React.dll"]