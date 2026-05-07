using CrudDemo.Data;
using CrudDemo.Dtos;
using CrudDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudDemo.Services;

public class UsuarioService : IUsuarioService
{
    private readonly AppDbContext _context;

    public UsuarioService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Usuario>> GetAllAsync()
    {
        return await _context.Usuarios.ToListAsync();
    }

    public async Task<Usuario?> GetByIdAsync(int id)
    {
        return await _context.Usuarios.FindAsync(id);
    }

    public async Task<Usuario> CreateAsync(UsuarioCreateDto dto)
    {
        var usuario = new Usuario
        {
            Nombre = dto.Nombre,
            Email = dto.Email
        };

        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();

        return usuario;
    }

    public async Task<Usuario?> UpdateAsync(int id, UsuarioUpdateDto dto)
    {
        var usuario = await _context.Usuarios.FindAsync(id);

        if (usuario is null)
            return null;

        usuario.Nombre = dto.Nombre;
        usuario.Email = dto.Email;

        await _context.SaveChangesAsync();

        return usuario;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var usuario = await _context.Usuarios.FindAsync(id);

        if (usuario is null)
            return false;

        _context.Usuarios.Remove(usuario);
        await _context.SaveChangesAsync();

        return true;
    }
}