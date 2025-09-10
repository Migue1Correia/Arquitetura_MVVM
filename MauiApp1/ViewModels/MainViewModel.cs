using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Linq;

using System.Runtime.CompilerServices;

using System.Text;

using System.Threading.Tasks;

namespace MauiApp1.ViewModels

{

    // ViewModel para conversar com a MainPage.xaml (minha View)

    public class MainViewModel : INotifyPropertyChanged

    // Quando uma propriedade for alterada, o ViewModel avisa a View (MainPage.xaml)

    {

        private string _nome;

        private string _saudacao;

        // Propriedade que vai conversar com nosso Entry' (MainPage.xaml)

        public string Nome

        {

            get => _nome;

            set

            {

                if (_nome != value)

                {

                    _nome = value;

                    OnPropertyChanged(); // Notifica a View que a propriedade mudou

                    CumprimentarCommand.ChangeCanExecute(); // Atualiza o estado do comando

                }

            }

        }

        // Propriedade que vai conversar com nosso Label (MainPage.xaml)

        public string Saudacao

        {

            get => _saudacao;

            set

            {

                if (_saudacao != value)

                {

                    _saudacao = value;

                    OnPropertyChanged(); // Notifica a View que a propriedade mudou

                }

            }

        }

        public Command CumprimentarCommand { get; }

        // Comando para o botão Cumprimentar

        public MainViewModel()

        {

            // Define o que o Command faz e quando executar.

            CumprimentarCommand = new Command(

                execute: () =>

                {

                    // Ação do comando de mostrar a saudação

                    Saudacao = $"Olá, {Nome}!";

                },

                canExecute: () =>

                {

                    return !string.IsNullOrWhiteSpace(Nome);

                    // Habilita o botão se o Nome não for vazio

                });

        }

        //Suporte do meu biding

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));




    }

}

