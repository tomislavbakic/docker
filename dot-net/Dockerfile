FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src/
COPY ["SkiSchool/SkiSchool.csproj", "SkiSchool/"]
RUN dotnet restore "SkiSchool/SkiSchool.csproj"
COPY . .
WORKDIR "/src/SkiSchool"
RUN dotnet build "SkiSchool.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SkiSchool.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SkiSchool.dll"]