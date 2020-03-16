<h1>Descrição</h1>
<p>O marvel-app se baseia na API da Marvel (https://developer.marvel.com/docs#!/public/).
Foi implementado uma forma simplificada dos enpoints /characters
Há possibilidade de obter os dados de duas fontes de dados diferentes:</p>
<ul>
  <li> API da Marvel (requer conexão com a internet) através da rota <b>/api/personagemapi/...</b></li>
  <li> Banco de dados local (não requer conexão com a internet) através da rota <b>/api/personagemdb/...</b></li>
</ul>

<h1>Stack</h1>
<p>Foram utilizados neste desenvolvimento:</p>
<ul>
  <li>.NET Core 3.1</li>
  <li>PostgreSQL 12.2</li>  
  <li>xUnit</li>
  <li>RestSharp</li>
  <li>Swagger</li>
  <li>Dapper</li>
</ul>

<h1>Pré-requisitos</h1>
<p>Para utilizar o app offline, é necessário <b>instalar</b> a última versão do <b>PostgreSQL</b> (https://www.postgresql.org/download/).
Ao instalar o PostgreSQL é recomendado manter as configurações padrão (porta, usuário, etc).</p>

<p>Após instalar o PostgreSQL é necessário criar o banco de dados "marvel" e criar a estrutura e inserção de dados das tabelas (instruções abaixo)
  
<h1>Criando o banco de dados, tabelas e inserindo dados</h1>
<p>Utilizar o "SQL Shell" para criar o database 'marvel' com o comando:</p>

```
CREATE DATABASE marvel;
```
<p>Em seguida criar as tabelas e inserir dados utilizando o SQL do arquivo <b>sql-estrutura.txt</b></p>

<h1>Como executar a API</h1>
<p>Clonar o repositório em sua máquina local</p>
<p>Abrir a Solution no Visual Studio <b>(marvel-app/back-end/Marvel/Marvel.sln)</b></p>
<p>Alterar a senha do PostgresSQL no arquivo <b>appsettings.json</b>
<p>Ao rodar a aplicação, o sistema irá automaticamente abrir o <b>Swagger</b> para que os testes possam ser feitos</p>
<p>Como mencionado anteriormente, foram feitos 2 controllers. Um se conecta à API do site da Marvel para obter os dados e o outro se conecta ao banco de dados local. Localmente foram copiados para o banco apenas os dados dos personagens com <b>Ids 1011334 e 1009150</b>, portanto, é recomendado utilizar estes dois Ids para o teste</p>
<p>É possível utilizar também o <b>Postman</b> para testes, seguem os links (copiar em Postman > File > Import > Import from link):</p>
<ul>
  <li>Rotas para controller API Online (Dados do site da Marvel): https://www.getpostman.com/collections/3bad862eb4c38492a1bb</li>
  <li>Rotas para controller PostgreSQL (Dados do banco de dados local): https://www.getpostman.com/collections/9e26359c9873f0c5f2d8</li>
</ul>
