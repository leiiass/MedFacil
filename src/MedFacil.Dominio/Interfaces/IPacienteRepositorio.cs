using MedFacil.Dominio.Modelos;
using System.Collections.Generic;

namespace MedFacil.Dominio.Interfaces
{
    public interface IPacienteRepositorio
    {
        public List<Paciente> ObterTodos();
        public Paciente ObterPorId(int id);
        public Paciente Criar(Paciente paciente);
        public void Atualizar(int id, Paciente paciente);
        public void Remover(int id);
    }
}
