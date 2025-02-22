﻿using OurHeroApiwithcodefirstapproach.Model;

namespace OurHeroApiwithcodefirstapproach.Services
{
    public interface IOurHeroService
    {
        Task<List<OurHeros>> GetAllHeros(bool? isActive);
        Task<OurHeros?> GetHerosByID(int id);
        Task<OurHeros?> AddOurHero(AddUpdateOurHero obj);
        Task<OurHeros?> UpdateOurHero(int id, AddUpdateOurHero obj);
        Task<bool> DeleteHerosByID(int id);

    }
}
