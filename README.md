# Hermap

**Hermap** é um aplicativo de transporte coletivo particular, projetado para empresas, universidades e serviços de transporte compartilhado que buscam uma solução moderna e eficiente para gerenciar rotas e passageiros. Inspirado no deus grego Hermes, protetor dos viajantes, o Hermap oferece funcionalidades avançadas para otimizar viagens, monitorar trajetos em tempo real e gerenciar pagamentos e reservas de maneira integrada.

## Funcionalidades Principais

### Para Passageiros
O usuário comum utiliza o Hermap para:
- **Localizar e reservar serviços de transporte**: visualizar rotas e horários disponíveis.
- **Acompanhar o trajeto em tempo real**: monitorar a localização do motorista e o status da viagem.
- **Realizar pagamentos**: efetuar pagamentos de forma prática e segura pelo aplicativo.

### Para Motoristas
Os motoristas podem:
- **Criar e gerenciar itinerários**: definir pontos de embarque e desembarque, otimizar rotas conforme a localização dos passageiros.
- **Controlar o financeiro**: acompanhar pagamentos, emitir boletos e realizar saques.
- **Consultar histórico de viagens**: acesso detalhado ao histórico de viagens realizadas.

### Para Empresas
Empresas têm a facilidade de:
- **Criar oportunidades de transporte**: disponibilizar transporte para funcionários com horários e locais predefinidos.
- **Cadastrar e gerenciar funcionários**: adicionar funcionários que utilizarão o serviço de transporte e acompanhá-los em cada trajeto.
- **Acompanhar o trajeto em tempo real**: monitorar a localização do motorista e o progresso do transporte de funcionários.
- **Efetuar pagamentos**: processar pagamentos de forma integrada e prática.

### Gerenciamento Integrado
O Hermap gerencia internamente as ações do sistema, incluindo:
- **Cálculo de rotas e trajetos**: otimização contínua dos percursos.
- **Notificações em tempo real**: atualizações de status enviadas para passageiros, motoristas e empresas.
- **Processamento de pagamentos**: integração com plataformas para recebimentos e saques.

## Benefícios do Hermap

- **Eficiência no Transporte**: Gestão de rotas e passageiros para otimização do tempo de viagem.
- **Acompanhamento em Tempo Real**: Visualização da localização do transporte por motoristas, empresas e passageiros.
- **Gestão Financeira Simplificada**: Processamento de pagamentos e saques diretamente no app.
- **Segurança e Confiabilidade**: Cadastro seguro de todos os usuários e histórico detalhado de viagens.

## Resumo
O Hermap é uma solução completa para mobilidade urbana compartilhada, promovendo a conectividade entre motoristas, passageiros e empresas de maneira prática e inovadora.



## Tecnologias a serem estudadas

- **Frontend Web**: [Blazor WebAssembly](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) para acesso via navegador em computadores.
- **Frontend Mobile**: [Xamarin](https://dotnet.microsoft.com/apps/xamarin) / [.NET MAUI](https://dotnet.microsoft.com/apps/maui) para o desenvolvimento dos aplicativos Android e iOS.
- **Backend**: [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet) para a criação da API que gerencia rotas, passageiros e transações financeiras.
- **Banco de dados**: [SQL Server](https://www.microsoft.com/sql-server) ou [Azure SQL Database](https://azure.microsoft.com/en-us/services/sql-database/) para armazenamento de dados.
- **Geolocalização**: Integração com APIs como [Bing Maps API](https://www.microsoft.com/en-us/maps) ou [Google Maps API](https://developers.google.com/maps).
- **Pagamentos**: Integração com [Stripe](https://stripe.com), [PayPal](https://www.paypal.com) ou [PagSeguro](https://pagseguro.uol.com.br), utilizando [Azure Functions](https://azure.microsoft.com/en-us/services/functions/) para processar pagamentos e emitir boletos.
- **Monitoramento em tempo real**: [SignalR](https://dotnet.microsoft.com/apps/aspnet/signalr) para comunicação em tempo real entre o servidor e os dispositivos, permitindo o acompanhamento de trajetos em tempo real.
- **Hospedagem**: [Azure App Services](https://azure.microsoft.com/en-us/services/app-service/) para hospedar o backend e os serviços de API.

