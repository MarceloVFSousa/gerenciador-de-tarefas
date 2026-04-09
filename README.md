# Gerenciador de Tarefas

## Descrição

O **Gerenciador de Tarefas** é um sistema desktop desenvolvido em **VB.NET (Windows Forms)** que permite criar projetos e gerenciar tarefas associadas a esses projetos.

O objetivo do sistema é permitir o acompanhamento de atividades através de **status, prioridades e organização automática**, facilitando a visualização das tarefas mais importantes.

O projeto foi desenvolvido utilizando conceitos de **arquitetura em camadas**, **acesso a banco de dados**, **interface gráfica**, **front-end** e **back-end**.

---

# Funcionalidades

O sistema atualmente possui as seguintes funcionalidades:

### Gerenciamento de Projetos

* Criar novos projetos
* Listar projetos cadastrados
* Excluir projetos
* Ao excluir um projeto, todas as tarefas associadas também são removidas

---

### Gerenciamento de Tarefas

Cada projeto pode possuir várias tarefas associadas.

O sistema permite:

* Criar tarefas
* Associar tarefas a um projeto
* Definir descrição da tarefa
* Definir **status**
* Definir **prioridade**
* Editar uma tarefa já existente

---

### Status das tarefas

As tarefas podem possuir três status:

* **Pendente**
* **Em andamento**
* **Concluída**

O sistema também exibe contadores automáticos de tarefas:

* Total de tarefas
* Tarefas pendentes
* Tarefas em andamento
* Tarefas concluídas

---

### Identificação visual por prioridade

As tarefas são destacadas por cores para facilitar a visualização:

| Prioridade | Cor      |
| ---------- | -------- |
| Alta       | Vermelho |
| Média      | Laranja  |
| Baixa      | Amarelo  |
| Concluída  | Verde    |

---

### Ordenação automática de tarefas

As tarefas são organizadas automaticamente na tabela seguindo a seguinte prioridade:

1. Tarefas de prioridade **Alta**
2. Tarefas de prioridade **Média**
3. Tarefas de prioridade **Baixa**
4. Tarefas com status **Concluída** (sempre exibidas por último)

Isso permite visualizar rapidamente as tarefas mais importantes.

---

# Arquitetura do Projeto

O sistema foi desenvolvido utilizando **arquitetura em camadas**, separando responsabilidades entre:

### Domain

Contém as **entidades do sistema**, representando os objetos principais da aplicação.

Exemplo:

* Projeto
* Tarefa

---

### Application

Contém a **lógica de negócio** do sistema.

Responsável por:

* criação de tarefas
* validações
* comunicação entre interface e repositórios

---

### Infrastructure / Repository

Responsável pelo **acesso ao banco de dados**.

Aqui são executadas operações como:

* inserção
* consulta
* exclusão
* atualização de dados

---

### UI (Interface)

Camada responsável pela **interface gráfica do usuário**, construída com **Windows Forms**.

Principais telas:

* Tela de Projetos
* Tela de Tarefas

---

# Banco de Dados

O sistema utiliza **SQL Server** como banco de dados.

### Tabela Projeto

| Campo       | Tipo     |
| ----------- | -------- |
| Id          | INT      |
| Nome        | VARCHAR  |
| Descricao   | VARCHAR  |
| DataCriacao | DATETIME |

---

### Tabela Tarefa

| Campo       | Tipo     |
| ----------- | -------- |
| Id          | INT      |
| ProjetoId   | INT      |
| Titulo      | VARCHAR  |
| Descricao   | VARCHAR  |
| Status      | VARCHAR  |
| Prioridade  | VARCHAR  |
| DataCriacao | DATETIME |

A tabela **Tarefa** possui relacionamento com **Projeto** através da chave estrangeira:

ProjetoId → Projeto.Id

---

# Como executar o projeto

1. Clonar o repositório

```
git clone https://github.com/MarceloVFSousa/gerenciador-de-tarefas)
```

2. Abrir o projeto no **Visual Studio**

3. Configurar a conexão com o banco de dados SQL Server

4. Criar as tabelas **Projeto** e **Tarefa**

5. Executar o sistema

---

# Demonstração

Durante a apresentação do projeto foi gravado um vídeo demonstrando:

* criação de projetos
* criação de tarefas
* organização automática das tarefas
* identificação visual por prioridade
* exclusão de projetos

---

# Tecnologias utilizadas

* VB.NET
* Windows Forms
* SQL Server
* ADO.NET

---

# Autor(es)

Marcelo Vinícius Ferreira Sousa

---

# Contexto acadêmico

Projeto desenvolvido como atividade de **metodologia ágil com entregas em sprint**, incluindo:

* código fonte versionado no GitHub
* board de funcionalidades
* vídeo de demonstração da sprint
