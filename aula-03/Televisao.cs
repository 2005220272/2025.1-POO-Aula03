using System;

namespace aula_03;

public class Televisao
{
    // Constantes para valores fixos
    private const float TAMANHO_MINIMO = 22;
    private const float TAMANHO_MAXIMO = 80;
    private const int VOLUME_MAXIMO = 100;
    private const int VOLUME_MINIMO = 0;
    private const int VOLUME_PADRAO = 10;
    private const int CANAL_PADRAO = 0;
    private const int CANAL_MAXIMO = 999;
    private const int CANAL_MINIMO = 0;

    // Propriedades privadas
    private bool _modoMudo;
    private int _ultimoVolume = VOLUME_PADRAO;
    private int _ultimoCanal = CANAL_PADRAO;

    // Propriedades públicas
    public float Tamanho { get; }
    public int Volume { get; private set; }
    public int Canal { get; private set; }
    public bool Estado { get; set; }

    // Construtor
    public Televisao(float tamanho)
    {
        if (tamanho < TAMANHO_MINIMO || tamanho > TAMANHO_MAXIMO)
        {
            throw new ArgumentOutOfRangeException(nameof(tamanho), $"O tamanho({tamanho}) não é suportado!");
        }

        Tamanho = tamanho;
        Volume = VOLUME_PADRAO;
        Canal = CANAL_PADRAO;
        _modoMudo = false;
    }

    // Métodos para controle de volume
    public void AumentarVolume()
    {
        if (!_modoMudo && Volume < VOLUME_MAXIMO)
        {
            Volume++;
            _ultimoVolume = Volume;
        }
    }

    public void DiminuirVolume()
    {
        if (!_modoMudo && Volume > VOLUME_MINIMO)
        {
            Volume--;
            _ultimoVolume = Volume;
        }
    }

    // Método para alternar o modo mudo
    public void AlternarModoMudo()
    {
        if (_modoMudo)
        {
            // Desativa o modo mudo e restaura o volume anterior
            Volume = _ultimoVolume;
        }
        else
        {
            // Ativa o modo mudo e armazena o volume atual
            _ultimoVolume = Volume;
            Volume = 0;
        }

        _modoMudo = !_modoMudo; // Alterna o estado do modo mudo
    }

    // Métodos para controle de canal
    public void SelecionarCanal(int canal)
    {
        if (canal >= CANAL_MINIMO && canal <= CANAL_MAXIMO)
        {
            Canal = canal;
            _ultimoCanal = Canal;
        }
        else
        {
            Console.WriteLine($"Canal {canal} não suportado. Canais válidos: {CANAL_MINIMO} a {CANAL_MAXIMO}.");
        }
    }

    public void AumentarCanal()
    {
        if (Canal < CANAL_MAXIMO)
        {
            Canal++;
            _ultimoCanal = Canal;
        }
        else
        {
            Console.WriteLine("A TV já está no canal máximo permitido.");
        }
    }

    public void DiminuirCanal()
    {
        if (Canal > CANAL_MINIMO)
        {
            Canal--;
            _ultimoCanal = Canal;
        }
        else
        {
            Console.WriteLine("A TV já está no canal mínimo permitido.");
        }
    }
}