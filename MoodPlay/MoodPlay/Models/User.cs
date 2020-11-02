using System;
using System.Collections.Generic;
using System.Text;

namespace MoodPlay.Models
{
    class User
    {
        //Id do usuário
        public int Id { get; set; }
        //Apelido do usuário
        public string Username { get; set; }
        //Email do usuário
        public string Email { get; set; }
        //Número do usuário
        public int Phone { get; set; }
        //Senha do usuário
        protected string Password { get; set; }
        //Agenda do usuário
        protected Agenda MyAgenda { get; set; }

        //Criar tarefa...
        public void CreateTask(string _description, Enum _tag, DateTime _HInicio, DateTime _HFinal)
        {
            //Cria uma tarefa;
            Tarefa _tarefa = new Tarefa();

            //Parâmetros serão os atributos da tarefa:
            _description = _tarefa.Description;
            _tag = _tarefa.Tag;
            _HInicio = _tarefa.HInicio;
            _HFinal = _tarefa.HFinal;

            //Adiciona A tarefa criada acima Na lista de tarefas localizada na agenda;
            MyAgenda.tarefas.Add(_tarefa);
        }

        
    }
}
