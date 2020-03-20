using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.ControlesBasicos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Configuracao config;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Enviar_Clicked(object sender, EventArgs e)
        {
            if (!config.ReceberEmail)
                DisplayAlert("Mensagem", "E-mail não autorizado", "Ok");
            else
                DisplayAlert("Mensagem", string.Format("E-mail enviado para {0}", config.Email), "Ok");
        }

        void Configuracao_Clicked(object sender, EventArgs e)
        {
            if (config == null)
                config = new Configuracao();

            Navigation.PushAsync(new ConfigPage() { BindingContext = config });

        }
    }
}
