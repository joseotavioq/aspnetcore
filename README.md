# ASP.NET Web API com EFCore (SqlServer) rodando no MacOS


##Yoeman
`npm i -g yo`
`npm i -g generator-aspnet`

## Migrations
`dotnet ef migrations add MigracaoInicial`

## Docker SqlServer
`sudo docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=suasenha' -p 1433:1433 -d microsoft/mssql-server-Linux`