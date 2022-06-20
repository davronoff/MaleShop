using MaleShop.Data;
using MaleShop.Domains;
using MaleShop.Repositories.Interface;

namespace MaleShop.Repositories.Repos
{
    public class SiteIndexCollactionsRepo : ISiteIndexCollactionsInterface
    {
        private readonly ApplicationDbContext dbContext;

        public SiteIndexCollactionsRepo(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<SiteIndexCollactions> AddSiteIndexCollaction(SiteIndexCollactions siteIndexCollaction)
        {
            dbContext.SiteIndexCollactions.Add(siteIndexCollaction);
            dbContext.SaveChanges();
            return Task.FromResult(siteIndexCollaction);
        }

        public Task DeleteSiteIndexCollactions(Guid id)
        {
            var item = dbContext.SiteIndexCollactions.FirstOrDefault(p => p.Id == id);
            dbContext.SiteIndexCollactions.Remove(item);
            dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public Task<SiteIndexCollactions> GetIndexCollaction(Guid id) =>
            Task.FromResult(dbContext.SiteIndexCollactions.FirstOrDefault(p => p.Id == id));

        public Task<List<SiteIndexCollactions>> GetSiteIndexCollactions() =>
            Task.FromResult(dbContext.SiteIndexCollactions.ToList());
        public Task<SiteIndexCollactions> UpdateSiteIndexCollactions(SiteIndexCollactions siteIndexCollaction)
        {
            dbContext.SiteIndexCollactions.Update(siteIndexCollaction);
            dbContext.SaveChanges();
            return Task.FromResult(siteIndexCollaction);
        }
    }
}
