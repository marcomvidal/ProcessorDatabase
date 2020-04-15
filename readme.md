# ProcessorDatabase

Aplicação Console de gerenciamento de processadores (CPUs) com armazenamento em Memória RAM. Desenvolvido em linguagem funcional e aproveitando os recursos-chave deste paradigma.

## Ferramentas utilizadas
- F# 4.7
- .NET Core 3.1

## Componentes
- `Application`: Container de estados e direcionamento de fluxo geral;
- `Model`: Tipos de dados;
- `Presenter`: Formatações visuais reutilizáveis;
- `Program`: Ponto de entrada;
- `Service`: Manipulação de dados;
- `UserInterface`: Fluxo de interação com usuário.

## Application
Direciona a entrada nas funcionalidades do sistema através da função `run()` que abriga um pattern matching de `MenuOption`.<br />
Dado que é recursiva, tão logo que uma funcionalidade termina seu fluxo, a execução volta para o menu.<br />
Contém também as variáveis `processors` e `lastId` que controlam o estado dos processadores armazenados para toda a aplicação.

## Model
Abriga todos os tipos complexos utilizados. São eles: <br />
- `MenuOption`: Discriminated Union. Contém as funcionalidades existentes no sistema;<br />
- `Processor`: Type. Reúne todas as informações de um dado processador.

## Presenter
Centraliza funções de formatação visual que são utilizadas diversas vezes em `UserInterface`.<br />
Algumas funções são realmente simples, mas justificam sua existência por tornar o código mais idiomático.<br />
A construção do código privilegiou uso de pattern matching, composição e funções de alta ordem.

## Program
Ponto de entrada da aplicação. Dispara a função recursiva `run()` de `Application`.

## Service
Centraliza as operações de armazenamento, escolha e exclusão de processadores.<br />
Operações de filtragem fazem uso de expressões lambda e operações de procura fazem uso da mônada `Option`, retornando algum `Processor` ou `None`.

## UserInterface
O "recheio" da aplicação, onde as etapas de cada uma das funcionalidades escolhidas no menu se desdobram.<br />
Operações com potencial de falha por entrada incorretas do usuário fazem uso de pattern matching com `Some` e `None`.

## Screenshots
* [Menu de opções](https://raw.githubusercontent.com/marcomvidal/ProcessorDatabase/master/screenshot_menu.png)
* [Cadastro de processadores](https://raw.githubusercontent.com/marcomvidal/ProcessorDatabase/master/screenshot_create.png)
* [Listagem de processadores](https://raw.githubusercontent.com/marcomvidal/ProcessorDatabase/master/screenshot_summary.png)
