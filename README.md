# Plano de Estudos

## Objetivo

Construir uma base forte para trabalhar profissionalmente com:

- C#
- TypeScript
- DDD
- TDD
- Clean Architecture
- Testes unitarios
- Cache
- Mensageria
- SOLID
- AWS
- MVC
- React
- Next.js

O foco deste plano e sair da teoria e chegar em projetos que parecam com cenarios reais de trabalho.

## Estrategia

Estudar em camadas:

1. Fundamentos de programacao e linguagem
2. Arquitetura e boas praticas
3. Testes e qualidade
4. Desenvolvimento web backend e frontend
5. Escalabilidade e comunicacao entre sistemas
6. Cloud e deploy
7. Projetos completos para consolidacao

## Rotina sugerida

Se voce estudar 2 horas por dia, 5 dias por semana:

- 45 min de teoria
- 60 min de pratica
- 15 min de revisao e anotacoes

Se puder estudar mais, mantenha a proporcao:

- 30% teoria
- 70% pratica

## Plano por fases

### Fase 1 - Base forte em logica, C# e TypeScript

Duracao sugerida: 4 a 6 semanas

#### Objetivos

- Ganhar seguranca com sintaxe e estrutura de codigo
- Entender orientacao a objetos
- Aprender a escrever codigo limpo

#### Estudar em C#

- Tipos, variaveis, condicionais e lacos
- Metodos
- Classes e objetos
- Encapsulamento, heranca, polimorfismo
- Interfaces
- Exceptions
- Collections
- LINQ
- Async/await

#### Estudar em TypeScript

- Tipagem estatica
- Interfaces e types
- Generics
- Funcoes
- Classes
- Modules
- Promises e async/await
- Manipulacao de arrays e objetos

#### Estudar junto nessa fase

- Logica de programacao
- Algoritmos basicos
- Git e GitHub
- Clean Code
- Principios SOLID

#### Projetos da fase

- Sistema de cadastro no console com C#
- API simples com CRUD em C#
- Pequenos exercicios em TypeScript
- To-do list simples com TypeScript

## Fase 2 - Web com C# usando MVC e APIs

Duracao sugerida: 4 a 6 semanas

#### Objetivos

- Entender como aplicacoes web funcionam
- Aprender backend com estrutura profissional
- Comecar a separar responsabilidades

#### Estudar

- ASP.NET Core
- Controllers
- Services
- Repositories
- Entity Framework Core
- Migrations
- MVC
- Web API
- Autenticacao e autorizacao
- Validacoes
- Middlewares
- Injeccao de dependencia

#### Projetos da fase

- Sistema MVC de produtos, clientes e pedidos
- API REST com login e cadastro
- Sistema com banco de dados relacional

## Fase 3 - React e Next.js com TypeScript

Duracao sugerida: 4 a 6 semanas

#### Objetivos

- Criar interfaces modernas
- Integrar frontend com backend
- Trabalhar com stack usada no mercado

#### Estudar React

- Componentes
- Props
- State
- Hooks
- Formularios
- Requisicoes HTTP
- Context API
- Organizacao de pastas
- Boas praticas com TypeScript

#### Estudar Next.js

- App Router ou Pages Router
- Server Components e Client Components
- Rotas
- Layouts
- Fetch de dados
- Server Actions
- Autenticacao
- Renderizacao SSR, SSG e ISR

#### Projetos da fase

- Dashboard administrativo com React
- Frontend consumindo sua API em C#
- Aplicacao com Next.js e autenticacao

## Fase 4 - Testes unitarios, TDD e qualidade

Duracao sugerida: 4 semanas

#### Objetivos

- Aprender a confiar no codigo
- Desenvolver com mais seguranca
- Criar habito de testar antes e durante a implementacao

#### Estudar

- O que e teste unitario
- Piramide de testes
- TDD: red, green, refactor
- Mocks e stubs
- Testes de integracao
- Cobertura de testes
- Refatoracao segura

#### Ferramentas sugeridas

- C#: xUnit, NUnit ou MSTest
- Mock em C#: Moq
- TypeScript/React: Jest ou Vitest
- React Testing Library

#### Projetos da fase

- Refazer regras de negocio antigas usando TDD
- Cobrir casos de uso com testes unitarios
- Testar componentes React

## Fase 5 - DDD, Clean Architecture e modelagem

Duracao sugerida: 6 a 8 semanas

#### Objetivos

- Sair de CRUD simples e pensar em dominio
- Modelar software para negocio real
- Organizar sistemas escalaveis

#### Estudar DDD

- Linguagem ubiqua
- Entidades
- Value Objects
- Aggregates
- Repositories
- Domain Services
- Bounded Contexts
- Eventos de dominio

#### Estudar Clean Architecture

- Camada de dominio
- Camada de aplicacao
- Camada de infraestrutura
- Camada de apresentacao
- Inversao de dependencia
- Casos de uso

#### Relacao com SOLID

- Entender como SOLID ajuda a sustentar DDD e Clean Architecture
- Praticar separacao de responsabilidades
- Evitar classes e servicos inchados

#### Projeto principal da fase

Criar um sistema mais completo, por exemplo:

- E-commerce
- Gestao de pedidos
- Sistema financeiro
- Plataforma de reservas

Esse projeto deve conter:

- API em C#
- Arquitetura em camadas
- Regras de negocio isoladas
- Testes unitarios
- Casos de uso
- Banco de dados
- Frontend em React ou Next.js

## Fase 6 - Cache e mensageria

Duracao sugerida: 4 a 6 semanas

#### Objetivos

- Aprender a melhorar performance com cache
- Entender comunicacao assincrona entre servicos
- Preparar sistemas para crescer com mais seguranca

#### Estudar cache

- O que e cache e quando usar
- Cache em memoria
- Cache distribuido
- Cache aside
- Write through
- Write behind
- Expiracao e invalidacao
- Chaves e estrategia de nomenclatura
- Redis
- Cenarios de cache em APIs e consultas

#### Estudar mensageria

- O que e mensageria
- Filas e topicos
- Publish/subscribe
- Produtores e consumidores
- Retry
- Dead letter queue
- Idempotencia
- Event-driven architecture
- Integracao assincrona
- RabbitMQ
- SQS e SNS na AWS

#### Aplicacao pratica

- Adicionar Redis em uma API para acelerar consultas
- Criar invalidacao de cache em operacoes de escrita
- Publicar eventos ao criar ou atualizar entidades
- Consumir mensagens em background
- Simular notificacoes, processamento de pedidos ou envio de emails

#### Projeto da fase

- Sistema de pedidos com cache de leitura e fila para processamento assincrono

## Fase 7 - AWS e deploy

Duracao sugerida: 4 a 6 semanas

#### Objetivos

- Aprender a publicar e operar aplicacoes
- Entender servicos mais usados no mercado

#### Estudar AWS

- Conceitos de cloud
- IAM
- EC2
- S3
- RDS
- Lambda
- API Gateway
- CloudWatch
- SQS
- SNS
- ElastiCache
- ECS ou Elastic Beanstalk
- CI/CD

#### Aplicacao pratica

- Subir a API em C# na AWS
- Publicar frontend React ou Next.js
- Configurar armazenamento de arquivos no S3
- Configurar banco no RDS
- Configurar cache com Redis ou ElastiCache
- Integrar filas com SQS ou SNS
- Adicionar logs e monitoramento

## Ordem recomendada de estudo

1. C# + logica + OOP + SOLID
2. TypeScript + fundamentos de frontend
3. ASP.NET Core + MVC + APIs
4. React + Next.js
5. Testes unitarios + TDD
6. DDD + Clean Architecture
7. Cache + mensageria
8. AWS + deploy
9. Projeto final integrando tudo

## Projeto final recomendado

Criar um sistema completo com:

- Backend em C# com ASP.NET Core
- Frontend em Next.js com TypeScript
- Banco relacional
- Autenticacao
- Testes unitarios
- Casos de uso com Clean Architecture
- Modelagem com DDD
- Cache com Redis
- Mensageria com RabbitMQ ou SQS/SNS
- Deploy na AWS

### Sugestao de tema

- Plataforma de cursos
- Sistema de pedidos
- Sistema de agendamento
- Gestao financeira pessoal

## Exemplo de cronograma semanal

### Segunda

- C# ou ASP.NET Core

### Terca

- TypeScript ou React

### Quarta

- Testes unitarios e TDD

### Quinta

- DDD, SOLID e Clean Architecture

### Sexta

- Cache, mensageria ou AWS

### Sabado opcional

- Revisao
- Refatoracao
- Leitura tecnica
- Resolver exercicios

## Como estudar para ter resultado

- Sempre transformar teoria em projeto
- Criar repositorios pequenos e um projeto principal
- Escrever testes desde cedo
- Refatorar codigo antigo
- Revisar conceitos semanalmente
- Publicar projetos no GitHub
- Documentar o que aprendeu

## Meta de portfolio

Ao final, tente ter pelo menos:

- 2 projetos pequenos em C#
- 1 API com testes
- 1 sistema MVC
- 1 frontend em React
- 1 aplicacao em Next.js
- 1 projeto com DDD e Clean Architecture
- 1 projeto com cache
- 1 fluxo assincrono com mensageria
- 1 projeto publicado na AWS

## Proximo passo pratico

Se quiser seguir este plano de forma objetiva, a melhor sequencia agora e:

1. Comecar por C# + OOP + SOLID
2. Em paralelo, estudar TypeScript basico
3. Depois entrar em ASP.NET Core MVC e Web API
4. Em seguida conectar com React e Next.js
5. Depois aprofundar em testes, TDD, DDD e Clean Architecture
6. Em seguida estudar cache e mensageria
7. Finalizar com AWS e deploy

## Fontes para leitura

Esta secao foi pensada para quem aprende melhor lendo documentacao, guias tecnicos e referencias.

### C# e .NET

- C# no Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/
- Tour de C#: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/
- Referencia da linguagem C#: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/
- Guias de arquitetura .NET: https://dotnet.microsoft.com/learn/architecture

### ASP.NET Core, MVC e Web API

- Documentacao do ASP.NET Core: https://learn.microsoft.com/en-us/aspnet/core/
- Criando Web APIs com ASP.NET Core: https://learn.microsoft.com/en-us/aspnet/core/web-api/
- MVC no ASP.NET Core: https://learn.microsoft.com/en-us/aspnet/core/mvc/

### TypeScript

- TypeScript Handbook: https://www.typescriptlang.org/docs/handbook/intro.html
- Documentacao geral do TypeScript: https://www.typescriptlang.org/docs/

### React e Next.js

- React Learn: https://react.dev/learn
- React Setup: https://react.dev/learn/setup
- Next.js Docs: https://nextjs.org/docs
- Arquitetura do Next.js: https://nextjs.org/docs/architecture

### Testes unitarios e TDD

- xUnit para .NET: https://xunit.net/docs/getting-started/v3/getting-started
- React Testing Library: https://testing-library.com/docs/react-testing-library/intro/
- Setup do React Testing Library: https://testing-library.com/docs/react-testing-library/setup
- Vitest Guide: https://vitest.dev/guide/
- Martin Fowler sobre TDD: https://martinfowler.com/bliki/TestDrivenDevelopment.html
- Martin Fowler sobre Unit Test: https://martinfowler.com/bliki/UnitTest.html

### DDD e Clean Architecture

- DDD e CQRS em .NET: https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/
- Designing a DDD-oriented microservice: https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/ddd-oriented-microservice
- Domain events em .NET: https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/domain-events-design-implementation

### Cache

- Redis Docs: https://redis.io/docs/latest/
- Redis caching: https://redis.io/solutions/use-cases/caching/
- Redis get started: https://redis.io/docs/latest/get-started/

### Mensageria

- RabbitMQ Tutorials: https://www.rabbitmq.com/tutorials
- How to use RabbitMQ: https://www.rabbitmq.com/docs/use-rabbitmq

### AWS

- AWS Well-Architected Framework: https://docs.aws.amazon.com/wellarchitected/latest/framework/welcome.html
- AWS Well-Architected overview: https://aws.amazon.com/architecture/well-architected/
- AWS Documentation: https://docs.aws.amazon.com/

## Como usar essas fontes

- Ler a documentacao principal do tema antes de ver videos
- Fazer anotacoes curtas por conceito
- Criar um mini projeto para cada assunto importante
- Voltar para a documentacao sempre que surgir duvida real no codigo

## Observacao final

Se voce quiser, no proximo passo eu posso transformar este material em um plano de 6 meses ou 12 meses com:

- metas por semana
- ordem exata de estudo
- mini projetos por etapa
- checklist de evolucao
