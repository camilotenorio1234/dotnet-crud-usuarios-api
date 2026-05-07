using CrudDemo.Dtos;
using CrudDemo.Models;

namespace CrudDemo.Services;

public interface IUsuarioService
{
    Task<List<Usuario>> GetAllAsync();
    Task<Usuario?> GetByIdAsync(int id);
    Task<Usuario> CreateAsync(UsuarioCreateDto dto);
    Task<Usuario?> UpdateAsync(int id, UsuarioUpdateDto dto);
    Task<bool> DeleteAsync(int id);
}