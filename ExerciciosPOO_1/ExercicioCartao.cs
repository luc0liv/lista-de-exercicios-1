using System;

public abstract class CartaoWeb
{
    public string Destinatario;

    public abstract string ShowMessage();
}

public class DiaDosNamorados : CartaoWeb
{
    public string Destinatario { get; set; }

    public DiaDosNamorados(string destinatario)
    {
        Destinatario = destinatario;
    }

    public override string ShowMessage()
    {
        return $"Feliz Dia dos Namorados, {Destinatario}!";
    }
}

public class Natal : CartaoWeb
{
    public string Destinatario { get; set; }

    public Natal(string destinatario)
    {
        Destinatario = destinatario;
    }

    public override string ShowMessage()
    {
        return $"Feliz Natal, {Destinatario}!";
    }
}

public class Aniversario : CartaoWeb
{
    public string Destinatario { get; set; }

    public Aniversario(string destinatario)
    {
        Destinatario = destinatario;
    }

    public override string ShowMessage()
    {
        return $"Feliz Aniversário, {Destinatario}!";
    }
}
