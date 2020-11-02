using System;
using System.Data;
using System.Collections.Generic;

namespace MoodPlay.Models
{
    public class Tarefa
    {
        //Descrição de tarefa
        public string Description { get; set; }
        //Tags das tarefas

        public Enum Tag { get; set; }
        public enum Tags
        {
            Estudando, Trabalhando, Arrumando, Deboismo,
            Banhando, Estrada, Ares, Aguas,
            Trilhos, Trilha, Malhando, Praieiro,
            Campo, Urbano, Alimentando
        }
        //Horário inicial das tarefas
        public DateTime HInicio { get; set; }
        //Término das tarefas
        public DateTime HFinal { get; set; }
    }

    
}
