# Diagrama de Caso de Uso do Hermap

O diagrama representa os principais atores e casos de uso do sistema de transporte, que abrange funcionalidades voltadas para **usuários comuns**, **motoristas**, **empresas** e o **sistema de pagamento**. Há também a presença de uma **API de Geolocalização** para funcionalidades relacionadas à localização e otimização de rotas.

---

## Atores

### 1. Usuário Comum
Usuários comuns utilizam o sistema para procurar e reservar transporte, além de gerenciar suas reservas e pagamentos.

### 2. Motorista
Motoristas têm a responsabilidade de gerenciar seus itinerários, passageiros, e manter o controle sobre os recebimentos e saques.

### 3. Empresa
Empresas utilizam o sistema para encontrar motoristas, criar oportunidades de transporte para seus funcionários, e monitorar o transporte em tempo real.

### 4. Sistema de Pagamento
O sistema de pagamento é um ator representado no diagrama para simplificar o fluxo financeiro entre os usuários e os motoristas.

### 5. API de Geolocalização
A API de Geolocalização oferece funcionalidades para monitorar e otimizar rotas, garantindo uma melhor eficiência no transporte.

---

## Casos de Uso por Ator

### Usuário Comum
- **Consultar Itinerário**: Visualizar o itinerário dos motoristas disponíveis.
- **Reservar Vaga**: Reservar uma vaga em um transporte específico.
- **Buscar Transporte**: Procurar transporte conforme necessidade.
- **Receber Notificações**: Receber notificações sobre o transporte reservado.
- **Efetuar Pagamento**: Realizar o pagamento pelo serviço de transporte.
- **Acompanhar Histórico de Viagens e Pagamentos**: Verificar o histórico de viagens e pagamentos realizados.

### Motorista
- **Gerenciar Passageiros**: Gerenciar os passageiros que reservaram o transporte.
- **Solicitar Saque**: Solicitar o saque dos valores disponíveis no saldo.
- **Emitir Boletos**: Emitir boletos de cobrança para os usuários.
- **Visualizar Pagamentos**: Visualizar os pagamentos recebidos dos usuários.
- **Consultar Saldo**: Consultar o saldo disponível referente aos pagamentos.
- **Cadastrar Itinerários**: Cadastrar os itinerários das rotas que o motorista irá realizar.
- **Organizar Rota**: Organizar a rota de embarque e desembarque dos passageiros.
- **Monitorar Localização**: Monitorar a localização do veículo durante o transporte.

### Empresa
- **Buscar Motoristas**: Buscar motoristas disponíveis no sistema.
- **Efetuar Pagamento**: Realizar o pagamento pelo transporte oferecido aos funcionários.
- **Monitorar Transporte em Tempo Real**: Acompanhar o transporte em tempo real, garantindo que os funcionários estejam no trajeto correto.
- **Gerenciar Parcerias com Motoristas**: Estabelecer e gerenciar parcerias com motoristas para transporte recorrente.
- **Criar Oportunidades para Motoristas**: Criar novas oportunidades de trabalho para motoristas, baseando-se nas necessidades de transporte dos funcionários.

### Sistema de Pagamento
- **Processar Pagamento**: Gerenciar o processamento dos pagamentos feitos pelos usuários.
- **Emitir Confirmações de Pagamento**: Enviar confirmações de pagamento aos usuários após a conclusão da transação.
- **Processar Repasse ao Motorista**: Processar o repasse dos valores recebidos aos motoristas.
- **Atualizar Saldo do Motorista**: Atualizar o saldo do motorista após o processamento de um pagamento ou saque.
- **Processar Saque**: Realizar o processamento de saque dos motoristas, conforme solicitado.

### API de Geolocalização
- **Otimizar Rotas**: Otimizar a rota do transporte com base na localização dos passageiros.
- **Fornecer Localização em Tempo Real**: Fornecer dados de localização em tempo real para motoristas e empresas.

---

## Resumo

O diagrama de caso de uso apresenta um sistema robusto de transporte, onde usuários comuns, motoristas e empresas interagem de forma eficiente com o auxílio de um sistema de pagamento e uma API de geolocalização. 

- **Usuários Comuns**: Focam em pesquisar, reservar e pagar pelo transporte.
- **Motoristas**: Gerenciam o itinerário, passageiros e o controle financeiro.
- **Empresas**: Realizam busca de motoristas e monitoram o transporte para seus funcionários.
- **Sistema de Pagamento**: Facilita as transações financeiras de maneira automatizada.
- **API de Geolocalização**: Melhora a eficiência das rotas e garante o monitoramento em tempo real.

Esse sistema tem o potencial de aprimorar significativamente a logística de transporte, oferecendo uma experiência otimizada para todos os envolvidos.
