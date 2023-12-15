# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução Implementada
Neste projeto, implementei um sistema em .NET para a abstração de smartphones, seguindo os princípios da programação orientada a objetos. O foco foi a criação de classes específicas para dois tipos de celulares: Nokia e iPhone, derivadas da classe abstrata Smartphone.

Estrutura do Código
Classe Abstrata Smartphone:

Serve como base para as classes Nokia e Iphone.
Define a estrutura básica de um smartphone, incluindo atributos como número, modelo, IMEI e memória.
Classe Nokia:

Herda de Smartphone.
Implementa métodos específicos para celulares da marca Nokia, como InstalarAplicativo.
Inclui funcionalidades como ligar, enviar mensagens de texto e instalar aplicativos.
Classe Iphone:

Herda de Smartphone.
Personaliza o comportamento para dispositivos iPhone, com métodos sobrescritos como InstalarAplicativo.
Possui funcionalidades como ligar, receber chamadas e instalar aplicativos.
Funcionalidades Implementadas
Teste com Smartphone Nokia:

Criação de um objeto Nokia com atributos específicos como número, modelo, IMEI e memória.
Execução de métodos como ligar, instalar o aplicativo "Whatsapp" e enviar mensagens de texto.
Teste com Smartphone Iphone:

Criação de um objeto Iphone com características definidas, como número, modelo, IMEI e memória.
Realização de ações como ligar, instalar o aplicativo "Facebook" e receber chamadas.
