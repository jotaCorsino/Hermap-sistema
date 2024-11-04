# Hermap

**Hermap** é um aplicativo de transporte coletivo particular, projetado para facilitar o gerenciamento de rotas e passageiros para empresas, universidades e outros serviços de transporte compartilhado. Inspirado no deus grego Hermes, conhecido como o protetor dos viajantes, Hermap oferece uma solução moderna e eficiente para otimizar viagens, monitorar trajetos em tempo real e gerenciar finanças de maneira integrada.

# Hermap: Funcionalidades e Estrutura do App

## 1. Usuário Comum (Estudante ou Não)
O usuário comum utiliza o app para encontrar e reservar serviços de transporte.

### Funcionalidades:
- **Busca por Serviços de Transporte**: O usuário pode procurar serviços de transporte fixo (trabalho, universidade) e viagens em grupo.
- **Consulta de Itinerários Disponíveis**: Visualizar itinerários cadastrados pelos motoristas, com detalhes de horários e pontos de embarque.
- **Reserva de Vaga**: Reservar vaga em grupos de transporte conforme disponibilidade definida pelo motorista.
- **Pagamento e Histórico**: Efetuar pagamento via app e acompanhar o histórico de viagens e pagamentos.
- **Notificações e Atualizações**: Receber atualizações em tempo real sobre o status da van e horário previsto de chegada.

## 2. Motorista
O motorista utiliza o app para cadastrar e gerenciar seus serviços de transporte e itinerários.

### Funcionalidades:
- **Cadastro de Itinerários e Serviços**: Criar novos itinerários, definir número de passageiros, horários e pontos de embarque/desembarque.
- **Gerenciamento de Passageiros**: Organizar e gerenciar passageiros, incluindo confirmação de presença e histórico de viagens.
- **Organização de Rotas**: Otimizar a rota com base nos locais de embarque/desembarque dos passageiros.
- **Controle de Pontos de Embarque/Desembarque**: Gravar o horário em que o motorista passa por cada ponto de embarque.
- **Gestão de Pagamentos**: Acompanhar pagamentos recebidos, emitir boletos e verificar status financeiro dos passageiros.
- **Serviços Diversificados**: Cadastro de viagens em grupo e serviços de entrega.

## 3. Empresa
As empresas usam o app para criar oportunidades de transporte para seus funcionários.

### Funcionalidades:
- **Criação de Oportunidades de Transporte**: Divulgar necessidade de transporte com horários e locais de embarque/desembarque próximos aos funcionários.
- **Busca por Motoristas**: Encontrar motoristas que ofereçam serviços compatíveis com as necessidades da empresa.
- **Gerenciamento de Transporte de Funcionários**: Acompanhar em tempo real o status do transporte e visualizar o histórico de viagens.
- **Integração com Motoristas**: Criar parcerias com motoristas para serviços recorrentes, como transporte diário de funcionários.

## 4. Gestão e Organização de Serviços (Motorista)
O app facilita a organização e gerenciamento dos serviços de transporte para os motoristas.

### Funcionalidades:
- **Organização de Horários**: Definir horários de partida e chegada com flexibilidade para ajustar às necessidades dos passageiros.
- **Controle de Pontos de Embarque/Desembarque**: Definir pontos de embarque otimizados com base na localização dos passageiros.
- **Histórico de Viagens**: Registrar o histórico completo de viagens com horários, pontos de embarque e desembarque.
- **Pagamentos e Controle Financeiro**: Gerenciar recebimentos, emitir boletos e processar pagamentos via integração com plataformas (Stripe, PagSeguro, etc.).

## 5. Resumo da Solução
O **Hermap** é uma plataforma que conecta motoristas, usuários e empresas de forma eficiente para facilitar:
- A busca por serviços de transporte;
- O gerenciamento de serviços por motoristas, com otimização de rotas e gestão de passageiros;
- A criação de oportunidades de transporte por empresas, com monitoramento de status e histórico de viagens.

As funcionalidades cobrem desde transporte fixo (diário) até serviços de viagem em grupo e entregas, tornando o **Hermap** uma solução completa para mobilidade.


## Tecnologias Utilizadas

- **Frontend Web**: [Blazor WebAssembly](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) para acesso via navegador em computadores.
- **Frontend Mobile**: [Xamarin](https://dotnet.microsoft.com/apps/xamarin) / [.NET MAUI](https://dotnet.microsoft.com/apps/maui) para o desenvolvimento dos aplicativos Android e iOS.
- **Backend**: [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet) para a criação da API que gerencia rotas, passageiros e transações financeiras.
- **Banco de dados**: [SQL Server](https://www.microsoft.com/sql-server) ou [Azure SQL Database](https://azure.microsoft.com/en-us/services/sql-database/) para armazenamento de dados.
- **Geolocalização**: Integração com APIs como [Bing Maps API](https://www.microsoft.com/en-us/maps) ou [Google Maps API](https://developers.google.com/maps).
- **Pagamentos**: Integração com [Stripe](https://stripe.com), [PayPal](https://www.paypal.com) ou [PagSeguro](https://pagseguro.uol.com.br), utilizando [Azure Functions](https://azure.microsoft.com/en-us/services/functions/) para processar pagamentos e emitir boletos.
- **Monitoramento em tempo real**: [SignalR](https://dotnet.microsoft.com/apps/aspnet/signalr) para comunicação em tempo real entre o servidor e os dispositivos, permitindo o acompanhamento de trajetos em tempo real.
- **Hospedagem**: [Azure App Services](https://azure.microsoft.com/en-us/services/app-service/) para hospedar o backend e os serviços de API.

