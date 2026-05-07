using CrudDemo.Dtos;
using CrudDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrudDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;

    public UsuariosController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var usuarios = await _usuarioService.GetAllAsync();
        return Ok(usuarios);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var usuario = await _usuarioService.GetByIdAsync(id);

        if (usuario is null)
            return NotFound(new { mensaje = "Usuario no encontrado" });

        return Ok(usuario);
    }

    [HttpPost]
    public async Task<IActionResult> Create(UsuarioCreateDto dto)
    {
        var usuario = await _usuarioService.CreateAsync(dto);

        return CreatedAtAction(nameof(GetById), new { id = usuario.Id }, usuario);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, UsuarioUpdateDto dto)
    {
        var usuario = await _usuarioService.UpdateAsync(id, dto);

        if (usuario is null)
            return NotFound(new { mensaje = "Usuario no encontrado" });

        return Ok(usuario);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var eliminado = await _usuarioService.DeleteAsync(id);

        if (!eliminado)
            return NotFound(new { mensaje = "Usuario no encontrado" });

        return NoContent();
    }
}