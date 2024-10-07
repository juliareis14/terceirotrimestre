﻿namespace tericeirotrimestre;

public partial class MainPage : ContentPage
{
    Gerenciador gerenciador;

	private int clickcount;

    public MainPage()
    {
        InitializeComponent();
        gerenciador= new Gerenciador(labelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5, Pontuacao, Nivel);
    }   

    void ButtonResposta1Clicked(object sender, EventArgs args)
	{
	    gerenciador.VerificaCorreta(1);
	}
	void ButtonResposta2Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(2);
	}
	void ButtonResposta3Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(3);
	}
	void ButtonResposta4Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(4);
	}
	void ButtonResposta5Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(5);
	}
 	private void ButtonVoltarButtonClicked(object sender, EventArgs args)
	{

		Application.Current.MainPage = new Telainicial();
	}
	void OnAjudaRetiradaClicked(object s, EventArgs e)
	{
		var ajuda = new RetiraErradas();
		ajuda.ConfiguraDesenho(ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(s as Button).IsVisible=false;
	}
	void OnAjudaPulaClicked (object s, EventArgs e)
	{
		gerenciador.ProximaQuestao();	
		clickcount++;
		if (clickcount>=3)
		(
			(sender as Button).IsVisible=false;
		
		)
		else 
		(
			(sender as Button).IsVisible=true;
		
		)	
		
		 
	}

	void OnAjudaUniversitariosClicked(object s, EventArgs e)
	{
		var ajuda = new Universitarios();
		ajuda.ConfiguraDesenho(ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(s as Button).IsVisible=false;
	}

}

