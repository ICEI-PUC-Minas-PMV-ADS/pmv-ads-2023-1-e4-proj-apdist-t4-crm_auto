# Plano de Testes de Software

Plano de testes de software usado para testar o sistema _CRMOBIL_. Ele inclui uma lista de cenários de testes que foram selecionados para avaliar diferentes funcionalidades da aplicação. Além disso, o plano inclui informações sobre as ferramentas utilizadas para realizar os testes, bem como sobre o grupo de usuários escolhido para participar dos testes. Essa abordagem ajuda a garantir que a aplicação esteja funcionando corretamente e atenda aos requisitos estabelecidos. O uso de ferramentas como Selenium e Postman pode melhorar a eficiência e a precisão dos testes, permitindo que os desenvolvedores e testadores encontrem e corrijam problemas com mais rapidez.



**Funcionalidades Avaliadas**

**1**. Visualização do andamento do serviço<br>
**2**. Adicionar um novo serviço<br>
**3**. Enviar orçamento para o cliente<br>

**Grupos de Usuários Envolvidos nos Testes**

**1.** Clientes<br>
**2.** Funcionários da oficina




| Funcionalidade<br>Avaliada                 | Grupo de<br>usúarios       | Cenário de Teste                                             | Ferramentas Utilizadas |
| ------------------------------------------ | -------------------------- | ------------------------------------------------------------ | ---------------------- |
| Visualização do<br>andamento do<br>serviço | Clientes                   | Cliente faz login no aplicativo móvel e<br>visualiza o status atual do serviço em<br>tempo real. | Swagger               |
| Adicionar um<br>novo serviço               | Funcionários<br>da oficina | Funcionário da oficina faz login na<br>aplicação web, adiciona um novo serviço<br>ao veículo do cliente e verifica se o status<br>do serviço é atualizado corretamente. | MongoDB,<br>Swagger   |
| Enviar orçamento<br>para o cliente         | Funcionários<br>da oficina | Funcionário da oficina faz login na<br>aplicação web, gera um orçamento para o<br>serviço do veículo do cliente e envia o<br>orçamento para o cliente através do aplicativo móvel. O cliente verifica se o orçamento foi recebido corretamente. | MongoDB,<br>Swagger |

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

**MongoDB/Swagger:** O Swagger é usado no desenvolvimento de APIs para documentar e testar as funcionalidades da API de forma padronizada.Ele também permite que os profissionais possam testar as APIs de forma mais consistente e segura, sendo uma de suas principais aplicações de forma prática.

**MongoDB:** O MongoDB é um banco de dados de documentos com a escalabilidade e flexibilidade que você deseja junto com a consulta e indexação que você precisa .O modelo documental do MongoDB é simples para os desenvolvedores aprenderem e utilizarem, ao mesmo tempo em que oferece todas as capacidades necessárias para atender aos requisitos mais complexos em qualquer escala.


A seguir, apresentamos os casos de testes de software para avaliação do sistema. Todos os testes estão associados a um ou mais requisitos funcionais. 



| Caso de Teste         | CT-01 - Efetuar login                                        |
| --------------------- | ------------------------------------------------------------ |
| Requisitos associados | RF-01 O sistema deve permitir que os usuários façam cadastro e login. |
| Objetivo do teste     | Verificar o funcionamento correto do login de usuário        |
| Passos                | 1. Acessar a página principal;<br>                                                                                                             2. Clicar em ENTRAR na lateral direita da parte superior da página;<br>                                                    3. No campo EMAIL digitar o email que foi utilizado ao fazer o cadastro;<br>                                                                       4. No campo Senha digitar a senha que foi cadastrada |
| Critérios de Êxito   | • Se o registro de usuário existir no banco de dados, o sistema deve permitir que o usuário acesse o sistema. Se as informações de login e senha estiverem incorretas, a página de login é recarregada para que os campos sejam preenchidos novamente. |



| Caso de Teste         | CT-03 - Registro de Oficina                                  |
| --------------------- | ------------------------------------------------------------ |
| Requisitos associados | RF-03 O sistema deve permitir a inserção, edição e exclusão de registros da oficina |
| Objetivo do teste     | Verificar o funcionamento correto do CRUD do cadastro de oficina |
| Passos                | 1. Fazer login no sistema;<br>                                                                                                                             2. No menu de navegação, clicar em oficina;<br>                                                                                          3. Preencher os campos com os dados da oficina;<br>                                                                         4. Clicar em salvar;<br> |
| Critérios de Êxito   |• Mensagem 200 após o preenchimento e execução                 |



| Caso de Teste         | CT-04 - CRUD de serviços                                     |
| --------------------- | ------------------------------------------------------------ |
| Requisitos associados | RF-04 O sistema deve permitir a inserção, edição e exclusão de um novo serviço disponibilizado pela oficina. |
| Objetivo do teste     | Verificar o funcionamento correto do CRUD de serviços        |
| Passos                | 1. Fazer login no sistema; <br>                                                                                                                      2. No menu de navegação clicar em Serviços;<br>                                                                                 3. Clicar no botão editar serviço;<br>                                                                                                            4. Preencher corretamente o formulário de cadastro;<br>                                                                  4. Clicar em salvar; |
| Critérios de Êxito   | • Após a inserção ser efetuada, as informações inseridas no formulário devem ser registradas no banco de dados |



| Caso de Teste         | CT-05 - Consulta de clientes da oficina                                     |
| --------------------- | ------------------------------------------------------------ |
| Requisitos associados | O sistema deve permitir a consulta dos clientes cadastrados. |
| Objetivo do teste     | Verificar se o sistema permite ao funcionário visualizar dados de um cliente quando necessário.        |
| Passos                | 1. Fazer login no sistema; <br>                                                                                                                      2. Ir para a lista de clientes;<br>                                                                                 3. Buscar clientes pelo nome, CNPJ ou CPF;<br>                                                                                                            4. Clicar sobre o nome do cliente para visualizar historico ou pêndencais;|
| Critérios de Êxito   | • Os dados de cliente deverão ser exibidos para o funcionário |









<!--Comente sobre as ferramentas de testes utilizadas.

> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)--
