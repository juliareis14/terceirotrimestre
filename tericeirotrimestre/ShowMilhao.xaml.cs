namespace tericeirotrimestre;

public partial class ShowMilhao : ContentPage
{
	

	public ShowMilhao()
	{
		InitializeComponent();
	}
 
  
 private void BotaoIniciarFoiClicado(object sender, EventArgs args)
  {
      Application.Current.ShowMilhao = new MainPage();
  }
}