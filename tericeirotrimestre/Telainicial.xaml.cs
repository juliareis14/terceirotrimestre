namespace tericeirotrimestre;

public partial class Telainicial : ContentPage
{

    public Telainicial()
    {
        InitializeComponent();
    }
    private void OnButtonIniciarJogoButtonClicked(object sender, EventArgs args)
    {

        Application.Current.MainPage = new MainPage();
    }
    private void OnButtonCreditosJogoButtonClicked(object sender, EventArgs args)
    {
         Application.Current.MainPage = new Telainicial();
    }

}