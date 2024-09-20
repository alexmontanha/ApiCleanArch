namespace ApiCleanArch.Models;

public class Reserva
{
    public required string Nome { get; set; }
    public DateTime DataCheckIn { get; set; }
    public DateTime DataCheckOut { get; set; }
    public int NumeroHospedes { get; set; }
    public string? NumeroConfirmacao { get; set; }
}