# BACKEND

Esse projeto foi gerado utilizando ASP.NET CORE na version 3.1

Para executar a aplicação, basta pelo diretório: `cd BACKEND/API` e inserir o comando `dotnet run` no terminal.

# FRONTEND

Esse projeto foi gerado utilizando [Angular CLI](https://github.com/angular/angular-cli) version 8.3.23.

## Development server

Para executar a aplicação, basta pelo diretório: `cd FRONTEND`e inserir o comando `ng serve` ou `ng s` no terminal para compilar a aplicação.

Navegue até o endereço: `http://localhost:4200/`.
O aplicativo será recarregado automaticamente se você alterar qualquer um dos arquivos de origem.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

## Running unit tests

Execute `ng test` para executar os testes de unidade via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Execute `ng e2e` para executar os testes de unidade via [Protractor](http://www.protractortest.org/).

#ALGUMAS MELHORIAS POSSIVEIS:
--> Mensagens de alertas quando os dados forem carregados, quando o botão de gerar campeonato for selecionado (submetendo a requisição ou não, caso não, com a justificativa). OBS.: Eu usaria o componente de notificações na versão material. Usei esses componentes ao invés dos componentes tradicionais do bootstrap. Não muda muita coisa, mas acho a estilização mais atrativa, mais bonita.

--> Criar o recurso de loading para ser exibido durante o carregamento de páginas e afins.

--> Em um projeto mais complexo, o correto era criar o recurso de lazy loading. Nesse eu não me preocupei com isso porque são apenas duas telinhas no front que não demandam tantos recursos no carregamento.

--> Uma API em um sistema comercial pede por um esquema de segurança, portanto, em um projeto mais complexo se torna imprescindível a construção de um (não foi o caso desse);
