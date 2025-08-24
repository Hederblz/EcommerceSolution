# 🛒 EcommerceSolution - InventoryService

Projeto desenvolvido em **.NET 9** com **MySQL** e **Entity Framework Core**, simulando a parte de **Gestão de Estoque** de uma plataforma de e-commerce.  

O objetivo é fornecer APIs para **cadastrar, consultar, atualizar e excluir produtos**, utilizando boas práticas de arquitetura e organização de código.  

---

## 🚀 Tecnologias Utilizadas

- [.NET 9](https://dotnet.microsoft.com/)
- [ASP.NET Core Web API](https://learn.microsoft.com/aspnet/core)
- [Entity Framework Core 9](https://learn.microsoft.com/ef/core/)
- [MySQL](https://www.mysql.com/)
- [Pomelo.EntityFrameworkCore.MySql](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql)
- [Swagger / Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)

---

## 📦 Estrutura do Projeto

A solução é organizada em microsserviços, cada um com sua responsabilidade específica.

### 📈 InventoryService/ (Microserviço de Estoque)

Este serviço é responsável por gerenciar o inventário de produtos.

- **`Controllers/`**: Contém os **endpoints da API** para interagir com o serviço de estoque.
- **`Data/`**: Inclui o **`DbContext`** e as configurações relacionadas ao banco de dados.
- **`Models/`**: Define as **entidades do domínio**, como `Product`, `Order` e `OrderItem`.
- **`Migrations/`**: Armazena o **histórico das migrações** do Entity Framework Core.
- **`Program.cs`**: O ponto de entrada principal, responsável pela **configuração da aplicação**.
- **`appsettings.json`**: Contém **configurações** essenciais, como a string de conexão do banco de dados.


---


