namespace Jako.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

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

        public void Clonar()
        {
            try
            {
                using (var context = new Model1())
                {

                    Nodo cl = (Nodo)this.MemberwiseClone();
                    if (cl.Id > 0)
                    {
                        context.Entry(cl).State = EntityState.Added;

                    }
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Listo()
        {
            try
            {
                using (var context = new Model1())
                {
                    if (this.Id > 0)
                    {
                        context.Entry(this).State = EntityState.Added;

                    }
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void FinalizarEn()
        {
            try
            {
                using (var context = new Model1())
                {
                    if (this.Id > 0)
                    {
                        context.Entry(this).State = EntityState.Modified;

                    }
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int LastId()
        {
            var id = 1;
            var nodo = new List<Nodo>();
            try
            {
                using (var context = new Model1())
                {
                    nodo = context.Nodo.ToList();
                    id = nodo.Last().Id;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return id;
        }

    }
}
