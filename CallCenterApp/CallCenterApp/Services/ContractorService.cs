using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CallCenterApp.Common;
using CallCenterApp.Controllers;
using CallCenterApp.Models;
using System.Windows;

namespace CallCenterApp.Services
{
    public class ContractorService : DbExtensions
    {
        public async Task<List<Contractor>> GetContractors()
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                if(SessionController.User.IsAdmin) return await dbContext.Contractors.AsNoTracking().ToListAsync();
                return await dbContext.Contractors.Where(c=>c.WhoCreated.UserID == SessionController.User.UserID).Include(s => s.WhoCreated).AsNoTracking().ToListAsync();
            }
        }

        public async Task<List<Contractor>> GetContractors(string criteria, string selectedCriteria)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                if (SessionController.User.IsAdmin) return await dbContext.Contractors.Where(c=> selectedCriteria == "NIP" ? c.NIP == criteria : c.CompanyName == criteria).Include(s => s.WhoCreated).AsNoTracking().ToListAsync();
                return await dbContext.Contractors.Where(c => c.WhoCreated.UserID == SessionController.User.UserID && selectedCriteria=="NIP"? c.NIP==criteria : c.CompanyName==criteria).Include(s => s.WhoCreated).AsNoTracking().ToListAsync();
            }
        }

        public async Task<Contractor> GetContractor(int contractorId)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                return await dbContext.Contractors.Where(u => u.ContractorID == contractorId).AsNoTracking().FirstOrDefaultAsync();
            }
        }

        public async Task<Contractor> CreateContractor(Contractor contractor)
        {
            contractor.WhoCreatedUserID = SessionController.User.UserID;
            contractor.WhoCreatedName = SessionController.User.Name;

            if(string.IsNullOrEmpty(contractor.NIP))
            {
                MessageBox.Show("NIP musi być uzupełniony.");
                return contractor;
            }

            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                var checkNip = await dbContext.Contractors.Where(c => c.NIP == contractor.NIP).Select(c => c).AsNoTracking().ToListAsync();
                if (checkNip.Any())
                {
                    MessageBox.Show("NIP musi być unikalny.");
                    return contractor;
                }
                else
                {
                    var Contractor = Insert(contractor, dbContext);
                    await dbContext.SaveChangesAsync();
                    return Contractor;
                }
            }
        }

        public async void UpdateContractor(Contractor contractor)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                Update(contractor, dbContext);
                await dbContext.SaveChangesAsync();
            }
        }

        public async void DeleteContractor(int contractorId)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                Delete(new Contractor { ContractorID = contractorId }, dbContext);
                await dbContext.SaveChangesAsync();
            }
        }

        public async void DeleteContractor(Contractor contractor)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                Delete(new Contractor { ContractorID = contractor.ContractorID }, dbContext);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
