using System;

public class Solution
{

}

public abstract class EsporteBase
{
    public int QuantidadeJogadoresPorTime;
    public int TempoDeJogoEmMinutos;

    public abstract string IniciarJogo();
    public abstract string FinalizarJogo();
    public abstract string ExibirDescricao();
}

public class Futebol : EsporteBase
{
    public int QuantidadeJogadoresPorTime { get; set; }
    public int TempoDeJogoEmMinutos { get; set; }

    public Futebol()
    {
        QuantidadeJogadoresPorTime = 11;
        TempoDeJogoEmMinutos = 90;
    }

    public override string IniciarJogo()
    {
        return "O jogo foi iniciado";
    }

    public override string FinalizarJogo()
    {
        return "O jogo foi finalizado";
    }

    public override string ExibirDescricao()
    {
        return $"O futebol é um esporte praticado por {QuantidadeJogadoresPorTime} jogadores em cada time durante {TempoDeJogoEmMinutos} minutos";
    }
}