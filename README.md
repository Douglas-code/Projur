# Projur

Projeto criado para o teste técnico.

### 📋 Pré-requisitos

```
.NET Core 3.1
Angular 8+ instalado
```

### 🔧 Instalação

Para rodar o projeto você pode fazer o seguinte

```
rodar pelo Visual Studio
abrir o projeto BancoAtlatico.Api e executar o seguinte comando no terminal
ou prompt de comando: dotnet run
```
O sistema está usando banco de dados InMemory, não será preciso ter nenhum banco de dados instalado.

## ⚙️ Executando os as migrations

Para executar as migrations é necessário rodar o seguinte comando no projeto de infraestrutura: dotnet ef database update -s ..\Projur.Api\Projur.Api.csproj

