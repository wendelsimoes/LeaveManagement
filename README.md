# Leave Management (Gerenciador de faltas)

Um projeto para teste do meu aprendizado sobre os padrões CLEAN/SOLID, temos um sistema que pode ser usado como exemplo em escolas e que gerencia as faltas e as requisições de faltas, é cadastrado o tipo de falta que pode ser desde doenças até pedidos de férias e assim por diante.

## Setup

É necessário o .NET 6 instalado na máquina e o banco de dados padrão usado é o SQL Server, mas com a ajuda da aaquitetura é muito simples de adicionar um novo banco.

Para testar a API usei o Swagger UI.

## Lições Aprendidas

Conheci o padrão SOLID para desenvolvimento de projetos, em especial o "single responsability" (responsabilidade única) onde cada classe é responsavel por uma e somente uma tarefa, como exemplo: os controllers servem de endpoint para as requests encaminhando o pedido para o domain da aplicação, ou seja, nada de regra de negócio no controller.

O padrão Clean também foi usado quando dividi a solução em multiplos projetos cada qual com sua camada na aplicação - o Domain que é responsavel por definir as entidades na sua forma original, a Application que é responsavel por definir as regras pela qual a aplicação flui, ou seja, nele estão definidos por exemplo os DTO's que substituem as entidades do Domain quando necessário mostrar ao Client o modelo tratado, como se fosse uma View-Model.

Também implementei o padrão CQRS que basicamente divide as funções de leitura e escrita sobre o banco em duas pastas para melhor organização e manutenção.

Aprendi a usar os pacotes FluentValidation e AutoMapper para respectivamente validar e ajudar na conversão de entidades e DTO's, em especifico usei o método .ReverseMap() que permite a conversão de um para outro e vice versa em ambas direções.
