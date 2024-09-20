using terceirotrimestre;

public class Gerenciador

{  
   List<Questao> ListaQuestoes=new List<Questao>();
   List<int> ListaQuestaosRespondidas=new List<int>();
   Questao QuestaoAtual;

   public Gerenciador (Label labelPerg, Button ButtonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4, Button ButtonResposta5)

   {
     CriaPerguntas (labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
     ProximaQuestao();
   }
    
  
   void CriaPerguntas(Label labelPerg, Button ButtonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4, Button ButtonResposta5)
   {
    
      var Q1= new Questao();
      Q1.ConfiguraDesenho (labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
      Q1.Pergunta="Quanto é 2+2?";
      Q1.Resposta01="2";
      Q1.Resposta02="22";
      Q1.Resposta03="4";
      Q1.Resposta04="6";
      Q1.Resposta05="0";
      Q1.RespostaCorreta= 3;
      listaQuestoes.Add (Q1);

}
    public async void VerificaCorreta(int RR)
    {
      if (QuestaoCorrente.VerificaCorreta (RR))
      {
        await Task.Delay(1000);
        ProximaQuestao();

      }
    }
     void ProximaQuestao()
       {
        var numAleat= Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(numAleat))
         numAleat=Random.Shared.Next(0, ListaQuestoes.Count);
         ListaQuestoesRespondidas.Add(numAleat);
         QuestaoCorrente=ListaQuestoes[numAleat];
         QuestaoCorrente.Desenhar();    
       }




}

