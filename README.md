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

### Frontend

- **Website**: Desenvolvido com **React.js** para uma interface rápida, interativa e responsiva.
- **Aplicativo Mobile (Android e iOS)**: Desenvolvido com **React Native**, permitindo a criação de aplicativos nativos para Android e, posteriormente, iOS a partir de uma base de código única.

### Backend

- **Node.js** com **Express** para a criação da API do servidor, garantindo escalabilidade e eficiência.
- **MongoDB** ou **PostgreSQL** para gerenciamento de dados, oferecendo flexibilidade e performance, dependendo da necessidade do projeto.

### Geolocalização

- **Google Maps API** ou **OpenStreetMap** para o monitoramento de localização em tempo real e cálculo de rotas.

### Pagamentos

- Integração com plataformas de pagamento como **Stripe**, **PayPal**, ou **PagSeguro** para emissão de boletos e gestão de pagamentos.

### Serviços de Hospedagem

- **AWS** ou **Google Cloud** para a infraestrutura e hospedagem de backend, com suporte a escalabilidade e integração contínua.
- **Firebase** para notificações push e autenticação de usuários (login).

### Testes

- **Jest** para testes unitários no frontend e backend.
- **Detox** ou **Appium** para testes end-to-end dos aplicativos móveis.
