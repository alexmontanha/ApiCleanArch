using ApiCleanArch.Models;

namespace ApiCleanArch.Repositories;

public interface IReservaRepository
{
    void Adicionar(Reserva reserva);
    bool ExisteReservaConflitante(DateTime dataCheckIn, DateTime dataCheckOut);
}
