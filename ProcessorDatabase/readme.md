# ProcessorDatabase

Aplica��o Console de gerenciamento de processadores (CPUs) com armazenamento em Mem�ria RAM. Desenvolvido em linguagem funcional e aproveitando os recursos-chave deste paradigma.

## Ferramentas utilizadas
- F# 4.7
- .NET Core 3.1

## Componentes
- `Application`: Container de estados e direcionamento de fluxo geral;
- `Model`: Tipos de dados;
- `Presenter`: Formata��es visuais reutiliz�veis;
- `Program`: Ponto de entrada;
- `Service`: Manipula��o de dados;
- `UserInterface`: Fluxo de intera��o com usu�rio.

## Application
Direciona a entrada nas funcionalidades do sistema atrav�s da fun��o `run()` que abriga um pattern matching de `MenuOption`.<br />
Dado que � recursiva, t�o logo que uma funcionalidade termina seu fluxo, a execu��o volta para o menu.<br />
Cont�m tamb�m as vari�veis `processors` e `lastId` que controlam o estado dos processadores armazenados para toda a aplica��o.

## Model
Abriga todos os tipos complexos utilizados. S�o eles: <br />
- `MenuOption`: Discriminated Union. Cont�m as funcionalidades existentes no sistema;<br />
- `Processor`: Type. Re�ne todas as informa��es de um dado processador.

## Presenter
Centraliza fun��es de formata��o visual que s�o utilizadas diversas vezes em `UserInterface`.<br />
Algumas fun��es s�o realmente simples, mas justificam sua exist�ncia por tornar o c�digo mais idiom�tico.<br />
A constru��o do c�digo privilegiou uso de pattern matching, composi��o e fun��es de alta ordem.

## Program
Ponto de entrada da aplica��o. Dispara a fun��o recursiva `run()` de `Application`.

## Service
Centraliza as opera��es de armazenamento, escolha e exclus�o de processadores.<br />
Opera��es de filtragem fazem uso de express�es lambda e opera��es de procura fazem uso da m�nada `Option`, retornando algum `Processor` ou `None`.

## UserInterface
O "recheio" da aplica��o, onde as etapas de cada uma das funcionalidades escolhidas no menu se desdobram.<br />
Opera��es com potencial de falha por entrada incorretas do usu�rio fazem uso de pattern matching com `Some` e `None`.

## Screenshots
* [Menu de op��es](https://raw.githubusercontent.com/marcomvidal/ProcessorDatabase/master/screenshot_menu.png)
* [Cadastro de processadores](https://raw.githubusercontent.com/marcomvidal/ProcessorDatabase/master/screenshot_create.png)
* [Listagem de processadores](https://raw.githubusercontent.com/marcomvidal/ProcessorDatabase/master/screenshot_summary.png)
