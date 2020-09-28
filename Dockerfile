FROM mcr.microsoft.com/dotnet/core/sdk:3.1

ADD ssmtest.tar.gz /

WORKDIR /ssmtest

CMD ["dotnet","run"]
