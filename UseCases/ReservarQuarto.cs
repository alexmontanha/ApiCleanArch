using ApiCleanArch.Models;
using ApiCleanArch.Repositories;

namespace ApiCleanArch.UseCases;

public class ReservarQuarto
{
    private readonly IReservaRepository _reservaRepository;

    public ReservarQuarto(IReservaRepository reservaRepository)
    {
        _reservaRepository = reservaRepository;
    }

    public string Executar(Reserva reserva)
    {
        if (string.IsNullOrEmpty(reserva.Nome) || reserva.DataCheckIn == default || reserva.DataCheckOut == default || reserva.NumeroHospedes <= 0)
        {
            throw new ArgumentException("Todos os campos obrigatórios devem ser preenchidos.");
        }

        if (reserva.DataCheckIn < DateTime.Now || reserva.DataCheckOut <= reserva.DataCheckIn)
        {
            throw new ArgumentException("A data de check-in deve ser futura e razoável.");
        }

        if (_reservaRepository.ExisteReservaConflitante(reserva.DataCheckIn, reserva.DataCheckOut))
        {
            throw new ArgumentException("As datas selecionadas não estão disponíveis.");
        }

        // Adicionar lógica para verificar o número de hóspedes permitido

        reserva.NumeroConfirmacao = Guid.NewGuid().ToString();
        _reservaRepository.Adicionar(reserva);

        return reserva.NumeroConfirmacao;
    }
}
