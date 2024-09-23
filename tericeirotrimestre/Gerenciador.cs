using terceirotrimestre;
using tericeirotrimestre;

public class Gerenciador

{
  List<Questao> ListaQuestoes = new List<Questao>();
  List<int> ListaQuestoesRespondidas = new List<int>();
  Questao QuestaoAtual;

  public Gerenciador(Label labelPerg, Button ButtonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4, Button ButtonResposta5)

  {
    CriaPerguntas(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    ProximaQuestao();
  }


  void CriaPerguntas(Label labelPerg, Button ButtonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4, Button ButtonResposta5)
  {

    
    var Q1 = new Questao();
    Q1.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q1.Pergunta = "Qual é o maior oceano do mundo?";
    Q1.Resposta1 = "Atlântico";
    Q1.Resposta2 = "Pacífico";
    Q1.Resposta3 = "Índico";
    Q1.Resposta4 = "Ártico";
    Q1.Resposta5 = "Antártico";
    Q1.Respostacorreta = 2;
    ListaQuestoes.Add(Q1);


    var Q2 = new Questao();
    Q2.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q2.Pergunta = "Qual país tem o formato de uma bota?";
    Q2.Resposta1 = "Brasil";
    Q2.Resposta2 = "Itália";
    Q2.Resposta3 = "Inglaterra";
    Q2.Resposta4 = "Rússia";
    Q2.Resposta5 = "Egito";
    Q2.Respostacorreta = 2;
    ListaQuestoes.Add(Q2);


    var Q3 = new Questao();
    Q3.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q3.Pergunta = "Quem pintou a Mona Lisa?";
    Q3.Resposta1 = "Vincent van Gogh";
    Q3.Resposta2 = "Leonardo da Vinci";
    Q3.Resposta3 = "Pablo Picasso";
    Q3.Resposta4 = "Claude Monet";
    Q3.Resposta5 = "Salvador Dalí";
    Q3.Respostacorreta = 2;
    ListaQuestoes.Add(Q3);


    var Q4 = new Questao();
    Q4.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q4.Pergunta = "Qual é o planeta mais próximo do Sol?";
    Q4.Resposta1 = "Vênus";
    Q4.Resposta2 = "Terra";
    Q4.Resposta3 = "Marte";
    Q4.Resposta4 = "Mercúrio";
    Q4.Resposta5 = "Júpiter";
    Q4.Respostacorreta = 4;
    ListaQuestoes.Add(Q4);


    var Q5 = new Questao();
    Q5.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q5.Pergunta = "Qual a capital da França?";
    Q5.Resposta1 = "Berlim";
    Q5.Resposta2 = "Madri";
    Q5.Resposta3 = "Roma";
    Q5.Resposta4 = "Paris";
    Q5.Resposta5 = "Lisboa";
    Q5.Respostacorreta = 4;
    ListaQuestoes.Add(Q5);


    var Q6 = new Questao();
    Q6.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q6.Pergunta = "Qual elemento químico tem o símbolo 'O'?";
    Q6.Resposta1 = "Oxigênio";
    Q6.Resposta2 = "Ouro";
    Q6.Resposta3 = "Prata";
    Q6.Resposta4 = "Ozônio";
    Q6.Resposta5 = "Carbono";
    Q6.Respostacorreta = 1;
    ListaQuestoes.Add(Q6);


    var Q7 = new Questao();
    Q7.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q7.Pergunta = "Qual é o maior país em extensão territorial?";
    Q7.Resposta1 = "China";
    Q7.Resposta2 = "Canadá";
    Q7.Resposta3 = "Estados Unidos";
    Q7.Resposta4 = "Brasil";
    Q7.Resposta5 = "Rússia";
    Q7.Respostacorreta = 5;
    ListaQuestoes.Add(Q7);


    var Q8 = new Questao();
    Q8.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q8.Pergunta = "Qual é a fórmula química da água?";
    Q8.Resposta1 = "H2O";
    Q8.Resposta2 = "O2";
    Q8.Resposta3 = "CO2";
    Q8.Resposta4 = "CH4";
    Q8.Resposta5 = "HCl";
    Q8.Respostacorreta = 1;
    ListaQuestoes.Add(Q8);


    var Q9 = new Questao();
    Q9.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q9.Pergunta = "Em que ano o homem pisou na Lua pela primeira vez?";
    Q9.Resposta1 = "1969";
    Q9.Resposta2 = "1970";
    Q9.Resposta3 = "1965";
    Q9.Resposta4 = "1975";
    Q9.Resposta5 = "1980";
    Q9.Respostacorreta = 1;
    ListaQuestoes.Add(Q9);


    var Q10 = new Questao();
    Q10.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q10.Pergunta = "Qual é a capital do Brasil?";
    Q10.Resposta1 = "Rio de Janeiro";
    Q10.Resposta2 = "São Paulo";
    Q10.Resposta3 = "Salvador";
    Q10.Resposta4 = "Brasília";
    Q10.Resposta5 = "Belo Horizonte";
    Q10.Respostacorreta = 4;
    ListaQuestoes.Add(Q10);

    // Pergunta 11
    var Q11 = new Questao();
    Q11.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q11.Pergunta = "Qual cientista formulou a teoria da relatividade?";
    Q11.Resposta1 = "Isaac Newton";
    Q11.Resposta2 = "Galileu Galilei";
    Q11.Resposta3 = "Albert Einstein";
    Q11.Resposta4 = "Niels Bohr";
    Q11.Resposta5 = "Stephen Hawking";
    Q11.Respostacorreta = 3;
    ListaQuestoes.Add(Q11);

    // Pergunta 12
    var Q12 = new Questao();
    Q12.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q12.Pergunta = "Qual é o maior deserto do mundo?";
    Q12.Resposta1 = "Deserto do Saara";
    Q12.Resposta2 = "Deserto da Arábia";
    Q12.Resposta3 = "Deserto de Gobi";
    Q12.Resposta4 = "Deserto da Antártica";
    Q12.Resposta5 = "Deserto do Kalahari";
    Q12.Respostacorreta = 4;
    ListaQuestoes.Add(Q12);

    // Pergunta 13
    var Q13 = new Questao();
    Q13.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q13.Pergunta = "Qual civilização construiu as pirâmides no Egito?";
    Q13.Resposta1 = "Maias";
    Q13.Resposta2 = "Incas";
    Q13.Resposta3 = "Sumérios";
    Q13.Resposta4 = "Egípcios";
    Q13.Resposta5 = "Astecas";
    Q13.Respostacorreta = 4;
    ListaQuestoes.Add(Q13);

    // Pergunta 14
    var Q14 = new Questao();
    Q14.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q14.Pergunta = "Qual é a segunda maior montanha do mundo?";
    Q14.Resposta1 = "Kangchenjunga";
    Q14.Resposta2 = "Everest";
    Q14.Resposta3 = "Makalu";
    Q14.Resposta4 = "K2";
    Q14.Resposta5 = "Lhotse";
    Q14.Respostacorreta = 4;
    ListaQuestoes.Add(Q14);

    // Pergunta 15
    var Q15 = new Questao();
    Q15.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q15.Pergunta = "Quem escreveu 'Dom Quixote'?";
    Q15.Resposta1 = "William Shakespeare";
    Q15.Resposta2 = "Miguel de Cervantes";
    Q15.Resposta3 = "Dante Alighieri";
    Q15.Resposta4 = "Fiodor Dostoiévski";
    Q15.Resposta5 = "Victor Hugo";
    Q15.Respostacorreta = 2;
    ListaQuestoes.Add(Q15);

    // Pergunta 16
    var Q16 = new Questao();
    Q16.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q16.Pergunta = "Qual é o maior osso do corpo humano?";
    Q16.Resposta1 = "Tíbia";
    Q16.Resposta2 = "Fêmur";
    Q16.Resposta3 = "Úmero";
    Q16.Resposta4 = "Rádio";
    Q16.Resposta5 = "Esterno";
    Q16.Respostacorreta = 2;
    ListaQuestoes.Add(Q16);

    // Pergunta 17
    var Q17 = new Questao();
    Q17.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q17.Pergunta = "Em que ano aconteceu a Revolução Francesa?";
    Q17.Resposta1 = "1789";
    Q17.Resposta2 = "1776";
    Q17.Resposta3 = "1804";
    Q17.Resposta4 = "1815";
    Q17.Resposta5 = "1756";
    Q17.Respostacorreta = 1;
    ListaQuestoes.Add(Q17);

    // Pergunta 18
    var Q18 = new Questao();
    Q18.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q18.Pergunta = "O que mede a escala de Richter?";
    Q18.Resposta1 = "Força dos ventos";
    Q18.Resposta2 = "Magnitudes de terremotos";
    Q18.Resposta3 = "Radiação nuclear";
    Q18.Resposta4 = "Altura das marés";
    Q18.Resposta5 = "Pressão atmosférica";
    Q18.Respostacorreta = 2;
    ListaQuestoes.Add(Q18);

    // Pergunta 19
    var Q19 = new Questao();
    Q19.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q19.Pergunta = "Qual é o nome da maior lua de Saturno?";
    Q19.Resposta1 = "Titã";
    Q19.Resposta2 = "Europa";
    Q19.Resposta3 = "Ganímedes";
    Q19.Resposta4 = "Io";
    Q19.Resposta5 = "Enceladus";
    Q19.Respostacorreta = 1;
    ListaQuestoes.Add(Q19);

    // Pergunta 20
    var Q20 = new Questao();
    Q20.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q20.Pergunta = "Quem foi o autor da obra 'O Príncipe'?";
    Q20.Resposta1 = "Nicolau Maquiavel";
    Q20.Resposta2 = "Jean-Jacques Rousseau";
    Q20.Resposta3 = "Platão";
    Q20.Resposta4 = "Aristóteles";
    Q20.Resposta5 = "Thomas Hobbes";
    Q20.Respostacorreta = 1;
    ListaQuestoes.Add(Q20);

    // Pergunta 21
    var Q21 = new Questao();
    Q21.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q21.Pergunta = "Quem foi o primeiro homem a circunavegar a Terra?";
    Q21.Resposta1 = "Cristóvão Colombo";
    Q21.Resposta2 = "Ferdinando Magalhães";
    Q21.Resposta3 = "James Cook";
    Q21.Resposta4 = "Marco Polo";
    Q21.Resposta5 = "Américo Vespúcio";
    Q21.Respostacorreta = 2;
    ListaQuestoes.Add(Q21);

    // Pergunta 22
    var Q22 = new Questao();
    Q22.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q22.Pergunta = "Qual é o maior órgão do corpo humano?";
    Q22.Resposta1 = "Pulmões";
    Q22.Resposta2 = "Fígado";
    Q22.Resposta3 = "Cérebro";
    Q22.Resposta4 = "Coração";
    Q22.Resposta5 = "Pele";
    Q22.Respostacorreta = 5;
    ListaQuestoes.Add(Q22);

    // Pergunta 23
    var Q23 = new Questao();
    Q23.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q23.Pergunta = "Qual a capital do Canadá?";
    Q23.Resposta1 = "Toronto";
    Q23.Resposta2 = "Ottawa";
    Q23.Resposta3 = "Vancouver";
    Q23.Resposta4 = "Montreal";
    Q23.Resposta5 = "Quebec";
    Q23.Respostacorreta = 2;
    ListaQuestoes.Add(Q23);

    // Pergunta 24
    var Q24 = new Questao();
    Q24.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q24.Pergunta = "Qual cientista descobriu a penicilina?";
    Q24.Resposta1 = "Alexander Fleming";
    Q24.Resposta2 = "Marie Curie";
    Q24.Resposta3 = "Louis Pasteur";
    Q24.Resposta4 = "Isaac Newton";
    Q24.Resposta5 = "Gregor Mendel";
    Q24.Respostacorreta = 1;
    ListaQuestoes.Add(Q24);

    // Pergunta 25
    var Q25 = new Questao();
    Q25.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q25.Pergunta = "Qual é o segundo maior país do mundo em área?";
    Q25.Resposta1 = "China";
    Q25.Resposta2 = "Brasil";
    Q25.Resposta3 = "Canadá";
    Q25.Resposta4 = "Estados Unidos";
    Q25.Resposta5 = "Rússia";
    Q25.Respostacorreta = 3;
    ListaQuestoes.Add(Q25);

    // Pergunta 26
    var Q26 = new Questao();
    Q26.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q26.Pergunta = "Qual é a maior estrela conhecida no universo?";
    Q26.Resposta1 = "Betelgeuse";
    Q26.Resposta2 = "Antares";
    Q26.Resposta3 = "UY Scuti";
    Q26.Resposta4 = "VY Canis Majoris";
    Q26.Resposta5 = "Sirius";
    Q26.Respostacorreta = 3;
    ListaQuestoes.Add(Q26);

    // Pergunta 27
    var Q27 = new Questao();
    Q27.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q27.Pergunta = "Quem foi o primeiro imperador romano?";
    Q27.Resposta1 = "Júlio César";
    Q27.Resposta2 = "Nero";
    Q27.Resposta3 = "Augusto";
    Q27.Resposta4 = "Trajano";
    Q27.Resposta5 = "Marco Aurélio";
    Q27.Respostacorreta = 3;
    ListaQuestoes.Add(Q27);

    // Pergunta 28
    var Q28 = new Questao();
    Q28.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q28.Pergunta = "Qual é o valor aproximado da constante de Planck?";
    Q28.Resposta1 = "6,63 × 10⁻³⁴ J·s";
    Q28.Resposta2 = "3,00 × 10⁸ m/s";
    Q28.Resposta3 = "9,81 m/s²";
    Q28.Resposta4 = "1,67 × 10⁻²⁷ kg";
    Q28.Resposta5 = "1,38 × 10⁻²³ J/K";
    Q28.Respostacorreta = 1;
    ListaQuestoes.Add(Q28);

    // Pergunta 29
    var Q29 = new Questao();
    Q29.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q29.Pergunta = "Quem foi o autor de 'A Origem das Espécies'?";
    Q29.Resposta1 = "Charles Darwin";
    Q29.Resposta2 = "Gregor Mendel";
    Q29.Resposta3 = "Albert Einstein";
    Q29.Resposta4 = "Isaac Newton";
    Q29.Resposta5 = "Louis Pasteur";
    Q29.Respostacorreta = 1;
    ListaQuestoes.Add(Q29);

    // Pergunta 30
    var Q30 = new Questao();
    Q30.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q30.Pergunta = "Qual é o ponto mais profundo dos oceanos?";
    Q30.Resposta1 = "Fossa das Marianas";
    Q30.Resposta2 = "Fossa de Java";
    Q30.Resposta3 = "Fossa de Tonga";
    Q30.Resposta4 = "Dorsal Mesoatlântica";
    Q30.Resposta5 = "Fossa das Filipinas";
    Q30.Respostacorreta = 1;
    ListaQuestoes.Add(Q30);

    // Pergunta 31
    var Q31 = new Questao();
    Q31.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q31.Pergunta = "Qual é a unidade astronômica usada para medir distâncias no espaço, equivalente a cerca de 3,26 anos-luz?";
    Q31.Resposta1 = "Parsec";
    Q31.Resposta2 = "Ano-luz";
    Q31.Resposta3 = "Unidade Astronômica";
    Q31.Resposta4 = "Quiloparsec";
    Q31.Resposta5 = "Gigaparsec";
    Q31.Respostacorreta = 1;
    ListaQuestoes.Add(Q31);

    // Pergunta 32
    var Q32 = new Questao();
    Q32.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q32.Pergunta = "Quem foi o vencedor do Prêmio Nobel de Literatura em 1925?";
    Q32.Resposta1 = "Thomas Mann";
    Q32.Resposta2 = "William Butler Yeats";
    Q32.Resposta3 = "George Bernard Shaw";
    Q32.Resposta4 = "T.S. Eliot";
    Q32.Resposta5 = "Ernest Hemingway";
    Q32.Respostacorreta = 3;
    ListaQuestoes.Add(Q32);

    // Pergunta 33
    var Q33 = new Questao();
    Q33.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q33.Pergunta = "Qual é o símbolo químico do elemento Urânio?";
    Q33.Resposta1 = "U";
    Q33.Resposta2 = "Ur";
    Q33.Resposta3 = "Ua";
    Q33.Resposta4 = "Um";
    Q33.Resposta5 = "Un";
    Q33.Respostacorreta = 1;
    ListaQuestoes.Add(Q33);

    // Pergunta 34
    var Q34 = new Questao();
    Q34.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q34.Pergunta = "Qual foi o tratado que pôs fim à Primeira Guerra Mundial?";
    Q34.Resposta1 = "Tratado de Versalhes";
    Q34.Resposta2 = "Tratado de Tordesilhas";
    Q34.Resposta3 = "Tratado de Utrecht";
    Q34.Resposta4 = "Tratado de Westfália";
    Q34.Resposta5 = "Tratado de Paris";
    Q34.Respostacorreta = 1;
    ListaQuestoes.Add(Q34);

    // Pergunta 35
    var Q35 = new Questao();
    Q35.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q35.Pergunta = "Em que parte do corpo humano fica o osso estribo, o menor osso do corpo?";
    Q35.Resposta1 = "Nariz";
    Q35.Resposta2 = "Ouvido";
    Q35.Resposta3 = "Olho";
    Q35.Resposta4 = "Mão";
    Q35.Resposta5 = "Joelho";
    Q35.Respostacorreta = 2;
    ListaQuestoes.Add(Q35);

    // Pergunta 36
    var Q36 = new Questao();
    Q36.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q36.Pergunta = "Em que ano ocorreu a Revolução Russa?";
    Q36.Resposta1 = "1917";
    Q36.Resposta2 = "1905";
    Q36.Resposta3 = "1936";
    Q36.Resposta4 = "1922";
    Q36.Resposta5 = "1945";
    Q36.Respostacorreta = 1;
    ListaQuestoes.Add(Q36);

    // Pergunta 37
    var Q37 = new Questao();
    Q37.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q37.Pergunta = "Qual filósofo escreveu 'A República'?";
    Q37.Resposta1 = "Sócrates";
    Q37.Resposta2 = "Aristóteles";
    Q37.Resposta3 = "Platão";
    Q37.Resposta4 = "Descartes";
    Q37.Resposta5 = "Nietzsche";
    Q37.Respostacorreta = 3;
    ListaQuestoes.Add(Q37);

    // Pergunta 38
    var Q38 = new Questao();
    Q38.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q38.Pergunta = "Qual é o maior satélite natural de Júpiter?";
    Q38.Resposta1 = "Calisto";
    Q38.Resposta2 = "Europa";
    Q38.Resposta3 = "Titã";
    Q38.Resposta4 = "Ganímedes";
    Q38.Resposta5 = "Io";
    Q38.Respostacorreta = 4;
    ListaQuestoes.Add(Q38);

    // Pergunta 39
    var Q39 = new Questao();
    Q39.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q39.Pergunta = "Qual foi o primeiro animal a ser clonado com sucesso?";
    Q39.Resposta1 = "Cachorro";
    Q39.Resposta2 = "Macaco";
    Q39.Resposta3 = "Carneiro";
    Q39.Resposta4 = "Gato";
    Q39.Resposta5 = "Rato";
    Q39.Respostacorreta = 3;
    ListaQuestoes.Add(Q39);

    // Pergunta 40
    var Q40 = new Questao();
    Q40.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q40.Pergunta = "O que descreve a Lei de Hubble?";
    Q40.Resposta1 = "A relação entre velocidade e distância de galáxias";
    Q40.Resposta2 = "A forma dos buracos negros";
    Q40.Resposta3 = "A estrutura do espaço-tempo";
    Q40.Resposta4 = "A curvatura da luz ao redor de estrelas";
    Q40.Resposta5 = "A equação do estado da matéria escura";
    Q40.Respostacorreta = 1;
    ListaQuestoes.Add(Q40);

    // Pergunta 41
    var Q41 = new Questao();
    Q41.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q41.Pergunta = "Quem formulou a teoria da relatividade geral?";
    Q41.Resposta1 = "Niels Bohr";
    Q41.Resposta2 = "Isaac Newton";
    Q41.Resposta3 = "Albert Einstein";
    Q41.Resposta4 = "Max Planck";
    Q41.Resposta5 = "Richard Feynman";
    Q41.Respostacorreta = 3;
    ListaQuestoes.Add(Q41);

    // Pergunta 42
    var Q42 = new Questao();
    Q42.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q42.Pergunta = "Qual é o número atômico do elemento químico Césio?";
    Q42.Resposta1 = "55";
    Q42.Resposta2 = "57";
    Q42.Resposta3 = "54";
    Q42.Resposta4 = "56";
    Q42.Resposta5 = "58";
    Q42.Respostacorreta = 1;
    ListaQuestoes.Add(Q42);

    // Pergunta 43
    var Q43 = new Questao();
    Q43.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q43.Pergunta = "Qual o nome da equação que descreve o comportamento de uma partícula quântica?";
    Q43.Resposta1 = "Equação de Schrödinger";
    Q43.Resposta2 = "Equação de Maxwell";
    Q43.Resposta3 = "Equação de Dirac";
    Q43.Resposta4 = "Equação de Klein-Gordon";
    Q43.Resposta5 = "Equação de Newton";
    Q43.Respostacorreta = 1;
    ListaQuestoes.Add(Q43);

    // Pergunta 44
    var Q44 = new Questao();
    Q44.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q44.Pergunta = "Qual é o nome do processo de conversão de glicose em piruvato, liberando energia, no metabolismo celular?";
    Q44.Resposta1 = "Fotossíntese";
    Q44.Resposta2 = "Fermentação";
    Q44.Resposta3 = "Glicólise";
    Q44.Resposta4 = "Ciclo de Krebs";
    Q44.Resposta5 = "Oxidação";
    Q44.Respostacorreta = 3;
    ListaQuestoes.Add(Q44);

    // Pergunta 45
    var Q45 = new Questao();
    Q45.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q45.Pergunta = "Em que país ocorreu a Guerra dos Cem Anos?";
    Q45.Resposta1 = "França";
    Q45.Resposta2 = "Inglaterra";
    Q45.Resposta3 = "Alemanha";
    Q45.Resposta4 = "Itália";
    Q45.Resposta5 = "Espanha";
    Q45.Respostacorreta = 1;
    ListaQuestoes.Add(Q45);

    // Pergunta 46
    var Q46 = new Questao();
    Q46.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q46.Pergunta = "Qual é a função das hemácias no corpo humano?";
    Q46.Resposta1 = "Transportar oxigênio";
    Q46.Resposta2 = "Produzir anticorpos";
    Q46.Resposta3 = "Destruir patógenos";
    Q46.Resposta4 = "Produzir hormônios";
    Q46.Resposta5 = "Promover coagulação";
    Q46.Respostacorreta = 1;
    ListaQuestoes.Add(Q46);

    // Pergunta 47
    var Q47 = new Questao();
    Q47.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q47.Pergunta = "Quem pintou o teto da Capela Sistina?";
    Q47.Resposta1 = "Leonardo da Vinci";
    Q47.Resposta2 = "Donatello";
    Q47.Resposta3 = "Michelangelo";
    Q47.Resposta4 = "Raphael";
    Q47.Resposta5 = "Caravaggio";
    Q47.Respostacorreta = 3;
    ListaQuestoes.Add(Q47);

    // Pergunta 48
    var Q48 = new Questao();
    Q48.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q48.Pergunta = "Qual é o principal constituinte do gás natural?";
    Q48.Resposta1 = "Metano";
    Q48.Resposta2 = "Etano";
    Q48.Resposta3 = "Propano";
    Q48.Resposta4 = "Butano";
    Q48.Resposta5 = "Dióxido de carbono";
    Q48.Respostacorreta = 1;
    ListaQuestoes.Add(Q48);

    // Pergunta 49
    var Q49 = new Questao();
    Q49.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q49.Pergunta = "Qual é o nome do modelo teórico que descreve a origem e evolução do universo?";
    Q49.Resposta1 = "Teoria das Supercordas";
    Q49.Resposta2 = "Teoria da Gravitação Quântica";
    Q49.Resposta3 = "Modelo de Expansão Inflacionária";
    Q49.Resposta4 = "Big Bang";
    Q49.Resposta5 = "Teoria do Multiverso";
    Q49.Respostacorreta = 4;
    ListaQuestoes.Add(Q49);

    // Pergunta 50
    var Q50 = new Questao();
    Q50.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q50.Pergunta = "Qual o nome do filósofo alemão que escreveu 'Assim Falou Zaratustra'?";
    Q50.Resposta1 = "Immanuel Kant";
    Q50.Resposta2 = "Friedrich Nietzsche";
    Q50.Resposta3 = "Martin Heidegger";
    Q50.Resposta4 = "Arthur Schopenhauer";
    Q50.Resposta5 = "Georg Hegel";
    Q50.Respostacorreta = 2;
    ListaQuestoes.Add(Q50);

    // Pergunta 51
    var Q51 = new Questao();
    Q51.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q51.Pergunta = "Quem propôs o princípio da incerteza, uma das bases da mecânica quântica?";
    Q51.Resposta1 = "Niels Bohr";
    Q51.Resposta2 = "Werner Heisenberg";
    Q51.Resposta3 = "Max Planck";
    Q51.Resposta4 = "Albert Einstein";
    Q51.Resposta5 = "Erwin Schrödinger";
    Q51.Respostacorreta = 2;
    ListaQuestoes.Add(Q51);

    // Pergunta 52
    var Q52 = new Questao();
    Q52.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q52.Pergunta = "Qual é o nome da partícula responsável pela força nuclear forte, mediada por glúons?";
    Q52.Resposta1 = "Fóton";
    Q52.Resposta2 = "Bóson de Higgs";
    Q52.Resposta3 = "Neutrino";
    Q52.Resposta4 = "Quark";
    Q52.Resposta5 = "Gráviton";
    Q52.Respostacorreta = 4;
    ListaQuestoes.Add(Q52);

    // Pergunta 53
    var Q53 = new Questao();
    Q53.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q53.Pergunta = "Qual cientista desenvolveu a equação E = mc²?";
    Q53.Resposta1 = "Marie Curie";
    Q53.Resposta2 = "Isaac Newton";
    Q53.Resposta3 = "Galileu Galilei";
    Q53.Resposta4 = "Albert Einstein";
    Q53.Resposta5 = "James Clerk Maxwell";
    Q53.Respostacorreta = 4;
    ListaQuestoes.Add(Q53);

    // Pergunta 54
    var Q54 = new Questao();
    Q54.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q54.Pergunta = "Qual é a equação fundamental da mecânica quântica, que descreve a evolução temporal de sistemas quânticos?";
    Q54.Resposta1 = "Equação de Schrödinger";
    Q54.Resposta2 = "Equação de Dirac";
    Q54.Resposta3 = "Teorema de Noether";
    Q54.Resposta4 = "Equações de Maxwell";
    Q54.Resposta5 = "Lei de Planck";
    Q54.Respostacorreta = 1;
    ListaQuestoes.Add(Q54);

    // Pergunta 55
    var Q55 = new Questao();
    Q55.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q55.Pergunta = "Em que ano ocorreu a queda do Império Romano do Ocidente?";
    Q55.Resposta1 = "476 d.C.";
    Q55.Resposta2 = "1453 d.C.";
    Q55.Resposta3 = "1204 d.C.";
    Q55.Resposta4 = "330 d.C.";
    Q55.Resposta5 = "395 d.C.";
    Q55.Respostacorreta = 1;
    ListaQuestoes.Add(Q55);

    // Pergunta 56
    var Q56 = new Questao();
    Q56.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q56.Pergunta = "Qual é o nome da teoria que unifica a relatividade geral e a mecânica quântica?";
    Q56.Resposta1 = "Teoria das Supercordas";
    Q56.Resposta2 = "Teoria do Campo Unificado";
    Q56.Resposta3 = "Teoria da Gravidade Quântica";
    Q56.Resposta4 = "Teoria do Big Bang";
    Q56.Resposta5 = "Modelo Padrão";
    Q56.Respostacorreta = 1;
    ListaQuestoes.Add(Q56);

    // Pergunta 57
    var Q57 = new Questao();
    Q57.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q57.Pergunta = "Qual é a distância aproximada da Terra ao Sol?";
    Q57.Resposta1 = "93 milhões de quilômetros";
    Q57.Resposta2 = "150 milhões de quilômetros";
    Q57.Resposta3 = "384 mil quilômetros";
    Q57.Resposta4 = "1,496 bilhões de quilômetros";
    Q57.Resposta5 = "100 milhões de quilômetros";
    Q57.Respostacorreta = 2;
    ListaQuestoes.Add(Q57);

    // Pergunta 58
    var Q58 = new Questao();
    Q58.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q58.Pergunta = "Qual é o nome do fenômeno que ocorre quando uma estrela de grande massa explode?";
    Q58.Resposta1 = "Supernova";
    Q58.Resposta2 = "Buraco Negro";
    Q58.Resposta3 = "Pulsar";
    Q58.Resposta4 = "Nebulosa";
    Q58.Resposta5 = "Estrela de Nêutrons";
    Q58.Respostacorreta = 1;
    ListaQuestoes.Add(Q58);

    // Pergunta 59
    var Q59 = new Questao();
    Q59.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q59.Pergunta = "Quem descobriu o próton, uma das partículas subatômicas?";
    Q59.Resposta1 = "Ernest Rutherford";
    Q59.Resposta2 = "Niels Bohr";
    Q59.Resposta3 = "J.J. Thomson";
    Q59.Resposta4 = "Robert Millikan";
    Q59.Resposta5 = "James Chadwick";
    Q59.Respostacorreta = 1;
    ListaQuestoes.Add(Q59);

    // Pergunta 60
    var Q60 = new Questao();
    Q60.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q60.Pergunta = "Qual é a partícula que interage com o campo de Higgs para dar massa a outras partículas?";
    Q60.Resposta1 = "Fóton";
    Q60.Resposta2 = "Glúon";
    Q60.Resposta3 = "Bóson de Higgs";
    Q60.Resposta4 = "Quark";
    Q60.Resposta5 = "Neutrino";
    Q60.Respostacorreta = 3;
    ListaQuestoes.Add(Q60);

    // Pergunta 61
    var Q61 = new Questao();
    Q61.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q61.Pergunta = "Qual foi a primeira nave espacial tripulada a pousar na Lua?";
    Q61.Resposta1 = "Apollo 13";
    Q61.Resposta2 = "Apollo 11";
    Q61.Resposta3 = "Vostok 1";
    Q61.Resposta4 = "Soyuz 1";
    Q61.Resposta5 = "Gemini 8";
    Q61.Respostacorreta = 2;
    ListaQuestoes.Add(Q61);

    // Pergunta 62
    var Q62 = new Questao();
    Q62.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q62.Pergunta = "Qual é o nome do físico que propôs o conceito de 'gato de Schrödinger' para ilustrar superposição quântica?";
    Q62.Resposta1 = "Erwin Schrödinger";
    Q62.Resposta2 = "Werner Heisenberg";
    Q62.Resposta3 = "Niels Bohr";
    Q62.Resposta4 = "Max Planck";
    Q62.Resposta5 = "Albert Einstein";
    Q62.Respostacorreta = 1;
    ListaQuestoes.Add(Q62);

    // Pergunta 63
    var Q63 = new Questao();
    Q63.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q63.Pergunta = "Qual é o nome do fenômeno físico que descreve a capacidade de um líquido subir em tubos finos contra a gravidade?";
    Q63.Resposta1 = "Efeito de Venturi";
    Q63.Resposta2 = "Capilaridade";
    Q63.Resposta3 = "Efeito Bernoulli";
    Q63.Resposta4 = "Tensão Superficial";
    Q63.Resposta5 = "Efeito Doppler";
    Q63.Respostacorreta = 2;
    ListaQuestoes.Add(Q63);

    // Pergunta 64
    var Q64 = new Questao();
    Q64.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q64.Pergunta = "Qual matemático é considerado o pai da teoria dos números e da álgebra moderna?";
    Q64.Resposta1 = "Isaac Newton";
    Q64.Resposta2 = "Carl Friedrich Gauss";
    Q64.Resposta3 = "Euclides";
    Q64.Resposta4 = "Leonhard Euler";
    Q64.Resposta5 = "René Descartes";
    Q64.Respostacorreta = 2;
    ListaQuestoes.Add(Q64);

    // Pergunta 65
    var Q65 = new Questao();
    Q65.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q65.Pergunta = "Qual é o nome da teoria que explica a movimentação das placas tectônicas?";
    Q65.Resposta1 = "Teoria do Big Bang";
    Q65.Resposta2 = "Teoria das Cordilheiras";
    Q65.Resposta3 = "Teoria das Placas Tectônicas";
    Q65.Resposta4 = "Teoria da Deriva Continental";
    Q65.Resposta5 = "Teoria do Gradiente";
    Q65.Respostacorreta = 3;
    ListaQuestoes.Add(Q65);

    // Pergunta 66
    var Q66 = new Questao();
    Q66.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q66.Pergunta = "Qual era a cidade-estado rival de Atenas durante as Guerras do Peloponeso?";
    Q66.Resposta1 = "Esparta";
    Q66.Resposta2 = "Corinto";
    Q66.Resposta3 = "Roma";
    Q66.Resposta4 = "Mileto";
    Q66.Resposta5 = "Tebas";
    Q66.Respostacorreta = 1;
    ListaQuestoes.Add(Q66);

    // Pergunta 67
    var Q67 = new Questao();
    Q67.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q67.Pergunta = "Qual é o nome do composto químico comum cuja fórmula molecular é C6H12O6?";
    Q67.Resposta1 = "Frutose";
    Q67.Resposta2 = "Glicose";
    Q67.Resposta3 = "Lactose";
    Q67.Resposta4 = "Amido";
    Q67.Resposta5 = "Sacarose";
    Q67.Respostacorreta = 2;
    ListaQuestoes.Add(Q67);

    // Pergunta 68
    var Q68 = new Questao();
    Q68.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q68.Pergunta = "Quem foi o primeiro presidente dos Estados Unidos a renunciar ao cargo?";
    Q68.Resposta1 = "Richard Nixon";
    Q68.Resposta2 = "Abraham Lincoln";
    Q68.Resposta3 = "John F. Kennedy";
    Q68.Resposta4 = "Andrew Johnson";
    Q68.Resposta5 = "Herbert Hoover";
    Q68.Respostacorreta = 1;
    ListaQuestoes.Add(Q68);

    // Pergunta 69
    var Q69 = new Questao();
    Q69.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q69.Pergunta = "Qual o nome do princípio da física que afirma que para cada ação há uma reação igual e oposta?";
    Q69.Resposta1 = "Princípio da Inércia";
    Q69.Resposta2 = "Lei de Ação e Reação";
    Q69.Resposta3 = "Teorema da Conservação de Energia";
    Q69.Resposta4 = "Lei de Conservação da Massa";
    Q69.Resposta5 = "Lei da Gravitação Universal";
    Q69.Respostacorreta = 2;
    ListaQuestoes.Add(Q69);

    // Pergunta 70
    var Q70 = new Questao();
    Q70.ConfiguraDesenho(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
    Q70.Pergunta = "Quem escreveu a obra filosófica 'Meditações sobre a Filosofia Primeira'?";
    Q70.Resposta1 = "René Descartes";
    Q70.Resposta2 = "Immanuel Kant";
    Q70.Resposta3 = "Friedrich Nietzsche";
    Q70.Resposta4 = "John Locke";
    Q70.Resposta5 = "David Hume";
    Q70.Respostacorreta = 1;
    ListaQuestoes.Add(Q70);

  }
  public async void VerificaCorreta(int RR)
  {
    if (QuestaoAtual.VerificaResposta(RR))
    {
      await Task.Delay(1000);
      AdicionaPontuacao(NivelAtual);
      NivelAtual++;
      ProximaQuestao();
    }
    else
    {
      await App.Current.MainPage.DisplayAlert("Fim","Você errou!","Ok");

    }
  }
  void ProximaQuestao()
  {
    var numAleat = Random.Shared.Next(0, ListaQuestoes.Count);
    while (ListaQuestoesRespondidas.Contains(numAleat))
      numAleat = Random.Shared.Next(0, ListaQuestoes.Count);
    ListaQuestoesRespondidas.Add(numAleat);
    QuestaoAtual = ListaQuestoes[numAleat];
    QuestaoAtual.Desenhar();
  }

  public int Pontuacao { get; private set; }
  int NivelAtual = 0;
  void Inicializar()
  {
    Pontuacao = 0;
    NivelAtual = 1;
    ProximaQuestao();
  }

  void AdicionaPontuacao(int n)
  {
    if (n == 1)
      Pontuacao = 1000;

    else if (n == 2)
      Pontuacao = 2000;

    else if (n == 3)
      Pontuacao = 5000;

    else if (n == 4)
      Pontuacao = 10000;

    else if (n == 5)
      Pontuacao = 20000;

    else if (n == 6)
      Pontuacao = 50000;

    else if (n == 7)
      Pontuacao = 100000;

    else if (n == 8)
      Pontuacao = 200000;

    else if (n == 9)
      Pontuacao = 500000;

    else Pontuacao = 1000000;

  }



}

