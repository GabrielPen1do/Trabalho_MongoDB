Este repositório contém um projeto ASP.NET MVC, com integração ao MongoDB usando o **MongoDB Driver para .NET**. A aplicação já está configurada para conectar-se ao MongoDB, e você pode seguir os passos abaixo para clonar o repositório, configurar seu ambiente e conectar ao banco de dados.

## Pré-requisitos

Antes de começar, certifique-se de ter os seguintes itens instalados:

- [Visual Studio 2022](https://visualstudio.microsoft.com/) com suporte ao ASP.NET
- [.NET SDK](https://dotnet.microsoft.com/download)
- [MongoDB](https://www.mongodb.com/try/download/community) (instalado e em execução localmente ou utilizando MongoDB Atlas)
- Git
- **MongoDB.Driver para .NET** (instruções abaixo)
- Um arquivo JSON contendo os dados que você deseja importar para o MongoDB

## Como Clonar o Repositório

1. Abra seu terminal (ou Git Bash no Windows) e navegue até o diretório onde deseja clonar o projeto.
2. Execute o seguinte comando para clonar o repositório:

   ```bash
   git clone <URL-do-repositorio>
   ```
3. Após a clonagem, navegue até a pasta do projeto:

  ```bash
     cd <nome-da-pasta-do-repositorio>
  ```

## Configurando o MongoDB Driver
Esta aplicação usa o MongoDB.Driver para se conectar ao banco de dados MongoDB. Se você ainda não tem o driver instalado, siga os passos abaixo:

Instalando o MongoDB.Driver
No Visual Studio 2022, abra o Gerenciador de Pacotes NuGet.

Pesquise pelo pacote MongoDB.Driver e instale a versão mais recente.


## Configurando o MongoDB
A aplicação está configurada para se conectar a um banco de dados MongoDB. Para garantir que você consiga acessar os dados, siga as instruções abaixo:

Certifique-se de que o MongoDB está rodando localmente ou configure um banco MongoDB Atlas.

Dentro do arquivo appsettings.json (ou no arquivo de configuração do seu ambiente), configure a string de conexão para o MongoDB. Substitua os valores conforme necessário:

"ConnectionStrings": {
  "MongoDbConnection": "mongodb://localhost:27017/<nome-do-seu-banco-de-dados>"
}


## Executando a Aplicação
Abra o projeto no Visual Studio 2022.
Compile o projeto para garantir que todas as dependências estão instaladas corretamente.
No Visual Studio, pressione Ctrl + F5 ou clique em Run para iniciar a aplicação.
Problemas Conhecidos
Certifique-se de que a string de conexão para o MongoDB está corretamente configurada.
Verifique se o MongoDB está rodando antes de tentar iniciar a aplicação.



