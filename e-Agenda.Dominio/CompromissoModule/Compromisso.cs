﻿using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.Shared;
using System;
using System.Collections.Generic;

namespace eAgenda.Dominio.CompromissoModule
{
    public class Compromisso : EntidadeBase, IEquatable<Compromisso>
    {        
        public Compromisso(string assunto, string local, string link, DateTime data,
            TimeSpan horaInicio, TimeSpan horaFim, Contato contato)
        {
            Assunto = assunto;
            Local = local;
            Link = link;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaFim;
            Contato = contato;
        }

        public string Assunto { get; set; }
        public string Local { get; set; }
        public string Link { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }
        public Contato Contato { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Compromisso);
        }

        public bool Equals(Compromisso other)
        {
            return other != null
                && Id == other.Id
                && Assunto == other.Assunto
                && Local == other.Local
                && Link == other.Link
                && Data == other.Data
                && HoraInicio.Equals(other.HoraInicio)
                && HoraTermino.Equals(other.HoraTermino)
                && EqualityComparer<Contato>.Default.Equals(Contato, other.Contato);
        }

        public override int GetHashCode()
        {
            int hashCode = 691503132;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Assunto);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Local);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Link);
            hashCode = hashCode * -1521134295 + Data.GetHashCode();
            hashCode = hashCode * -1521134295 + HoraInicio.GetHashCode();
            hashCode = hashCode * -1521134295 + HoraTermino.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Contato>.Default.GetHashCode(Contato);
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Assunto))
                resultadoValidacao = "O campo Assunto é obrigatório";

            if (Data == DateTime.MinValue)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Data é obrigatório";

            if ((HoraInicio == TimeSpan.MinValue) && (HoraTermino == TimeSpan.MinValue))
            {
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "Hora Inicio e Hora Término Inválidas";    
            }
            else if (HoraInicio == TimeSpan.MinValue)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Hora Início é obrigatório";

            else if (HoraTermino == TimeSpan.MinValue)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Hora Término é obrigatório";
  
            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }


    }
}
