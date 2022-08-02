using System;

namespace App1_Mimica.Model
{
    public class Partida
    {
        public Grupo Grupo1 { get; set; }
        public Grupo Grupo2 { get; set; }
        public string Nivel { get; set; }
        public short Tempo { get; set; }
        public byte Rodadas { get; set; }
    }
}
