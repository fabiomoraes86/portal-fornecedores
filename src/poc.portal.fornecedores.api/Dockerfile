#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/poc.portal.fornecedores.api/poc.portal.fornecedores.api.csproj", "src/poc.portal.fornecedores.api/"]
COPY ["src/poc.portal.fornecedores.application/poc.portal.fornecedores.application.csproj", "src/poc.portal.fornecedores.application/"]
RUN dotnet restore "src/poc.portal.fornecedores.api/poc.portal.fornecedores.api.csproj"

COPY . .
WORKDIR "/src/src/poc.portal.fornecedores.api"
RUN dotnet build "poc.portal.fornecedores.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "poc.portal.fornecedores.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "poc.portal.fornecedores.api.dll"]