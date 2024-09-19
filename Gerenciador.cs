public class Gerenciador
{
   List<Questao> ListaQuestoes=new List<Questao>();
   List<int> ListaQuestaosRespondidas=new List<int>();
   Questao QuestaoAtual;

   public Gerenciador (Label labelPerg, Button ButtonResposta1, Button ButtonResposta2 Button ButtonResposta3, Button ButtonResposta4, Button ButtonResposta5);
   {
     CriaPerguntas (labelperg, ButtonResposta1, ButtonResposta2 ButtonResposta3, ButtonResposta4, ButtonResposta5);
   }
  
     void CriaPerguntas(Label labelPerg, Button ButtonResposta1, ButtonResposta2 ButtonResposta3, ButtonResposta4, ButtonResposta5);


}