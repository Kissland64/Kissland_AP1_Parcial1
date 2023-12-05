using System.Linq.Expressions;
using Kissland_AP1.DAL;
using Kissland_AP1.Models;
using Microsoft.EntityFrameworkCore;

public class IngresosBLL
{
    private readonly Context _context;

    public IngresosBLL(Context context)
    {
        _context = context;
    }

    public bool Existe(int ingresoId)
    {
        return _context.Ingresos.Any(i => i.IngresoId == ingresoId);
    }

    public bool Crear(Ingresos ingreso)
    {
        _context.Ingresos.Add(ingreso);
        int creado = _context.SaveChanges();
        return creado > 0;
    }

    public bool Modificar(Ingresos ingreso)
    {
        _context.Update(ingreso);
        int modificado = _context.SaveChanges();
        return modificado > 0;
    }

    public bool Guardar(Ingresos ingreso)
    {
        if (!Existe(ingreso.IngresoId))
        {
            return Crear(ingreso);
        }
        else
        {
            return Modificar(ingreso);
        }
    }

    public bool Eliminar(Ingresos ingreso)
    {
        _context.Ingresos.Remove(ingreso);
        int eliminado = _context.SaveChanges();
        return eliminado > 0;
    }

    public Ingresos? Buscar(int ingresoId)
    {
        return _context.Ingresos.AsNoTracking().SingleOrDefault(i => i.IngresoId == ingresoId);
    }

    public List<Ingresos> Listar(Expression<Func<Ingresos, bool>> criterio)
    {
        return _context.Ingresos.Where(criterio).AsNoTracking().ToList();
    }
}
