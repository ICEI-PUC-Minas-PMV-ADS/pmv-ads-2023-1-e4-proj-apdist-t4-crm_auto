# Plano de Testes de Software

<!-- <span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Enumere quais cenários de testes foram selecionados para teste. Neste tópico o grupo deve detalhar quais funcionalidades avaliadas, o grupo de usuários que foi escolhido para participar do teste e as ferramentas utilizadas.-->


- Plano de testes de software usado para testar o sistema _CRMOBIL_. Ele inclui uma lista de cenários de testes que foram selecionados para avaliar diferentes funcionalidades da aplicação. Além disso, o plano inclui informações sobre as ferramentas utilizadas para realizar os testes, bem como sobre o grupo de usuários escolhido para participar dos testes. Essa abordagem ajuda a garantir que a aplicação esteja funcionando corretamente e atenda aos requisitos estabelecidos. O uso de ferramentas como Selenium e Postman pode melhorar a eficiência e a precisão dos testes, permitindo que os desenvolvedores e testadores encontrem e corrijam problemas com mais rapidez.


**Funcionalidades Avaliadas**

**1**. Visualização do andamento do serviço<br>
**2**. Adicionar um novo serviço<br>
**3**. Enviar orçamento para o cliente<br>

**Grupos de Usuários Envolvidos nos Testes**

**1.** Clientes<br>
**2.** Funcionários da oficina


| Funcionalidade<br>Avaliada | Grupo de<br>usúarios | Cenário de Teste |Ferramentas Utilizadas|
| ---                     |    ----           |          ---     |               ---          |
|Visualização do<br>andamento do<br>serviço   |Clientes         |Cliente faz login no aplicativo móvel e<br>visualiza o status atual do serviço em<br>tempo real.|Selenium|         
|Adicionar um<br>novo serviço|Funcionários<br>da oficina|Funcionário da oficina faz login na<br>aplicação web, adiciona um novo serviço<br>ao veículo do cliente e verifica se o status<br>do serviço é atualizado corretamente.|Selenium,<br>Postman|
|Enviar orçamento<br>para o cliente|Funcionários<br>da oficina|Funcionário da oficina faz login na<br>aplicação web, gera um orçamento para o<br>serviço do veículo do cliente e envia o<br>orçamento para o cliente através do aplicativo móvel. O cliente verifica se o orçamento foi recebido corretamente.|Selenium,<br>Postman|

**Estratégia de Testes**

**Os testes serão realizados em duas fases:**
 - Testes de unidade: Os desenvolvedores realizarão testes de unidade para garantir que<br>cada funcionalidade esteja funcionando corretamente individualmente.
 - Testes de integração: Depois que todas as funcionalidades forem implementadas, serão realizados testes de integração para garantir que as diferentes partes do sistema estejam funcionando juntas de maneira adequada.
 
 **Critérios de Aceitação**<br>
 
 **Os seguintes critérios de aceitação foram definidos para cada cenário de teste:**<br>
 
 **1.** Visualização do andamento do serviço:

- O cliente deve ser capaz de visualizar o status do serviço em tempo real.
- O status do serviço deve ser atualizado corretamente na aplicação móvel.

**2.** Adicionar um novo serviço:

- O funcionário da oficina deve ser capaz de adicionar um novo serviço ao veículo do cliente.
- O status do serviço deve ser atualizado corretamente na aplicação web.

**3.** Enviar orçamento para o cliente:

- O funcionário da oficina deve ser capaz de gerar um orçamento para o serviço do veículo do cliente.
- O orçamento deve ser enviado com sucesso para o cliente através do aplicativo móvel.
- O cliente deve ser capaz de visualizar o orçamento recebido corretamente.

 
## Ferramentas de Testes (Opcional)

**Selenium:** Selenium é uma ferramenta de automação de testes de software que permite aos desenvolvedores e testadores automatizar ações repetitivas em um navegador da web.O Selenium é uma ferramenta poderosa e flexível para automação de testes de software web, permitindo aos testadores automatizar as tarefas repetitivas de teste, economizar tempo e recursos, aumentar a eficiência dos testes e melhorar a qualidade do software.

**Postaman:** O Postman é uma aplicação de desktop que funciona em várias plataformas, como Windows, macOS e Linux. Ele oferece uma interface gráfica do usuário (GUI) intuitiva e fácil de usar que permite aos usuários criar solicitações HTTP e ver as respostas em tempo real. O Postman pode ser usado para enviar solicitações HTTP, como GET, POST, PUT, DELETE, PATCH, entre outros.

Além de enviar solicitações HTTP, o Postman também pode ser usado para testar APIs de forma mais avançada, como definir cabeçalhos personalizados, autenticar solicitações, simular erros de rede, monitorar desempenho, entre outras funcionalidades.

<!--Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)--
