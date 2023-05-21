# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado em um plano de testes pré-definido.

## Avaliação

Discorra sobre os resultados do teste. Ressaltando pontos fortes e fracos identificados na solução. Comente como o grupo pretende atacar esses pontos nas próximas iterações. Apresente as falhas detectadas e as melhorias geradas a partir dos resultados obtidos nos testes.

Ao executar a aplicação, o usuário deverá fazer login como Colaborador, preenchendo todos os campos solicitados. EM seguida A opção "Salvar" deve ser selecionada:


### CT -01: Registro de Login:

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e4-proj-apdist-t4-crm_auto/assets/92118593/fbc073dc-af20-4a97-9994-ead4c09a7c21)


### CT-02: Login usuário

Após clicar em "Salvar", o usuário é direcionado à página de "login Usuário" da oficina. As informações devem ser corretamente preenchidas. Após isso, clicar em "Salvar".

**Objetivo:** Verificar se o usuário consegue logar no sistema.

**Passos:** 1. Acessar a página principal;<br>                                                                                                             2. Clicar em ENTRAR na lateral direita da parte superior da página;<br>                                                    3. No campo EMAIL digitar o email que foi utilizado ao fazer o cadastro;<br>                                                                       4. No campo Senha digitar a senha que foi cadastrada

![img1](./img/registo%20CT-01.png)
![img1](./img/registo%20CT-01.2.png)

No MongoDB CRMOBILDB.Funcionarios a aplicação é apresenta da seguinte forma:

Se as informações forem preenchidas corretamente, o sistema deve armazenar um novo registro no banco de dados, contendo as informações fornecidas pelo usuário:

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e4-proj-apdist-t4-crm_auto/assets/92118593/05dfa1df-3319-4210-bfa4-bd0913d9a42e)


###CT -03: Cadastro de Serviço 

Selecionando o Menu Serviços no Painel de Controle

o formulário de cadastro é apresentado da seguinte forma:

Na página de cadastro de serviço, as informações devem ser corretamente preenchidas. Após isso, clicar em "Ok".

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e4-proj-apdist-t4-crm_auto/assets/92118593/57e93afa-6c9b-49aa-a4e0-9ef3a9f342e3)

No MongoDB ordem_servico na aplicação é apresentada da seguinte forma:

Se as informações forem preenchidas corretamente, o sistema deve armazenar um novo registro no banco de dados, contendo as informações fornecidas pelo usuário:

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e4-proj-apdist-t4-crm_auto/assets/92118593/d2b1c14a-5cb1-4adc-b0ec-9b721afed152)

No mongoBB.usuarios é apresentada da seguinte forma:

Se as informações forem preenchidas corretamente, o sistema deve armazenar um novo registro no banco de dados, contendo as informações fornecidas pelo usuário:

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e4-proj-apdist-t4-crm_auto/assets/92118593/3f354697-9fa8-466d-a8bb-55f0cc773232)

### CT- 04: Contato Cliente

Essa funcionalidade permite que os usuários entrem em contato com a equipe de suporte do CRMobil por meio de tais informações como: Nome ,empresa(caso possua) ,telefone e e-mail(caso possua), como números de telefone. Esse formulário de conto é salvo pelo cliente no campo enviar e os dados serão encaminhados para o suporte.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e4-proj-apdist-t4-crm_auto/assets/92118593/917cfb94-03c0-4efe-9d04-d00a7e1afb96)

> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
