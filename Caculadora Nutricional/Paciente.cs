using System.Reflection.PortableExecutable;

class Paciente
{

    private string? _nome;
    public string? Nome
    {
        get { return _nome; } // permite ler o valor
        set { _nome = value; } // permite atribuir um novo valor
    }

    private float _peso;
    public float Peso
    {
        get { return _peso; }
        set { _peso = value; }
    }

    private int _idade;
    public int Idade
    {
        get { return _idade; }
        set { _peso = value; }
    }

    private int _altura;
    public int Altura
    {
        get { return _altura; }
        set { _altura = value; }
    }

    private char _genero;
    public char Genero
    {
        get { return _genero; }
        set { _genero = value; }
    }

    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    private float _kcal;
    public float Kcal
    {
        get { return _kcal; }
        set { _kcal = value; }
    }

    private float _ptn;
    public float Ptn
    {
        get { return _ptn; }
        set { _ptn = value; }
    }

    private float _lip;
    public float Lip
    {
        get { return _lip; }
        set { _lip = value; }
    }

    private float _cho;
    public float Cho
    {
        get { return _cho; }
        set { _cho = value; }
    }

    private float _bf;
    public float Bf
    {
        get { return _bf; }
        set { _bf = value; }
    }

    private float _faf;
    public float Faf
    {
        get { return _faf; }
        set { _faf = value; }
    }

    private float _get;
    public float Get
    {
        get { return _get; }
        set { _get = value; }
    }
}