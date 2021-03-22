namespace Jako.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Spatial;
    using Jako.Models;

    [Table("Nodo")]
    public partial class Nodo
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string pregunta { get; set; }

        public int? padre { get; set; }

        public int? hizq { get; set; }

        public int? hder { get; set; }
        public List<Nodo> Listar()
        {
            var nodo = new List<Nodo>();
            try
            {
                using (var context = new Model1())
                {
                    nodo = context.Nodo.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return nodo;
        }
        public Nodo ObtenerP(int id)
        {
            var preg = new Nodo();
            try
            {
                using (var context = new Model1())
                {
                    preg = context.Nodo
                                  .Where(x => x.Id == id)
                                  .Single();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return preg;

        }

    }
}
