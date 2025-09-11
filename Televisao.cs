public class Televisao
{
    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;
    private int VolumeAnterior;

    private const int CANAL_MIN = 1;
    private const int CANAL_MAX = 520;
    private int UltimoCanal;

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        Canal = CANAL_MIN;
        UltimoCanal = Canal;
        Volume = 10;
    }

    public float Tamanho { get ;}
    public int Resolucao { get ; set;}
    public int Volume { get ; private set;}
    public int Canal { get ; set;}
    public bool Estado { get ; set;}

    public void AumentarVolume()
    {
        if(Volume < VOL_MAX)
            Volume++;
        else
            Console.WriteLine("TV já está no max.");
    }

    public void DiminuirVolume()
    {
        if(Volume > VOL_MIN)
            Volume--;
        else
            Console.WriteLine("TV já está no min.");
    }

    public void AlterarMudo()
    {
        if(Volume == 0)
        {
            Volume = VolumeAnterior;
        }
        else
        {
            VolumeAnterior = Volume;
            Volume = 0;
        }
    }

    public void ProximoCanal() 
    {
        if(Canal < CANAL_MAX)
            Canal++;    
        else
            Console.WriteLine("Já está no último canal");
    } 

    public void CanalAnterior() 
    {
        if(Canal > CANAL_MIN)
            Canal--;    
        else
            Console.WriteLine("Já está no primeiro canal");
    }

    public void MudarCanal(int numero)
    {
        if(numero >= CANAL_MIN && numero <= CANAL_MAX)
            Canal = numero;
        else
            Console.WriteLine("Canal inválido");
    }

    public void Ligar()
    {
        Canal = UltimoCanal; // quando liga, volta para o último canal
        Estado = true;
    }

    public void Desligar()
    {
        UltimoCanal = Canal; // quando desliga, guarda o canal atual
        Estado = false;
    }

}