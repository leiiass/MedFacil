using MedFacil.Dominio.Enumeradores;
using System;

namespace MedFacil.Dominio.Modelos
{
    public class Medico
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public int CRM { get; set; }
        public string EstadoCRM { get; set; }
        public EspecialidadeMedica Especialidade { get; set; }
        public TimeSpan HorarioInicio { get; set; }
        public TimeSpan HorarioFim { get; set; }
        public DiasDaSemana DiasDeAtendimento { get; set; }
    }
}
