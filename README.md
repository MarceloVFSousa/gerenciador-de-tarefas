# Gerenciador de Tarefas

## Descrição

O **Gerenciador de Tarefas** é um sistema desktop desenvolvido em **VB.NET (Windows Forms)** que permite criar projetos e gerenciar tarefas associadas a esses projetos.

O objetivo do sistema é permitir o acompanhamento de atividades através de **status, prioridades e organização automática**, facilitando a visualização das tarefas mais importantes.

O projeto foi desenvolvido utilizando conceitos de **arquitetura em camadas**, **acesso a banco de dados**, **interface gráfica**, **front-end** e **back-end**.

---

# Funcionalidades

O sistema atualmente possui as seguintes funcionalidades:

---

## Gerenciamento de Projetos

O sistema permite:

* Criar novos projetos
* Listar projetos cadastrados
* Excluir projetos
* Exibir confirmação antes da exclusão
* Remover automaticamente todas as tarefas associadas ao projeto excluído

---

## Gerenciamento de Tarefas

Cada projeto pode possuir várias tarefas associadas.

O sistema permite:

* Criar tarefas
* Editar tarefas existentes
* Excluir tarefas individualmente
* Associar tarefas a um projeto
* Definir descrição da tarefa
* Definir status
* Definir prioridade

---

## Filtros e Busca de Tarefas

O sistema permite localizar tarefas de forma rápida através de:

* Busca por texto (título da tarefa)
* Filtro por status:

  * Pendente
  * Em andamento
  * Concluída
* Filtro por prioridade:

  * Alta
  * Média
  * Baixa

Os filtros podem ser combinados para refinar os resultados.

Também é possível limpar os filtros e retornar à listagem completa.

---

## Dashboard do Projeto

O sistema possui um dashboard simples para acompanhamento do andamento do projeto.

São exibidos:

* Total de tarefas
* Tarefas pendentes
* Tarefas em andamento
* Tarefas concluídas
* Percentual de conclusão do projeto
* Barra de progresso visual

O dashboard é atualizado automaticamente conforme as tarefas são alteradas.

---

## Status das Tarefas

As tarefas podem possuir três status:

* Pendente
* Em andamento
* Concluída

O sistema exibe contadores automáticos de tarefas:

* Total de tarefas
* Pendentes
* Em andamento
* Concluídas

Os contadores representam o estado geral do projeto independentemente dos filtros aplicados.

---

## Identificação Visual por Prioridade

As tarefas são destacadas por cores para facilitar a visualização:

| Prioridade | Cor      |
| ---------- | -------- |
| Alta       | Vermelho |
| Média      | Laranja  |
| Baixa      | Amarelo  |
| Concluída  | Verde    |

---

## Ordenação Inteligente de Tarefas

As tarefas são organizadas automaticamente seguindo a seguinte prioridade:

1. Prioridade Alta
2. Prioridade Média
3. Prioridade Baixa
4. Tarefas concluídas

Esse comportamento facilita a identificação das atividades mais importantes.

---

## Validações

O sistema possui validações para garantir a consistência dos dados:

### Projetos

* Nome obrigatório
* Nome com no mínimo 3 caracteres
* Descrição com no mínimo 5 caracteres

### Tarefas

* Título obrigatório
* Título com no mínimo 3 caracteres
* Descrição obrigatória
* Descrição com no mínimo 5 caracteres
* Status obrigatório
* Prioridade obrigatória

---

## Melhorias de Experiência do Usuário (UX)

Foram implementadas melhorias de usabilidade, incluindo:

* Mensagens de sucesso padronizadas
* Mensagens de erro padronizadas
* Confirmações de exclusão
* Destaque visual da tarefa selecionada
* Navegação simplificada entre telas
* Indicadores visuais de progresso do projeto

# Arquitetura do Projeto

O sistema foi desenvolvido utilizando **arquitetura em camadas**, separando responsabilidades entre:

# Diagramas UML

Como parte da documentação do sistema, foram desenvolvidos os seguintes diagramas:

## Diagrama de Classes

Representa a arquitetura em camadas do sistema e os relacionamentos entre entidades, serviços, repositórios e interface gráfica.

Principais elementos:

* Projeto
* Tarefa
* ProjetoService
* TarefaService
* ProjetoRepository
* TarefaRepository
* DbConnectionFactory
* frmProjetos
* frmTarefas

## Diagrama de Caso de Uso

Representa as funcionalidades disponíveis para o usuário do sistema.

Principais casos de uso:

* Criar Projeto
* Listar Projetos
* Excluir Projeto
* Criar Tarefa
* Editar Tarefa
* Excluir Tarefa
* Buscar Tarefa
* Filtrar por Status
* Filtrar por Prioridade
* Visualizar Dashboard
* Visualizar Progresso do Projeto


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

# Tecnologias utilizadas

* VB.NET
* Windows Forms
* SQL Server
* ADO.NET

---

# Autor(es)

Marcelo Vinícius Ferreira Sousa

---

# Contexto Acadêmico

Projeto desenvolvido como atividade prática da disciplina de Software Product, utilizando desenvolvimento incremental através de sprints.

Durante as entregas foram aplicados conceitos de:

* Planejamento de Sprint
* Gestão de Backlog
* Organização de Board de Desenvolvimento
* Controle de Versão com Git e GitHub
* Desenvolvimento em Camadas
* Banco de Dados Relacional
* Interface Gráfica Desktop
* Modelagem UML

Os artefatos produzidos incluem:

* Código fonte versionado no GitHub
* Board de acompanhamento das funcionalidades
* Vídeos demonstrando cada sprint
* Diagrama de Classes
* Diagrama de Caso de Uso
* Documentação técnica do projeto

