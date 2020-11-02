using System;
using System.Collections.Generic;
using System.Text;

namespace MoodPlay.Models
{
    class Agenda
    {
        protected User Owner { get; set; }
        public List<Tarefa> tarefas = new List<Tarefa>();
    }
}
