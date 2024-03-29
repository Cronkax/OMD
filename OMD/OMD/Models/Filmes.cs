﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OMD.Models{

    public class Filmes{

        public int ID { get; set; }

        public string Titulo { get; set; }

        public string Imagem { get; set; }

        public string Trailer { get; set; }

        public int Lancamento { get; set; }

        public string Genero { get; set; }

        public int Duracao { get; set; }


        [ForeignKey("Estudio")]
        public int EstudioFK { get; set; }
        public Estudios Estudio { get; set; }


        public virtual ICollection<AtoresFilmes> ListaDePersonagens { get; set; }
    }
}