using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XF.Recursos.Exemplo
{
    public class ClasseViewModel
    {
        public string Nome { get; set; }
        public ICommand EventoOK { get; set; }
        public EventoAdicionar EventoAdd { get; set; }

        public ClasseViewModel()
        {
            EventoOK = new Command(Mensagem);
            EventoAdd = new EventoAdicionar(this);
        }

        public void Mensagem()
        {
            App.Current.MainPage.DisplayAlert("Atenção", "Olá Xamarin", "OK");
        }
    }

    public class EventoAdicionar : ICommand
    {
        ClasseViewModel viewModel;
        public EventoAdicionar(ClasseViewModel vm)
        {
            viewModel = vm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.Mensagem();
        }
    }
}
