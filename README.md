# Maui Event Manager

Uma aplicação nativa e multiplataforma desenvolvida com **.NET MAUI** voltada para a otimização de fluxos de cadastro de eventos, gestão de cronogramas e análise preditiva de custos operacionais.

---

## 🛠️ Recursos e Arquitetura

* **Padrão MVVM (Model-View-ViewModel)**: Separação estrita de responsabilidades entre a camada de apresentação (XAML) e as regras de negócio de dados (C#).
* **Matriz de Custo Dinâmica**: Processamento e cálculo em tempo real do orçamento consolidado do evento com base na densidade de participantes e custos per capita.
* **Cálculo de Escopo Temporário**: Manipulação estruturada de cronogramas complexos utilizando cálculos com as classes `System.DateTime` e `TimeSpan`.
* **Gerenciamento de Ciclo de Vida**: Persistência e acoplamento seguro de estados da interface do usuário por meio de injeção direta via `BindingContext` nas rotas de navegação.

---

## Tecnologias e Ambiente

* **Framework:** .NET MAUI 10
* **Linguagem:** C# 13 / XAML
* **Arquiteturas Alvo:** Windows Machine (Compilado Nativo), Android API 34+, iOS

---

## Como Executar o Projeto

Para clonar e executar esta aplicação localmente, certifique-se de ter o **.NET SDK 10** instalado e execute os comandos abaixo no terminal:

```bash
# Clonar o repositório
git clone [https://github.com/gabriellyleitedev.git](https://github.com/gabriellyleitedev.git)

# Entrar no diretório do projeto
cd CadastroEventos

# Compilar e executar na plataforma Windows
dotnet run -f net10.0-windows10.0.19041.0
