# get the official .NET SDK image that has all the tools and packages needed to build a .NET application
FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env

# create a working directory for our source files in the image
# instructs Docker to use this path as the default location for all subsequent commands
# so, we can use relative paths based on the working directory
WORKDIR /src

# Project files don't change often, so take advantage of caching and copy files and run restore
COPY src/UDS.Net.Web.MVC/UDS.Net.Web.MVC.csproj UDS.Net.Web.MVC/
COPY src/UDS.Net.Forms/UDS.Net.Forms.csproj UDS.Net.Forms/
COPY src/UDS.Net.Web.MVC.Services/UDS.Net.Web.MVC.Services.csproj UDS.Net.Web.MVC.Services/
RUN dotnet restore "UDS.Net.Web.MVC/UDS.Net.Web.MVC.csproj"

# Copy all source files into image and build the project
COPY src/ .
RUN dotnet publish "UDS.Net.Web.MVC/UDS.Net.Web.MVC.csproj" -c Release -o /publish/app /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime

WORKDIR /app
COPY --from=build-env /publish/app .

EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "UDS.Net.Web.MVC.dll"]