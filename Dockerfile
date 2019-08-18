#Import dotnet runtime image
FROM mcr.microsoft.com/dotnet/core/sdk:2.2

#Set Working Directory
WORKDIR /app

#Copy contents to working directory
COPY ./CartApp/bin/Release/netcoreapp2.2/ .

# Run app when the container launches
ENTRYPOINT dotnet CartApp.dll