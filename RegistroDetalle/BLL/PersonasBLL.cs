using ResgistroDetalle.DAL;
using ResgistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResgistroDetalle.BLL
{
    public class PersonasBLL
    {
        public static bool Guardar(Persona personas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Persona.Add(personas) != null)
                {
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }
        public static bool Modificar(Persona persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                persona = contexto.Persona.Find(persona.PersonaID);
                foreach (var item in persona.Telefonos)
                {
                    if (!persona.Telefonos.Exists(d => d.Id == item.Id))
                        contexto.Entry(item).State = EntityState.Deleted;
                }
                contexto.Entry(persona).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Persona persona = contexto.Persona.Find(id);
                contexto.Entry(persona).State = EntityState.Deleted;
                paso = (contexto.SaveChanges() > 0);

            }
            catch (Exception)
            {
                throw;
            }
            contexto.Dispose();
            return paso;

        }


    }
}

public static Persona Buscar (int id)
{
    Contexto = new Contexto();
    Persona persona = new Persona();
    try
    {
        persona = Contexto.Persona.Find(id);
        persona.DetallesTel.Count();
    }
    catch (Exception)
    { throw; }
    finally
    { Contexto.Dispose(); }
    return persona;
}

public static List<Persona> GetList(Expression<Func<Persona, bool>>persona)
{
    List<Persona> Lista = new List<Persona>();
    Contexto contexto = new Contexto();
    try
    {
        Lista = Contexto.Persona.Where(persona).ToList();
    }
    catch (Exception)
    {
        throw;
    }
    finally
    {
        Contexto.Dispose();
    }
    return Lista;
}
