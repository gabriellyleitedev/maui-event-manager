using CadastroEventos.Models;

namespace CadastroEventos;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    [Obsolete]
    private async void OnCalcularClicked(object sender, EventArgs e)
    {
        try
        {
            // Criando o objeto evento com conversão explícita e segura das propriedades
#pragma warning disable CS8629 // Nullable value type may be null.
            Evento ev = new Evento
            {
                Nome = txt_nome.Text,
                Local = txt_local.Text,
                DataInicio = (DateTime)dtp_inicio.Date,
                DataTermino = (DateTime)dtp_termino.Date,
                NumeroParticipantes = Convert.ToInt32(txt_participantes.Text),
                CustoPorParticipante = Convert.ToDouble(txt_custo.Text)
            };
#pragma warning restore CS8629 // Nullable value type may be null.

            // Requisito 3: Repassando o objeto criado pelo BindingContext pra a nova página
            await Navigation.PushAsync(new ResumoEventoPage()
            {
                BindingContext = ev
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops!", "Preencha todos os campos corretamente: " + ex.Message, "OK");
        }
    }
}