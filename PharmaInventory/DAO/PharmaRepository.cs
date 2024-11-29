using PharmaInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmaInventory.Data;
using PharmaInventory.Models;


namespace PharmaInventory.DAO
{
    public class PharmaRepository
    {
        private readonly ApplicationDbContext _context;

        public PharmaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<PharmaItem> GetAllMed()
        {
            return _context.PharmaItem.ToList();
        }

        public PharmaItem GetMedById(int id)
        {
            return _context.PharmaItem.Find(id);
        }

        public void AddMed(PharmaItem pharmaItem)
        {
            _context.PharmaItem.Add(pharmaItem);
            _context.SaveChanges();
        }
        public void UpdateMed(PharmaItem pharmaItem)
        {
            _context.PharmaItem.Update(pharmaItem);
            _context.SaveChanges();
        }
        public void DeleteMed(int id)
        {
            var med = _context.PharmaItem.Find(id);
            if (med != null)
            {
                _context.PharmaItem.Remove(med);
                _context.SaveChanges();
            }
        }
    }
}