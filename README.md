# Password Strength API

Esta API é uma solução simples em .NET Core 6 que permite a análise da força de senhas. Utiliza critérios como comprimento da senha, uso de caracteres especiais, números, letras maiúsculas e minúsculas para determinar a segurança de uma senha fornecida.

## Funcionalidades

- **Análise de Força de Senha**: Recebe uma senha e retorna sua pontuação de força e um nível de classificação.
- **Segurança e Privacidade**: Nenhuma senha é armazenada ou logada pela API.

## Tecnologias Utilizadas

- ASP.NET Core 6
- C#

## Requisitos

- .NET 6 SDK

## Instalação

Clone o repositório para sua máquina local usando:

```bash
git clone https://github.com/seu-usuario/password-strength-api.git
cd password-strength-api
```

## Configuração
Antes de iniciar o servidor, você pode precisar configurar variáveis de ambiente ou ajustes específicos do aplicativo no arquivo appsettings.json.

Execução
Para executar a aplicação localmente, utilize o seguinte comando no diretório do projeto:
```bash
dotnet run
```
Isso iniciará o servidor em http://localhost:5000. A API estará acessível via http://localhost:5000/api/password.

## Uso
Para analisar a força de uma senha, faça uma requisição POST para /api/password/analyze com um corpo JSON contendo a senha, como mostrado abaixo:
```json
{
  "password": "SuaSenha123!"
}
```
Você pode usar ferramentas como Postman ou cURL para fazer a requisição.

Exemplo de uso com cURL:

```bash
curl -X POST http://localhost:5000/api/password/analyze -H "Content-Type: application/json" -d "{\"password\":\"SuaSenha123!\"}"
```

## Testes
Para executar os testes, use o seguinte comando:

```bash
dotnet test
```
