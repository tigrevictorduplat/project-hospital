# Projeto Hospital
 ## Sumário
 - [**Objetivo**](/README(pt-br).md/#objetivo)
 - [**Descrição**](/README(pt-br).md/#descrição)
 - [**Demonstrações**](/README(pt-br).md/#demonstração-do-programa)
 - [**Janelas do Sistema**](/README(pt-br).md/#janelas-do-sistema)
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
# Demonstração do Programa
#### ADMConnection Form
<video width=60% alt="Demonstração ADM Conncetion" src="https://user-images.githubusercontent.com/98099656/228383875-c5ba088c-b148-4af8-89f0-c2a03d9b27c1.mp4"></video>

#### Menu Principal
<video width=60% alt="Demonstração Menu Principal" src="https://user-images.githubusercontent.com/98099656/228383935-8313269d-6f62-4de2-a515-0981eda174d6.mp4"></video>

***
# Janelas do Sistema