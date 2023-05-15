# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descritas por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos os artefatos criados (código fonte) além das estruturas de dados utilizadas e as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Para cada requisito funcional, pode ser entregue um artefato desse tipo

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)

# API 
## Arquitetura do software

O desenvolvimento do software durante o projeto teve como objetivo utilizar as tecnologias apresentadas na Seção Especificações do Projeto, em conjunto com uma arquitetura de software simples, modular, escalável e de fácil manutenção. O software foi desenvolvimento em 4 pacotes escritos em C#: o Database, Controller, Entities e Services.

### Database

Banco de dados desenvolvido na tecnologia NoSQL (bando de dados não relacional) utilizando-se do SGDB MongoDB para o desenvolvimento da arquitetura e aplicação da base de dados.

### Controller

O pacote Controller é responsável por lidar com cada requisição recebida pelo framework Dotnet Core 6.0, definindo as rotinas que serão executadas. Cada método descrito no Controller exerce as funções de tradução de JSON para uma estrutura em C#, realiza a validação dos dados, executa o serviço necessário e retorna para o cliente a devida resposta para a requisição. 

### Entities

O pacote Entities é o pacote onde estão descritos todos recursos acessíveis da aplicação em estruturas do C#. Ou seja, descreve os dados e seus tipos, que serão acessados e manipulados pela API e, consequentemente, devido à utilização do ORM, também define a estrutura dos dados no banco de dados. Esta dupla responsabilidade dos modelos unifica a representação dos dados e simplifica o desenvolvimento da aplicação, com uma representação única dos dados estruturados manipulados pela API e dos dados armazenados no banco de dados não relacional.

### Services

A camada de Serviços consiste em uma interface capaz de realizar serviços para múltiplos usuários com diferentes interfaces. O pacote Services aplicada ao padrão de projeto, que define uma camada de serviços. Foi implementado no pacote métodos que define as regras de negócio da aplicação independente das ferramentas utilizadas. Ou seja, caso futuramente estas ferramentas sejam modificadas ou substituídas, a lógica da aplicação se mantem inalterada.

### CRUD dos elementos

O monitoramento e gestão da rede exige diversas funcionalidades. O escopo do projeto vai além do tempo de desenvolvimento atual, portanto como prioridade definida pela equipe, o foco inicial está na CRUD dos elementos da rede. Para cada elemento foram utilizados os verbos HTTP e tiveram como guia de design da API o design REST. O desenvolvimento das operações de CRUD seguiu a padronização descrita abaixo, com o nome de cada elemento no endpoints em inglês.

### Criando um elemento

A criação de um elemento pode ser realizada ao enviar uma requisição HTTP utilizando o método POST para o endpoint /elemento, com o elemento incluído no corpo da requisição um JSON com todas as informações do elemento a ser adicionado e o seu identificador. A resposta da requisição, em caso de sucesso, retorna o elemento criado em formato JSON.

### Obtendo um ou mais elementos

Para se obter um elemento deve-se enviar uma requisição HTTP utilizando o método GET para o endpoint /elemento/identificador. A resposta da requisição, em caso de sucesso, retorna o elemento criado em formato JSON. Também foi implementada a listagem de todos os elementos, para tal, deve-se realizar uma requisição HTTP utilizando o método GET para o endpoint /elemento.

### Editando um elemento

A edição de um elemento pode ser realizada ao enviar uma requisição HTTP utilizando o método PUT para o endpoint /elemento/identificador, adicionando no corpo da requisição um JSON com as novas informações do elemento. A resposta da requisição, em caso de sucesso retorna o elemento editado em formato JSON. 

### Apagando um ou mais elementos

Para apagar um elemento deve-se realizar uma requisição HTTP utilizando o método DELETE para o endpoint /elemento/identificador. Também foi implementada a ação de apagar diversos elementos, para tal, deve-se realizar uma requisição HTTP utilizando o método DELETE para o endpoint /elemento com os identificadores em um vetor dentro do corpo da requisição.
