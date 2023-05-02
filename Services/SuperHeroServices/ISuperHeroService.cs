namespace SuperHeroApiDotNet7.Services.SuperHeroServices
{
    public interface ISuperHeroService
    {
        Task<List<SuperHero>> GetAllHeros();
        Task<SuperHero?>GetHero(int id);
        Task<List<SuperHero>>AddHero(SuperHero hero);
        Task<List<SuperHero>?> UpdateHero(int id, SuperHero request);
        Task<List<SuperHero>?> DeleteHero(int id);
    }
}
