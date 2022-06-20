using MaleShop.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaleShop.Repositories.Interface
{
    public interface ISiteIndexCollactionsInterface
    {
        Task<List<SiteIndexCollactions>> GetSiteIndexCollactions();
        Task<SiteIndexCollactions> GetIndexCollaction(Guid id);
        Task<SiteIndexCollactions> AddSiteIndexCollaction(SiteIndexCollactions siteIndexCollaction);
        Task<SiteIndexCollactions> UpdateSiteIndexCollactions(SiteIndexCollactions siteIndexCollaction);
        Task DeleteSiteIndexCollactions(Guid id);
    }
}
