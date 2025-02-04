namespace ListaTarefaApi.Models
{
    public class Tarefa
    {
        public int tarefaId { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }
        public int TipoTarefaId { get; set; }
        public TipoTarefa? TipoTarefa { get; set; }
    }
}
