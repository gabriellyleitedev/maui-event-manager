# Maui Event Manager

Uma aplicação multiplataforma para mobile e desktop desenvolvida com **.NET MAUI** para otimizar o cadastro de eventos, controle de cronogramas e análise de custos financeiros.

## Recursos e Arquitetura

- **Padrão MVVM**: Separação estrita de responsabilidades entre a camada visual (XAML) e a lógica de dados (C#).
- **Matriz de Custo Dinâmica**: Cálculo em tempo real do orçamento total do evento com base no número de participantes e custos por pessoa.
- **Cálculo com TimeSpan**: Manipulação estruturada de cronogramas de vários dias utilizando matrizes nativas do `System.DateTime`.
- **Ciclo de Vida de Navegação**: Persistência de estado da interface do usuário através da injeção tipada do `BindingContext` durante a navegação entre telas.

## Tecnologias Utilizadas

- **Framework:** .NET MAUI 10
- **Linguagem:** C# 13 / XAML
- **Sistemas Alvo:** Windows Machine (Compilado Nativo), Android, iOS