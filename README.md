# Hermap

**Hermap** é um aplicativo de transporte inteligente, projetado para facilitar o gerenciamento de rotas e passageiros para empresas, universidades e outros serviços de transporte compartilhado. Inspirado no deus grego Hermes, conhecido como o protetor dos viajantes, Hermap oferece uma solução moderna e eficiente para otimizar viagens, monitorar trajetos em tempo real e gerenciar finanças de maneira integrada.

## Funcionalidades Principais

- **Localização em tempo real**: Acompanhe a localização exata da van e saiba a previsão de chegada.
- **Controle de itinerários**: Gerenciamento detalhado de rotas, horários e locais de embarque e desembarque.
- **Confirmação de presença**: Passageiros podem confirmar ou desmarcar sua viagem de maneira rápida e fácil.
- **Gerenciamento de passageiros**: Controle total de passageiros por viagem, com cadastro e histórico de viagens.
- **Rotas automáticas**: Criação automática de rotas baseadas no local de embarque e desembarque de cada passageiro.
- **Gestão financeira**: Emissão de boletos, controle de pagamentos e posição financeira de cada passageiro.
- **Divulgação de serviços**: Facilita o contato entre motoristas/empresas e potenciais clientes, promovendo seus serviços.

## Funcionalidades Futuras

- **Avaliação de motoristas e empresas**: Sistema de feedback dos usuários para garantir qualidade no serviço.
- **Serviços diferenciados**: Cadastro de serviços personalizados conforme as necessidades dos passageiros e empresas.

## Tecnologias Utilizadas

- **Frontend Web**: [Blazor WebAssembly](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) para acesso via navegador em computadores.
- **Frontend Mobile**: [Xamarin](https://dotnet.microsoft.com/apps/xamarin) / [.NET MAUI](https://dotnet.microsoft.com/apps/maui) para o desenvolvimento dos aplicativos Android e iOS.
- **Backend**: [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet) para a criação da API que gerencia rotas, passageiros e transações financeiras.
- **Banco de dados**: [SQL Server](https://www.microsoft.com/sql-server) ou [Azure SQL Database](https://azure.microsoft.com/en-us/services/sql-database/) para armazenamento de dados.
- **Geolocalização**: Integração com APIs como [Bing Maps API](https://www.microsoft.com/en-us/maps) ou [Google Maps API](https://developers.google.com/maps).
- **Pagamentos**: Integração com [Stripe](https://stripe.com), [PayPal](https://www.paypal.com) ou [PagSeguro](https://pagseguro.uol.com.br), utilizando [Azure Functions](https://azure.microsoft.com/en-us/services/functions/) para processar pagamentos e emitir boletos.
- **Monitoramento em tempo real**: [SignalR](https://dotnet.microsoft.com/apps/aspnet/signalr) para comunicação em tempo real entre o servidor e os dispositivos, permitindo o acompanhamento de trajetos em tempo real.
- **Hospedagem**: [Azure App Services](https://azure.microsoft.com/en-us/services/app-service/) para hospedar o backend e os serviços de API.

