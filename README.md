## Sobre o projeto

Esta aplicação desktop MVP, desenvolvida utilizando **.NET 8**, adota os princípios do **Domain-Driven Design (DDD)** para oferecer uma solução estruturada e eficaz no gerenciamento de despesas pessoais. O principal objetivo é permitir que os usuários façam o gerenciamento do estoque, em que pode ser cadastrado fornecedores, categorias, produtos, registrar movimentações e controle de usuários. Os dados são armazenados no banco de dados **PostgreSQL**.

Dentre os pacotes NuGet utilizados, o **Dapper** simplifica as interações com a base de dados, em que agiliza as operações, principalmente pelo mapeamento realizado para os objetos.

### Construído com

![badge-dot-net]
![badge-windows]
![badge-visual-studio]
![badge-postgresql]

## Getting started

Para obter uma cópia local funcionando siga esses passos simples.

### Requisitos

* Visual Studio versão 2022
* Windows 10+ com [.NET 8 SDK][dot-net-sdk] instalado
* PostgreSQL Server ou Docker Desktop

### Instalação

1. Clone o repositório:

```sh
git clone https://github.com/GabrielSousaJS/estoque-flow.git
```

2. Verifique as informações de conexão com o banco de dados baseado na opção utilizada

### PostgreSQL com Docker

* Com o Docker Desktop instalado, basta executar o script abaixo. Ele irá criar um container PostgreSQL que contém a mesma configuração já feita na aplicação
```sh
docker run --name estoque-database -e POSTGRESQL_USERNAME=estoque -e POSTGRESQL_PASSWORD=estoque.123 -e POSTGRESQL_DATABASE=estoque -p 5432:5432 bitnami/postgresql
```
* Realizar a conexão com o banco de dados por meio de um SGBD compatível com PostgreSQL (ex.: DBeaver)
* Executar o script DDL disponível na pasta **script-db**

### PostgreSQL sem Docker

* Estabelecer conexão com o banco de dados
* Executar o script disponível na pasta **script-db**
* Altere as configurações no arquivo `\src\EstoqueFlow.Infraestructure\DataAccess\DbConnectionFactory.cs`
* Realize o teste de conexão entre aplicação e banco de dados ao cadastrar um novo usuário

## Apenas executar

* Windows 10+ e possuir o [.NET 8 Desktop Runtime][dot-net-runtime] instalado
* Seguir os passos da seção **PosgreSQL com Docker**
* Instalar a pasta dist.zip do [repositório][estoque-flow] e descompactar, e executar o arquivo **EstoqueFlow.exe**
* Todos os arquivos da pasta dist devem ser mantidos, caso o arquivo **EstoqueFlow.exe** ou qualquer outro seja movido ao removido, a aplicação não irá funcionar corretamente

## Observação

* O .NET para Desktop possui algumas limitações, dentre elas a resolução, para não ocorrer problemas de layout, deve ser utilizado a resolução 1920x1080 e escala 100%
* Como a aplicação não será utilizada em ambiente corporativo, a conexão com banco de dados está no projeto, caso contrário, esses dados seriam recebidos como argumentos ao iniciar a aplicação.
<!-- Links -->
[dot-net-sdk]: https://dotnet.microsoft.com/pt-br/download
[dot-net-runtime]: https://dotnet.microsoft.com/pt-br/download/dotnet/thank-you/runtime-desktop-8.0.16-windows-x64-installer?cid=getdotnetcore
[estoque-flow]: https://github.com/GabrielSousaJS/estoque-flow-apenas-execucao

<!-- Badges -->
[badge-dot-net]: https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge
[badge-windows]: https://img.shields.io/badge/Windows-0078D4?logo=windows&logoColor=fff&style=for-the-badge
[badge-visual-studio]: https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=fff&style=for-the-badge
[badge-postgresql]: https://img.shields.io/badge/postgresql-4169e1?style=for-the-badge&logo=postgresql&logoColor=white
