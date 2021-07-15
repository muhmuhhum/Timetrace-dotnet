FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Timetrace/Timetrace.csproj", "Timetrace/"]
RUN dotnet restore "Timetrace/Timetrace.csproj"
COPY . .
WORKDIR "/src/Timetrace"
RUN dotnet build "Timetrace.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Timetrace.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Timetrace.dll"]
