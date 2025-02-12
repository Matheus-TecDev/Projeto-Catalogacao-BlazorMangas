using BlazorMangas.Models.DTOs;

namespace BlazorMangas.Services.Api
{
    public interface ICategoriaService
    {
        Task<List<CategoriaDTO>> GetCategorias();
        Task<CategoriaDTO> GetCategoria(int id);

        /*
        Task CreateCategoria(CategoriaDTO categoriaDTO);
        Task UpdateCategoria(CategoriaDTO categoriaDTO);
        Task DeleteCategoria(int id);
        Task<IEnumerable<CategoriaDTO>> LocalizaCategoria(string criterio);
        */
    }
}
