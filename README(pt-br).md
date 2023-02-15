# Projeto Hospital
 ## Sumário
 - [**Objetivo**](/README.md/#objetivo)
 - [**Descrição**](/README.md/#descrição)
 - [**Diário do Projeto**](/README.md/#diário-do-projeto)
  ***

## Objetivo 🎯
Este é um projeto feito para simular um sistema de recepção de um Hospital, esse projeto contempla:
- Cadastro de Cliente
- Cadastro de Usuário
Sendo eles:
    - Médico
    - Paciente
    - Empresa/Colaborador

Através de uma integração entre *Banco de Dados Relacional*(**MySQL**) e *Janelas de Forms*(**C#**), teremos um sistema básico para o cadastro de clientes e para o uso dos serviços disponíveis. 
## Descrição 🖊️

### Tabela Cliente
Tabela que guarda as informações dos eventuais clientes (no caso, pacientes) do Hospital.

Campo | Tipo do Dado | +
---|---|---
⭐CPF| VARCHAR(11) | Chave Primária
Nome Cliente | VARCHAR(45) |---
Data de Registro | DATE TIME | ---
Plano de Saúde | VARCHAR(45) | Poder ser nulo

### Tabela Usuário
Tabela que guarda as informações dos possívei usuários (médicos, pacientes recorrentes, empresas ou beneficiários) do Hospital.

Campo | Tipo do Dado | +
---|---|---
⭐ID | INT | Chave Primária (Auto Incremento)
Nome Usuário | VARCHAR(45) |---
Senha | VARCHAR(45) | ---
Data de Registro | DATE TIME | ---
Tipo de Usuário | VARCHAR(45) | ---

### Tabela Serviços
Tabela que guarda as informações dos serviços disponíveis (Exames, Consultas, Laboratório, Pronto-Socorro) do Hospital.

Campo | Tipo do Dado | +
---|---|---
⭐ID | INT | Chave Primária (Auto Incremento)
Nome Serviço | VARCHAR(45) |---
Descrição Serviço | VARCHAR(45) | ---
Preço do Serviço |DOUBLE(6,2) | (Default = 0.00)

### Relacionamento Ciente-Serviço (Tabela Agendamento)
Campo | Tipo do Dado | +
---|---|---
⭐ID | INT | Chave Primária (Auto Incremento)
Data do Agendamento | DATE TIME |---
Descrição Serviço | VARCHAR(45) | ---
🔑 ID Cliente | VARCHAR(11) | Chave Estrangeira
🔑 ID Serviço | INT | Chave Estrangeira

***
## Diário do Projeto 📝

### Dia 1
- [X] Criação do Banco de Dados e das Tabelas Principais
    - [X] Tabela Cliente
    - [X] Tabela Usuário
    - [X] Tabela Serviços
    - [X] Tabela Agendamento (Cliente-Serviço)
- [X] Criação do Projeto C#
    - [X] Janela Principal
    - [X] Janela Cadastro
        - [X] Aba Cliente
        - [X] Aba Usuário
    - [X] Janela Agendamento
