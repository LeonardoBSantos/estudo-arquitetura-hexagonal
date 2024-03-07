# Estudo da arquitetura hexagonal

## Resumo de artigo
### Fonte: Cockburn, Alistair (2005-04-01). "Hexagonal architecture"
  A intenção desta arquitetura é permitir que aplicações sejam igualmente conduzidas por usuários, programas, testes automatizados ou scripts batch e desenvolvida/testada de forma isolada de seus dispositivos e bancos de dados. Como motivação, Alistair menciona o problema da infiltração de lógica de negócios no código da interface do usuário descrevendo seus 3 desdobramentos: dificuldade de testes automatizados, inflexibilidade no uso (por exemplo mudar de um uso do sistema conduzido por humanos para um sistema batch) e impossibilidade de o programa ser conduzido por outros programas. Ele ressalta os benefícios do uso de APIs: QAs podem rodar testes automatizados, negócios podem criar casos de teste antes da GUI ser finalizada e o deploy pode ser feito apenas com a API pronta.

  Para entender a natureza da solução, devemos considerar a perspectiva “dentro” e “fora” da aplicação com a regra: o código relativo à parte de dentro não deve vazar para a parte de fora da aplicação.	Devemos pensar nas portas como em um sistema operacional onde qualquer dispositivo que adere aos protocolos da porta pode ser plugado (por exemplo fone USB). Para cada agente externo existe um adaptador que converte as informações. Uma interface gráfica GUI é um exemplo de adaptador que converte movimentos da pessoa para a API da porta. Na implementação, portas e adaptadores aparecem em dois tipos chamados: condutores (Driving) e acionados (Driven), além disso, os casos de uso geralmente devem ser escritos no limite da aplicação (o hexágono interno).

## Mapa Mental 

<img src"../assets/mapa-arq-hex.jpg">

## Referências
Artigo "Hexagonal architecture" - https://alistair.cockburn.us/hexagonal-architecture/

Artigo "Organizando seu projeto .NET com Arquitetura Hexagonal — Parte 02"- https://alexalvess.medium.com/organizando-seu-projeto-net-com-arquitetura-hexagonal-parte-02-fe9a8ed6ab02

