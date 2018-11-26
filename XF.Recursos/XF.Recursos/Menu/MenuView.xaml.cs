using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Recursos.App_Code;

namespace XF.Recursos.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuView : ContentPage
	{
        public ListView ListView { get { return lstMenu; } }
        public MenuView()
        {
            InitializeComponent();

            ObservableCollection<OpcoesMenu> menuItems = 
                new ObservableCollection<OpcoesMenu>();
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Home",
                Icone = "Home.png",
                TargetType = typeof(HomeView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Editor",
                TargetType = typeof(Controles.EditorView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Controle de Data",
                TargetType = typeof(Controles.PickerView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "List Picker",
                TargetType = typeof(Controles.ListPickerView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Stepper",
                TargetType = typeof(Controles.StepperView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Controle de Progresso",
                TargetType = typeof(Controles.ProgressoView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Uso do Command",
                TargetType = typeof(Exemplo.CommandView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Estilo Dinâmico",
                TargetType = typeof(Estilo.DinamicoView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Triggers",
                TargetType = typeof(Estilo.TriggersView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Lista Produtos",
                TargetType = typeof(Lista.ProdutoView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Theme",
                TargetType = typeof(Theme.ThemeView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Messaging Center",
                TargetType = typeof(PassParameter.MCHomeView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Custom Renderer",
                TargetType = typeof(CustomControl.CustomView)
            });
            lstMenu.ItemsSource = menuItems;
        }
    }
}