using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmaInventory.Models;
using PharmaInventory.DAO;

namespace PharmaInventory.Services
{
    public class PharmaService
    {
        private readonly PharmaRepository _pharmaRepository;
        public PharmaService(PharmaRepository pharmaRepository)
        {
            _pharmaRepository = pharmaRepository;
        }

        public List<PharmaItem> GetAllMed()
        {
            return _pharmaRepository.GetAllMed();
        }
        public PharmaItem GetMedById(int id)
        {
            return _pharmaRepository.GetMedById(id);
        }
        public void AddMed(PharmaItem pharmaItem)
        {
            _pharmaRepository.AddMed(pharmaItem);
        }
        public void DeleteMed(int id)
        {
            _pharmaRepository.DeleteMed(id);
        }
        public void UpdateMed(PharmaItem pharmaItem)
        {
            _pharmaRepository.UpdateMed(pharmaItem);
        }

   
    }
}