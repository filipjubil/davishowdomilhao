namespace davishowdomilhao;
public class questao
{
public string pergunta1;
public string resposta2;
public string resposta3;
public string resposta4;
public string resposta5;
public int respostacorreta;
public int nivel;
label labelpergunta;
Button buttonResposta1;
Button buttonResposta2;
Button buttonResposta3;
Button buttonResposta4;
Button buttonResposta5;

public void Desenhar()
{
    labelpergunta.text=pergunta1;
    buttonResposta1.Text=buttonResposta1;
    buttonResposta1.Text=buttonResposta2;
    buttonResposta1.Text=buttonResposta3;
    buttonResposta1.Text=buttonResposta4;
    buttonResposta1.Text=buttonResposta5;

}
public Boll verifica Resposta (int rr)
{
    if (resposta Certa == rr)
    {
        var btn = Qualbtn (rr)
        btn backgrowColor = colors.Green;
        return true;
     
    }
  else
  {
    var btnCorreto = QualBtn (buttonResposta1 Certa);
    var btnIncorreto = QualBtn (RR);
     btnCorreto.backgrowColor =  Colors.red;
     btnIncorreto.backgrowColor = Colors.Red;
     return false;
  }




}


}