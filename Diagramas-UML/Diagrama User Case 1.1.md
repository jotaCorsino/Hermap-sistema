## Atores

### 1. Passageiro
Usuários comuns utilizam o sistema para procurar e reservar transporte, além de gerenciar suas reservas e pagamentos.

### 2. Motorista
Cadastra-se, cria rotas, acompanha rotas em tempo real, consulta histórico de rotas e realiza saques.

### 3. Empresa
Cadastra-se, acompanha rota em tempo real, consulta histórico de rotas, cadastra funcionários, cria demandas de transporte, busca rotas e efetua pagamento.

### 4. Sistema 
 Responsável por realizar as ações internas do sistema, como cálculos de rotas, notificações e gerenciar pagamentos, etc.
 
---

## Casos de Uso por Ator

### Usuário Passageiro
- **Cadastrar-se**: Se cadastra no sistema com Nome, idade, CPF, Email, Telefone e Endereço.
- **Acompanhar rota em tempo real**: Acompanha a localização do motorista na rota.
- **Consultar histórico de rotas**: Pode consultar em seu perfil o histórico de rotas por viagem, com data e local variando com o horário no percurso, hora e local de embarque e desembarque.
- **Buscar Rota**: Pode pesquisar por rotas disponiveis, cadastradas por motoristas, cada rota tem: Nome do motorista, placa do veículo, valor mensal, quantidade de vagas disponiveis, destino e horario de chegada.
- **Efetuar Pagamento**: Realizar o pagamento pelo serviço de transporte.

### Usuário Empresa
- **Cadastrar-se**: Se cadastra no sistema com Nome, CNPJ, ADM/setor responsavel(nome, cargo, CPF, email, telefone) e Endereço.
- **Cadastrar Funcionário**: Cada empresa pode cadastrar seus funcionários(nome, CPF, telefone, endereço) que forem usufruir do serviço de transporte e cadastrar esses usuarios em "Oportunidades"
- **Criar Oportunidade**: Cada empresa pode criar uma oportunidade, deixando seus dados e a quantidade de passageiros, fornecendo uma lista com endereços para ser gerenciado pelo motorista.
- **Acompanhar rota em tempo real**: Acompanha a localização do motorista na rota.
- **Consultar histórico de rotas**: Pode consultar em seu perfil o histórico de rotas por viagem, com data e local variando com o horário no percurso, hora e local de embarque e desembarque.
- **Buscar Rota**: Pode pesquisar por rotas disponiveis, cadastradas por motoristas, cada rota tem: Nome do motorista, placa do veículo, valor mensal, quantidade de vagas disponiveis, destino e horario de chegada.
- **Efetuar Pagamento**: Realizar o pagamento pelo serviço de transporte.

### Usuário Motorista
- **Cadastrar-se**: Se cadastra no sistema com Nome, CNPJ/CPF, veiculo(s)(placa e quantidade de vagas), Email, Telefone e Endereço.
- **Criar Rotas**: O motorista pode criar rotas para destinos especificos, estipulando um valor mensal, quantidade de vagas, frequancia semanal e horario de chegada.
- **Acompanhar rota em tempo real**: Acompanha a localização do motorista na rota.
- **Consultar histórico de rotas**: Pode consultar em seu perfil o histórico de rotas por viagem, com data e local variando com o horário no percurso, hora e local de embarque e desembarque.
- **Efetuar Saque**: Realizar o saque dos pagamentos mensais.
