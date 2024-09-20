using ApiCleanArch.Models;

namespace ApiCleanArch.Repositories;

public class ReservaRepository : IReservaRepository
{
    private readonly List<Reserva> _reservas = new List<Reserva>();

    public void Adicionar(Reserva reserva)
    {
        _reservas.Add(reserva);
    }

    public bool ExisteReservaConflitante(DateTime dataCheckIn, DateTime dataCheckOut)
    {
        return _reservas.Any(r => r.DataCheckIn < dataCheckOut && r.DataCheckOut > dataCheckIn);
    }
}
