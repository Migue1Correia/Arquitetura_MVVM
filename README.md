HelloMvvmMaui

Aplicativo exemplo em .NET MAUI utilizando o padrão MVVM (Model-View-ViewModel).
Este projeto demonstra como criar uma interface simples que interage com o usuário por meio de data binding e commands, facilitando a separação de responsabilidades entre a interface e a lógica de negócios.

🚀 Funcionalidades

Entrada do nome do usuário.

Botão que dispara um comando (Command) no ViewModel.

Exibição de uma saudação personalizada baseada no nome digitado.

Estruturação do projeto seguindo boas práticas do padrão MVVM.

🗂 Estrutura do Projeto
HelloMvvmMaui/
│
├── ViewModels/
│   └── MainViewModel.cs        # Contém a lógica de negócios e propriedades bindadas à UI
│
├── Views/
│   └── MainPage.xaml            # Layout da página principal
│   └── MainPage.xaml.cs         # Code-behind que conecta a View ao ViewModel
│
├── Models/                      # (Opcional) Classes de domínio ou dados
│
├── App.xaml                      # Configuração geral do aplicativo
└── App.xaml.cs                    # Inicialização do app

🛠 Tecnologias Utilizadas

.NET MAUI (Multi-platform App UI)

C# 10/11

MVVM (Model-View-ViewModel)

Visual Studio 2022 ou superior

📋 Pré-requisitos

Antes de rodar este projeto, certifique-se de ter instalado:

Visual Studio 2022
 com a workload de .NET MAUI habilitada.

.NET SDK 8.0 ou superior

Emulador ou dispositivo físico para testes:

Android

iOS

Windows (WinUI)

🔧 Como Executar

Clone este repositório

git clone https://github.com/seu-usuario/HelloMvvmMaui.git
cd HelloMvvmMaui


Restaure os pacotes do projeto

dotnet restore


Compile e execute

dotnet build
dotnet run


💡 No Visual Studio, basta abrir a solução (.sln), selecionar a plataforma de destino e clicar em Run ▶️.

🧩 Funcionamento

O MainViewModel contém as propriedades Nome e Saudacao, além do comando CumprimentarCommand.

A View (MainPage.xaml) utiliza data binding para se conectar ao ViewModel.

Quando o usuário digita um nome e clica no botão, o comando é executado, atualizando a saudação automaticamente.

Fluxo:

Usuário digita o nome no Entry.

O texto é passado via binding para a propriedade Nome no MainViewModel.

Ao clicar no botão, o comando CumprimentarCommand é executado.

A propriedade Saudacao é atualizada.

O Label mostra automaticamente a saudação personalizada.

🖥 Demonstração do Layout
-----------------------------
Digite seu Nome:
[ Entry Aqui ]

[ Botão Cumprimentar ]

Saudação exibida aqui!
-----------------------------

📚 Conceitos aplicados

MVVM (Model-View-ViewModel):

View (MainPage.xaml): apenas define a interface do usuário.

ViewModel (MainViewModel.cs): contém toda a lógica e dados, usando INotifyPropertyChanged.

Model: não utilizado neste exemplo, mas serve para representar dados da aplicação.

Data Binding: vincula propriedades da UI diretamente ao ViewModel.

Commands: permitem que botões e outros elementos disparem ações sem código no code-behind.

🤝 Contribuição

Sinta-se à vontade para contribuir com melhorias:

Faça um fork do projeto.

Crie uma branch com sua feature:

git checkout -b minha-feature


Faça commit das alterações:

git commit -m "Minha nova feature"


Envie a branch:

git push origin minha-feature


Abra um Pull Request.

📜 Licença

Este projeto está sob a licença MIT.
Consulte o arquivo LICENSE
 para mais detalhes.
