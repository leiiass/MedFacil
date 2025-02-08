using MedFacil.Dominio.Modelos;
using System.Collections.Generic;

namespace MedFacil.Dominio.Interfaces
{
    public interface IMedicoRepositorio
    {
        public List<Medico> ObterTodos();
        public Medico ObterPorId(int id);
        public Medico Criar(Medico medico);
        public void Atualizar(int id, Medico medico);
        public void Remover(int id);

    }
}