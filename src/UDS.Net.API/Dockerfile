FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env

WORKDIR /src

COPY src/UDS.Net.API/UDS.Net.API.csproj UDS.Net.API/
COPY src/UDS.Net.Dto/UDS.Net.Dto.csproj UDS.Net.Dto/
RUN dotnet restore "UDS.Net.API/UDS.Net.API.csproj"

COPY src .
RUN dotnet publish "UDS.Net.API/UDS.Net.API.csproj" -c Release -o /publish/api

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime

WORKDIR /app
COPY --from=build-env /publish/api .

EXPOSE 80

ENTRYPOINT ["dotnet", "UDS.Net.API.dll"]