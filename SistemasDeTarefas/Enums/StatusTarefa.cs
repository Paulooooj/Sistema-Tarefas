﻿using System.ComponentModel;

namespace SistemasDeTarefas.Enums
{
    public enum StatusTarefa
    {
        [Description ("A fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAdamento = 2,
        [Description("Concluido")]
        Concluido = 3
    }
}