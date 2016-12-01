# Exemplo de .NET Core 1.1 (ASP.NET Web API) com EFCore (SqlServer) rodando no Linux

#.NET Core e Node.js
[Instale o Node.js](https://nodejs.org/en/)
[Instale o .NET Core](http://www.dot.net)

##Yoeman
Para instalar o Yoeman e o Scaffolding do ASP.NET Core (o bower é requerido pelo Scaffolding), utilize o NPM, através dos seguintes comandos:
`npm i -g bower`
`npm i -g yo`
`npm i -g generator-aspnet`

Para criar o projeto do zero, você pode utilizar agora o comando `yo dotnet` e seguir as instruções informadas no terminal.

## Migrations
Para criar o primeiro pacote do migration, execute o comando abaixo:
`dotnet ef migrations add MigracaoInicial`

## Docker - Container SqlServer no Linux
[Docker para o MacOS](https://www.docker.com/products/docker#/mac)

Para subir a imagem do container SqlServer (linux), execute o comando abaixo:
`sudo docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Workshop@123' -p 1433:1433 -d microsoft/mssql-server-Linux`

## Visual Studio Code
[Visual Studio Code](https://code.visualstudio.com/)

## Visual Studio Code Extensions
- C#
- C# Extensions
- vscode-icons