namespace CadastroEventos;

public partial class ResumoEventoPage : ContentPage
{
    public ResumoEventoPage()
    {
        InitializeComponent();
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        // Remove a página atual e volta para o formulário inicial
        await Navigation.PopAsync();
    }
}