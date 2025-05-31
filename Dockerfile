FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app

COPY . ./

EXPOSE 5116

CMD ["dotnet", "run", "--urls", "http://0.0.0.0:5116"]