# Clean Architecture - Arquitetura Limpa - .Net C#

O projeto é uma abstração de um catálogo de produtos onde é possível criar um produto e uma categoria e realizar o vínculo onde uma categoria pode conter vários produtos.

Para isso foi utilizado os princípios do Clean Architecture com o apoio dos aproaches a seguir:
  * Utilização do princípios SOLID
  * Api no padrão REST
  * Injeção de dependência
  * Padrão MVC
  * Padrão CQRS
  * Aplicação de migrations utilizando o "Code First"
  * Autenticação JWT
  * Autenticação Identity Server
  * Teste unitários com xUnit
  * Banco Sql Server

A aplicação é composta por 7 projetos, sendo 2 deles camada de apresentação e uma camada de teste. Segue uma breve descrição de cada uma das responsabilidades dos projetos:
  * CleanArchMvc.Api - Projeto composto pela api no padrão REST
  * CleanArchMvc.WebUI - Camada de apresentação utilizando o MVC ASP .NET Core
  * CleanArchMvc.Domain.Tests - Projeto de testes unitários utilizando o xUnit
  * CleanArchMvc.Infra.Ioc - Camada responsável pelo gerenciamento da injeção de dependencia entre os projetos
  * CleanArchMvc.Application - Projeto composto pela camada de services e regras de negócio da aplicação
  * CleanArchMvc.Infra.Data - Camada de conexão com o banco Sql Server através do Entity Framework
  * CleanArchMvc.Domain - Representação das entidades/tabelas

## 🚀 Começando

Essas instruções permitirão que você obtenha uma cópia do projeto em operação na sua máquina local para fins de desenvolvimento e teste.
  * Abra o prompt de comando e o aponte para um diretório a seu critério
  * Com o prompt apontado para o diretório, digite o "git clone https://github.com/alanfelipeneres/clean-architecture"
  * O código da aplicação será baixado no diretório informado
  * Na pasta onde foi baixado o código fonte da aplicação abra a soluction (CleanArchMvc.sln) em uma IDE .Net de sua preferência
  * Clique com o botão direito no projeto a ser executado, pode ser o CleanArchMvc.WebUI, e selecione a opção "Set as StartUp Project"
  * Clique no botão Run ou pressione F5 para executar o projeto

Possíveis erros:
  * Pode haver a necessidade de restaurar os pacotes utilizados nos projetos, para isso basta clicar com o botão direito na soluction (CleanArchMvc.sln) e selecionar a opção "Restore NuGet Packages"

### 📋 Pré-requisitos
  * .Net Core 7 ou superior
  * Uma IDE .Net de sua preferência. Ex: Visual Studio, VS Code, JetBrains Rider e etc

## 🖇️ Colaborando
Trata-se de uma aplicação baseada no curso Clean Architecture Essencial - ASP .NET Core com C# do professor Macoratti. Curso feito através da plataforma Udemy

## ✒️ Autores
* **Alan Felipe** - Aluno do curso
* **José Carlos Macoratti** - Professor e instrutor do curso
